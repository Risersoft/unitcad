Imports System.Xml
Imports Infragistics.Win.UltraWinTabControl
Imports Infragistics.Win.UltraWinGrid
Imports Inventor
Imports Autodesk.ADN.InvUtility.CommandUtils
Imports System.Collections.Generic

Public Class frmEntityMarker
    Inherits frmMax
    Dim _app As Application, myMarker As clsMarker, _doc As Document
    Public Sub New(Optional cmd As AdnButtonCommandBase = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not cmd Is Nothing Then _app = cmd.Application
        Me.InitForm()
    End Sub

    Public Sub InitForm()


        myView.SetGrid(Me.UltraGrid1)
      
        'http://adndevblog.typepad.com/manufacturing/2012/05/how-to-set-custom-cursor-for-object-selection-using-net.html
        myMarker = New clsMarker(_app)


    End Sub
    ' members

    Private WithEvents _interactionEvents As Inventor.InteractionEvents
    Private WithEvents _selectEvents As Inventor.SelectEvents
    Private WithEvents _highlightSet As Inventor.HighlightSet

    Private Sub CreateObjects()

        _interactionEvents = _app.CommandManager.CreateInteractionEvents()
        AddHandler _interactionEvents.OnTerminate, AddressOf _interactionEvents_OnTerminate
        ' set prompts and cursor
        '_interactionEvents.SetCursor(Inventor.CursorTypeEnum.kCursorTypeCustom, "MyCustomCursor.cur", Inventor.CursorHotSpotEnum.kCursorHotSpotDefault)
        _interactionEvents.StatusBarText = "Select Face or Edge"
        ' subscribe to recive select events
        _selectEvents = _interactionEvents.SelectEvents

        ' selection filter
        _selectEvents.SingleSelectEnabled = True
        _selectEvents.ClearSelectionFilter()
        _selectEvents.AddSelectionFilter(Inventor.SelectionFilterEnum.kPartFaceFilter)
        _selectEvents.AddSelectionFilter(Inventor.SelectionFilterEnum.kPartEdgeFilter)

        ' add delegates
        AddHandler _selectEvents.OnSelect, AddressOf _selectEvents_OnSelect
        _doc = _app.ActiveDocument
        _highlightSet = _doc.CreateHighlightSet
    End Sub

  
   

    Private Sub frmEntityMarker_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.CleanUp()
    End Sub


    Private Sub _interactionEvents_OnTerminate()


    End Sub

    Private Sub _selectEvents_OnSelect(JustSelectedEntities As Inventor.ObjectsEnumerator, SelectionDevice As Inventor.SelectionDeviceEnum, ModelPosition As Inventor.Point, ViewPosition As Inventor.Point2d, View As Inventor.View)
        _interactionEvents.Stop()
        Dim obj As Object = JustSelectedEntities(1), proxy As Boolean
        Dim newname As String = myMarker.EditSelected(obj, "")

        Dim strp As String = ""
        If TypeOf obj Is FaceProxy OrElse TypeOf obj Is EdgeProxy Then
            strp = obj.nativeobject.Parent.ComponentDefinition.Document.FullFileName
            proxy = True
        ElseIf TypeOf obj Is Face OrElse TypeOf obj Is Edge Then
            strp = obj.parent.ComponentDefinition.Document.FullFileName
            proxy = False
        End If

        Dim nr1 As DataRow = Nothing
        If strp.Trim.Length > 0 Then
            'entity has been added
            If newname.Trim.Length > 0 Then Me.ListEntities()
            'find it
            nr1 = myMarker.FindRow(strp, "", obj, proxy)
        End If
        If Not nr1 Is Nothing Then
            Dim gRow As UltraGridRow = myWinUtils.FindRow(myView.mainGrid.myGrid, "entityid", nr1("entityid"))
            If Not gRow Is Nothing Then
                myWinUtils.ClearActiveRow(myView.mainGrid.myGrid)
                myWinUtils.SelectRow(myView.mainGrid.myGrid, gRow)
            End If
        End If
    End Sub
    Private Sub ListEntities()
        Dim dt1 As DataTable = myMarker.ListNamedEntities()
        myView.mainGrid.Initialize()
        myView.mainGrid.BindView(dt1.DataSet)
        myView.mainGrid.MainConf("defaultgroupon") = "PartFileName"
        myView.mainGrid.QuickConf("", True, "3-1-1")
        myView.mainGrid.PrepEdit("<BAND INDEX=""0""><COL KEY=""EntityName""/></BAND>", , , , EnumEditType.acEditOnly)
    End Sub
    Private Sub frmEntityMarker_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.CreateObjects()
        Me.ListEntities()
        myView.mainGrid.ExpandFirstRow()

    End Sub

    Private Sub UltraGrid1_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGrid1.AfterCellUpdate
        If e.Cell.Column.Key.Trim.ToLower = "entityname" Then
            myMarker.EditSelected(e.Cell.Row.Cells("entity").Value, e.Cell.Value)
        End If
    End Sub

    Private Sub UltraGrid1_AfterRowActivate(sender As Object, e As System.EventArgs) Handles UltraGrid1.AfterRowActivate
        Dim nr As DataRow = myWinUtils.DataRowFromGridRow(Me.UltraGrid1.ActiveRow)
        If nr Is Nothing Then
            _highlightSet.Clear()
        Else
            _highlightSet.Clear()

          
            Dim el As clsEntityList = nr("entitylist")
            If el.EntityProxyList.Count = 0 Then
                Dim obj As Object = nr("entity")
                If Not myUtils.NullNot(obj) Then _highlightSet.AddItem(obj)
            Else
                For Each obj In el.EntityProxyList
                    _highlightSet.AddItem(obj)
                Next
            End If
        End If
    End Sub
    Private Sub DestroyObjects()


        If Not _highlightSet Is Nothing Then
            _highlightSet.Clear()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(_highlightSet)
            _highlightSet = Nothing
        End If

        If Not _selectEvents Is Nothing Then
            RemoveHandler _selectEvents.OnSelect, AddressOf _selectEvents_OnSelect

            System.Runtime.InteropServices.Marshal.ReleaseComObject(_selectEvents)

        End If

        If Not _interactionEvents Is Nothing Then
            RemoveHandler _interactionEvents.OnTerminate, AddressOf _interactionEvents_OnTerminate
            System.Runtime.InteropServices.Marshal.ReleaseComObject(_interactionEvents)

        End If


    End Sub
    Private Sub CleanUp()
        System.GC.Collect()
        System.GC.WaitForPendingFinalizers()
     
        Me.DestroyObjects()
     
        myMarker.dtEntity.Rows.Clear()
        myMarker = Nothing

        System.GC.WaitForPendingFinalizers()
        System.GC.Collect()

    End Sub

    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click

        _interactionEvents.Start()

    End Sub

    Private Sub btnDelSel_Click(sender As System.Object, e As System.EventArgs) Handles btnDelSel.Click
        Dim gr As UltraGridRow = myView.mainGrid.ActiveORSelectedRow
        Dim nr As DataRow = myWinUtils.DataRowFromGridRow(gr)
        If Not nr Is Nothing Then
            If myMarker.DeleteNameSelected(nr("entity")) Then
                Me.ListEntities()
                myView.mainGrid.ExpandFirstRow()
            End If
           End If

    End Sub

    Private Sub btnDeleteAll_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteAll.Click
        myMarker.DeleteAllNames()
        Me.ListEntities()
        myView.mainGrid.ExpandFirstRow()
    End Sub

    Private Sub btnHightLightAll_Click(sender As System.Object, e As System.EventArgs) Handles btnHightLightAll.Click
        myMarker.highlightNamedEntities()
    End Sub

    Private Sub btnUnHighlightAll_Click(sender As System.Object, e As System.EventArgs) Handles btnUnHighlightAll.Click
        myMarker.unhighlightNamedEntities()
    End Sub

    Private Sub UltraGrid1_BeforeCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles UltraGrid1.BeforeCellUpdate
        If e.Cell.Column.Key.Trim.ToLower = "entityname" Then
            If myMarker.dtEntity.Select("entityname='" & e.NewValue & "' and fullfilename='" & e.Cell.Row.Cells("fullfilename").Value & "' and entityid<>" & e.Cell.Row.Cells("entityid").Value).Length > 0 Then
                MsgBox("Name already exists.", MsgBoxStyle.Information, myWinApp.Vars("appname"))
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub UltraGrid1_DoubleClickCell(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles UltraGrid1.DoubleClickCell
        If e.Cell.Column.Key.Trim.ToLower = "visible" Then
            If e.Cell.Value.ToString.Trim.ToLower = "no" Then
                e.Cell.Value = "Yes"
                myMarker.Highlightrow(myWinUtils.DataRowFromGridRow(e.Cell.Row), True)
            Else
                e.Cell.Value = "No"
                myMarker.UnHighlightrow(myWinUtils.DataRowFromGridRow(e.Cell.Row))
            End If
        End If
    End Sub

   
End Class


