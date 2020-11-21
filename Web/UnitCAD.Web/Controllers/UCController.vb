Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Web.Hosting
Imports System.Web.Http
Imports Newtonsoft.Json
Imports risersoft.app.mxengg
Imports risersoft.app.mxent
Imports risersoft.shared.dotnetfx
Imports risersoft.shared
Imports risersoft.shared.portable.Model
Imports risersoft.shared.portable.Models.UnitCAD
Imports risersoft.shared.web
Imports risersoft.shared.web.Controllers

Namespace Controllers
    <RoutePrefix("api/UC")>
    Public Class UCController
        Inherits ApiControllerBase

        Dim rTask As DataRow, objTask As New ApiTask, output As New UCTaskOutput
        Dim mWO As clsWOInfoBase, mdsCompDef As DataSet
        Dim tfCompDefID As Integer, templatefile As String

        ' GET: api/UC/BaseDir
        <HttpGet> <ActionName("BaseDir")>
        Public Function GetBaseDir() As String
            Dim baseDirectory As String = Path.Combine(Me.myWebController.App.objAppExtender.CommonAppDataPath, "AIO", System.Guid.NewGuid.ToString)
            My.Computer.FileSystem.CreateDirectory(baseDirectory)
            Return baseDirectory
        End Function


        ' GET: api/UC/Workunit/5
        <HttpGet> <ActionName("WorkUnit")>
        Public Async Function GetWorkUnit(ByVal id As Integer) As Task(Of UCWorkUnit)
            If Await Me.myWebController.CheckInitModel(New clsAppInfo, False) Then
                Dim mWO As clsWOInfoBase = myPIDU.GenerateWOInfo(Me.myWebController, id)
                Dim mdsCompDef As DataSet = myIntent.LoadComponentDefData(Me.myWebController, True)
                Dim tfCompDefID As Integer = myUtils.cValTN(mWO.rPIDU("startupdefid"))
                Dim rCompDef As DataRow = myIntent.rCompDef(mdsCompDef, tfCompDefID)

                Dim obj As New UCWorkUnit
                obj.ID = id
                obj.StartupCode = rCompDef("compdefcode")
                For Each rp As DataRow In mWO.dtParamTrans(False).Select(myWebController.Params.ParamGroupFilter(myUtils.cStrTN(mWO.rPIDU("paramgrouppsv"))))
                    obj.Params.Add(New KeyValuePair(Of String, String)(rp("paramcode"), rp("paramvalue")))
                Next
                Return obj

            End If

        End Function

        ' POST: api/UC/Workunit
        <HttpPost> <ActionName("WorkUnit")>
        Public Async Function PostWorkUnit(<FromBody()> unit As UCWorkUnit) As Task(Of ApiTask)
            If Await Me.myWebController.CheckInitModel(New clsAppInfo, False) Then

                mWO = myPIDU.GenerateWOInfo(Me.myWebController, unit.ID)
                mdsCompDef = myIntent.LoadComponentDefData(Me.myWebController, True)
                tfCompDefID = myUtils.cValTN(mWO.rPIDU("startupdefid"))
                templatefile = myUtils.cStrTN(mWO.rPIDU("templatefilename"))

                For Each prm In unit.Params
                    Me.myWebController.Params.AddUpdParam(mWO.dtParamTrans(False), prm.Key, Nothing, prm.Value, True)
                Next

                Dim sql As String = "select * from apitask where 0=1"
                Dim dt1 As DataTable = Me.myWebController.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                rTask = Me.myWebController.Tables.AddNewRow(dt1)
                rTask("apitaskid") = System.Guid.NewGuid.ToString
                rTask("tasktype") = "UC"
                rTask("ParentID") = unit.ID
                rTask("submittedon") = Now
                rTask("status") = "In Progress"
                Me.myWebController.DataProvider.objSQLHelper.SaveResults(dt1, sql)
                SyncObjectFromRow(objTask, rTask)
                objTask.StatusURL = Me.Url.Route("ActionApi", New With {.Controller = "UC", .Action = "Task", .ID = objTask.ApiTaskID})
                HostingEnvironment.QueueBackgroundWorkItem(AddressOf RunApiTask)
                Return objTask
            End If

        End Function
        ' GET: api/UC/Task/Guid
        <HttpGet> <ActionName("Task")>
        Public Async Function GetApiTask(ByVal id As String) As Task(Of ApiTask)
            If Await Me.myWebController.CheckInitModel(New clsAppInfo, False) Then
                'this function runs on a new controller object and hence does not affect the original task object
                Dim oRet As clsProcOutput = Me.myWebController.SQL.ValidateValue(GetType(Guid), id)
                If oRet.Success Then
                    Dim sql As String = "select * from apitask where apitaskid='" & id & "'"
                    Dim dt1 As DataTable = Me.myWebController.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                    If dt1.Rows.Count > 0 Then
                        SyncObjectFromRow(objTask, dt1.Rows(0))
                    Else
                        oRet.AddError(id & " does not exist in this context")
                    End If
                End If
                If Not oRet.Success Then
                    objTask.Report = oRet.Message
                    objTask.Status = "Error"
                End If
                Return objTask

            End If

        End Function
        Private Async Sub RunApiTask(ct As CancellationToken)
            Dim provider As ICADServer2D = myWebApp.objAppExtender.CADProvider2D(Me.myWebController, AddressOf ProgressChanged, 0)
            Await provider.PrepareDoc2D(templatefile, mWO.dsWO, tfCompDefID, mdsCompDef, "", mWO.dtParamTrans(False))

            Dim oFiler As clsFileProviderClientBase = myWebApp.objAppExtender.FileProviderClient(Me.myWebController, "ucad", "blob")
            Dim str1 As String = oFiler.DownloadHttpString(output.ReportURL)

            rTask("status") = "Completed"
            rTask("CompletedOn") = Now
            rTask("report") = str1
            rTask("ResultJson") = JsonConvert.SerializeObject(output)
            Me.myWebController.DataProvider.objSQLHelper.SaveResults(rTask.Table, "Select * from apitask where 0=0")
        End Sub
        Private Sub ProgressChanged(ByVal sender As Object, report As clsProgressReport)
            Select Case report.ReportType
                Case EnumReportType.Message
                    Debug.WriteLine(report.Message)
                Case EnumReportType.StepCompleted
                    'this event should be handled such that both files are given similar treatment.
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