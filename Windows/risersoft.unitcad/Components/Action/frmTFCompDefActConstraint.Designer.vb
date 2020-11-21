Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFCompDefActConstraint
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab19 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraExplorerBarGroup1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup5 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Me.UltraExplorerBarContainerControl1 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.txt_ActionFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraExplorerBarContainerControl4 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.UltraTabControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_Part1Formula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_Ent1Formula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraExplorerBarContainerControl2 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_Part2Formula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_Ent2Formula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraExplorerBarContainerControl3 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.txt_DistFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraExplorerBarContainerControl5 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl()
        Me.txt_QtyFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_ContOnError = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraExplorerBar1 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar()
        Me.UltraExplorerBarContainerControl1.SuspendLayout()
        Me.UltraExplorerBarContainerControl4.SuspendLayout()
        CType(Me.UltraTabControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl4.SuspendLayout()
        Me.UltraTabPageControl13.SuspendLayout()
        Me.UltraTabPageControl14.SuspendLayout()
        Me.UltraExplorerBarContainerControl2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.UltraExplorerBarContainerControl3.SuspendLayout()
        Me.UltraExplorerBarContainerControl5.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.chk_ContOnError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExplorerBar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraExplorerBarContainerControl1
        '
        Me.UltraExplorerBarContainerControl1.Controls.Add(Me.txt_ActionFormula)
        Me.UltraExplorerBarContainerControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl1.Name = "UltraExplorerBarContainerControl1"
        Me.UltraExplorerBarContainerControl1.Size = New System.Drawing.Size(688, 333)
        Me.UltraExplorerBarContainerControl1.TabIndex = 0
        Me.UltraExplorerBarContainerControl1.Visible = False
        '
        'txt_ActionFormula
        '
        Me.txt_ActionFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ActionFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_ActionFormula.LabelText = ""
        Me.txt_ActionFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_ActionFormula.Name = "txt_ActionFormula"
        Me.txt_ActionFormula.Size = New System.Drawing.Size(688, 333)
        Me.txt_ActionFormula.TabIndex = 0
        '
        'UltraExplorerBarContainerControl4
        '
        Me.UltraExplorerBarContainerControl4.Controls.Add(Me.UltraTabControl4)
        Me.UltraExplorerBarContainerControl4.Location = New System.Drawing.Point(3, 45)
        Me.UltraExplorerBarContainerControl4.Name = "UltraExplorerBarContainerControl4"
        Me.UltraExplorerBarContainerControl4.Size = New System.Drawing.Size(688, 333)
        Me.UltraExplorerBarContainerControl4.TabIndex = 3
        '
        'UltraTabControl4
        '
        Me.UltraTabControl4.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl13)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl14)
        Me.UltraTabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl4.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl4.Name = "UltraTabControl4"
        Appearance1.FontData.BoldAsString = "True"
        Me.UltraTabControl4.SelectedTabAppearance = Appearance1
        Me.UltraTabControl4.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.UltraTabControl4.Size = New System.Drawing.Size(688, 333)
        Me.UltraTabControl4.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl4.TabIndex = 20
        Me.UltraTabControl4.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        Me.UltraTabControl4.TabPadding = New System.Drawing.Size(10, 1)
        UltraTab1.TabPage = Me.UltraTabPageControl13
        UltraTab1.Text = "Component"
        UltraTab2.TabPage = Me.UltraTabPageControl14
        UltraTab2.Text = "Entity"
        Me.UltraTabControl4.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.UltraTabControl4.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(595, 333)
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.txt_Part1Formula)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(93, 0)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(595, 333)
        '
        'txt_Part1Formula
        '
        Me.txt_Part1Formula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Part1Formula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Part1Formula.LabelText = ""
        Me.txt_Part1Formula.Location = New System.Drawing.Point(0, 0)
        Me.txt_Part1Formula.Name = "txt_Part1Formula"
        Me.txt_Part1Formula.Size = New System.Drawing.Size(595, 333)
        Me.txt_Part1Formula.TabIndex = 2
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.txt_Ent1Formula)
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(478, 272)
        '
        'txt_Ent1Formula
        '
        Me.txt_Ent1Formula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Ent1Formula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Ent1Formula.LabelText = ""
        Me.txt_Ent1Formula.Location = New System.Drawing.Point(0, 0)
        Me.txt_Ent1Formula.Name = "txt_Ent1Formula"
        Me.txt_Ent1Formula.Size = New System.Drawing.Size(478, 272)
        Me.txt_Ent1Formula.TabIndex = 2
        '
        'UltraExplorerBarContainerControl2
        '
        Me.UltraExplorerBarContainerControl2.Controls.Add(Me.UltraTabControl1)
        Me.UltraExplorerBarContainerControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl2.Name = "UltraExplorerBarContainerControl2"
        Me.UltraExplorerBarContainerControl2.Size = New System.Drawing.Size(571, 272)
        Me.UltraExplorerBarContainerControl2.TabIndex = 1
        Me.UltraExplorerBarContainerControl2.Visible = False
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance3.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance3
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(571, 272)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl1.TabIndex = 21
        Me.UltraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        Me.UltraTabControl1.TabPadding = New System.Drawing.Size(10, 1)
        UltraTab18.TabPage = Me.UltraTabPageControl1
        UltraTab18.Text = "Component"
        UltraTab19.TabPage = Me.UltraTabPageControl2
        UltraTab19.Text = "Entity"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab18, UltraTab19})
        Me.UltraTabControl1.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(478, 272)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.txt_Part2Formula)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(93, 0)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(478, 272)
        '
        'txt_Part2Formula
        '
        Me.txt_Part2Formula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Part2Formula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Part2Formula.LabelText = ""
        Me.txt_Part2Formula.Location = New System.Drawing.Point(0, 0)
        Me.txt_Part2Formula.Name = "txt_Part2Formula"
        Me.txt_Part2Formula.Size = New System.Drawing.Size(478, 272)
        Me.txt_Part2Formula.TabIndex = 2
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.txt_Ent2Formula)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(478, 272)
        '
        'txt_Ent2Formula
        '
        Me.txt_Ent2Formula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Ent2Formula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Ent2Formula.LabelText = ""
        Me.txt_Ent2Formula.Location = New System.Drawing.Point(0, 0)
        Me.txt_Ent2Formula.Name = "txt_Ent2Formula"
        Me.txt_Ent2Formula.Size = New System.Drawing.Size(478, 272)
        Me.txt_Ent2Formula.TabIndex = 2
        '
        'UltraExplorerBarContainerControl3
        '
        Me.UltraExplorerBarContainerControl3.Controls.Add(Me.txt_DistFormula)
        Me.UltraExplorerBarContainerControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl3.Name = "UltraExplorerBarContainerControl3"
        Me.UltraExplorerBarContainerControl3.Size = New System.Drawing.Size(571, 272)
        Me.UltraExplorerBarContainerControl3.TabIndex = 2
        Me.UltraExplorerBarContainerControl3.Visible = False
        '
        'txt_DistFormula
        '
        Me.txt_DistFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_DistFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_DistFormula.LabelText = ""
        Me.txt_DistFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_DistFormula.Name = "txt_DistFormula"
        Me.txt_DistFormula.Size = New System.Drawing.Size(571, 272)
        Me.txt_DistFormula.TabIndex = 1
        '
        'UltraExplorerBarContainerControl5
        '
        Me.UltraExplorerBarContainerControl5.Controls.Add(Me.txt_QtyFormula)
        Me.UltraExplorerBarContainerControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExplorerBarContainerControl5.Name = "UltraExplorerBarContainerControl5"
        Me.UltraExplorerBarContainerControl5.Size = New System.Drawing.Size(571, 251)
        Me.UltraExplorerBarContainerControl5.TabIndex = 4
        Me.UltraExplorerBarContainerControl5.Visible = False
        '
        'txt_QtyFormula
        '
        Me.txt_QtyFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_QtyFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_QtyFormula.LabelText = ""
        Me.txt_QtyFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_QtyFormula.Name = "txt_QtyFormula"
        Me.txt_QtyFormula.Size = New System.Drawing.Size(571, 251)
        Me.txt_QtyFormula.TabIndex = 4
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
        Appearance4.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance4
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(518, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 48)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance2
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
        Me.Panel1.Size = New System.Drawing.Size(694, 53)
        Me.Panel1.TabIndex = 140
        '
        'chk_ContOnError
        '
        Appearance7.FontData.BoldAsString = "False"
        Appearance7.FontData.SizeInPoints = 8.0!
        Me.chk_ContOnError.Appearance = Appearance7
        Me.chk_ContOnError.Location = New System.Drawing.Point(73, 13)
        Me.chk_ContOnError.Name = "chk_ContOnError"
        Me.chk_ContOnError.Size = New System.Drawing.Size(468, 26)
        Me.chk_ContOnError.TabIndex = 352
        Me.chk_ContOnError.Text = "Continue Action for all qty in the event of error"
        '
        'UltraExplorerBar1
        '
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl1)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl2)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl3)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl4)
        Me.UltraExplorerBar1.Controls.Add(Me.UltraExplorerBarContainerControl5)
        Me.UltraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill
        UltraExplorerBarGroup1.Container = Me.UltraExplorerBarContainerControl1
        UltraExplorerBarGroup1.Text = "Action"
        UltraExplorerBarGroup4.Container = Me.UltraExplorerBarContainerControl4
        UltraExplorerBarGroup4.Text = "Part 1"
        UltraExplorerBarGroup2.Container = Me.UltraExplorerBarContainerControl2
        UltraExplorerBarGroup2.Text = "Part 2"
        UltraExplorerBarGroup3.Container = Me.UltraExplorerBarContainerControl3
        UltraExplorerBarGroup3.Key = "descrip"
        UltraExplorerBarGroup3.Text = "Distance"
        UltraExplorerBarGroup5.Container = Me.UltraExplorerBarContainerControl5
        UltraExplorerBarGroup5.Text = "Quantity"
        Me.UltraExplorerBar1.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup1, UltraExplorerBarGroup4, UltraExplorerBarGroup2, UltraExplorerBarGroup3, UltraExplorerBarGroup5})
        Me.UltraExplorerBar1.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer
        Me.UltraExplorerBar1.Location = New System.Drawing.Point(0, 53)
        Me.UltraExplorerBar1.Name = "UltraExplorerBar1"
        Me.UltraExplorerBar1.Size = New System.Drawing.Size(694, 444)
        Me.UltraExplorerBar1.Style = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarStyle.Toolbox
        Me.UltraExplorerBar1.TabIndex = 141
        '
        'frmTFCompDefActConstraint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Component Definition Child Action"
        Me.ClientSize = New System.Drawing.Size(694, 545)
        Me.Controls.Add(Me.UltraExplorerBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTFCompDefActConstraint"
        Me.Text = "Component Definition Child Action"
        Me.UltraExplorerBarContainerControl1.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl4.ResumeLayout(False)
        CType(Me.UltraTabControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl4.ResumeLayout(False)
        Me.UltraTabPageControl13.ResumeLayout(False)
        Me.UltraTabPageControl14.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl2.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl3.ResumeLayout(False)
        Me.UltraExplorerBarContainerControl5.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.chk_ContOnError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExplorerBar1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chk_ContOnError As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraExplorerBar1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents UltraExplorerBarContainerControl1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents txt_ActionFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_Part2Formula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_Ent2Formula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents txt_DistFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl4 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents UltraTabControl4 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_Part1Formula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_Ent1Formula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraExplorerBarContainerControl5 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl
    Friend WithEvents txt_QtyFormula As risersoft.shared.win.ctlFormulaEditorScintilla

#End Region
End Class

