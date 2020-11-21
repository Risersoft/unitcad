Imports System.Security.Claims
Imports System.Web.Helpers
Imports System.Web.Hosting
Imports System.Web.Http
Imports System.Web.Optimization
Imports risersoft.shared.web

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        myWebApp = New clsMvcWebApp(New clsExtendWebAppUC)
        HostingEnvironment.RegisterVirtualPathProvider(New EmbeddedVirtualPathProvider())
        AreaRegistration.RegisterAllAreas()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
        AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier
    End Sub
End Class
