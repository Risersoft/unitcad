Imports risersoft.shared
Imports System.Runtime.Serialization

<DataContract>
Public Class frmTFCompDefActPackModel
    Inherits clsFormDataModel
    Dim myTFCD As New clsTFCDModel(myContext)
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("shotchild")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Me.IgnorefRow = True
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim Sql As String = "select * from TFCompDefactpack where TFCompDefactpackID=" & myUtils.cValTN(prepIDX)
        Me.InitData(Sql, "TFCompDefID", oView, prepMode, prepIDX, strXML, "tfcompdefactpackid")

        If myUtils.cValTN(myRow("parentactpackid")) = 0 Then
            Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select * from TFCompDef where TFCompDefID=" & myUtils.cValTN(myRow("TfCompDefId"))).Tables(0)
            myTFCD.SetupActionView(myView, myUtils.cStrTN(dt.Rows(0)("comptype")), myUtils.cValTN(frmIDX))
            If Me.CopyIDX > 0 Then
                Sql = "select * from TFCompDefAction where tfcompdefactpackid=" & Me.CopyIDX
                Me.AddDataSet("TFCompDefAction", Sql)
            End If
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("Descrip")).Trim.Length = 0 Then Me.AddError("Descrip", "Enter Description")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmIDX = myRow("tfcompdefactpackid")
                frmMode = EnumfrmMode.acEditM

                myView.MainGrid.SaveChanges(, "tfcompdefactpackid = " & frmIDX)
                VSave = True
                myContext.Provider.dbConn.CommitTransaction()
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
