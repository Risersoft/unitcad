Imports System.ComponentModel
Imports System.Configuration.Install
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO
Public Class InstallerHelper
    Dim p As clsDll
    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add initialization code after the call to InitializeComponent
        p = New clsDll
    End Sub
    Protected Overrides Sub OnAfterRollback(savedState As System.Collections.IDictionary)
        Try
            MyBase.OnAfterRollback(savedState)
            p.OnAfterUninstall()
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnAfterUninstall(savedState As System.Collections.IDictionary)
        Try
            MyBase.OnAfterUninstall(savedState)
            p.OnAfterUninstall()
        Catch ex As Exception

        End Try
    End Sub


    Protected Overrides Sub OnAfterInstall(savedState As System.Collections.IDictionary)
        'System.Diagnostics.Debugger.Launch()
        'https://social.msdn.microsoft.com/Forums/vstudio/en-US/279e0aea-077c-4150-89ae-55d8494def1b/installer-class-passing-parameters
        Dim version As String = "2012"
        If Me.Context.Parameters.ContainsKey("version") Then version = Me.Context.Parameters("version")

        Try
            MyBase.OnAfterInstall(savedState)
            p.OnAfterInstall(version)
        Catch exc As Exception
            Context.LogMessage(exc.ToString())
            Throw
        End Try
    End Sub

End Class
