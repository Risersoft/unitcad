Imports System

Imports Inventor
Imports Autodesk.ADN.InvUtility.CommandUtils
Imports Autodesk.ADN.InvUtility.WinUtils

'///////////////////////////////////////////////////////////////////////////////////
'// ButtonCmdDemo Inventor Add-in Command
'//  
'// Author: Phil
'// Creation date: 10/29/2012 4:05:09 PM
'// 
'///////////////////////////////////////////////////////////////////////////////////

<AdnCommandAttribute()>
Public Class UCEntityMarkerCmd
    Inherits AdnButtonCommandBase

    Private _userInputEvents As UserInputEvents

    Public Sub New(ByVal addInSite As ApplicationAddInSite)
        MyBase.New(addInSite.Application)

        _userInputEvents = Application.CommandManager.UserInputEvents

        Me.AddInSite = addInSite

        AddHandler _userInputEvents.OnLinearMarkingMenu,
            AddressOf Me.OnLinearMarkingMenu

        AddHandler _userInputEvents.OnRadialMarkingMenu,
            AddressOf Me.OnRadialMarkingMenu

    End Sub

    Property AddInSite As ApplicationAddInSite

    Public Overrides ReadOnly Property DisplayName() As String
        Get
            Return "Entity" & vbCrLf & "Marker"
        End Get
    End Property

    Public Overrides ReadOnly Property InternalName() As String
        Get
            Return "risersoft.unitcad.iv.UCEntityMarkerCmd"
        End Get
    End Property

    Public Overrides ReadOnly Property Classification() As CommandTypesEnum
        Get
            Return CommandTypesEnum.kEditMaskCmdType
        End Get
    End Property

    Public Overrides ReadOnly Property ClientId() As String
        Get
            Dim t As Type = GetType(StandardAddInServer)
            Return t.GUID.ToString("B")
        End Get
    End Property

    Public Overrides ReadOnly Property Description() As String
        Get
            Return "Entity Marker"
        End Get
    End Property

    Public Overrides ReadOnly Property ToolTipText() As String
        Get
            Return "Select and Name Entities"
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonDisplay() As ButtonDisplayEnum
        Get
            Return ButtonDisplayEnum.kDisplayTextInLearningMode
        End Get
    End Property


    Public Overrides ReadOnly Property StandardIconName() As String
        Get
            Return "risersoft.unitcad.iv.AU_16x16.ico"
        End Get
    End Property

    Public Overrides ReadOnly Property LargeIconName() As String
        Get
            Return "risersoft.unitcad.iv.AU_32x32.ico"
        End Get
    End Property



    Protected Overrides Sub OnExecute(ByVal context As NameValueMap)
        If myIVUtils.fMain IsNot Nothing Then
            Dim f As frmEntityMarker = New frmEntityMarker(Me)
            f.Show(New WindowWrapper(Application.MainFrameHWND))
        End If

        Terminate()

    End Sub

    Protected Overrides Sub OnHelp(ByVal context As NameValueMap)

    End Sub

    Protected Overrides Sub OnLinearMarkingMenu(
        ByVal SelectedEntities As ObjectsEnumerator,
        ByVal SelectionDevice As SelectionDeviceEnum,
        ByVal LinearMenu As CommandControls,
        ByVal AdditionalInfo As NameValueMap)

        ' Add this button to linear context menu
        'LinearMenu.AddButton(ControlDefinition, true, true, "", false)

    End Sub

    Protected Overrides Sub OnRadialMarkingMenu(
        ByVal SelectedEntities As ObjectsEnumerator,
        ByVal SelectionDevice As SelectionDeviceEnum,
        ByVal RadialMenu As RadialMarkingMenu,
        ByVal AdditionalInfo As NameValueMap)

        ' Add this button to radial context menu
        'RadialMenu.NorthControl = ControlDefinition

    End Sub

End Class


