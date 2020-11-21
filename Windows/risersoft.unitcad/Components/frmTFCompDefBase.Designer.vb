Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFCompDefBase
    Inherits frmMax
#Region " Windows Form Designer generated code "


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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab21 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab22 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab23 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab19 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab20 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab17 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid7 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnRenumChild = New Infragistics.Win.Misc.UltraButton()
        Me.btnMoveUpChild = New Infragistics.Win.Misc.UltraButton()
        Me.btnMoveDownChild = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl15 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid8 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.PanelAction = New System.Windows.Forms.Panel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnApplySelected = New Infragistics.Win.Misc.UltraButton()
        Me.btnApplyActions = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl19 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid13 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btn_GenChildrenLeaf = New Infragistics.Win.Misc.UltraButton()
        Me.btnDown = New Infragistics.Win.Misc.UltraButton()
        Me.btn_GenChildRenLevelTop = New Infragistics.Win.Misc.UltraButton()
        Me.btnUp = New Infragistics.Win.Misc.UltraButton()
        Me.btnRenumber = New Infragistics.Win.Misc.UltraButton()
        Me.btn_GenChildRenLevel1 = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid9 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_DesTableID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_DesTableCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmb_DTSelColID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_DTLocalParamCode = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panelbtn = New System.Windows.Forms.Panel()
        Me.btn_print = New Infragistics.Win.Misc.UltraButton()
        Me.btnCopy = New Infragistics.Win.Misc.UltraButton()
        Me.btnAdd = New Infragistics.Win.Misc.UltraButton()
        Me.btnEdit = New Infragistics.Win.Misc.UltraButton()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControlRules = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControlMat = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl18 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid4 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3D = New System.Windows.Forms.Panel()
        Me.btn_TakeShots = New Infragistics.Win.Misc.UltraButton()
        Me.btnGenWorkFeat = New Infragistics.Win.Misc.UltraButton()
        Me.btnGenEnt = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.UltraGrid12 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGrid11 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid10 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl16 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_ParamEditorClass = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.chk_TreatLib = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTabPageControl17 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.chk_RemoveConstraints = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cmb_ViewName = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_IntDesignCode = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.lblInternal = New Infragistics.Win.Misc.UltraLabel()
        Me.btnMakeModel = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_CompType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.utcDim = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_DefGroup = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.chk_CreateNewASM = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cmb_ParamBehave = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Descrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.CtlPIDUnitID1 = New risersoft.[shared].win.ctlPIDUnitID()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_CompDefCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnExport = New Infragistics.Win.Misc.UltraButton()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl12.SuspendLayout()
        CType(Me.UltraGrid7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.UltraTabPageControl15.SuspendLayout()
        CType(Me.UltraGrid8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAction.SuspendLayout()
        Me.UltraTabPageControl19.SuspendLayout()
        CType(Me.UltraGrid13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.UltraGrid9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.cmb_DesTableID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DesTableCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_DTSelColID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_DTLocalParamCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Panelbtn.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraTabControlRules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControlRules.SuspendLayout()
        Me.UltraTabPageControl11.SuspendLayout()
        CType(Me.UltraTabControlMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControlMat.SuspendLayout()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        Me.UltraTabPageControl18.SuspendLayout()
        CType(Me.UltraGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3D.SuspendLayout()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.UltraGrid12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.UltraGrid10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl16.SuspendLayout()
        CType(Me.txt_ParamEditorClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_TreatLib, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl17.SuspendLayout()
        CType(Me.chk_RemoveConstraints, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ViewName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_IntDesignCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.UltraTabSharedControlsPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_CompType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utcDim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utcDim.SuspendLayout()
        CType(Me.cmb_DefGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_CreateNewASM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ParamBehave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Descrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CompDefCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.UltraGrid7)
        Me.UltraTabPageControl12.Controls.Add(Me.Panel9)
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(98, 0)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(682, 389)
        '
        'UltraGrid7
        '
        Me.UltraGrid7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid7.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid7.Name = "UltraGrid7"
        Me.UltraGrid7.Size = New System.Drawing.Size(682, 345)
        Me.UltraGrid7.TabIndex = 23
        Me.UltraGrid7.Text = "Component Definitions"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnRenumChild)
        Me.Panel9.Controls.Add(Me.btnMoveUpChild)
        Me.Panel9.Controls.Add(Me.btnMoveDownChild)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 345)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(682, 44)
        Me.Panel9.TabIndex = 22
        '
        'btnRenumChild
        '
        Me.btnRenumChild.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRenumChild.Location = New System.Drawing.Point(604, 14)
        Me.btnRenumChild.Name = "btnRenumChild"
        Me.btnRenumChild.Size = New System.Drawing.Size(70, 24)
        Me.btnRenumChild.TabIndex = 368
        Me.btnRenumChild.Text = "Renumber"
        Me.btnRenumChild.Visible = False
        '
        'btnMoveUpChild
        '
        Me.btnMoveUpChild.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveUpChild.Location = New System.Drawing.Point(517, 14)
        Me.btnMoveUpChild.Name = "btnMoveUpChild"
        Me.btnMoveUpChild.Size = New System.Drawing.Size(80, 24)
        Me.btnMoveUpChild.TabIndex = 367
        Me.btnMoveUpChild.Text = "Move Up"
        '
        'btnMoveDownChild
        '
        Me.btnMoveDownChild.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveDownChild.Location = New System.Drawing.Point(430, 14)
        Me.btnMoveDownChild.Name = "btnMoveDownChild"
        Me.btnMoveDownChild.Size = New System.Drawing.Size(80, 24)
        Me.btnMoveDownChild.TabIndex = 366
        Me.btnMoveDownChild.Text = "Move Down"
        '
        'UltraTabPageControl15
        '
        Me.UltraTabPageControl15.Controls.Add(Me.UltraGrid8)
        Me.UltraTabPageControl15.Controls.Add(Me.PanelAction)
        Me.UltraTabPageControl15.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl15.Name = "UltraTabPageControl15"
        Me.UltraTabPageControl15.Size = New System.Drawing.Size(682, 389)
        '
        'UltraGrid8
        '
        Me.UltraGrid8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid8.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid8.Name = "UltraGrid8"
        Me.UltraGrid8.Size = New System.Drawing.Size(682, 339)
        Me.UltraGrid8.TabIndex = 29
        Me.UltraGrid8.Text = "Action Packs"
        '
        'PanelAction
        '
        Me.PanelAction.Controls.Add(Me.UltraLabel3)
        Me.PanelAction.Controls.Add(Me.btnApplySelected)
        Me.PanelAction.Controls.Add(Me.btnApplyActions)
        Me.PanelAction.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelAction.Location = New System.Drawing.Point(0, 339)
        Me.PanelAction.Name = "PanelAction"
        Me.PanelAction.Size = New System.Drawing.Size(682, 50)
        Me.PanelAction.TabIndex = 30
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance1
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(377, 18)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(242, 14)
        Me.UltraLabel3.TabIndex = 367
        Me.UltraLabel3.Text = "Action Pack needs to be empty before deletion."
        '
        'btnApplySelected
        '
        Me.btnApplySelected.Location = New System.Drawing.Point(123, 0)
        Me.btnApplySelected.Name = "btnApplySelected"
        Me.btnApplySelected.Size = New System.Drawing.Size(129, 42)
        Me.btnApplySelected.TabIndex = 366
        Me.btnApplySelected.Text = "Apply Selected Actions"
        '
        'btnApplyActions
        '
        Me.btnApplyActions.Location = New System.Drawing.Point(19, 0)
        Me.btnApplyActions.Name = "btnApplyActions"
        Me.btnApplyActions.Size = New System.Drawing.Size(99, 42)
        Me.btnApplyActions.TabIndex = 365
        Me.btnApplyActions.Text = "Apply All Actions"
        '
        'UltraTabPageControl19
        '
        Me.UltraTabPageControl19.Controls.Add(Me.UltraGrid13)
        Me.UltraTabPageControl19.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl19.Name = "UltraTabPageControl19"
        Me.UltraTabPageControl19.Size = New System.Drawing.Size(682, 389)
        '
        'UltraGrid13
        '
        Me.UltraGrid13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid13.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid13.Name = "UltraGrid13"
        Me.UltraGrid13.Size = New System.Drawing.Size(682, 389)
        Me.UltraGrid13.TabIndex = 29
        Me.UltraGrid13.Text = "Action Packs"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGrid3)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel8)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(93, 0)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(687, 389)
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(687, 344)
        Me.UltraGrid3.TabIndex = 26
        Me.UltraGrid3.Text = "Detail BOM"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btn_GenChildrenLeaf)
        Me.Panel8.Controls.Add(Me.btnDown)
        Me.Panel8.Controls.Add(Me.btn_GenChildRenLevelTop)
        Me.Panel8.Controls.Add(Me.btnUp)
        Me.Panel8.Controls.Add(Me.btnRenumber)
        Me.Panel8.Controls.Add(Me.btn_GenChildRenLevel1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 344)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(687, 45)
        Me.Panel8.TabIndex = 27
        '
        'btn_GenChildrenLeaf
        '
        Me.btn_GenChildrenLeaf.Location = New System.Drawing.Point(11, 3)
        Me.btn_GenChildrenLeaf.Name = "btn_GenChildrenLeaf"
        Me.btn_GenChildrenLeaf.Size = New System.Drawing.Size(113, 42)
        Me.btn_GenChildrenLeaf.TabIndex = 360
        Me.btn_GenChildrenLeaf.Text = "Generate BOM Leaf Nodes"
        Me.btn_GenChildrenLeaf.Visible = False
        '
        'btnDown
        '
        Me.btnDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDown.Location = New System.Drawing.Point(425, 15)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(80, 24)
        Me.btnDown.TabIndex = 363
        Me.btnDown.Text = "Move Down"
        '
        'btn_GenChildRenLevelTop
        '
        Me.btn_GenChildRenLevelTop.Location = New System.Drawing.Point(236, 3)
        Me.btn_GenChildRenLevelTop.Name = "btn_GenChildRenLevelTop"
        Me.btn_GenChildRenLevelTop.Size = New System.Drawing.Size(108, 42)
        Me.btn_GenChildRenLevelTop.TabIndex = 362
        Me.btn_GenChildRenLevelTop.Text = "Generate BOM Top Level Only"
        Me.btn_GenChildRenLevelTop.Visible = False
        '
        'btnUp
        '
        Me.btnUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUp.Location = New System.Drawing.Point(512, 15)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(80, 24)
        Me.btnUp.TabIndex = 364
        Me.btnUp.Text = "Move Up"
        '
        'btnRenumber
        '
        Me.btnRenumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRenumber.Location = New System.Drawing.Point(599, 15)
        Me.btnRenumber.Name = "btnRenumber"
        Me.btnRenumber.Size = New System.Drawing.Size(80, 24)
        Me.btnRenumber.TabIndex = 365
        Me.btnRenumber.Text = "Renumber"
        '
        'btn_GenChildRenLevel1
        '
        Me.btn_GenChildRenLevel1.Location = New System.Drawing.Point(130, 3)
        Me.btn_GenChildRenLevel1.Name = "btn_GenChildRenLevel1"
        Me.btn_GenChildRenLevel1.Size = New System.Drawing.Size(100, 42)
        Me.btn_GenChildRenLevel1.TabIndex = 361
        Me.btn_GenChildRenLevel1.Text = "Generate BOM Level 1"
        Me.btn_GenChildRenLevel1.Visible = False
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(687, 389)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(687, 389)
        Me.UltraGrid2.TabIndex = 27
        Me.UltraGrid2.Text = "Detail BOM"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(0, 22)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(780, 367)
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraGrid9)
        Me.UltraTabPageControl7.Controls.Add(Me.Panel6)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(780, 367)
        '
        'UltraGrid9
        '
        Me.UltraGrid9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid9.Location = New System.Drawing.Point(445, 0)
        Me.UltraGrid9.Name = "UltraGrid9"
        Me.UltraGrid9.Size = New System.Drawing.Size(335, 367)
        Me.UltraGrid9.TabIndex = 19
        Me.UltraGrid9.Text = "Select Columns"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.cmb_DesTableID)
        Me.Panel6.Controls.Add(Me.txt_DesTableCode)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.cmb_DTSelColID)
        Me.Panel6.Controls.Add(Me.cmb_DTLocalParamCode)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(445, 367)
        Me.Panel6.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(153, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(289, 15)
        Me.Label4.TabIndex = 349
        Me.Label4.Text = "Leave Design Table for Data Blank if same as for Columns"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 24)
        Me.Label3.TabIndex = 348
        Me.Label3.Text = "Design Table for Columns"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_DesTableID
        '
        Me.cmb_DesTableID.DataMember = "Table1"
        Me.cmb_DesTableID.DisplayMember = "ParamCode"
        Me.cmb_DesTableID.Location = New System.Drawing.Point(151, 60)
        Me.cmb_DesTableID.MaxDropDownItems = 15
        Me.cmb_DesTableID.Name = "cmb_DesTableID"
        Me.cmb_DesTableID.Size = New System.Drawing.Size(272, 22)
        Me.cmb_DesTableID.TabIndex = 347
        Me.cmb_DesTableID.Text = "UltraCombo1"
        Me.cmb_DesTableID.ValueMember = "ParamCode"
        '
        'txt_DesTableCode
        '
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.ItalicAsString = "False"
        Appearance2.FontData.Name = "Arial"
        Appearance2.FontData.SizeInPoints = 8.25!
        Appearance2.FontData.StrikeoutAsString = "False"
        Appearance2.FontData.UnderlineAsString = "False"
        Me.txt_DesTableCode.Appearance = Appearance2
        Me.txt_DesTableCode.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_DesTableCode.Location = New System.Drawing.Point(151, 88)
        Me.txt_DesTableCode.Name = "txt_DesTableCode"
        Me.txt_DesTableCode.Size = New System.Drawing.Size(181, 21)
        Me.txt_DesTableCode.TabIndex = 346
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(151, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 15)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "Leave Selection Column Blank for Row Index"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 24)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Local Parameter"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(12, 116)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(131, 15)
        Me.Label20.TabIndex = 170
        Me.Label20.Text = "Selection Column"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label20.Visible = False
        '
        'cmb_DTSelColID
        '
        Me.cmb_DTSelColID.Location = New System.Drawing.Point(151, 115)
        Me.cmb_DTSelColID.Name = "cmb_DTSelColID"
        Me.cmb_DTSelColID.Size = New System.Drawing.Size(270, 22)
        Me.cmb_DTSelColID.TabIndex = 169
        Me.cmb_DTSelColID.Text = "UltraCombo4"
        Me.cmb_DTSelColID.Visible = False
        '
        'cmb_DTLocalParamCode
        '
        Me.cmb_DTLocalParamCode.DataMember = "Table1"
        Me.cmb_DTLocalParamCode.DisplayMember = "ParamCode"
        Me.cmb_DTLocalParamCode.Location = New System.Drawing.Point(151, 32)
        Me.cmb_DTLocalParamCode.MaxDropDownItems = 15
        Me.cmb_DTLocalParamCode.Name = "cmb_DTLocalParamCode"
        Me.cmb_DTLocalParamCode.Size = New System.Drawing.Size(272, 22)
        Me.cmb_DTLocalParamCode.TabIndex = 168
        Me.cmb_DTLocalParamCode.Text = "UltraCombo1"
        Me.cmb_DTLocalParamCode.ValueMember = "ParamCode"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(11, 87)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(132, 22)
        Me.Label21.TabIndex = 167
        Me.Label21.Text = "Design Table for Data"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Panelbtn)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(780, 389)
        '
        'Panelbtn
        '
        Me.Panelbtn.Controls.Add(Me.btn_print)
        Me.Panelbtn.Controls.Add(Me.btnCopy)
        Me.Panelbtn.Controls.Add(Me.btnAdd)
        Me.Panelbtn.Controls.Add(Me.btnEdit)
        Me.Panelbtn.Controls.Add(Me.btnDel)
        Me.Panelbtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelbtn.Location = New System.Drawing.Point(0, 347)
        Me.Panelbtn.Name = "Panelbtn"
        Me.Panelbtn.Size = New System.Drawing.Size(780, 42)
        Me.Panelbtn.TabIndex = 23
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Location = New System.Drawing.Point(450, 6)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(58, 24)
        Me.btn_print.TabIndex = 371
        Me.btn_print.Text = "Print"
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopy.Location = New System.Drawing.Point(512, 6)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(59, 24)
        Me.btnCopy.TabIndex = 370
        Me.btnCopy.Text = "Copy"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(575, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(59, 24)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(638, 6)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(59, 24)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Location = New System.Drawing.Point(701, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(59, 24)
        Me.btnDel.TabIndex = 14
        Me.btnDel.Text = "Delete"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraTabControlRules)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(780, 389)
        '
        'UltraTabControlRules
        '
        Me.UltraTabControlRules.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.UltraTabControlRules.Controls.Add(Me.UltraTabPageControl12)
        Me.UltraTabControlRules.Controls.Add(Me.UltraTabPageControl15)
        Me.UltraTabControlRules.Controls.Add(Me.UltraTabPageControl19)
        Me.UltraTabControlRules.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControlRules.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControlRules.Name = "UltraTabControlRules"
        Appearance3.FontData.BoldAsString = "True"
        Me.UltraTabControlRules.SelectedTabAppearance = Appearance3
        Me.UltraTabControlRules.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.UltraTabControlRules.Size = New System.Drawing.Size(780, 389)
        Me.UltraTabControlRules.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControlRules.TabIndex = 24
        Me.UltraTabControlRules.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        UltraTab21.Key = "child"
        UltraTab21.TabPage = Me.UltraTabPageControl12
        UltraTab21.Text = "Child Rules"
        UltraTab22.Key = "action"
        UltraTab22.TabPage = Me.UltraTabPageControl15
        UltraTab22.Text = "Action Rules"
        UltraTab23.Key = "snapshot"
        UltraTab23.TabPage = Me.UltraTabPageControl19
        UltraTab23.Text = "Snapshot Rules"
        Me.UltraTabControlRules.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab21, UltraTab22, UltraTab23})
        Me.UltraTabControlRules.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(682, 389)
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.UltraTabControlMat)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(780, 389)
        '
        'UltraTabControlMat
        '
        Me.UltraTabControlMat.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.UltraTabControlMat.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControlMat.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControlMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControlMat.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControlMat.Name = "UltraTabControlMat"
        Appearance4.FontData.BoldAsString = "True"
        Me.UltraTabControlMat.SelectedTabAppearance = Appearance4
        Me.UltraTabControlMat.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.UltraTabControlMat.Size = New System.Drawing.Size(780, 389)
        Me.UltraTabControlMat.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControlMat.TabIndex = 25
        Me.UltraTabControlMat.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        UltraTab10.Key = "bom"
        UltraTab10.TabPage = Me.UltraTabPageControl3
        UltraTab10.Text = "Bill-Of-Material"
        UltraTab11.Key = "vol"
        UltraTab11.TabPage = Me.UltraTabPageControl4
        UltraTab11.Text = "Volume"
        Me.UltraTabControlMat.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab10, UltraTab11})
        Me.UltraTabControlMat.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(687, 389)
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraTabControl2)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(780, 389)
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(780, 389)
        Me.UltraTabControl2.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl2.TabIndex = 17
        UltraTab6.Key = "file"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Fixed File"
        UltraTab7.Key = "destab"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Design Table Based"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab7})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(780, 367)
        '
        'UltraTabPageControl18
        '
        Me.UltraTabPageControl18.Controls.Add(Me.UltraGrid4)
        Me.UltraTabPageControl18.Controls.Add(Me.Panel3D)
        Me.UltraTabPageControl18.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl18.Name = "UltraTabPageControl18"
        Me.UltraTabPageControl18.Size = New System.Drawing.Size(780, 389)
        '
        'UltraGrid4
        '
        Me.UltraGrid4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid4.Name = "UltraGrid4"
        Me.UltraGrid4.Size = New System.Drawing.Size(780, 339)
        Me.UltraGrid4.TabIndex = 25
        Me.UltraGrid4.Text = "Entities"
        '
        'Panel3D
        '
        Me.Panel3D.Controls.Add(Me.btn_TakeShots)
        Me.Panel3D.Controls.Add(Me.btnGenWorkFeat)
        Me.Panel3D.Controls.Add(Me.btnGenEnt)
        Me.Panel3D.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3D.Location = New System.Drawing.Point(0, 339)
        Me.Panel3D.Name = "Panel3D"
        Me.Panel3D.Size = New System.Drawing.Size(780, 50)
        Me.Panel3D.TabIndex = 24
        '
        'btn_TakeShots
        '
        Me.btn_TakeShots.Location = New System.Drawing.Point(11, 6)
        Me.btn_TakeShots.Name = "btn_TakeShots"
        Me.btn_TakeShots.Size = New System.Drawing.Size(98, 42)
        Me.btn_TakeShots.TabIndex = 367
        Me.btn_TakeShots.Text = "Take Snapshots"
        '
        'btnGenWorkFeat
        '
        Me.btnGenWorkFeat.Location = New System.Drawing.Point(114, 6)
        Me.btnGenWorkFeat.Name = "btnGenWorkFeat"
        Me.btnGenWorkFeat.Size = New System.Drawing.Size(117, 42)
        Me.btnGenWorkFeat.TabIndex = 364
        Me.btnGenWorkFeat.Text = "Generate Work Features"
        '
        'btnGenEnt
        '
        Me.btnGenEnt.Location = New System.Drawing.Point(237, 6)
        Me.btnGenEnt.Name = "btnGenEnt"
        Me.btnGenEnt.Size = New System.Drawing.Size(117, 42)
        Me.btnGenEnt.TabIndex = 360
        Me.btnGenEnt.Text = "Generate Entities"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.Splitter1)
        Me.UltraTabPageControl8.Controls.Add(Me.UltraGrid12)
        Me.UltraTabPageControl8.Controls.Add(Me.UltraGrid11)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(780, 389)
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 153)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(780, 5)
        Me.Splitter1.TabIndex = 30
        Me.Splitter1.TabStop = False
        '
        'UltraGrid12
        '
        Me.UltraGrid12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid12.Location = New System.Drawing.Point(0, 153)
        Me.UltraGrid12.Name = "UltraGrid12"
        Me.UltraGrid12.Size = New System.Drawing.Size(780, 236)
        Me.UltraGrid12.TabIndex = 29
        Me.UltraGrid12.Text = "Undefined Rows"
        '
        'UltraGrid11
        '
        Me.UltraGrid11.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGrid11.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid11.Name = "UltraGrid11"
        Me.UltraGrid11.Size = New System.Drawing.Size(780, 153)
        Me.UltraGrid11.TabIndex = 28
        Me.UltraGrid11.Text = "Defined Rows"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.UltraGrid10)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(780, 389)
        '
        'UltraGrid10
        '
        Me.UltraGrid10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid10.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid10.Name = "UltraGrid10"
        Me.UltraGrid10.Size = New System.Drawing.Size(780, 389)
        Me.UltraGrid10.TabIndex = 24
        Me.UltraGrid10.Text = "Library Folders"
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(780, 389)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(780, 389)
        Me.UltraGrid1.TabIndex = 25
        Me.UltraGrid1.Text = "Library Folders"
        '
        'UltraTabPageControl16
        '
        Me.UltraTabPageControl16.Controls.Add(Me.txt_ParamEditorClass)
        Me.UltraTabPageControl16.Controls.Add(Me.UltraLabel8)
        Me.UltraTabPageControl16.Controls.Add(Me.chk_TreatLib)
        Me.UltraTabPageControl16.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabPageControl16.Name = "UltraTabPageControl16"
        Me.UltraTabPageControl16.Size = New System.Drawing.Size(393, 75)
        '
        'txt_ParamEditorClass
        '
        Appearance5.FontData.BoldAsString = "False"
        Appearance5.FontData.ItalicAsString = "False"
        Appearance5.FontData.Name = "Arial"
        Appearance5.FontData.SizeInPoints = 8.25!
        Appearance5.FontData.StrikeoutAsString = "False"
        Appearance5.FontData.UnderlineAsString = "False"
        Me.txt_ParamEditorClass.Appearance = Appearance5
        Me.txt_ParamEditorClass.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_ParamEditorClass.Location = New System.Drawing.Point(113, 33)
        Me.txt_ParamEditorClass.Name = "txt_ParamEditorClass"
        Me.txt_ParamEditorClass.Size = New System.Drawing.Size(276, 21)
        Me.txt_ParamEditorClass.TabIndex = 352
        '
        'UltraLabel8
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel8.Appearance = Appearance6
        Me.UltraLabel8.Location = New System.Drawing.Point(24, 34)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(83, 20)
        Me.UltraLabel8.TabIndex = 351
        Me.UltraLabel8.Text = "Editor"
        '
        'chk_TreatLib
        '
        Appearance7.FontData.BoldAsString = "False"
        Appearance7.FontData.SizeInPoints = 8.0!
        Me.chk_TreatLib.Appearance = Appearance7
        Me.chk_TreatLib.Location = New System.Drawing.Point(49, 7)
        Me.chk_TreatLib.Name = "chk_TreatLib"
        Me.chk_TreatLib.Size = New System.Drawing.Size(340, 20)
        Me.chk_TreatLib.TabIndex = 350
        Me.chk_TreatLib.Text = "Treat as Library component. Do not copy to Work Order directory"
        '
        'UltraTabPageControl17
        '
        Me.UltraTabPageControl17.Controls.Add(Me.chk_RemoveConstraints)
        Me.UltraTabPageControl17.Controls.Add(Me.cmb_ViewName)
        Me.UltraTabPageControl17.Controls.Add(Me.UltraLabel7)
        Me.UltraTabPageControl17.Controls.Add(Me.cmb_IntDesignCode)
        Me.UltraTabPageControl17.Controls.Add(Me.lblInternal)
        Me.UltraTabPageControl17.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl17.Name = "UltraTabPageControl17"
        Me.UltraTabPageControl17.Size = New System.Drawing.Size(393, 75)
        '
        'chk_RemoveConstraints
        '
        Appearance8.FontData.BoldAsString = "False"
        Appearance8.FontData.SizeInPoints = 8.0!
        Me.chk_RemoveConstraints.Appearance = Appearance8
        Me.chk_RemoveConstraints.AutoSize = True
        Me.chk_RemoveConstraints.Location = New System.Drawing.Point(68, 57)
        Me.chk_RemoveConstraints.Name = "chk_RemoveConstraints"
        Me.chk_RemoveConstraints.Size = New System.Drawing.Size(223, 17)
        Me.chk_RemoveConstraints.TabIndex = 359
        Me.chk_RemoveConstraints.Text = "Remove any parametric block constraints"
        '
        'cmb_ViewName
        '
        Me.cmb_ViewName.Location = New System.Drawing.Point(185, 3)
        Me.cmb_ViewName.Name = "cmb_ViewName"
        Me.cmb_ViewName.Size = New System.Drawing.Size(208, 21)
        Me.cmb_ViewName.TabIndex = 358
        Me.cmb_ViewName.Text = "UltraComboEditor1"
        '
        'UltraLabel7
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance9
        Me.UltraLabel7.Location = New System.Drawing.Point(35, 3)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(142, 21)
        Me.UltraLabel7.TabIndex = 357
        Me.UltraLabel7.Text = "View"
        '
        'cmb_IntDesignCode
        '
        Me.cmb_IntDesignCode.LimitToList = True
        Me.cmb_IntDesignCode.Location = New System.Drawing.Point(185, 30)
        Me.cmb_IntDesignCode.Name = "cmb_IntDesignCode"
        Me.cmb_IntDesignCode.Size = New System.Drawing.Size(208, 21)
        Me.cmb_IntDesignCode.TabIndex = 356
        Me.cmb_IntDesignCode.Text = "UltraComboEditor1"
        '
        'lblInternal
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.lblInternal.Appearance = Appearance10
        Me.lblInternal.Location = New System.Drawing.Point(35, 30)
        Me.lblInternal.Name = "lblInternal"
        Me.lblInternal.Size = New System.Drawing.Size(142, 21)
        Me.lblInternal.TabIndex = 355
        Me.lblInternal.Text = "Internal Design Type"
        '
        'btnMakeModel
        '
        Me.btnMakeModel.Location = New System.Drawing.Point(12, 6)
        Me.btnMakeModel.Name = "btnMakeModel"
        Me.btnMakeModel.Size = New System.Drawing.Size(124, 30)
        Me.btnMakeModel.TabIndex = 363
        Me.btnMakeModel.Text = "Test Component"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraTabControl1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 591)
        Me.Panel2.TabIndex = 16
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl18)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl10)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl11)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 176)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.Panelbtn})
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(784, 415)
        Me.UltraTabControl1.TabIndex = 11
        UltraTab1.Key = "param"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Parameters"
        UltraTab2.Key = "rules"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Rules"
        UltraTab19.Key = "material"
        UltraTab19.TabPage = Me.UltraTabPageControl11
        UltraTab19.Text = "Material"
        UltraTab5.Key = "comp"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Component"
        UltraTab18.Key = "ent"
        UltraTab18.TabPage = Me.UltraTabPageControl18
        UltraTab18.Text = "Entity Helper"
        UltraTab8.Key = "tabrows"
        UltraTab8.TabPage = Me.UltraTabPageControl8
        UltraTab8.Text = "Table Rows"
        UltraTab9.Key = "stdff"
        UltraTab9.TabPage = Me.UltraTabPageControl9
        UltraTab9.Text = "Std Folders"
        UltraTab20.TabPage = Me.UltraTabPageControl10
        UltraTab20.Text = "Print"
        UltraTab20.Visible = False
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab19, UltraTab5, UltraTab18, UltraTab8, UltraTab9, UltraTab20})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.Panelbtn)
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(780, 389)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmb_CompType)
        Me.Panel1.Controls.Add(Me.UltraLabel5)
        Me.Panel1.Controls.Add(Me.utcDim)
        Me.Panel1.Controls.Add(Me.UltraLabel6)
        Me.Panel1.Controls.Add(Me.cmb_DefGroup)
        Me.Panel1.Controls.Add(Me.chk_CreateNewASM)
        Me.Panel1.Controls.Add(Me.cmb_ParamBehave)
        Me.Panel1.Controls.Add(Me.UltraLabel4)
        Me.Panel1.Controls.Add(Me.txt_Descrip)
        Me.Panel1.Controls.Add(Me.CtlPIDUnitID1)
        Me.Panel1.Controls.Add(Me.UltraLabel2)
        Me.Panel1.Controls.Add(Me.txt_CompDefCode)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 176)
        Me.Panel1.TabIndex = 10
        '
        'cmb_CompType
        '
        Me.cmb_CompType.DataMember = "Table1"
        Me.cmb_CompType.DisplayMember = "ParamCode"
        Me.cmb_CompType.Location = New System.Drawing.Point(155, 68)
        Me.cmb_CompType.MaxDropDownItems = 15
        Me.cmb_CompType.Name = "cmb_CompType"
        Me.cmb_CompType.ReadOnly = True
        Me.cmb_CompType.Size = New System.Drawing.Size(212, 22)
        Me.cmb_CompType.TabIndex = 364
        Me.cmb_CompType.Text = "UltraCombo1"
        Me.cmb_CompType.ValueMember = "ParamCode"
        '
        'UltraLabel5
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance11
        Me.UltraLabel5.Location = New System.Drawing.Point(3, 72)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(146, 18)
        Me.UltraLabel5.TabIndex = 363
        Me.UltraLabel5.Text = "Type"
        '
        'utcDim
        '
        Me.utcDim.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.utcDim.Controls.Add(Me.UltraTabPageControl16)
        Me.utcDim.Controls.Add(Me.UltraTabPageControl17)
        Me.utcDim.Location = New System.Drawing.Point(383, 65)
        Me.utcDim.Name = "utcDim"
        Me.utcDim.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.utcDim.Size = New System.Drawing.Size(393, 75)
        Me.utcDim.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard
        Me.utcDim.TabIndex = 362
        UltraTab16.Key = "3d"
        UltraTab16.TabPage = Me.UltraTabPageControl16
        UltraTab16.Text = "tab1"
        UltraTab17.Key = "2d"
        UltraTab17.TabPage = Me.UltraTabPageControl17
        UltraTab17.Text = "tab2"
        Me.utcDim.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab16, UltraTab17})
        Me.utcDim.UseAppStyling = False
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(393, 75)
        '
        'UltraLabel6
        '
        Appearance12.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance12
        Me.UltraLabel6.Location = New System.Drawing.Point(335, 15)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(54, 21)
        Me.UltraLabel6.TabIndex = 361
        Me.UltraLabel6.Text = "Group"
        '
        'cmb_DefGroup
        '
        Me.cmb_DefGroup.Location = New System.Drawing.Point(395, 11)
        Me.cmb_DefGroup.Name = "cmb_DefGroup"
        Me.cmb_DefGroup.Size = New System.Drawing.Size(208, 21)
        Me.cmb_DefGroup.TabIndex = 360
        Me.cmb_DefGroup.Text = "UltraComboEditor1"
        '
        'chk_CreateNewASM
        '
        Appearance13.FontData.BoldAsString = "False"
        Appearance13.FontData.SizeInPoints = 8.0!
        Me.chk_CreateNewASM.Appearance = Appearance13
        Me.chk_CreateNewASM.Location = New System.Drawing.Point(623, 13)
        Me.chk_CreateNewASM.Name = "chk_CreateNewASM"
        Me.chk_CreateNewASM.Size = New System.Drawing.Size(153, 40)
        Me.chk_CreateNewASM.TabIndex = 349
        Me.chk_CreateNewASM.Text = "Create Containing Assembly document"
        '
        'cmb_ParamBehave
        '
        Me.cmb_ParamBehave.Location = New System.Drawing.Point(155, 95)
        Me.cmb_ParamBehave.Name = "cmb_ParamBehave"
        Me.cmb_ParamBehave.Size = New System.Drawing.Size(212, 21)
        Me.cmb_ParamBehave.TabIndex = 358
        Me.cmb_ParamBehave.Text = "UltraComboEditor1"
        Me.ToolTip1.SetToolTip(Me.cmb_ParamBehave, "Notes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1. Parameters overridden by immediate parent are always overridden. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. O" &
        "verriding with blank formula inverts the behaviour")
        '
        'UltraLabel4
        '
        Appearance14.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance14
        Me.UltraLabel4.Location = New System.Drawing.Point(3, 99)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(146, 18)
        Me.UltraLabel4.TabIndex = 357
        Me.UltraLabel4.Text = "Parameter Behaviour"
        '
        'txt_Descrip
        '
        Appearance15.FontData.BoldAsString = "False"
        Appearance15.FontData.ItalicAsString = "False"
        Appearance15.FontData.Name = "Arial"
        Appearance15.FontData.SizeInPoints = 8.25!
        Appearance15.FontData.StrikeoutAsString = "False"
        Appearance15.FontData.UnderlineAsString = "False"
        Me.txt_Descrip.Appearance = Appearance15
        Me.txt_Descrip.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Descrip.Location = New System.Drawing.Point(155, 38)
        Me.txt_Descrip.Name = "txt_Descrip"
        Me.txt_Descrip.Size = New System.Drawing.Size(449, 21)
        Me.txt_Descrip.TabIndex = 347
        '
        'CtlPIDUnitID1
        '
        Me.CtlPIDUnitID1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CtlPIDUnitID1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtlPIDUnitID1.Location = New System.Drawing.Point(0, 146)
        Me.CtlPIDUnitID1.Name = "CtlPIDUnitID1"
        Me.CtlPIDUnitID1.Size = New System.Drawing.Size(784, 30)
        Me.CtlPIDUnitID1.TabIndex = 352
        '
        'UltraLabel2
        '
        Appearance16.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance16
        Me.UltraLabel2.Location = New System.Drawing.Point(66, 38)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(83, 21)
        Me.UltraLabel2.TabIndex = 346
        Me.UltraLabel2.Text = "Description"
        '
        'txt_CompDefCode
        '
        Appearance17.FontData.BoldAsString = "False"
        Appearance17.FontData.ItalicAsString = "False"
        Appearance17.FontData.Name = "Arial"
        Appearance17.FontData.SizeInPoints = 8.25!
        Appearance17.FontData.StrikeoutAsString = "False"
        Appearance17.FontData.UnderlineAsString = "False"
        Me.txt_CompDefCode.Appearance = Appearance17
        Me.txt_CompDefCode.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_CompDefCode.Location = New System.Drawing.Point(155, 11)
        Me.txt_CompDefCode.Name = "txt_CompDefCode"
        Me.txt_CompDefCode.Size = New System.Drawing.Size(162, 21)
        Me.txt_CompDefCode.TabIndex = 345
        '
        'UltraLabel1
        '
        Appearance18.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance18
        Me.UltraLabel1.Location = New System.Drawing.Point(66, 11)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(83, 21)
        Me.UltraLabel1.TabIndex = 344
        Me.UltraLabel1.Text = "Code"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnExport)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Controls.Add(Me.btnMakeModel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 591)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(784, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(142, 6)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(81, 30)
        Me.btnExport.TabIndex = 364
        Me.btnExport.Text = "Export"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance19.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance19
        Me.btnSave.Location = New System.Drawing.Point(496, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance20.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance20
        Me.btnCancel.Location = New System.Drawing.Point(592, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance21.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance21
        Me.btnOK.Location = New System.Drawing.Point(688, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'frmTFCompDefBase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Component Definition"
        Me.ClientSize = New System.Drawing.Size(784, 639)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.MinimumSize = New System.Drawing.Size(800, 550)
        Me.Name = "frmTFCompDefBase"
        Me.Text = "Component Definition"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl12.ResumeLayout(False)
        CType(Me.UltraGrid7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.UltraTabPageControl15.ResumeLayout(False)
        CType(Me.UltraGrid8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAction.ResumeLayout(False)
        Me.PanelAction.PerformLayout()
        Me.UltraTabPageControl19.ResumeLayout(False)
        CType(Me.UltraGrid13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.UltraGrid9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.cmb_DesTableID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DesTableCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_DTSelColID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_DTLocalParamCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.Panelbtn.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraTabControlRules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControlRules.ResumeLayout(False)
        Me.UltraTabPageControl11.ResumeLayout(False)
        CType(Me.UltraTabControlMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControlMat.ResumeLayout(False)
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        Me.UltraTabPageControl18.ResumeLayout(False)
        CType(Me.UltraGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3D.ResumeLayout(False)
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.UltraGrid12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.UltraGrid10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl16.ResumeLayout(False)
        Me.UltraTabPageControl16.PerformLayout()
        CType(Me.txt_ParamEditorClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_TreatLib, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl17.ResumeLayout(False)
        Me.UltraTabPageControl17.PerformLayout()
        CType(Me.chk_RemoveConstraints, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ViewName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_IntDesignCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.UltraTabSharedControlsPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_CompType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utcDim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utcDim.ResumeLayout(False)
        CType(Me.cmb_DefGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_CreateNewASM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ParamBehave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Descrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CompDefCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_CompDefCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents txt_Descrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel3D As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid4 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panelbtn As System.Windows.Forms.Panel
    Public WithEvents btnAdd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chk_CreateNewASM As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Public WithEvents btnCopy As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chk_TreatLib As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid9 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmb_DTSelColID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_DTLocalParamCode As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents UltraGrid11 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid10 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid12 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_DesTableCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_DesTableID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Public WithEvents btn_print As Infragistics.Win.Misc.UltraButton
    Friend WithEvents CtlPIDUnitID1 As win.ctlPIDUnitID
    Friend WithEvents cmb_IntDesignCode As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblInternal As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_ParamBehave As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Protected Friend WithEvents btnGenEnt As Infragistics.Win.Misc.UltraButton
    Protected Friend WithEvents btnGenWorkFeat As Infragistics.Win.Misc.UltraButton
    Protected Friend WithEvents btn_TakeShots As Infragistics.Win.Misc.UltraButton
    Protected Friend WithEvents btnMakeModel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_DefGroup As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents utcDim As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl16 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl17 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cmb_ViewName As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl18 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Protected Friend WithEvents btnExport As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents chk_RemoveConstraints As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_CompType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabPageControl2 As UltraTabPageControl
    Friend WithEvents UltraTabPageControl11 As UltraTabPageControl
    Friend WithEvents UltraTabControlRules As UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl12 As UltraTabPageControl
    Friend WithEvents UltraTabPageControl15 As UltraTabPageControl
    Friend WithEvents UltraTabPageControl19 As UltraTabPageControl
    Friend WithEvents UltraGrid7 As UltraGrid
    Friend WithEvents Panel9 As Windows.Forms.Panel
    Friend WithEvents btnRenumChild As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMoveUpChild As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMoveDownChild As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid8 As UltraGrid
    Friend WithEvents PanelAction As Windows.Forms.Panel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Protected Friend WithEvents btnApplySelected As Infragistics.Win.Misc.UltraButton
    Protected Friend WithEvents btnApplyActions As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid13 As UltraGrid
    Friend WithEvents UltraTabControlMat As UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage5 As UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As UltraTabPageControl
    Friend WithEvents UltraGrid3 As UltraGrid
    Friend WithEvents Panel8 As Windows.Forms.Panel
    Protected Friend WithEvents btn_GenChildrenLeaf As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDown As Infragistics.Win.Misc.UltraButton
    Protected Friend WithEvents btn_GenChildRenLevelTop As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnUp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnRenumber As Infragistics.Win.Misc.UltraButton
    Protected Friend WithEvents btn_GenChildRenLevel1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid2 As UltraGrid
    Friend WithEvents txt_ParamEditorClass As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Protected Friend WithEvents UltraTabControl1 As UltraTabControl

#End Region
End Class

