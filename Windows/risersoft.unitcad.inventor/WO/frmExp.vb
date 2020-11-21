Public Class frmExp

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
        subFoldersColumn.CustomGrouping = True

        SetColumnText()
    End Sub

    Private Sub Browser1_Group(ByVal sender As Object, ByVal e As ExplorerControls.ExpList.ExpListGroupEventArgs) Handles Browser1.Group
        If Not e.Column Is subFoldersColumn Then Exit Sub
        Dim itm As ExplorerControls.ExpListItem
        For Each itm In Browser1.ExpListItems
            Dim groupName As String
            If itm.CShItem.HasSubFolders Then
                groupName = "True (Custom Group)"
            Else
                groupName = "False (Custom Group)"
            End If
            If IsNothing(Browser1.ExpListGroups(groupName)) Then
                itm.Group = Browser1.ExpListGroups.Add(groupName, groupName)
            Else
                itm.Group = Browser1.ExpListGroups(groupName)
            End If
        Next
    End Sub

    'Use ItemsAdded to set the item text - SelectedFolderChanged won't work with refresh
    Private Sub Browser1_ItemsAdded(ByVal sender As Object, ByVal e As ExplorerControls.ExpList.ExpListItemsAddedEventArgs) Handles Browser1.ItemsAdded
        SetColumnText()
    End Sub

    'Private Sub Browser1_SelectedFolderChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Browser1.SelectedFolderChanged
    '    SetColumnText()
    'End Sub

    Private Sub SetColumnText()
        Dim itm As ExplorerControls.ExpListItem
        For Each itm In Browser1.ExpListItems
            Dim index As Integer = Browser1.Columns.IndexOf(subFoldersColumn)
            If index > -1 Then
                itm.SubItems(index).Text = CStr(itm.CShItem.HasSubFolders)
            End If
        Next
    End Sub

    Private Sub subFoldersColumn_ColumnAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles subFoldersColumn.ColumnAdded
        SetColumnText()
    End Sub

 
End Class