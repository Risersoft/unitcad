
Imports Infragistics.Win.UltraWinTree
Imports Infragistics.Win.Misc
Imports Infragistics.Win.UltraWinEditors
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.Interop

Public Class frmDWGSnap
    Inherits frmMax
    Implements IViewer

    Dim currfilename As String, oDoc As Document
    Public Sub InitForm()


        Me.TopLevel = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None

    End Sub

    Public ReadOnly Property CurrFile() As String Implements IViewer.CurrFile
        Get
            Return currfilename
        End Get
    End Property

    Public Function OpenFile(ByVal filename As String) As Object Implements IViewer.OpenFile
        Dim obj As AcadDocument = Nothing
        If filename.Trim.Length > 0 Then
            oDoc = myAcUtilsWin.FileNameDoc(filename, True)        'Readonly added 10-May-2012
            If Not oDoc Is Nothing Then
                currfilename = filename
                Me.PictureBox1.Image = myACUtilsUCAD.SnapshotImage(oDoc, Autodesk.AutoCAD.GraphicsInterface.VisualStyleType.Basic)
                obj = myAcUtilsWin.AcadDocumentFromDoc(oDoc)
            End If
        ElseIf (Not oDoc Is Nothing) Then
            myAcUtilsWin.CloseAndDiscard(oDoc)
            currfilename = ""
        End If
        Return obj

    End Function

    Public Function CloseFile() As Boolean Implements [shared].IViewer.CloseFile
        Me.OpenFile("")
        Return True
    End Function

    Public Function DetachRequiredOnClose() As Boolean Implements [shared].IViewer.DetachRequiredOnClose
        Return True
    End Function

    Public Sub zoom_extents() Implements [shared].IViewer.zoom_extents

    End Sub

    Public Function GenerateTreeModel() As clsTreeModel Implements IViewer.GenerateTreeModel
        Return myDWG.objAddin2D.dtBlocks(currfilename)

    End Function

    Public Function OpenFile(zipfilename As String, rootfilename As String) As Object Implements IViewer.OpenFile
        Return Me.OpenFile(zipfilename)
    End Function
End Class
