@imports risersoft.shared.cloud.common
@Code
    ViewData("Title") = "Home Page"
    Dim baseUrl As String = Request.Url.Scheme & "://" & Request.Url.Authority & Request.ApplicationPath.TrimEnd("/")
    Dim banner As String = risersoft.shared.GlobalCore.GetConfigSetting("banner")
    If String.IsNullOrEmpty(banner) Then banner = "/Content/images/unitcad-front.jpg" Else banner = baseUrl & banner

End Code






<div class="row">
    <div class="col-md-8">
        <img src="@banner" style="width:580px;" class="img-responsive banner-img">
    </div>
    <div class="col-md-3 gst-banner-text" style="margin-top:0px;">
        <h1 class="gst-banner-text-title">FormulaCAD</h1>
        <p class="lead gst-banner-text-para">FormulaCAD is framework for automating your drawings using add-ins, win & web apps and web services.</p>
        <p><a href="/app" class="btn btn-primary btn-lg">Start Now &raquo;</a></p>

        

        
    </div>
</div>
<div><br /><br /></div>


<div class="row clsimgb">
    <div class="col-md-3 footer-nav footer-text">
        <h2>AutoCAD Add-In</h2>
        <p>
            FormulaCAD installs as an add-in inside of AutoCAD and lets you author and test rules.
        </p>
    </div>
    <div class="col-md-3 footer-nav footer-text">
        <h2>Inventor Add-In</h2>
        <p>
            FormulaCAD installs as an add-in inside of Inventor and lets you author and test rules.
        </p>
    </div>
    <div class="col-md-3 footer-nav footer-text">
        <h2>Standalone Apps</h2>
        <p>Run your rules from standalone win and web apps without the need of AutoCAD or Inventor</p>
    </div>
    <div class="col-md-3 footer-text">
        <h2>Web API</h2>
        <p>Use FormulaCAD engine within your own apps</p>
    </div>
</div>
