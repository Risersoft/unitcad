Imports Infragistics.Win.UltraWinTabControl
Imports risersoft.app.mxform.eto

Public Class frmUCInvPIDU
    Inherits frmWizMax
    Public fp As frmPIDUParamsUc, fc As frmUC3Out

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        Dim arrDel As New ArrayList, uTab As UltraTab

        Me.SuspendLayout()
        myTables.LoadDataSet(False)

        fp = New frmPIDUParamsUc
        fp.cmb_Startupdefid.ReadOnly = True
        uTab = fp.AddtoTab(Me.UltraTabControl1, "params", True)
        uTab.Text = "Work Order Parameters"

        fc = New frmUC3Out
        uTab = fc.AddtoTab(Me.UltraTabControl1, "cadout", True)
        uTab.Text = "CAD Maker"

        Me.InitTabs(Me.UltraTabControl1, "pidunitid", "")
        Me.InitTabKey = "params"
        Me.arrmode.AddRange(New String() {"params"})

        Me.PanelBtn.Height = Me.Panel4.Height
        Me.ResumeLayout()
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Me.strT = "tf"
        If frmMode = EnumfrmMode.acEditM AndAlso Me.UltraTabControl1.Tabs.Count > 0 Then
            Dim objModel As frmUCInvPIDUModel = Me.InitData("frmUCInvPIDUModel", oview, prepMode, prepIdx, strXML)
            If Me.BindModel(objModel, oview) Then
                Me.Prepmode()
                Me.FormPrepared = True
            End If
        Else
            MsgBox("Cannot Open!", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
        Me.UltraTabControl1.Style = UltraTabControlStyle.Wizard
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Return True
        End If
        Return False
    End Function

    Protected Overrides Sub OnMakeFTFPanel(vsbl As Boolean)
        Me.Panel1.Visible = vsbl
        MyBase.OnMakeFTFPanel(vsbl)
    End Sub
End Class



'Inherits frmWizMax
'Public fp As frmPIDUParams, fc As frmUC3Out
'Public Sub New()
'    MyBase.New()

'    'This call is required by the Windows Form Designer.
'    InitializeComponent()
'    'Add any initialization after the InitializeComponent() call
'    Me.InitForm()
'End Sub
'Public Sub InitForm()
'    Dim obj As Object, arrDel As New ArrayList, uTab As UltraTab

'    Me.SuspendLayout()
'    myWinTables.LoadDataSet(False)

'    fp = New frmPIDUParams
'    fp.cmb_Startupdefid.ReadOnly = True
'    uTab = fp.AddtoTab(Me.UltraTabControl1, "params", True)
'    uTab.Text = "Work Order Parameters"

'    fc = New frmUC3Out
'    uTab = fc.AddtoTab(Me.UltraTabControl1, "cadout", True)
'    uTab.Text = "CAD Maker"

'    Me.InitTabs(Me.UltraTabControl1, "pidunitid", "")
'    Me.InitTabKey = "params"
'    Me.arrmode.AddRange(New String() {"params"})
'    myView.SetGrid(, Me)
'    Me.PanelBtn.Height = Me.Panel4.Height   'so wished Mr Anand Pujari Autodesk
'    'myXLBasic.QuitExcel()
'    Me.ResumeLayout()

'End Sub


'Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
'    Dim sql, str1 As String, dt1, dt2, dt3, dt4 As DataTable, ds As DataSet, groupindex As Integer = 0
'    Dim r1, r2, rr(), nr As DataRow, cont As Boolean = False, dtVars As DataTable
'    Dim uTab As ut.UltraTab, dt As DataTable, f As frmMax

'    Me.FormPrepared = False
'    Me.strT = "tf"
'    If frmMode = EnumfrmMode.acEditM AndAlso Me.UltraTabControl1.Tabs.Count > 0 Then
'        If Me.GetRowLock(prepMode, "pidunitid", prepIdx, True) Then
'            sql = "select * from deslistpidunittot() where pidunitid=" & prepIdx
'            Me.InitData(sql, "", oview, prepMode, prepIdx, strXML)

'            Me.Prepmode()


'        End If
'    Else
'        MsgBox("Cannot Open!", MsgBoxStyle.Information, myWinApp.Vars("appname"))
'    End If
'    Me.UltraTabControl1.Style = ut.UltraTabControlStyle.Wizard
'    Return Me.FormPrepared
'End Function
'Protected Overrides Sub OnMakeFTFPanel(vsbl As Boolean)
'    Me.Panel1.Visible = vsbl
'    MyBase.OnMakeFTFPanel(vsbl)
'End Sub


'End Class


