Imports Inventor
Imports Autodesk.ADN.InvUtility.WinUtils
Imports System.Windows.Forms

Public Class clsShower
    Implements IShow
    Dim _app As Inventor.Application
    Dim myDockableWindows As New clsCollecString(Of DockableWindow)
    Dim DocumentForms As New clsCollecString(Of Form)
    Public Sub ShowModeless(ByVal f As IForm, ByVal pFrm As IForm) Implements IShow.ShowModeless
        Dim frm As frmMax = CType(f, frmMax)
        If TypeOf frm Is IDockedWindow Then
            Dim Id As String = CType(frm, IDockedWindow).Id
            If myDockableWindows.ContainsKey(Id) Then
                Me.ActivatePalette(Id)
            Else
                frm.MakeDownLevel()
                Dim Caption As String = CType(frm, IDockedWindow).Caption
                Dim State As EnumDockingState = CType(frm, IDockedWindow).DockState
                Me.InstallPalette(Id, Caption, frm, State)
            End If
        Else
            If TypeOf frm Is IDocumentForm Then
                Dim Id As String = CType(frm, IDocumentForm).Id
                If DocumentForms.ContainsKey(Id) Then
                    frm = DocumentForms(Id)
                Else
                    AddHandler frm.FormClosing, Sub(sender, e)
                                                    Dim filename As String = CType(frm, IDocumentForm).AttachedFileName
                                                    Dim doc As Inventor.Document = myIAM.GetDocument(frm.Controller, myIAM.mApp, filename, False)
                                                    If doc IsNot Nothing Then doc.Close(False)
                                                    DocumentForms.Remove(Id)
                                                End Sub
                    AddHandler _app.ApplicationEvents.OnCloseDocument, Sub(DocumentObject As _Document, FullDocumentName As String, BeforeOrAfter As EventTimingEnum, Context As NameValueMap, ByRef HandlingCode As HandlingCodeEnum)
                                                                           CType(frm, IDocumentForm).OnCloseDocument(DocumentObject, FullDocumentName)
                                                                       End Sub
                End If

            End If
            WinFormUtils.SetFormLocation(frm, pFrm)
            If pFrm Is Nothing Then
                frm.Show(New WindowWrapper(_app.MainFrameHWND))
            Else
                frm.Show(pFrm)
            End If
            frm.BringToFront()




        End If




    End Sub
    Public Sub New(app As Inventor.Application)
        _app = app
    End Sub
    Protected Friend Sub ActivatePalette(Id As String)

        If myDockableWindows.ContainsKey(Id) Then
            myDockableWindows(Id).Visible = True
            If (_app.ActiveDocument Is Nothing) AndAlso myDockableWindows.Count < 2 Then
                If _app.WindowState = WindowsSizeEnum.kMaximize Then
                    _app.WindowState = WindowsSizeEnum.kNormalWindow
                    _app.WindowState = WindowsSizeEnum.kMaximize
                Else
                    _app.WindowState = WindowsSizeEnum.kMaximize
                    _app.WindowState = WindowsSizeEnum.kNormalWindow
                End If
            End If
            For Each kvp In myDockableWindows
                If Not myUtils.IsInList(kvp.Key, "unitcad-main", Id) Then kvp.Value.Visible = False
            Next
        End If

    End Sub

    Protected Friend Sub InstallPalette(Id As String, Title As String, f As Form, dock As EnumDockingState)
        Dim myDockableWindow As DockableWindow
        If myDockableWindows.ContainsKey(Id) Then
            myDockableWindow = myDockableWindows(Id)
        Else
            Dim uiMgr As UserInterfaceManager = _app.UserInterfaceManager
            myDockableWindow = uiMgr.DockableWindows.Add(myIVUtils.addInCls, Id, Title)
            myDockableWindow.AddChild(f.Handle)
            myDockableWindows.Add(Id, myDockableWindow)
            'AddHandler f.Shown, AddressOf frmMain_Shown
            AddHandler f.FormClosing, Sub(sender, e)
                                          If e.CloseReason = CloseReason.UserClosing OrElse e.CloseReason = CloseReason.FormOwnerClosing Then
                                              myDockableWindow.Visible = False
                                              myDockableWindow.Delete()
                                              myDockableWindows.Remove(Id)
                                          End If

                                      End Sub
            If TypeOf f Is IDockedWindow Then
                AddHandler _app.ApplicationEvents.OnCloseDocument, Sub(DocumentObject As _Document, FullDocumentName As String, BeforeOrAfter As EventTimingEnum, Context As NameValueMap, ByRef HandlingCode As HandlingCodeEnum)
                                                                       CType(f, IDockedWindow).OnCloseDocument(DocumentObject, FullDocumentName)
                                                                   End Sub

            End If

        End If

            ' Default docking state
            'If Not myDockableWindow.IsCustomized Then
            '    myDockableWindow.DockingState = DockingStateEnum.kFloat
            '    myDockableWindow.Move(25, 25, myDockableWindow.Height, myDockableWindow.Width)
            'End If

            myDockableWindow.DockingState = Me.DockingState(dock)
        myDockableWindow.ShowVisibilityCheckBox = True
        myDockableWindow.ShowTitleBar = True
        Me.ActivatePalette(Id)
    End Sub
    Protected Friend Function DockingState(state As EnumDockingState) As DockingStateEnum
        Dim ivstate As DockingStateEnum = DockingStateEnum.kDockLeft
        Select Case state
            Case EnumDockingState.Bottom : ivstate = DockingStateEnum.kDockBottom
            Case EnumDockingState.Float : ivstate = DockingStateEnum.kFloat
            Case EnumDockingState.LastKnown : ivstate = DockingStateEnum.kDockLastKnown
            Case EnumDockingState.Right : ivstate = DockingStateEnum.kDockRight
            Case EnumDockingState.Top : ivstate = DockingStateEnum.kDockTop
        End Select
        Return ivstate
    End Function
    Protected Friend Sub frmMain_Shown(sender As Object, e As EventArgs)
        Debug.WriteLine("form shown")
        Dim f As Form = CType(sender, Form), t As New System.Windows.Forms.Timer
        Dim Id As String = If(TypeOf f Is IDockedWindow, CType(f, IDockedWindow).Id, "UnitCAD-Main")
        If myDockableWindows.ContainsKey(Id) Then
            Dim myDockableWindow As DockableWindow = myDockableWindows(Id)
            AddHandler t.Tick, Sub()
                                   t.Stop()
                                   myDockableWindow.ShowTitleBar = False
                                   myDockableWindow.ShowTitleBar = True
                                   Debug.WriteLine("done resize palette")
                                   RemoveHandler f.Shown, AddressOf frmMain_Shown
                               End Sub

            t.Start()
        End If
    End Sub

End Class

