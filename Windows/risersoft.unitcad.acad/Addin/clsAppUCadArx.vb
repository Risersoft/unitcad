Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.Windows
Imports Autodesk.AutoCAD.Geometry
Imports risersoft.shared.win
Imports risersoft.app.shared
Imports risersoft.app2.shared
Imports System.Reflection
Imports risersoft.shared.DotnetFx


<Assembly: CommandClass(GetType(risersoft.unitcad.acad.clsAppUCadArx))>
Public Class clsAppUCadArx
    Inherits clsAcadAppBase

    <CommandMethod("UnitCAD-Options")>
    Public Sub UCADOptions()
        Dim ed As Editor = Application.DocumentManager.MdiActiveDocument.Editor
        If myWinApp() Is Nothing Then
            ed.WriteMessage("Run UnitCAD First")
        Else
            Dim f As New frmOptions
            If fMain Is Nothing Then
                f.PrepForm(Nothing, EnumfrmMode.acAddM, "")
            Else
                f.PrepForm(fMain.myView, EnumfrmMode.acAddM, "")
            End If
            Me.ShowModeless(f, Nothing)
        End If
    End Sub

    <CommandMethod("UnitCAD")>
    Public Overrides Sub CreateUCAD()

        myEApps.HandleAssemblyResolve()
        myApp = New clsRSWinCloudApp(New clsUCADExtendAppArx)
        If myWinApp.dicUserSettings.ContainsKey("selfhost") Then ProviderFactory.CreateProviderHost(myWinApp)
        WinFormUtils.Shower = Me
        'shower is required because:
        'checklicense shows forms depending on whether shower Is installed Or Not. 
        'if entry assembly is null, it is taken from shower
        Dim oRet As clsProcOutput = myWinApp.Init(Nothing).GetAwaiter.GetResult
        If oRet.Success Then
            If fMain Is Nothing Then
                'Init
                'fMain is created after objects have been initialized
                fMain = New frmMain
                fMain.MakeDownLevel()
                fMain.myView.ApplyStyle("Windows7")

            End If
            Me.InstallActivatePalette("UnitCAD")
        Else
            Dim ed As Editor = Application.DocumentManager.MdiActiveDocument.Editor
            ed.WriteMessage("Error in Initialization. Try UnitCAD-Options" & vbLf & oRet.Message)
        End If
    End Sub

End Class
