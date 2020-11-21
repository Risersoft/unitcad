Imports Infragistics.Win.Misc
Imports risersoft.app.mxform.eto

Public Class frmTFCompDefActPack
    Inherits frmMax
    Public f As frmTFCompDefBase
    Dim dicHandlers As clsCollecString(Of Tuple(Of String, Type))

    Public Sub initForm()
        myView.SetGrid(UltraGrid1)
        WinFormUtils.SetButtonConf(btnOK, btnCancel, btnSave)
        If Not Me.DesignMode Then
        End If
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmTFCompDefActPackModel = Me.InitData("frmTFCompDefActPackModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            f = Me.pView.fParentWin
            Me.SetupActionHandler(myUtils.cStrTN(f.myRow("comptype")))
            Me.txt_EvalCondition.InitFCheck(f.dtAllParams, f.oWOInfo, "")

            If Me.CopyIDX > 0 Then
                Dim dt As DataTable = Me.Model.DatasetCollection("TFCompDefAction").Tables(0)
                myUtils.CopyRows(dt.Select, myView.mainGrid.myDS.Tables(0))
            End If
            Me.FormPrepared = True
        Else
            MsgBox("This action pack is inherited from " & myUtils.cStrTN(pView.ContextRow.CellValue("parentapcomp")) & ". It cannot be edited directly", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("shotchild"),, Me.btnDel)
            Return True
        End If
        Return False
    End Function

    Protected Friend Sub SetupActionHandler(CompType As String)
        dicHandlers = New clsCollecString(Of Tuple(Of String, Type))
        Select Case CompType.Trim.ToUpper
            Case "ASY"
                dicHandlers.Add("Constraint", New Tuple(Of String, Type)("Add New Constraint", GetType(frmTFCompDefActConstraint)))
                dicHandlers.Add("Pattern", New Tuple(Of String, Type)("Add New Pattern", GetType(frmTFCompDefActPattern)))
            Case "BLK"
                dicHandlers.Add("", New Tuple(Of String, Type)("Add New", GetType(frmTFCompDefAction)))
        End Select

        For Each str1 As String In dicHandlers.Keys
            Dim tu1 As Tuple(Of String, Type) = dicHandlers(str1)
            Dim btn As UltraButton = New UltraButton()
            Me.PanelBtn.Controls.Add(btn)
            btn.Text = tu1.Item1
            btn.Tag = str1      'actiontypekey
            btn.Dock = System.Windows.Forms.DockStyle.Right
            btn.AutoSize = True
            AddHandler btn.Click, AddressOf btnAdd_Click
        Next
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

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str1 As String = myUtils.cStrTN(CType(sender, UltraButton).Tag)
        Dim f As frmMax = Me.ActionHandler(str1)

        If f.PrepForm(Me.myView, EnumfrmMode.acAddM, "") Then f.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        myView.ContextRow = myView.mainGrid.ActiveRow

        Dim str1 As String = myUtils.cStrTN(myView.ContextRow.CellValue("actiontype"))
        Dim f As frmMax = Me.ActionHandler(str1)

        If f.PrepForm(Me.myView, EnumfrmMode.acEditM, "") Then f.ShowDialog()
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Dim nr As DataRow, gRow As Infragistics.Win.UltraWinGrid.UltraGridRow

        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            Dim str1 As String = myUtils.cStrTN(myView.ContextRow.CellValue("actiontype"))
            gRow = myView.mainGrid.ButtonAction("add")
            myView.mainGrid.myGrid.UpdateData()
            nr = myWinUtils.DataRowFromGridRow(gRow)
            myUtils.MergeDataRow(myUtils.DataRowFromGridRow(myView.ContextRow), nr, , True)
            myView.mainGrid.myGrid.ActiveRow = gRow
            Dim f As frmMax = Me.ActionHandler(str1)
            If f.PrepForm(Me.myView, EnumfrmMode.acEditM, "") Then f.ShowDialog()
        End If
    End Sub

    Private Function ActionHandler(ActionType As String) As frmMax
        Dim tu1 As Tuple(Of String, Type), f As frmMax

        If dicHandlers.Exists(ActionType) Then
            tu1 = dicHandlers(ActionType)
        ElseIf dicHandlers.Count = 1 Then
            tu1 = dicHandlers(0)
        End If
        If Not tu1 Is Nothing Then
            f = CType(Activator.CreateInstance(tu1.Item2), frmMax)
        End If
        Return f
    End Function
End Class
