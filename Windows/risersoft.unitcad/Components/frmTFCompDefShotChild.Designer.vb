<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFCompDefShotChild
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
    Friend WithEvents cmb_CompDefDescrip As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_ChildCompDefID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_QtyFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_CompDefCodeFormula = New risersoft.[shared].win.ctlFormulaEditorScintilla()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCopyParams = New Infragistics.Win.Misc.UltraButton()
        Me.btnEdit = New Infragistics.Win.Misc.UltraButton()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.btnAdd = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_Remarks = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_CompDefDescrip = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_ChildCompDefID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.txt_NewName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CompDefDescrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ChildCompDefID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.txt_NewName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.txt_QtyFormula)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(705, 289)
        '
        'txt_QtyFormula
        '
        Me.txt_QtyFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_QtyFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_QtyFormula.LabelText = "Qty"
        Me.txt_QtyFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_QtyFormula.Name = "txt_QtyFormula"
        Me.txt_QtyFormula.Size = New System.Drawing.Size(705, 289)
        Me.txt_QtyFormula.TabIndex = 10
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.txt_CompDefCodeFormula)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(705, 306)
        '
        'txt_CompDefCodeFormula
        '
        Me.txt_CompDefCodeFormula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_CompDefCodeFormula.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_CompDefCodeFormula.LabelText = "Component Code"
        Me.txt_CompDefCodeFormula.Location = New System.Drawing.Point(0, 0)
        Me.txt_CompDefCodeFormula.Name = "txt_CompDefCodeFormula"
        Me.txt_CompDefCodeFormula.Size = New System.Drawing.Size(705, 306)
        Me.txt_CompDefCodeFormula.TabIndex = 1
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(705, 306)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(705, 258)
        Me.UltraGrid1.TabIndex = 8
        Me.UltraGrid1.Text = "Overriding Parameters"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCopyParams)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnDel)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 258)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 48)
        Me.Panel1.TabIndex = 9
        '
        'btnCopyParams
        '
        Me.btnCopyParams.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopyParams.Location = New System.Drawing.Point(341, 16)
        Me.btnCopyParams.Name = "btnCopyParams"
        Me.btnCopyParams.Size = New System.Drawing.Size(119, 24)
        Me.btnCopyParams.TabIndex = 3
        Me.btnCopyParams.Text = "Copy From Child"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(545, 16)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(70, 24)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "&Edit"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Location = New System.Drawing.Point(466, 16)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 24)
        Me.btnDel.TabIndex = 2
        Me.btnDel.Text = "&Delete"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(624, 16)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 24)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Add New"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_NewName)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_Remarks)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cmb_CompDefDescrip)
        Me.Panel2.Controls.Add(Me.cmb_ChildCompDefID)
        Me.Panel2.Controls.Add(Me.UltraLabel2)
        Me.Panel2.Controls.Add(Me.UltraLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(709, 137)
        Me.Panel2.TabIndex = 0
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Location = New System.Drawing.Point(118, 99)
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(495, 32)
        Me.txt_Remarks.TabIndex = 2
        Me.txt_Remarks.Text = "UltraTextEditor3"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(14, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 21)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Remarks"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CompDefDescrip
        '
        Me.cmb_CompDefDescrip.DataMember = "CompDef"
        Me.cmb_CompDefDescrip.DisplayMember = "Descrip"
        Me.cmb_CompDefDescrip.Location = New System.Drawing.Point(117, 40)
        Me.cmb_CompDefDescrip.Name = "cmb_CompDefDescrip"
        Me.cmb_CompDefDescrip.Size = New System.Drawing.Size(496, 22)
        Me.cmb_CompDefDescrip.TabIndex = 1
        Me.cmb_CompDefDescrip.ValueMember = "TFCompDefID"
        '
        'cmb_ChildCompDefID
        '
        Me.cmb_ChildCompDefID.DataMember = "CompDef"
        Me.cmb_ChildCompDefID.DisplayMember = "CompDefCode"
        Me.cmb_ChildCompDefID.Location = New System.Drawing.Point(117, 12)
        Me.cmb_ChildCompDefID.Name = "cmb_ChildCompDefID"
        Me.cmb_ChildCompDefID.Size = New System.Drawing.Size(224, 22)
        Me.cmb_ChildCompDefID.TabIndex = 0
        Me.cmb_ChildCompDefID.ValueMember = "TFCompDefID"
        '
        'UltraLabel2
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance2
        Me.UltraLabel2.Location = New System.Drawing.Point(17, 40)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(94, 24)
        Me.UltraLabel2.TabIndex = 8
        Me.UltraLabel2.Text = "Description"
        '
        'UltraLabel1
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance9
        Me.UltraLabel1.Location = New System.Drawing.Point(19, 12)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(92, 23)
        Me.UltraLabel1.TabIndex = 7
        Me.UltraLabel1.Text = "Code"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 452)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(709, 40)
        Me.Panel4.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance5
        Me.btnSave.Location = New System.Drawing.Point(422, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance6.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance6
        Me.btnCancel.Location = New System.Drawing.Point(518, 3)
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
        Me.btnOK.Location = New System.Drawing.Point(614, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 137)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(709, 315)
        Me.UltraTabControl1.TabIndex = 8
        UltraTab3.Key = "qty"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Qty Formula"
        UltraTab2.Key = "selec"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Conditional Selection of Child"
        UltraTab1.Key = "param"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Parameters Value / Override"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab2, UltraTab1})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(705, 289)
        '
        'txt_NewName
        '
        Appearance11.FontData.SizeInPoints = 9.0!
        Me.txt_NewName.Appearance = Appearance11
        Me.txt_NewName.Location = New System.Drawing.Point(117, 68)
        Me.txt_NewName.Name = "txt_NewName"
        Me.txt_NewName.Size = New System.Drawing.Size(496, 22)
        Me.txt_NewName.TabIndex = 351
        Me.txt_NewName.Text = "UltraTextEditor1"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(17, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 21)
        Me.Label4.TabIndex = 352
        Me.Label4.Text = "New Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmTFCompDefShotChild
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Component SnapShot Child"
        Me.ClientSize = New System.Drawing.Size(709, 492)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "frmTFCompDefShotChild"
        Me.Text = "Component SnapShot Child"
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CompDefDescrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ChildCompDefID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.txt_NewName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_Remarks As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAdd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCopyParams As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_QtyFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents txt_CompDefCodeFormula As risersoft.shared.win.ctlFormulaEditorScintilla
    Friend WithEvents txt_NewName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label

#End Region
End Class

