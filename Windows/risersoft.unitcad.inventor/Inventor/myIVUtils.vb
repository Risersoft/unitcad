Imports risersoft.shared.win
Imports Inventor
Imports risersoft.app.shared
Imports risersoft.app2.shared
Imports System.Collections.Generic
Imports System.Reflection
Imports risersoft.shared.DotnetFx

Public Class myIVUtils
    Public Shared fMain As frmMain, addInCls As String, Shower As clsShower
    Delegate Sub SetTextCallback(ByVal ed As Infragistics.Win.UltraWinEditors.UltraTextEditor, ByVal txt As String)

    Protected Friend Shared Sub InstallObjects(app As Application, server As InventorServerObject)
        myDWG.AppTriedIv = True
        myIAM.mApp = app
        myIAM.mServer = server
        myDWG.InProcInv = True
        'myTFCD.oCADHost = New clsCADHostInv
        'myDWG.fView = New frmDWGSnap
        If Shower Is Nothing Then Shower = New clsShower(app)
        WinFormUtils.Shower = Shower
    End Sub
    Public Shared Sub InitApp(app As Application, server As InventorServerObject)

        myEApps.HandleAssemblyResolve()
        myApp = New clsRSWinCloudApp(New clsUCAD3DExtendApp)
        myIVUtils.InstallObjects(app, server) 'shower is required because checklicense shows forms depending on whether shower is installed or not
        If myWinApp.dicUserSettings.ContainsKey("selfhost") Then ProviderFactory.CreateProviderHost(myWinApp)

    End Sub
    Public Shared Sub LaunchApp(app As Inventor.Application, server As InventorServerObject, addinCLS As String)
        If myIVUtils.fMain Is Nothing Then
            myIVUtils.addInCls = addinCLS
            myIVUtils.InitApp(app, server)
            Dim oRet As clsProcOutput = myWinApp.Init(Nothing).GetAwaiter.GetResult
            If oRet.Success Then
                If myIVUtils.fMain Is Nothing Then
                    'Init
                    'fMain is created after objects have been initialized
                    myIVUtils.fMain = New frmMain
                    myIVUtils.fMain.myView.EnsureStyle("Windows7", "")
                    myIVUtils.fMain.MakeDownLevel()
                End If
                Shower.InstallPalette("UnitCAD-Main", myWinApp.Vars("appname"), myIVUtils.fMain, EnumDockingState.Left)
                Shower.ActivatePalette("UnitCAD-Main")
            Else
                MsgBox("Error in Initialization. Try UnitCAD-Options" & vbLf & oRet.Message)
            End If

        Else
            Shower.ActivatePalette("UnitCAD-Main")
        End If



    End Sub

End Class
