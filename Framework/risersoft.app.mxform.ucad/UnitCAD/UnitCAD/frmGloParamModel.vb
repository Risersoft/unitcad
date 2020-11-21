Imports risersoft.shared
Imports System.Runtime.Serialization
Imports risersoft.app.mxengg

<DataContract>
Public Class frmGloParamModel
    Inherits clsFormDataModel
    Dim myTFCD As New clsTFCDModel(myContext)
    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String = "select destableid,tablecode,tablename from destables order by tablecode"
        Me.AddLookupField("RIDestableID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "destab").TableName)

        Sql = "select destablecolid,ColumnName, destableid from destablecols order by columnname"
        Me.AddLookupField("cmb_DesTableColID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "tablecol").TableName)

        Dim vlist1 As New clsValueList
        Dim dic As clsCollection(Of Integer, String) = myContext.Params.dicDataType
        For Each i In dic.Keys
            vlist1.Add(i, dic(i))
        Next
        Me.ValueLists.Add("DataType", vlist1)
        Me.AddLookupField("DataType", "DataType")
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String, dt As New DataTable
        Me.FormPrepared = False
        Dim oRet As clsProcOutput = Me.GetRowLock(prepMode, "desparamid", prepIDX)
        If oRet.Success Then
            If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
            sql = "select * from desparams where desparamid = " & prepIDX
            Me.InitData(sql, "", oView, prepMode, prepIDX, strXML, "desparamid", "paramcode")
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        Dim oRet As clsProcOutput = myIntent.ValidateIdentifier(myUtils.cStrTN(myRow("ParamCode")), False)
        If Not oRet.Success Then Me.AddError("ParamCode", oRet.Message)
        If myUtils.cStrTN(myRow("ParamName")).Trim.Length = 0 Then Me.AddError("ParamName", "Enter Name")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                Me.ChangeModeGetLock("desparamid")
                VSave = True
            Catch e As Exception
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
