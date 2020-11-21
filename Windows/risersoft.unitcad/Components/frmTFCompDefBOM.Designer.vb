<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFCompDefBOM
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab19 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab20 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab21 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraExplorerBarGroup1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup5 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup6 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup7 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_ThkFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_WidthFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl15 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_LengthFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl16 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_DrgFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl17 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_QtyFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_QtyTextFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl18 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_AggCodeFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl19 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_AggTextFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_MaterialFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_DensityFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraExplorerBarContainerControl1 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.txt_PortionNumFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraExplorerBarContainerControl2 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.txt_GroupNumFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraExplorerBarContainerControl3 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.txt_DescripFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraExplorerBarContainerControl4 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.UltraTabControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraExplorerBarContainerControl5 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraExplorerBarContainerControl6 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.UltraTabControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraExplorerBarContainerControl7 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.txt_RemarkFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.Panelbtn = New System.Windows.Forms.Panel()
        Me.btn_print = New Infragistics.Win.Misc.UltraButton()
        Me.btnCopy = New Infragistics.Win.Misc.UltraButton()
        Me.btnAdd = New Infragistics.Win.Misc.UltraButton()
        Me.btnEdit = New Infragistics.Win.Misc.UltraButton()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExplorerBar1 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnRenumP = New Infragistics.Win.Misc.UltraButton()
        Me.btnMovePU = New Infragistics.Win.Misc.UltraButton()
        Me.btnMovePD = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraLabel42 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ItemNumFixed = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Remarks = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl13.SuspendLayout()
        Me.UltraTabPageControl14.SuspendLayout()
        Me.UltraTabPageControl15.SuspendLayout()
        Me.UltraTabPageControl16.SuspendLayout()
        Me.UltraTabPageControl17.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraTabPageControl18.SuspendLayout()
        Me.UltraTabPageControl19.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        Me.UltraExplorerBarContainerControl1.SuspendLayout()
        Me.UltraExplorerBarContainerControl2.SuspendLayout()
        Me.UltraExplorerBarContainerControl3.SuspendLayout()
        Me.UltraExplorerBarContainerControl4.SuspendLayout()
        CType(Me.UltraTabControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl4.SuspendLayout()
        Me.UltraExplorerBarContainerControl5.SuspendLayout()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        Me.UltraExplorerBarContainerControl6.SuspendLayout()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl3.SuspendLayout()
        Me.UltraExplorerBarContainerControl7.SuspendLayout()
        Me.Panelbtn.SuspendLayout()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExplorerBar1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_ItemNumFixed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.UltraTabSharedControlsPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.txt_ThkFormula)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(86, 0)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(627, 216)
        '
        'txt_ThkFormula
        '
        Me.txt_ThkFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ThkFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_ThkFormula.LabelText = ""
        Me.txt_ThkFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_ThkFormula.Name = "txt_ThkFormula"
        Me.txt_ThkFormula.Size = New System.Drawing.Size(627, 216)
        Me.txt_ThkFormula.TabIndex = 2
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.txt_WidthFormula)
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(627, 216)
        '
        'txt_WidthFormula
        '
        Me.txt_WidthFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_WidthFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_WidthFormula.LabelText = ""
        Me.txt_WidthFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_WidthFormula.Name = "txt_WidthFormula"
        Me.txt_WidthFormula.Size = New System.Drawing.Size(627, 216)
        Me.txt_WidthFormula.TabIndex = 2
        '
        'UltraTabPageControl15
        '
        Me.UltraTabPageControl15.Controls.Add(Me.txt_LengthFormula)
        Me.UltraTabPageControl15.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl15.Name = "UltraTabPageControl15"
        Me.UltraTabPageControl15.Size = New System.Drawing.Size(627, 216)
        '
        'txt_LengthFormula
        '
        Me.txt_LengthFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_LengthFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_LengthFormula.LabelText = ""
        Me.txt_LengthFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_LengthFormula.Name = "txt_LengthFormula"
        Me.txt_LengthFormula.Size = New System.Drawing.Size(627, 216)
        Me.txt_LengthFormula.TabIndex = 2
        '
        'UltraTabPageControl16
        '
        Me.UltraTabPageControl16.Controls.Add(Me.txt_DrgFormula)
        Me.UltraTabPageControl16.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl16.Name = "UltraTabPageControl16"
        Me.UltraTabPageControl16.Size = New System.Drawing.Size(627, 216)
        '
        'txt_DrgFormula
        '
        Me.txt_DrgFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_DrgFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_DrgFormula.LabelText = ""
        Me.txt_DrgFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_DrgFormula.Name = "txt_DrgFormula"
        Me.txt_DrgFormula.Size = New System.Drawing.Size(627, 216)
        Me.txt_DrgFormula.TabIndex = 2
        '
        'UltraTabPageControl17
        '
        Me.UltraTabPageControl17.Controls.Add(Me.txt_QtyFormula)
        Me.UltraTabPageControl17.Location = New System.Drawing.Point(128, 0)
        Me.UltraTabPageControl17.Name = "UltraTabPageControl17"
        Me.UltraTabPageControl17.Size = New System.Drawing.Size(585, 216)
        '
        'txt_QtyFormula
        '
        Me.txt_QtyFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_QtyFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_QtyFormula.LabelText = ""
        Me.txt_QtyFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_QtyFormula.Name = "txt_QtyFormula"
        Me.txt_QtyFormula.Size = New System.Drawing.Size(585, 216)
        Me.txt_QtyFormula.TabIndex = 3
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.txt_QtyTextFormula)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(585, 216)
        '
        'txt_QtyTextFormula
        '
        Me.txt_QtyTextFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_QtyTextFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_QtyTextFormula.LabelText = ""
        Me.txt_QtyTextFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_QtyTextFormula.Name = "txt_QtyTextFormula"
        Me.txt_QtyTextFormula.Size = New System.Drawing.Size(585, 216)
        Me.txt_QtyTextFormula.TabIndex = 4
        '
        'UltraTabPageControl18
        '
        Me.UltraTabPageControl18.Controls.Add(Me.txt_AggCodeFormula)
        Me.UltraTabPageControl18.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl18.Name = "UltraTabPageControl18"
        Me.UltraTabPageControl18.Size = New System.Drawing.Size(585, 216)
        '
        'txt_AggCodeFormula
        '
        Me.txt_AggCodeFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_AggCodeFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_AggCodeFormula.LabelText = ""
        Me.txt_AggCodeFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_AggCodeFormula.Name = "txt_AggCodeFormula"
        Me.txt_AggCodeFormula.Size = New System.Drawing.Size(585, 216)
        Me.txt_AggCodeFormula.TabIndex = 3
        '
        'UltraTabPageControl19
        '
        Me.UltraTabPageControl19.Controls.Add(Me.txt_AggTextFormula)
        Me.UltraTabPageControl19.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl19.Name = "UltraTabPageControl19"
        Me.UltraTabPageControl19.Size = New System.Drawing.Size(585, 216)
        '
        'txt_AggTextFormula
        '
        Me.txt_AggTextFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_AggTextFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_AggTextFormula.LabelText = ""
        Me.txt_AggTextFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_AggTextFormula.Name = "txt_AggTextFormula"
        Me.txt_AggTextFormula.Size = New System.Drawing.Size(585, 216)
        Me.txt_AggTextFormula.TabIndex = 3
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.txt_MaterialFormula)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(71, 0)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(642, 216)
        '
        'txt_MaterialFormula
        '
        Me.txt_MaterialFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MaterialFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_MaterialFormula.LabelText = ""
        Me.txt_MaterialFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_MaterialFormula.Name = "txt_MaterialFormula"
        Me.txt_MaterialFormula.Size = New System.Drawing.Size(642, 216)
        Me.txt_MaterialFormula.TabIndex = 3
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.txt_DensityFormula)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(642, 216)
        '
        'txt_DensityFormula
        '
        Me.txt_DensityFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_DensityFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_DensityFormula.LabelText = ""
        Me.txt_DensityFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_DensityFormula.Name = "txt_DensityFormula"
        Me.txt_DensityFormula.Size = New System.Drawing.Size(642, 216)
        Me.txt_DensityFormula.TabIndex = 4
        '
        'UltraExplorerBarContainerControl1
        '
        Me.UltraExplorerBarContainerControl1.Controls.Add(Me.txt_PortionNumFormula)
        Me.UltraExplorerBarContainerControl1.Location = New System.Drawing.Point(3, 24)
        Me.UltraExplorerBarContainerControl1.Name = "UltraExplorerBarContainerControl1"
        Me.UltraExplorerBarContainerControl1.Size = New System.Drawing.Size(713, 216)
        Me.UltraExplorerBarContainerControl1.TabIndex = 0
        '
        'txt_PortionNumFormula
        '
        Me.txt_PortionNumFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_PortionNumFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_PortionNumFormula.LabelText = ""
        Me.txt_PortionNumFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_PortionNumFormula.Name = "txt_PortionNumFormula"
        Me.txt_PortionNumFormula.Size = New System.Drawing.Size(713, 216)
        Me.txt_PortionNumFormula.TabIndex = 0
        '
        'UltraExplorerBarContainerControl2
        '
        Me.UltraExplorerBarContainerControl2.Controls.Add(Me.txt_GroupNumFormula)
        Me.UltraExplorerBarContainerControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl2.Name = "UltraExplorerBarContainerControl2"
        Me.UltraExplorerBarContainerControl2.Size = New System.Drawing.Size(713, 216)
        Me.UltraExplorerBarContainerControl2.TabIndex = 1
        Me.UltraExplorerBarContainerControl2.Visible = False
        '
        'txt_GroupNumFormula
        '
        Me.txt_GroupNumFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_GroupNumFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_GroupNumFormula.LabelText = ""
        Me.txt_GroupNumFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_GroupNumFormula.Name = "txt_GroupNumFormula"
        Me.txt_GroupNumFormula.Size = New System.Drawing.Size(713, 216)
        Me.txt_GroupNumFormula.TabIndex = 1
        '
        'UltraExplorerBarContainerControl3
        '
        Me.UltraExplorerBarContainerControl3.Controls.Add(Me.txt_DescripFormula)
        Me.UltraExplorerBarContainerControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl3.Name = "UltraExplorerBarContainerControl3"
        Me.UltraExplorerBarContainerControl3.Size = New System.Drawing.Size(713, 233)
        Me.UltraExplorerBarContainerControl3.TabIndex = 2
        Me.UltraExplorerBarContainerControl3.Visible = False
        '
        'txt_DescripFormula
        '
        Me.txt_DescripFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_DescripFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_DescripFormula.LabelText = ""
        Me.txt_DescripFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_DescripFormula.Name = "txt_DescripFormula"
        Me.txt_DescripFormula.Size = New System.Drawing.Size(713, 233)
        Me.txt_DescripFormula.TabIndex = 1
        '
        'UltraExplorerBarContainerControl4
        '
        Me.UltraExplorerBarContainerControl4.Controls.Add(Me.UltraTabControl4)
        Me.UltraExplorerBarContainerControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl4.Name = "UltraExplorerBarContainerControl4"
        Me.UltraExplorerBarContainerControl4.Size = New System.Drawing.Size(713, 216)
        Me.UltraExplorerBarContainerControl4.TabIndex = 3
        Me.UltraExplorerBarContainerControl4.Visible = False
        '
        'UltraTabControl4
        '
        Me.UltraTabControl4.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl13)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl14)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl15)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl16)
        Me.UltraTabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl4.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl4.Name = "UltraTabControl4"
        Appearance1.FontData.BoldAsString = "True"
        Me.UltraTabControl4.SelectedTabAppearance = Appearance1
        Me.UltraTabControl4.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.UltraTabControl4.Size = New System.Drawing.Size(713, 216)
        Me.UltraTabControl4.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl4.TabIndex = 20
        Me.UltraTabControl4.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        Me.UltraTabControl4.TabPadding = New System.Drawing.Size(10, 1)
        UltraTab18.TabPage = Me.UltraTabPageControl13
        UltraTab18.Text = "Thickness"
        UltraTab19.TabPage = Me.UltraTabPageControl14
        UltraTab19.Text = "Width"
        UltraTab20.TabPage = Me.UltraTabPageControl15
        UltraTab20.Text = "Length"
        UltraTab21.TabPage = Me.UltraTabPageControl16
        UltraTab21.Text = "Drawing"
        Me.UltraTabControl4.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab18, UltraTab19, UltraTab20, UltraTab21})
        Me.UltraTabControl4.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(627, 216)
        '
        'UltraExplorerBarContainerControl5
        '
        Me.UltraExplorerBarContainerControl5.Controls.Add(Me.UltraTabControl2)
        Me.UltraExplorerBarContainerControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl5.Name = "UltraExplorerBarContainerControl5"
        Me.UltraExplorerBarContainerControl5.Size = New System.Drawing.Size(713, 216)
        Me.UltraExplorerBarContainerControl5.TabIndex = 4
        Me.UltraExplorerBarContainerControl5.Visible = False
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl17)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl18)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl19)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Appearance2.FontData.BoldAsString = "True"
        Me.UltraTabControl2.SelectedTabAppearance = Appearance2
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(713, 216)
        Me.UltraTabControl2.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl2.TabIndex = 22
        Me.UltraTabControl2.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        Me.UltraTabControl2.TabPadding = New System.Drawing.Size(10, 1)
        UltraTab1.TabPage = Me.UltraTabPageControl17
        UltraTab1.Text = "Quantity"
        UltraTab8.TabPage = Me.UltraTabPageControl1
        UltraTab8.Text = "Quantity Text"
        UltraTab10.TabPage = Me.UltraTabPageControl18
        UltraTab10.Text = "Aggregation Code"
        UltraTab11.TabPage = Me.UltraTabPageControl19
        UltraTab11.Text = "Aggregation Text"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab8, UltraTab10, UltraTab11})
        Me.UltraTabControl2.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(585, 216)
        '
        'UltraExplorerBarContainerControl6
        '
        Me.UltraExplorerBarContainerControl6.Controls.Add(Me.UltraTabControl3)
        Me.UltraExplorerBarContainerControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl6.Name = "UltraExplorerBarContainerControl6"
        Me.UltraExplorerBarContainerControl6.Size = New System.Drawing.Size(713, 216)
        Me.UltraExplorerBarContainerControl6.TabIndex = 5
        Me.UltraExplorerBarContainerControl6.Visible = False
        '
        'UltraTabControl3
        '
        Me.UltraTabControl3.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl3.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl3.Name = "UltraTabControl3"
        Appearance3.FontData.BoldAsString = "True"
        Me.UltraTabControl3.SelectedTabAppearance = Appearance3
        Me.UltraTabControl3.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl3.Size = New System.Drawing.Size(713, 216)
        Me.UltraTabControl3.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl3.TabIndex = 23
        Me.UltraTabControl3.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        Me.UltraTabControl3.TabPadding = New System.Drawing.Size(10, 1)
        UltraTab2.TabPage = Me.UltraTabPageControl3
        UltraTab2.Text = "Name"
        UltraTab3.TabPage = Me.UltraTabPageControl6
        UltraTab3.Text = "Density"
        Me.UltraTabControl3.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab3})
        Me.UltraTabControl3.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(642, 216)
        '
        'UltraExplorerBarContainerControl7
        '
        Me.UltraExplorerBarContainerControl7.Controls.Add(Me.txt_RemarkFormula)
        Me.UltraExplorerBarContainerControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl7.Name = "UltraExplorerBarContainerControl7"
        Me.UltraExplorerBarContainerControl7.Size = New System.Drawing.Size(713, 212)
        Me.UltraExplorerBarContainerControl7.TabIndex = 6
        Me.UltraExplorerBarContainerControl7.Visible = False
        '
        'txt_RemarkFormula
        '
        Me.txt_RemarkFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_RemarkFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_RemarkFormula.LabelText = ""
        Me.txt_RemarkFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_RemarkFormula.Name = "txt_RemarkFormula"
        Me.txt_RemarkFormula.Size = New System.Drawing.Size(713, 212)
        Me.txt_RemarkFormula.TabIndex = 3
        '
        'Panelbtn
        '
        Me.Panelbtn.Controls.Add(Me.btn_print)
        Me.Panelbtn.Controls.Add(Me.btnCopy)
        Me.Panelbtn.Controls.Add(Me.btnAdd)
        Me.Panelbtn.Controls.Add(Me.btnEdit)
        Me.Panelbtn.Controls.Add(Me.btnDel)
        Me.Panelbtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelbtn.Location = New System.Drawing.Point(0, 333)
        Me.Panelbtn.Name = "Panelbtn"
        Me.Panelbtn.Size = New System.Drawing.Size(719, 36)
        Me.Panelbtn.TabIndex = 30
        '
        'btn_print
        '
        Me.btn_print.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_print.Location = New System.Drawing.Point(419, 0)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(58, 36)
        Me.btn_print.TabIndex = 371
        Me.btn_print.Text = "Print"
        '
        'btnCopy
        '
        Me.btnCopy.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCopy.Location = New System.Drawing.Point(477, 0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(58, 36)
        Me.btnCopy.TabIndex = 370
        Me.btnCopy.Text = "Copy"
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdd.Location = New System.Drawing.Point(535, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 36)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEdit.Location = New System.Drawing.Point(593, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(56, 36)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        '
        'btnDel
        '
        Me.btnDel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDel.Location = New System.Drawing.Point(649, 0)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 36)
        Me.btnDel.TabIndex = 14
        Me.btnDel.Text = "Delete"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.UltraExplorerBar1)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(719, 369)
        '
        'UltraExplorerBar1
        '
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl1)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl2)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl3)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl4)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl5)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl6)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl7)
        Me.UltraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill
        UltraExplorerBarGroup1.Container = Me.UltraExplorerBarContainerControl1
        UltraExplorerBarGroup1.Text = "Portion"
        UltraExplorerBarGroup2.Container = Me.UltraExplorerBarContainerControl2
        UltraExplorerBarGroup2.Text = "Group"
        UltraExplorerBarGroup3.Container = Me.UltraExplorerBarContainerControl3
        UltraExplorerBarGroup3.Key = "descrip"
        UltraExplorerBarGroup3.Text = "Description"
        UltraExplorerBarGroup4.Container = Me.UltraExplorerBarContainerControl4
        UltraExplorerBarGroup4.Text = "Specification"
        UltraExplorerBarGroup5.Container = Me.UltraExplorerBarContainerControl5
        UltraExplorerBarGroup5.Text = "Quantity"
        UltraExplorerBarGroup6.Container = Me.UltraExplorerBarContainerControl6
        UltraExplorerBarGroup6.Text = "Material"
        UltraExplorerBarGroup7.Container = Me.UltraExplorerBarContainerControl7
        UltraExplorerBarGroup7.Text = "Remark"
        Me.UltraExplorerBar1.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup1, UltraExplorerBarGroup2, UltraExplorerBarGroup3, UltraExplorerBarGroup4, UltraExplorerBarGroup5, UltraExplorerBarGroup6, UltraExplorerBarGroup7})
        Me.UltraExplorerBar1.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer
        Me.UltraExplorerBar1.Location = New System.Drawing.Point(0, 0)
        Me.UltraExplorerBar1.Name = "UltraExplorerBar1"
        Me.UltraExplorerBar1.Size = New System.Drawing.Size(719, 369)
        Me.UltraExplorerBar1.Style = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarStyle.Toolbox
        Me.UltraExplorerBar1.TabIndex = 1
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(719, 369)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel10)
        Me.UltraTabPageControl2.Controls.Add(Me.Panelbtn)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(719, 369)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(719, 303)
        Me.UltraGrid1.TabIndex = 30
        Me.UltraGrid1.Text = "Bill Of Material"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btnRenumP)
        Me.Panel10.Controls.Add(Me.btnMovePU)
        Me.Panel10.Controls.Add(Me.btnMovePD)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 303)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(719, 30)
        Me.Panel10.TabIndex = 31
        '
        'btnRenumP
        '
        Me.btnRenumP.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRenumP.Location = New System.Drawing.Point(160, 0)
        Me.btnRenumP.Name = "btnRenumP"
        Me.btnRenumP.Size = New System.Drawing.Size(80, 30)
        Me.btnRenumP.TabIndex = 368
        Me.btnRenumP.Text = "Renumber"
        '
        'btnMovePU
        '
        Me.btnMovePU.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMovePU.Location = New System.Drawing.Point(80, 0)
        Me.btnMovePU.Name = "btnMovePU"
        Me.btnMovePU.Size = New System.Drawing.Size(80, 30)
        Me.btnMovePU.TabIndex = 367
        Me.btnMovePU.Text = "Move Up"
        '
        'btnMovePD
        '
        Me.btnMovePD.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMovePD.Location = New System.Drawing.Point(0, 0)
        Me.btnMovePD.Name = "btnMovePD"
        Me.btnMovePD.Size = New System.Drawing.Size(80, 30)
        Me.btnMovePD.TabIndex = 366
        Me.btnMovePD.Text = "Move Down"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(719, 369)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(719, 369)
        Me.UltraGrid2.TabIndex = 31
        Me.UltraGrid2.Text = "Bill Of Material"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGrid3)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(719, 369)
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(719, 369)
        Me.UltraGrid3.TabIndex = 32
        Me.UltraGrid3.Text = "Bill Of Material"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraLabel42)
        Me.Panel2.Controls.Add(Me.txt_ItemNumFixed)
        Me.Panel2.Controls.Add(Me.txt_Remarks)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(723, 80)
        Me.Panel2.TabIndex = 0
        '
        'UltraLabel42
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.UltraLabel42.Appearance = Appearance4
        Me.UltraLabel42.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.UltraLabel42.Location = New System.Drawing.Point(13, 53)
        Me.UltraLabel42.Name = "UltraLabel42"
        Me.UltraLabel42.Size = New System.Drawing.Size(97, 16)
        Me.UltraLabel42.TabIndex = 301
        Me.UltraLabel42.Text = "Item No."
        '
        'txt_ItemNumFixed
        '
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.FontData.ItalicAsString = "False"
        Appearance5.FontData.Name = "Arial"
        Appearance5.FontData.SizeInPoints = 10.0!
        Appearance5.FontData.StrikeoutAsString = "False"
        Appearance5.FontData.UnderlineAsString = "False"
        Me.txt_ItemNumFixed.Appearance = Appearance5
        Me.txt_ItemNumFixed.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ItemNumFixed.Location = New System.Drawing.Point(118, 53)
        Me.txt_ItemNumFixed.Name = "txt_ItemNumFixed"
        Me.txt_ItemNumFixed.Size = New System.Drawing.Size(128, 24)
        Me.txt_ItemNumFixed.TabIndex = 300
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Location = New System.Drawing.Point(118, 16)
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(495, 32)
        Me.txt_Remarks.TabIndex = 78
        Me.txt_Remarks.Text = "UltraTextEditor3"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(32, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Remarks"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 475)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(723, 40)
        Me.Panel4.TabIndex = 5
        '
        'btnSave
        '
        Appearance6.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance6
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(459, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 40)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance7.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance7
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(547, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance8.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance8
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(635, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 40)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 80)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.Panelbtn})
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(723, 395)
        Me.UltraTabControl1.TabIndex = 8
        UltraTab9.ExcludedSharedControls.AddRange(New System.Windows.Forms.Control() {Me.Panelbtn})
        UltraTab9.TabPage = Me.UltraTabPageControl9
        UltraTab9.Text = "Definition"
        UltraTab7.ExcludedSharedControls.AddRange(New System.Windows.Forms.Control() {Me.Panelbtn})
        UltraTab7.Key = "part"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Part File"
        UltraTab6.Key = "param"
        UltraTab6.TabPage = Me.UltraTabPageControl2
        UltraTab6.Text = "Parameters"
        UltraTab12.Key = "wt"
        UltraTab12.TabPage = Me.UltraTabPageControl4
        UltraTab12.Text = "Weight"
        UltraTab4.Key = "area"
        UltraTab4.TabPage = Me.UltraTabPageControl5
        UltraTab4.Text = "Area"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab9, UltraTab7, UltraTab6, UltraTab12, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.Panelbtn)
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(719, 369)
        '
        'frmTFCompDefBOM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Component Definition BOM"
        Me.ClientSize = New System.Drawing.Size(723, 515)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmTFCompDefBOM"
        Me.Text = "Component Definition BOM"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl13.ResumeLayout(False)
        Me.UltraTabPageControl14.ResumeLayout(False)
        Me.UltraTabPageControl15.ResumeLayout(False)
        Me.UltraTabPageControl16.ResumeLayout(False)
        Me.UltraTabPageControl17.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl18.ResumeLayout(False)
        Me.UltraTabPageControl19.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl1.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl2.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl3.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl4.ResumeLayout(False)
        CType(Me.UltraTabControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl4.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl5.ResumeLayout(False)
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl6.ResumeLayout(False)
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl3.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl7.ResumeLayout(False)
        Me.Panelbtn.ResumeLayout(False)
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExplorerBar1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_ItemNumFixed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.UltraTabSharedControlsPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents txt_Remarks As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExplorerBar1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents UltraExplorerBarContainerControl1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents UltraExplorerBarContainerControl2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents txt_GroupNumFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents txt_DescripFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents UltraTabControl4 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_ThkFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_WidthFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl15 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_LengthFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl16 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_DrgFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl5 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl17 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_QtyFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl18 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_AggCodeFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl19 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_AggTextFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl6 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents UltraExplorerBarContainerControl7 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents txt_RemarkFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_QtyTextFormula As ctlFormulaEditorScintilla
    Friend WithEvents txt_PortionNumFormula As ctlFormulaEditorScintilla
    Friend WithEvents UltraLabel42 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ItemNumFixed As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents btnRenumP As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMovePU As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMovePD As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl3 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_MaterialFormula As ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_DensityFormula As ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panelbtn As Windows.Forms.Panel
    Public WithEvents btn_print As Infragistics.Win.Misc.UltraButton
    Public WithEvents btnCopy As Infragistics.Win.Misc.UltraButton
    Public WithEvents btnAdd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid

#End Region
End Class

