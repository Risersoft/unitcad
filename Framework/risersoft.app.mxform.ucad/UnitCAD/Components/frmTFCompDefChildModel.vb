Imports risersoft.shared
Imports System.Runtime.Serialization

<DataContract>
Public Class frmTFCompDefChildModel
    Inherits clsFormDataModel
    Dim myVueActPack As clsViewModel
    Dim myTFCD As New clsTFCDModel(myContext), SqlAct As String
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("bom")
        myVueActPack = Me.GetViewModel("ActPack")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String = "Select tfCompDefShotID,ShotCode,tfCompDefId from tfCompDefShot order by ShotCode"
        Me.AddLookupField("tfCompDefShotID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "ShotCode").TableName)

        Dim vlist As New clsValueList
        vlist = myTFCD.myTFCompDef.myTFCDPrm.dicDataType.ToVList
        vlist.Add(5, "Not Defined")
        Me.ValueLists.Add("DataType", vlist)
        Me.AddLookupField("DataType", "DataType")
        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sqlForm = "select * from TFCompDefDetBOM where TFCompDefDetBOMID=" & myUtils.cValTN(prepIDX)
        Me.InitData(sqlForm, "tfCompDefId", oView, prepMode, prepIDX, strXML, "TFCompDefDetBOMID", "newname")

        Dim str1 As String = "tfCompDefId<>" & myUtils.cValTN(myRow("tfCompDefId"))
        str1 = myUtils.CombineWhere(False, str1, myTFCD.myTFCompDef.ComponentFilter(Me.Name, myUtils.cStrTN(Me.vBag("CompType"))))
        Dim Sql As String = "select tfcompdefid,CompDefCode,Descrip from tfcompdef where " & str1 & " order by compdefcode"
        Me.AddLookupField("ChildCompDefID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "CompDef").TableName)

        myTFCD.SetupBOMParamView(myView, "tfcompdefdetbomid", myUtils.cValTN(frmIDX))

        myVueActPack.MainGrid.BindGridData(myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select tfcompdefactpackid,tfcompdefid,Descrip,EvalCondition from TFCompDefActPack where parentactpackid is null and tfCompDefId <> " & myUtils.cValTN(Me.myRow("TFCompDefID"))), 0)
        myVueActPack.Mode = EnumViewMode.acSelectM : myVueActPack.MultiSelect = True
        myVueActPack.MainGrid.QuickConf("", True, "1-1", True, "Select Action Packs")
        SqlAct = "select * from tfcompdefactpack where parentactpackid in (select tfcompdefactpackid from tfcompdefactpack where tfCompDefId=" & myUtils.cValTN(myRow("childcompdefid")) & ") and tfCompDefId= " & myUtils.cValTN(Me.myRow("TFCompDefID"))
        myContext.Data.TickIncludedCols2(myVueActPack.MainGrid.myDS.Tables(0), sqlact, "tfcompdefactpackid", "parentactpackid", , myVueActPack.MainGrid.myDV.RowFilter)

        If Me.CopyIDX.Trim.Length > 0 Then
            Sql = "select ParamCode,Formula from TFCompDefBOMParam where tfCompDefDetBomId = " & CopyIDX & ""
            Me.AddDataSet("TFCompDefBOMParam", Sql)
        End If

        Dim dt2 As DataTable = myTFCD.GetDataParamsComp(Me.Name, myUtils.cStrTN(Me.vBag("CompType")), myUtils.cValTN(Me.vBag("PIDUnitID")))
        Me.AddLookupField("paramcode", myUtils.AddTable(Me.dsCombo, dt2, "params").TableName)
        FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cValTN(Me.myRow("ChildCompDefID")) = 0 AndAlso myUtils.cStrTN(Me.myRow("CompDefCodeFormula")).Trim.Length = 0 Then Me.AddError("ChildCompDefID", "Select Child")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim dt As DataTable, nr, rr() As DataRow
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmIDX = myRow("tfCompDefDetBomId")
                frmMode = EnumfrmMode.acEditM

                myView.MainGrid.SaveChanges(, "tfCompDefDetBomId=" & frmIDX)
                dt = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, SqlAct).Tables(0)
                dt.Columns.Add("incl", GetType(Boolean))
                myUtils.ChangeAll(dt.Select, "incl=0")
                For Each r1 As DataRow In myVueActPack.MainGrid.myDS.Tables(0).Select(myUtils.CombineWhere(False, myVueActPack.MainGrid.myDV.RowFilter, "sysincl=1"))
                    rr = dt.Select("parentactpackid=" & r1("tfcompdefactpackid"))
                    If rr.Length = 0 Then
                        nr = dt.NewRow
                        nr("parentactpackid") = r1("tfcompdefactpackid")
                        dt.Rows.Add(nr)
                    Else
                        nr = rr(0)
                    End If
                    nr("incl") = True
                    nr("TFCompDefID") = myUtils.cValTN(Me.myRow("TFCompDefID"))
                Next
                myUtils.DeleteRows(dt.Select("incl=0"))
                myContext.Provider.objSQLHelper.SaveResults(dt, SqlAct)

                VSave = True
                myContext.Provider.dbConn.CommitTransaction()
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
