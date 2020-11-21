Public Class clsCADHostInv
    Inherits clsCADHostBase
    Public Overrides Function ActionTypeHandlers() As clsCollecString(Of Tuple(Of String, Type))
        Dim dic As New clsCollecString(Of Tuple(Of String, Type))
        dic.Add("Constraint", New Tuple(Of String, Type)("Add New Constraint", GetType(frmTFCompDefAction)))
        dic.Add("Pattern", New Tuple(Of String, Type)("Add New Pattern", GetType(frmTFCompDefActPattern)))
        Return dic

    End Function

End Class
