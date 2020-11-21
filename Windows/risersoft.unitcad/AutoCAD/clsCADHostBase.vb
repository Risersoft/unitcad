Public Class clsCADHostBase
    Public Overridable Function ActionTypeHandlers() As clsCollecString(Of Tuple(Of String, Type))
        Dim dic As New clsCollecString(Of Tuple(Of String, Type))
        dic.Add("", New Tuple(Of String, Type)("Add New", GetType(frmTFCompDefAction)))
        Return dic

    End Function

End Class
