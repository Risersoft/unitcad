Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFCompDefActPattern
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitForm()
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraExplorerBarGroup1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup8 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup9 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_ContOnError = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraExplorerBar1 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar()
        Me.UltraExplorerBarContainerControl1 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.txt_ActionFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraExplorerBarContainerControl2 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.txt_Part2Formula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraExplorerBarContainerControl4 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.txt_Part1Formula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraExplorerBarContainerControl6 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.UltraTabControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_Ent1Formula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_QtyFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_DistFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraExplorerBarContainerControl7 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_Ent2Formula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_Qty2Formula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_Dist2Formula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.chk_ContOnError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExplorerBar1.SuspendLayout()
        Me.UltraExplorerBarContainerControl1.SuspendLayout()
        Me.UltraExplorerBarContainerControl2.SuspendLayout()
        Me.UltraExplorerBarContainerControl4.SuspendLayout()
        Me.UltraExplorerBarContainerControl6.SuspendLayout()
        CType(Me.UltraTabControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl4.SuspendLayout()
        Me.UltraTabPageControl13.SuspendLayout()
        Me.UltraTabPageControl14.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraExplorerBarContainerControl7.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.UltraTabPageControl5.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(690, 330)
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(690, 330)
        Me.Panel5.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 497)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(694, 48)
        Me.Panel4.TabIndex = 73
        '
        'btnCancel
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance3
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(518, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 48)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance4
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(606, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 48)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chk_ContOnError)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 61)
        Me.Panel1.TabIndex = 140
        '
        'chk_ContOnError
        '
        Appearance7.FontData.BoldAsString = "False"
        Appearance7.FontData.SizeInPoints = 8.0!
        Me.chk_ContOnError.Appearance = Appearance7
        Me.chk_ContOnError.Location = New System.Drawing.Point(73, 19)
        Me.chk_ContOnError.Name = "chk_ContOnError"
        Me.chk_ContOnError.Size = New System.Drawing.Size(468, 26)
        Me.chk_ContOnError.TabIndex = 352
        Me.chk_ContOnError.Text = "Continue Action for all qty in the event of error"
        '
        'UltraExplorerBar1
        '
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl1)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl2)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl4)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl6)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl7)
        Me.UltraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill
        UltraExplorerBarGroup1.Container = Me.UltraExplorerBarContainerControl1
        UltraExplorerBarGroup1.Text = "Action"
        UltraExplorerBarGroup4.Container = Me.UltraExplorerBarContainerControl4
        UltraExplorerBarGroup4.Text = "Component Base"
        UltraExplorerBarGroup2.Container = Me.UltraExplorerBarContainerControl2
        UltraExplorerBarGroup2.Text = "Component Pattern"
        UltraExplorerBarGroup8.Container = Me.UltraExplorerBarContainerControl6
        UltraExplorerBarGroup8.Text = "Column"
        UltraExplorerBarGroup9.Container = Me.UltraExplorerBarContainerControl7
        UltraExplorerBarGroup9.Text = "Row"
        Me.UltraExplorerBar1.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup1, UltraExplorerBarGroup4, UltraExplorerBarGroup2, UltraExplorerBarGroup8, UltraExplorerBarGroup9})
        Me.UltraExplorerBar1.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer
        Me.UltraExplorerBar1.Location = New System.Drawing.Point(0, 61)
        Me.UltraExplorerBar1.Name = "UltraExplorerBar1"
        Me.UltraExplorerBar1.Size = New System.Drawing.Size(694, 436)
        Me.UltraExplorerBar1.Style = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarStyle.Toolbox
        Me.UltraExplorerBar1.TabIndex = 141
        '
        'UltraExplorerBarContainerControl1
        '
        Me.UltraExplorerBarContainerControl1.Controls.Add(Me.txt_ActionFormula)
        Me.UltraExplorerBarContainerControl1.Location = New System.Drawing.Point(3, 24)
        Me.UltraExplorerBarContainerControl1.Name = "UltraExplorerBarContainerControl1"
        Me.UltraExplorerBarContainerControl1.Size = New System.Drawing.Size(688, 325)
        Me.UltraExplorerBarContainerControl1.TabIndex = 0
        '
        'txt_ActionFormula
        '
        Me.txt_ActionFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ActionFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_ActionFormula.LabelText = ""
        Me.txt_ActionFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_ActionFormula.Name = "txt_ActionFormula"
        Me.txt_ActionFormula.Size = New System.Drawing.Size(688, 325)
        Me.txt_ActionFormula.TabIndex = 0
        '
        'UltraExplorerBarContainerControl2
        '
        Me.UltraExplorerBarContainerControl2.Controls.Add(Me.txt_Part2Formula)
        Me.UltraExplorerBarContainerControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl2.Name = "UltraExplorerBarContainerControl2"
        Me.UltraExplorerBarContainerControl2.Size = New System.Drawing.Size(571, 272)
        Me.UltraExplorerBarContainerControl2.TabIndex = 1
        Me.UltraExplorerBarContainerControl2.Visible = False
        '
        'txt_Part2Formula
        '
        Me.txt_Part2Formula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Part2Formula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Part2Formula.LabelText = ""
        Me.txt_Part2Formula.Location = New System.Drawing.Point(0, 0)
        Me.txt_Part2Formula.Name = "txt_Part2Formula"
        Me.txt_Part2Formula.Size = New System.Drawing.Size(571, 272)
        Me.txt_Part2Formula.TabIndex = 3
        '
        'UltraExplorerBarContainerControl4
        '
        Me.UltraExplorerBarContainerControl4.Controls.Add(Me.txt_Part1Formula)
        Me.UltraExplorerBarContainerControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl4.Name = "UltraExplorerBarContainerControl4"
        Me.UltraExplorerBarContainerControl4.Size = New System.Drawing.Size(571, 272)
        Me.UltraExplorerBarContainerControl4.TabIndex = 3
        Me.UltraExplorerBarContainerControl4.Visible = False
        '
        'txt_Part1Formula
        '
        Me.txt_Part1Formula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Part1Formula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Part1Formula.LabelText = ""
        Me.txt_Part1Formula.Location = New System.Drawing.Point(0, 0)
        Me.txt_Part1Formula.Name = "txt_Part1Formula"
        Me.txt_Part1Formula.Size = New System.Drawing.Size(571, 272)
        Me.txt_Part1Formula.TabIndex = 3
        '
        'UltraExplorerBarContainerControl6
        '
        Me.UltraExplorerBarContainerControl6.Controls.Add(Me.UltraTabControl4)
        Me.UltraExplorerBarContainerControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl6.Name = "UltraExplorerBarContainerControl6"
        Me.UltraExplorerBarContainerControl6.Size = New System.Drawing.Size(571, 272)
        Me.UltraExplorerBarContainerControl6.TabIndex = 5
        Me.UltraExplorerBarContainerControl6.Visible = False
        '
        'UltraTabControl4
        '
        Me.UltraTabControl4.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl13)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl14)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl4.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl4.Name = "UltraTabControl4"
        Appearance2.FontData.BoldAsString = "True"
        Me.UltraTabControl4.SelectedTabAppearance = Appearance2
        Me.UltraTabControl4.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.UltraTabControl4.Size = New System.Drawing.Size(571, 272)
        Me.UltraTabControl4.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl4.TabIndex = 21
        Me.UltraTabControl4.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        Me.UltraTabControl4.TabPadding = New System.Drawing.Size(10, 1)
        UltraTab6.TabPage = Me.UltraTabPageControl13
        UltraTab6.Text = "Direction"
        UltraTab7.TabPage = Me.UltraTabPageControl14
        UltraTab7.Text = "Qty"
        UltraTab8.TabPage = Me.UltraTabPageControl1
        UltraTab8.Text = "Distance"
        Me.UltraTabControl4.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab7, UltraTab8})
        Me.UltraTabControl4.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(492, 272)
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.txt_Ent1Formula)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(79, 0)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(492, 272)
        '
        'txt_Ent1Formula
        '
        Me.txt_Ent1Formula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Ent1Formula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Ent1Formula.LabelText = ""
        Me.txt_Ent1Formula.Location = New System.Drawing.Point(0, 0)
        Me.txt_Ent1Formula.Name = "txt_Ent1Formula"
        Me.txt_Ent1Formula.Size = New System.Drawing.Size(492, 272)
        Me.txt_Ent1Formula.TabIndex = 2
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.txt_QtyFormula)
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(492, 272)
        '
        'txt_QtyFormula
        '
        Me.txt_QtyFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_QtyFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_QtyFormula.LabelText = ""
        Me.txt_QtyFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_QtyFormula.Name = "txt_QtyFormula"
        Me.txt_QtyFormula.Size = New System.Drawing.Size(492, 272)
        Me.txt_QtyFormula.TabIndex = 2
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.txt_DistFormula)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(492, 272)
        '
        'txt_DistFormula
        '
        Me.txt_DistFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_DistFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_DistFormula.LabelText = ""
        Me.txt_DistFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_DistFormula.Name = "txt_DistFormula"
        Me.txt_DistFormula.Size = New System.Drawing.Size(492, 272)
        Me.txt_DistFormula.TabIndex = 3
        '
        'UltraExplorerBarContainerControl7
        '
        Me.UltraExplorerBarContainerControl7.Controls.Add(Me.UltraTabControl1)
        Me.UltraExplorerBarContainerControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl7.Name = "UltraExplorerBarContainerControl7"
        Me.UltraExplorerBarContainerControl7.Size = New System.Drawing.Size(571, 251)
        Me.UltraExplorerBarContainerControl7.TabIndex = 6
        Me.UltraExplorerBarContainerControl7.Visible = False
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance1.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance1
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(571, 251)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl1.TabIndex = 22
        Me.UltraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        Me.UltraTabControl1.TabPadding = New System.Drawing.Size(10, 1)
        UltraTab1.TabPage = Me.UltraTabPageControl2
        UltraTab1.Text = "Direction"
        UltraTab2.TabPage = Me.UltraTabPageControl3
        UltraTab2.Text = "Qty"
        UltraTab3.TabPage = Me.UltraTabPageControl5
        UltraTab3.Text = "Distance"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.UltraTabControl1.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(492, 251)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.txt_Ent2Formula)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(79, 0)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(492, 251)
        '
        'txt_Ent2Formula
        '
        Me.txt_Ent2Formula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Ent2Formula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Ent2Formula.LabelText = ""
        Me.txt_Ent2Formula.Location = New System.Drawing.Point(0, 0)
        Me.txt_Ent2Formula.Name = "txt_Ent2Formula"
        Me.txt_Ent2Formula.Size = New System.Drawing.Size(492, 251)
        Me.txt_Ent2Formula.TabIndex = 2
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.txt_Qty2Formula)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(492, 251)
        '
        'txt_Qty2Formula
        '
        Me.txt_Qty2Formula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Qty2Formula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Qty2Formula.LabelText = ""
        Me.txt_Qty2Formula.Location = New System.Drawing.Point(0, 0)
        Me.txt_Qty2Formula.Name = "txt_Qty2Formula"
        Me.txt_Qty2Formula.Size = New System.Drawing.Size(492, 251)
        Me.txt_Qty2Formula.TabIndex = 2
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Dist2Formula)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(492, 251)
        '
        'txt_Dist2Formula
        '
        Me.txt_Dist2Formula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Dist2Formula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Dist2Formula.LabelText = ""
        Me.txt_Dist2Formula.Location = New System.Drawing.Point(0, 0)
        Me.txt_Dist2Formula.Name = "txt_Dist2Formula"
        Me.txt_Dist2Formula.Size = New System.Drawing.Size(492, 251)
        Me.txt_Dist2Formula.TabIndex = 3
        '
        'frmTFCompDefActPattern
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Component Definition Pattern Action"
        Me.ClientSize = New System.Drawing.Size(694, 545)
        Me.Controls.Add(Me.UltraExplorerBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTFCompDefActPattern"
        Me.Text = "Component Definition Pattern Action"
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.chk_ContOnError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExplorerBar1.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl1.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl2.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl4.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl6.ResumeLayout(False)
        CType(Me.UltraTabControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl4.ResumeLayout(False)
        Me.UltraTabPageControl13.ResumeLayout(False)
        Me.UltraTabPageControl14.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl7.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chk_ContOnError As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraExplorerBar1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents UltraExplorerBarContainerControl1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents txt_ActionFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents txt_Part2Formula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents txt_Part1Formula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl6 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents UltraTabControl4 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_Ent1Formula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_QtyFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_DistFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl7 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_Ent2Formula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_Qty2Formula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_Dist2Formula As risersoft.shared.win.ctlFormulaEditorScintilla

#End Region
End Class

