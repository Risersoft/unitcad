﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        ' Web API configuration and services

        ' Web API routes
        config.MapHttpAttributeRoutes()

        config.Routes.MapHttpRoute(
         name:="ValuesApi",
    routeTemplate:="api/Values/{id}",
    defaults:=New With {.controller = "Values", .id = RouteParameter.Optional}
     )

        config.Routes.MapHttpRoute(
         name:="ActionApi",
    routeTemplate:="api/{controller}/{action}/{id}",
    defaults:=New With {.id = RouteParameter.Optional}
     )
    End Sub
End Module