Imports Infragistics.Win.UltraWinExplorerBar
Imports risersoft.app.mxform.eto

Public Class frmTFCompDefBOM
    Inherits frmMax
    Implements IDefChild
    Dim WithEvents codesys As New clsCodeSystem
    Dim fDoc As frmMax, fDef As frmTFCompDefBase, oSortP As clsWinSort
    Dim LastGroup As UltraExplorerBarGroup, ItemNumFixed As String
    Dim myViewPrm As New clsWinView, myViewArea As New clsWinView
    Dim EditGroupManager As New clsFormulaEditManagerSci
    Public Sub initForm()
        myViewPrm.SetGrid(Me.UltraGrid1)
        myView.SetGrid(Me.UltraGrid2)
        myViewArea.SetGrid(Me.UltraGrid3)
        oSortP = New clsWinSort(myViewPrm, Me.btnMovePU, Me.btnMovePD, Me.btnRenumP, "sortindex")
        WinFormUtils.SetButtonConf(btnOK, btnCancel, btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmTFCompDefBOMModel = Me.InitData("frmTFCompDefBOMModel", oview, prepMode, prepIdx, strXML)
        fDef = oview.fParentWin
        If Me.BindModel(objModel, oview) Then
            If (fDoc Is Nothing) AndAlso fDef.IsDevApp Then
                Try
                    Dim t As Type = fDef.fDoc.GetType
                    fDoc = Activator.CreateInstance(t)
                    fDoc.AddtoTab(Me.UltraTabControl1, "part", True)
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                End Try
            End If

            If (fDoc Is Nothing) Then
                Me.UltraTabControl1.Tabs("part").Visible = False
            Else
                fDoc.PrepForm(Me)
            End If
            EditGroupManager.InitFCheckBar(Me.UltraExplorerBar1, fDef.dtAllParams, fDef.oWOInfo)
            Me.SetControlsValue(Me.UltraExplorerBar1)
            For Each grp As UltraExplorerBarGroup In Me.UltraExplorerBar1.Groups
                EditGroupManager.HandleFormulaEditorGroup(grp)
            Next
            LastGroup = Me.UltraExplorerBar1.Groups("descrip")
            LastGroup.Selected = True


            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("WT"))
            myViewArea.PrepEdit(NewModel.GridViews("AREA"))


            myFuncsTFCD.SetupLocalParamView(myViewPrm, fDef.fPrmList.myView.mainGrid.myDv.Table)
            Me.ApplyItemNumFilter()
            Me.SetItemNum()
            oSortP.reSort()
            Return True
        End If
        Return False
    End Function
    Protected Friend Sub SetItemNum()
        For Each r1 As DataRowView In myViewPrm.mainGrid.myDv
            r1.Row("ItemNumFixed") = myRow("ItemNumFixed")
        Next

    End Sub
    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()

        Me.Model.ClientParams.Clear()
        Me.Model.ClientParams.Add(New clsSQLParam("@RowCount", myViewPrm.mainGrid.myDv.Count, GetType(Integer), False))
        If Me.ValidateData() Then
            Me.SetItemNum()
            Me.ApplyItemNumFilter()
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub ApplyItemNumFilter()
        ItemNumFixed = myUtils.cStrTN(myRow("itemnumfixed"))
        If ItemNumFixed.Trim.Length = 0 Then ItemNumFixed = "ADD*"
        myViewPrm.mainGrid.myDv.RowFilter = "itemnumfixed='" & ItemNumFixed & "'"
    End Sub

    Private Sub UltraExplorerBar1_ActiveGroupChanged(sender As Object, e As Infragistics.Win.UltraWinExplorerBar.GroupEventArgs) Handles UltraExplorerBar1.ActiveGroupChanged
        If Not LastGroup Is Nothing Then EditGroupManager.HandleFormulaEditorGroup(LastGroup)
        LastGroup = e.Group
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim f As frmMax, oView As clsWinView
        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "param"
                f = New frmTFCompDefParam
                oView = myViewPrm
            Case "wt"
                f = New frmTFCompDefCalcItemWV
                oView = Me.myView
            Case "area"
                f = New frmTFCompDefCalcItemArea
                oView = Me.myViewArea
        End Select

        If (Not f Is Nothing) AndAlso (Not oView Is Nothing) Then
            oView.ContextRow = oView.mainGrid.ActiveRow
            If f.PrepForm(oView, EnumfrmMode.acAddM, "", "<PARAMS TFCOMPDEFID=""" & fDef.frmIDX & """ TFCOMPDEFDETBOMID=""" & frmIDX & """/>") Then
                f.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim f As frmMax, oView As clsWinView, str1 As String, ChildMode As EnumfrmMode = EnumfrmMode.acEditM, Key As String = ""
        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "param"
                f = New frmTFCompDefParam
                oView = myViewPrm
                str1 = "tfcompdefparamid"
            Case "wt"
                f = New frmTFCompDefCalcItemWV
                oView = Me.myView
                str1 = "tfcompdefcalcid"
            Case "area"
                f = New frmTFCompDefCalcItemArea
                oView = Me.myViewArea
                str1 = "tfcompdefcalcid"
        End Select

        If (Not f Is Nothing) AndAlso (Not oView Is Nothing) Then
            oView.ContextRow = oView.mainGrid.ActiveRow
            If Not IsNothing(oView.ContextRow) Then
                If f.PrepForm(oView, ChildMode, myUtils.cValTN(oView.ContextRow.CellValue(str1))) Then
                    f.ShowDialog(Me)
                End If
            End If
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim oView As clsWinView
        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "param"
                oView = myViewPrm
            Case "wt"
                oView = Me.myView
            Case "area"
                oView = Me.myViewArea
        End Select
        If (Not oView Is Nothing) Then
            oView.ContextRow = oView.mainGrid.ActiveRow
            If Not oView.ContextRow Is Nothing Then
                If MsgBox("Are you sure?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                    oView.mainGrid.ButtonAction("del")
                End If
            End If
        End If
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Dim f As frmMax, oView As clsWinView, str1 As String, ChildMode As EnumfrmMode = EnumfrmMode.acCopyM, Key As String = ""
        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "param"
                f = New frmTFCompDefParam
                oView = myViewPrm
                str1 = "tfcompdefparamid"
            Case "wt"
                f = New frmTFCompDefCalcItemWV
                oView = Me.myView
                str1 = "tfcompdefcalcid"
            Case "area"
                f = New frmTFCompDefCalcItemArea
                oView = Me.myViewArea
                str1 = "tfcompdefcalcid"
        End Select
        If (Not f Is Nothing) AndAlso (Not oView Is Nothing) Then
            oView.ContextRow = oView.mainGrid.ActiveRow
            If f.PrepForm(oView, ChildMode, myUtils.cValTN(oView.ContextRow.CellValue(str1))) Then
                f.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        Dim oView As clsWinView
        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "param"
                oView = myViewPrm
            Case "wt"
                oView = Me.myView
            Case "area"
                oView = Me.myViewArea
        End Select
        If (Not oView Is Nothing) Then
            Me.Controller.PrintingPress.GenerateAndShowReport(oView)
        End If
    End Sub

    Public ReadOnly Property fp As IfrmDef Implements IDefChild.fp
        Get
            Return fDef
        End Get
    End Property

    Public ReadOnly Property ItemNumber As String Implements IDefChild.ItemNumber
        Get
            Return ItemNumFixed
        End Get
    End Property
End Class
