
Option Explicit On

Imports Inventor
Imports System.Collections.Generic

Public Class clsMarker

    Friend g_highlightingOn As Boolean, _app As Application, dtEntity As DataTable, oNode As GraphicsNode
    Friend Sub New(app As Inventor.Application)
        _app = app
        dtEntity = Me.dtEntityBlank
    End Sub
    Private Function dtEntityBlank() As DataTable
        Dim dt1 As New DataTable

        dt1.Columns.Add("EntityID", GetType(Integer))
        dt1.Columns.Add("FullFileName", GetType(String))
        dt1.Columns.Add("PartFileName", GetType(String))
        dt1.Columns.Add("Entity", GetType(Object))
        dt1.Columns.Add("EntityList", GetType(clsEntityList))
        dt1.Columns.Add("EntityName", GetType(String))
        dt1.Columns.Add("EntityType", GetType(String))
        dt1.Columns.Add("Visible", GetType(String))

        Dim oProc As New clsTableUtilsBase
        oProc.SetAuto(dt1, Nothing, "entityid")


        myUtils.MakeDSfromTable(dt1, False)
        Return dt1
    End Function
    Public Function GetNewKey(PartFileName As String, StartWith As String) As String
        Dim strk, str1 As String, cnt As Integer = 1

        Do
            str1 = StartWith & cnt

            If dtEntity.Select("fullfilename='" & PartFileName & "' and entityname='" & str1 & "'").Length = 0 Then
                strk = str1
                Exit Do
            End If
            cnt = cnt + 1
        Loop
        Return strk
    End Function
    Friend Function FindRow(PartFileName As String, EntityName As String, Entity As Object, Proxy As Boolean) As DataRow
        Dim nr, rr() As DataRow, el As clsEntityList

        rr = dtEntity.Select("fullfilename='" & PartFileName & "' and entityname='" & EntityName & "'")
        If rr.Length = 0 Then
            rr = dtEntity.Select("fullfilename='" & PartFileName & "'")
            For Each r1 In rr
                el = r1("entitylist")
                If Proxy Then
                    If el.EntityProxyList.Contains(Entity) Then
                        nr = r1
                        Exit For
                    End If
                Else
                    If r1("entity") Is Entity Then
                        nr = r1
                        Exit For
                    End If
                End If
            Next
        Else
            nr = rr(0)
        End If
        Return nr
    End Function


    Friend Function AddRow(PartFileName As String, EntityName As String, EntityType As String, Visible As String, Entity As Object, Proxy As Boolean) As DataRow
        Dim nr As DataRow, el As clsEntityList

        nr = Me.FindRow(PartFileName, EntityName, Entity, Proxy)
        If nr Is Nothing Then
            nr = dtEntity.NewRow
            nr("fullfilename") = PartFileName
            nr("partfilename") = System.IO.Path.GetFileName(PartFileName)
            nr("entityname") = EntityName
            nr("entitytype") = EntityType
            nr("visible") = Visible
            el = New clsEntityList
            nr("entitylist") = el
            If Proxy Then
                el.EntityProxyList.Add(Entity)
                nr("entity") = Entity.nativeobject      'for deleting / maintenance
            Else
                nr("entity") = Entity
            End If
            dtEntity.Rows.Add(nr)
        ElseIf Proxy Then
            el = nr("entitylist")
            If Not el.EntityProxyList.Contains(Entity) Then el.EntityProxyList.Add(Entity)
        End If
        Return nr
    End Function
    '
    ' Adds all Intent-named faces and edges from the given part-occurrence to the given collections.
    '
    Private Sub AddProxiesLeafLevel(occDoc As Document, occ As ComponentOccurrence)
        Dim attMgr As AttributeManager = occDoc.AttributeManager
        Dim objColl As ObjectCollection = attMgr.FindObjects("Intent", "Name")

        Dim obj As Object, e As Object, EntityType As String
        For Each obj In objColl
            Dim attSet As AttributeSet = obj.AttributeSets.Item("Intent")
            Dim attr As Inventor.Attribute = attSet.Item("Name")
            e = Nothing
            EntityType = ""
            If TypeOf obj Is Face Then
                EntityType = "Face"
            ElseIf TypeOf obj Is Edge Then
                EntityType = "Edge"
            Else
                'ignore anything else we find.
            End If
            If EntityType.Trim.Length > 0 Then
                Dim nr As DataRow
                If occ Is Nothing Then
                    e = obj
                    nr = Me.AddRow(occDoc.FullFileName, attr.Value, EntityType, "No", e, False)

                Else
                    If TypeOf obj Is Face Then
                        Dim fp As FaceProxy
                        occ.CreateGeometryProxy(obj, fp)
                        e = fp
                    ElseIf TypeOf obj Is Edge Then
                        Dim ep As EdgeProxy
                        occ.CreateGeometryProxy(obj, ep)
                        e = ep
                    End If
                       nr = Me.AddRow(occDoc.FullFileName, attr.Value, EntityType, "No", e, True)

                End If
            End If
        Next obj

    End Sub

    'Recursive procedure that eventually adds Intent-faces of the leaves
    'of this assembly to the collection.  The faces/edges in the collections
    'are returned as proxies at the given level.
    Private Sub AddIntentEntities(occs As ComponentOccurrences)

        For Each occ As ComponentOccurrence In occs
            If occ.SubOccurrences.Count > 0 Then
                AddIntentEntities(occ.SubOccurrences)
            Else
                AddProxiesLeafLevel(occ.Definition.Document, occ)
            End If
        Next occ
    End Sub
    Public Function ListNamedEntities() As DataTable



        Dim oDoc As Document = _app.ActiveDocument
        dtEntity = Me.dtEntityBlank
        If oDoc.DocumentType = DocumentTypeEnum.kPartDocumentObject Then
            Dim pDoc As PartDocument = oDoc
            AddProxiesLeafLevel(pDoc, Nothing)
        ElseIf oDoc.DocumentType = DocumentTypeEnum.kAssemblyDocumentObject Then
            Dim aDoc As AssemblyDocument = oDoc
            Dim acd As AssemblyComponentDefinition = aDoc.ComponentDefinition
            AddIntentEntities(acd.Occurrences)
        End If


        Return dtEntity



    End Function
    Private Sub EnsureNode()
        If oNode Is Nothing Then
            Dim oDoc As Document = _app.ActiveDocument

            '
            ' Create client graphics entities showing each name

            Dim oDataSets As GraphicsDataSets, oClientGraphics As ClientGraphics
            Dim oCompDef As ComponentDefinition = oDoc.ComponentDefinition
            Try
                oDataSets = oDoc.GraphicsDataSetsCollection.Item("EntityNames")
            Catch ex As Exception
                oDataSets = oDoc.GraphicsDataSetsCollection.Add("EntityNames")
            End Try

            Try
                oClientGraphics = oCompDef.ClientGraphicsCollection.Item("EntityNames")
            Catch ex As Exception
                oClientGraphics = oCompDef.ClientGraphicsCollection.Add("EntityNames")
            End Try
            Try
                oNode = oClientGraphics.AddNode(1)
            Catch ex As Exception

            End Try
            '

        End If
    End Sub

    Public Sub highlightNamedEntities()

        If g_highlightingOn Then Exit Sub
        Me.EnsureNode()

        Try
            ' Add text graphics for each face
            For Each r1 As DataRow In dtEntity.Select()
                Me.Highlightrow(r1, False)
            Next
            g_highlightingOn = True
            _app.ActiveView.Update()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try



    End Sub
    Friend Sub UnHighlightrow(r1 As DataRow)
        Dim el As clsEntityList = r1("entitylist")
        For Each oTextGraphics As TextGraphics In el.GraphicsList
            oTextGraphics.Delete()
        Next
        el.GraphicsList.Clear()

        _app.ActiveView.Update()
    End Sub
    Friend Sub Highlightrow(r1 As DataRow, Optional CheckNode As Boolean = True)

        If CheckNode Then Me.EnsureNode()
        If myUtils.InStrList(r1("entitytype"), "face") Then
            Dim el As clsEntityList = r1("entitylist")
            If el.EntityProxyList.Count = 0 Then
                'face
                Dim f As Face = r1("entity")
                AddClientGraphics(oNode, f.PointOnFace, r1)
            Else
                'face proxy
                For Each f As FaceProxy In el.EntityProxyList
                    AddClientGraphics(oNode, f.PointOnFace, r1)
                Next
            End If

        ElseIf myUtils.InStrList(r1("entitytype"), "edge") Then
            Dim el As clsEntityList = r1("entitylist")
            If el.EntityProxyList.Count = 0 Then

                'face
                Dim e As Edge = r1("entity")
                AddClientGraphics(oNode, e.PointOnEdge, r1)
            Else
                'face proxy
                For Each e As EdgeProxy In el.EntityProxyList
                    AddClientGraphics(oNode, e.PointOnEdge, r1)
                Next
            End If
        End If
        If CheckNode Then _app.ActiveView.Update()
    End Sub
    Private Sub AddClientGraphics(oNode As GraphicsNode, oAnchorPt As Point, r1 As DataRow)

        Dim oTextGraphics As TextGraphics
        oTextGraphics = oNode.AddTextGraphics

        oTextGraphics.Text = r1("entityname")
        oTextGraphics.Anchor = oAnchorPt
        oTextGraphics.Font = "Arial"
        oTextGraphics.FontSize = 25
        oTextGraphics.HorizontalAlignment = HorizontalTextAlignmentEnum.kAlignTextLeft
        oTextGraphics.PutTextColor(0, 255, 0)
        oTextGraphics.VerticalAlignment = VerticalTextAlignmentEnum.kAlignTextMiddle
        oTextGraphics.SetTransformBehavior(oAnchorPt, DisplayTransformBehaviorEnum.kFrontFacingAndPixelScaling)

        Dim el As clsEntityList = r1("entitylist")
        el.GraphicsList.Add(oTextGraphics)
    End Sub

    Public Sub unhighlightNamedEntities()

        If Not g_highlightingOn Then Exit Sub

        Dim oDoc As Document
        oDoc = _app.ActiveDocument

        Dim oCompDef As ComponentDefinition
        oCompDef = oDoc.ComponentDefinition

        Dim oClientGraphics As ClientGraphics
        oClientGraphics = oCompDef.ClientGraphicsCollection.Item("EntityNames")
        oClientGraphics.Delete()

        oNode = Nothing

        g_highlightingOn = False
        _app.ActiveView.Update()

    End Sub

    Public Function EditSelected(oEnt As Object, IntentName As String) As String
        Dim obj1 As Object = Nothing, obj2 As Object = Nothing, newName As String = "", updname As String = ""

        If (TypeOf oEnt Is FaceProxy) Then
            obj1 = oEnt.NativeObject
            newName = "Face"
        ElseIf (TypeOf oEnt Is EdgeProxy) Then
            obj1 = oEnt.NativeObject
            newName = "Edge"
        ElseIf (TypeOf oEnt Is Face) Then
            obj1 = oEnt
            newName = "Face"
        ElseIf (TypeOf oEnt Is Edge) Then
            obj1 = oEnt
            newName = "Edge"
        End If
        If IntentName.Trim.Length = 0 Then
            Dim str1 As String = obj1.parent.ComponentDefinition.Document.FullFileName
            newName = Me.GetNewKey(str1, newName)
        End If

        If Not obj1 Is Nothing Then
            Dim oTxnMgr As TransactionManager = _app.TransactionManager
            Dim oTxn As Transaction = oTxnMgr.StartTransaction(_app.ActiveDocument, "Intent Rename Entity")

            Dim attrSet As AttributeSet
            If obj1.AttributeSets.NameIsUsed("Intent") Then
                attrSet = obj1.AttributeSets.Item("Intent")
            Else
                attrSet = obj1.AttributeSets.Add("Intent")
            End If

            Dim attr As Inventor.Attribute
            If attrSet.NameIsUsed("Name") Then
                attr = attrSet.Item("Name")
                If IntentName.Trim.Length > 0 Then
                    updname = IntentName
                    attr.Value = IntentName
                End If
            Else
                attr = attrSet.Add("Name", ValueTypeEnum.kStringType, "ChangeMe")
                attr.Value = newName
                updname = newName
            End If

            'If we didn't actually do anything, then don't
            'record the transaction.
            If (oTxn.ChildTransactions.Count > 0) Then
                oTxn.End()
                If g_highlightingOn Then
                    unhighlightNamedEntities()
                    highlightNamedEntities()
                End If
            Else
                oTxn.Abort()
            End If

        End If
        Return updname
    End Function

    Public Function DeleteNameSelected(oEnt As Object) As Boolean
        Dim cont As Boolean = False
        If Not oEnt.AttributeSets.NameIsUsed("Intent") Then
            MsgBox("Selected entity was not Intent-named.")
            Exit Function
        End If

        Dim attrSet As AttributeSet
        attrSet = oEnt.AttributeSets.Item("Intent")

        If Not attrSet.NameIsUsed("Name") Then
            MsgBox("Selected entity was not Intent-named.")
            Exit Function
        End If

        Dim attr As Inventor.Attribute
        attr = attrSet.Item("Name")

        Dim button As MsgBoxResult
        button = MsgBox("Remove name '" & attr.Value & "' from selected entity?", vbYesNoCancel, myWinApp.Vars("appname"))
        If (button = vbYes) Then
            attr.Delete()
            cont = True
            If attrSet.Count = 0 Then
                attrSet.Delete()
            End If
            If g_highlightingOn Then
                unhighlightNamedEntities()
                highlightNamedEntities()
            End If
        End If
        Return cont
    End Function

    '
    ' Remove all Intent names from all entities
    '
    Public Sub DeleteAllNames()

        ' Confirm the action
        Dim button As MsgBoxResult
        button = MsgBox("Remove all Intent names from all occurrences?", vbOKCancel, myWinApp.Vars("appname"))
        If (button <> vbOK) Then Exit Sub

        ' Do it in a transaction
        Dim bTxnStarted As Boolean = False, oTxn As Transaction
        Try
            Dim oTxnMgr As TransactionManager
            oTxnMgr = _app.TransactionManager

            oTxn = oTxnMgr.StartTransaction(_app.ActiveDocument, "Intent Adopt Assembly")

            bTxnStarted = True

            Dim oDoc As Document = _app.ActiveDocument
            If oDoc.DocumentType = DocumentTypeEnum.kPartDocumentObject Then
                Dim pDoc As PartDocument = oDoc
                DeleteNamesInDocument(pDoc)
            ElseIf oDoc.DocumentType = DocumentTypeEnum.kAssemblyDocumentObject Then
                Dim aDoc As AssemblyDocument = oDoc
                Dim acd As AssemblyComponentDefinition = aDoc.ComponentDefinition
                ' (Recursively) delete the names in the occurrences
                DeleteNamesInOccurrences(acd.Occurrences)
            End If

            'If we didn't actually do anything, then don't record the transaction.
            If (oTxn.ChildTransactions.Count > 0) Then
                oTxn.End()
            Else
                oTxn.Abort()
            End If
            bTxnStarted = False

            ' Make sure highlights are gone
            unhighlightNamedEntities()

        Catch ex As Exception
            If bTxnStarted Then oTxn.Abort()
            MsgBox("Error during DeleteAllNames: " & ex.Message)

        End Try


    End Sub

    Private Sub DeleteNamesInOccurrences(occs As ComponentOccurrences)

        Dim occ As ComponentOccurrence
        For Each occ In occs
            ' Delete in this occurrence
            DeleteNamesInDocument(occ.Definition.Document)

            ' Delete in any suboccurrences
            If occ.SubOccurrences.Count > 0 Then
                DeleteNamesInOccurrences(occ.SubOccurrences)
            End If
        Next occ

    End Sub

    Private Sub DeleteNamesInDocument(doc As Document)

        ' Find all "Intent" attribute sets that include a "Name" attribute
        Dim attrSets As AttributeSetsEnumerator
        attrSets = doc.AttributeManager.FindAttributeSets("Intent", "Name")

        ' Delete any "Name" attributes
        Dim attrSet As AttributeSet
        For Each attrSet In attrSets
            If attrSet.NameIsUsed("Name") Then
                attrSet.Item("Name").Delete()
            End If
        Next

    End Sub
End Class
