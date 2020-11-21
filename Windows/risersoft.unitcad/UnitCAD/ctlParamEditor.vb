Imports System.Windows.Forms
Imports risersoft.app.dataporter
Imports risersoft.app.mxform.eto
Imports risersoft.unitcad.API

Public Class ctlParamEditor
    Inherits UserControl
    Implements IParamEditorControl

    Dim bag3 As PropertyTable, compd As Integer, dtp As DataTable
    Public Event UpdateApplyButton As EventHandler(Of UpdateButtonEventArgs) Implements IParamEditorControl.UpdateApplyButton
    Public Event UpdateOkButton As EventHandler(Of UpdateButtonEventArgs) Implements IParamEditorControl.UpdateOkButton
    Dim m_interaction As Object, mDoc As IComponentDocument, m_config As EditorWindowConfig
    Public Property ContextDocument As IComponentDocument Implements IParamEditorControl.ContextDocument
        Get
            Return mDoc
        End Get
        Set(value As IComponentDocument)
            mDoc = value
            Me.RefreshData()
        End Set
    End Property
    Private Sub CreateConfigurationData()
        Me.m_config = New EditorWindowConfig() With
            {
                .AllowStandardPartEditor = False,
                .IsResizable = True,
                .MinimumSize = Me.MinimumSize,
                .PreferredSize = MyBase.Size
            }
    End Sub
    Public ReadOnly Property WindowConfiguration As EditorWindowConfig Implements IParamEditorControl.WindowConfiguration
        Get
            Return Me.m_config
        End Get
    End Property

    Public Property InventorInteractionEventsObject As Object Implements IParamEditorControl.InventorInteractionEventsObject
        Get
            Return m_interaction
        End Get
        Set(value As Object)
            m_interaction = value
        End Set
    End Property

    Private Sub InitForm()

        Me.CreateConfigurationData()

    End Sub

    Private Sub CheckDesignTable(g As PropertySpecDescriptor)
        Dim r1 As DataRow, desparamid As Integer
        Me.btnSelect.Tag = g

        If g Is Nothing Then
            Me.btnSelect.Enabled = False
        Else
            desparamid = g.item.Tag
            r1 = myParams.ParamRow(dtp, desparamid, "tfdescomprefparamid")
            If myUtils.cValTN(r1("ridestableid")) > 0 Then
                Me.btnSelect.Enabled = True
            Else
                Me.btnSelect.Enabled = False
            End If
        End If

    End Sub
    Private Sub PropertyGrid1_SelectedGridItemChanged(sender As Object, e As System.Windows.Forms.SelectedGridItemChangedEventArgs) Handles PropertyGrid1.SelectedGridItemChanged
        Dim g As PropertySpecDescriptor = CType(e.NewSelection.PropertyDescriptor, PropertySpecDescriptor)
        Me.CheckDesignTable(g)

    End Sub

    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click
        Dim r1 As DataRow, desparamid, destableid As Integer, dt As DataTable, ret As Object
        Dim g As PropertySpecDescriptor = Me.btnSelect.Tag
        desparamid = g.item.Tag
        r1 = myParams.ParamRow(dtp, desparamid)
        destableid = CInt(r1("ridestableid"))
        dt = myTables.DesignTable(destableid)
        ret = myTables.ShowDesignTable(r1, destableid, dt, Me.Parent)
        If Not ret Is Nothing Then
            bag3(g.Name) = CInt(ret)
            Me.PropertyGrid1.Refresh()
        End If

    End Sub
    Private Sub UpdateButtons(enable As Boolean)
        RaiseEvent UpdateApplyButton(Me, New UpdateButtonEventArgs(enable))
        RaiseEvent UpdateOkButton(Me, New UpdateButtonEventArgs(enable))
    End Sub

    Private Function validateAllParameters() As Boolean
        Return True
    End Function
    Public Function ApplyChanges() As Boolean Implements IParamEditorControl.ApplyChanges
        myParams.SaveBag(bag3, dtp, "tfdescomprefparamid")
        For Each r1 As DataRow In dtp.Select
            mDoc.SetRuleValue(r1("paramcode"), r1("paramvalue"))
        Next
        Return True
    End Function

    Public Function GetRulesCurrentValues() As IDictionary(Of String, Object) Implements IParamEditorControl.GetRulesCurrentValues
        Dim dic As New Dictionary(Of String, Object)
        myParams.SaveBag(bag3, dtp, "tfdescomprefparamid")
        For Each r1 As DataRow In dtp.Select
            dic.Add(r1("paramcode"), r1("paramvalue"))
        Next
        Return dic

    End Function

    Public Sub RefreshData() Implements IParamEditorControl.RefreshData
        dtp = CType(mDoc, clsComponentDocument).GenerateInputParamTable
        Me.LoadTable(dtp)
        Me.UpdateButtons(Me.validateAllParameters)
    End Sub

    Public Sub RefreshFromRulesCurrentValues(modifiedRules As IDictionary(Of String, Object)) Implements IParamEditorControl.RefreshFromRulesCurrentValues
        Dim dtp As DataTable = CType(mDoc, clsComponentDocument).GenerateInputParamTable
        For Each kvp In modifiedRules
            Dim nr As DataRow = myParams.AddUpdParam(dtp, kvp.Key, kvp.Value.GetType, kvp.Value, True)
        Next

        Me.LoadTable(dtp)

    End Sub
    Protected Friend Sub LoadTable(dt1 As DataTable)
        bag3 = New PropertyTable()
        Me.PropertyGrid1.SelectedObjects = New PropertyBag() {bag3}
        myParams.AddUpdParams(dt1, dt1, bag3, "", "tfdescomprefparamid")
        Me.PropertyGrid1.Refresh()
        If Me.PropertyGrid1.SelectedGridItem Is Nothing Then Me.CheckDesignTable(Nothing) Else Me.CheckDesignTable(Me.PropertyGrid1.SelectedGridItem.PropertyDescriptor)

    End Sub
End Class
