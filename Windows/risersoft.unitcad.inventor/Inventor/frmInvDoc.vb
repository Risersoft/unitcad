Imports risersoft.unitcad

Public Class frmInvDoc
    Implements IDoc

    Public Event DocParamChanged()
    Public fM As frmMax, fCompDef As frmTFCompDefBase, paramdirty As Boolean = False
    Public oNewDoc As Inventor.Document
    Public fView As frmMax, provider As ICADServer3D, oTree As clsWinTree, objModel As clsTreeModel
    Dim mLoadedFile As String = ""
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        initForm()
    End Sub
    Public Sub initForm()
        Dim sql As String, r As DataRow, i As Integer, dt As DataTable

        Me.FormPrepared = False
        myView.SetGrid(Me.UltraGrid5)
        oTree = New clsWinTree(Me.UltraTree1, Nothing)
        fView = myWinApp.objAppExtender.fViewer3D
        If fView Is Nothing Then
            Me.UltraTabControl3.Tabs(0).Visible = False
        Else
            fView.AddtoTab(Me.UltraTabControl3, "view", True)
            fView.BringToFront()
        End If
        AddHandler Me.UltraTabControl3.SelectedTabChanged, AddressOf UltraTabControl3_SelectedTabChanged
        AddHandler CtlUpLoad1.btnRefresh.Click, AddressOf btnRefreshTree_Click
        AddHandler CtlUpLoad1.btnShowApp.Click, AddressOf btnShow_Click
        AddHandler CtlUpLoad1.btnUpdate.Click, AddressOf btnUpdate_Click
        AddHandler CtlUpLoad1.NewFileLoaded, AddressOf LoadFile
        AddHandler CtlUpLoad1.FileUploaded, AddressOf FileUploaded
        AddHandler CtlUpLoad1.FileSelected, AddressOf FileSelected
    End Sub
    Public Overrides Function PrepForm(ByVal f As frmMax) As Boolean


        myView.mainGrid.MainConf("FORMATXML") = "<COL KEY=""MapType"" CAPTION=""Mapping"" VLIST=""0;Not Found|1;Local|2;Inherited|3;Global""/>"
        myView.mainGrid.MainConf("showrownumber") = True
        myView.mainGrid.BindView(myUtils.MakeDSfromTable(myIAM.dtBlankDocParams, False), , 0)
        myView.mainGrid.QuickConf("", True, "1-1-1-1-1-1-1", True, "Document Parameters")
        'myView.mainGrid.myDv.RowFilter = "isuser=1"

        Me.txt_TestFormula.CtlFormulaChk1.ParamsLoaded = True
        'parameters will be loaded when "Calc Parameters" button is pressed
        'this is to allow user to check to get actual values.
        Me.txt_TestFormula.InitFCheck(Nothing, Nothing, "")

        fM = f
        Me.frmMode = f.frmMode


        'dont use apprentice server component from inside inventor
        'http://modthemachine.typepad.com/my_weblog/2013/03/inventor-api-training-lesson-12.html
        If f.frmMode = EnumfrmMode.acAddM AndAlso myDWG.InProcInv AndAlso (Not myIAM.mApp.ActiveDocument Is Nothing) Then
            Me.LoadFile(myPathUtils.RelativePathTo(myWinApp.objAppExtender.FileServerPath, myIAM.mApp.ActiveDocument.FullFileName))
        Else
            Dim str1 As String = myUtils.cStrTN(f.myRow("compfilename"))
            Me.LoadFile(str1)
        End If

        If TypeOf f Is frmTFCompDefBase Then fCompDef = f Else fCompDef = Nothing
        If myIAM.mApp Is Nothing Then myDWG.AppTriedIv = False
        Me.FormPrepared = True
    End Function
    Friend Sub FileSelected(ByVal filename As String)
        If myUtils.EndsWith(filename, ".zip") Then
            Dim lst = myZipFile.LoadDBZipFileEntries(filename, 1)

            lst = lst.Where(Function(x)
                                Return myUtils.EndsWith(x, ".iam")
                            End Function).ToList
            If lst.Count > 1 Then lst = lst.Where(Function(x)
                                                      Dim arr() As String = Split(x, "/")
                                                      Return Not myUtils.StartsWith(arr(arr.Length - 1), "std")
                                                  End Function).ToList
            If lst.Count <> 1 Then Throw New Exception("Zip File does not contain a top level assembly.")
        End If
    End Sub

    Friend Overloads Sub FileUploaded(localFile As String, serverPath As String)
        Dim newFile As String = System.IO.Path.Combine(myWinApp.objAppExtender.FileServerPath, serverPath.Replace("/", "\"))
        My.Computer.FileSystem.CopyFile(localFile, newFile, True)
        Me.LoadFile(serverPath)
    End Sub
    Friend Async Sub LoadFile(ByVal filename As String)


        Dim localfile As String = Me.CtlUpLoad1.oFiler.FileProvider.DownloadAndUnzipFile(filename, "*.iam", "std")

        If System.IO.File.Exists(localfile) Then
            mLoadedFile = localfile
            Try
                Me.TryInitCADProvider()
                Dim model As clsTreeModel = Nothing
                If myDWG.InProcInv Then
                    Me.GetParams(localfile, True)
                    model = myIAM.BuildInventorTree(Me.Controller, localfile)
                ElseIf (Not fView Is Nothing) Then
                    If CType(fView, IViewer).CurrFile <> localfile Then
                        CType(fView, IViewer).OpenFile(localfile)
                        model = CType(fView, IViewer).GenerateTreeModel
                    End If
                    Me.GetParams(localfile, True)
                End If
                oTree.BindModel(model)
                objModel = model
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
            paramdirty = True
        Else
            mLoadedFile = ""
            If Not fView Is Nothing Then
                CType(fView, IViewer).OpenFile("")
            End If

        End If
    End Sub
    Public Sub TryInitCADProvider()
        provider = myDWG.objAddIn3d
        If (provider Is Nothing) AndAlso (myDWG.InProcInv OrElse (Not myDWG.AppTriedIv)) Then
            provider = myWinApp.objAppExtender.CADProvider3D(Me.Controller, AddressOf Me.Controller.HandleCallBack, 0)
        End If
    End Sub

    Private Sub GetParams(ByVal filename As String, ByVal doget As Boolean)
        myDWG.GetSet3DParams(filename, myView.mainGrid.myDS.Tables(0), doget)
        RaiseEvent DocParamChanged()

    End Sub
    Private Sub btnRefreshTree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Me.LoadFile(Me.FileName)

    End Sub

    Private Sub UltraTabControl3_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs)
        If Me.FormPrepared AndAlso myUtils.IsInList(e.Tab.Key, "params") AndAlso Me.FileName.Trim.Length > 0 Then
            If Not ((myDWG.AppTriedIv) AndAlso (myIAM.mApp Is Nothing)) Then
                Me.TryInitCADProvider()
                If provider Is Nothing Then
                    Me.UltraTabControl3.Tabs("params").Visible = False
                Else
                    If (paramdirty) OrElse myView.mainGrid.myGrid.Rows.Count = 0 Then Me.GetParams(Me.LoadedFile, True)
                    paramdirty = False
                End If
            End If
        End If
    End Sub


    Private Sub btnPrintDocParams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintDocParams.Click
        Me.Controller.PrintingPress.GenerateAndShowReport(myView)
    End Sub


    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oDoc As Inventor.Document
        If Not myIAM.oInvApp(Me.Controller) Is Nothing Then
            myIAM.oInvApp(Me.Controller).Visible = True
            If myIAM.oInvApp(Me.Controller).Documents.VisibleDocuments.Count > 1 Then
                oDoc = myIAM.oInvApp(Me.Controller).ActiveDocument
                myIAM.oInvApp(Me.Controller).Documents(1).Activate()
                myIAM.oInvApp(Me.Controller).Documents(2).Activate()
                oDoc.Activate()
            End If
        End If

    End Sub


    Private Sub btn_CalcParams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CalcParams.Click
        If Not fCompDef Is Nothing Then
            myParams.CalcFormulas(Me.txt_TestFormula.CtlFormulaChk1.cManager, fCompDef.dtAllParams)
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

        Me.GetParams(Me.LoadedFile, False)
        If Not myIAM.mApp Is Nothing Then
            myIAM.mApp.Visible = True
        End If
    End Sub

    Public Function BlockName() As String Implements IDoc.FileBlockName
        Return ""
    End Function
    Public Function UploadedFileLocalPath() As String Implements IDoc.UploadedFileLocalPath
        Dim filename As String = Me.CtlUpLoad1.TextFileName.Text
        If Not System.IO.Path.IsPathRooted(filename) Then filename = System.IO.Path.Combine(myWinApp.objAppExtender.FileServerPath, filename)
        Return filename
    End Function
    Public Function FileName() As String Implements IDoc.FileName
        Return Me.CtlUpLoad1.TextFileName.Text
    End Function

    Public Function CompFileTextBox() As Object Implements IDoc.CompFileTextBox
        Return Me.CtlUpLoad1.TextFileName
    End Function
    Protected Overrides Sub OnFrmModeChanged(value As EnumfrmMode)
        Dim str1 As String
        If TypeOf fM Is IDefChild Then
            Dim f As frmMax = CType(fM, IDefChild).fp
            str1 = If(value = EnumfrmMode.acEditM, "compdef_" & f.myRow("tfcompdefid").ToString & "_" & fM.myRow("tfcompdefdetbomid").ToString & "_" & myWinFtp.ReplaceSpecialChars(myUtils.cStrTN(f.myRow("compdefcode"))) & "." & "ext", "")
        Else
            str1 = If(value = EnumfrmMode.acEditM, "compdef_" & fM.myRow("tfcompdefid").ToString & "_" & myWinFtp.ReplaceSpecialChars(myUtils.cStrTN(fM.myRow("compdefcode"))) & "." & "ext", "")
        End If
        Me.CtlUpLoad1.InitFilter(value, str1, myUtils.cStrTN(fM.myRow("compfilename")), "inv", "Part Files|*.ipt|Zip Files|*.zip", "ucad")
        Me.CtlUpLoad1.SetupUCAD(myDWG.InProcInv, True)
    End Sub

    Public Function LoadedFile() As String Implements IDoc.LoadedFile
        Return mLoadedFile
    End Function
    Private Async Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If oNewDoc Is Nothing Then oNewDoc = myIAM.mApp.ActiveDocument

        If (oNewDoc IsNot Nothing) AndAlso myUtils.IsInList(oNewDoc.FullFileName, mLoadedFile) Then
            oNewDoc.Save2(True)
            Dim LocalFile As String = Me.UploadedFileLocalPath
            Dim ServerFile As String = Me.CtlUpLoad1.CalculateServerFileName

            If myUtils.EndsWith(LocalFile, ".zip") Then
                Me.CtlUpLoad1.oFiler.FileProvider.ReCreateZip(LocalFile)
            End If
            Await Me.CtlUpLoad1.UploadFile(LocalFile, ServerFile)
        End If

    End Sub
End Class