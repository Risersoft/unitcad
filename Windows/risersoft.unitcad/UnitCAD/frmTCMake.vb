Imports System.Windows.Forms
Imports System.IO
Imports risersoft.app.mxent
Imports risersoft.shared.cloud

Public Class frmTCMake
    Inherits frmMax
    Implements IfWizMax
    Public fTF As frmTCPIDU
    Dim startTime As Date, provider As ICADServer2D
    Dim mWO As clsWOInfoUCAD, tfCompDefID As Integer, mdsCompDef As DataSet, templatefile As String = ""
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitForm()
        'Add any initialization after the InitializeComponent() call

    End Sub
    Public Sub InitForm()
        myView.SetGrid(Me.UltraGrid1)
        WinFormUtils.SetButtonConf(Me.btnOK)
    End Sub
    Public Overloads Function Prepform(ByVal r As DataRow) As Boolean
        Me.FormPrepared = False
        If Me.BindData(r) Then
            Me.PrepareBOMGrid(myUtils.cValTN(myRow("pidunitid")))
            Me.FormPrepared = True
        End If

        Return Me.FormPrepared
    End Function
    Protected Friend Sub PrepareBOMGrid(PIDUnitID As Integer)
        Dim params As New List(Of clsSQLParam)
        params.Add(New clsSQLParam("@pidunitid", PIDUnitID, GetType(Integer), False))
        Dim model As clsViewModel = Me.Controller.DataProvider.GenerateParamsModel(Me.Controller.GetAppInfo, "frmPIDUParamsUcModel", "", myView.Model.ViewState, "bomtank", params).Result
        myView.BindView(model)
    End Sub
    Public Overrides Function VSave() As Boolean
        Return True
    End Function
    Public Function LoseFocus(newTabKey As String) As Boolean Implements IfWizMax.LoseFocus
        Dim cont As Boolean
        cont = Me.VSave()
        Return cont
    End Function

    Public Function SetFocus(oldTabKey As String) As Boolean Implements IfWizMax.SetFocus
        Dim cont As Boolean
        cont = Me.Prepform(fTF.myRow.Row)
        Me.FormPrepared = cont
        Return cont
    End Function

    Public Function btnActionText() As String Implements IfWizMax.btnActionText

    End Function

    Public Function ShowTabKeys() As System.Collections.ArrayList Implements IfWizMax.ShowTabKeys

    End Function
    Public Sub StartAction() Implements IfWizMax.StartAction

    End Sub

    Public Sub StopAction() Implements IfWizMax.StopAction

    End Sub
    Private Sub StartPrep()
        If Not fTF Is Nothing Then fTF.StartPrep()
        Me.btnOK.Enabled = False
        Me.btnSave.Enabled = False
        startTime = Now

    End Sub
    Public Sub TestComponent(oWO As clsWOInfoBase, rCompDef As DataRow, dsCompDef As DataSet)
        tfCompDefID = rCompDef("tfcompdefid")
        mdsCompDef = dsCompDef
        mWO = oWO
        Me.btnPrepModel2D.Visible = False
        Me.btnOK.Visible = True
        Me.PrepareBOMGrid(myUtils.cValTN(oWO.rPIDU("pidunitid")))
        Me.recalc2D("prep2d")
    End Sub
    Private Sub ProgressChanged(ByVal sender As Object, report As clsProgressReport)
        Select Case report.ReportType
            Case EnumReportType.Message
                myWinUtils.LogTextEvent(Me.RichTextBox1, report.TextColor, report.Message)
            Case EnumReportType.TaskProgress
                Me.ReportProgress(report.Percentage, report.Message)
            Case EnumReportType.TaskFinish
                Me.CompleteRun(report.Description, False)
            Case EnumReportType.StepCompleted

                Select Case report.FileNewName.Trim.ToLower
                    Case "txt"
                        'download the status report
                        'DownloadToDocs(url, "AIO-report.txt")
                        Dim oFiler As clsFileProviderClientBase = myWinApp.objAppExtender.FileProviderClient(Me.Controller, "ucad", "blob")
                        Dim str1 As String = oFiler.DownloadHttpString(report.FileNameCompleted)
                        myWinUtils.LogTextEvent(Me.RichTextBox1, report.TextColor, str1)
                    Case "zip"
                        'Resource property of the output argument "Results" will have the output url
                        'DownloadToDocs(url2, "AIO.zip")
                        Dim f As IViewer = myWinApp.objAppExtender.fViewer2D
                        f.OpenFile(report.FileNameCompleted, "test.dwg")
                        WinFormUtils.CentreForm(f)
                        Dim oClient As New clsAuViewerClient(Me.Controller)
                        oClient.DownloadObject(report.FileNameCompleted)


                End Select
        End Select
    End Sub
    Friend Async Sub recalc2D(ByVal code As String)
        If Me.VSave Then
            Me.StartPrep()
            If myWinApp.CheckLicense2() Then
                Select Case code.Trim.ToLower
                    Case "prep2d"
                        Me.StartTimedProgress(100, 30, "Connecting to AutoCAD")
                        If provider Is Nothing Then provider = myWinApp.objAppExtender.CADProvider2D(Me.Controller, AddressOf ProgressChanged, 0)
                        Me.ReportProgress(0, "Model Construction Started")
                        Dim str3 As String = Await provider.PrepareDoc2D(templatefile, mWO.dsWO, tfCompDefID, mdsCompDef, "", mWO.dtParamTrans(False))
                        Me.CompleteRun(str3, False)

                    Case Else
                        'BOM OR BOM+Tree
                        '-------Important note dated 10-02-2012 -----------------------------------------------------------
                        'This is not used because in unitcad 2D, we have a mechanism of getting values from the geometry
                        'The children and qty may be decided on that basis: hence prepareTree is not possible
                        'Besides since unitcad is running inside AutoCAD, Inventor like approach is not a must.
                        Me.StartTimedProgress(80, 10, "Creating Tree")
                        Dim oDef As New clsTFCompDefBase(Me.Controller)
                        Dim cb As New ProgressReporter(Of clsProgressReport)(AddressOf ProgressChanged)
                        Await oDef.PrepareTree2DAsync(New clsMultiWorker(cb), mWO, tfCompDefID, "demo1", True)
                        Me.CompleteRun("Done", False)

                End Select

            End If

        End If
    End Sub
    Public Sub StartTimedProgress(ByVal perTravel As Integer, ByVal timeoutsecs As Integer, ByVal Descrip As String)
        If Not fTF Is Nothing Then fTF.Invoke(New myWinUtils.StartTimedProgressCB(AddressOf fTF.StartTimedProgressBar), perTravel, timeoutsecs, fTF.UltraProgressBar1, Descrip)
    End Sub

    Public Sub PrintOutput() Implements IfWizMax.PrintOutput

    End Sub

    Private Sub btn_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Print.Click
        Dim str2 As String
        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "bomtank2"
                str2 = "<MMR CAPTION=""Bill Of Material""><GROUP FIELD=""sortindex"" TYPE=""3""/></MMR>"""
                Me.Controller.PrintingPress.GenerateAndShowReport(myView, EnumPrintWhat.acTopBand, str2, , 1)

        End Select
    End Sub


    Public Sub CompleteRun(ByVal result As String, ByVal cancelled As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of String, Boolean)(AddressOf CompleteRun), result, cancelled)
        Else
            If Not fTF Is Nothing Then
                fTF.UltraProgressBar1.Visible = False
                For Each oview As clsWinView In New clsWinView() {myView}
                    oview.Refresh()
                Next
                fTF.RestoreButtons()
            End If
            myDWG.objAddin2D.ZoomAll() 'should not be taken into inside of Intent2D operations because sometimes gives application busy message
            Me.btnOK.Enabled = True
            Me.btnSave.Enabled = True
            Debug.WriteLine(result)
        End If
    End Sub

    Public Sub ReportProgress(ByVal ProgressPercentage As Decimal, ByVal msgProg As String)
        If Not fTF Is Nothing Then
            If fTF.UltraProgressBar1.InvokeRequired Then
                Dim d As New myWinUtils.ReportProgress(AddressOf ReportProgress)
                fTF.UltraProgressBar1.Invoke(d, New Object() {ProgressPercentage, msgProg})
            Else
                fTF.ReportProgress(ProgressPercentage, msgProg, DateDiff(DateInterval.Second, startTime, Now))
            End If
        End If
    End Sub

    Private Sub btnPrepModel2D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrepModel2D.Click
        'gets it afresh each time as frmPIDUParams might have changed it
        tfCompDefID = myUtils.cValTN(fTF.fp.myRow("startupdefid"))
        templatefile = myUtils.cStrTN(fTF.fp.myRow("templatefilename"))
        mWO = myPIDU.GenerateWOInfo(Me.Controller, myRow("pidunitid"))
        mdsCompDef = myIntent.LoadComponentDefData(Me.Controller, True)

        If tfCompDefID > 0 Then
            Me.RichTextBox1.Clear()
            Me.recalc2D("prep2d")
        Else
            MsgBox("Startup Definition Not Selected", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If

    End Sub



    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim sfd As New SaveFileDialog

        sfd.Filter = "RTF File (*.rtf)|*.rtf"
        sfd.FilterIndex = 1
        If sfd.ShowDialog = DialogResult.OK Then
            Me.RichTextBox1.SaveFile(sfd.FileName)
        End If
    End Sub
End Class

