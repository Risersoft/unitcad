Imports System.Web.Mvc
Imports risersoft.shared.web
Imports risersoft.shared.web.Providers

Namespace Controllers
    Public Class ForgeController
        Inherits Controller

        ' GET: Forge
        Function Viewer() As ActionResult
            ViewData("ViewerURN") = Request.QueryString("urn")
            ViewData("AccessToken") = Request.QueryString("token")
            Return View()
        End Function
    End Class
End Namespace