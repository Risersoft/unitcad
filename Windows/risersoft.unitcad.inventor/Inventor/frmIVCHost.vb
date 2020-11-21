Public Class frmIVCHost
    Inherits frmMax
    Implements IViewer

    Public objapprenticeServerApp As New Inventor.ApprenticeServerComponent

    Public ReadOnly Property CurrFile As String Implements IViewer.CurrFile
        Get
            Return Me.AxInventorViewControl1.FileName
        End Get
    End Property

    Public Sub zoom_extents() Implements IViewer.zoom_extents
        Throw New NotImplementedException()
    End Sub

    Public Function CloseFile() As Boolean Implements IViewer.CloseFile
        Me.OpenFile("")
    End Function

    Public Function DetachRequiredOnClose() As Boolean Implements IViewer.DetachRequiredOnClose
        Return False
    End Function

    Public Function GenerateTreeModel() As clsTreeModel Implements IViewer.GenerateTreeModel
        Dim model = myIAM.BuildApprenticeTree(Me.Controller, Me.AxInventorViewControl1.ApprenticeServerDocument)
        Me.AxInventorViewControl1.ApprenticeServerDocument.CreateHighlightSet()
        Return model
    End Function

    Public Function OpenFile(filename As String) As Object Implements IViewer.OpenFile
        If Me.AxInventorViewControl1.FileName <> filename Then Me.AxInventorViewControl1.FileName = filename
        Return Me.AxInventorViewControl1.ApprenticeServerDocument
    End Function
    Public Function OpenFile(zipfilename As String, rootfilename As String) As Object Implements IViewer.OpenFile
        Return Me.OpenFile(zipfilename)
    End Function
End Class