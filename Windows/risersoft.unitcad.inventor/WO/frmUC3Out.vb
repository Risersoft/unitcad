Imports System.Xml
Imports Infragistics.Win.UltraWinTabControl
Imports risersoft.unitcad
Imports System.Drawing
Imports risersoft.unitcad.iv
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports risersoft.app.shared
Imports System.IO
Imports System.Threading.Tasks
Imports risersoft.app.mxent
Imports risersoft.shared.cloud

Public Class frmUC3Out
    Inherits frmMax
    Implements IfWizMax

    Public fTF As frmUCInvPIDU
    Dim myVueRef As New clsWinView, mdsCompDef As DataSet
    Dim startTime As Date, rootComponent As String, downloadList As New List(Of String)
    Dim mWO As clsWOInfoUCAD, provider As ICADServer3D
    Public Sub InitForm()
        Dim dt As DataTable



        Me.Visible = False
        Me.Dock = DockStyle.Fill
        myView.SetGrid(Me.UltraGrid1)
        myVueRef.SetGrid(Me.UltraGrid2)

        AddHandler Me.UltraGrid2.InitializeRow, AddressOf myUC3Out.UltraGrid2_InitializeRow

    End Sub

    Public Overloads Function Prepform(ByVal r As DataRow) As Boolean
        Dim arrSht As New ArrayList, str1 As String

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

        Dim model1 As clsViewModel = Me.Controller.DataProvider.GenerateParamsModel(Me.Controller.GetAppInfo, "frmUCInvPIDUModel", "", myView.Model.ViewState, "bomtank", params).Result
        myView.PrepEdit(model1)

        Dim model2 As clsViewModel = Me.Controller.DataProvider.GenerateParamsModel(Me.Controller.GetAppInfo, "frmUCInvPIDUModel", "", myVueRef.Model.ViewState, "compref", params).Result
        myVueRef.PrepEdit(model2)

        myUC3Out.FillThumbs(Me.UltraListView1, mWO, myVueRef.mainGrid.myDS.Tables(0), True)


    End Sub
    Public Overrides Function VSave() As Boolean
        Dim cont As Boolean = False

        Me.VSaving = True
        If fTF Is Nothing Then
            cont = True
        Else
            Me.cm.EndCurrentEdit()
            cont = fTF.VSave()
        End If
        Me.VSaving = False
        Return cont

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
        If fTF IsNot Nothing Then fTF.StartPrep()
        startTime = Now

    End Sub
    Public Async Function TestComponent(oWO As clsWOInfoBase, tfCompDefID As Integer, dsCompDef As DataSet, dtParams As DataTable, dtRef As DataTable, dtRefParam As DataTable) As Task(Of String)
        mdsCompDef = dsCompDef
        mWO = New clsWOInfoUCAD(Me.Controller, oWO.dsWO.Copy, dtParams)
        myUtils.AddTable(mWO.dsWO, dtRef, "compref")
        myUtils.AddTable(mWO.dsWO, dtRefParam, "comprefparam")
        Me.PanelButtons.Visible = False
        Me.UltraTabControl1.Style = UltraTabControlStyle.Wizard
        Me.UltraTabControl1.Tabs("log").Selected = True

        Return Await Me.recalc3D("prep3d")
    End Function
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
                        Dim oFiler As clsFileProviderClientBase = myWinApp.objAppExtender.FileProviderClient(Me.Controller, "ucad", "blob")
                        Dim str1 As String = oFiler.DownloadHttpString(report.FileNameCompleted)
                        My.Computer.FileSystem.WriteAllText(Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, "AIO-report.txt"), str1, False)
                        myWinUtils.LogTextEvent(Me.RichTextBox1, report.TextColor, str1)
                    Case "zip"
                        'Resource property of the output argument "Results" will have the output url
                        downloadList.Add(report.FileNameCompleted)
                        myWinUtils.LogTextEvent(Me.RichTextBox1, report.TextColor, report.FileNameCompleted)
                    Case Else
                        'iam/ipt
                        myUC3Out.AddFile(Me.UltraListView1, report.FileNameCompleted, report.FileNewName)
                End Select
        End Select
    End Sub

    Friend Async Function recalc3D(ByVal code As String) As Task(Of String)
        If Me.VSave Then
            Me.StartPrep()
            Me.UltraListView1.Items.Clear()
            Dim WODomain As String = ""
            downloadList.Clear()

            Dim cb As New ProgressReporter(Of clsProgressReport)(AddressOf ProgressChanged)

            Select Case code.Trim.ToLower
                Case "prep3d"
                    rootComponent = myIntent.FindRootComponent(mWO, WODomain)
                    Me.StartTimedProgress(100, 60, "Connecting to Inventor")
                    If provider Is Nothing Then provider = myWinApp.objAppExtender.CADProvider3D(Me.Controller, AddressOf ProgressChanged, 0)
                    Dim str3 As String = Await provider.PrepareDoc3D(mWO.dsWO, mdsCompDef, WODomain, mWO.dtParamOrig)

                    Dim TaskList As New List(Of Task)
                    For Each file In downloadList
                        Dim f As IViewer = myWinApp.objAppExtender.fViewer3D
                        f.OpenFile(file, rootComponent)
                        WinFormUtils.CentreForm(f)


                        Dim oFiler As clsFileProviderClientBase = myWinApp.objAppExtender.FileProviderClient(Me.Controller, "ucad", "blob")
                        TaskList.Add(Task.Run(Sub()
                                                  Dim oClient As New clsAuViewerClient(Me.Controller)
                                                  oClient.DownloadObject(file)
                                              End Sub))
                    Next
                    Await Task.WhenAll(TaskList)
                    Me.CompleteRun(str3, False)
                    Return str3
                Case Else
                    'BOM OR BOM+Tree
                    Dim tfCompDefID As Integer = myUtils.cValTN(mWO.rPIDU("startupdefid"))
                    Me.StartTimedProgress(80, 10, "Creating Tree")
                    Dim oDef As New clsTFCompDefBase(Me.Controller)
                    Await oDef.PrepareTree3DAsync(New clsMultiWorker(cb), mWO, tfCompDefID, WODomain, True, True)
                    Me.CompleteRun("Done", False)
                    Return tfCompDefID
            End Select

        End If
    End Function
    Public Sub StartTimedProgress(ByVal perTravel As Integer, ByVal timeoutsecs As Integer, ByVal Descrip As String)
        If Not fTF Is Nothing Then fTF.Invoke(New myWinUtils.StartTimedProgressCB(AddressOf fTF.StartTimedProgressBar), perTravel, timeoutsecs, fTF.UltraProgressBar1, Descrip)
    End Sub


    Public Sub PrintOutput() Implements IfWizMax.PrintOutput


    End Sub

    Private Sub frmPackOut_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Not Me.DesignMode Then
            myView.mainGrid.Genwidth(True)
        End If

    End Sub


    Private Sub btn_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Print.Click
        Dim str1, str2 As String
        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "bomtank2"
                str2 = "<MMR CAPTION=""Bill Of Material""><GROUP FIELD=""sortindex"" TYPE=""3""/></MMR>"""
                Me.Controller.PrintingPress.GenerateAndShowReport(myView, EnumPrintWhat.acTopBand, str2, , 1)
            Case "compref"
                Me.Controller.PrintingPress.GenerateAndShowReport(myVueRef, EnumPrintWhat.acMMR)
        End Select
    End Sub



    Private Async Sub btnPrep2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrep2.Click
        mWO = myPIDU.GenerateWOInfo(Me.Controller, myRow("pidunitid"))
        mdsCompDef = myIntent.LoadComponentDefData(Me.Controller, True)
        Await recalc3D("bomtree")
    End Sub

    Private Async Sub btnMasterZip_Click(sender As Object, e As EventArgs) Handles btnMasterZip.Click
        Me.StartPrep()
        Me.StartTimedProgress(100, 60, "Generating Zip File")
        Dim subdir As String = "inv"
        Dim oRet As clsProcOutput = Me.Controller.DataProvider.GenerateIDOutput(Me.Controller.GetAppInfo, "frmUCInvPIDUModel", "", "compfile", 0).Result
        Dim oFiler As New clsMultiFiler(Me.Controller, "ucad")
        For Each dt1 As DataTable In oRet.Data.Tables
            For Each r1 As DataRow In dt1.Select
                Dim path As String = System.IO.Path.Combine(Me.Controller.App.objAppExtender.FileServerPath, r1("compfilename"))
                Await Task.Run(Sub()
                                   oFiler.FileProvider.DownloadAndUnzipFileAsync(r1("compfilename"), "*.iam", "std")
                               End Sub)
                If System.IO.File.Exists(path) Then
                    r1("compfilehash") = Me.Controller.FTP.MD5CalcFile(path)
                    r1("compfilemodified") = System.IO.File.GetLastWriteTime(path)
                End If
            Next
        Next
        oRet = Me.Controller.DataProvider.GenerateDataOutput(Me.Controller.GetAppInfo, "frmUCInvPIDUModel", "", "compfile", oRet.Data, 0).Result
        Dim foldername As String = System.IO.Path.Combine(Me.Controller.App.objAppExtender.FileServerPath, subdir)
        Dim filename As String = oFiler.FileProvider.CreateZipFileFromFolder(foldername, "master.zip", "*.zip", "*.ipt")
        Me.ReportProgress(0, "Uploading Zip")
        Await Task.Run(Sub()
                           oFiler.FileProvider.UpLoadAsync(filename, "master.zip", subdir)
                       End Sub)
        Me.CompleteRun("Master Zip Uploaded", False)
    End Sub

    Private Async Sub btnPrepModel3D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrepModel3D.Click
        mWO = myPIDU.GenerateWOInfo(Me.Controller, myRow("pidunitid"))
        mdsCompDef = myIntent.LoadComponentDefData(Me.Controller, True)
        Await recalc3D("prep3d")
    End Sub

    Public Sub CompleteRun(ByVal result As String, ByVal cancelled As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of String, Boolean)(AddressOf CompleteRun), result, cancelled)
        Else
            If Not fTF Is Nothing Then
                fTF.UltraProgressBar1.Visible = False
                Me.PrepareBOMGrid(myUtils.cValTN(myRow("pidunitid")))
                fTF.RestoreButtons()
            End If
            Debug.WriteLine(result)
        End If
    End Sub

    Public Overloads Sub ReportProgress(ByVal ProgressPercentage As Integer, ByVal msgProg As String)
        If Not fTF Is Nothing Then
            If fTF.UltraProgressBar1.InvokeRequired Then
                Dim d As New myWinUtils.ReportProgress(AddressOf ReportProgress)
                fTF.UltraProgressBar1.Invoke(d, New Object() {ProgressPercentage, msgProg})
            Else
                fTF.ReportProgress(ProgressPercentage, msgProg, DateDiff(DateInterval.Second, startTime, Now))
            End If
        End If
    End Sub


    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        myUC3Out.FillThumbs(Me.UltraListView1, mWO, myVueRef.mainGrid.myDS.Tables(0), True)
    End Sub

End Class

