Imports System
Imports System.Runtime.InteropServices


Public Class CommonUtils

    <DllImport("kernel32.dll", CharSet:=CharSet.None, ExactSpelling:=False)>
    Private Shared Function GetCurrentProcess() As IntPtr
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, ExactSpelling:=False)>
    Private Shared Function GetModuleHandle(ByVal moduleName As String) As IntPtr
    End Function

    Public Shared Function GetOsVersion(ByVal checkSP As Boolean) As String
        Dim oSVersion As OperatingSystem = Environment.OSVersion
        Dim str As String = "Unknown"
        If (oSVersion.Platform = PlatformID.Win32Windows) Then
            Dim minor As Integer = oSVersion.Version.Minor
            If (minor = 0) Then
                str = "95"
            ElseIf (minor = 10) Then
                str = If(oSVersion.Version.Revision.ToString() <> "2222A", "98", "98SE")
            ElseIf (minor = 90) Then
                str = "Me"
            End If
        ElseIf (oSVersion.Platform = PlatformID.Win32NT) Then
            Select Case oSVersion.Version.Major
                Case 3
                    str = "NT 3.51"
                    Exit Select
                Case 4
                    str = "NT 4.0"
                    Exit Select
                Case 5
                    If (oSVersion.Version.Minor <> 0) Then
                        str = "XP"
                        Exit Select
                    Else
                        str = "2000"
                        Exit Select
                    End If
                Case 6
                    If (oSVersion.Version.Minor <> 0) Then
                        str = "7"
                        Exit Select
                    Else
                        str = "Vista"
                        Exit Select
                    End If
            End Select
        End If
        If (str <> "") Then
            str = String.Concat("Windows ", str)
            If (oSVersion.ServicePack <> "" AndAlso checkSP) Then
                str = String.Concat(str, " ", oSVersion.ServicePack)
            End If
        End If
        Return str
    End Function

    <DllImport("kernel32", CharSet:=CharSet.Auto, ExactSpelling:=False, SetLastError:=True)>
    Private Shared Function GetProcAddress(ByVal hModule As IntPtr, ByVal procName As String) As IntPtr
    End Function

    Public Shared Function Is64BitOperatingSystem() As Boolean
        Dim flag As Boolean
        If (IntPtr.Size = 8) Then
            Return True
        End If
        If (CommonUtils.Win32MethodExist("kernel32.dll", "IsWow64Process") AndAlso CommonUtils.IsWow64Process(CommonUtils.GetCurrentProcess(), flag)) Then
            Return flag
        End If
        Return False
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, ExactSpelling:=False, SetLastError:=True)>
    Private Shared Function IsWow64Process(ByVal hProcess As IntPtr, <Out> ByRef wow64Process As Boolean) As Boolean
    End Function

    Private Shared Function Win32MethodExist(ByVal moduleName As String, ByVal methodName As String) As Boolean
        Dim moduleHandle As IntPtr = CommonUtils.GetModuleHandle(moduleName)
        If (moduleHandle = IntPtr.Zero) Then
            Return False
        End If
        Return CommonUtils.GetProcAddress(moduleHandle, methodName) <> IntPtr.Zero
    End Function
End Class
Public Enum RegFreeModeEnum
    kVersionDep
    kVersionIndep
    kUserOverride
End Enum
Public Enum InstallModeEnum
    kRegistryFree
    kRegistry
    kBoth
End Enum