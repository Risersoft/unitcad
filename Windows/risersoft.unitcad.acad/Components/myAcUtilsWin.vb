Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Interop
Imports Autodesk.AutoCAD.Interop.Common
Imports Autodesk.AutoCAD.Windows

Public Class myAcUtilsWin
    Public Shared RegAppName As String = "UCAD"
    Friend Shared m_ContextMenu As ContextMenuExtension
    Public Shared ps4 As Autodesk.AutoCAD.Windows.PaletteSet
    Public Shared pMain As Palette, MainIndex As Integer
    Public Shared Function FileNameDoc(ByVal filename As String, Optional ByVal freadonly As Boolean = False, Optional ByRef FreshOpened As Boolean = False) As Document
        Dim oDoc As Document
        Dim docs As DocumentCollection = Application.DocumentManager

        For Each doc As Document In docs
            If doc.Name.Trim.ToLower = filename.Trim.ToLower Then
                oDoc = doc
                Exit For
            End If
        Next
        If (oDoc Is Nothing) AndAlso My.Computer.FileSystem.FileExists(filename) Then
            oDoc = myAcUtilsWin.OpenDoc(filename, freadonly)
            FreshOpened = True
        End If
        Return oDoc
    End Function
    Public Shared Function NewFile(ByVal templatefile As String) As Document
        'this function is giving internal application error if a new file is opened in a different thread
        'hence for TCMake BGWorker, file new/open on the same thread through COM and then pass object variable
        'this function is called in WCF because WCF server is inside AutoCAD.
        Dim oDoc As Document
        Dim docs As DocumentCollection = Application.DocumentManager
        Dim doc As Document = docs.MdiActiveDocument
        If doc Is Nothing Then
            oDoc = myAcUtilsWin.NewDoc(templatefile)
        Else
            Using docLock As DocumentLock = doc.LockDocument
                oDoc = myAcUtilsWin.NewDoc(templatefile)
            End Using
        End If
        docs.MdiActiveDocument = oDoc
        Return oDoc
    End Function

    Friend Shared Function AcadDocumentFromDoc(oDoc As Document) As AcadDocument
        Dim ad As AcadDocument = Nothing
#If ACAD = "2013" Then
        ad = Autodesk.AutoCAD.ApplicationServices.DocumentExtension.GetAcadDocument(oDoc)
#End If
#If ACAD = "2012" Then
        ad = oDoc.AcadDocument
#End If
        Return ad
    End Function
    Friend Shared Function DocFromAcadDocument(ad As AcadDocument) As Document
        Dim oDoc As Document
#If ACAD = "2013" Then
        oDoc = Autodesk.AutoCAD.ApplicationServices.DocumentExtension.FromAcadDocument(ad)
#End If
#If ACAD = "2012" Then
        oDoc = Document.FromAcadDocument(ad)
#End If
        Return oDoc
    End Function
    Friend Shared Function OpenDoc(filename As String, freadonly As Boolean) As Document
        Dim oDoc As Document
#If ACAD = "2013" Then
        oDoc = Autodesk.AutoCAD.ApplicationServices.DocumentCollectionExtension.Open(Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager, filename, freadonly)
#End If
#If ACAD = "2012" Then
        oDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.Open(filename, freadonly)
#End If


        Return oDoc
    End Function
    Friend Shared Function NewDoc(templatefile As String) As Document
        Dim oDoc As Document
#If ACAD = "2013" Then
        oDoc = Autodesk.AutoCAD.ApplicationServices.DocumentCollectionExtension.Add(Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager, templatefile)
#End If
#If ACAD = "2012" Then
        oDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.Add(templatefile)
#End If

        Return oDoc

    End Function
    Friend Shared Sub CloseAndDiscard(oDoc As Document)
#If ACAD = "2013" Then
        Autodesk.AutoCAD.ApplicationServices.DocumentExtension.CloseAndDiscard(oDoc)
#End If
#If ACAD = "2012" Then
        oDoc.CloseAndDiscard()
#End If

    End Sub
    Friend Shared Sub CloseAndSave(oDoc As Document, filename As String)
#If ACAD = "2013" Then
        Autodesk.AutoCAD.ApplicationServices.DocumentExtension.CloseAndSave(oDoc, filename)
