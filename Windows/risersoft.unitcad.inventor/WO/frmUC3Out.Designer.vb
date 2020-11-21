Imports System.Xml
Imports Infragistics.Win.UltraWinTabControl
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmUC3Out
    Inherits frmMax


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitForm()
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
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.btnMasterZip = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.btnPrepModel3D = New Infragistics.Win.Misc.UltraButton()
        Me.btnPrep2 = New Infragistics.Win.Misc.UltraButton()
        Me.btn_Print = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraListView1 = New Infragistics.Win.UltraWinListView.UltraListView()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButtons.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.UltraTabSharedControlsPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(624, 652)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(624, 652)
        Me.UltraGrid1.TabIndex = 17
        Me.UltraGrid1.Text = "Delivery Schedule"
        '
        'PanelButtons
        '
        Me.PanelButtons.Controls.Add(Me.btnMasterZip)
        Me.PanelButtons.Controls.Add(Me.UltraButton1)
        Me.PanelButtons.Controls.Add(Me.btnPrepModel3D)
        Me.PanelButtons.Controls.Add(Me.btnPrep2)
        Me.PanelButtons.Controls.Add(Me.btn_Print)
        Me.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelButtons.Location = New System.Drawing.Point(0, 611)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(624, 41)
        Me.PanelButtons.TabIndex = 3
        '
        'btnMasterZip
        '
        Me.btnMasterZip.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMasterZip.Location = New System.Drawing.Point(375, 0)
        Me.btnMasterZip.Name = "btnMasterZip"
        Me.btnMasterZip.Size = New System.Drawing.Size(99, 41)
        Me.btnMasterZip.TabIndex = 660
        Me.btnMasterZip.Text = "Create Master Zip"
        '
        'UltraButton1
        '
        Me.UltraButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraButton1.Location = New System.Drawing.Point(276, 0)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(99, 41)
        Me.UltraButton1.TabIndex = 659
        Me.UltraButton1.Text = "Refresh Explorer 3D"
        '
        'btnPrepModel3D
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.btnPrepModel3D.Appearance = Appearance1
        Me.btnPrepModel3D.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrepModel3D.Location = New System.Drawing.Point(185, 0)
        Me.btnPrepModel3D.Name = "btnPrepModel3D"
        Me.btnPrepModel3D.Size = New System.Drawing.Size(91, 41)
        Me.btnPrepModel3D.TabIndex = 657
        Me.btnPrepModel3D.Text = "Prepare Model 3D"
        '
        'btnPrep2
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnPrep2.Appearance = Appearance2
        Me.btnPrep2.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrep2.Location = New System.Drawing.Point(94, 0)
        Me.btnPrep2.Name = "btnPrep2"
        Me.btnPrep2.Size = New System.Drawing.Size(91, 41)
        Me.btnPrep2.TabIndex = 656
        Me.btnPrep2.Text = "Prepare Tree+BOM"
        '
        'btn_Print
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btn_Print.Appearance = Appearance3
        Me.btn_Print.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Print.Location = New System.Drawing.Point(0, 0)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(94, 41)
        Me.btn_Print.TabIndex = 655
        Me.btn_Print.Text = "Print"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(624, 652)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(624, 652)
        Me.UltraGrid2.TabIndex = 18
        Me.UltraGrid2.Text = "Delivery Schedule"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraListView1)
        Me.UltraTabPageControl1.Controls.Add(Me.PanelButtons)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(213, 1)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(624, 652)
        '
        'UltraListView1
        '
        Me.UltraListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraListView1.Location = New System.Drawing.Point(0, 0)
        Me.UltraListView1.Name = "UltraListView1"
        Me.UltraListView1.Size = New System.Drawing.Size(624, 611)
        Me.UltraListView1.TabIndex = 4
        Me.UltraListView1.Text = "UltraListView1"
        Me.UltraListView1.View = Infragistics.Win.UltraWinListView.UltraListViewStyle.Tiles
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.RichTextBox1)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(624, 652)
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(624, 652)
        Me.RichTextBox1.TabIndex = 21
        Me.RichTextBox1.Text = ""
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(756, 409)
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.BackColorInternal = System.Drawing.SystemColors.Control
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance4.BorderColor = System.Drawing.Color.Transparent
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.FontData.SizeInPoints = 12.0!
        Appearance4.TextTrimming = Infragistics.Win.TextTrimming.None
        Me.UltraTabControl1.SelectedTabAppearance = Appearance4
        Me.UltraTabControl1.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.PanelButtons})
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(840, 656)
        Me.UltraTabControl1.TabIndex = 0
        Me.UltraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        UltraTab6.Key = "bomtank2"
        UltraTab6.TabPage = Me.UltraTabPageControl9
        UltraTab6.Text = "Bill of Material"
        UltraTab2.Key = "compref"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Component Builtup"
        UltraTab1.Key = "thumb"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Thumbnails"
        UltraTab3.Key = "log"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Log"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab2, UltraTab1, UltraTab3})
        Me.UltraTabControl1.TabSize = New System.Drawing.Size(0, 210)
        Me.UltraTabControl1.TabsPerRow = 1
        Me.UltraTabControl1.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.PanelButtons)
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(624, 652)
        '
        'frmUC3Out
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Transformer Design"
        Me.ClientSize = New System.Drawing.Size(840, 656)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUC3Out"
        Me.ShowInTaskbar = False
        Me.Text = "Transformer Design"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButtons.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.UltraTabSharedControlsPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelButtons As System.Windows.Forms.Panel
    Friend WithEvents btn_Print As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnPrep2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnPrepModel3D As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraListView1 As Infragistics.Win.UltraWinListView.UltraListView
    Friend WithEvents UltraTabPageControl3 As UltraTabPageControl
    Friend WithEvents RichTextBox1 As Windows.Forms.RichTextBox
    Friend WithEvents btnMasterZip As Infragistics.Win.Misc.UltraButton

#End Region
End Class

