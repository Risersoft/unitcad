Imports Autodesk.AutoCAD.Runtime
Imports System.Reflection
Imports Autodesk.AutoCAD.ApplicationServices
Imports System.IO
Imports System.Security

Public Class clsPropertyClass
    Dim custProp As clsPropMaxiName = Nothing, LoadingOK As Boolean = False
    'Private arr1() As String = New String() {"AcDbLine", "AcDbCircle"}
    Private arr1() As String = New String() {"AcDbEntity"}
    'Autodesk.AutoCAD.Windows.OPM removed from imports list so that if not present / error, UnitCAD can load.
    Friend Sub DoInitialize()
        Dim str1 As String, classDict As Dictionary = Nothing
        str1 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location) & "\asdkOPMNetExt.dll"
        Assembly.LoadFrom(str1)
        classDict = SystemObjects.ClassDictionary
        custProp = New clsPropMaxiName()
        ' Add the Dynamic Property
        For Each str1 In arr1
            Dim oDesc As RXClass = DirectCast(classDict.At(str1), RXClass)
            Dim pPropMan As Autodesk.AutoCAD.Windows.OPM.IPropertyManager2 = DirectCast(Autodesk.AutoCAD.Windows.OPM.xOPM.xGET_OPMPROPERTY_MANAGER(oDesc), Autodesk.AutoCAD.Windows.OPM.IPropertyManager2)
            pPropMan.AddProperty(DirectCast(custProp, Object))
            LoadingOK = True  'even if one entity type is added, this will be true
        Next

    End Sub
    Friend Sub DoTerminate()
        ' Remove the Dynamic Property
        If LoadingOK Then
            For Each str1 As String In arr1
                Try
                    Dim classDict As Dictionary = SystemObjects.ClassDictionary
                    Dim oDesc As RXClass = DirectCast(classDict.At(str1), RXClass)
                    Dim pPropMan As Autodesk.AutoCAD.Windows.OPM.IPropertyManager2 = DirectCast(Autodesk.AutoCAD.Windows.OPM.xOPM.xGET_OPMPROPERTY_MANAGER(oDesc), Autodesk.AutoCAD.Windows.OPM.IPropertyManager2)

                    pPropMan.RemoveProperty(DirectCast(custProp, Object))
                Catch ex As Exception
                    Debug.WriteLine("Error while removing propertyextension: " & ex.Message)

                End Try

            Next
        End If
        custProp = Nothing
    End Sub
End Class
