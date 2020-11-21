<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFCompDefShot
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraExplorerBarGroup6 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup5 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_SheetNameFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_DeleteSheetsFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl17 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_TitleBlockNameFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl18 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_TitleBlockVarFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraExplorerBarContainerControl1 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.UltraExplorerBarContainerControl3 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.UltraExplorerBarContainerControl4 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.UltraTabControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraExplorerBarContainerControl5 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraExplorerBarContainerControl6 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.txt_EvalCondition = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid7 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panelbtn = New System.Windows.Forms.Panel()
        Me.btnMoveUpChild = New Infragistics.Win.Misc.UltraButton()
        Me.btnMoveDownChild = New Infragistics.Win.Misc.UltraButton()
        Me.btnCopy = New Infragistics.Win.Misc.UltraButton()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.btnAdd = New Infragistics.Win.Misc.UltraButton()
        Me.btnEdit = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExplorerBar1 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chk_CanOverWrite = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cmb_FileType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cmb_ShotType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ShotCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.txt_TemplateFileFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_PaperSizeFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_PaperOrientationFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl13.SuspendLayout()
        Me.UltraTabPageControl14.SuspendLayout()
        Me.UltraTabPageControl17.SuspendLayout()
        Me.UltraTabPageControl18.SuspendLayout()
        Me.UltraExplorerBarContainerControl1.SuspendLayout()
        Me.UltraExplorerBarContainerControl3.SuspendLayout()
        Me.UltraExplorerBarContainerControl4.SuspendLayout()
        CType(Me.UltraTabControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl4.SuspendLayout()
        Me.UltraExplorerBarContainerControl5.SuspendLayout()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        Me.UltraExplorerBarContainerControl6.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGrid7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelbtn.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExplorerBar1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.chk_CanOverWrite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_FileType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ShotType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ShotCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl3.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.txt_SheetNameFormula)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(559, 242)
        '
        'txt_SheetNameFormula
        '
        Me.txt_SheetNameFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_SheetNameFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_SheetNameFormula.LabelText = ""
        Me.txt_SheetNameFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_SheetNameFormula.Name = "txt_SheetNameFormula"
        Me.txt_SheetNameFormula.Size = New System.Drawing.Size(559, 242)
        Me.txt_SheetNameFormula.TabIndex = 2
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.txt_DeleteSheetsFormula)
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(64, 0)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(559, 242)
        '
        'txt_DeleteSheetsFormula
        '
        Me.txt_DeleteSheetsFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_DeleteSheetsFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_DeleteSheetsFormula.LabelText = ""
        Me.txt_DeleteSheetsFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_DeleteSheetsFormula.Name = "txt_DeleteSheetsFormula"
        Me.txt_DeleteSheetsFormula.Size = New System.Drawing.Size(559, 242)
        Me.txt_DeleteSheetsFormula.TabIndex = 2
        '
        'UltraTabPageControl17
        '
        Me.UltraTabPageControl17.Controls.Add(Me.txt_TitleBlockNameFormula)
        Me.UltraTabPageControl17.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl17.Name = "UltraTabPageControl17"
        Me.UltraTabPageControl17.Size = New System.Drawing.Size(542, 221)
        '
        'txt_TitleBlockNameFormula
        '
        Me.txt_TitleBlockNameFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TitleBlockNameFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_TitleBlockNameFormula.LabelText = ""
        Me.txt_TitleBlockNameFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_TitleBlockNameFormula.Name = "txt_TitleBlockNameFormula"
        Me.txt_TitleBlockNameFormula.Size = New System.Drawing.Size(542, 221)
        Me.txt_TitleBlockNameFormula.TabIndex = 3
        '
        'UltraTabPageControl18
        '
        Me.UltraTabPageControl18.Controls.Add(Me.txt_TitleBlockVarFormula)
        Me.UltraTabPageControl18.Location = New System.Drawing.Point(81, 0)
        Me.UltraTabPageControl18.Name = "UltraTabPageControl18"
        Me.UltraTabPageControl18.Size = New System.Drawing.Size(542, 221)
        '
        'txt_TitleBlockVarFormula
        '
        Me.txt_TitleBlockVarFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TitleBlockVarFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_TitleBlockVarFormula.LabelText = ""
        Me.txt_TitleBlockVarFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_TitleBlockVarFormula.Name = "txt_TitleBlockVarFormula"
        Me.txt_TitleBlockVarFormula.Size = New System.Drawing.Size(542, 221)
        Me.txt_TitleBlockVarFormula.TabIndex = 3
        '
        'UltraExplorerBarContainerControl1
        '
        Me.UltraExplorerBarContainerControl1.Controls.Add(Me.txt_TemplateFileFormula)
        Me.UltraExplorerBarContainerControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl1.Name = "UltraExplorerBarContainerControl1"
        Me.UltraExplorerBarContainerControl1.Size = New System.Drawing.Size(623, 242)
        Me.UltraExplorerBarContainerControl1.TabIndex = 0
        Me.UltraExplorerBarContainerControl1.Visible = False
        '
        'UltraExplorerBarContainerControl3
        '
        Me.UltraExplorerBarContainerControl3.Controls.Add(Me.UltraTabControl3)
        Me.UltraExplorerBarContainerControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl3.Name = "UltraExplorerBarContainerControl3"
        Me.UltraExplorerBarContainerControl3.Size = New System.Drawing.Size(623, 242)
        Me.UltraExplorerBarContainerControl3.TabIndex = 2
        Me.UltraExplorerBarContainerControl3.Visible = False
        '
        'UltraExplorerBarContainerControl4
        '
        Me.UltraExplorerBarContainerControl4.Controls.Add(Me.UltraTabControl4)
        Me.UltraExplorerBarContainerControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl4.Name = "UltraExplorerBarContainerControl4"
        Me.UltraExplorerBarContainerControl4.Size = New System.Drawing.Size(623, 242)
        Me.UltraExplorerBarContainerControl4.TabIndex = 3
        Me.UltraExplorerBarContainerControl4.Visible = False
        '
        'UltraTabControl4
        '
        Me.UltraTabControl4.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl13)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl14)
        Me.UltraTabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl4.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl4.Name = "UltraTabControl4"
        Appearance3.FontData.BoldAsString = "True"
        Me.UltraTabControl4.SelectedTabAppearance = Appearance3
        Me.UltraTabControl4.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.UltraTabControl4.Size = New System.Drawing.Size(623, 242)
        Me.UltraTabControl4.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl4.TabIndex = 20
        Me.UltraTabControl4.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        Me.UltraTabControl4.TabPadding = New System.Drawing.Size(10, 1)
        UltraTab7.TabPage = Me.UltraTabPageControl13
        UltraTab7.Text = "Name"
        UltraTab8.TabPage = Me.UltraTabPageControl14
        UltraTab8.Text = "Delete"
        Me.UltraTabControl4.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab7, UltraTab8})
        Me.UltraTabControl4.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(559, 242)
        '
        'UltraExplorerBarContainerControl5
        '
        Me.UltraExplorerBarContainerControl5.Controls.Add(Me.UltraTabControl2)
        Me.UltraExplorerBarContainerControl5.Location = New System.Drawing.Point(3, 108)
        Me.UltraExplorerBarContainerControl5.Name = "UltraExplorerBarContainerControl5"
        Me.UltraExplorerBarContainerControl5.Size = New System.Drawing.Size(623, 221)
        Me.UltraExplorerBarContainerControl5.TabIndex = 4
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl17)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl18)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Appearance6.FontData.BoldAsString = "True"
        Me.UltraTabControl2.SelectedTabAppearance = Appearance6
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(623, 221)
        Me.UltraTabControl2.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl2.TabIndex = 22
        Me.UltraTabControl2.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        Me.UltraTabControl2.TabPadding = New System.Drawing.Size(10, 1)
        UltraTab10.TabPage = Me.UltraTabPageControl17
        UltraTab10.Text = "Name"
        UltraTab11.TabPage = Me.UltraTabPageControl18
        UltraTab11.Text = "Variables"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab10, UltraTab11})
        Me.UltraTabControl2.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(542, 221)
        '
        'UltraExplorerBarContainerControl6
        '
        Me.UltraExplorerBarContainerControl6.Controls.Add(Me.txt_EvalCondition)
        Me.UltraExplorerBarContainerControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl6.Name = "UltraExplorerBarContainerControl6"
        Me.UltraExplorerBarContainerControl6.Size = New System.Drawing.Size(623, 242)
        Me.UltraExplorerBarContainerControl6.TabIndex = 5
        Me.UltraExplorerBarContainerControl6.Visible = False
        '
        'txt_EvalCondition
        '
        Me.txt_EvalCondition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_EvalCondition.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_EvalCondition.LabelText = ""
        Me.txt_EvalCondition.Location = New System.Drawing.Point(0, 0)
        Me.txt_EvalCondition.Name = "txt_EvalCondition"
        Me.txt_EvalCondition.Size = New System.Drawing.Size(623, 242)
        Me.txt_EvalCondition.TabIndex = 3
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGrid7)
        Me.UltraTabPageControl3.Controls.Add(Me.Panelbtn)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(629, 331)
        '
        'UltraGrid7
        '
        Me.UltraGrid7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid7.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid7.Name = "UltraGrid7"
        Me.UltraGrid7.Size = New System.Drawing.Size(629, 295)
        Me.UltraGrid7.TabIndex = 25
        Me.UltraGrid7.Text = "Component Definitions"
        '
        'Panelbtn
        '
        Me.Panelbtn.Controls.Add(Me.btnMoveUpChild)
        Me.Panelbtn.Controls.Add(Me.btnMoveDownChild)
        Me.Panelbtn.Controls.Add(Me.btnCopy)
        Me.Panelbtn.Controls.Add(Me.btnDel)
        Me.Panelbtn.Controls.Add(Me.btnAdd)
        Me.Panelbtn.Controls.Add(Me.btnEdit)
        Me.Panelbtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelbtn.Location = New System.Drawing.Point(0, 295)
        Me.Panelbtn.Name = "Panelbtn"
        Me.Panelbtn.Size = New System.Drawing.Size(629, 36)
        Me.Panelbtn.TabIndex = 26
        '
        'btnMoveUpChild
        '
        Me.btnMoveUpChild.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMoveUpChild.Location = New System.Drawing.Point(233, 0)
        Me.btnMoveUpChild.Name = "btnMoveUpChild"
        Me.btnMoveUpChild.Size = New System.Drawing.Size(80, 36)
        Me.btnMoveUpChild.TabIndex = 367
        Me.btnMoveUpChild.Text = "Move Up"
        '
        'btnMoveDownChild
        '
        Me.btnMoveDownChild.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMoveDownChild.Location = New System.Drawing.Point(313, 0)
        Me.btnMoveDownChild.Name = "btnMoveDownChild"
        Me.btnMoveDownChild.Size = New System.Drawing.Size(80, 36)
        Me.btnMoveDownChild.TabIndex = 366
        Me.btnMoveDownChild.Text = "Move Down"
        '
        'btnCopy
        '
        Me.btnCopy.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCopy.Location = New System.Drawing.Point(393, 0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(59, 36)
        Me.btnCopy.TabIndex = 370
        Me.btnCopy.Text = "Copy"
        '
        'btnDel
        '
        Me.btnDel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDel.Location = New System.Drawing.Point(452, 0)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(59, 36)
        Me.btnDel.TabIndex = 14
        Me.btnDel.Text = "Delete"
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdd.Location = New System.Drawing.Point(511, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(59, 36)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEdit.Location = New System.Drawing.Point(570, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(59, 36)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraExplorerBar1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(629, 353)
        '
        'UltraExplorerBar1
        '
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl1)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl3)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl4)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl5)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl6)
        Me.UltraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill
        UltraExplorerBarGroup6.Container = Me.UltraExplorerBarContainerControl6
        UltraExplorerBarGroup6.Key = "condition"
        UltraExplorerBarGroup6.Text = "Condition"
        UltraExplorerBarGroup1.Container = Me.UltraExplorerBarContainerControl1
        UltraExplorerBarGroup1.Key = "template"
        UltraExplorerBarGroup1.Text = "Template"
        UltraExplorerBarGroup4.Container = Me.UltraExplorerBarContainerControl4
        UltraExplorerBarGroup4.Key = "sheet"
        UltraExplorerBarGroup4.Text = "Sheet"
        UltraExplorerBarGroup3.Container = Me.UltraExplorerBarContainerControl3
        UltraExplorerBarGroup3.Key = "paper"
        UltraExplorerBarGroup3.Text = "Paper"
        UltraExplorerBarGroup5.Container = Me.UltraExplorerBarContainerControl5
        UltraExplorerBarGroup5.Key = "title"
        UltraExplorerBarGroup5.Text = "Title Block"
        Me.UltraExplorerBar1.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup6, UltraExplorerBarGroup1, UltraExplorerBarGroup4, UltraExplorerBarGroup3, UltraExplorerBarGroup5})
        Me.UltraExplorerBar1.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer
        Me.UltraExplorerBar1.Location = New System.Drawing.Point(0, 0)
        Me.UltraExplorerBar1.Name = "UltraExplorerBar1"
        Me.UltraExplorerBar1.Size = New System.Drawing.Size(629, 353)
        Me.UltraExplorerBar1.Style = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarStyle.Toolbox
        Me.UltraExplorerBar1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chk_CanOverWrite)
        Me.Panel2.Controls.Add(Me.cmb_FileType)
        Me.Panel2.Controls.Add(Me.cmb_ShotType)
        Me.Panel2.Controls.Add(Me.UltraLabel3)
        Me.Panel2.Controls.Add(Me.UltraLabel2)
        Me.Panel2.Controls.Add(Me.txt_ShotCode)
        Me.Panel2.Controls.Add(Me.UltraLabel1)
        Me.Panel2.Controls.Add(Me.txt_Remark)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(633, 130)
        Me.Panel2.TabIndex = 0
        '
        'chk_CanOverWrite
        '
        Appearance7.FontData.BoldAsString = "False"
        Appearance7.FontData.SizeInPoints = 8.0!
        Me.chk_CanOverWrite.Appearance = Appearance7
        Me.chk_CanOverWrite.Location = New System.Drawing.Point(314, 66)
        Me.chk_CanOverWrite.Name = "chk_CanOverWrite"
        Me.chk_CanOverWrite.Size = New System.Drawing.Size(286, 20)
        Me.chk_CanOverWrite.TabIndex = 354
        Me.chk_CanOverWrite.Text = "Can Overwrite existing file/sheet"
        '
        'cmb_FileType
        '
        Me.cmb_FileType.Location = New System.Drawing.Point(118, 66)
        Me.cmb_FileType.Name = "cmb_FileType"
        Me.cmb_FileType.Size = New System.Drawing.Size(181, 21)
        Me.cmb_FileType.TabIndex = 2
        Me.cmb_FileType.Text = "UltraComboEditor1"
        '
        'cmb_ShotType
        '
        Me.cmb_ShotType.Location = New System.Drawing.Point(118, 39)
        Me.cmb_ShotType.Name = "cmb_ShotType"
        Me.cmb_ShotType.Size = New System.Drawing.Size(181, 21)
        Me.cmb_ShotType.TabIndex = 1
        Me.cmb_ShotType.Text = "UltraComboEditor1"
        '
        'UltraLabel3
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.Location = New System.Drawing.Point(29, 70)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(83, 14)
        Me.UltraLabel3.TabIndex = 350
        Me.UltraLabel3.Text = "FileType"
        '
        'UltraLabel2
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance4
        Me.UltraLabel2.Location = New System.Drawing.Point(29, 43)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(83, 14)
        Me.UltraLabel2.TabIndex = 348
        Me.UltraLabel2.Text = "Type"
        '
        'txt_ShotCode
        '
        Appearance11.FontData.BoldAsString = "False"
        Appearance11.FontData.ItalicAsString = "False"
        Appearance11.FontData.Name = "Arial"
        Appearance11.FontData.SizeInPoints = 8.25!
        Appearance11.FontData.StrikeoutAsString = "False"
        Appearance11.FontData.UnderlineAsString = "False"
        Me.txt_ShotCode.Appearance = Appearance11
        Me.txt_ShotCode.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_ShotCode.Location = New System.Drawing.Point(118, 12)
        Me.txt_ShotCode.Name = "txt_ShotCode"
        Me.txt_ShotCode.Size = New System.Drawing.Size(181, 21)
        Me.txt_ShotCode.TabIndex = 0
        '
        'UltraLabel1
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance8
        Me.UltraLabel1.Location = New System.Drawing.Point(29, 12)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(83, 14)
        Me.UltraLabel1.TabIndex = 346
        Me.UltraLabel1.Text = "Code"
        '
        'txt_Remark
        '
        Me.txt_Remark.Location = New System.Drawing.Point(118, 93)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(482, 32)
        Me.txt_Remark.TabIndex = 3
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(29, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Remark"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 509)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(633, 40)
        Me.Panel4.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance5
        Me.btnSave.Location = New System.Drawing.Point(346, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance10.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance10
        Me.btnCancel.Location = New System.Drawing.Point(442, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance1
        Me.btnOK.Location = New System.Drawing.Point(538, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(629, 353)
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 130)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(633, 379)
        Me.UltraTabControl1.TabIndex = 8
        UltraTab2.Key = "param"
        UltraTab2.TabPage = Me.UltraTabPageControl1
        UltraTab2.Text = "Parameters"
        UltraTab3.Key = "det"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Children"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab3})
        '
        'txt_TemplateFileFormula
        '
        Me.txt_TemplateFileFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TemplateFileFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_TemplateFileFormula.LabelText = ""
        Me.txt_TemplateFileFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_TemplateFileFormula.Name = "txt_TemplateFileFormula"
        Me.txt_TemplateFileFormula.Size = New System.Drawing.Size(623, 242)
        Me.txt_TemplateFileFormula.TabIndex = 3
        '
        'UltraTabControl3
        '
        Me.UltraTabControl3.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl3.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl3.Name = "UltraTabControl3"
        Appearance9.FontData.BoldAsString = "True"
        Me.UltraTabControl3.SelectedTabAppearance = Appearance9
        Me.UltraTabControl3.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl3.Size = New System.Drawing.Size(623, 242)
        Me.UltraTabControl3.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl3.TabIndex = 21
        Me.UltraTabControl3.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        Me.UltraTabControl3.TabPadding = New System.Drawing.Size(10, 1)
        UltraTab1.TabPage = Me.UltraTabPageControl2
        UltraTab1.Text = "Size"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Orientation"
        Me.UltraTabControl3.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab4})
        Me.UltraTabControl3.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(532, 242)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.txt_PaperSizeFormula)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(532, 242)
        '
        'txt_PaperSizeFormula
        '
        Me.txt_PaperSizeFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_PaperSizeFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_PaperSizeFormula.LabelText = ""
        Me.txt_PaperSizeFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_PaperSizeFormula.Name = "txt_PaperSizeFormula"
        Me.txt_PaperSizeFormula.Size = New System.Drawing.Size(532, 242)
        Me.txt_PaperSizeFormula.TabIndex = 2
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.txt_PaperOrientationFormula)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(91, 0)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(532, 242)
        '
        'txt_PaperOrientationFormula
        '
        Me.txt_PaperOrientationFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_PaperOrientationFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_PaperOrientationFormula.LabelText = ""
        Me.txt_PaperOrientationFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_PaperOrientationFormula.Name = "txt_PaperOrientationFormula"
        Me.txt_PaperOrientationFormula.Size = New System.Drawing.Size(532, 242)
        Me.txt_PaperOrientationFormula.TabIndex = 2
        '
        'frmTFCompDefShot
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Component SnapShot"
        Me.ClientSize = New System.Drawing.Size(633, 549)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "frmTFCompDefShot"
        Me.Text = "Component SnapShot"
        Me.UltraTabPageControl13.ResumeLayout(False)
        Me.UltraTabPageControl14.ResumeLayout(False)
        Me.UltraTabPageControl17.ResumeLayout(False)
        Me.UltraTabPageControl18.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl1.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl3.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl4.ResumeLayout(False)
        CType(Me.UltraTabControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl4.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl5.ResumeLayout(False)
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl6.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGrid7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelbtn.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExplorerBar1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.chk_CanOverWrite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_FileType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ShotType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ShotCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl3.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ShotCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cmb_ShotType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraGrid7 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnMoveUpChild As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMoveDownChild As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panelbtn As System.Windows.Forms.Panel
    Public WithEvents btnCopy As Infragistics.Win.Misc.UltraButton
    Public WithEvents btnAdd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraExplorerBar1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents UltraExplorerBarContainerControl1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents UltraExplorerBarContainerControl3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents UltraExplorerBarContainerControl4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents UltraTabControl4 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_SheetNameFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_DeleteSheetsFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl5 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl17 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_TitleBlockNameFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl18 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_TitleBlockVarFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl6 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents txt_EvalCondition As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents cmb_FileType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chk_CanOverWrite As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_TemplateFileFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabControl3 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_PaperSizeFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_PaperOrientationFormula As risersoft.shared.win.ctlFormulaEditorScintilla

#End Region
End Class

