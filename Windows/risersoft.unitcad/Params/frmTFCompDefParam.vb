Imports risersoft.app.shared.mxengg
Imports Infragistics.Win.UltraWinGrid
Imports risersoft.shared.Extensions
Public Class frmTFCompDefParam
    Inherits frmMax
    Dim arrVueComp As New clsCollecString(Of clsWinView), arrVueAssy As New clsCollecString(Of clsWinView)
    Dim IsAssy As Boolean = False, fDef As IfrmDef, fDefChild As IDefChild

    Private Sub InitForm()
        Dim cnt As Integer = 0, myVue As clsWinView

        'CompRef will remian untouched in case of parameter rename.
        'as it is stored snapshot of proecessed data
        'if we need to change it, we must reprocess
        For Each str1 As String In New String() {"comp", "param", "bomparam", "bom", "actpack", "action", "paramgrp"}
            cnt = cnt + 1
            myVue = New clsWinView
            myVue.SetGrid(WinFormUtils.getControlFromName("ugrid" & cnt, Me.UltraTabControl1))
            myVue.mainGrid.myGrid.Text = ""
            myVue.myMode = EnumViewMode.acSelectM : myVue.MultiSelect = True
            arrVueComp.Add(str1, myVue)
        Next
        cnt = 0
        For Each str1 As String In New String() {"assy", "partdef", "parthw", "partdis", "param", "bomparam"}
            cnt = cnt + 1
            myVue = New clsWinView
            myVue.SetGrid(WinFormUtils.getControlFromName("agrid" & cnt, Me.UltraTabControl1))
            myVue.mainGrid.myGrid.Text = ""
            myVue.myMode = EnumViewMode.acSelectM : myVue.MultiSelect = True
            arrVueAssy.Add(str1, myVue)
        Next
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel)
        Me.DoRefresh = False
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim dt As DataTable
        Me.FormPrepared = False
        If Me.GetSoftData(oView, prepMode, prepIDX) Then
            If TypeOf oView.fParentWin Is frmTFCompDefParamList Then
                fDef = TryCast(CType(oView.fParentWin, frmTFCompDefParamList).fp, IfrmDef) 'can be frmTFCompDef or frmTFCompDefCalc or anything
            ElseIf TypeOf oView.fParentWin Is IDefChild Then
                fDefChild = oView.fParentWin
                fDef = fDefChild.fp 'can be frmTFCompDefChild or frmTFCompDefBOM
            Else
                fDef = TryCast(oView.fParentWin, IfrmDef) 'can be frmTFCompDef or frmTFAssyDef
            End If
            If Me.BindModel(CType(fDef, frmMax).Model) Then
                Me.DoRefresh = False
                If (Not fDef Is Nothing) Then
                    dt = fDef.dtAllParams

                    If fDef.DefType.Trim.ToLower = "assy" Then
                        Me.UltraTabControl1.Tabs(1).Selected = True
                        IsAssy = True
                        Me.btnReplace.Visible = False 'To be implemented
                        Me.Text = "Assembly Definition Parameter"
                    Else
                        Me.UltraTabControl1.Tabs(0).Selected = True
                        Me.btnReplace.Visible = True
                        Me.Text = "Component Definition Parameter"
                    End If


                    If fDefChild Is Nothing Then
                        myRow("itemnumfixed") = ""
                        Me.chk_IsInput.Visible = True
                    Else
                        myRow("itemnumfixed") = fDefChild.ItemNumber
                        Me.Text = Me.Text & " - Item Level"
                        Me.chk_IsInput.Visible = False
                    End If

                    Me.txt_Formula.InitFCheck(dt, fDef.oWOInfo, "")
                    Me.txt_CheckFormula.InitFCheck(dt, fDef.oWOInfo, "")
                    If myDWG.InProcACAD Then Me.txt_Formula.CtlFormulaChk1.cManager.AddFuncLib("acad", myAssy.GetClass(Me.Controller, "risersoft.unitcad.acad", "clsULtraFuncs2"))
                    Me.UltraTabControl2.Tabs("rename").Visible = (frmMode = EnumfrmMode.acEditM)
                    Me.FormPrepared = True
                End If
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        Me.cmb_DataType.ValueList = NewModel.ValueLists("DataType").ComboList
        Return True
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        Me.InitError()
        Dim oRet As clsProcOutput = myIntent.ValidateIdentifier(Me.txt_ParamCode.Text, False)
        If Not oRet.Success Then WinFormUtils.AddError(Me.txt_ParamCode, oRet.Message)
        If Me.CanSave Then
            Me.SaveSoftData()
            VSave = True
        End If
    End Function

    Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        If IsAssy Then Me.FindAssembly() Else Me.FindComponent()
    End Sub

    Private Sub FindComponent()
        cm.EndCurrentEdit()

        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@CompType", "'" & myUtils.cStrTN(CType(fDef, frmMax).myRow("comptype")) & "'", GetType(String), False))
        Params.Add(New clsSQLParam("@ParamCode", "'" & myUtils.cStrTN(myRow("paramcode")) & "'", GetType(String), False))
        Dim dic As clsCollecString(Of clsViewModel) = CType(fDef, frmMax).GenerateParamsModelCollec("arrvuecomp", Params)
        PrepEditComp(dic)
    End Sub

    Private Sub FindAssembly()
        cm.EndCurrentEdit()
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@ParamCode", "'" & myUtils.cStrTN(myRow("paramcode")) & "'", GetType(String), False))
        Dim dic As clsCollecString(Of clsViewModel) = CType(fDef, frmMax).GenerateParamsModelCollec("arrvueassy", Params)
        arrVueAssy("assy").PrepEdit(dic("assy"))
        arrVueAssy("param").PrepEdit(dic("param"))
        arrVueAssy("bomparam").PrepEdit(dic("bomparam"))
        arrVueAssy("partdef").PrepEdit(dic("partdef"))
        arrVueAssy("parthw").PrepEdit(dic("parthw"))
        arrVueAssy("partdis").PrepEdit(dic("partdis"))

        For Each oView As clsWinView In arrVueAssy.Values
            oView.mainGrid.HighlightRows()
        Next
    End Sub

    Private Sub ReplaceComponent()
        If Me.VSave AndAlso Me.TextNewCode.Text.Trim.Length > 0 Then
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@CompType", "'" & myUtils.cStrTN(CType(fDef, frmMax).myRow("comptype")) & "'", GetType(String), False))
            Params.Add(New clsSQLParam("@OldParamCode", "'" & myUtils.cStrTN(myRow("paramcode")) & "'", GetType(String), False))
            Params.Add(New clsSQLParam("@NewParamCode", "'" & myUtils.cStrTN(Me.TextNewCode.Text) & "'", GetType(String), False))
            Dim dic As clsCollecString(Of clsViewModel) = CType(fDef, frmMax).GenerateParamsModelCollec("replacecomp", Params)
            PrepEditComp(dic)
            Me.txt_ParamCode.Text = Me.TextNewCode.Text
            pdr("paramcode") = Me.TextNewCode.Text
        End If
    End Sub

    Private Sub PrepEditComp(dic As clsCollecString(Of clsViewModel))
        arrVueComp("comp").PrepEdit(dic("comp"))
        arrVueComp("param").PrepEdit(dic("local"))
        arrVueComp("bomparam").PrepEdit(dic("bomparam"))
        arrVueComp("bom").PrepEdit(dic("bom"))
        arrVueComp("actpack").PrepEdit(dic("act"))
        arrVueComp("action").PrepEdit(dic("action"))
        arrVueComp("paramgrp").PrepEdit(dic("grp"))

        For Each oView As clsWinView In arrVueComp.Values
            oView.mainGrid.HighlightRows()
        Next
    End Sub

    Private Sub ReplaceAssembly()
    End Sub

    Private Sub btnReplace_Click(sender As System.Object, e As System.EventArgs) Handles btnReplace.Click
        If MsgBox("Are You Sure", MsgBoxStyle.YesNoCancel, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            If IsAssy Then Me.ReplaceAssembly() Else Me.ReplaceComponent()
        End If
    End Sub
End Class

