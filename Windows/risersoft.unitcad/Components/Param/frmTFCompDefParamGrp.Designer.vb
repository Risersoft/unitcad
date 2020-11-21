Imports System.Xml
Imports Infragistics.Win.UltraWinTabControl
Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFCompDefParamGrp
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_PrintType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.chk_ShowInherited = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_GroupName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Description = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl19 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_PrintTypeFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_PrintType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_ShowInherited, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GroupName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        Me.UltraTabPageControl5.SuspendLayout()
        Me.UltraTabPageControl19.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(756, 409)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmb_PrintType)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.chk_ShowInherited)
        Me.Panel1.Controls.Add(Me.txt_GroupName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.UltraLabel6)
        Me.Panel1.Controls.Add(Me.txt_Description)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(643, 195)
        Me.Panel1.TabIndex = 0
        '
        'cmb_PrintType
        '
        Me.cmb_PrintType.LimitToList = True
        Me.cmb_PrintType.Location = New System.Drawing.Point(133, 159)
        Me.cmb_PrintType.Name = "cmb_PrintType"
        Me.cmb_PrintType.Size = New System.Drawing.Size(208, 21)
        Me.cmb_PrintType.TabIndex = 165
        Me.cmb_PrintType.Text = "UltraComboEditor1"
        '
        'UltraLabel1
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.Location = New System.Drawing.Point(45, 159)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel1.TabIndex = 164
        Me.UltraLabel1.Text = "Print Type"
        '
        'chk_ShowInherited
        '
        Appearance8.FontData.BoldAsString = "False"
        Appearance8.FontData.SizeInPoints = 8.0!
        Me.chk_ShowInherited.Appearance = Appearance8
        Me.chk_ShowInherited.Location = New System.Drawing.Point(133, 125)
        Me.chk_ShowInherited.Name = "chk_ShowInherited"
        Me.chk_ShowInherited.Size = New System.Drawing.Size(207, 28)
        Me.chk_ShowInherited.TabIndex = 163
        Me.chk_ShowInherited.Text = "Show Inherited Parameters"
        '
        'txt_GroupName
        '
        Appearance11.FontData.SizeInPoints = 9.0!
        Me.txt_GroupName.Appearance = Appearance11
        Me.txt_GroupName.Location = New System.Drawing.Point(133, 27)
        Me.txt_GroupName.Name = "txt_GroupName"
        Me.txt_GroupName.Size = New System.Drawing.Size(436, 22)
        Me.txt_GroupName.TabIndex = 162
        Me.txt_GroupName.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(35, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Group Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraLabel6
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance5
        Me.UltraLabel6.Location = New System.Drawing.Point(35, 73)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(90, 21)
        Me.UltraLabel6.TabIndex = 160
        Me.UltraLabel6.Text = "Description"
        '
        'txt_Description
        '
        Appearance4.FontData.BoldAsString = "False"
        Appearance4.FontData.ItalicAsString = "False"
        Appearance4.FontData.Name = "Arial"
        Appearance4.FontData.SizeInPoints = 8.25!
        Appearance4.FontData.StrikeoutAsString = "False"
        Appearance4.FontData.UnderlineAsString = "False"
        Me.txt_Description.Appearance = Appearance4
        Me.txt_Description.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Description.Location = New System.Drawing.Point(133, 73)
        Me.txt_Description.Multiline = True
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.Size = New System.Drawing.Size(436, 39)
        Me.txt_Description.TabIndex = 159
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(639, 262)
        Me.UltraGrid1.TabIndex = 24
        Me.UltraGrid1.Text = "Core Material"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 480)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(643, 48)
        Me.Panel4.TabIndex = 74
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance1
        Me.btnCancel.Location = New System.Drawing.Point(435, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance2
        Me.btnOK.Location = New System.Drawing.Point(531, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl19)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabControl2.Location = New System.Drawing.Point(0, 195)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl2.Size = New System.Drawing.Size(643, 285)
        Me.UltraTabControl2.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl2.TabIndex = 142
        UltraTab1.Key = "serial"
        UltraTab1.TabPage = Me.UltraTabPageControl5
        UltraTab1.Text = "Paremeters"
        UltraTab12.TabPage = Me.UltraTabPageControl19
        UltraTab12.Text = "Condition"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab12})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(639, 262)
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(639, 262)
        '
        'UltraTabPageControl19
        '
        Me.UltraTabPageControl19.Controls.Add(Me.txt_PrintTypeFormula)
        Me.UltraTabPageControl19.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl19.Name = "UltraTabPageControl19"
        Me.UltraTabPageControl19.Size = New System.Drawing.Size(639, 262)
        '
        'txt_PrintTypeFormula
        '
        Me.txt_PrintTypeFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_PrintTypeFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_PrintTypeFormula.LabelText = ""
        Me.txt_PrintTypeFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_PrintTypeFormula.Name = "txt_PrintTypeFormula"
        Me.txt_PrintTypeFormula.Size = New System.Drawing.Size(639, 262)
        Me.txt_PrintTypeFormula.TabIndex = 1
        '
        'frmTFCompDefParamGrp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Component Parameter Group"
        Me.ClientSize = New System.Drawing.Size(643, 528)
        Me.Controls.Add(Me.UltraTabControl2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTFCompDefParamGrp"
        Me.ShowInTaskbar = False
        Me.Text = "Component Parameter Group"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_PrintType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_ShowInherited, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GroupName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.UltraTabPageControl19.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txt_GroupName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Description As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chk_ShowInherited As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cmb_PrintType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabControl2 As UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As UltraTabPageControl
    Friend WithEvents UltraTabPageControl19 As UltraTabPageControl
    Friend WithEvents txt_PrintTypeFormula As ctlFormulaEditorScintilla

#End Region
End Class

