Imports System

Imports Inventor
Imports Autodesk.ADN.InvUtility.CommandUtils
Imports Autodesk.ADN.InvUtility.WinUtils
Imports System.Drawing

'///////////////////////////////////////////////////////////////////////////////////
'// ButtonCmdDemo Inventor Add-in Command
'//  
'// Author: Phil
'// Creation date: 10/29/2012 4:05:09 PM
'// 
'///////////////////////////////////////////////////////////////////////////////////

<AdnCommandAttribute()>
Public Class UCGettingStartedCmd
    Inherits AdnButtonCommandBase

    Private _userInputEvents As UserInputEvents
    Dim str1 As String, dic As clsCollection(Of String, Image)
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
            Return "Getting" & vbCrLf & "Started"
        End Get
    End Property

    Public Overrides ReadOnly Property InternalName() As String
        Get
            Return "risersoft.unitcad.iv.UCGettingStartedCmd"
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
            Return "Getting Started"
        End Get
    End Property

    Public Overrides ReadOnly Property ToolTipText() As String
        Get
            Return "Getting Started Videos"
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonDisplay() As ButtonDisplayEnum
        Get
            Return ButtonDisplayEnum.kDisplayTextInLearningMode
        End Get
    End Property


    Public Overrides ReadOnly Property StandardIconName() As String
        Get
            Return "risersoft.unitcad.iv.gettingstarted.ico"
        End Get
    End Property

    Public Overrides ReadOnly Property LargeIconName() As String
        Get
            Return "risersoft.unitcad.iv.gettingstarted.ico"
        End Get
    End Property



    Protected Overrides Sub OnExecute(ByVal context As NameValueMap)
        Try
            If dic Is Nothing Then
                str1 = myAssy.GetString(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "GettingStarted.htm")
                dic = New clsCollection(Of String, Image)
                Dim img As Image = myBMP.ScaleImageWidth(My.Resources.logo, 300)
                dic.Add("logo.png", img)
            End If

            'Throw New Exception("Exception Occured")


            Dim m_dialog As frmMediaPlayer = New frmMediaPlayer
            m_dialog.SetHTML(str1, dic)

            m_dialog.Show(New WindowWrapper(Me.Application.MainFrameHWND))

        Catch ex As Exception
            Dim strmsg As String
#If DEBUG Then
            strmsg = ex.Message & vbCrLf & ex.StackTrace
#Else
                strmsg="An error has occured in an attempt to show getting started videos." & vbCrLf & "Would you like to open up the videos folder?"
#End If

            If MsgBox(strmsg, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim str1 As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location), "videos")
                If System.IO.Directory.Exists(str1) Then Process.Start(str1)
            End If

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


