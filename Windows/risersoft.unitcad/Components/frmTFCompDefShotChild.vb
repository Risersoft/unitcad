Imports risersoft.app.mxform.eto

Public Class frmTFCompDefShotChild
    Inherits frmMax
    Implements IDefChild
    Dim WithEvents codesys As New clsCodeSystem
    Public fDef As frmTFCompDefBase, fShot As frmTFCompDefShot

    Public Sub initForm()
        myView.SetGrid(UltraGrid1)
        WinFormUtils.SetButtonConf(btnOK, btnCancel, btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Me.InitData("", "", oview, prepMode, prepIdx, strXML)   'for vBag generation
        Me.vBag("PIDUnitID") = WinParamUtils.GetCurrPIDUNitID(Me.Controller)
        strXML = Me.Controller.Data.VarBagXML(Me.vBag)

        Dim objModel As frmTFCompDefShotChildModel = Me.InitData("frmTFCompDefShotChildModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            fShot = CType(Me.pView.fParentWin, frmTFCompDefShot)
            fDef = fShot.fp

            Me.txt_CompDefCodeFormula.InitFCheck(fDef.dtAllParams, fDef.oWOInfo, "")
            Me.txt_QtyFormula.InitFCheck(fDef.dtAllParams, fDef.oWOInfo, "")

            Me.cmb_ChildCompDefID.Value = myRow("childcompdefid")
            Me.codesys.HandleCombo(Me.cmb_ChildCompDefID, EnumWantEvent.acForceEvent)

            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("BOMParam"),, btnDel)
            If Me.CopyIDX.Trim.Length > 0 Then
                myUtils.CopyRows(Me.Model.DatasetCollection("TFCompDefBOMParam").Tables(0).Select, myView.mainGrid.myDS.Tables(0))
            End If

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

    Private Sub btnCopyParams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyParams.Click
        Dim sr As DataRow = myWinUtils.DataRowFromGridRow(Me.cmb_ChildCompDefID.SelectedRow)
        myFuncsTFCD.CopyChildParams(sr, fDef.dsCompDef, fDef.fPrmList.mvInheritParam.mainGrid.myDS.Tables(0), myView)
    End Sub

    Public ReadOnly Property fp As IfrmDef Implements IDefChild.fp
        Get
            Return fDef
        End Get
    End Property

    Public ReadOnly Property ItemNumber As String Implements IDefChild.ItemNumber
        Get
            Return ""
        End Get
    End Property
End Class

