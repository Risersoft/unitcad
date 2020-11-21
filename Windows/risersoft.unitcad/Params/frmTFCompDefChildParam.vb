Imports risersoft.shared.Extensions
Public Class frmTFCompDefChildParam
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem
    Dim f As IDefChild

    Private Sub InitForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If Me.GetSoftData(oView, prepMode, prepIDX) Then
            f = Me.pView.fParentWin
            If Me.BindModel(Me.pView.fParent.Model) Then
                Me.txt_Formula.InitFCheck(f.fp.dtAllParams, f.fp.oWOInfo, "")

                Me.cmb_paramcode.Value = myRow("paramcode")
                Me.codesys.HandleCombo(Me.cmb_paramcode)
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        Dim obj As Object
        Me.cmb_DataType.ValueList = NewModel.ValueLists("DataType").ComboList

        Me.codesys.SetConf(NewModel.dsCombo.Tables("params"), Me.cmb_paramcode, Me.cmb_paramname)
        If myUtils.IsInList(f.fp.DefSubType, "blk") Then
            obj = myAssy.GetClass(Me.Controller, "risersoft.unitcad.acad", "clsULtraFuncs2")
            Me.txt_Formula.CtlFormulaChk1.cManager.AddFuncLib("acad", obj)
        End If
        Return True
    End Function

    Public Overrides Function VSave() As Boolean
        Dim str1 As String
        VSave = False
        Me.InitError()
        str1 = myUtils.cStrTN(Me.cmb_paramcode.Text)
        If str1.Trim.Length = 0 Then WinFormUtils.AddError(Me.cmb_paramcode, "Enter Parameter Code")
        If Me.CanSave Then
            Me.SaveSoftData()
            VSave = True
        End If
    End Function

    Private Sub codesys_ItemChanged() Handles codesys.ItemChanged
        If Me.cmb_paramcode.SelectedRow Is Nothing Then
            Me.cmb_DataType.Value = -1
        Else
            Me.cmb_DataType.Value = myUtils.cValTN(Me.cmb_paramcode.SelectedRow.Cells("datatype").Value)
        End If
    End Sub
End Class

