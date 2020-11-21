<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFCompDefParamList
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        initForm()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.PanelMove = New System.Windows.Forms.Panel()
        Me.btnRenumP = New Infragistics.Win.Misc.UltraButton()
        Me.btnMovePU = New Infragistics.Win.Misc.UltraButton()
        Me.btnMovePD = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid5 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid6 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnExportParams = New Infragistics.Win.Misc.UltraButton()
        Me.UltraCheckEditor1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTabPageControl15 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid14 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabControlParam = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMove.SuspendLayout()
        Me.UltraTabPageControl11.SuspendLayout()
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl12.SuspendLayout()
        CType(Me.UltraGrid6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.UltraCheckEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl15.SuspendLayout()
        CType(Me.UltraGrid14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControlParam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControlParam.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl10.Controls.Add(Me.PanelMove)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(125, 0)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(565, 461)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(565, 423)
        Me.UltraGrid1.TabIndex = 18
        Me.UltraGrid1.Text = "Bill Of Material"
        '
        'PanelMove
        '
        Me.PanelMove.Controls.Add(Me.btnRenumP)
        Me.PanelMove.Controls.Add(Me.btnMovePU)
        Me.PanelMove.Controls.Add(Me.btnMovePD)
        Me.PanelMove.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMove.Enabled = False
        Me.PanelMove.Location = New System.Drawing.Point(0, 423)
        Me.PanelMove.Name = "PanelMove"
        Me.PanelMove.Size = New System.Drawing.Size(565, 38)
        Me.PanelMove.TabIndex = 19
        '
        'btnRenumP
        '
        Me.btnRenumP.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRenumP.Location = New System.Drawing.Point(268, 0)
        Me.btnRenumP.Name = "btnRenumP"
        Me.btnRenumP.Size = New System.Drawing.Size(99, 38)
        Me.btnRenumP.TabIndex = 368
        Me.btnRenumP.Text = "Renumber"
        '
        'btnMovePU
        '
        Me.btnMovePU.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMovePU.Location = New System.Drawing.Point(367, 0)
        Me.btnMovePU.Name = "btnMovePU"
        Me.btnMovePU.Size = New System.Drawing.Size(99, 38)
        Me.btnMovePU.TabIndex = 367
        Me.btnMovePU.Text = "Move Up"
        '
        'btnMovePD
        '
        Me.btnMovePD.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMovePD.Location = New System.Drawing.Point(466, 0)
        Me.btnMovePD.Name = "btnMovePD"
        Me.btnMovePD.Size = New System.Drawing.Size(99, 38)
        Me.btnMovePD.TabIndex = 366
        Me.btnMovePD.Text = "Move Down"
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.UltraGrid5)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(565, 461)
        '
        'UltraGrid5
        '
        Me.UltraGrid5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid5.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid5.Name = "UltraGrid5"
        Me.UltraGrid5.Size = New System.Drawing.Size(565, 461)
        Me.UltraGrid5.TabIndex = 19
        Me.UltraGrid5.Text = "Bill Of Material"
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.UltraGrid6)
        Me.UltraTabPageControl12.Controls.Add(Me.Panel7)
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(565, 461)
        '
        'UltraGrid6
        '
        Me.UltraGrid6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid6.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid6.Name = "UltraGrid6"
        Me.UltraGrid6.Size = New System.Drawing.Size(565, 413)
        Me.UltraGrid6.TabIndex = 20
        Me.UltraGrid6.Text = "Bill Of Material"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnExportParams)
        Me.Panel7.Controls.Add(Me.UltraCheckEditor1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Enabled = False
        Me.Panel7.Location = New System.Drawing.Point(0, 413)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(565, 48)
        Me.Panel7.TabIndex = 19
        '
        'btnExportParams
        '
        Me.btnExportParams.Location = New System.Drawing.Point(3, 3)
        Me.btnExportParams.Name = "btnExportParams"
        Me.btnExportParams.Size = New System.Drawing.Size(100, 36)
        Me.btnExportParams.TabIndex = 365
        Me.btnExportParams.Text = "Export Global Parameters"
        '
        'UltraCheckEditor1
        '
        Me.UltraCheckEditor1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "False"
        Appearance1.FontData.SizeInPoints = 8.0!
        Me.UltraCheckEditor1.Appearance = Appearance1
        Me.UltraCheckEditor1.Location = New System.Drawing.Point(367, 8)
        Me.UltraCheckEditor1.Name = "UltraCheckEditor1"
        Me.UltraCheckEditor1.Size = New System.Drawing.Size(186, 24)
        Me.UltraCheckEditor1.TabIndex = 349
        Me.UltraCheckEditor1.Text = "Show Only Parameters used in this component definition"
        Me.UltraCheckEditor1.Visible = False
        '
        'UltraTabPageControl15
        '
        Me.UltraTabPageControl15.Controls.Add(Me.UltraGrid14)
        Me.UltraTabPageControl15.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl15.Name = "UltraTabPageControl15"
        Me.UltraTabPageControl15.Size = New System.Drawing.Size(565, 461)
        '
        'UltraGrid14
        '
        Me.UltraGrid14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid14.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid14.Name = "UltraGrid14"
        Me.UltraGrid14.Size = New System.Drawing.Size(565, 461)
        Me.UltraGrid14.TabIndex = 19
        Me.UltraGrid14.Text = "Bill Of Material"
        '
        'UltraTabControlParam
        '
        Me.UltraTabControlParam.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.UltraTabControlParam.Controls.Add(Me.UltraTabPageControl10)
        Me.UltraTabControlParam.Controls.Add(Me.UltraTabPageControl11)
        Me.UltraTabControlParam.Controls.Add(Me.UltraTabPageControl12)
        Me.UltraTabControlParam.Controls.Add(Me.UltraTabPageControl15)
        Me.UltraTabControlParam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControlParam.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControlParam.Name = "UltraTabControlParam"
        Appearance2.FontData.BoldAsString = "True"
        Me.UltraTabControlParam.SelectedTabAppearance = Appearance2
        Me.UltraTabControlParam.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.UltraTabControlParam.Size = New System.Drawing.Size(690, 461)
        Me.UltraTabControlParam.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControlParam.TabIndex = 18
        Me.UltraTabControlParam.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        UltraTab10.Key = "local"
        UltraTab10.TabPage = Me.UltraTabPageControl10
        UltraTab10.Text = "Local Parameters"
        UltraTab11.TabPage = Me.UltraTabPageControl11
        UltraTab11.Text = "Inherited Parameters"
        UltraTab12.TabPage = Me.UltraTabPageControl12
        UltraTab12.Text = "Global Parameters"
        UltraTab15.Key = "grp"
        UltraTab15.TabPage = Me.UltraTabPageControl15
        UltraTab15.Text = "Parameter Groups"
        Me.UltraTabControlParam.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab10, UltraTab11, UltraTab12, UltraTab15})
        Me.UltraTabControlParam.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(565, 461)
        '
        'frmTFCompDefParamList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Component Definition Parameter List"
        Me.ClientSize = New System.Drawing.Size(690, 461)
        Me.Controls.Add(Me.UltraTabControlParam)
        Me.MaximizeBox = False
        Me.Name = "frmTFCompDefParamList"
        Me.Text = "Component Definition Parameter List"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMove.ResumeLayout(False)
        Me.UltraTabPageControl11.ResumeLayout(False)
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl12.ResumeLayout(False)
        CType(Me.UltraGrid6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.UltraCheckEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl15.ResumeLayout(False)
        CType(Me.UltraGrid14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControlParam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControlParam.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnRenumP As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMovePU As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMovePD As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid5 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid6 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Protected Friend WithEvents btnExportParams As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraCheckEditor1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTabPageControl15 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid14 As Infragistics.Win.UltraWinGrid.UltraGrid
    Public WithEvents UltraTabControlParam As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Public WithEvents PanelMove As Windows.Forms.Panel

#End Region
End Class

