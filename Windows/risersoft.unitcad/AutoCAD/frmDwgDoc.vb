Imports Infragistics.Win.UltraWinTree
Imports Autodesk.AutoCAD.Interop
Imports risersoft.unitcad

Public Class frmDwgDoc
    Implements IDoc
    Public Event DocParamChanged()
    Public fM As frmMax, fCompDef As frmTFCompDefBase, paramdirty As Boolean = False
    Public fView As frmMax, provider As ICADServer2D
    Dim mBlockName As String, oTree As clsWinTree, mLoadedFile As String
    Public Property BlockName() As String
        Get
            Return mBlockName
        End Get
        Set(ByVal value As String)
            Dim oNode As UltraTreeNode
            If Me.UltraTree1.Nodes.Exists(value) Then
                oNode = Me.UltraTree1.Nodes(value)
            Else
                If Me.UltraTree1.Nodes.Count > 0 Then oNode = Me.UltraTree1.Nodes(0)
            End If
            If oNode IsNot Nothing Then
                Me.UltraTree1.ActiveNode = oNode
                Me.UltraTree1.ActiveNode.Selected = True
                'Me.SelectNode(oNode)
            End If
        End Set
    End Property
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        initForm()
    End Sub
    Public Sub initForm()
        Dim sql, str1 As String, r As DataRow, i As Integer, dt As DataTable

        myView.SetGrid(Me.UltraGrid5)
        fView = myWinApp.objAppExtender.fViewer2D
        fView.AddtoTab(Me.UltraTabControl3, "preview", True)
        AddHandler CtlUpLoad1.btnRefresh.Click, AddressOf btnRefreshTree_Click
        AddHandler CtlUpLoad1.btnShowApp.Click, AddressOf btnShow_Click
        AddHandler CtlUpLoad1.NewFileLoaded, AddressOf LoadFile
        AddHandler CtlUpLoad1.FileUploaded, AddressOf FileUploaded
        oTree = New clsWinTree(Me.UltraTree1, Nothing)

        Me.btnCopyUnused.Enabled = False
    End Sub
    Public Overrides Function PrepForm(ByVal f As frmMax) As Boolean
        Dim obj As Object

        If TypeOf f Is frmTFCompDefBase Then
            fCompDef = f
        Else
            fCompDef = Nothing
            myView.mainGrid.MainConf("HIDECOLS") = "MapType,NewValue"
            Me.btnCopyUnused.Enabled = False
            Me.btn_CalcParams.Enabled = False
            Me.btnSetUpdate.Enabled = False
        End If

        myView.mainGrid.MainConf("FORMATXML") = "<COL KEY=""MapType"" CAPTION=""Mapping"" VLIST=""0;Not Found|1;Local|2;Inherited|3;Global""/>"
        myView.mainGrid.MainConf("showrownumber") = True
        myView.mainGrid.BindView(myUtils.MakeDSfromTable(myDWG.dtBlankDocParams(True), False), , 0)
        myView.mainGrid.QuickConf("", True, "1-1-1-1-1-1", True, "Document Parameters")
        myView.mainGrid.myDv.RowFilter = "0=0"      'isuser=1 is not required for AutoCAD parameters

        Me.txt_TestFormula.CtlFormulaChk1.ParamsLoaded = True
        'parameters will be loaded when "Calc Parameters" button is pressed
        'this is to allow user to check to get actual values.
        Me.txt_TestFormula.InitFCheck(Nothing, Nothing, "")
        Me.txt_TestFormula.CtlFormulaChk1.cManager.AddFuncLib("acad", myAssy.GetClass(Me.Controller, "risersoft.unitcad.acad", "clsULtraFuncs2"))

        fM = f
        Me.frmMode = f.frmMode


        If myDWG.mApp Is Nothing Then myDWG.AppTriedAc = False

        Me.LoadFile(myUtils.cStrTN(f.myRow("compfilename")), myUtils.cStrTN(f.myRow("blockname")))
        Me.FormPrepared = True
        Me.BlockName = myUtils.cStrTN(f.myRow("blockname"))

    End Function
    Friend Overloads Sub FileUploaded(localFile As String, serverPath As String)
        Dim newFile As String = System.IO.Path.Combine(myWinApp.objAppExtender.FileServerPath, serverPath.Replace("/", "\"))
        My.Computer.FileSystem.CopyFile(localFile, newFile, True)
        Me.LoadFile(serverPath, myUtils.cStrTN(fM.myRow("blockname")))     'existing block name is preserved.
    End Sub
    Friend Overloads Sub LoadFile(ByVal filename As String)
        Me.LoadFile(filename, myUtils.cStrTN(fM.myRow("blockname")))     'existing block name is preserved.
    End Sub

    Friend Overloads Sub LoadFile(ByVal filename As String, CurrBlockName As String)


        Dim localfile As String = filename
        If (Not System.IO.Path.IsPathRooted(localfile)) AndAlso (Not String.IsNullOrEmpty(localfile)) Then
            localfile = System.IO.Path.Combine(myWinApp.objAppExtender.FileServerPath, filename.Replace("/", "\"))
            If (Not System.IO.File.Exists(localfile)) AndAlso (Not Me.CtlUpLoad1.oFiler Is Nothing) Then Me.CtlUpLoad1.oFiler.FileProvider.DownloadFile(filename, localfile)
        End If
        If System.IO.File.Exists(localfile) Then
            mLoadedFile = localfile
            If CType(fView, IViewer).CurrFile <> localfile Then
                CType(fView, IViewer).OpenFile(localfile)
            End If
            Me.TryInitCADProvider()
            Dim model = CType(fView, IViewer).GenerateTreeModel

            If ((model Is Nothing) OrElse model.Count = 0) AndAlso CurrBlockName.Trim.Length > 0 Then
                model.Add(CurrBlockName, CurrBlockName)
            End If
            oTree.BindModel(model)
            If Not provider Is Nothing Then
                Me.GetParams(localfile, True)
                paramdirty = False
            Else
                paramdirty = True
            End If
        Else
            mLoadedFile = ""
            If Not fView Is Nothing Then
                CType(fView, IViewer).OpenFile("")
            End If
        End If
    End Sub
    Public Sub TryInitCADProvider()
        provider = myDWG.objAddin2D
        If (provider Is Nothing) AndAlso (myDWG.InProcACAD OrElse (Not myDWG.AppTriedAc)) Then
            provider = myWinApp.objAppExtender.CADProvider2D(Me.Controller, AddressOf Me.Controller.HandleCallBack, 0)
        End If
    End Sub
    Private Sub GetParams(ByVal filename As String, ByVal doget As Boolean)
        Dim blockname As String, oNode As UltraTreeNode = Nothing

        If Me.UltraTree1.SelectedNodes.Count > 0 Then
            oNode = Me.UltraTree1.SelectedNodes(0)
        ElseIf Me.UltraTree1.Nodes.Count > 0 Then
            oNode = Me.UltraTree1.Nodes(0)
        End If
        If oNode IsNot Nothing Then
            blockname = oNode.Key
            myDWG.GetSet2DParams(filename, blockname, myView.mainGrid.myDS.Tables(0), doget)
            RaiseEvent DocParamChanged()
        End If
    End Sub
    Private Sub btnRefreshTree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.LoadFile(Me.FileName, mBlockName)
    End Sub

    Private Sub btnPrintDocParams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintDocParams.Click
        Me.Controller.PrintingPress.GenerateAndShowReport(myView)
    End Sub


    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TryInitCADProvider()
        Dim mApp As Object = myDWG.mApp
        If Not mApp Is Nothing Then
            mApp.Visible = True
            If mApp.Documents.Count > 1 Then
                Dim oDoc As Object = mApp.ActiveDocument
                oDoc.Activate()
            End If
        End If

    End Sub


    Private Sub btn_CalcParams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CalcParams.Click
        If Not fCompDef Is Nothing Then
            myParams.CalcFormulas(Me.txt_TestFormula.CtlFormulaChk1.cManager, fCompDef.dtAllParams, , , EnumFillBehaviour.acForceFill)
            For Each r1 As DataRow In myView.mainGrid.myDS.Tables(0).Select
                Try
                    r1("newvalue") = myUtils.MakeDBN(myParams.ParamValue(fCompDef.dtAllParams, r1("paramcode")))
                Catch ex As Exception
                    Debug.WriteLine("Error in setting  - " & r1("paramcode"))
                    r1("newvalue") = 0
                End Try
            Next
        End If

    End Sub

    Private Sub btnSetUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetUpdate.Click

        'set params
        Me.GetParams(Me.LoadedFile, False)
        If Not myDWG.mApp Is Nothing Then
            myDWG.mApp.Visible = True
        End If
    End Sub
    Private Sub SelectNode(ByVal oNode As UltraTreeNode)
        If Not fCompDef Is Nothing Then Me.btnCopyUnused.Enabled = True 'only when a block is selected should this button be enabled.
        myView.mainGrid.myDv.RowFilter = "blockname='" & oNode.Key & "'"
        mBlockName = oNode.Key
        RaiseEvent DocParamChanged()
        Dim conf = TryCast(oNode.Tag, clsConf)
        If (Not conf Is Nothing) AndAlso (Not myUtils.NullNot(conf("icon"))) Then
            Me.PictureBox1.Image = oNode.Tag("icon")
            If Me.UltraTabControl3.Tabs("preview").Selected Then Me.UltraTabControl3.Tabs("bpreview").Selected = True
        End If

    End Sub
    Private Sub UltraTree1_AfterSelect(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTree.SelectEventArgs) Handles UltraTree1.AfterSelect
        Dim oNode As UltraTreeNode
        Me.PictureBox1.Image = Nothing
        If Me.UltraTree1.SelectedNodes.Count > 0 Then
            oNode = Me.UltraTree1.SelectedNodes(0)
            Me.SelectNode(oNode)
        End If
    End Sub

    Private Sub UltraTabControl3_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl3.SelectedTabChanged
        If myUtils.IsInList(e.Tab.Key, "params") AndAlso Me.FileName.Trim.Length > 0 Then
            If Not ((myDWG.AppTriedAc) AndAlso (provider Is Nothing)) Then
                Me.TryInitCADProvider()
                If provider Is Nothing Then
                    Me.UltraTabControl3.Tabs("params").Visible = False
                Else
                    If (paramdirty) OrElse myView.mainGrid.myDS.Tables(0).Rows.Count = 0 Then Me.GetParams(Me.LoadedFile, True)
                    paramdirty = False
                End If
            End If
        ElseIf e.Tab.Index = 0 Then
            fView.Size = New Drawing.Size(10, 10)
        End If
    End Sub


    Public Function FileBlockName() As String Implements IDoc.FileBlockName
        Return myUtils.cStrTN(Me.BlockName)

    End Function
    Public Function LoadedFile() As String Implements IDoc.LoadedFile
        Return mLoadedFile
    End Function
    Public Function UploadedFileLocalPath() As String Implements IDoc.UploadedFileLocalPath
        Dim filename As String = Me.CtlUpLoad1.TextFileName.Text
        If Not System.IO.Path.IsPathRooted(filename) Then filename = System.IO.Path.Combine(myWinApp.objAppExtender.FileServerPath, filename)
        Return filename

    End Function
    Public Function FileName() As String Implements IDoc.FileName
        Return myUtils.cStrTN(Me.CtlUpLoad1.TextFileName.Text)

    End Function
    Protected Overrides Sub OnFrmModeChanged(value As EnumfrmMode)
        If fM IsNot Nothing Then
            Dim str1 As String = If(value = EnumfrmMode.acEditM, "compdef_" & fM.myRow("tfcompdefid").ToString & "_" & myWinFtp.ReplaceSpecialChars(myUtils.cStrTN(fM.myRow("compdefcode"))) & "." & "ext", "")
            Me.CtlUpLoad1.InitFilter(value, str1, myUtils.cStrTN(fM.myRow("compfilename")), "acad", "DWG Files|*.dwg|DXF Files|*.dxf", "ucad")
            Me.CtlUpLoad1.SetupUCAD(myDWG.InProcACAD, False)
        End If
    End Sub

    Public Function CompFileTextBox() As Object Implements IDoc.CompFileTextBox
        Return Me.CtlUpLoad1.TextFileName
    End Function
End Class