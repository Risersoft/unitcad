Imports Infragistics.Win.UltraWinTabControl
Imports Infragistics.Win.Misc

Public Class frmTCPIDU
    Inherits frmWizMax
    Public fp As frmPIDUParamsUc, fc As frmTCMake

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        Dim arrDel As New ArrayList, uTab As UltraTab

        Me.SuspendLayout()

        For Each btn As UltraButton In New UltraButton() {Me.btnMaxView, Me.btnRestoreView, Me.btnSave, Me.btnOK, Me.btnCancel}
            btn.Width = Math.Min(btn.Width, Me.Width / 6)
        Next

        myTables.LoadDataSet(False)

        fp = New frmPIDUParamsUc
        fp.cmb_Startupdefid.ReadOnly = True
        uTab = fp.AddtoTab(Me.UltraTabControl1, "params", True)
        uTab.Text = "Work Order Parameters"

        fc = New frmTCMake
        uTab = fc.AddtoTab(Me.UltraTabControl1, "cadout", True)
        uTab.Text = "CAD Maker"

        Me.InitTabs(Me.UltraTabControl1, "pidunitid", "")
        Me.InitTabKey = "params"
        Me.arrmode.AddRange(New String() {"params"})

        Me.ResumeLayout()
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Me.strT = "tf"
        If frmMode = EnumfrmMode.acEditM AndAlso Me.UltraTabControl1.Tabs.Count > 0 Then
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@pidunitid", prepIdx, GetType(Integer), False))
            Dim ds As DataSet = Me.Controller.DataProvider.LoadAppData(Me.Controller.GetAppInfo, "pidunit", Params, False).Result.Data
            If Me.InitData(ds.Tables(0), oview, prepMode, prepIdx, strXML) Then
                Me.Prepmode()
            End If
        Else
            MsgBox("Cannot Open!", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
        Me.UltraTabControl1.Style = UltraTabControlStyle.Wizard
        Return Me.FormPrepared
    End Function

    Protected Overrides Sub OnMakeFTFPanel(vsbl As Boolean)
        Me.Panel1.Visible = vsbl
        MyBase.OnMakeFTFPanel(vsbl)
    End Sub
End Class

