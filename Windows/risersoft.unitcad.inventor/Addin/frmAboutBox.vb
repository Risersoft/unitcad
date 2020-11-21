Imports risersoft.app.shared

Public Class frmAboutBox
    Inherits frmAboutRSBase

    Protected Overrides Sub AboutBox1_Load(sender As Object, e As System.EventArgs)
        MyBase.AboutBox1_Load(sender, e)
        Me.PictureBox1.Image = My.Resources.logo
        Me.PictureBox2.Image = Me.RiserLogo
    End Sub
End Class