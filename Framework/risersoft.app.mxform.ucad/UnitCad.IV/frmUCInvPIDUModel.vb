Imports risersoft.shared
Imports System.Runtime.Serialization
Imports risersoft.app.mxent

<DataContract>
Public Class frmUCInvPIDUModel
    Inherits clsFormDataModel
    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim oRet As clsProcOutput = Me.GetRowLock(prepMode, "pidunitid", prepIDX)
        If prepMode = EnumfrmMode.acEditM AndAlso oRet.Success Then
            Dim Sql As String = "select * from deslistpidunittot() where pidunitid=" & prepIDX
            Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)
            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function
    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim oView As New clsViewModel(vwState, myContext)
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "bomtank"
                    Dim PIDUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@pidunitid", Params))
                    Dim str1 As String = "<FILTER KEY=""pidu""><VALUE VALUE1=""" & PIDUnitID & """ /></FILTER><MODROW><HIDECOLS>Portion</HIDECOLS></MODROW>"
                    myContext.Provider.ProcessTag(oView, "<VIEW KEY=""listtfbomtank"">" & str1 & "</VIEW>")
                Case "compref"
                    Dim PIDUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@pidunitid", Params))
                    Dim str1 As String = "<FILTER KEY=""pidu""><VALUE VALUE1=""" & PIDUnitID & """ /></FILTER><MODROW><HIDECOLS>Portion</HIDECOLS></MODROW>"
                    myContext.Provider.ProcessTag(oView, "<VIEW KEY=""listtfcompref"">" & str1 & "</VIEW>")
                    oView.MainGrid.BindGridData(oView.MainGrid.myDS, 0)
                    Dim oProc As New clsListGeneratorBase(myContext)
                    oProc.SetChildFilter(oView.MainGrid.myDV.Table, Nothing, "ChildRefIDs", "pCompRefID", "TFDesCompRefID")
                    oView.MainGrid.myDV.Table.AcceptChanges()
            End Select
        End If
        Return oView
    End Function
    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "addchild"
                    Dim TFDesCompRefID As Guid = Guid.Parse(myContext.SQL.ParamValue("@tfdescomprefid", Params))
                    Dim PIDUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@pidunitid", Params))
                    Dim dic As New clsCollecString(Of String)
                    dic.Add("ref", "select * From tfdescompref where pidunitid = " & PIDUnitID)
                    dic.Add("def", "select tfcompdefid, compdefcode, descrip From tfcompdef where comptype='ASY'")
                    oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
                    Dim rr() As DataRow = oRet.Data.Tables("ref").Select("Tfdescomprefid='" & TFDesCompRefID.ToString & "'"), DeleteList As New List(Of DataRow)
                    While rr.Length > 0
                        myUtils.RemoveRows(oRet.Data.Tables("def").Select("tfcompdefid=" & myUtils.cValTN(rr(0)("tfcompdefid"))))
                        rr = oRet.Data.Tables("ref").Select("Tfdescomprefid='" & myUtils.cStrTN(rr(0)("pcomprefid")) & "'")
                    End While
            End Select
        End If
        Return oRet
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, ID As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "compfile"
                Dim dic As New clsCollecString(Of String)
                dic.Add("compdef", "select * from tfcompdef where len(rtrim(ltrim(isnull(compfilename,''))))>0")
                dic.Add("compdefbom", "select * from tfcompdefdetbom where len(rtrim(ltrim(isnull(compfilename,''))))>0")
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
        End Select
        Return oRet
    End Function
    Public Overrides Function GenerateDataOutput(dataKey As String, ds As DataSet, ID As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "compfile"
                Dim dic As New clsCollecString(Of String)
                dic.Add("compdef", "select tfcompdefid,compfilehash,compfilemodified from tfcompdef where 0=1")
                dic.Add("compdefbom", "select tfcompdefdetbomid,compfilehash,compfilemodified from tfcompdefdetbom where 0=1")
                For Each str1 As String In dic.Keys
                    If ds.Tables.Contains(str1) Then
                        myContext.Provider.objSQLHelper.SaveResults(ds.Tables(str1), dic(str1))
                    End If
                Next
        End Select
        Return oRet
    End Function
End Class
