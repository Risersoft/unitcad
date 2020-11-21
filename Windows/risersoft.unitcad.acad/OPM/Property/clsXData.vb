Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Runtime

<Assembly: CommandClass(GetType(risersoft.unitcad.acad.clsXData))> 
Public Class clsXData
    <CommandMethod("UNIT-GETNAME")> _
    Public Shared Sub GetXData()
        Dim doc As Document = Application.DocumentManager.MdiActiveDocument
        Dim ed As Editor = doc.Editor

        ' Ask the user to select an entity
        ' for which to retrieve XData
        Dim opt As New PromptEntityOptions(vbLf & "Select entity: ")
        Dim res As PromptEntityResult = ed.GetEntity(opt)
        If res.Status = PromptStatus.OK Then
            Dim tr As Transaction = doc.TransactionManager.StartTransaction()
            Using tr
                Dim obj As DBObject = tr.GetObject(res.ObjectId, OpenMode.ForRead)
                Dim rb As ResultBuffer = obj.XData
                If rb Is Nothing Then
                    ed.WriteMessage(vbLf & "Entity does not have a name.")
                Else
                    Dim n As Integer = 0
                    ed.WriteMessage(vbLf & "Name = " & myAcUtilsWin.XDataName(rb))
                    'For Each tv As TypedValue In rb
                    '    ed.WriteMessage(vbLf & "TypedValue {0} - type: {1}, value: {2}", System.Math.Max(System.Threading.Interlocked.Increment(n), n - 1), tv.TypeCode, tv.Value)
                    'Next
                    rb.Dispose()
                End If
            End Using
        End If

    End Sub
    <CommandMethod("UNIT-SETNAME")>
    Public Shared Sub SetXData()
        Dim doc As Document = Application.DocumentManager.MdiActiveDocument
        Dim ed As Editor = doc.Editor
        ' Ask the user to select an entity
        ' for which to set XData
        Dim opt As New PromptEntityOptions(vbLf & "Select entity: ")
        opt.SetRejectMessage("Select Entity")
        opt.AddAllowedClass(GetType(Entity), False)
        Dim res As PromptEntityResult = ed.GetEntity(opt)
        If res.Status = PromptStatus.OK Then
            Dim res2 As PromptResult = ed.GetString(vbLf & "Enter Name: ")
            If res2.Status = PromptStatus.OK Then
                Dim tr As Transaction = doc.TransactionManager.StartTransaction()
                Using tr
                    Dim obj As DBObject = tr.GetObject(res.ObjectId, OpenMode.ForWrite)
                    AddRegAppTableRecord(doc, myAcUtilsWin.RegAppName)
                    Dim rb As New ResultBuffer(New TypedValue(1001, myAcUtilsWin.RegAppName), New TypedValue(1000, res2.StringResult))
                    obj.XData = rb
                    rb.Dispose()
                    tr.Commit()
                End Using
            End If
        End If

    End Sub

    Friend Shared Sub AddRegAppTableRecord(doc As Document, ByVal regAppName As String)
        If doc Is Nothing Then doc = Application.DocumentManager.MdiActiveDocument
        Dim ed As Editor = doc.Editor
        Dim db As Database = doc.Database
        Dim tr As Transaction = doc.TransactionManager.StartTransaction()
        Using tr
            Dim rat As RegAppTable = DirectCast(tr.GetObject(db.RegAppTableId, OpenMode.ForRead, False), RegAppTable)
            If Not rat.Has(regAppName) Then
                rat.UpgradeOpen()
                Dim ratr As New RegAppTableRecord()
                ratr.Name = regAppName
                rat.Add(ratr)
                tr.AddNewlyCreatedDBObject(ratr, True)
            End If
            tr.Commit()
        End Using

    End Sub

End Class

