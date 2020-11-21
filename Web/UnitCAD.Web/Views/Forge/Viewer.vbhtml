@imports Infragistics.Web.Mvc
@imports System.Data
@imports risersoft.shared
@imports risersoft.shared.web
@imports risersoft.shared.web.Extensions
@imports risersoft.app.mxform.eto
@Code
    ViewData("Title") = "Forge Viewer"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code




<div id="3dViewDiv" style="border-style: solid;position: relative; top: 0px;left: 0px; width:100%; height:360px">
</div>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    @Html.Hidden("AccessTokenFld", ViewData("AccessToken"), New Dictionary(Of String, Object) From {{"id", "AccessTokenFld"}})
    @Html.Hidden("ViewerURNFld", ViewData("ViewerURN"), New Dictionary(Of String, Object) From {{"id", "ViewerURNFld"}})
End Using


<div id="szlider">
    <div id="szliderbar" style="width:0%;height:10px;border-right: 1px solid #000000;">
    </div>
    <div id="szazalek">
    </div>
</div>


@section Scripts


    @Scripts.Render("~/bundles/jqueryui")
    @Scripts.Render("~/bundles/ig")
    @Styles.Render("~/Content/themes/base/css")
    @Styles.Render("~/Content/themes/ig/css")
  <!--JS library of viewer-->
    <!-- Viewer production -->
<link type="text/css" rel="stylesheet" href="https://developer.api.autodesk.com/derivativeservice/v2/viewers/style.min.css" />
<script src="https://developer.api.autodesk.com/derivativeservice/v2/viewers/three.min.js"></script>
<script src="https://developer.api.autodesk.com/derivativeservice/v2/viewers/viewer3D.min.js?v=v2.17"></script>


@Scripts.Render("/scripts/view-data.js")


end section