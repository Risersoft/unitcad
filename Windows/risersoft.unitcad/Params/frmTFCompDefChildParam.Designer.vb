Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFCompDefChildParam
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_DataType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_paramname = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_paramcode = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.txt_Formula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl5.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_DataType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_paramname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_paramcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Formula)
        Me.UltraTabPageControl5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(690, 360)
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
        Appearance1.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance1
        Me.btnCancel.Location = New System.Drawing.Point(486, 8)
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
        Me.Panel1.Controls.Add(Me.cmb_paramname)
        Me.Panel1.Controls.Add(Me.cmb_paramcode)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 114)
        Me.Panel1.TabIndex = 140
        '
        'cmb_DataType
        '
        Me.cmb_DataType.LimitToList = True
        Me.cmb_DataType.Location = New System.Drawing.Point(166, 75)
        Me.cmb_DataType.Name = "cmb_DataType"
        Me.cmb_DataType.ReadOnly = True
        Me.cmb_DataType.Size = New System.Drawing.Size(208, 21)
        Me.cmb_DataType.TabIndex = 163
        Me.cmb_DataType.Text = "UltraComboEditor1"
        '
        'UltraLabel1
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance7
        Me.UltraLabel1.Location = New System.Drawing.Point(78, 75)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel1.TabIndex = 162
        Me.UltraLabel1.Text = "Data Type"
        '
        'cmb_paramname
        '
        Me.cmb_paramname.DataMember = "params"
        Me.cmb_paramname.DisplayMember = "paramname"
        Me.cmb_paramname.Location = New System.Drawing.Point(166, 44)
        Me.cmb_paramname.Name = "cmb_paramname"
        Me.cmb_paramname.ReadOnly = True
        Me.cmb_paramname.Size = New System.Drawing.Size(496, 22)
        Me.cmb_paramname.TabIndex = 161
        Me.cmb_paramname.ValueMember = "paramcode"
        '
        'cmb_paramcode
        '
        Me.cmb_paramcode.DataMember = "params"
        Me.cmb_paramcode.DisplayMember = "paramcode"
        Me.cmb_paramcode.Location = New System.Drawing.Point(166, 13)
        Me.cmb_paramcode.Name = "cmb_paramcode"
        Me.cmb_paramcode.Size = New System.Drawing.Size(161, 22)
        Me.cmb_paramcode.TabIndex = 160
        Me.cmb_paramcode.ValueMember = "paramcode"
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
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(690, 360)
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabControl2.Location = New System.Drawing.Point(0, 114)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(694, 383)
        Me.UltraTabControl2.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl2.TabIndex = 141
        UltraTab1.Key = "serial"
        UltraTab1.TabPage = Me.UltraTabPageControl5
        UltraTab1.Text = "Formula"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        '
        'txt_Formula
        '
        Me.txt_Formula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Formula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Formula.LabelText = ""
        Me.txt_Formula.Location = New System.Drawing.Point(0, 0)
        Me.txt_Formula.Name = "txt_Formula"
        Me.txt_Formula.Size = New System.Drawing.Size(690, 360)
        Me.txt_Formula.TabIndex = 1
        '
        'frmTFCompDefChildParam
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Component Definition Child Parameters"
        Me.ClientSize = New System.Drawing.Size(694, 545)
        Me.Controls.Add(Me.UltraTabControl2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTFCompDefChildParam"
        Me.Text = "Component Definition Child Parameters"
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_DataType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_paramname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_paramcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_paramname As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_paramcode As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_DataType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Formula As risersoft.shared.win.ctlFormulaEditorScintilla

#End Region
End Class

