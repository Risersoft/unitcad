Imports risersoft.app.mxengg
Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.mxform.eto
Imports risersoft.shared
Imports risersoft.shared.cloud
Imports risersoft.shared.web
Imports risersoft.shared.web.mvc
Imports risersoft.unitcad.provider.acadio
Imports risersoft.unitcad.provider.iv

Public Class clsExtendWebAppUC
    Inherits clsExtendWebAppBase


    Public Overrides Function NewDBName() As String
        Return "mxenggdb"
    End Function


    Public Overrides Function ProgramCode() As String
        Return "mxengg"
    End Function

    Public Overrides Function ProgramName() As String
        Return "FormulaCAD"

    End Function

    Public Overrides Function StartupAppCode() As String
        Return "ucadex"
    End Function
    Public Overrides Function CADProvider3D(context As clsAppController, handler As Action(Of Object, clsProgressReport), modelmode As Integer) As ICADServer3D

        Dim oClient As New clsCADClient3D(Of clsCAD3D)(context, handler)
        Dim ucadprovider As clsInventorIOProvider = New clsInventorIOProvider(context, oClient)
        ucadprovider.Init(New clsPackageInfoIv)
        Dim provider As ICADServer3D = oClient.InitAIOProvider(ucadprovider)
        myDWG.AppTriedIv = True

        Return provider
    End Function
    Public Overrides Function CADProvider2D(context As clsAppController, handler As Action(Of Object, clsProgressReport), modelmode As Integer) As ICADServer2D

        Dim oClient As New clsCADClient2D(Of clsCAD2D)(context, handler)
        Dim ucadprovider As clsACADIOProvider = New clsACADIOProvider(context, oClient)
        ucadprovider.Init(New clsPackageInfoAc)
        Dim provider As ICADServer2D = oClient.InitAIOProvider(ucadprovider)
        myDWG.AppTriedAc = True

        Return provider
    End Function
    Public Overrides Function dicFormModelTypes() As clsCollecString(Of Type)
        If dicFormModel Is Nothing Then
            dicFormModel = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicFormModel, GetType(frmGenPersonModel).Assembly, GetType(clsFormDataModel))
            Me.AddTypeAssembly(dicFormModel, GetType(frmProDocuModel).Assembly, GetType(clsFormDataModel))
        End If
        Return dicFormModel
    End Function

    Public Overrides Function dicReportProviderTypes(myContext As clsAppController) As clsCollecString(Of Type)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function dicTaskProviderTypes() As clsCollecString(Of Type)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function AppCodesHandled() As List(Of String)
        Return New String() {Me.StartupAppCode}.ToList
    End Function

    Public Overrides Function HelpSite() As String
        Throw New NotImplementedException()
    End Function
    Public Overrides Function dicWOInfoTypes() As clsCollecString(Of Type)

        If dicWOInfo Is Nothing Then
            dicWOInfo = New clsCollecString(Of Type)
            dicWOInfo.Add(GetType(clsWOInfo).Name, GetType(clsWOInfo))
            dicWOInfo.Add(GetType(clsWOInfoUCAD).Name, GetType(clsWOInfoUCAD))
        End If
        Return dicWOInfo


    End Function
End Class
