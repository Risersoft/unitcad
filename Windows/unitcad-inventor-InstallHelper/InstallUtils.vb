Imports System
Imports System.Collections
Imports System.Configuration.Install
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Xml


Public Class InstallUtils

    Public Shared Function GenerateAddinFileLocation(ByVal mode As RegFreeModeEnum, ByVal version As String) As String
        Dim userName As String = Environment.UserName
        Dim osVersion As String = CommonUtils.GetOsVersion(False)
        Select Case mode
            Case RegFreeModeEnum.kVersionDep
                Dim str As String = osVersion
                Dim str1 As String = str
                If (str Is Nothing) Then
                    Exit Select
                End If
                If (str1 = "Windows XP") Then
                    Return String.Concat("C:\Documents and Settings\All Users\Application Data\Autodesk\", version, "\Addins\")
                End If
                If (str1 = "Windows Vista" OrElse str1 = "Windows 7" OrElse str1 = "Windows 10") Then
                    Return String.Concat("C:\ProgramData\Autodesk\", version, "\Addins\")
                End If
                Exit Select
            Case RegFreeModeEnum.kVersionIndep
                Dim str2 As String = osVersion
                Dim str3 As String = str2
                If (str2 Is Nothing) Then
                    Exit Select
                End If
                If (str3 = "Windows XP") Then
                    Return "C:\Documents and Settings\All Users\Application Data\Autodesk\Inventor Addins\"
                End If
                If (str3 = "Windows Vista" OrElse str3 = "Windows 7" OrElse str3 = "Windows 10") Then
                    Return "C:\ProgramData\Autodesk\Inventor Addins\"
                End If
                Exit Select
            Case RegFreeModeEnum.kUserOverride
                Dim str4 As String = osVersion
                Dim str5 As String = str4
                If (str4 Is Nothing) Then
                    Exit Select
                End If
                If (str5 = "Windows XP") Then
                    Dim strArrays() As String = {"C:\Documents and Settings\", userName, "\Application Data\Autodesk\", version, "\Addins\"}
                    Return String.Concat(strArrays)
                End If
                If (str5 = "Windows Vista" OrElse str5 = "Windows 7") Then
                    Dim strArrays1() As String = {"C:\Users\", userName, "\AppData\Roaming\Autodesk\", version, "\Addins\"}
                    Return String.Concat(strArrays1)
                End If
                Exit Select
        End Select
        Throw New InstallException()
    End Function

    Public Shared Sub InstallRegistry(ByVal stateSaver As IDictionary, ByVal asm As Assembly)
        If (CommonUtils.Is64BitOperatingSystem()) Then
            InstallUtils.RegAsm64("/codebase", asm)
            Return
        End If
        Dim flag As Boolean = (New RegistrationServices()).RegisterAssembly(asm, AssemblyRegistrationFlags.SetCodeBase)
    End Sub

    Public Shared Function InstallRegistryFree(ByVal stateSaver As IDictionary, ByVal mode As RegFreeModeEnum, ByVal version As String) As String
        Return InstallUtils.InstallRegistryFree(stateSaver, Assembly.GetExecutingAssembly(), mode, version)
    End Function

    Public Shared Function InstallRegistryFree(ByVal stateSaver As IDictionary, ByVal Asm As Assembly, ByVal mode As RegFreeModeEnum, ByVal version As String) As String
        Dim str As String
        Try
            Dim fileInfo As System.IO.FileInfo = New System.IO.FileInfo(Asm.Location)
            Dim fileInfo1 As System.IO.FileInfo = Nothing
            Dim files As System.IO.FileInfo() = fileInfo.Directory.GetFiles()
            Dim num As Integer = 0
            While num < CInt(files.Length)
                Dim fileInfo2 As System.IO.FileInfo = files(num)
                If (fileInfo2.Extension.ToLower() <> ".addin") Then
                    num = num + 1
                Else
                    fileInfo1 = fileInfo2
                    Exit While
                End If
            End While
            If (fileInfo1 Is Nothing) Then
                Throw New InstallException()
            End If
            Dim xmlDocument As System.Xml.XmlDocument = New System.Xml.XmlDocument()
            xmlDocument.Load(fileInfo1.FullName)
            Dim itemOf As XmlNode = xmlDocument.GetElementsByTagName("Assembly")(0)
            If (itemOf Is Nothing) Then
                Throw New InstallException()
            End If
            Dim filename As String = System.IO.Path.GetFileName(itemOf.InnerText)
            Dim filepath As String = System.IO.Path.GetDirectoryName(fileInfo.FullName)
            itemOf.InnerText = System.IO.Path.Combine(filepath, filename)
            Dim str1 As String = InstallUtils.GenerateAddinFileLocation(mode, version)
            If (Not Directory.Exists(str1)) Then
                Directory.CreateDirectory(str1)
            End If
            str1 = String.Concat(str1, fileInfo1.Name)
            If (File.Exists(str1)) Then
                File.Delete(str1)
            End If
            xmlDocument.Save(str1)
            fileInfo1.Delete()
            str = str1
        Catch
            Throw New InstallException("Error installing .addin file!")
        End Try
        Return str
    End Function

    Public Shared Sub RegAsm64(ByVal parameters As String)
        InstallUtils.RegAsm64(parameters, Assembly.GetExecutingAssembly())
    End Sub

    Public Shared Sub RegAsm64(ByVal parameters As String, ByVal asm As Assembly)
        Dim fullPath As String = Path.GetFullPath(Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), "..\.."))
        Dim str As String = String.Concat(fullPath, "\Framework64\", RuntimeEnvironment.GetSystemVersion(), "\regasm.exe")
        If (Not File.Exists(str)) Then
            Trace.WriteLine("Failed to find RegAsm")
            Return
        End If
        Dim location As String = asm.Location
        Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.ErrorDialog = False
        process.StartInfo.UseShellExecute = False
        process.StartInfo.FileName = str
        process.StartInfo.Arguments = String.Format("""{0}"" {1}", location, parameters)
        Dim process1 As System.Diagnostics.Process = process
        Using process1
            process1.Start()
            process1.WaitForExit()
        End Using
    End Sub

    Public Shared Sub UninstallRegistry(ByVal savedState As IDictionary, ByVal asm As Assembly)
        If (CommonUtils.Is64BitOperatingSystem()) Then
            InstallUtils.RegAsm64("/u", asm)
            Return
        End If
        Dim flag As Boolean = (New RegistrationServices()).UnregisterAssembly(asm)
    End Sub

    Public Shared Sub UninstallRegistryFree(ByVal savedState As IDictionary, ByVal pathToAddinFile As String)
        If (File.Exists(pathToAddinFile)) Then
            File.Delete(pathToAddinFile)
        End If
    End Sub
End Class
