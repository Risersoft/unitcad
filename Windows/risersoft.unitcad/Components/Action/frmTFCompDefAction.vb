Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinExplorerBar

Public Class frmTFCompDefAction
    Inherits frmMax
    Dim EditorGroupManager As New clsFormulaEditManagerSci

    Dim f As frmTFCompDefActPack, LastGroup As UltraExplorerBarGroup
    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim ds As DataSet, comp2d As Boolean

        If Me.GetSoftData(oView, prepMode, prepIDX) Then
            f = Me.pView.fParentWin

            EditorGroupManager.InitFCheckBar(Me.UltraExplorerBar1, f.f.dtAllParams, f.f.oWOInfo)
            Me.SetControlsValue(Me.UltraExplorerBar1)
            For Each grp As UltraExplorerBarGroup In Me.UltraExplorerBar1.Groups
                EditorGroupManager.HandleFormulaEditorGroup(grp)
            Next
            LastGroup = Me.UltraExplorerBar1.Groups(0)
            LastGroup.Selected = True
            PrepForm = True
        End If


    End Function


    Private Sub InitForm()
        Dim sql, str1 As String, dt As DataTable



        'Me.cmb_ActionCode.Items.Clear()
        'Me.cmb_ActionCode.Items.Add("ivmate", "Mate Constraint")
        'Me.cmb_ActionCode.Items.Add("ivflush", "Flush Constraint")

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel)

    End Sub

    Public Overrides Function VSave() As Boolean

        Me.InitError()
        'If myUtils.NullNot(Me.cmb_ActionCode.Value) Then WinFormUtils.AddError(Me.cmb_ActionCode, "Enter Action Code")
        If Me.CanSave Then
            If myRow.Row.Table.Columns.Contains("actiontype") Then myRow("actiontype") = "Constraint"
            Me.SaveSoftData()
            VSave = True
        End If

    End Function

    Private Sub UltraExplorerBar1_ActiveGroupChanged(sender As Object, e As Infragistics.Win.UltraWinExplorerBar.GroupEventArgs) Handles UltraExplorerBar1.ActiveGroupChanged
        If Not LastGroup Is Nothing Then EditorGroupManager.HandleFormulaEditorGroup(LastGroup)
        LastGroup = e.Group
    End Sub
End Class
