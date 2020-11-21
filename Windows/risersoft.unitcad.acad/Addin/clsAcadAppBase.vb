Imports Autodesk.AutoCAD.ApplicationServices

Public Class clsAcadAppBase
    Inherits clsAppUCadCrx
    Implements IShow
    Public fMain As frmMax

    Protected Friend Sub InstallActivatePalette(Title As String)
        If (myAcUtilsWin.ps4 Is Nothing) Then
            myAcUtilsWin.ps4 = New Autodesk.AutoCAD.Windows.PaletteSet(myWinApp.Vars("appname"))
            myAcUtilsWin.ps4.MinimumSize = New System.Drawing.Size(320, 500)
            myAcUtilsWin.ps4.Size = myAcUtilsWin.ps4.MinimumSize
        End If


        If myAcUtilsWin.pMain Is Nothing Then
            myAcUtilsWin.pMain = myAcUtilsWin.ps4.Add(Title, fMain)
            myAcUtilsWin.MainIndex = myAcUtilsWin.ps4.Count - 1
        End If


        myAcUtilsWin.ps4.Activate(myAcUtilsWin.MainIndex)
        myAcUtilsWin.ps4.Visible = True
        myAcUtilsWin.ps4.Dock = Autodesk.AutoCAD.Windows.DockSides.Left


    End Sub
    Public Sub ShowModeless(ByVal f As IForm, ByVal pFrm As IForm) Implements IShow.ShowModeless
        AddHandler Application.BeginQuit, AddressOf f.OnBeginQuit

        If pFrm Is Nothing Then Application.ShowModelessDialog(f) Else Application.ShowModelessDialog(pFrm, f)
    End Sub

End Class
