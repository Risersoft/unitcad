Imports System.IO

Public Class clsDll
    Dim file1, file2 As String
    Public Sub New()
        file1 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location) & "\asdkOPMNetExt.dll"
        file2 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location) & "\asdk.txt"
    End Sub
    Protected Friend Sub OnAfterUninstall()
        If System.IO.File.Exists(file1) Then File.Delete(file1)
        If System.IO.File.Exists(file2) Then File.Delete(file2)
    End Sub
    Protected Friend Sub OnAfterInstall(version As String)
        Me.EmitDll(version)
    End Sub
    Private Sub EmitDll(version As String)
        Dim s As Stream, str1 As String

        If Environment.Is64BitOperatingSystem Then
            str1 = "asdkOPMNetExt.dll." & version & ".x64"
        Else
            str1 = "asdkOPMNetExt.dll." & version & ".x86"
        End If

        For Each str2 As String In System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceNames
            If str2.IndexOf(str1) >= 0 Then
#If DEBUG Then
                My.Computer.FileSystem.WriteAllText(file2, str1 & vbCrLf & str2, False)
#End If
                s = System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceStream(str2)
                Exit For
            End If
        Next
        'System.Diagnostics.Debugger.Launch()
        If Not s Is Nothing Then
            Using fs As FileStream = System.IO.File.Create(file1, CInt(s.Length))
                Dim byt(CInt(s.Length) - 1) As Byte
                s.Read(byt, 0, CInt(s.Length))
                fs.Write(byt, 0, byt.Length)
                fs.Close()
            End Using
        End If
    End Sub

End Class
