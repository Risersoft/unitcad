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
Imports risersoft.app.mxform.eto
Imports risersoft.unitcad.API
Imports Infragistics.Win.UltraWinTree

Public Class frmUC3Explorer
    Inherits frmMax
    Implements ICadModelProvider

    Implements IDockedWindow

    Dim SelectedNode As UltraTreeNode
    Dim myVueRef As New clsWinView, mdsCompDef As DataSet
    Dim rootComponent As String, downloadList As New List(Of String)
    Dim mWO As clsWOInfoUCAD, provider As ICADServer3D, mWODomain As String = ""

    Public Sub InitForm()


        myView.SetGrid(Me.UltraGrid1)
        myVueRef.SetGrid(Me.UltraGrid2)

        AddHandler Me.UltraGrid2.InitializeRow, AddressOf myUC3Out.UltraGrid2_InitializeRow
    End Sub
    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Me.strT = "tf"
        Dim objModel As frmUCInvPIDUModel = Me.InitData("frmUCInvPIDUModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.GenerateWOInfo(False)
            Me.PrepareUI(myUtils.cValTN(myRow("pidunitid")))
            provider = myWinApp.objAppExtender.CADProvider3D(Me.Controller, AddressOf ProgressChanged, 0)
            provider.InitializeDoc3D(mWO.dsWO, WODomain, mWO.dtParamOrig)
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Return True
        End If
        Return False
    End Function

    Protected Friend Sub PrepareUI(PIDUnitID As Integer)
        WinTreeUtils.BuildBOMTree(Me.UltraTree1, "TFDesCompRefID,ChildRefIDs,NewName,BaseFileName", "0-0-1-1")

        Dim params As New List(Of clsSQLParam)
        params.Add(New clsSQLParam("@pidunitid", PIDUnitID, GetType(Integer), False))

        Dim model1 As clsViewModel = Me.Controller.DataProvider.GenerateParamsModel(Me.Controller.GetAppInfo, "frmUCInvPIDUModel", "", myView.Model.ViewState, "bomtank", params).Result
        myView.PrepEdit(model1)

        Dim model2 As clsViewModel = Me.Controller.DataProvider.GenerateParamsModel(Me.Controller.GetAppInfo, "frmUCInvPIDUModel", "", myVueRef.Model.ViewState, "compref", params).Result
        model2.MainGrid.MainConf("hidecols") = "descrip,basefilename"
        model2.MainGrid.MainConf("autorowht") = False
        myVueRef.PrepEdit(model2)


        WinTreeUtils.MakeTree(Me.UltraTree1.Nodes, Nothing, myVueRef.mainGrid.myDv.Table, "TFDesCompRefID", "NewName", "pCompRefID", "", New WinTreeUtils.dSetNodeProps(AddressOf SetNodeProp), Nothing)
        WinTreeUtils.ExpandNodes(Me.UltraTree1, 2)
        If Me.UltraTree1.Nodes.Count > 0 Then
            Me.UltraTree1.ActiveNode = Me.UltraTree1.Nodes(0)
            Me.UltraTree1.ActiveNode.Selected = True
        End If
        myUC3Out.FillThumbs(Me.UltraListView1, mWO, myVueRef.mainGrid.myDS.Tables(0), True)
    End Sub
    Private Sub SetNodeProp(xNode As UltraTreeNode, rNode As DataRow)
        Dim imageindex As Integer = 0
        xNode.SetCellValue(xNode.DataColumnSetResolved.Columns("BaseFileName"), rNode("BaseFileName"))
        xNode.SetCellValue(xNode.DataColumnSetResolved.Columns("ChildRefIDs"), rNode("ChildRefIDs"))
        If myUtils.EndsWith(rNode("newfilename"), "ipt") Then imageindex = 1
        xNode.Cells("NewName").Appearance.Image = Me.imageList.Images(imageindex)
    End Sub
    Private Sub UltraTree1_AfterSelect(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTree.SelectEventArgs) Handles UltraTree1.AfterSelect

        If Me.UltraTree1.SelectedNodes.Count = 0 Then SelectedNode = Me.UltraTree1.Nodes(0) Else SelectedNode = Me.UltraTree1.SelectedNodes(0)
        Dim str2 As String = myUtils.cStrTN(SelectedNode.GetCellValue(SelectedNode.DataColumnSetResolved.Columns("ChildRefIDs")))
        myVueRef.mainGrid.myDv.RowFilter = "TFDesCompRefID in (" & str2 & ")"
        Dim TFDesCompRefID As String = SelectedNode.Key.ToString
        Dim rr() As DataRow = myVueRef.mainGrid.myDv.Table.Select("TFDesCompRefID='" & TFDesCompRefID & "'")
        Me.UltraToolbarsManager1.Tools("ID_Delete").SharedProps.Enabled = myUtils.cBoolTN(rr(0)("isdynamic"))
        Me.UltraToolbarsManager1.Tools("ID_EditChildRule").SharedProps.Enabled = (Not myUtils.cBoolTN(rr(0)("isdynamic"))) AndAlso (myUtils.cStrTN(rr(0)("pcomprefid")).Trim.Length > 0)
        Me.UltraToolbarsManager1.Tools("ID_AddChild").SharedProps.Enabled = Not myUtils.EndsWith(myUtils.cStrTN(rr(0)("newfilename")), ".ipt")
    End Sub

    Public Overrides Function VSave() As Boolean

        Me.VSaving = True
        Me.cm.EndCurrentEdit()



        Me.VSaving = False
        Return True

    End Function
    Private Sub StartPrep()
        starttime = Now
        Me.DisableButtons()
        Me.UltraProgressBar1.Value = 0
        Me.UltraProgressBar1.Text = "[Formatted]"
        Me.UltraProgressBar1.Visible = True

    End Sub

    Private Sub DisableButtons()
        Me.PanelButtons.Enabled = False
    End Sub

    Private Sub ProgressChanged(ByVal sender As Object, report As clsProgressReport)
        Select Case report.ReportType
            Case EnumReportType.Message
                myWinUtils.LogTextEvent(Me.RichTextBox1, report.TextColor, report.Message)
            Case EnumReportType.TaskProgress
                Me.ReportProgress(report.Percentage, report.Message)
            Case EnumReportType.TaskFinish
                Me.ReportProgress(100, report.Description)
                'reCalc already calls CompleteRun > PrepareUI > FillThumbs
                'Hence no action to be taken hare
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

    Friend Async Function recalc3D(ByVal task As String) As Task(Of String)
        If Me.VSave Then
            Me.StartPrep()
            Me.UltraListView1.Items.Clear()
            downloadList.Clear()

            Dim cb As New ProgressReporter(Of clsProgressReport)(AddressOf ProgressChanged)
            Dim arr() As String = Split(task, "|")
            Select Case arr(0).Trim.ToLower
                Case "snapshot3d"
                    rootComponent = myIntent.FindRootComponent(mWO, mWODomain)
                    Me.StartTimedProgress(100, 60, "Connecting to Inventor")
                    Dim str3 As String = Await provider.PrepareSnapshot3D(mWO.dsWO, mdsCompDef, mWODomain, mWO.dtParamOrig, arr(1), arr(2))
                    Me.CompleteRun(str3, False)
                    Return str3
                Case "prep3d"
                    rootComponent = myIntent.FindRootComponent(mWO, mWODomain)
                    Me.StartTimedProgress(100, 60, "Connecting to Inventor")
                    Dim str3 As String = Await provider.PrepareDoc3D(mWO.dsWO, mdsCompDef, mWODomain, mWO.dtParamOrig)

                    Dim TaskList As New List(Of Task)
                    For Each file In downloadList
                        Dim f As IViewer = myWinApp.objAppExtender.fViewer3D
                        f.OpenFile(file, rootComponent)
                        WinFormUtils.CentreForm(f)


                        Dim oFiler As clsFileProviderClientBase = myWinApp.objAppExtender.FileProviderClient(Me.Controller, "ucad", "blob")
                        TaskList.Add(Threading.Tasks.Task.Run(Sub()
                                                                  Dim oClient As New clsAuViewerClient(Me.Controller)
                                                                  oClient.DownloadObject(file)
                                                              End Sub))
                    Next
                    Await Threading.Tasks.Task.WhenAll(TaskList)
                    Me.CompleteRun(str3, False)
                    Return str3
                Case Else
                    'BOM OR BOM+Tree
                    Dim tfCompDefID As Integer = myUtils.cValTN(mWO.rPIDU("startupdefid"))
                    Me.StartTimedProgress(80, 10, "Creating Tree")
                    Dim oDef As New clsTFCompDefBase(Me.Controller)
                    Await oDef.PrepareTree3DAsync(New clsMultiWorker(cb), mWO, tfCompDefID, mWODomain, True, True)
                    Me.CompleteRun("Done", False)
                    Return tfCompDefID
            End Select

        End If
    End Function
    Public Sub StartTimedProgress(ByVal perTravel As Integer, ByVal timeoutsecs As Integer, ByVal Descrip As String)
        Me.Invoke(New myWinUtils.StartTimedProgressCB(AddressOf Me.StartTimedProgressBar), perTravel, timeoutsecs, Me.UltraProgressBar1, Descrip)
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


    Private Async Sub btnPrepModel3D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrepModel3D.Click
        Await Me.UpdateModelAsync(sender)
    End Sub

    Public Sub CompleteRun(ByVal result As String, ByVal cancelled As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of String, Boolean)(AddressOf CompleteRun), result, cancelled)
        Else
                Me.UltraProgressBar1.Visible = False
            Me.PrepareUI(myRow("pidunitid"))
            Me.RestoreButtons()
            Debug.WriteLine(result)
        End If
    End Sub

    Private Async Sub UltraToolbarsManager1_ToolClick(sender As Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Dim _app = myIAM.mApp
        If (_app.ActiveDocument Is Nothing) Then
            'Do Nothing
        ElseIf (SelectedNode Is Nothing) Then
            'Do Nothing
        ElseIf frmParamEditor.CurrentPartEditorDialog Is Nothing Then
            Dim TFDesCompRefID As Guid = Guid.Parse(SelectedNode.Key.ToString)
            Dim rr() As DataRow = myVueRef.mainGrid.myDv.Table.Select("TFDesCompRefID='" & TFDesCompRefID.ToString & "'")
            Dim doc As New clsComponentDocument(TFDesCompRefID.ToString, Me)
            Select Case e.Tool.Key.Trim
                Case "ID_Params"
                    Dim fp As frmParamEditor
                    Dim _interactionEvents = _app.CommandManager.CreateInteractionEvents()
                    fp = New frmParamEditor(doc, _interactionEvents, Me)
                    fp.Show(Me)
                Case "ID_AddChild"
                    Dim f As New frmGrid
                    Dim Params As New List(Of clsSQLParam)
                    Params.Add(New clsSQLParam("@tfdescomprefid", TFDesCompRefID.ToString, GetType(Guid), False))
                    Params.Add(New clsSQLParam("@pidunitid", myUtils.cValTN(myRow("pidunitid")), GetType(Integer), False))
                    Dim oRet As clsProcOutput = Me.GenerateParamsOutput("addchild", Params)
                    f.myView.mainGrid.BindView(oRet.Data,, 1)
                    f.myView.mainGrid.QuickConf("", True, "1-2")
                    If f.ShowDialog(Me) = DialogResult.OK Then
                        Dim def As New clsComponentDefinition(myUtils.DataRowFromGridRow(f.myView.ContextRow)("tfcompdefid"), Me)
                        Dim fp As frmParamEditor
                        Dim _interactionEvents = _app.CommandManager.CreateInteractionEvents()
                        fp = New frmParamEditor(Me)
                        Await fp.SetCreationContext(doc, def, _interactionEvents)
                        fp.Show(Me)
                    End If
                Case "ID_GlobalParams"
                    Dim f As New frmPIDUParamsUc
                    If f.PrepForm(myView, EnumfrmMode.acEditM, myRow("pidunitid")) Then
                        WinFormUtils.CentreForm(f)
                    End If
                Case "ID_EditDef"
                    Dim f As New frmTFCompDef3D
                    If f.PrepForm(myView, EnumfrmMode.acEditM, myUtils.cValTN(rr(0)("tfcompdefid"))) Then
                        WinFormUtils.CentreForm(f)
                    End If
                Case "ID_Delete"
                    Await doc.Parent.RemoveDynamicChild(TFDesCompRefID.ToString)
                Case "ID_EditChildRule"
                    Dim f As New frmTFCompDefChild
                    f.fDef = New clsComponentDefinition(doc.Parent.Definition.ID, Me)
                        If f.PrepForm(myView, EnumfrmMode.acEditM, myUtils.cValTN(rr(0)("tfcompdefdetbomid"))) Then
                        WinFormUtils.CentreForm(f)
                    End If
            End Select
        End If

    End Sub

    Private Sub RestoreButtons()
        Me.PanelButtons.Enabled = True
    End Sub

    Public Overloads Sub ReportProgress(ByVal ProgressPercentage As Integer, ByVal msgProg As String)
        If Me.UltraProgressBar1.InvokeRequired Then
            Dim d As New myWinUtils.ReportProgress(AddressOf ReportProgress)
            Me.UltraProgressBar1.Invoke(d, New Object() {ProgressPercentage, msgProg})
        Else
            Me.ReportProgress(Me.UltraProgressBar1, ProgressPercentage, msgProg, DateDiff(DateInterval.Second, starttime, Now))
        End If
    End Sub


    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        myUC3Out.FillThumbs(Me.UltraListView1, mWO, myVueRef.mainGrid.myDS.Tables(0), True)
    End Sub

    Public Async Function UpdateModelAsync(sender As Object) As Task(Of Boolean) Implements ICadModelProvider.UpdateModelAsync
        Me.GenerateWOInfo(False)
        mWO.LoadParams(True)
        Me.GenerateComponentData(True)
        Await recalc3D("bomtree")
        Await recalc3D("prep3d")
        Return True
    End Function



    Public Function GenerateWOInfo(forcefresh As Boolean) As clsWOInfoUCAD Implements ICadModelProvider.GenerateWOInfo
        If (mWO Is Nothing) OrElse forcefresh Then
            mWO = myPIDU.GenerateWOInfo(Me.Controller, myRow("pidunitid"))
        End If
        Return mWO
    End Function

    Public Function GenerateComponentData(forcefresh As Boolean) As DataSet Implements ICadModelProvider.GenerateComponentData
        If (mdsCompDef Is Nothing) OrElse forcefresh Then
            mdsCompDef = myIntent.LoadComponentDefData(Me.Controller, True)
        End If
        Return mdsCompDef
    End Function

    Public Function DockState() As EnumDockingState Implements IDockedWindow.DockState
        Return EnumDockingState.Right
    End Function

    Public Function Id() As String Implements IDockedWindow.Id
        Return "UnitCAD-WO-" & myRow("pidunitid")
    End Function

    Private Function IDockedWindow_Caption() As String Implements IDockedWindow.Caption
        Return " Model Explorer"
    End Function

    Public Sub OnCloseDocument(sender As Object, fullDocumentName As String) Implements IDockedWindow.OnCloseDocument
        Dim rootComponent = myIntent.FindRootComponent(mWO, mWODomain)
        If myUtils.EndsWith(fullDocumentName, rootComponent) Then Me.Close()
    End Sub

    Public Function WODomain() As String Implements ICadModelProvider.WODomain
        Return mWODomain
    End Function

    Public Async Function RunSnapshotRule(sender As Object, RefID As String, ShotCode As String) As Task(Of Boolean) Implements ICadModelProvider.RunSnapshotRule
        Me.GenerateWOInfo(False)
        mWO.LoadParams(False)
        Me.GenerateComponentData(True)
        Await recalc3D("snapshot3d|" & RefID & "|" & ShotCode)
        Return True

    End Function
End Class

