﻿@imports risersoft.shared.web.Extensions
@imports risersoft.shared.web
@imports risersoft.shared.portable
@imports risersoft.shared.cloud.common
@imports risersoft.shared.cloud
@imports risersoft.shared.agent

@Code
    Dim _user As RSUser = Nothing
    If (Not Me.User Is Nothing) AndAlso (Not Me.User.Identity Is Nothing) Then
        _user = OwinHelper.GetRSUser(Me.User.Identity)

    End If
    Dim portal As String = risersoft.shared.GlobalCore.GetConfigSetting("portal")
    Dim ctx = CType(ViewContext.Controller, IHostedController).myWebController
End Code
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewData("Title")</title>
    @Scripts.Render("~/bundles/modernizr")
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/jqueryui")
    @Scripts.Render("~/bundles/bootstrap")
    <link href="~/Scripts/jquery-ui/jquery-ui.css" rel="stylesheet" />
    @RenderSection("scripts", required:=False)
    @Styles.Render("~/Content/css")
    <link href="~/Content/font-awesome.css" rel="stylesheet" />
    @Scripts.Render("~/bundles/angular")
    @Scripts.Render("~/bundles/ig")
    @Scripts.Render("~/scripts/rsweb.js")
    @*@Styles.Render("~/Content/themes/base/css")*@
    @Styles.Render("~/Content/themes/ig/css")
    <script src="/scripts/handlebars-v4.0.12.js"></script>

    @Html.RenderScripts(True, True)


    <style>
        div.spinnerTarget.backdrop {
            width: 100%;
            min-height: 1500px;
            position: absolute;
            background-color: lightgrey;
            opacity: 0.8;
            z-index: 99999999999999999999999;
        }
    </style>
</head>
<body ng-app="rsApp">
    <div class="spinnerTarget" us-spinner="{top:'70%', radius:30, width:8, length: 16}" spinner-key="spinner-1" spinner-theme="smallBlue"></div>
    @*<div class="top-line">&nbsp;</div>*@
    @If Not _user Is Nothing Then
        @<div Class="top-header-navigation" style="height: 38px;">
            <div class="container">
                @*<div class="btn-group margin-rgt10"><a href="/index" class="link-underline"><h2 class="uni-logo" style="margin-top: 0px;"><img src="~/Content/images/formulacad.png" class="ninja-logo" />ProjectsNirvana</h2></a></div>*@
                <div class="btn-group margin-rgt10 navbar navbar-expand-md" style="float:right;margin-right: 22px;margin-top: 5px;">
                    <a class="fa fa-user active" data-toggle="dropdown" style="text-decoration:none" href="#" aria-expanded="false">
                        <span class="caret"></span>
                    </a>
                    <ul class="dropdown-menu dropdown-men" style="left:-115px;">
                        <li> <a class="dropdown-item" href="/account/change">Manage</a></li>
                        <li> <a class="dropdown-item" href="/account/Logout">Logout</a></li>
                    </ul>
                </div>

                <div class="btn-group margin-rgt10 navbar navbar-expand-md" style="float:right;margin-right: 22px;">
                    <a class="" style="text-decoration:none" href="#" aria-expanded="false">
                        Welcome @_user.FullName
                    </a>
                </div>
            </div>

        </div>
    Else
        @<ul Class="header-item">
            <li>
                <a href="/Account/Login">Login</a>
            </li>
            <li>
                <a href="/User/signup">Signup</a>
            </li>
        </ul>
    End If





    <div style="background:#ffffff">
        <div class="container">
            <div Class="row">
                <div Class="col-md-3" style="margin-top: 0px;">
                    <div class="logo-header">
                        <div class="pull-left mobo-widthtab"><a href="/index" class="link-underline"><h5 class="uni-logo" style="margin-top: 0px;"><img src="~/Content/images/formulacad.png" class="ninja-logo" />FormulaCAD</h5></a></div>

                    </div>
                </div>
                <div Class="col-md-8" style="margin-top: 22px;">
                    <div class="pull-right tagline mobo-widthtab" style="float:right">
                        <h2>CAD and BOM Automation</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>







    @Html.Menu(ctx)
    <div class="rowdis navbar-light">
        <button type="button" class="btn btn-primary" id="dismenu">
            <span class="navbar-toggler-icon"></span>


        </button>
    </div>
    <div class="menu">
        <div class="rowdel"><a href="#" style="font-size: 25px;text-decoration: none!important;" id="removeMenu" class="imgcn"><img src="~/Content/images/icon_exportimg.png" /></a></div>

    </div>
    <div class="clsmargn">
        @RenderBody()

        <div id="dialogFilter" title="Filter">
        </div>
        <footer class="fcls">
            <p>&copy; @DateTime.Now.Year - @ctx.Controller.CalcPublisher</p>
        </footer>
    </div>
    <ul id="id_context2" style="display: none;">
        <li data-command="action1">Fetching Data ...</li>
    </ul>
    @RenderSection("BotScripts", required:=False)

    <script type="text/javascript">
        $(document).ready(function () {
            $('.rowdis').addClass('rowdp');
            $('.navbar-nav').removeClass('nav');
            $(window).bind('scroll', function () {
                if ($(window).scrollTop() > 31) {

                    $('.navbar-fixed-top').addClass('navbar-fixed-top-change');
                    $('.top-line-move').addClass('fixed');
                }
                else {

                    $('.navbar-fixed-top').removeClass('navbar-fixed-top-change');
                    $('.top-line-move').removeClass('fixed');
                }
            });
            $(window).bind('scroll', function () {
                if ($(window).scrollTop() > 50) {

                    $('.navbar-fixed-top').addClass('navbar-fixed-top-change');
                    $('.top-line-move').addClass('fixed');
                }
                else {

                    $('.navbar-fixed-top').removeClass('navbar-fixed-top-change');
                    $('.top-line-move').removeClass('fixed');
                }
            });


            $("#dismenu").on('click', function () {
                dismenudata();
            });
            function dismenudata() {

                $('#PayloadContainer').addClass('PayloadContainern');
                $('.treegrid').addClass('treegridn');
                $('.menu').addClass('mendis');
                $('.rowdel').addClass('treegridn');
                $('.rowdis').addClass('rowdp');
                $('.navbar-collapse').addClass('show');
                $('#PayloadContainer').addClass('showdata');
            };






            $('#removeMenu').on('click', function () {
                $('.menu').removeClass('mendis');
                $('.clsmargn').removeClass('maindis');
                $('.rowdis').removeClass('rowdp');
                $('.rowdel').removeClass('treegridn');
                $('#PayloadContainer').removeClass('PayloadContainern');
                $('.treegrid').removeClass('treegridn');
            });
        });
        function tablehtml(table) {

            var thtml = "<tr>";
            for (var k in table[0]) {
                thtml += "<th>" + k + "</th>";
            }
            thtml += "</tr>";
            $.each(table, function (index, value) {
                var TableRow = "<tr>";
                $.each(value, function (key, val) {
                    TableRow += "<td>" + val + "</td>";
                });
                TableRow += "</tr>";
                thtml += TableRow;;
            });
            return thtml;
        }

    </script>
</body>
</html>
