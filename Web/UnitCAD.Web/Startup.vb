Imports Microsoft.Owin
Imports Owin

<Assembly: OwinStartup(GetType(UnitCAD.Startup))>

Public Partial Class Startup
	Public Sub Configuration(app As IAppBuilder)
		ConfigureAuth(app)
	End Sub
End Class
