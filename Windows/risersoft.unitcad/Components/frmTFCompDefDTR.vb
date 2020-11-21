Imports risersoft.app.mxform.eto

Public Class frmTFCompDefDTR
    Inherits frmMax
    Implements IDefChild
    Dim WithEvents codesys As New clsCodeSystem, myTFCD As New clsTFCDModel(Me.Controller)
    Dim fDoc As frmMax, mvParam As New clsWinView
    Public fp As frmTFCompDefBase

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid1)
        mvParam.SetGrid(Me.UltraGrid2)
        WinFormUtils.SetButtonConf(btnOK, btnCancel, btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Me.InitData("", "", oview, prepMode, prepIdx, strXML)   'for vBag generation
        fp = oview.fParentWin
        Me.vBag("CompType") = fp.CompType
        Me.vBag("PIDUnitID") = WinParamUtils.GetCurrPIDUNitID(Me.Controller)
        strXML = Me.Controller.Data.VarBagXML(Me.vBag)

        Dim objModel As frmTFCompDefDTRModel = Me.InitData("frmTFCompDefDTRModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If myUtils.cValTN(myRow("destablerowid")) > 0 Then

                If frmMode = EnumfrmMode.acAddM Then myTFCD.DisplayDTRData(myView.Model, fp.mvBlankDTR.Model) Else myTFCD.DisplayDTRData(myView.Model, fp.mvDefDTR.Model)

                Me.codesys.SetConf(Me.dsCombo.Tables("CompDef"), Me.cmb_ChildCompDefID, Me.cmb_CompDefDescrip)
                Me.cmb_ChildCompDefID.Value = myRow("childcompdefid")
                Me.codesys.HandleCombo(Me.cmb_ChildCompDefID, IIf(frmMode = EnumfrmMode.acAddM, EnumWantEvent.acForceEvent, EnumWantEvent.acNoEvent))

                If fDoc Is Nothing Then
                    Dim t As Type = fp.fDoc.GetType
                    fDoc = Activator.CreateInstance(t)
                    fDoc.AddtoTab(Me.UltraTabControl1, "part", True)
                End If

                fDoc.PrepForm(Me)
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            mvParam.PrepEdit(NewModel.GridViews("Param"),, btnDel)
            Return True
        End If
        Return False
    End Function



    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        myFuncsTFCD.SetCompFileName(Me.Controller, TryCast(fDoc, IDoc), myRow.Row, fp.CompType)
        If myUtils.IsInList(fp.CompType, "BLK") Then
            If myUtils.cStrTN(myRow("compfilename")).Trim.Length > 0 AndAlso myUtils.cStrTN(myRow("blockname")).Trim.Length = 0 Then WinFormUtils.AddError(CType(fDoc, IDoc).CompFileTextBox, "Select Block", Me.eBag)
        End If
        If Me.CanSave Then
            If Me.ValidateData() Then
                If Me.SaveModel() Then
                    Return True
                End If
            Else
                Me.SetError()
            End If
        End If
        Me.Refresh()
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim f As frmTFCompDefChildParam = New frmTFCompDefChildParam
        If f.PrepForm(Me.mvParam, EnumfrmMode.acAddM, "") Then f.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim f As frmTFCompDefChildParam = New frmTFCompDefChildParam
        If f.PrepForm(Me.mvParam, EnumfrmMode.acEditM, "") Then f.ShowDialog()
    End Sub

    Public ReadOnly Property fp1 As IfrmDef Implements IDefChild.fp
        Get
            Return fp
        End Get
    End Property

    Public ReadOnly Property ItemNumber As String Implements IDefChild.ItemNumber
        Get
            Return ""
        End Get
    End Property
End Class

