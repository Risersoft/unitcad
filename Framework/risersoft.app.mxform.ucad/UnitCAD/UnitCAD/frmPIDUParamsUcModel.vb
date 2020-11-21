Imports risersoft.app.mxengg
Imports risersoft.shared
Imports System.Runtime.Serialization

<DataContract>
Public Class frmPIDUParamsUcModel
    Inherits clsFormDataModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Params")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql, str1 As String, dt As DataTable


    End Sub

    Public Overrides Function PrepForm(ByVal oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            sql = "select * from deslistpidunittot() where pidunitid = " & prepIDX
            Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

            myView.MainGrid.BindGridData(Me.LoadParams(frmIDX).DataSet, 0)
            myView.MainGrid.myDS.Tables(0).PrimaryKey = New DataColumn() {myView.MainGrid.myDS.Tables(0).Columns("desparamid")}
            myView.MainGrid.myDV.RowFilter = myContext.Params.ParamGroupFilter(myUtils.cStrTN(myRow("paramgrouppsv")))
            myView.MainGrid.QuickConf("", True, "1-2-1")
            Dim str1 As String = "<BAND INDEX=""0"" ALLOWINSERT=""FALSE"" ALLOWDELETE=""FALSE""><COL KEY=""Paramvalue""/></BAND>"""
            myView.MainGrid.PrepEdit(str1, EnumEditType.acEditOnly)

            Dim objDef As New clsTFCompDefBase(myContext)
            Dim strf1 = myUtils.CombineWhere(False, objDef.ComponentFilter(Me.Name, ""), "0=0")
            Dim strf2 = "comptype in (select comptype from tfcompdef where tfcompdefid = (select startupdefid from pidunit where pidunitid=" & frmIDX & "))"
            str1 = myUtils.CombineWhereOR(False, strf1, strf2)
            sql = "select tfcompdefid, compdefcode, Descrip,comptype from tfcompdef where " & str1 & " order by compdefcode"
            Me.AddLookupField("StartupDefID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "compdef").TableName)

            Me.FormPrepared = True


        End If
        Return Me.FormPrepared
    End Function
    Public Overrides Function Validate() As Boolean
        Me.InitError()
        Return Me.CanSave
    End Function
    Protected Friend Function LoadParams(pidunitid As Integer) As DataTable
        Dim Sql As String = "Select * from DesListPidUParams() where IsDesPidUParam=1 and PidUnitID=" & frmIDX
        Dim dt As DataTable = myContext.Params.ApplyTransDesTableRI(myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0))
        Return dt
    End Function
    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                If Me.SelectedRow("startupdefid") Is Nothing Then myRow("startupcomptype") = "" Else myRow("startupcomptype") = Me.SelectedRow("startupdefid")("comptype")
                Dim sqlSave As String = "select pidunitid,StartupDefID,startupcomptype,templatefilename from pidunit where pidunitid =0"
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlSave)

                Dim dtp2 As DataTable = myContext.Params.PrepParamDataTable(myView.MainGrid.myDS.Tables(0))
                myUtils.ChangeAll(dtp2.Select, "PidUnitID=" & frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(dtp2, "Select PidUParamID,DesParamID,PidUnitID,ParamValue from PidUParams")
                myContext.Provider.dbConn.CommitTransaction()
                myView.MainGrid.BindGridData(Me.LoadParams(frmIDX).DataSet)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function

End Class
