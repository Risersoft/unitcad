Imports Autodesk.AutoCAD.Runtime
Imports System.Reflection
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports System.IO
Imports System.Security

Public Class MyEntryPoint
    Implements IExtensionApplication

    Dim pc As clsPropertyClass
    Public Sub Initialize() Implements IExtensionApplication.Initialize
        Dim ed As Editor = Application.DocumentManager.MdiActiveDocument.Editor

        Try
            ed.WriteMessage("Loading property management dll")
            pc = New clsPropertyClass
            pc.DoInitialize()
        Catch ex1 As FileNotFoundException
            ed.WriteMessage("Error while loading propertyextension: " & ex1.Message)
        Catch ex2 As FileLoadException
            ' A file that was found could not be loaded. 
            ed.WriteMessage("Error while loading propertyextension: " & ex2.Message)
        Catch ex3 As BadImageFormatException
            'assemblyFile is not a valid assembly. 
            '-or-
            'Version 2.0 or later of the common language runtime is currently loaded and assemblyFile was compiled with a later version. 
            ed.WriteMessage("Error while loading propertyextension: " & ex3.Message)
        Catch ex4 As SecurityException
            'A codebase that does not start with "file://" was specified without the required WebPermission. 
            ed.WriteMessage("Error while loading propertyextension: " & ex4.Message)
        Catch ex5 As ArgumentException
            'The assemblyFile parameter is an empty string (""). 
            ed.WriteMessage("Error while loading propertyextension: " & ex5.Message)
        Catch ex6 As PathTooLongException
            'The assembly name is longer than MAX_PATH characters
            ed.WriteMessage("Error while loading propertyextension: " & ex6.Message)
        Catch ex As Exception
            ed.WriteMessage("Error while loading propertyextension: " & ex.Message)
        End Try

    End Sub

    Public Sub Terminate() Implements IExtensionApplication.Terminate
        If Not pc Is Nothing Then pc.DoTerminate()
    End Sub
End Class
