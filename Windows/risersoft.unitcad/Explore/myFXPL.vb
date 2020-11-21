Imports System.Drawing

Public Class myFXPL
    Inherits risersoft.shared.win.myFXPL
    Public Shared Function setDWGThumbNail(ByVal f As frmExplore, ByVal filename As String) As Boolean
        Dim cont As Boolean = True

        Try
            f.fdp.AxDwgThumbnail1.DwgFileName = filename
            f.fdp.UltraTabControl1.Tabs(0).Selected = True
            'f.UltraTabControl1.Tabs(2).Selected = True
            'f.AxDwgPreview1.DwgName = ""
            'f.AxDwgPreview1.DwgName = filename
            'f.AxDwgPreview1.Refresh()
        Catch ex As Exception
            'f.AxDwgPreview1.DwgName = ""
            f.fdp.AxDwgThumbnail1.DwgFileName = ""
            cont = False
        End Try
        Return cont
    End Function
    Public Shared Function setThumbNail(ByVal f As frmExplore, ByVal img As Image) As Boolean
        Dim cont As Boolean = True

        Try
            f.fdp.AxDwgThumbnail1.DwgFileName = ""
            f.fdp.UltraTabControl1.Tabs(1).Selected = True
            f.fdp.UltraPictureBox1.Image = img
        Catch ex As Exception
            cont = False
        End Try
        Return cont
    End Function
End Class
