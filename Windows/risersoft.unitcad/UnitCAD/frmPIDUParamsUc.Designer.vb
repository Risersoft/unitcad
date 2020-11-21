Imports uwg = Infragistics.Win.UltraWinGrid
Imports uwt = Infragistics.Win.UltraWinTabControl
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPIDUParamsUc
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnExportFile = New Infragistics.Win.Misc.UltraButton()
        Me.btnImportFile = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnImportXL = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New Infragistics.Win.Misc.UltraButton()
        Me.btnBrowse = New Infragistics.Win.Misc.UltraButton()
        Me.lblTemplate = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_TemplateFileName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btnSelect = New Infragistics.Win.Misc.UltraButton()
        Me.cmb_Startupdefid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lblStartup = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_TemplateFileName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Startupdefid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid1.Location = New System.Drawing.Point(0, 96)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(742, 371)
        Me.PropertyGrid1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnExportFile)
        Me.Panel2.Controls.Add(Me.btnImportFile)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnImportXL)
        Me.Panel2.Controls.Add(Me.btnOK)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 467)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(742, 40)
        Me.Panel2.TabIndex = 3
        '
        'btnSave
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(502, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 40)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        '
        'btnExportFile
        '
        Appearance4.FontData.BoldAsString = "False"
        Me.btnExportFile.Appearance = Appearance4
        Me.btnExportFile.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExportFile.Location = New System.Drawing.Point(175, 0)
        Me.btnExportFile.Name = "btnExportFile"
        Me.btnExportFile.Size = New System.Drawing.Size(99, 40)
        Me.btnExportFile.TabIndex = 165
        Me.btnExportFile.Text = "Export to UCAD File ..."
        '
        'btnImportFile
        '
        Appearance3.FontData.BoldAsString = "False"
        Me.btnImportFile.Appearance = Appearance3
        Me.btnImportFile.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnImportFile.Location = New System.Drawing.Point(81, 0)
        Me.btnImportFile.Name = "btnImportFile"
        Me.btnImportFile.Size = New System.Drawing.Size(94, 40)
        Me.btnImportFile.TabIndex = 164
        Me.btnImportFile.Text = "Import From UCAD File ..."
        '
        'btnCancel
        '
        Appearance49.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance49
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(582, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnImportXL
        '
        Appearance2.FontData.BoldAsString = "False"
        Me.btnImportXL.Appearance = Appearance2
        Me.btnImportXL.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnImportXL.Location = New System.Drawing.Point(0, 0)
        Me.btnImportXL.Name = "btnImportXL"
        Me.btnImportXL.Size = New System.Drawing.Size(81, 40)
        Me.btnImportXL.TabIndex = 163
        Me.btnImportXL.Text = "Import From Excel ..."
        '
        'btnOK
        '
        Appearance50.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance50
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(662, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 40)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnBrowse)
        Me.Panel1.Controls.Add(Me.lblTemplate)
        Me.Panel1.Controls.Add(Me.txt_TemplateFileName)
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.cmb_Startupdefid)
        Me.Panel1.Controls.Add(Me.lblStartup)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 96)
        Me.Panel1.TabIndex = 4
        '
        'btnClear
        '
        Appearance11.FontData.BoldAsString = "False"
        Me.btnClear.Appearance = Appearance11
        Me.btnClear.Location = New System.Drawing.Point(100, 66)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(58, 24)
        Me.btnClear.TabIndex = 170
        Me.btnClear.Text = "Clear"
        '
        'btnBrowse
        '
        Appearance6.FontData.BoldAsString = "False"
        Me.btnBrowse.Appearance = Appearance6
        Me.btnBrowse.Location = New System.Drawing.Point(25, 66)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(69, 24)
        Me.btnBrowse.TabIndex = 169
        Me.btnBrowse.Text = "Browse ..."
        '
        'lblTemplate
        '
        Appearance14.FontData.BoldAsString = "True"
        Appearance14.TextHAlignAsString = "Right"
        Appearance14.TextVAlignAsString = "Middle"
        Me.lblTemplate.Appearance = Appearance14
        Me.lblTemplate.Location = New System.Drawing.Point(11, 40)
        Me.lblTemplate.Name = "lblTemplate"
        Me.lblTemplate.Size = New System.Drawing.Size(118, 16)
        Me.lblTemplate.TabIndex = 168
        Me.lblTemplate.Text = "Template File Name"
        '
        'txt_TemplateFileName
        '
        Me.txt_TemplateFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TemplateFileName.Location = New System.Drawing.Point(133, 40)
        Me.txt_TemplateFileName.Name = "txt_TemplateFileName"
        Me.txt_TemplateFileName.ReadOnly = True
        Me.txt_TemplateFileName.Size = New System.Drawing.Size(606, 21)
        Me.txt_TemplateFileName.TabIndex = 167
        Me.txt_TemplateFileName.Text = "UltraTextEditor1"
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.FontData.BoldAsString = "False"
        Me.btnSelect.Appearance = Appearance5
        Me.btnSelect.AutoSize = True
        Me.btnSelect.Location = New System.Drawing.Point(559, 61)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(154, 24)
        Me.btnSelect.TabIndex = 166
        Me.btnSelect.Text = "Select from Design Table ..."
        '
        'cmb_Startupdefid
        '
        Me.cmb_Startupdefid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Startupdefid.DataMember = "params"
        Me.cmb_Startupdefid.DisplayMember = "paramcode"
        Me.cmb_Startupdefid.Location = New System.Drawing.Point(133, 12)
        Me.cmb_Startupdefid.Name = "cmb_Startupdefid"
        Me.cmb_Startupdefid.Size = New System.Drawing.Size(606, 22)
        Me.cmb_Startupdefid.TabIndex = 162
        Me.cmb_Startupdefid.Text = "test"
        Me.cmb_Startupdefid.ValueMember = "paramcode"
        '
        'lblStartup
        '
        Me.lblStartup.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStartup.Location = New System.Drawing.Point(9, 12)
        Me.lblStartup.Name = "lblStartup"
        Me.lblStartup.Size = New System.Drawing.Size(120, 16)
        Me.lblStartup.TabIndex = 161
        Me.lblStartup.Text = "Startup Component"
        Me.lblStartup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPIDUParams
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Work Order Parameters"
        Me.ClientSize = New System.Drawing.Size(742, 507)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPIDUParams"
        Me.Text = "Work Order Parameters"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_TemplateFileName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Startupdefid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblStartup As System.Windows.Forms.Label
    Friend WithEvents btnImportXL As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnImportFile As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnExportFile As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSelect As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblTemplate As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_TemplateFileName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnBrowse As Infragistics.Win.Misc.UltraButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnClear As Infragistics.Win.Misc.UltraButton
    Public WithEvents cmb_Startupdefid As uwg.UltraCombo

#End Region
End Class

