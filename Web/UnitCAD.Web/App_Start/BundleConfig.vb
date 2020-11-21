Imports System.Web.Optimization

Public Module BundleConfig
    ' For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Use the development version of Modernizr to develop with and learn from. Then, when you're
        ' ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js",
                  "~/Scripts/respond.js"))

        bundles.Add(New ScriptBundle("~/bundles/ig").Include(
                  "~/Scripts/infragistics.core.js",
                  "~/Scripts/infragistics.lob.js",
                  "~/Scripts/infragistics.dv.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/site.css",
              "~/Content/rsweb.css"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryui").Include(
            "~/Scripts/jquery-ui-{version}.js", "~/Scripts/jquery.ui-contextmenu.js"))

        bundles.Add(New StyleBundle("~/Content/themes/base/css").Include(
            "~/Scripts/jquery-ui/jquery-ui.css",
              "~/Content/themes/base/jquery.ui.core.css",
              "~/Content/themes/base/jquery.ui.resizable.css",
              "~/Content/themes/base/jquery.ui.selectable.css",
              "~/Content/themes/base/jquery.ui.accordion.css",
              "~/Content/themes/base/jquery.ui.autocomplete.css",
              "~/Content/themes/base/jquery.ui.button.css",
              "~/Content/themes/base/jquery.ui.dialog.css",
              "~/Content/themes/base/jquery.ui.slider.css",
              "~/Content/themes/base/jquery.ui.tabs.css",
              "~/Content/themes/base/jquery.ui.datepicker.css",
              "~/Content/themes/base/jquery.ui.progressbar.css",
              "~/Content/themes/base/jquery.ui.theme.css"))

        bundles.Add(New StyleBundle("~/Content/themes/ig/css").Include(
             "~/Content/themes/infragistics/infragistics.theme.css",
             "~/Content/themes/infragistics/infragistics.structure.css"))

        bundles.Add(New ScriptBundle("~/bundles/angular").Include(
          "~/Scripts/angular.js",
          "~/Scripts/angular-sanitize.js",
            "~/Scripts/rsang.js",
          "~/Scripts/angular-datepicker.js"))
    End Sub
End Module

