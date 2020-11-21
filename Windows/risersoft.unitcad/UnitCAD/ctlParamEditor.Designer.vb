Imports System.Windows.Forms
Imports uwg = Infragistics.Win.UltraWinGrid
Imports uwt = Infragistics.Win.UltraWinTabControl
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class ctlParamEditor
    Inherits UserControl

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
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSelect = New Infragistics.Win.Misc.UltraButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(433, 309)
        Me.PropertyGrid1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 309)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 48)
        Me.Panel1.TabIndex = 4
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "False"
        Me.btnSelect.Appearance = Appearance1
        Me.btnSelect.AutoSize = True
        Me.btnSelect.Location = New System.Drawing.Point(250, 13)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(154, 24)
        Me.btnSelect.TabIndex = 166
        Me.btnSelect.Text = "Select from Design Table ..."
        '
        'ctlParamEditor
        '
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ctlParamEditor"
        Me.Size = New System.Drawing.Size(433, 357)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSelect As Infragistics.Win.Misc.UltraButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

#End Region
End Class

