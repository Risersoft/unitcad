Imports Infragistics.Win

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDwgDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDwgDoc))
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid5 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.PanelBot = New System.Windows.Forms.Panel()
        Me.btnSetUpdate = New Infragistics.Win.Misc.UltraButton()
        Me.btn_CalcParams = New Infragistics.Win.Misc.UltraButton()
        Me.btnPrintDocParams = New Infragistics.Win.Misc.UltraButton()
        Me.btnCopyUnused = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_TestFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UltraTree1 = New Infragistics.Win.UltraWinTree.UltraTree()
        Me.imageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CtlUpLoad1 = New risersoft.[shared].win.ctlUpLoad()
        Me.UltraTabControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBot.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(428, 409)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.PictureBox1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(428, 409)
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(428, 409)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.UltraGrid5)
        Me.UltraTabPageControl9.Controls.Add(Me.PanelBot)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(428, 409)
        '
        'UltraGrid5
        '
        Me.UltraGrid5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid5.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid5.Name = "UltraGrid5"
        Me.UltraGrid5.Size = New System.Drawing.Size(428, 361)
        Me.UltraGrid5.TabIndex = 21
        Me.UltraGrid5.Text = "Bill Of Material"
        '
        'PanelBot
        '
        Me.PanelBot.Controls.Add(Me.btnSetUpdate)
        Me.PanelBot.Controls.Add(Me.btn_CalcParams)
        Me.PanelBot.Controls.Add(Me.btnPrintDocParams)
        Me.PanelBot.Controls.Add(Me.btnCopyUnused)
        Me.PanelBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBot.Location = New System.Drawing.Point(0, 361)
        Me.PanelBot.Name = "PanelBot"
        Me.PanelBot.Size = New System.Drawing.Size(428, 48)
        Me.PanelBot.TabIndex = 20
        '
        'btnSetUpdate
        '
        Me.btnSetUpdate.Location = New System.Drawing.Point(161, 3)
        Me.btnSetUpdate.Name = "btnSetUpdate"
        Me.btnSetUpdate.Size = New System.Drawing.Size(81, 38)
        Me.btnSetUpdate.TabIndex = 363
        Me.btnSetUpdate.Text = "Set and Update"
        '
        'btn_CalcParams
        '
        Me.btn_CalcParams.Location = New System.Drawing.Point(98, 3)
        Me.btn_CalcParams.Name = "btn_CalcParams"
        Me.btn_CalcParams.Size = New System.Drawing.Size(57, 38)
        Me.btn_CalcParams.TabIndex = 362
        Me.btn_CalcParams.Text = "Calc Params"
        '
        'btnPrintDocParams
        '
        Me.btnPrintDocParams.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintDocParams.Location = New System.Drawing.Point(248, 4)
        Me.btnPrintDocParams.Name = "btnPrintDocParams"
        Me.btnPrintDocParams.Size = New System.Drawing.Size(58, 37)
        Me.btnPrintDocParams.TabIndex = 20
        Me.btnPrintDocParams.Text = "Print"
        '
        'btnCopyUnused
        '
        Me.btnCopyUnused.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopyUnused.Location = New System.Drawing.Point(312, 6)
        Me.btnCopyUnused.Name = "btnCopyUnused"
        Me.btnCopyUnused.Size = New System.Drawing.Size(107, 35)
        Me.btnCopyUnused.TabIndex = 14
        Me.btnCopyUnused.Text = "Copy unmapped to local"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.txt_TestFormula)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(428, 409)
        '
        'txt_TestFormula
        '
        Me.txt_TestFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TestFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_TestFormula.LabelText = ""
        Me.txt_TestFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_TestFormula.Name = "txt_TestFormula"
        Me.txt_TestFormula.Size = New System.Drawing.Size(428, 409)
        Me.txt_TestFormula.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.UltraTree1)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(377, 435)
        Me.Panel3.TabIndex = 352
        '
        'UltraTree1
        '
        Me.UltraTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTree1.FullRowSelect = True
        Me.UltraTree1.HideSelection = False
        Me.UltraTree1.ImageList = Me.imageList
        Me.UltraTree1.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.UltraTree1.Location = New System.Drawing.Point(0, 125)
        Me.UltraTree1.Name = "UltraTree1"
        Me.UltraTree1.NodeConnectorColor = System.Drawing.SystemColors.ControlDark
        Me.UltraTree1.Size = New System.Drawing.Size(377, 310)
        Me.UltraTree1.TabIndex = 2
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
        Me.Panel5.Size = New System.Drawing.Size(377, 125)
        Me.Panel5.TabIndex = 0
        '
        'CtlUpLoad1
        '
        Me.CtlUpLoad1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlUpLoad1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad1.Location = New System.Drawing.Point(0, 0)
        Me.CtlUpLoad1.Name = "CtlUpLoad1"
        Me.CtlUpLoad1.Size = New System.Drawing.Size(377, 125)
        Me.CtlUpLoad1.TabIndex = 0
        '
        'UltraTabControl3
        '
        Me.UltraTabControl3.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl3.Location = New System.Drawing.Point(377, 0)
        Me.UltraTabControl3.Name = "UltraTabControl3"
        Me.UltraTabControl3.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl3.Size = New System.Drawing.Size(432, 435)
        Me.UltraTabControl3.TabIndex = 353
        UltraTab8.Key = "preview"
        UltraTab8.TabPage = Me.UltraTabPageControl8
        UltraTab8.Text = "File Preview"
        UltraTab2.Key = "bpreview"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Block Preview"
        UltraTab9.Key = "params"
        UltraTab9.TabPage = Me.UltraTabPageControl9
        UltraTab9.Text = "Parameters"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Check"
        Me.UltraTabControl3.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab8, UltraTab2, UltraTab9, UltraTab1})
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(428, 409)
        '
        'frmDwgDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "frmDwgDoc"
        Me.ClientSize = New System.Drawing.Size(809, 435)
        Me.Controls.Add(Me.UltraTabControl3)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDwgDoc"
        Me.Text = "frmDwgDoc"
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBot.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabControl3 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid5 As Infragistics.Win.UltraWinGrid.UltraGrid
    Public WithEvents btnPrintDocParams As Infragistics.Win.Misc.UltraButton
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents btnSetUpdate As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_CalcParams As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTree1 As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents btnCopyUnused As Infragistics.Win.Misc.UltraButton
    Public WithEvents PanelBot As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Public WithEvents txt_TestFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents CtlUpLoad1 As ctlUpLoad
End Class
