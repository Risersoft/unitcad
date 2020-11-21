Public Class Main
    Shared p As clsDll, action As String = "", version As String = "2012"
    Public Shared Sub Main()
        p = New clsDll
        ParseParameters()
        Select Case action.Trim.ToLower
            Case "install"
                p.OnAfterInstall(version)
            Case "uninstall"
                p.OnAfterUninstall()
            Case "rollback"
                p.OnAfterUninstall()
        End Select
    End Sub
    Private Shared Sub ParseParameters()
        Dim str1, str2 As String
        'System.Diagnostics.Debugger.Launch()
        Dim commandLineArgs As String() = Environment.GetCommandLineArgs()
        For i As Integer = 0 To CInt(commandLineArgs.Length) - 1
            Dim strcommand As String = commandLineArgs(i)
            Dim chrArray As Char() = New Char() {":", "="}
            Dim strArrays As String() = strcommand.Split(chrArray)
            If CInt(strArrays.Length) > 0 AndAlso strArrays(0).StartsWith("/") Then
                str1 = strArrays(0).ToLowerInvariant()
                If CInt(strArrays.Length) > 1 Then str2 = strArrays(1) Else str2 = String.Empty
                Dim flag As Boolean = False
                'Get the value of num
                Select Case str1.Trim.ToLower
                    Case "/a"
                        action = str2.Trim
                    Case "/v"
                        version = str2.Trim
                End Select
            End If
        Next
    End Sub

End Class
