Imports risersoft.shared
Imports System.Reflection
Imports risersoft.app.shared
Imports risersoft.app.mxent
Imports risersoft.shared.dal
Imports risersoft.app.mxform
Imports risersoft.app.mxform.eto
Imports risersoft.shared.cloud
Imports risersoft.app.reports
Imports risersoft.app2.shared

Public Class clsUCAD3DExtendApp
    Inherits clsUCAD3dExtendAppCrx

    Dim FileProvider As ICloudFileProvider

    Public Overrides Function GetLicProductInfo() As LicProductInfo
        Return New LicProductInfo("ucad.3d", 2.0, "etobench.pro")
    End Function

    Public Overrides Sub UpdateSettings(s As myAppSettings)
        MyBase.UpdateSettings(s)
        s.CommonMenuResourceName = "gen.Addin.xml"
        s.RelateLoginPerson = True
    End Sub

    Public Overrides Function ExportTable(ds As System.Data.DataSet) As String
        Dim oExim As New clsEXIM(myWinApp)
        Return oExim.ExportTable(ds)
    End Function

    Public Overrides Function StartupAppCode() As String
        Return "ucad.3d"
    End Function

    Public Overrides Function AboutBox() As [shared].IForm
        Return New frmAboutBox
    End Function


    Public Overrides Function FileServerRequired() As Boolean
        Return True
    End Function

    Public Overrides Function MinDBVersion() As Decimal
        Return My.Settings.MinDBVersion
    End Function



    Public Overrides Function dicFormModelTypes() As clsCollecString(Of Type)
        If dicFormModel Is Nothing Then
            dicFormModel = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicFormModel, GetType(frmGenPersonModel).Assembly, GetType(clsFormDataModel))
            Me.AddTypeAssembly(dicFormModel, GetType(frmTFCompDefModel).Assembly, GetType(clsFormDataModel))
        End If
        Return dicFormModel
    End Function


    Public Overrides Function dicReportProviderTypes(myContext As clsAppController) As clsCollecString(Of Type)
        If dicReportModelProvider Is Nothing Then
            dicReportModelProvider = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicReportModelProvider, GetType(vcktReportDataProvider).Assembly, GetType(clsReportDataProviderBase))
        End If
        Return dicReportModelProvider
    End Function

    Public Overrides Function dicTaskProviderTypes() As clsCollecString(Of Type)
        Throw New NotImplementedException()
    End Function
    Public Overrides Function fViewer3D() As IViewer
        If Not myDWG.InProcInv Then
            Try
                Return New frmIVCHost
            Catch ex As Exception
                'Inventor apprentice control may not be installed / available.
                'Ref Rustam system
            End Try
        End If
        Return Nothing
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
                If FileProvider Is Nothing Then FileProvider = ProviderFactory.CreateFileProvider(context)
                provider = New clsBlobFileClient(context, AppCode, FileProvider)
            Case Else
                provider = MyBase.FileProviderClient(context, AppCode, ProviderCode)
        End Select
        Return provider
    End Function

End Class
