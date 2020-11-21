Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmParamEditor
    Inherits frmMax

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParamEditor))
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.okButton = New System.Windows.Forms.Button()
        Me.applyButton = New System.Windows.Forms.Button()
        Me.customPanel = New System.Windows.Forms.Panel()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.m_switchEditors = New System.Windows.Forms.Button()
        Me.partNamePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.partNameTextBox = New System.Windows.Forms.TextBox()
        Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tableLayoutPanel1.SuspendLayout()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.partNamePanel.SuspendLayout()
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "restoreDefault_Active.png")
        Me.imageList1.Images.SetKeyName(1, "restoreDefault_Inactive.png")
        Me.imageList1.Images.SetKeyName(2, "Design16.png")
        '
        'buttonCancel
        '
        Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonCancel.CausesValidation = False
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Location = New System.Drawing.Point(521, 3)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 25)
        Me.buttonCancel.TabIndex = 0
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'okButton
        '
        Me.okButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.okButton.Location = New System.Drawing.Point(440, 3)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 25)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'applyButton
        '
        Me.applyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.applyButton.Location = New System.Drawing.Point(359, 3)
        Me.applyButton.Name = "applyButton"
        Me.applyButton.Size = New System.Drawing.Size(75, 25)
        Me.applyButton.TabIndex = 2
        Me.applyButton.Text = "Apply"
        Me.applyButton.UseVisualStyleBackColor = True
        '
        'customPanel
        '
        Me.customPanel.CausesValidation = False
        Me.customPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.customPanel.Location = New System.Drawing.Point(3, 35)
        Me.customPanel.Name = "customPanel"
        Me.customPanel.Size = New System.Drawing.Size(599, 210)
        Me.customPanel.TabIndex = 0
        Me.customPanel.TabStop = True
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.customPanel, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.flowLayoutPanel1, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.partNamePanel, 0, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(605, 285)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.AutoSize = True
        Me.flowLayoutPanel1.Controls.Add(Me.buttonCancel)
        Me.flowLayoutPanel1.Controls.Add(Me.okButton)
        Me.flowLayoutPanel1.Controls.Add(Me.applyButton)
        Me.flowLayoutPanel1.Controls.Add(Me.m_switchEditors)
        Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(3, 251)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(599, 31)
        Me.flowLayoutPanel1.TabIndex = 1
        '
        'm_switchEditors
        '
        Me.m_switchEditors.Cursor = System.Windows.Forms.Cursors.Default
        Me.m_switchEditors.Image = Global.risersoft.unitcad.My.Resources.Resources.ToggleCustomStandardPartEditor
        Me.m_switchEditors.Location = New System.Drawing.Point(278, 3)
        Me.m_switchEditors.Name = "m_switchEditors"
        Me.m_switchEditors.Size = New System.Drawing.Size(75, 25)
        Me.m_switchEditors.TabIndex = 3
        Me.m_switchEditors.UseVisualStyleBackColor = True
        '
        'partNamePanel
        '
        Me.partNamePanel.AutoSize = True
        Me.partNamePanel.Controls.Add(Me.label1)
        Me.partNamePanel.Controls.Add(Me.partNameTextBox)
        Me.partNamePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.partNamePanel.Location = New System.Drawing.Point(3, 3)
        Me.partNamePanel.Name = "partNamePanel"
        Me.partNamePanel.Size = New System.Drawing.Size(599, 26)
        Me.partNamePanel.TabIndex = 2
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(3, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 22)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Part Name:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'partNameTextBox
        '
        Me.partNameTextBox.Location = New System.Drawing.Point(89, 3)
        Me.partNameTextBox.Name = "partNameTextBox"
        Me.partNameTextBox.Size = New System.Drawing.Size(178, 20)
        Me.partNameTextBox.TabIndex = 1
        '
        'errorProvider1
        '
        Me.errorProvider1.ContainerControl = Me
        '
        'frmParamEditor
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelButton
        Me.Text = "Parameter Editor"
        Me.ClientSize = New System.Drawing.Size(609, 289)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmParamEditor"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Parameter Editor"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.partNamePanel.ResumeLayout(False)
        Me.partNamePanel.PerformLayout()
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


    Private imageList1 As ImageList

    Private WithEvents okButton As Button

    Private WithEvents buttonCancel As Button

    Private WithEvents applyButton As Button

    Private customPanel As Panel

    Private tableLayoutPanel1 As TableLayoutPanel

    Private flowLayoutPanel1 As FlowLayoutPanel

    Private partNamePanel As FlowLayoutPanel

    Private label1 As Label

    Private WithEvents partNameTextBox As TextBox

    Private errorProvider1 As ErrorProvider

    Private WithEvents m_switchEditors As Button

End Class
