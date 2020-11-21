Imports risersoft.shared
Imports System.Runtime.Serialization

<DataContract>
Public Class frmTFCompDefShotModel
    Inherits clsFormDataModel
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
        Dim sql As String = "select * from TFCompDefshot where TFCompDefshotID=" & myUtils.cValTN(prepIDX)
        Me.InitData(sql, "tfcompdefid", oView, prepMode, prepIDX, strXML, "tfcompdefshotid")

        myView.MainGrid.BindGridData(GenerateData("shotchild", frmIDX), 0)
        myView.MainGrid.QuickConf("", True, "1-2-2-4", True)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "shotchild"
                Dim Sql As String = "select TFCompDefShotChildid,sortindex,tfcompdefshotid,ChildCompDefID,ChildCompDefID as DefID2,QtyFormula, Remarks from TFCompDefShotChild where tfcompdefshotid = " & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
        End Select
        Return oRet.Data
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("ShotCode")).Trim.Length = 0 Then Me.AddError("ShotCode", "Enter Code")
        If myUtils.cStrTN(myRow("ShotType")).Trim.Length = 0 Then Me.AddError("ShotType", "Enter Type")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                frmIDX = myRow("tfcompdefshotid")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.objSQLHelper.SaveResults(myView.MainGrid.myDS.Tables(0), "select TFCompDefShotChildid,sortindex from TFCompDefShotChild where TFCompDefShotChildid=0")
                VSave = True
                myContext.Provider.dbConn.CommitTransaction()
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "shotchild"
                oRet.Data = GenerateData("shotchild", frmIDX)
            Case "deldet"
                Dim Sql As String = "delete from tfcompdefshotchild where tfcompdefshotchildid= " & frmIDX & "; delete from tfcompdefbomparam where tfcompdefshotchildid is not null and tfcompdefshotchildid not in (select tfcompdefshotchildid from tfcompdefshotchild)"
                myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, Sql)
        End Select
        Return oRet
    End Function
End Class
