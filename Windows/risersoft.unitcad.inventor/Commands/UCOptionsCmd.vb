Imports System

Imports Inventor
Imports Autodesk.ADN.InvUtility.CommandUtils
Imports Autodesk.ADN.InvUtility.WinUtils
Imports risersoft.app.shared.mxengg
Imports risersoft.app.shared

'///////////////////////////////////////////////////////////////////////////////////
'// ButtonCmdDemo Inventor Add-in Command
'//  
'// Author: Phil
'// Creation date: 10/29/2012 4:05:09 PM
'// 
'///////////////////////////////////////////////////////////////////////////////////

<AdnCommandAttribute()>
Public Class UCOptionsCmd
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
            Return "UnitCAD" + vbCrLf + "Options"
        End Get
    End Property

    Public Overrides ReadOnly Property InternalName() As String
        Get
            Return "risersoft.unitcad.iv.UCOptionsCmd"
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
            Return "UnitCAD Options"
        End Get
    End Property

    Public Overrides ReadOnly Property ToolTipText() As String
        Get
            Return "Displays and allows to change various configuration options for UnitCAD"
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonDisplay() As ButtonDisplayEnum
        Get
            Return ButtonDisplayEnum.kDisplayTextInLearningMode
        End Get
    End Property


    Public Overrides ReadOnly Property StandardIconName() As String
        Get
            Return "risersoft.unitcad.iv.options.ico"
        End Get
    End Property

    Public Overrides ReadOnly Property LargeIconName() As String
        Get
            Return "risersoft.unitcad.iv.options.ico"
        End Get
    End Property



    Protected Overrides Sub OnExecute(ByVal context As NameValueMap)


        Try
            myIVUtils.InitApp(Me.Application, AddInSite.InventorServer)

            Dim f As New frmOptions
            If myIVUtils.fMain Is Nothing Then
                f.PrepForm(Nothing, EnumfrmMode.acAddM, "")
            Else
                f.PrepForm(myIVUtils.fMain.myView, EnumfrmMode.acAddM, "")
            End If
            f.ShowDialog(New WindowWrapper(Application.MainFrameHWND))
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try


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


