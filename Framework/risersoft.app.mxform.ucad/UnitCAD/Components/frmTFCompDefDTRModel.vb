Imports risersoft.shared
Imports System.Runtime.Serialization

<DataContract>
Public Class frmTFCompDefDTRModel
    Inherits clsFormDataModel
    Dim mvParam As clsViewModel, myTFCD As New clsTFCDModel(myContext)
    Protected Overrides Sub InitViews()
        mvParam = Me.GetViewModel("Param")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim vlist As New clsValueList
        vlist = myTFCD.myTFCompDef.myTFCDPrm.dicDataType.ToVList
        vlist.Add(5, "Not Defined")
        Me.ValueLists.Add("DataType", vlist)
        Me.AddLookupField("DataType", "DataType")
        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim Sql As String
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sqlForm = "select * from TFCompDefDetBOM where TFCompDefDetBOMID=" & myUtils.cValTN(prepIDX)
        Me.InitData(sqlForm, "tfcompdefid", oView, prepMode, prepIDX, strXML)

        If frmMode = EnumfrmMode.acAddM Then
            Dim vBag2 As clsConf = myContext.Data.VarBag(Me.vBag, pView.ContextRow, Split("destablerowid", ","))
            If (Not vBag2 Is Nothing) AndAlso vBag2.Contains("destablerowid") Then myRow("destablerowid") = vBag2("destablerowid")
        End If

        If myUtils.cValTN(myRow("destablerowid")) > 0 Then
            Sql = "select tfcompdefbomparamid,tfcompdefdetbomid,ParamCode,Formula from TFCompDefBOMParam where tfcompdefdetbomid=" & myUtils.cValTN(frmIDX)
            mvParam.MainGrid.QuickConf(Sql, True, "1-1", True, "")
            mvParam.MainGrid.PrepEdit("<BAND INDEX=""0"" TABLE =""tfcompdefbomparam"" IDFIELD=""tfcompdefbomparamid"" ><COL KEY=""tfcompdefdetbomid,ParamCode,Formula""/></BAND>", EnumEditType.acCommandOnly)

            Sql = "select tfcompdefid,CompDefCode,Descrip from tfcompdef where tfcompdefid<>" & myUtils.cValTN(myRow("tfcompdefid")) & " order by compdefcode"
            Me.AddLookupField("ChildCompDefID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "CompDef").TableName)
            Me.FormPrepared = True
        End If


        Dim dt2 As DataTable = myTFCD.GetDataParamsComp(Me.Name, myUtils.cStrTN(Me.vBag("CompType")), myUtils.cValTN(Me.vBag("PIDUnitID")))
        Me.AddLookupField("paramcode", myUtils.AddTable(Me.dsCombo, dt2, "params").TableName)
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmIDX = myRow("tfcompdefdetbomid")
                frmMode = EnumfrmMode.acEditM
                mvParam.MainGrid.SaveChanges(, "tfcompdefdetbomid=" & frmIDX)
                VSave = True
                myContext.Provider.dbConn.CommitTransaction()
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
