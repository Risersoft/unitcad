Imports Infragistics.Win.UltraWinGrid
Imports System.Xml
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmGloParam
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call

        Me.initForm()


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
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_ParamGroup As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_ParamName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_ParamCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_DataType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.cmb_DataType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ParamGroup = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ParamName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ParamCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_RIDestableID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel56 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_DesTableColID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_DefaultValue = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chk_IsDBCADParam = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.cmb_DataType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ParamGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ParamName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ParamCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_RIDestableID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_DesTableColID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DefaultValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsDBCADParam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 423)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(533, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance2
        Me.btnSave.Location = New System.Drawing.Point(293, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance3
        Me.btnCancel.Location = New System.Drawing.Point(373, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance4
        Me.btnOK.Location = New System.Drawing.Point(453, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'cmb_DataType
        '
        Me.cmb_DataType.LimitToList = True
        Me.cmb_DataType.Location = New System.Drawing.Point(152, 256)
        Me.cmb_DataType.Name = "cmb_DataType"
        Me.cmb_DataType.Size = New System.Drawing.Size(208, 21)
        Me.cmb_DataType.TabIndex = 116
        Me.cmb_DataType.Text = "UltraComboEditor1"
        '
        'UltraLabel1
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance7
        Me.UltraLabel1.Location = New System.Drawing.Point(64, 256)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel1.TabIndex = 115
        Me.UltraLabel1.Text = "Data Type"
        '
        'txt_ParamGroup
        '
        Appearance10.FontData.SizeInPoints = 10.0!
        Me.txt_ParamGroup.Appearance = Appearance10
        Me.txt_ParamGroup.Location = New System.Drawing.Point(152, 76)
        Me.txt_ParamGroup.Name = "txt_ParamGroup"
        Me.txt_ParamGroup.Size = New System.Drawing.Size(336, 24)
        Me.txt_ParamGroup.TabIndex = 97
        Me.txt_ParamGroup.Text = "UltraTextEditor2"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(28, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Parameter Group"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ParamName
        '
        Appearance11.FontData.SizeInPoints = 10.0!
        Me.txt_ParamName.Appearance = Appearance11
        Me.txt_ParamName.Location = New System.Drawing.Point(152, 44)
        Me.txt_ParamName.Name = "txt_ParamName"
        Me.txt_ParamName.Size = New System.Drawing.Size(336, 24)
        Me.txt_ParamName.TabIndex = 95
        Me.txt_ParamName.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(28, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Parameter Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ParamCode
        '
        Appearance12.FontData.SizeInPoints = 10.0!
        Me.txt_ParamCode.Appearance = Appearance12
        Me.txt_ParamCode.Location = New System.Drawing.Point(152, 12)
        Me.txt_ParamCode.Name = "txt_ParamCode"
        Me.txt_ParamCode.Size = New System.Drawing.Size(208, 24)
        Me.txt_ParamCode.TabIndex = 93
        Me.txt_ParamCode.Text = "UltraTextEditor1"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(28, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 16)
        Me.Label22.TabIndex = 92
        Me.Label22.Text = "Parameter Code"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(48, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Remarks"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Remark.Location = New System.Drawing.Point(152, 108)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(336, 117)
        Me.txt_Remark.TabIndex = 87
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'cmb_RIDestableID
        '
        Me.cmb_RIDestableID.DataMember = "tanktype"
        Me.cmb_RIDestableID.DisplayMember = "tanktype"
        Me.cmb_RIDestableID.Location = New System.Drawing.Point(152, 292)
        Me.cmb_RIDestableID.Name = "cmb_RIDestableID"
        Me.cmb_RIDestableID.Size = New System.Drawing.Size(208, 22)
        Me.cmb_RIDestableID.TabIndex = 600
        Me.cmb_RIDestableID.Text = "UltraCombo4"
        Me.cmb_RIDestableID.ValueMember = "tanktypecode"
        '
        'UltraLabel56
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel56.Appearance = Appearance6
        Me.UltraLabel56.Location = New System.Drawing.Point(8, 282)
        Me.UltraLabel56.Name = "UltraLabel56"
        Me.UltraLabel56.Size = New System.Drawing.Size(136, 32)
        Me.UltraLabel56.TabIndex = 599
        Me.UltraLabel56.Text = "Parameter is a row index in the Design Table:"
        '
        'UltraLabel2
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance5
        Me.UltraLabel2.Location = New System.Drawing.Point(0, 329)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(136, 32)
        Me.UltraLabel2.TabIndex = 602
        Me.UltraLabel2.Text = "Override Column for Design Table Lookup"
        '
        'cmb_DesTableColID
        '
        Me.cmb_DesTableColID.DataMember = "tanktype"
        Me.cmb_DesTableColID.DisplayMember = "tanktype"
        Me.cmb_DesTableColID.Location = New System.Drawing.Point(152, 329)
        Me.cmb_DesTableColID.Name = "cmb_DesTableColID"
        Me.cmb_DesTableColID.Size = New System.Drawing.Size(208, 22)
        Me.cmb_DesTableColID.TabIndex = 601
        Me.cmb_DesTableColID.Text = "UltraCombo4"
        Me.cmb_DesTableColID.ValueMember = "tanktypecode"
        '
        'txt_DefaultValue
        '
        Me.txt_DefaultValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DefaultValue.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_DefaultValue.Location = New System.Drawing.Point(152, 368)
        Me.txt_DefaultValue.Name = "txt_DefaultValue"
        Me.txt_DefaultValue.Size = New System.Drawing.Size(336, 21)
        Me.txt_DefaultValue.TabIndex = 604
        Me.txt_DefaultValue.Text = "UltraTextEditor8"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(64, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 603
        Me.Label7.Text = "Default Value"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_IsDBCADParam
        '
        Me.chk_IsDBCADParam.Location = New System.Drawing.Point(152, 401)
        Me.chk_IsDBCADParam.Name = "chk_IsDBCADParam"
        Me.chk_IsDBCADParam.Size = New System.Drawing.Size(230, 16)
        Me.chk_IsDBCADParam.TabIndex = 605
        Me.chk_IsDBCADParam.Text = "Is General UnitCAD Parameter"
        '
        'frmGloParam
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Global Parameter"
        Me.ClientSize = New System.Drawing.Size(533, 471)
        Me.Controls.Add(Me.chk_IsDBCADParam)
        Me.Controls.Add(Me.txt_DefaultValue)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.cmb_DesTableColID)
        Me.Controls.Add(Me.cmb_RIDestableID)
        Me.Controls.Add(Me.UltraLabel56)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txt_ParamCode)
        Me.Controls.Add(Me.txt_Remark)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_DataType)
        Me.Controls.Add(Me.txt_ParamName)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_ParamGroup)
        Me.Name = "frmGloParam"
        Me.Text = "Global Parameter"
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.cmb_DataType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ParamGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ParamName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ParamCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_RIDestableID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_DesTableColID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DefaultValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsDBCADParam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_RIDestableID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel56 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_DesTableColID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_DefaultValue As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chk_IsDBCADParam As Infragistics.Win.UltraWinEditors.UltraCheckEditor

#End Region
End Class

