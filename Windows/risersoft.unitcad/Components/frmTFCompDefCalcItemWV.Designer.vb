<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFCompDefCalcItemWV
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
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmb_SumType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Remarks = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.txt_FactorFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.txt_LengthFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.txt_WidthFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.txt_HeightFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.txt_QtyFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.cmb_SumType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        Me.UltraTabPageControl5.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmb_SumType)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_Remarks)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(690, 102)
        Me.Panel2.TabIndex = 0
        '
        'cmb_SumType
        '
        Me.cmb_SumType.Location = New System.Drawing.Point(118, 25)
        Me.cmb_SumType.Name = "cmb_SumType"
        Me.cmb_SumType.Size = New System.Drawing.Size(193, 21)
        Me.cmb_SumType.TabIndex = 632
        Me.cmb_SumType.Text = "UltraComboEditor1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Sum Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Location = New System.Drawing.Point(118, 64)
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(495, 32)
        Me.txt_Remarks.TabIndex = 78
        Me.txt_Remarks.Text = "UltraTextEditor3"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(32, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Remarks"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 475)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(690, 40)
        Me.Panel4.TabIndex = 5
        '
        'btnCancel
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance1
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(514, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance2
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(602, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 40)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.txt_QtyFormula)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(686, 347)
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.txt_FactorFormula)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(686, 347)
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.txt_LengthFormula)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(686, 347)
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.txt_WidthFormula)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(686, 347)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.txt_HeightFormula)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(686, 347)
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(686, 347)
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 102)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(690, 373)
        Me.UltraTabControl1.TabIndex = 8
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Factor"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Length"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Width"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Height"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Quantity"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab4, UltraTab3, UltraTab1, UltraTab6})
        '
        'txt_FactorFormula
        '
        Me.txt_FactorFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_FactorFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_FactorFormula.LabelText = ""
        Me.txt_FactorFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_FactorFormula.Name = "txt_FactorFormula"
        Me.txt_FactorFormula.Size = New System.Drawing.Size(686, 347)
        Me.txt_FactorFormula.TabIndex = 7
        '
        'txt_LengthFormula
        '
        Me.txt_LengthFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_LengthFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_LengthFormula.LabelText = ""
        Me.txt_LengthFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_LengthFormula.Name = "txt_LengthFormula"
        Me.txt_LengthFormula.Size = New System.Drawing.Size(686, 347)
        Me.txt_LengthFormula.TabIndex = 7
        '
        'txt_WidthFormula
        '
        Me.txt_WidthFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_WidthFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_WidthFormula.LabelText = ""
        Me.txt_WidthFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_WidthFormula.Name = "txt_WidthFormula"
        Me.txt_WidthFormula.Size = New System.Drawing.Size(686, 347)
        Me.txt_WidthFormula.TabIndex = 7
        '
        'txt_HeightFormula
        '
        Me.txt_HeightFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_HeightFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_HeightFormula.LabelText = ""
        Me.txt_HeightFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_HeightFormula.Name = "txt_HeightFormula"
        Me.txt_HeightFormula.Size = New System.Drawing.Size(686, 347)
        Me.txt_HeightFormula.TabIndex = 7
        '
        'txt_QtyFormula
        '
        Me.txt_QtyFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_QtyFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_QtyFormula.LabelText = ""
        Me.txt_QtyFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_QtyFormula.Name = "txt_QtyFormula"
        Me.txt_QtyFormula.Size = New System.Drawing.Size(686, 347)
        Me.txt_QtyFormula.TabIndex = 7
        '
        'frmTFCompDefCalcItemWV
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Component Definition Calculation Item"
        Me.ClientSize = New System.Drawing.Size(690, 515)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmTFCompDefCalcItemWV"
        Me.Text = "Component Definition Calculation Item"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cmb_SumType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Remarks As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_SumType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents txt_QtyFormula As ctlFormulaEditorScintilla
    Friend WithEvents txt_FactorFormula As ctlFormulaEditorScintilla
    Friend WithEvents txt_LengthFormula As ctlFormulaEditorScintilla
    Friend WithEvents txt_WidthFormula As ctlFormulaEditorScintilla
    Friend WithEvents txt_HeightFormula As ctlFormulaEditorScintilla

#End Region
End Class

