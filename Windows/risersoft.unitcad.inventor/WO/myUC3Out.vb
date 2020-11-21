Imports Infragistics.Win.UltraWinListView
Imports Microsoft.WindowsAPICodePack.Shell

Public Class myUC3Out
    'can try thumbnail view
    'also see http://archive.msdn.microsoft.com/WindowsAPICodePack
    'windows xp http://stackoverflow.com/questions/2823541/windows-api-codepack-backwards-compatibility-on-window-xp
    'news on http://www.3dcadworld.com/autodesk-inventor-eto-gets-webified/


    Public Shared Sub FillThumbs(lv As UltraListView, oWO As clsWOInfoBase, dtRef As DataTable, ByVal clearExisting As Boolean)
        Dim cnt As Integer
        If (Not lv Is Nothing) AndAlso (Not oWO Is Nothing) Then
            cnt = lv.Items.Count
            If clearExisting Then lv.Items.Clear()
            If lv.SubItemColumns.Count = 0 Then
                Dim mainColumn As UltraListViewMainColumn = lv.MainColumn
                mainColumn.Text = "FileName"
                mainColumn.DataType = GetType(String)

                ' For all other fields, add a member to the
                ' SubItemColumns collection
                Dim subItemColumn As UltraListViewSubItemColumn
                subItemColumn = lv.SubItemColumns.Add("NewName")        'not used actually.
                subItemColumn.DataType = GetType(String)
            End If
            If clearExisting OrElse cnt = 0 Then
                'Add Items
                For Each r1 As DataRow In dtRef.Select("len(newfilename)>0", "sortindex")
                    Dim filename As String = System.IO.Path.Combine(oWO.FuncRootPath("model"), r1("newfilename"))
                    myUC3Out.AddFile(lv, filename, myUtils.cStrTN(r1("newname")))
                Next

            End If
        End If
    End Sub
    Public Shared Function AddFile(lv As UltraListView, ByVal filename As String, ByVal newname As String) As String

        If System.IO.File.Exists(filename) Then
            Try
                Dim lvi As UltraListViewItem = lv.Items.Add(filename, System.IO.Path.GetFileName(filename))
                Dim sf As ShellFile = ShellFile.FromFilePath(filename)
                lvi.Appearance.Image = sf.Thumbnail.ExtraLargeBitmap
                If newname.Trim.Length > 0 Then lvi.Value = newname
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End If

    End Function
    Public Shared Sub UltraGrid2_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs)
        Dim str1 As String

        If myUtils.cStrTN(e.Row.Cells("errorcode").Value).Trim.Length > 0 Then
            e.Row.CellAppearance.BackColor = System.Drawing.Color.OrangeRed
        Else
            If myUtils.cBoolTN(e.Row.Cells("isold").Value) Then
                e.Row.CellAppearance.BackColor = System.Drawing.Color.LightGreen
            Else
                e.Row.CellAppearance.BackColor = System.Drawing.Color.LightBlue
            End If
        End If
    End Sub
    Public Shared Sub FillThumbs2(f As frmExp, myVueRef As clsWinView, ByVal clearExisting As Boolean)
        Dim cnt As Integer
        If (Not f Is Nothing) Then
            cnt = f.Browser1.ExpListItems.Count
            If clearExisting Then f.Browser1.ExpListItems.Clear()
            f.Browser1.PanelCombo.Visible = False
            'f.Browser1.View = ExplorerControls.ExpListView.Thumbnail
            'f.Browser1.StartUpDirectory = ExplorerControls.ExpTree.StartDir.MyDocuments
            If clearExisting OrElse cnt = 0 Then
                For Each r1 As DataRow In myVueRef.mainGrid.myDS.Tables(0).Select("len(newfilename)>0", "sortindex")
                    myUC3Out.AddFile2(f, r1("newfilename"), myUtils.cStrTN(r1("newname")))
                Next

            End If
        End If
    End Sub
    Public Shared Function AddFile2(f As frmExp, ByVal filename As String, ByVal newname As String) As String
        If Not System.IO.Path.IsPathRooted(filename) Then filename = System.IO.Path.Combine(myWinApp.objAppExtender.FileServerPath, filename)
        If System.IO.File.Exists(filename) Then
            Try
                Dim eli As ExplorerControls.ExpListItem = f.Browser1.ExpList1.Items.Add(filename)
                If newname.Trim.Length > 0 Then eli.Text = newname
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End If

    End Function
    
End Class
