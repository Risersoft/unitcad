Imports risersoft.shared
Imports Autodesk.AutoCAD.Interop
Imports System.Reflection
Imports risersoft.app.shared
Imports Autodesk.AutoCAD.ApplicationServices
Imports risersoft.app.mxform
Imports risersoft.app.mxform.eto
Imports risersoft.app.shared.mxengg
Imports risersoft.app2.shared
Imports risersoft.shared.cloud
Imports risersoft.app.mxform.ucad

Public Class clsUCADExtendAppArx
    Inherits clsUCADExtendAppCrx
    Public Overrides Function GetLicProductInfo() As LicProductInfo
        Return New LicProductInfo("ucad.2d", 2.0, "etobench.pro")
    End Function
    Public Overrides Function ExportTable(ds As System.Data.DataSet) As String
        Dim oExim As New clsEXIM(myWinApp)
        Return oExim.ExportTable(ds)
    End Function
    Public Overrides Sub UpdateSettings(s As myAppSettings)
        MyBase.UpdateSettings(s)
        s.CommonMenuResourceName = "gen.Addin.xml"
        s.RelateLoginPerson = True
    End Sub


    Public Overrides Function StartupAppCode() As String
        Return "ucad.2d"
    End Function

    Public Overrides Function AboutBox() As [shared].IForm
        Return New frmAboutBox
    End Function



    Public Overrides Function FileServerRequired() As Boolean
        Return True
    End Function


    Public Overrides Function fViewer2D() As IViewer
        Return New frmDWGSnap
    End Function

    Public Overrides Function OnAppInit(oApp As clsCoreApp) As Boolean
        MyBase.OnAppInit(oApp)
        myDWG.mApp = Application.AcadApplication
        'myTFCD.oCADHost = New clsCADHostBase

        Return True
    End Function
    Public Overrides Function dicFormModelTypes() As clsCollecString(Of Type)
        If dicFormModel Is Nothing Then
            dicFormModel = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicFormModel, GetType(frmGenPersonModel).Assembly, GetType(clsFormDataModel))
            Me.AddTypeAssembly(dicFormModel, GetType(frmTFCompDefModel).Assembly, GetType(clsFormDataModel))
        End If
        Return dicFormModel
    End Function
    Public Overrides Function FileServerPath() As String
        Return myPathUtils.FileServerPath
    End Function
    Public Overrides Function CreateDataProvider(context As clsAppController, cb As IAsyncWCFCallBack) As IAppDataProvider
        Dim Provider As IAppDataProvider = ProviderFactory.CreateDataProvider(context, cb)
        Return Provider

    End Function
    Public Overrides Function FileProviderClient(context As IProviderContext, AppCode As String, ProviderCode As String) As clsFileProviderClientBase
        Dim provider As clsFileProviderClientBase
        Select Case ProviderCode.Trim.ToLower
            Case "blob"
                Dim FileProvider = ProviderFactory.CreateFileProvider(context)
                provider = New clsBlobFileClient(context, AppCode, FileProvider)
            Case Else
                provider = MyBase.FileProviderClient(context, AppCode, ProviderCode)
        End Select
        Return provider
    End Function
End Class
