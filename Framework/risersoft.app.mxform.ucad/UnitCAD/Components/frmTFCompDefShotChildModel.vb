Imports risersoft.shared
Imports System.Runtime.Serialization

<DataContract>
Public Class frmTFCompDefShotChildModel
    Inherits clsFormDataModel
    Dim myTFCD As New clsTFCDModel(myContext)
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("BOMParam")
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
        Me.FormPrepared = False

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sqlForm = "select * from TFCompDefShotChild where TFCompDefShotChildID=" & myUtils.cValTN(prepIDX)
        Me.InitData(sqlForm, "TfCompDefShotId", oView, prepMode, prepIDX, strXML, "TFCompDefShotChildid")

        Dim Sql As String = "Select * from TfCompDefShot where TfCompDefShotId = " & myUtils.cValTN(myRow("TfCompDefShotId")) & ""
        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)

        Dim str1 As String = "TfCompDefId<>" & myUtils.cValTN(dt.Rows(0)("TfCompDefId"))
        str1 = myUtils.CombineWhere(False, str1, myTFCD.myTFCompDef.ComponentFilter(Me.Name, myUtils.cStrTN(dt.Rows(0)("shottype"))))
        Sql = "select tfcompdefid,CompDefCode,Descrip from tfcompdef where " & str1 & " order by compdefcode"
        Me.AddLookupField("ChildCompDefID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "CompDef").TableName)

        myTFCD.SetupBOMParamView(myView, "TFCompDefShotChildID", myUtils.cValTN(frmIDX))

        If Me.CopyIDX.Trim.Length > 0 Then
            Sql = "select ParamCode,Formula from TFCompDefBOMParam where TFCompDefShotChildid=" & Me.CopyIDX
            Me.AddDataSet("TFCompDefBOMParam", Sql)
        End If

        Dim dt2 As DataTable = myTFCD.GetDataParamsComp(Me.Name, myUtils.cStrTN(dt.Rows(0)("shottype")), myUtils.cValTN(Me.vBag("PIDUnitID")))
        Me.AddLookupField("paramcode", myUtils.AddTable(Me.dsCombo, dt2, "params").TableName)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If Me.SelectedRow("ChildCompDefID") Is Nothing AndAlso myUtils.cStrTN(myRow("CompDefCodeFormula")).Trim.Length = 0 Then Me.AddError("ChildCompDefID", "Select Child")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmIDX = myRow("TFCompDefShotChildid")
                frmMode = EnumfrmMode.acEditM

                myView.MainGrid.SaveChanges(, "TFCompDefShotChildid=" & frmIDX)
                VSave = True
                myContext.Provider.dbConn.CommitTransaction()
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
