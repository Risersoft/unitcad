@imports Infragistics.Web.Mvc
@imports System.Data
@imports risersoft.shared
@imports risersoft.shared.web
@imports risersoft.shared.web.Extensions
@imports risersoft.app.mxform.eto
@ModelType frmPIDUParamsUcModel
@Code
    Dim ctx = CType(ViewContext.Controller, IWebController).myWebController
    ViewData("Title") = ctx.Vars("appname") & " - CAD Maker"
    Layout = "~/Views/Shared/_FrameworkLayout.vbhtml"
    Dim pgModel = Html.PrepEdit(Model.GridViews("params"))
    'http://www.dotnet-stuff.com/tutorials/aspnet-mvc/how-to-render-different-layout-in-asp-net-mvc
End Code
<h2>CAD Maker</h2>


@(Html.Infragistics().Grid(pgModel.mainGrid.myGrid))
<br />
<input type="button" id="saveChanges" value="Save Changes" />
<br />


<div id="3dViewDiv" style="border-style: solid;position: relative; top: 0px;left: 0px; width:100%; height:360px">
</div>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    @Html.Hidden("AccessTokenFld", ViewData("AccessToken"), New Dictionary(Of String, Object) From {{"id", "AccessTokenFld"}})
    @Html.Hidden("ViewerURNFld", ViewData("ViewerURN"), New Dictionary(Of String, Object) From {{"id", "ViewerURNFld"}})

    @<p>
        <input type="submit" name="Command" value="Preview" onclick="busy()" id="btnpreview" />
         <div id="viewerlink" style="display:none">
             <a href="@ViewData("viewerlink")">Viewer</a>
         </div>
    </p>
End Using


<div id="szlider">
    <div id="szliderbar" style="width:0%;height:10px;border-right: 1px solid #000000;">
    </div>
    <div id="szazalek">
    </div>
</div>

<script type="text/javascript">
    $(function () {
        $('#saveChanges').igButton({ labelText: $('#saveChanges').val(), disabled: false });
        $('#btnpreview').igButton({ labelText: $('#btnpreview').val(), disabled: false });
        $('#saveChanges').on('igbuttonclick',
                function (e) {
                    $('#acMainGrid').igGrid('saveChanges');
                    return false;
                }
            )
    });
</script>


@*http://blog.falafel.com/three-steps-use-jquery-ui-asp-net-mvc-5/
    http://www.igniteui.com/help/iggrid-developing-asp-net-mvc-applications-with-iggrid*@


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