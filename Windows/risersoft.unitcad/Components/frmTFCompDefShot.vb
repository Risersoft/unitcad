Imports Infragistics.Win.UltraWinExplorerBar
Imports risersoft.app.mxform.eto
Public Class frmTFCompDefShot
    Inherits frmMax
    Public fp As frmTFCompDefBase
    Dim oSortC As clsWinSort, LastGroup As UltraExplorerBarGroup
    Dim EditorGroupManager As New clsFormulaEditManagerSci
    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid7)
        oSortC = New clsWinSort(myView, Me.btnMoveUpChild, Me.btnMoveDownChild, Nothing, "sortindex")
        WinFormUtils.SetButtonConf(btnOK, btnCancel, btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmTFCompDefShotModel = Me.InitData("frmTFCompDefShotModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            fp = Me.pView.fParentWin

            Me.reFreshCompGrid(False)
            oSortC.reSort()

            EditorGroupManager.InitFCheckBar(Me.UltraExplorerBar1, fp.dtAllParams, fp.oWOInfo)
            Me.SetControlsValue(Me.UltraExplorerBar1)
            For Each grp As UltraExplorerBarGroup In Me.UltraExplorerBar1.Groups
                EditorGroupManager.HandleFormulaEditorGroup(grp)
            Next
            LastGroup = Me.UltraExplorerBar1.Groups("condition")
            LastGroup.Selected = True

            Me.cmb_ShotType.Items.Clear()
            If myUtils.IsInList(myUtils.cStrTN(fp.myRow("comptype")), "asy") Then Me.cmb_ShotType.Items.Add("dwg", "Model Drawing")
            If myUtils.IsInList(myUtils.cStrTN(fp.myRow("comptype")), "asy", "blk") Then Me.cmb_ShotType.Items.Add("doc", "Word Document")

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("shotchild"))

            Return True
        End If
        Return False
    End Function

    Public Sub reFreshCompGrid(ByVal refresh As Boolean)
        If refresh Then RefreshGrid(myView, "shotchild", frmIDX)
        Dim dtComp As DataTable = fp.dsCompDef.Tables(0)
        myView.mainGrid.SetColLookup("childcompdefid", dtComp, "", , "Code", "CompdefCode", "tfcompdefid")
        myView.mainGrid.SetColLookup("defid2", dtComp, "", , "Description", "Descrip", "tfcompdefid")
        Me.cmb_ShotType.ReadOnly = (myView.mainGrid.myGrid.Rows.Count > 0)
    End Sub

    Private Sub RefreshGrid(View As clsWinView, key As String, ID As Integer)
        Dim oRet As New clsProcOutput
        oRet = Me.GenerateIDOutput(key.Trim.ToLower, ID)
        If oRet.Success Then
            Me.UpdateViewData(View, oRet)
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Protected Friend Sub HandleShotType(type As String)
        Dim arr As New List(Of String)
        Me.cmb_FileType.Items.Clear()
        Select Case type.Trim.ToUpper
            Case "DWG"
                Me.cmb_FileType.Items.Add("idw", ".IDW")
                Me.cmb_FileType.Items.Add("dwg", ".DWG")
                arr.AddRange(New String() {"template", "sheet", "paper", "title"})
            Case "DOC"
                Me.cmb_FileType.Items.Add("doc", ".DOC")
                Me.cmb_FileType.Items.Add("docx", ".DOCX")
                arr.AddRange(New String() {"template", "paper"})
        End Select
        If Me.cmb_FileType.SelectedItem Is Nothing AndAlso Me.cmb_FileType.Items.Count > 0 Then Me.cmb_FileType.Value = Me.cmb_FileType.Items(0).DataValue
        arr.Add("condition")
        For Each grp As UltraExplorerBarGroup In Me.UltraExplorerBar1.Groups
            grp.Visible = myUtils.IsInList(grp.Key, arr.ToArray)
        Next
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim f As frmMax, oView As clsWinView

        If Me.VSave Then
            Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
                Case "det"
                    f = New frmTFCompDefShotChild
                    oView = Me.myView
            End Select
        End If

        If (Not f Is Nothing) AndAlso (Not oView Is Nothing) Then
            oView.ContextRow = oView.mainGrid.ActiveRow

            If f.PrepForm(oView, EnumfrmMode.acAddM, "", "<PARAMS TFCOMPDEFSHOTID=""" & frmIDX & """/>") Then
                f.ShowDialog(Me)
                If f.DoRefresh Then RefreshGrid(oView, "shotchild", frmIDX)
                If TypeOf f Is frmTFCompDefShotChild Then Me.OnChildEdit()
            End If
        End If
    End Sub

    Private Sub OnChildEdit()
        Me.reFreshCompGrid(True)
        'Automatic renumbering 08-May-2012
        oSortC.renumber()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click, btnCopy.Click
        Dim f As frmMax, oView As clsWinView, str1 As String, ChildMode As EnumfrmMode = EnumfrmMode.acEditM
        If frmMode = EnumfrmMode.acEditM Then
            If sender Is btnCopy Then ChildMode = EnumfrmMode.acCopyM
            Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
                Case "det"
                    f = New frmTFCompDefShotChild
                    oView = Me.myView
                    str1 = "tfcompdefshotchildid"
            End Select
        Else
            MsgBox("First save then proceed.", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
        If (Not f Is Nothing) AndAlso (Not oView Is Nothing) Then
            oView.ContextRow = oView.mainGrid.ActiveRow
            If Not oView.ContextRow Is Nothing Then
                If f.PrepForm(oView, ChildMode, myUtils.cValTN(oView.ContextRow.CellValue(str1))) Then
                    f.ShowDialog(Me)
                    If f.DoRefresh Then RefreshGrid(oView, "shotchild", frmIDX)
                    If TypeOf f Is frmTFCompDefShotChild Then Me.OnChildEdit()
                End If
            End If
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim oView As clsWinView, sql As String = "", str1 As String = ""
        If frmMode = EnumfrmMode.acEditM Then
            Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
                Case "det"
                    oView = Me.myView
                    str1 = "tfcompdefshotchildid"
            End Select
        End If

        If (Not oView Is Nothing) Then
            oView.ContextRow = oView.mainGrid.ActiveRow
            If Not oView.ContextRow Is Nothing Then
                If sql.Trim.Length > 0 AndAlso str1.Trim.Length > 0 Then
                    If MsgBox("Are you sure?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                        Dim oRet As New clsProcOutput
                        oRet = Me.GenerateIDOutput("deldet", myUtils.cValTN(oView.ContextRow.CellValue(str1)))
                        If oRet.Success Then
                            If oView Is myView Then Me.OnChildEdit()
                        Else
                            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                        End If

                    End If
                Else
                    oView.mainGrid.ButtonAction("del")
                End If
            End If
        End If
    End Sub

    Private Sub UltraExplorerBar1_ActiveGroupChanged(sender As Object, e As Infragistics.Win.UltraWinExplorerBar.GroupEventArgs) Handles UltraExplorerBar1.ActiveGroupChanged
        If Not LastGroup Is Nothing Then EditorGroupManager.HandleFormulaEditorGroup(LastGroup)
        LastGroup = e.Group
    End Sub

    Private Sub cmb_ShotType_ValueChanged(sender As Object, e As EventArgs) Handles cmb_ShotType.ValueChanged
        If Me.FormPrepared Then
            Me.HandleShotType(Me.cmb_ShotType.Value)
        End If
    End Sub
End Class
