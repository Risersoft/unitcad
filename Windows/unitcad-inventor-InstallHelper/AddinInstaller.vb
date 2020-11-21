'------------------------------------------------------------
'// Copyright (c) Autodesk, Inc. All rights reserved 
'// Written by Philippe Leefsma 2011 - ADN/Developer Technical Services
'//
'// Permission to use, copy, modify, and distribute this software in
'// object code form for any purpose and without fee is hereby granted, 
'// provided that the above copyright notice appears in all copies and 
'// that both that copyright notice and the limited warranty and
'// restricted rights notice below appear in all supporting 
'// documentation.
'//
'// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS. 
'// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
'// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC. 
'// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
'// UNINTERRUPTED OR ERROR FREE.
'------------------------------------------------------------
Imports System
Imports System.IO
Imports System.Reflection
Imports System.Diagnostics
Imports System.Collections
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Configuration.Install
Imports System.Runtime.InteropServices




<RunInstaller(True)>
Public Class AddinInstaller
    Inherits Installer

#Region "Base Implementation"

    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)

        If disposing And (Not components Is Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)

    End Sub

    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub Install(ByVal stateSaver As IDictionary)

        Try

            MyBase.Install(stateSaver)

            Dim installMode As Integer = InstallModeEnum.kRegistryFree

            Dim Asm As Assembly = Assembly.GetExecutingAssembly()
            Dim asmFile As FileInfo = New FileInfo(Asm.Location)

            stateSaver.Add("InstallMode", installMode)

            Select Case (installMode)

                Case InstallModeEnum.kRegistryFree

                    stateSaver.Add("PathToAddinFile",
                            InstallUtils.InstallRegistryFree(stateSaver,
                                Asm, RegFreeModeEnum.kVersionIndep,
                                String.Empty))

                        ' Exemple version dependant
                        'stateSaver.Add("PathToAddinFile", _
                        '    InstallUtils.InstallRegistryFree(stateSaver, _
                        '                                     Asm, InstallUtils.RegFreeMode.kVersionDep, _
                        '                                     "Inventor 2012"))


                Case InstallModeEnum.kRegistry

                    InstallUtils.InstallRegistry(stateSaver, Asm)

                Case InstallModeEnum.kBoth

                    InstallUtils.InstallRegistry(stateSaver, Asm)

                    stateSaver.Add("PathToAddinFile",
                            InstallUtils.InstallRegistryFree(stateSaver,
                                Asm, RegFreeModeEnum.kVersionIndep,
                                String.Empty))

            End Select

        Catch ex As InstallException

            Throw New InstallException(ex.Message)

        Catch ex2 As Exception

            Throw New InstallException("Error installing addin: " & ex2.Message)

        End Try
    End Sub

    Public Overrides Sub Uninstall(ByVal savedState As IDictionary)

        Try

            Dim installMode As InstallModeEnum = savedState("InstallMode")

            Dim Asm As Assembly = Assembly.GetExecutingAssembly()

            Dim pathToAddinFile As String

            Select Case installMode

                Case InstallModeEnum.kRegistryFree
                    pathToAddinFile = savedState("PathToAddinFile")
                    InstallUtils.UninstallRegistryFree(savedState, pathToAddinFile)

                Case InstallModeEnum.kRegistry
                    InstallUtils.UninstallRegistry(savedState, Asm)

                Case InstallModeEnum.kBoth
                    InstallUtils.UninstallRegistry(savedState, Asm)
                    pathToAddinFile = savedState("PathToAddinFile")
                    InstallUtils.UninstallRegistryFree(savedState, pathToAddinFile)

            End Select

        Catch


        End Try

        MyBase.Uninstall(savedState)

    End Sub

End Class