#End If
#If ACAD = "2012" Then
        oDoc.CloseAndSave(filename)
#End If

    End Sub
    Public Shared Function XDataName(rb As ResultBuffer) As String
        Dim str1 As String = ""
        If rb IsNot Nothing Then
            Dim foundStart As Boolean = False
            For Each tv As TypedValue In rb
                If tv.TypeCode = CInt(DxfCode.ExtendedDataRegAppName) AndAlso tv.Value.ToString() = myAcUtilsWin.RegAppName Then
                    foundStart = True
                Else
                    If foundStart = True Then
                        If tv.TypeCode = CInt(DxfCode.ExtendedDataAsciiString) Then
                            str1 = CStr(tv.Value)
                            Exit For
                        End If
                    End If
                End If
            Next
            rb.Dispose()
        End If
        Return str1
    End Function
    Public Shared Function GetXDataName(doc As Document, ByVal tr As Transaction, ByVal obj As AcadObject) As String
        Dim pVarData As String = ""

        Try
            Dim o As DBObject = myAcUtilsWin.DBObjectFromLink(doc.Database, tr, obj, OpenMode.ForRead)
            Dim rb As ResultBuffer = o.XData
            pVarData = myAcUtilsWin.XDataName(rb)
            If rb IsNot Nothing Then rb.Dispose()

        Catch ex As Exception
            pVarData = "Error: " & ex.Message
        End Try
        Return pVarData
    End Function

    Friend Shared Function DBObjectFromLink(db As Database, tr As Transaction, obj As AcadObject, mode As OpenMode) As DBObject
        'AcadObject.ObjectID method is not available in x64
        'Hence if we include the definition in a method, even if it is not called, error is raised.
        'Hence we made a method like this which does not cause any offence - 21 Apr 2012
        If IntPtr.Size = 8 Then
            Return myAcUtilsWin.DBObjectFromLink64(db, tr, obj, mode)
        Else
            Return myAcUtilsWin.DBObjectFromLink32(db, tr, obj, mode)
        End If
    End Function
    Friend Shared Function DBObjectFromLink64(db As Database, tr As Transaction, obj As AcadObject, mode As OpenMode) As DBObject
        Dim o As DBObject
        Dim ln As Long = Convert.ToInt64(obj.Handle, 16)
        Dim h As Handle = New Handle(ln)
        Dim id As ObjectId = db.GetObjectId(False, h, 0)
        o = tr.GetObject(id, mode)
        Return o

    End Function
    Friend Shared Function DBObjectFromLink32(db As Database, tr As Transaction, obj As AcadObject, mode As OpenMode) As DBObject
        Dim o As DBObject
        '32 bit system
        o = tr.GetObject(New ObjectId(CType(obj.ObjectID, IntPtr)), mode)
        Return o
    End Function
    Public Shared Function SetXData(ByVal doc As Document, ByVal pUnk As Object, ByVal varData As Object) As String
        Dim msg As String = ""
        Dim obj As AcadObject = TryCast(pUnk, AcadObject)
        If obj IsNot Nothing Then
            Try
                If doc Is Nothing Then doc = Application.DocumentManager.MdiActiveDocument
                Dim dl As DocumentLock = doc.LockDocument(DocumentLockMode.ProtectedAutoWrite, Nothing, Nothing, True)
                Using dl
                    clsXData.AddRegAppTableRecord(doc, myAcUtilsWin.RegAppName)
                    Dim tr As Transaction = doc.TransactionManager.StartTransaction()
                    Using tr
                        Dim o As DBObject = myAcUtilsWin.DBObjectFromLink(doc.Database, tr, obj, OpenMode.ForWrite)
                        Dim rb As New ResultBuffer(New TypedValue(CInt(DxfCode.ExtendedDataRegAppName), myAcUtilsWin.RegAppName), New TypedValue(CInt(DxfCode.ExtendedDataAsciiString), CStr(varData)))
                        o.XData = rb
                        rb.Dispose()
                        tr.Commit()
                        msg = ""
                    End Using
                End Using
            Catch ex As Exception
                If myAcUtilsWin.RegAppName.Trim.Length = 0 Then
                    msg = "Initialize Application"
                Else
                    msg = ex.Message
                End If
            End Try
        End If
        Return msg
    End Function
End Class
