Imports System.Windows.Forms
Imports risersoft.app.mxent
Imports risersoft.app.mxform.eto
Imports risersoft.shared.Extensions
Public Class frmTFCompDefBase
    Inherits frmMax
    Implements IfrmDef
    Public fDoc As frmMax, fPrmList As frmTFCompDefParamList, dsCompDef As DataSet, myVueAct As New clsWinView, oWO As clsWOInfoBase, CompType As String
    Protected Friend myVueBOM, myVuePrint, myVueEnt, myVueCalc As New clsWinView
    Protected Friend mvDTCols, mvDefDTR, mvBlankDTR, mvStdFF, mvShots As New clsWinView
    Dim oSort, oSortC As clsWinSort, dvCol As DataView
    Protected Friend pnl As Panel, IsDevApp As Boolean, objCompDef As clsTFCompDefBase


    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.initForm()
    End Sub

    Public Overridable Sub InitViewer2D()
    End Sub

    Public Overridable Sub InitViewer3D()
    End Sub

    Public Sub initForm()
        If Not myWinApp() Is Nothing Then myWinApp.objAppExtender.InitDesignData(Me.Controller, False)
        myVueCalc.SetGrid(Me.UltraGrid2)
        myVueBOM.SetGrid(Me.UltraGrid3)
        myView.SetGrid(Me.UltraGrid7)
        myVueEnt.SetGrid(Me.UltraGrid4)
        myVueAct.SetGrid(Me.UltraGrid8)
        mvDTCols.SetGrid(Me.UltraGrid9)
        mvDefDTR.SetGrid(Me.UltraGrid11)
        mvBlankDTR.SetGrid(Me.UltraGrid12)
        mvStdFF.SetGrid(Me.UltraGrid10)
        mvShots.SetGrid(Me.UltraGrid13)
        myVuePrint.SetGrid(Me.UltraGrid1)

        fPrmList = New frmTFCompDefParamList With {.fp = Me}
        fPrmList.AddtoTab(Me.UltraTabControl1, "param", True)
        AddHandler fPrmList.UltraTabControlParam.SelectedTabChanged, AddressOf UltraTabControl1_Param_SelectedTabChanged

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        objCompDef = New clsTFCompDefBase(Me.Controller)
        oSort = New clsWinSort(myVueBOM, Me.btnUp, Me.btnDown, Me.btnRenumber, "sortindex")
        oSortC = New clsWinSort(myView, Me.btnMoveUpChild, Me.btnMoveDownChild, Me.btnRenumChild, "sortindex")
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Me.cmb_IntDesignCode.ValueList = Me.Model.ValueLists("IntDesignCode").ComboList
            Me.cmb_ParamBehave.ValueList = Me.Model.ValueLists("ParamBehave").ComboList

            If Not myWinApp() Is Nothing Then
                Me.cmb_DefGroup.ValueList = Me.Model.ValueLists("DefGroup").ComboList
                Me.cmb_ViewName.ValueList = Me.Model.ValueLists("ViewName").ComboList
            End If

            myWinSQL.AssignCmb(Me.dsCombo, "CompType", "", Me.cmb_CompType)

            Me.LoadPIDU(WinParamUtils.GetCurrPIDUNitID(Me.Controller), False)
            If myUtils.cValTN(Me.CopyIDX) > 0 Then
                myUtils.CopyRows(Me.Model.DatasetCollection("TFCompDefParam").Tables(0).Select, fPrmList.myView.mainGrid.myDS.Tables(0))
            End If

            'PrepForm2D3D moved up because refreshcompgrid needs comp2d Value
            Me.PrepForm2D3D(myUtils.cStrTN(myRow("comptype")))
            myView.PrepEdit(NewModel.GridViews("Det"))

            Me.reFreshCompGrid(False)
            oSortC.reSort()

            If myUtils.IsInList(myUtils.cStrTN(myRow("CompType")), "ASY") Then mvStdFF.PrepEdit(NewModel.GridViews("StdFF"))
            If myUtils.cValTN(myRow("dtbased")) = 1 Then
                Me.UltraTabControl2.Tabs("file").Visible = False
                For Each str1 As String In New String() {"rules", "material", "ent"}
                    Me.UltraTabControl1.Tabs(str1).Visible = False
                Next

                mvDTCols.PrepEdit(NewModel.GridViews("DTCols"))
                mvDTCols.mainGrid.SelectRows(myUtils.cStrTN(myRow("DTDispColKeys")), "columnname")

                myWinSQL.AssignCmb(Me.dsCombo, "destab", "", Me.cmb_DesTableID)
                dvCol = myWinSQL.AssignCmb(Me.dsCombo, "dtcol", "", Me.cmb_DTSelColID,, 2)
            Else
                Me.UltraTabControl2.Tabs("destab").Visible = False
                Me.UltraTabControl1.Tabs("tabrows").Visible = False

                myVueBOM.PrepEdit(NewModel.GridViews("BOM"))
                myVueCalc.PrepEdit(NewModel.GridViews("VOL"))
                oSort.reSort()

                myVueAct.PrepEdit(NewModel.GridViews("Act"))
                myVueEnt.PrepEdit(NewModel.GridViews("Ent"))
                mvShots.PrepEdit(NewModel.GridViews("Shots"))
                If Not fDoc Is Nothing Then fDoc.PrepForm(Me)
            End If

            If myUtils.cValTN(Me.CopyIDX) > 0 Then
                myUtils.CopyRows(Me.Model.DatasetCollection("TFCompDefDetBOM").Tables(0).Select, myVueBOM.mainGrid.myDS.Tables(0))
            End If
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim pidunitid As Integer = WinParamUtils.GetCurrPIDUNitID(Me.Controller)
        oWO = myPIDU.GenerateWOInfo(Me.Controller, pidunitid)
        If Me.oWO.rPIDU Is Nothing Then
            MsgBox("Work Order Selection is required", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        Else
            Me.InitData("", "", oview, prepMode, prepIdx, strXML)   'for vBag generation
            Me.vBag("PIDUnitID") = pidunitid
            strXML = Me.Controller.Data.VarBagXML(Me.vBag)

            Dim objModel As frmTFCompDefModel = Me.InitData("frmTFCompDefModel", oview, prepMode, prepIdx, strXML)
            If Me.BindModel(objModel, oview) Then

                'Until this is resolved
                Me.chk_RemoveConstraints.Visible = IsDevApp
                If myUtils.cValTN(myRow("intdesigncode")) > 0 Then
                    For Each ctl As Control In Me.Panel1.Controls
                        If Not ctl Is Me.txt_Descrip Then ctl.Enabled = IsDevApp
                    Next
                    For Each pnl As Panel In New Panel() {Me.PanelAction, Me.Panel3D, Me.Panel6, fPrmList.Panel7, Me.Panel8, Me.Panel9}
                        pnl.Enabled = False
                    Next
                    For Each pnl As Panel In New Panel() {fPrmList.PanelMove, Me.Panelbtn}
                        'maxapp can be commented when editing for unitcad db.
                        pnl.Enabled = IsDevApp
                    Next
                    If Not fDoc Is Nothing Then fDoc.Enabled = IsDevApp
                Else
                    'below are disabled by default due to possibility of use elsewhere.
                    For Each pnl As Panel In New Panel() {fPrmList.PanelMove, fPrmList.Panel7}
                        pnl.Enabled = True
                    Next
                End If

                Me.CalcInherit()
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Sub PrepForm2D3D(ByVal mCompType As String)
        CompType = mCompType
        Me.UltraTabControlRules.Tabs("action").Visible = myUtils.IsInList(mCompType, "asy", "blk")
        Me.UltraTabControl1.Tabs("comp").Visible = myUtils.IsInList(mCompType, "asy", "blk")
        Me.UltraTabControlRules.Tabs("snapshot").Visible = myUtils.IsInList(mCompType, "asy", "blk")
        Me.UltraTabControl1.Tabs("stdff").Visible = myUtils.IsInList(mCompType, "asy")
        Me.UltraTabControl1.Tabs("ent").Visible = myUtils.IsInList(mCompType, "asy")
        Me.UltraTabControlMat.Tabs("bom").Visible = myUtils.IsInList(mCompType, "asy", "blk", "prm")
        Me.UltraTabControlMat.Tabs("vol").Visible = myUtils.IsInList(mCompType, "asy", "blk", "prm")
        Me.PanelAction.Visible = myUtils.IsInList(mCompType, "asy")
        utcDim.Visible = myUtils.IsInList(mCompType, "asy", "blk")
        Me.chk_CreateNewASM.Visible = myUtils.IsInList(mCompType, "asy", "blk")

        IsDevApp = myWinPolice.IsAllowedUser("abhishek.singhal", "") AndAlso (Debugger.IsAttached)
        'Visibility controlled here but view etc controlled in prepform etc
        Select Case mCompType.Trim.ToUpper
            Case "BLK"
                Me.utcDim.Tabs("2d").Selected = True
                Me.cmb_IntDesignCode.Enabled = IsDevApp
                Me.chk_CreateNewASM.Text = "Create Containing Block Definition for this component definition"
                If fDoc Is Nothing Then Me.InitViewer2D()
            Case "ASY"
                utcDim.Tabs("3d").Selected = True
                Me.chk_CreateNewASM.Text = "Create Containing Assembly document"
                If fDoc Is Nothing Then Me.InitViewer3D()
        End Select

        If (Not fDoc Is Nothing) AndAlso (fDoc.uTab Is Nothing) Then
            fDoc.AddtoTab(Me.UltraTabControl2, "file", True)
        End If
    End Sub

    Public Sub reFreshCompGrid(ByVal refresh As Boolean)
        Dim dtComp As DataTable
        If refresh Then RefreshGrid(myView, "det", frmIDX)
        If refresh OrElse (dsCompDef Is Nothing) Then dsCompDef = myIntent.LoadComponentDefData(Me.Controller, True)
        dtComp = dsCompDef.Tables(0)
        myView.mainGrid.SetColLookup("childcompdefid", dtComp, "", , "Code", "CompdefCode", "tfcompdefid")
        myView.mainGrid.SetColLookup("defid2", dtComp, "", , "Description", "Descrip", "tfcompdefid")
    End Sub


    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        WinFormUtils.InitTabBacks(Me.UltraTabControl1)

        If Me.ValidateData() Then
            myFuncsTFCD.SetCompFileName(Me.Controller, TryCast(fDoc, IDoc), myRow.Row, myUtils.cStrTN(myRow("CompType")))
            If myUtils.IsInList(myUtils.cStrTN(myRow("CompType")), "BLK") Then
                If myUtils.cStrTN(myRow("CompFileName")).Trim.Length > 0 AndAlso myUtils.cStrTN(myRow("BlockName")).Trim.Length = 0 Then WinFormUtils.AddError(CType(fDoc, IDoc).CompFileTextBox, "Select Block", Me.eBag)
            End If
            If Me.CanSave Then
                If Me.SaveModel() Then
                    fPrmList.frmIDX = Me.frmIDX     'just in case myVueGrp is refreshed.
                    VSave = Me.OnFormVSave
                    Return True
                End If
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Public Overridable Function OnFormVSave() As Boolean
        Return True
    End Function

    Protected Friend Sub HandleParams()

        'Common for 2D and 3D
        If (Not fDoc Is Nothing) AndAlso fDoc.FormPrepared Then
            myIntent.UpdateParamMapping(fDoc.myView.mainGrid.myDS.Tables(0), fPrmList.myView.Model, fPrmList.mvInheritParam.Model, fPrmList.mvGloParam.Model)
            If fDoc.myView.mainGrid.myDS.Tables(0).Select.Length > 0 Then
                If fDoc.myView.mainGrid.myDS.Tables(0).Select(myUtils.CombineWhere(False, "isnull(mapok,0)=0", fDoc.myView.mainGrid.myDv.RowFilter)).Length = 0 Then
                    pnl.BackColor = System.Drawing.Color.Green
                Else
                    pnl.BackColor = System.Drawing.Color.Red
                End If
            Else
                pnl.BackColor = Me.BackColor
            End If
        End If
    End Sub

    Private Sub UltraTabControl1_Param_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs)
        If myUtils.IsInList(e.Tab.Key, "local", "grp") Then
            Me.Panelbtn.Visible = True
        Else
            Me.Panelbtn.Visible = False
        End If
    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        If myUtils.IsInList(e.Tab.Key, "comp", "ent") Then
            Me.Panelbtn.Visible = False
        Else
            Me.Panelbtn.Visible = True
        End If
        If myUtils.IsInList(e.Tab.Key, "tabrows") Then Me.MakeDTR()
    End Sub

    Private Sub MakeDTR()
        Dim Params As New List(Of clsSQLParam)
        mvDTCols.mainGrid.myGrid.UpdateData()
        Params.Add(New clsSQLParam("@TfCompDefId", myUtils.cValTN(frmIDX), GetType(Integer), False))
        Params.Add(New clsSQLParam("@DesTableCode", "'" & myUtils.cStrTN(Me.txt_DesTableCode.Text).Trim & "'", GetType(String), False))
        Params.Add(New clsSQLParam("@ColumnNameCSV", myUtils.MakeCSV(mvDTCols.mainGrid.myDS.Tables(0).Select("sysIncl = 1"), "ColumnName", ",", "''", True), GetType(String), True))
        Dim dic As clsCollecString(Of clsViewModel) = Me.GenerateParamsModelCollec("makedtr", Params)
        mvDefDTR.PrepEdit(dic("DefDTR"))
        mvBlankDTR.PrepEdit(dic("BlankDTR"))
        mvDefDTR.mainGrid.SetColLookup("childcompdefid", dsCompDef.Tables(0), "", , "Code", "CompdefCode", "tfcompdefid")
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim f As frmMax = Nothing, oView As clsWinView = Nothing, Key As String = ""

        If Me.VSave Then
            Me.SetChildFormObjects(sender, f, oView, "", Key)
        End If

        If (Not f Is Nothing) AndAlso (Not oView Is Nothing) Then
            oView.ContextRow = oView.mainGrid.ActiveRow

            If f.PrepForm(oView, EnumfrmMode.acAddM, "", "<PARAMS TFCOMPDEFID=""" & frmIDX & """/>") Then
                f.ShowDialog(Me)
                If f.DoRefresh Then RefreshGrid(oView, Key, myUtils.cValTN(frmIDX))

                If TypeOf f Is frmTFCompDefParam Then Me.CalcInherit()
                If TypeOf f Is frmTFCompDefDTR Then Me.MakeDTR()
                If TypeOf f Is frmTFCompDefChild Then Me.OnChildEdit()
            End If
        End If
    End Sub

    Private Sub OnChildEdit()
        Me.reFreshCompGrid(True)
        Me.CalcInherit()
        RefreshGrid(myVueAct, "act", myUtils.cValTN(frmIDX))
        'Automatic renumbering 08-May-2012
        oSortC.renumber()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click, btnCopy.Click
        Dim f As frmMax = Nothing, oView As clsWinView = Nothing, str1 As String = "", ChildMode As EnumfrmMode = EnumfrmMode.acEditM, Key As String = ""
        If frmMode = EnumfrmMode.acEditM Then
            If sender Is btnCopy Then ChildMode = EnumfrmMode.acCopyM
            Me.SetChildFormObjects(sender, f, oView, str1, Key)
        Else
            MsgBox("First save then proceed.", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
        If (Not f Is Nothing) AndAlso (Not oView Is Nothing) Then
            oView.ContextRow = oView.mainGrid.ActiveRow
            If Not oView.ContextRow Is Nothing Then
                If f.PrepForm(oView, ChildMode, myUtils.cValTN(oView.ContextRow.CellValue(str1))) Then
                    f.ShowDialog(Me)
                    If f.DoRefresh Then RefreshGrid(oView, Key, myUtils.cValTN(frmIDX))

                    If TypeOf f Is frmTFCompDefParam Then
                        Me.CalcInherit()
                    End If
                    If TypeOf f Is frmTFCompDefDTR Then Me.MakeDTR()
                    If TypeOf f Is frmTFCompDefChild Then Me.OnChildEdit()
                End If
            End If
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim oView As clsWinView = Nothing, str1 As String = "", Key As String = ""
        If frmMode = EnumfrmMode.acEditM Then
            Me.SetChildFormObjects(sender, Nothing, oView, str1, Key)
        Else
            MsgBox("First save then proceed.", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
        If (Not oView Is Nothing) Then
            oView.ContextRow = oView.mainGrid.ActiveRow
            If Not oView.ContextRow Is Nothing Then
                If str1.Trim.Length > 0 Then
                    If MsgBox("Are you sure?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                        RefreshGrid(oView, Key, myUtils.cValTN(oView.ContextRow.CellValue(str1)))
                    End If
                Else
                    oView.mainGrid.ButtonAction("del")
                End If
            End If
        End If
    End Sub

    Protected Friend Sub btnCopyUnused_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'doesnt copy attributes
        For Each r1 As DataRow In fDoc.myView.mainGrid.myDS.Tables(0).Select("isnull(mapok,0)=0")
            Dim nrp = myParams.AddUpdParam(fPrmList.myView.mainGrid.myDS.Tables(0), r1("paramcode"), GetType(Decimal), DBNull.Value)
            nrp("formula") = myUtils.cValTN(r1("modelvalue"))
        Next
        Me.HandleParams()
    End Sub

    Private Sub cmb_DesTableID_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_DesTableID.ValueChanged
        If Me.FormPrepared AndAlso myUtils.cValTN(myRow("dtbased")) = 1 Then
            dvCol.RowFilter = "destableid=" & myUtils.cValTN(Me.cmb_DesTableID.Value)
            mvDTCols.mainGrid.myDv.RowFilter = "destableid=" & myUtils.cValTN(Me.cmb_DesTableID.Value)
            If Not Me.cmb_DesTableID.SelectedRow Is Nothing Then Me.txt_DesTableCode.Text = Me.cmb_DesTableID.SelectedRow.Cells("tablecode").Value
        End If
    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        Dim oView As clsWinView = Nothing, sql As String = "", str1 As String = ""
        Dim mmrXML As String = ""
        If Me.VSave Then
            Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
                Case "param"
                    oView = fPrmList.myView
                    oView.mainGrid.MainConf("strview") = "Local Parameters"
                Case "rules"
                    Select Case Me.UltraTabControlRules.SelectedTab.Key.Trim.ToLower
                        Case "action"
                            Dim Params As New List(Of clsSQLParam)
                            Params.Add(New clsSQLParam("@CompType", "'" & myUtils.cStrTN(myRow("CompType")) & "'", GetType(String), False))
                            Dim Model As clsViewModel = Me.GenerateParamsModel("act", Params)
                            myVuePrint.PrepEdit(Model)
                            oView = myVuePrint
                            oView.mainGrid.MainConf("strview") = "Action Rules"
                            mmrXML = "<MMR><GROUP FIELD=""Descrip"" TYPE=""2""/></MMR>"
                        Case "snapshot"
                            oView = Me.mvShots
                        Case "child"
                            Dim Params As New List(Of clsSQLParam)
                            Params.Add(New clsSQLParam("@TfCompDefId", myUtils.cValTN(frmIDX), GetType(Integer), False))
                            Dim Model As clsViewModel = Me.GenerateParamsModel("det", Params)
                            myVuePrint.PrepEdit(Model)
                            oView = Me.myVuePrint
                            oView.mainGrid.MainConf("strview") = "Child Rules"
                    End Select
                Case "material"
                    Select Case Me.UltraTabControlMat.SelectedTab.Key.Trim.ToLower
                        Case "bom"
                            oView = myVueBOM
                            oView.mainGrid.MainConf("strview") = "BOM Rules"
                    End Select
                Case "tabrows"
                    oView = Me.mvDefDTR
                Case "stdff"
                    oView = Me.mvStdFF
            End Select
        End If
        If (Not oView Is Nothing) Then
            If mmrXML.Trim.Length > 0 Then
                Me.Controller.PrintingPress.GenerateAndShowReport(oView, EnumPrintWhat.acMMR, mmrXML)
            Else
                Me.Controller.PrintingPress.GenerateAndShowReport(oView, , mmrXML)
            End If
        End If
    End Sub
    Protected Friend Sub SetChildFormObjects(sender As Object, ByRef f As frmMax, ByRef oView As clsWinView, ByRef str1 As String, ByRef key As String)

        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "param"
                Select Case fPrmList.UltraTabControlParam.SelectedTab.Key.Trim.ToLower
                    Case "local"
                        f = New frmTFCompDefParam
                        oView = fPrmList.myView
                        str1 = "tfcompdefparamid"
                        key = "local"
                    Case "grp"
                        f = New frmTFCompDefParamGrp
                        oView = fPrmList.myVueGrp
                        str1 = "tfcompdefparamgrpid"
                        key = "grp"
                End Select
                If sender Is btnDel Then str1 = ""
            Case "rules"
                Select Case Me.UltraTabControlRules.SelectedTab.Key.Trim.ToLower
                    Case "child"
                        f = New frmTFCompDefChild
                        oView = Me.myView
                        str1 = "tfcompdefdetbomid"
                        key = "det"
                    Case "action"
                        f = New frmTFCompDefActPack
                        oView = Me.myVueAct
                        str1 = "tfcompdefactpackid"
                        key = "act"
                    Case "snapshot"
                        f = New frmTFCompDefShot
                        oView = Me.mvShots
                        str1 = "tfcompdefshotid"
                        key = "shot"
                End Select
            Case "material"
                Select Case Me.UltraTabControlMat.SelectedTab.Key.Trim.ToLower
                    Case "bom"
                        f = New frmTFCompDefBOM
                        oView = Me.myVueBOM
                        str1 = "tfcompdefdetbomid"
                        key = "bom"
                    Case "vol"
                        f = New frmTFCompDefCalcItemWV
                        oView = Me.myVueCalc
                        str1 = "tfcompdefcalcid"
                        key = "calc"
                        If sender Is btnDel Then str1 = ""
                End Select
            Case "tabrows"

                f = New frmTFCompDefDTR
                If sender Is btnAdd Then
                    oView = Me.mvBlankDTR
                ElseIf sender Is btnEdit Then
                    oView = Me.mvDefDTR
                End If

                str1 = "tfcompdefdetbomid"
                key = "tabrows"
            Case "stdff"
                If sender Is btnAdd Then
                    If Me.FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop Then
                        Me.FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.DesktopDirectory
                        Me.FolderBrowserDialog1.SelectedPath = myWinApp.objAppExtender.FileServerPath
                    End If
                    If Me.FolderBrowserDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                        Dim nr As DataRow = mvStdFF.mainGrid.myDS.Tables(0).NewRow
                        nr("foldername") = myPathUtils.RelativePathTo(myWinApp.objAppExtender.FileServerPath, Me.FolderBrowserDialog1.SelectedPath)
                        mvStdFF.mainGrid.myDS.Tables(0).Rows.Add(nr)
                    End If
                ElseIf sender Is btnDel Then
                    oView = mvStdFF
                End If
                key = "stdff"

        End Select
        If sender Is btnDel Then key = "del" & key
    End Sub
    Private Sub CtlPIDUnitID1_PIDUnitIDChanged(ByVal currpidunitid As Integer) Handles CtlPIDUnitID1.PIDUnitIDChanged
        Me.LoadPIDU(currpidunitid, True)
        Me.CalcInherit()
    End Sub

    Public Sub LoadPIDU(pidunitid As Integer, OnCtlPIDUChange As Boolean)
        oWO = myPIDU.GenerateWOInfo(Me.Controller, pidunitid)
        CtlPIDUnitID1.LoadPIDU(oWO)
        fPrmList.LoadPIDU(myRow.Row, "tfcompdefid", oWO, OnCtlPIDUChange)
    End Sub



    Public ReadOnly Property oWOInfo As clsWOInfoBase Implements IfrmDef.oWOInfo
        Get
            Return oWO
        End Get
    End Property

    Public ReadOnly Property dtAllDefParams As System.Data.DataTable Implements IfrmDef.dtAllDefParams
        Get
            Return fPrmList.dtAllCompDefParams
        End Get
    End Property

    Public ReadOnly Property dtAllParams As System.Data.DataTable Implements IfrmDef.dtAllParams
        Get
            Return fPrmList.dtAllParams
        End Get
    End Property



    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        Dim oExim As New clsEXIM(Me.Controller)
        oExim.ExportComponent(myRow.Row, Me.dsCompDef)
    End Sub

    Public Sub CalcInherit()
        If myUtils.cValTN(myRow("dtbased")) = 1 Then
            myWinSQL.AssignCmb(fPrmList.myView.mainGrid.myDS, "table", "", Me.cmb_DTLocalParamCode, , , True)
        End If
        fPrmList.CalcInherit(myRow.Row, "tfcompdefid", Me.dsCompDef, myView.mainGrid.myDS.Tables(0))
    End Sub

    Public Overridable ReadOnly Property DefType As String Implements IfrmDef.DefType
        Get
            Return "comp"
        End Get
    End Property

    Public ReadOnly Property DefSubType As String Implements IfrmDef.DefSubType
        Get
            Return myUtils.cStrTN(myRow("CompType"))
        End Get
    End Property

    Private Sub RefreshGrid(View As clsWinView, key As String, ID As Integer)
        If Not myUtils.IsInList(key.Trim.ToLower, "tabrows") Then
            Dim oRet As New clsProcOutput
            If myUtils.IsInList(key.Trim.ToLower, "act") Then
                Dim Params As New List(Of clsSQLParam)
                Params.Add(New clsSQLParam("@TfCompDefId", myUtils.cValTN(frmIDX), GetType(Integer), False))
                oRet = GenerateParamsOutput("act", Params)
            ElseIf myUtils.IsInList(key.Trim.ToLower, "deldet", "delbom", "delact", "delshot") Then
                Dim Params As New List(Of clsSQLParam)
                Params.Add(New clsSQLParam("@SqlID", myUtils.cValTN(ID), GetType(Integer), False))
                Params.Add(New clsSQLParam("@TfCompDefId", myUtils.cValTN(frmIDX), GetType(Integer), False))
                oRet = GenerateParamsOutput(key.Trim.ToLower, Params)
            Else
                oRet = Me.GenerateIDOutput(key.Trim.ToLower, ID)
            End If

            If oRet.Success Then
                If myUtils.IsInList(key.Trim.ToLower, "deltabrows") Then
                    Me.MakeDTR()
                Else
                    Me.UpdateViewData(View, oRet)
                    If myUtils.IsInList(key.Trim.ToLower, "det") Then oSortC.reSort()
                    If myUtils.IsInList(key.Trim.ToLower, "bom") Then oSort.reSort()
                    If myUtils.IsInList(key.Trim.ToLower, "deldet") Then OnChildEdit()
                End If
            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub
End Class
