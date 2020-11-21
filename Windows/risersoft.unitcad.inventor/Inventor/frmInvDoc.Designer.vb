Imports risersoft.shared.win
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvDoc
    Inherits frmMax

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvDoc))
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid5 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.PanelBot = New System.Windows.Forms.Panel()
        Me.btn_CalcParams = New Infragistics.Win.Misc.UltraButton()
        Me.btnSetUpdate = New Infragistics.Win.Misc.UltraButton()
        Me.btnPrintDocParams = New Infragistics.Win.Misc.UltraButton()
        Me.btnCopyUnused = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_TestFormula = New ctlFormulaEditorScintilla()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UltraTree1 = New Infragistics.Win.UltraWinTree.UltraTree()
        Me.imageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CtlUpLoad1 = New ctlUpLoad()
        Me.UltraTabControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBot.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.Panel6)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(481, 409)
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(481, 26)
        Me.Panel6.TabIndex = 354
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.UltraGrid5)
        Me.UltraTabPageControl9.Controls.Add(Me.PanelBot)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(481, 409)
        '
        'UltraGrid5
        '
        Me.UltraGrid5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid5.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid5.Name = "UltraGrid5"
        Me.UltraGrid5.Size = New System.Drawing.Size(481, 355)
        Me.UltraGrid5.TabIndex = 21
        Me.UltraGrid5.Text = "Bill Of Material"
        '
        'PanelBot
        '
        Me.PanelBot.Controls.Add(Me.btn_CalcParams)
        Me.PanelBot.Controls.Add(Me.btnSetUpdate)
        Me.PanelBot.Controls.Add(Me.btnPrintDocParams)
        Me.PanelBot.Controls.Add(Me.btnCopyUnused)
        Me.PanelBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBot.Location = New System.Drawing.Point(0, 355)
        Me.PanelBot.Name = "PanelBot"
        Me.PanelBot.Size = New System.Drawing.Size(481, 54)
        Me.PanelBot.TabIndex = 20
        '
        'btn_CalcParams
        '
        Me.btn_CalcParams.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CalcParams.Location = New System.Drawing.Point(183, 6)
        Me.btn_CalcParams.Name = "btn_CalcParams"
        Me.btn_CalcParams.Size = New System.Drawing.Size(62, 42)
        Me.btn_CalcParams.TabIndex = 362
        Me.btn_CalcParams.Text = "Calculate"
        '
        'btnSetUpdate
        '
        Me.btnSetUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSetUpdate.Location = New System.Drawing.Point(251, 7)
        Me.btnSetUpdate.Name = "btnSetUpdate"
        Me.btnSetUpdate.Size = New System.Drawing.Size(56, 42)
        Me.btnSetUpdate.TabIndex = 363
        Me.btnSetUpdate.Text = "Set and Update"
        '
        'btnPrintDocParams
        '
        Me.btnPrintDocParams.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintDocParams.Location = New System.Drawing.Point(313, 6)
        Me.btnPrintDocParams.Name = "btnPrintDocParams"
        Me.btnPrintDocParams.Size = New System.Drawing.Size(56, 42)
        Me.btnPrintDocParams.TabIndex = 20
        Me.btnPrintDocParams.Text = "Print"
        '
        'btnCopyUnused
        '
        Me.btnCopyUnused.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopyUnused.Location = New System.Drawing.Point(372, 7)
        Me.btnCopyUnused.Name = "btnCopyUnused"
        Me.btnCopyUnused.Size = New System.Drawing.Size(99, 42)
        Me.btnCopyUnused.TabIndex = 14
        Me.btnCopyUnused.Text = "Copy unmapped to local"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.txt_TestFormula)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(481, 409)
        '
        'txt_TestFormula
        '
        Me.txt_TestFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TestFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_TestFormula.LabelText = ""
        Me.txt_TestFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_TestFormula.Name = "txt_TestFormula"
        Me.txt_TestFormula.Size = New System.Drawing.Size(481, 409)
        Me.txt_TestFormula.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.UltraTree1)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 435)
        Me.Panel3.TabIndex = 352
        '
        'UltraTree1
        '
        Me.UltraTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTree1.HideSelection = False
        Me.UltraTree1.ImageList = Me.imageList
        Me.UltraTree1.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.UltraTree1.Location = New System.Drawing.Point(0, 130)
        Me.UltraTree1.Name = "UltraTree1"
        Me.UltraTree1.NodeConnectorColor = System.Drawing.SystemColors.ControlDark
        Me.UltraTree1.Size = New System.Drawing.Size(320, 305)
        Me.UltraTree1.TabIndex = 1
        '
        'imageList
        '
        Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList.Images.SetKeyName(0, "")
        Me.imageList.Images.SetKeyName(1, "")
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.CtlUpLoad1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(320, 130)
        Me.Panel5.TabIndex = 0
        '
        'CtlUpLoad1
        '
        Me.CtlUpLoad1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlUpLoad1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad1.Location = New System.Drawing.Point(0, 0)
        Me.CtlUpLoad1.Name = "CtlUpLoad1"
        Me.CtlUpLoad1.Size = New System.Drawing.Size(320, 130)
        Me.CtlUpLoad1.TabIndex = 1
        '
        'UltraTabControl3
        '
        Me.UltraTabControl3.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl3.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl3.Name = "UltraTabControl3"
        Me.UltraTabControl3.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl3.Size = New System.Drawing.Size(485, 435)
        Me.UltraTabControl3.TabIndex = 353
        UltraTab8.Key = "view"
        UltraTab8.TabPage = Me.UltraTabPageControl8
        UltraTab8.Text = "Preview"
        UltraTab9.TabPage = Me.UltraTabPageControl9
        UltraTab9.Text = "Parameters"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Check"
        Me.UltraTabControl3.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab8, UltraTab9, UltraTab1})
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(481, 409)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UltraTabControl3)
        Me.SplitContainer1.Size = New System.Drawing.Size(809, 435)
        Me.SplitContainer1.SplitterDistance = 320
        Me.SplitContainer1.TabIndex = 354
        '
        'frmInvDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "frmInvDoc"
        Me.ClientSize = New System.Drawing.Size(809, 435)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmInvDoc"
        Me.Text = "frmInvDoc"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBot.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UltraTree1 As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabControl3 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid5 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents PanelBot As System.Windows.Forms.Panel
    Public WithEvents btnPrintDocParams As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCopyUnused As Infragistics.Win.Misc.UltraButton
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents btnSetUpdate As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_CalcParams As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txt_TestFormula As Global.risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents CtlUpLoad1 As Global.risersoft.shared.win.ctlUpLoad
End Class
