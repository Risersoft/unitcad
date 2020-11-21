Imports System.Collections.Generic
Imports Inventor

Public Class clsEntityList
    Friend EntityProxyList As List(Of Object)
    Friend GraphicsList As List(Of TextGraphics)
    Public Sub New()
        EntityProxyList = New List(Of Object)
        GraphicsList = New List(Of TextGraphics)

    End Sub
    Public Overrides Function ToString() As String
        Return "EntityList Object"
    End Function
End Class
