Imports risersoft.unitcad
Public Class frmTFCompDefCalcItemWV
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem
    Dim fDef As IfrmDef, fDefChild As IDefChild

    Public Sub initForm()

        WinFormUtils.SetButtonConf(btnOK, btnCancel)
        Me.cmb_SumType.Items.Clear()
        Me.cmb_SumType.Items.Add("Add", "Add")
        Me.cmb_SumType.Items.Add("Sub", "Subtract")
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If Me.GetSoftData(oView, prepmode, prepIDX) Then
            Me.DoRefresh = False
            If TypeOf oView.fParentWin Is IDefChild Then
                fDefChild = oView.fParentWin
                fDef = fDefChild.fp 'can be frmTFCompDefChild or frmTFCompDefBOM
            Else
                fDef = TryCast(oView.fParentWin, IfrmDef) 'can be frmTFCompDef or frmTFAssyDef
            End If

            Me.txt_HeightFormula.InitFCheck(fDef.dtAllParams, fDef.oWOInfo, "")
            Me.txt_WidthFormula.InitFCheck(fDef.dtAllParams, fDef.oWOInfo, "")
            Me.txt_LengthFormula.InitFCheck(fDef.dtAllParams, fDef.oWOInfo, "")
            Me.txt_FactorFormula.InitFCheck(fDef.dtAllParams, fDef.oWOInfo, "")
            Me.txt_QtyFormula.InitFCheck(fDef.dtAllParams, fDef.oWOInfo, "")
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        Me.InitError()
        If Me.CanSave Then
            Me.SaveSoftData()
            VSave = True
        End If
        Return VSave
    End Function
End Class
