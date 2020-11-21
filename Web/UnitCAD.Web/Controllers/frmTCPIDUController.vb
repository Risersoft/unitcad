Imports System.IO
Imports System.Threading.Tasks
Imports System.Web.Mvc
Imports Infragistics.Web.Mvc
Imports risersoft.app.mxengg
Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.mxform.eto
Imports risersoft.app.mxform.ucad
Imports risersoft.shared
Imports risersoft.shared.cloud
Imports risersoft.shared.portable.Models.UnitCAD
Imports risersoft.shared.web
Imports risersoft.shared.web.mvc
Imports risersoft.shared.web.Providers

Namespace Controllers
    Public Class frmTCPIDUController
        Inherits clsMvcControllerBase
        Dim output As New UCTaskOutput

        ' GET: frmTCPIDU/Edit/5
        <Authorize> <HostActionFilter>
        <HttpGet>
        Public Async Function Edit(ByVal id As Integer) As Task(Of ActionResult)

            If Await Me.myWebController.CheckInitModel(Me.myWebController.AppInfo, True) Then

                'Me.myWebController.InitBarManager(True, True)
                Dim oView As New clsMvcView(EnumViewMode.acNormalM, Me.myWebController)
                Dim model As frmPIDUParamsUcModel = Await myWebController.DataProvider.LoadForm(myWebController.AppInfo, oView.Model.ViewState, "frmPIDUParamsUcModel", "", EnumfrmMode.acEditM, id)
                Return View(model)
            End If
        End Function

        ' POST: frmTCPIDU/Edit/5
        <Authorize> <HostActionFilter>
        <HttpPost>
        Async Function Edit(ByVal id As Integer, command As String) As Threading.Tasks.Task(Of ActionResult)
            Dim task1 As Task, model As frmPIDUParamsUcModel
            Dim WODomain As String = "", rootComponent As String = "", aio_filename As String = ""
            Trace.WriteLine("Begin Model Prep")
            If Await Me.myWebController.CheckInitModel(Me.myWebController.AppInfo, True) Then


                Dim oWO As clsWOInfoUCAD = myPIDU.GenerateWOInfo(Me.myWebController, id)
                Dim mdsCompDef As DataSet = myIntent.LoadComponentDefData(Me.myWebController, True)
                Dim tfCompDefID As Integer = myUtils.cValTN(oWO.rPIDU("startupdefid"))
                Dim templatefile As String = myUtils.cStrTN(oWO.rPIDU("templatefilename"))

                Dim cb As New ProgressReporter(Of clsProgressReport)(AddressOf ProgressChanged)
                Dim oDef As New clsTFCompDefBase(Me.myWebController)
                If myUtils.IsInList(oWO.rPIDU("comptype"), "asy") Then
                    'Inventor IO
                    Await oDef.PrepareTree3DAsync(New clsMultiWorker(cb), oWO, tfCompDefID, WODomain, True, False)
                    rootComponent = myIntent.FindRootComponent(oWO, WODomain)
                    Dim provider As ICADServer3D = myWebApp.objAppExtender.CADProvider3D(Me.myWebController, AddressOf ProgressChanged, 0)
                    Trace.WriteLine("End Model Prep")
                    task1 = provider.PrepareDoc3D(oWO.dsWO, mdsCompDef, WODomain, oWO.dtParamOrig)
                Else
                    'ACAD IO
                    rootComponent = ""
                    Dim provider As ICADServer2D = myWebApp.objAppExtender.CADProvider2D(Me.myWebController, AddressOf ProgressChanged, 0)
                    Trace.WriteLine("End Model Prep")
                    task1 = provider.PrepareDoc2D(templatefile, oWO.dsWO, tfCompDefID, mdsCompDef, WODomain, oWO.dtParamOrig)
                End If

                'VIEW AND DATA
                Dim client As New clsAuViewerClient(Me.myWebController)
                Dim task2 As Task(Of String) = Task.Run(Function()
                                                            Return client.Authenticate()
                                                        End Function)

                'model
                Dim task3 As Task = Task.Run(Async Function() As Task
                                                 If myUtils.IsInList(oWO.rPIDU("comptype"), "asy") Then
                                                     oDef.SaveWOBom(oWO, WODomain)
                                                     oDef.SaveWOTree(oWO, WODomain)
                                                 End If
                                                 Dim oView As New clsMvcView(EnumViewMode.acNormalM, Me.myWebController)
                                                 model = Await myWebController.DataProvider.LoadForm(myWebController.AppInfo, oView.Model.ViewState, "frmPIDUParamsUcModel", "", EnumfrmMode.acEditM, id)
                                             End Function)
                'Me.myWebController.InitBarManager(True, True)
                Dim oFiler As clsFileProviderClientBase = myWebApp.objAppExtender.FileProviderClient(Me.myWebController, "ucad", "blob")
                Dim baseDirectory As String = Path.Combine(Me.myWebController.App.objAppExtender.CommonAppDataPath, "AIO", System.Guid.NewGuid.ToString)
                oFiler.EnsureLocalDirectory(baseDirectory)

                Await Task.WhenAll(task1, task2, task3)

                Dim report As String = Await Task.Run(Function()
                                                          Dim str2 As String = oFiler.DownloadHttpString(output.ReportURL)
                                                          Return str2
                                                      End Function)

                Trace.WriteLine(report)
                Dim token As String = task2.Result
                Dim urn As String = Await Task.Run(Function()
                                                       Return client.GenerateCloudURN(output.OutputFileUrl, rootComponent)
                                                   End Function)

                ViewData("AccessToken") = token
                ViewData("ViewerURN") = urn
                ViewData("ViewerLink") = client.GenerateURL(urn, token)

                Return View(model)

            End If



        End Function
        'http://help.infragistics.com/Help/Doc/jQuery/2014.2/CLR4.0/html/igGrid_Binding_to_DataTable.html

        <Authorize> <HostActionFilter>
        <ActionName("EditingSaveChanges")>
        Public Async Function EditingSaveChanges(ByVal id As Integer) As Task(Of ActionResult)

            'myWebController.manager = Nothing
            Dim oView As New clsMvcView(EnumViewMode.acNormalM, Me.myWebController)
            Dim model As frmPIDUParamsUcModel = Await myWebController.DataProvider.LoadForm(Me.myWebController.AppInfo, oView.Model.ViewState, "frmPIDUParamsUcModel", "", EnumfrmMode.acEditM, id)
            Dim dt As DataTable = model.GridViews("params").MainGrid.myDS.Tables(0)

            Dim m As New NewtonSoftGridModel()
            Dim oRet As clsProcOutput = myMvcController.UpdateModel(model, "", "params", m.LoadTransactionsDictionary(Of Dictionary(Of String, String))(HttpContext.Request.Form("ig_transactions")))

            Dim response As New Dictionary(Of String, Boolean)()
            response.Add("Success", oRet.Success)
            Dim result As New JsonResult()
            result.Data = response
            Return result
        End Function

        Private Sub ProgressChanged(ByVal sender As Object, report As clsProgressReport)
            Select Case report.ReportType
                Case EnumReportType.Message
                    Trace.WriteLine("Message: " & report.Message)
                Case EnumReportType.TaskProgress
                    Trace.WriteLine(String.Format("Progress: {0}%, Message = {1}", report.Percentage, report.Message))
                Case EnumReportType.TaskFinish
                    Trace.WriteLine("Finish Result: " & report.Description)
                Case EnumReportType.StepCompleted
                    Select Case report.FileNewName.Trim.ToLower
                        Case "txt"
                            output.ReportURL = report.FileNameCompleted
                        Case "zip"
                            output.OutputFileUrl = report.FileNameCompleted
                    End Select
            End Select

        End Sub
    End Class
End Namespace