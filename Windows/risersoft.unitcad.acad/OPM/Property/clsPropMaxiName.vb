Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.EditorInput

Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Interop.Common

' No class interface is generated for this class and
' no interface is marked as the default.
' Users are expected to expose functionality through
' interfaces that will be explicitly exposed by the object
' This means the object can only expose interfaces we define

' Set the default COM interface that will be used for
' Automation. Languages like: C#, C++ and VB allow to 
'query for interface's we're interested in but Automation 
' only aware languages like javascript do not allow to 
' query interface(s) and create only the default one

<Guid("51296E9E-11C6-41aa-83D9-3D7112B27A16"), ProgId("maxacad.MaxName.1"), ClassInterface(ClassInterfaceType.None), ComVisible(True)> _
Friend Class clsPropMaxiName
    Inherits CustomPropBase
    Dim myName As String = ""
    ' Unique property ID

    Public Overrides Sub GetGUID(ByRef propGUID As Guid)
        propGUID = New Guid("51296E9E-11C6-41aa-83D9-3D7112B27A16")
    End Sub

    ' Property display name

    Public Overrides Sub GetDisplayName(ByRef szName As String)
        szName = "UnitCAD Name"
    End Sub

    Public Overrides Sub GetDescription(ByRef szName As String)
        szName = "Enter Name to be used in UnitCAD"
    End Sub


    Public Overrides Sub GetCurrentValueType(ByRef varType As UShort)
        ' The Property Inspector supports the following data
        ' types for dynamic properties:
        'VT_I2 (2), VT_I4 (3), VT_R4 (4), VT_R8 (5),
        'VT_BSTR (8), VT_BOOL (11), and VT_USERDEFINED (29). 

        varType = 8
    End Sub

    ' Get the property value, passes the specific object
    ' we need the property value for.

    Public Overrides Sub GetCurrentValueData(ByVal pUnk As Object, ByRef pVarData As Object)
        ' TODO: Get the value and return it to AutoCAD

        ' Because we said the value type was a 32b int (VT_I4)
        'pVarData = myName

        Dim obj As AcadObject = TryCast(pUnk, AcadObject)
        If obj IsNot Nothing Then
            Dim doc As Document = Application.DocumentManager.MdiActiveDocument
            Using tr As Transaction = doc.TransactionManager.StartTransaction()
                pVarData = myAcUtilsWin.GetXDataName(doc, tr, obj)
                tr.Dispose()
            End Using
        End If

    End Sub

    ' Set the property value, passes the specific object we
    ' want to set the property value for

    Public Overrides Sub SetCurrentValueData(ByVal pUnk As Object, ByVal varData As Object)
        Dim msg As String
        ' TODO: Save the value returned to you
        ' Because we said the value type was a 32b int (VT_I4)
        'myName = CStr(varData)
        msg = myAcUtilsWin.SetXData(Nothing, pUnk, varData)
        If msg.Trim.Length > 0 Then
            Dim ed As Editor = Application.DocumentManager.MdiActiveDocument.Editor
            ed.WriteMessage(vbLf & "Set Name Error: " & msg)
        End If
    End Sub

End Class
