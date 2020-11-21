﻿Imports risersoft.shared.web
Imports risersoft.shared.web.common
Imports risersoft.shared.portable.Models.Auth

Public Class HomeController
    Inherits clsMvcControllerBase

    Function Index() As ActionResult
        Return View()
    End Function
    Function Parent() As ActionResult
        Return Me.Redirect("http://www.risersoft.com")
    End Function
    Function Explore() As ActionResult
        Return Me.Redirect("http://www.risersoft.com/formulacad")
    End Function

    Function BuyApp() As ActionResult
        Dim portal As String = Me.Host.Portal.ToRootString
        Return Me.Redirect(portal & "/account/create?license=buy&product=formulacad")
    End Function

    Function TryApp() As ActionResult
        Dim portal As String = Me.Host.Portal.ToRootString
        Return Me.Redirect(portal & "/account/create?license=try&product=formulacad")
    End Function
End Class
