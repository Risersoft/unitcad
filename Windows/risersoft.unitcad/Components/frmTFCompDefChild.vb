Imports risersoft.app.mxform.eto
Public Class frmTFCompDefChild
    Inherits frmMax
    Implements IDefChild
    Dim WithEvents codesys As New clsCodeSystem
    Dim myVueActPack As New clsWinView, dv As DataView
    Public fDef As IfrmDef

    Public Sub initForm()
        myView.SetGrid(UltraGrid1)
        myVueActPack.SetGrid(Me.UltraGrid2)

        WinFormUtils.SetButtonConf(btnOK, btnCancel, btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False

        Me.InitData("", "", oview, prepMode, prepIdx, strXML)   'for vBag generation
        If fDef Is Nothing Then fDef = Me.pView.fParentWin
        Me.vBag("CompType") = fDef.DefSubType
        Me.vBag("PIDUnitID") = WinParamUtils.GetCurrPIDUNitID(Me.Controller)
        strXML = Me.Controller.Data.VarBagXML(Me.vBag)

        Dim objModel As frmTFCompDefChildModel = Me.InitData("frmTFCompDefChildModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then

            Me.txt_CompDefCodeFormula.InitFCheck(fDef.dtAllParams, fDef.oWOInfo, "")
            Me.txt_QtyFormula.InitFCheck(fDef.dtAllParams, fDef.oWOInfo, "")
            Me.txt_NewNameFormula.InitFCheck(fDef.dtAllParams, fDef.oWOInfo, "")

            Me.cmb_ChildCompDefID.Value = myRow("childcompdefid")
            Me.codesys.HandleCombo(Me.cmb_ChildCompDefID, EnumWantEvent.acForceEvent)

            Me.PanelShot.Visible = myUtils.IsInList(fDef.DefSubType, "BLK") AndAlso (Debugger.IsAttached)
            Me.chk_CreateCopy.Visible = myUtils.IsInList(fDef.DefSubType, "ASY")
            If Me.CopyIDX.Trim.Length > 0 Then
                Dim dt1 As DataTable = Me.Model.DatasetCollection("TFCompDefBOMParam").Tables(0)
                myUtils.CopyRows(dt1.Select, myView.mainGrid.myDS.Tables(0))
            End If
            Me.setview(myUtils.cBoolTN(myRow("InheritActPack")), myUtils.cBoolTN(myRow("InheritParams")))

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("bom"),, btnDel)
            myVueActPack.PrepEdit(NewModel.GridViews("ActPack"))
            myVueActPack.mainGrid.HighlightRows()

            If myWinApp.objAppExtender.ProgramCode = "max" Then dv = myWinSQL.AssignCmb(Me.dsCombo, "ShotCode", "", Me.cmb_tfcompdefshotid, , 2)
            Me.codesys.SetConf(Me.dsCombo.Tables("CompDef"), Me.cmb_ChildCompDefID, Me.cmb_CompDefDescrip)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Me.DoRefresh = True
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub codesys_ItemChanged() Handles codesys.ItemChanged
        Dim val1 As Integer
        Me.HightlightParams()
        val1 = 0
        If Not Me.cmb_ChildCompDefID.SelectedRow Is Nothing Then val1 = myUtils.cValTN(Me.cmb_ChildCompDefID.SelectedRow.Cells("tfcompdefid").Value)
        myVueActPack.mainGrid.myDv.RowFilter = "tfcompdefid=" & val1
    End Sub

    Private Sub HightlightParams()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim f As frmTFCompDefChildParam = New frmTFCompDefChildParam
        If f.PrepForm(Me.myView, EnumfrmMode.acAddM, "") Then f.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim f As frmTFCompDefChildParam = New frmTFCompDefChildParam
        If f.PrepForm(Me.myView, EnumfrmMode.acEditM, "") Then f.ShowDialog()
    End Sub

    Private Sub chk_InheritParams_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_InheritParams.CheckedChanged
        Me.setview(Me.chk_InheritActPack.CheckState = System.Windows.Forms.CheckState.Checked, Me.chk_InheritParams.CheckState = System.Windows.Forms.CheckState.Checked)
    End Sub

    Private Sub btnCopyParams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyParams.Click
        Dim sr As DataRow = myWinUtils.DataRowFromGridRow(Me.cmb_ChildCompDefID.SelectedRow)
        Dim ds As DataSet = myIntent.LoadComponentDefData(Me.Controller, False)
        myFuncsTFCD.CopyChildParams(sr, ds, fDef.dtAllDefParams, myView)
    End Sub

    Private Sub chk_InheritActPack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_InheritActPack.CheckedChanged
        Me.setview(Me.chk_InheritActPack.CheckState = System.Windows.Forms.CheckState.Checked, Me.chk_InheritParams.CheckState = System.Windows.Forms.CheckState.Checked)
    End Sub

    Private Sub setview(bActPack As Boolean, bParam As Boolean)
        Me.UltraTabControl1.Tabs("qty").Visible = (Not bParam) AndAlso (Not bActPack)
        Me.UltraTabControl1.Tabs("newname").Visible = Me.UltraTabControl1.Tabs("qty").Visible
        Me.UltraTabControl1.Tabs("selec").Visible = Me.UltraTabControl1.Tabs("qty").Visible
        Me.UltraTabControl1.Tabs("param").Visible = Me.UltraTabControl1.Tabs("qty").Visible
        Me.UltraTabControl1.Tabs("act").Visible = bActPack
    End Sub

    Private Sub frmTFCompDefChild_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.setview()
    End Sub

    Private Sub cmb_ChildCompDefID_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_ChildCompDefID.ValueChanged
        Dim val1 As Integer
        If Me.PanelShot.Visible Then
            val1 = Me.cmb_tfcompdefshotid.Value
            dv.RowFilter = "tfCompDefId=" & myUtils.cValTN(Me.cmb_ChildCompDefID.Value)
            If val1 > 0 Then
                Me.cmb_tfcompdefshotid.Value = val1
                If Me.cmb_tfcompdefshotid.SelectedRow Is Nothing Then Me.cmb_tfcompdefshotid.Value = DBNull.Value
            End If
        End If
    End Sub

    Public ReadOnly Property fp As IfrmDef Implements IDefChild.fp
        Get
            Return fDef
        End Get
    End Property


    Public ReadOnly Property ItemNumber As String Implements IDefChild.ItemNumber
        Get
            Return myUtils.cStrTN(myRow("ItemNum"))
        End Get
    End Property
End Class
