Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmTFCompDefParam
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
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents txt_ParamName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_ParamCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmb_DataType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab17 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab19 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugrid4 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugrid5 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugrid6 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugrid7 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl15 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl18 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrid4 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl16 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrid5 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl17 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrid6 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_Formula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl19 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_CheckFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnReplace = New Infragistics.Win.Misc.UltraButton()
        Me.btnFind = New Infragistics.Win.Misc.UltraButton()
        Me.TextNewCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl20 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Notes = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chk_InPrint = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_IsInput = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_DataType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ParamName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ParamCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl11.SuspendLayout()
        CType(Me.ugrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.ugrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.ugrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.ugrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.ugrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.ugrid6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.ugrid7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl14.SuspendLayout()
        CType(Me.agrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl15.SuspendLayout()
        CType(Me.agrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl12.SuspendLayout()
        CType(Me.agrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl18.SuspendLayout()
        CType(Me.agrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl16.SuspendLayout()
        CType(Me.agrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl17.SuspendLayout()
        CType(Me.agrid6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl3.SuspendLayout()
        Me.UltraTabPageControl13.SuspendLayout()
        CType(Me.UltraTabControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl4.SuspendLayout()
        Me.UltraTabPageControl5.SuspendLayout()
        Me.UltraTabPageControl19.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TextNewCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl20.SuspendLayout()
        CType(Me.txt_Notes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_InPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_DataType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ParamName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ParamCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.ugrid1)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(682, 256)
        '
        'ugrid1
        '
        Me.ugrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugrid1.Location = New System.Drawing.Point(0, 0)
        Me.ugrid1.Name = "ugrid1"
        Me.ugrid1.Size = New System.Drawing.Size(682, 256)
        Me.ugrid1.TabIndex = 20
        Me.ugrid1.Text = "Bill Of Material"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.ugrid2)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(682, 256)
        '
        'ugrid2
        '
        Me.ugrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugrid2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.ugrid2.Location = New System.Drawing.Point(0, 0)
        Me.ugrid2.Name = "ugrid2"
        Me.ugrid2.Size = New System.Drawing.Size(682, 256)
        Me.ugrid2.TabIndex = 10
        Me.ugrid2.Text = "Actions"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.ugrid3)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(682, 256)
        '
        'ugrid3
        '
        Me.ugrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugrid3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.ugrid3.Location = New System.Drawing.Point(0, 0)
        Me.ugrid3.Name = "ugrid3"
        Me.ugrid3.Size = New System.Drawing.Size(682, 256)
        Me.ugrid3.TabIndex = 11
        Me.ugrid3.Text = "Actions"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.ugrid4)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(682, 256)
        '
        'ugrid4
        '
        Me.ugrid4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugrid4.Location = New System.Drawing.Point(0, 0)
        Me.ugrid4.Name = "ugrid4"
        Me.ugrid4.Size = New System.Drawing.Size(682, 256)
        Me.ugrid4.TabIndex = 21
        Me.ugrid4.Text = "Bill Of Material"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.ugrid5)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(682, 256)
        '
        'ugrid5
        '
        Me.ugrid5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugrid5.Location = New System.Drawing.Point(0, 0)
        Me.ugrid5.Name = "ugrid5"
        Me.ugrid5.Size = New System.Drawing.Size(682, 256)
        Me.ugrid5.TabIndex = 21
        Me.ugrid5.Text = "Bill Of Material"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.ugrid6)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(682, 256)
        '
        'ugrid6
        '
        Me.ugrid6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugrid6.Location = New System.Drawing.Point(0, 0)
        Me.ugrid6.Name = "ugrid6"
        Me.ugrid6.Size = New System.Drawing.Size(682, 256)
        Me.ugrid6.TabIndex = 21
        Me.ugrid6.Text = "Bill Of Material"
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.ugrid7)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(682, 256)
        '
        'ugrid7
        '
        Me.ugrid7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugrid7.Location = New System.Drawing.Point(0, 0)
        Me.ugrid7.Name = "ugrid7"
        Me.ugrid7.Size = New System.Drawing.Size(682, 256)
        Me.ugrid7.TabIndex = 21
        Me.ugrid7.Text = "Bill Of Material"
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.agrid1)
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(682, 256)
        '
        'agrid1
        '
        Me.agrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrid1.Location = New System.Drawing.Point(0, 0)
        Me.agrid1.Name = "agrid1"
        Me.agrid1.Size = New System.Drawing.Size(682, 256)
        Me.agrid1.TabIndex = 20
        Me.agrid1.Text = "Bill Of Material"
        '
        'UltraTabPageControl15
        '
        Me.UltraTabPageControl15.Controls.Add(Me.agrid2)
        Me.UltraTabPageControl15.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl15.Name = "UltraTabPageControl15"
        Me.UltraTabPageControl15.Size = New System.Drawing.Size(682, 256)
        '
        'agrid2
        '
        Me.agrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrid2.Location = New System.Drawing.Point(0, 0)
        Me.agrid2.Name = "agrid2"
        Me.agrid2.Size = New System.Drawing.Size(682, 256)
        Me.agrid2.TabIndex = 20
        Me.agrid2.Text = "Bill Of Material"
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.agrid3)
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(682, 256)
        '
        'agrid3
        '
        Me.agrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrid3.Location = New System.Drawing.Point(0, 0)
        Me.agrid3.Name = "agrid3"
        Me.agrid3.Size = New System.Drawing.Size(682, 256)
        Me.agrid3.TabIndex = 21
        Me.agrid3.Text = "Bill Of Material"
        '
        'UltraTabPageControl18
        '
        Me.UltraTabPageControl18.Controls.Add(Me.agrid4)
        Me.UltraTabPageControl18.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl18.Name = "UltraTabPageControl18"
        Me.UltraTabPageControl18.Size = New System.Drawing.Size(682, 256)
        '
        'agrid4
        '
        Me.agrid4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrid4.Location = New System.Drawing.Point(0, 0)
        Me.agrid4.Name = "agrid4"
        Me.agrid4.Size = New System.Drawing.Size(682, 256)
        Me.agrid4.TabIndex = 22
        Me.agrid4.Text = "Bill Of Material"
        '
        'UltraTabPageControl16
        '
        Me.UltraTabPageControl16.Controls.Add(Me.agrid5)
        Me.UltraTabPageControl16.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl16.Name = "UltraTabPageControl16"
        Me.UltraTabPageControl16.Size = New System.Drawing.Size(682, 256)
        '
        'agrid5
        '
        Me.agrid5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrid5.Location = New System.Drawing.Point(0, 0)
        Me.agrid5.Name = "agrid5"
        Me.agrid5.Size = New System.Drawing.Size(682, 256)
        Me.agrid5.TabIndex = 21
        Me.agrid5.Text = "Bill Of Material"
        '
        'UltraTabPageControl17
        '
        Me.UltraTabPageControl17.Controls.Add(Me.agrid6)
        Me.UltraTabPageControl17.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl17.Name = "UltraTabPageControl17"
        Me.UltraTabPageControl17.Size = New System.Drawing.Size(682, 256)
        '
        'agrid6
        '
        Me.agrid6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrid6.Location = New System.Drawing.Point(0, 0)
        Me.agrid6.Name = "agrid6"
        Me.agrid6.Size = New System.Drawing.Size(682, 256)
        Me.agrid6.TabIndex = 21
        Me.agrid6.Text = "Bill Of Material"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraTabControl3)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(686, 282)
        '
        'UltraTabControl3
        '
        Me.UltraTabControl3.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl10)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl11)
        Me.UltraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl3.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl3.Name = "UltraTabControl3"
        Me.UltraTabControl3.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl3.Size = New System.Drawing.Size(686, 282)
        Me.UltraTabControl3.TabIndex = 2
        UltraTab9.TabPage = Me.UltraTabPageControl11
        UltraTab9.Text = "Components"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Parameters"
        UltraTab4.TabPage = Me.UltraTabPageControl6
        UltraTab4.Text = "Parameter Overrides"
        UltraTab5.TabPage = Me.UltraTabPageControl7
        UltraTab5.Text = "BOM"
        UltraTab6.TabPage = Me.UltraTabPageControl8
        UltraTab6.Text = "Action Packs"
        UltraTab7.TabPage = Me.UltraTabPageControl9
        UltraTab7.Text = "Actions"
        UltraTab8.TabPage = Me.UltraTabPageControl10
        UltraTab8.Text = "Parameter Groups"
        Me.UltraTabControl3.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab9, UltraTab3, UltraTab4, UltraTab5, UltraTab6, UltraTab7, UltraTab8})
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(682, 256)
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.UltraTabControl4)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(686, 282)
        '
        'UltraTabControl4
        '
        Me.UltraTabControl4.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl14)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl15)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl16)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl17)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl12)
        Me.UltraTabControl4.Controls.Add(Me.UltraTabPageControl18)
        Me.UltraTabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl4.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl4.Name = "UltraTabControl4"
        Me.UltraTabControl4.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.UltraTabControl4.Size = New System.Drawing.Size(686, 282)
        Me.UltraTabControl4.TabIndex = 0
        UltraTab15.TabPage = Me.UltraTabPageControl14
        UltraTab15.Text = "Assembly"
        UltraTab16.Key = "partdef"
        UltraTab16.TabPage = Me.UltraTabPageControl15
        UltraTab16.Text = "BOM Parts"
        UltraTab10.Key = "parthw"
        UltraTab10.TabPage = Me.UltraTabPageControl12
        UltraTab10.Text = "BOM HW"
        UltraTab11.Key = "partdis"
        UltraTab11.TabPage = Me.UltraTabPageControl18
        UltraTab11.Text = "BOM DisAssy"
        UltraTab17.TabPage = Me.UltraTabPageControl16
        UltraTab17.Text = "Parameters"
        UltraTab18.TabPage = Me.UltraTabPageControl17
        UltraTab18.Text = "Parameter Overrides"
        Me.UltraTabControl4.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab15, UltraTab16, UltraTab10, UltraTab11, UltraTab17, UltraTab18})
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(682, 256)
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Formula)
        Me.UltraTabPageControl5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(690, 365)
        '
        'txt_Formula
        '
        Me.txt_Formula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Formula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Formula.LabelText = ""
        Me.txt_Formula.Location = New System.Drawing.Point(0, 0)
        Me.txt_Formula.Name = "txt_Formula"
        Me.txt_Formula.Size = New System.Drawing.Size(690, 365)
        Me.txt_Formula.TabIndex = 0
        '
        'UltraTabPageControl19
        '
        Me.UltraTabPageControl19.Controls.Add(Me.txt_CheckFormula)
        Me.UltraTabPageControl19.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl19.Name = "UltraTabPageControl19"
        Me.UltraTabPageControl19.Size = New System.Drawing.Size(690, 365)
        '
        'txt_CheckFormula
        '
        Me.txt_CheckFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_CheckFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_CheckFormula.LabelText = ""
        Me.txt_CheckFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_CheckFormula.Name = "txt_CheckFormula"
        Me.txt_CheckFormula.Size = New System.Drawing.Size(690, 365)
        Me.txt_CheckFormula.TabIndex = 1
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraTabControl1)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(690, 365)
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl13)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 57)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(690, 308)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab13.TabPage = Me.UltraTabPageControl2
        UltraTab13.Text = "UnitCAD"
        UltraTab14.TabPage = Me.UltraTabPageControl13
        UltraTab14.Text = "Assembly"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab13, UltraTab14})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(686, 282)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnReplace)
        Me.Panel2.Controls.Add(Me.btnFind)
        Me.Panel2.Controls.Add(Me.TextNewCode)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(690, 57)
        Me.Panel2.TabIndex = 0
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(330, 18)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(156, 24)
        Me.btnReplace.TabIndex = 160
        Me.btnReplace.Text = "Replace, Save and Close"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(10, 18)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(73, 24)
        Me.btnFind.TabIndex = 159
        Me.btnFind.Text = "Find Usage"
        '
        'TextNewCode
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.TextNewCode.Appearance = Appearance1
        Me.TextNewCode.Location = New System.Drawing.Point(164, 20)
        Me.TextNewCode.Name = "TextNewCode"
        Me.TextNewCode.Size = New System.Drawing.Size(160, 22)
        Me.TextNewCode.TabIndex = 158
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(85, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "New Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl20
        '
        Me.UltraTabPageControl20.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl20.Controls.Add(Me.txt_Notes)
        Me.UltraTabPageControl20.Controls.Add(Me.chk_InPrint)
        Me.UltraTabPageControl20.Controls.Add(Me.chk_IsInput)
        Me.UltraTabPageControl20.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl20.Name = "UltraTabPageControl20"
        Me.UltraTabPageControl20.Size = New System.Drawing.Size(690, 365)
        '
        'UltraLabel2
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance2
        Me.UltraLabel2.Location = New System.Drawing.Point(76, 133)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel2.TabIndex = 169
        Me.UltraLabel2.Text = "Notes"
        '
        'txt_Notes
        '
        Appearance3.FontData.BoldAsString = "False"
        Appearance3.FontData.ItalicAsString = "False"
        Appearance3.FontData.Name = "Arial"
        Appearance3.FontData.SizeInPoints = 8.25!
        Appearance3.FontData.StrikeoutAsString = "False"
        Appearance3.FontData.UnderlineAsString = "False"
        Me.txt_Notes.Appearance = Appearance3
        Me.txt_Notes.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Notes.Location = New System.Drawing.Point(164, 130)
        Me.txt_Notes.Multiline = True
        Me.txt_Notes.Name = "txt_Notes"
        Me.txt_Notes.Size = New System.Drawing.Size(504, 92)
        Me.txt_Notes.TabIndex = 168
        '
        'chk_InPrint
        '
        Appearance4.FontData.BoldAsString = "False"
        Appearance4.FontData.SizeInPoints = 8.0!
        Me.chk_InPrint.Appearance = Appearance4
        Me.chk_InPrint.Location = New System.Drawing.Point(164, 36)
        Me.chk_InPrint.Name = "chk_InPrint"
        Me.chk_InPrint.Size = New System.Drawing.Size(166, 21)
        Me.chk_InPrint.TabIndex = 167
        Me.chk_InPrint.Text = "Print Parameter in Output ?"
        '
        'chk_IsInput
        '
        Appearance5.FontData.BoldAsString = "False"
        Appearance5.FontData.SizeInPoints = 8.0!
        Me.chk_IsInput.Appearance = Appearance5
        Me.chk_IsInput.Location = New System.Drawing.Point(164, 78)
        Me.chk_IsInput.Name = "chk_IsInput"
        Me.chk_IsInput.Size = New System.Drawing.Size(166, 21)
        Me.chk_IsInput.TabIndex = 166
        Me.chk_IsInput.Text = "Input Parameter ?"
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
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance6.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance6
        Me.btnCancel.Location = New System.Drawing.Point(486, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance7.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance7
        Me.btnOK.Location = New System.Drawing.Point(582, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmb_DataType)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.txt_ParamName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_ParamCode)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 109)
        Me.Panel1.TabIndex = 140
        '
        'cmb_DataType
        '
        Me.cmb_DataType.LimitToList = True
        Me.cmb_DataType.Location = New System.Drawing.Point(166, 75)
        Me.cmb_DataType.Name = "cmb_DataType"
        Me.cmb_DataType.Size = New System.Drawing.Size(208, 21)
        Me.cmb_DataType.TabIndex = 160
        Me.cmb_DataType.Text = "UltraComboEditor1"
        '
        'UltraLabel1
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance8
        Me.UltraLabel1.Location = New System.Drawing.Point(78, 75)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel1.TabIndex = 159
        Me.UltraLabel1.Text = "Data Type"
        '
        'txt_ParamName
        '
        Appearance9.FontData.SizeInPoints = 9.0!
        Me.txt_ParamName.Appearance = Appearance9
        Me.txt_ParamName.Location = New System.Drawing.Point(166, 44)
        Me.txt_ParamName.Name = "txt_ParamName"
        Me.txt_ParamName.Size = New System.Drawing.Size(504, 22)
        Me.txt_ParamName.TabIndex = 158
        Me.txt_ParamName.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(42, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Parameter Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ParamCode
        '
        Appearance10.FontData.SizeInPoints = 9.0!
        Me.txt_ParamCode.Appearance = Appearance10
        Me.txt_ParamCode.Location = New System.Drawing.Point(166, 12)
        Me.txt_ParamCode.Name = "txt_ParamCode"
        Me.txt_ParamCode.Size = New System.Drawing.Size(160, 22)
        Me.txt_ParamCode.TabIndex = 156
        Me.txt_ParamCode.Text = "UltraTextEditor1"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label22.Location = New System.Drawing.Point(42, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 16)
        Me.Label22.TabIndex = 155
        Me.Label22.Text = "Parameter Code"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(690, 365)
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl19)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl20)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabControl2.Location = New System.Drawing.Point(0, 109)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(694, 388)
        Me.UltraTabControl2.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl2.TabIndex = 141
        UltraTab1.Key = "serial"
        UltraTab1.TabPage = Me.UltraTabPageControl5
        UltraTab1.Text = "Value"
        UltraTab12.TabPage = Me.UltraTabPageControl19
        UltraTab12.Text = "Check"
        UltraTab2.Key = "rename"
        UltraTab2.TabPage = Me.UltraTabPageControl1
        UltraTab2.Text = "Rename"
        UltraTab19.TabPage = Me.UltraTabPageControl20
        UltraTab19.Text = "General"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab12, UltraTab2, UltraTab19})
        '
        'frmTFCompDefParam
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Component Definition Parameters"
        Me.ClientSize = New System.Drawing.Size(694, 545)
        Me.Controls.Add(Me.UltraTabControl2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTFCompDefParam"
        Me.Text = "Component Definition Parameters"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl11.ResumeLayout(False)
        CType(Me.ugrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.ugrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.ugrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.ugrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.ugrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.ugrid6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.ugrid7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl14.ResumeLayout(False)
        CType(Me.agrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl15.ResumeLayout(False)
        CType(Me.agrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl12.ResumeLayout(False)
        CType(Me.agrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl18.ResumeLayout(False)
        CType(Me.agrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl16.ResumeLayout(False)
        CType(Me.agrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl17.ResumeLayout(False)
        CType(Me.agrid6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl3.ResumeLayout(False)
        Me.UltraTabPageControl13.ResumeLayout(False)
        CType(Me.UltraTabControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl4.ResumeLayout(False)
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.UltraTabPageControl19.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TextNewCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl20.ResumeLayout(False)
        Me.UltraTabPageControl20.PerformLayout()
        CType(Me.txt_Notes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_InPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_DataType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ParamName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ParamCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextNewCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReplace As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnFind As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabControl3 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabControl4 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl15 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugrid4 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugrid5 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugrid6 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugrid7 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl16 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrid5 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl17 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrid6 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl18 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrid4 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txt_Formula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl19 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_CheckFormula As ctlFormulaEditorScintilla
    Friend WithEvents UltraTabPageControl20 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents chk_InPrint As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_IsInput As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Notes As Infragistics.Win.UltraWinEditors.UltraTextEditor

#End Region
End Class

