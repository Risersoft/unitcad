<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIVCHost

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIVCHost))
        Me.AxInventorViewControl1 = New AxInventorViewControlLib.AxInventorViewControl()
        CType(Me.AxInventorViewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxInventorViewControl1
        '
        Me.AxInventorViewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxInventorViewControl1.Enabled = True
        Me.AxInventorViewControl1.Location = New System.Drawing.Point(0, 0)
        Me.AxInventorViewControl1.Name = "AxInventorViewControl1"
        Me.AxInventorViewControl1.OcxState = CType(resources.GetObject("AxInventorViewControl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxInventorViewControl1.Size = New System.Drawing.Size(284, 262)
        Me.AxInventorViewControl1.TabIndex = 356
        '
        'frmIVCHost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.AxInventorViewControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIVCHost"
        Me.Text = "frmIVCHost"
        CType(Me.AxInventorViewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxInventorViewControl1 As AxInventorViewControlLib.AxInventorViewControl
End Class
