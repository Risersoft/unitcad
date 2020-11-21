Imports System.ComponentModel
Imports System.Globalization
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Forms
Imports System.Windows.Forms.Integration
Imports risersoft.unitcad.API

Public Class frmParamEditor
    Inherits frmMax
    Private provider As ICadModelProvider
    Private pws As PersistWindowState
    Private _closedUsingButtons As Boolean
    Private m_needsClosingValidation As Boolean
    Private m_previousPartName As String
    Private m_inventorInteractionEvents As Object
    Private m_dialogButtonSize As System.Drawing.Size
    Private m_partEditorControl As IParamEditorControl
    Private m_standardPartEditorControl As ctlParamEditor
    Private m_previousPartEditorControl As Control
    Public IsAutomaticUpdateEnabled As IsAutomaticUpdateEnabledHandler
    Public Shared Property CurrentPartEditorDialog() As frmParamEditor
    Friend Property Mode() As frmParamEditor.ProcessingMode


    Friend ReadOnly Property NeedsValidation() As Boolean
        Get
            Return Me.m_needsClosingValidation
        End Get
    End Property

    Private WriteOnly Property ShowApplyButton() As Boolean
        Set
            Me.applyButton.Visible = Value
        End Set
    End Property

    Private Sub New()
        Me.OnCreate()
    End Sub

    Public Sub New(contextPart As IComponentDocument, interactionEvents As Object, provider As ICadModelProvider)
        Me.OnCreate()
        Me.provider = provider
        Me.SetContextPart(contextPart, interactionEvents)
    End Sub

    Public Sub New(provider As ICadModelProvider)
        Me.OnCreate()
        Me.provider = provider
        Me.ShowApplyButton = False
    End Sub

    Private Async Sub applyButton_Click(sender As Object, e As EventArgs) Handles applyButton.Click
        Me.UpdateApplyButtonStatus(Me, New UpdateButtonEventArgs(False))
        Await Me.ApplyChanges()
        Me.RefreshData()
    End Sub

    Private Async Function ApplyChanges() As Task(Of Boolean)
        Dim flag As Boolean = False, cont As Boolean = False
        Dim part As IComponentDocument = Nothing
        Try
            If Me.partNameTextBox.Visible AndAlso Not String.Equals(Me.partNameTextBox.Text, Me.m_previousPartName, StringComparison.Ordinal) Then
                cont = Me.ChangePartName(Me.partNameTextBox.Text, Me.m_partEditorControl.ContextDocument.Parent)
            Else
                cont = True
            End If
            If cont Then
                Dim flag1 As Boolean = Me.m_partEditorControl.ApplyChanges()
                If flag1 AndAlso Me.IsAutomaticUpdateEnabled IsNot Nothing AndAlso Me.IsAutomaticUpdateEnabled() Then
                End If
                flag1 = Await Me.UpdateModelAsync
                flag = flag1
            End If
        Catch exception As Exception
            flag = False
        End Try
        Return flag
    End Function

    Private Function ChangePartName(newPartName As String, parentPart As IComponentDocument) As Boolean
        Try
            If parentPart(newPartName) Is Nothing Then
                Me.m_partEditorControl.ContextDocument.Name = newPartName
                Me.m_previousPartName = newPartName
                Return True
            End If
        Catch exception1 As Exception
            Dim exception As Exception = exception1
            Dim currentCulture As CultureInfo = CultureInfo.CurrentCulture
            Dim errorAddDynamicChild As String = My.Resources.Error_AddDynamicChild
            Dim objArray As Object() = New Object() {newPartName, exception.Message}
            Dim str As String = String.Format(currentCulture, errorAddDynamicChild, objArray)
            Dim partEditorTitle As String = My.Resources.PartEditor_Title
            System.Windows.Forms.MessageBox.Show(Me, str, partEditorTitle, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Throw New ApplicationException(str, exception)
        End Try
        Return False
    End Function

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click
        Me.RaisePartEditorDialogClosed(False)
        Me.m_needsClosingValidation = False
        Me._closedUsingButtons = True
        MyBase.Close()
        Me.m_needsClosingValidation = True
        Me._closedUsingButtons = False
    End Sub

    Private Sub ConfigureControl(configureToggleButton As Boolean)
        Dim controlConfiguration As EditorWindowConfig = Me.m_partEditorControl.WindowConfiguration
        If controlConfiguration IsNot Nothing Then
            Dim preferredSize As System.Drawing.Size = controlConfiguration.PreferredSize
            MyBase.Height = preferredSize.Height + Me.m_dialogButtonSize.Height
            Dim size As System.Drawing.Size = controlConfiguration.PreferredSize
            MyBase.Width = size.Width + Me.m_dialogButtonSize.Width
            MyBase.FormBorderStyle = (If(controlConfiguration.IsResizable, System.Windows.Forms.FormBorderStyle.Sizable, System.Windows.Forms.FormBorderStyle.FixedDialog))
            If configureToggleButton Then
                Me.m_switchEditors.Visible = controlConfiguration.AllowStandardPartEditor
                If controlConfiguration.IsResizable Then
                    Me.pws = New PersistWindowState(Me)
                End If
            End If
        End If
    End Sub

    Private Async Function CreatePart(newPartName As String, parentPart As IComponentDocument, partDefinition As IComponentDefinition) As Task(Of IComponentDocument)
        Await parentPart.AddDynamicChild(newPartName, partDefinition)
        Me.m_previousPartName = newPartName
        Return parentPart(newPartName)
    End Function

    Private Sub HookControlEvents()
        AddHandler Me.m_partEditorControl.UpdateOkButton, New EventHandler(Of UpdateButtonEventArgs)(AddressOf Me.UpdateOkButtonStatus)
        AddHandler Me.m_partEditorControl.UpdateApplyButton, New EventHandler(Of UpdateButtonEventArgs)(AddressOf Me.UpdateApplyButtonStatus)
    End Sub


    Private Sub LoadPartEditorControl(part As IComponentDocument)
        Me.m_partEditorControl = (New CustomPartEditorControl(part)).LoadControl(Me.customPanel)
        If Me.m_partEditorControl IsNot Nothing Then
            Me.ConfigureControl(True)
            Me.HookControlEvents()
            Me.UpdateApplyButtonStatus(Me, New UpdateButtonEventArgs(False))
        End If
    End Sub

    Private Sub m_switchEditors_Click(sender As Object, e As EventArgs) Handles m_switchEditors.Click
        If Me.m_partEditorControl Is Nothing Then
            Return
        End If
        Dim mPartEditorControl As ctlParamEditor = TryCast(Me.m_partEditorControl, ctlParamEditor)
        Dim rulesCurrentValues As IDictionary(Of String, Object) = Me.m_partEditorControl.GetRulesCurrentValues()
        If mPartEditorControl Is Nothing Then
            Me.m_previousPartEditorControl = TryCast(Me.m_partEditorControl, Control)
            Me.customPanel.Controls.Remove(Me.m_previousPartEditorControl)
            If Me.m_standardPartEditorControl IsNot Nothing Then
                Me.m_partEditorControl = Me.m_standardPartEditorControl
                Me.customPanel.Controls.Add(Me.m_standardPartEditorControl)
                Me.ConfigureControl(False)
            Else
                Dim contextPart As IComponentDocument = Me.m_partEditorControl.ContextDocument
                Me.m_partEditorControl = (New CustomPartEditorControl()).LoadControl(Me.customPanel)
                Me.m_standardPartEditorControl = TryCast(Me.m_partEditorControl, ctlParamEditor)
                Me.m_partEditorControl.InventorInteractionEventsObject = Me.m_inventorInteractionEvents
                Me.m_partEditorControl.ContextDocument = contextPart
                Me.ConfigureControl(False)
                Me.HookControlEvents()
            End If
        ElseIf Me.m_previousPartEditorControl IsNot Nothing Then
            Me.m_standardPartEditorControl = mPartEditorControl
            Me.customPanel.Controls.Remove(Me.m_standardPartEditorControl)
            Me.customPanel.Controls.Add(Me.m_previousPartEditorControl)
            Me.m_partEditorControl = TryCast(Me.m_previousPartEditorControl, IParamEditorControl)
            Me.ConfigureControl(False)
        End If
        Me.m_partEditorControl.RefreshFromRulesCurrentValues(rulesCurrentValues)
    End Sub

    Private Async Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Me.UpdateOkButtonStatus(Me, New UpdateButtonEventArgs(False))
        If Not Await Me.ApplyChanges() Then
            Me.RefreshData()
            Return
        End If
        Me.RaisePartEditorDialogClosed(True)
        Me._closedUsingButtons = True
        MyBase.Close()
        Me._closedUsingButtons = False
    End Sub

    Protected Overrides Sub OnClosed(e As EventArgs)
        frmParamEditor.CurrentPartEditorDialog = Nothing
        MyBase.OnClosed(e)
    End Sub

    Private Sub OnCreate()
        frmParamEditor.CurrentPartEditorDialog = Me
        Me.InitializeComponent()
        Me.m_dialogButtonSize = New System.Drawing.Size(MyBase.Width - Me.customPanel.Width, MyBase.Height - Me.customPanel.Height)
        Me.m_needsClosingValidation = True
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        e.Cancel = False
        MyBase.OnFormClosing(e)
        If Not Me._closedUsingButtons Then
            Me.RaisePartEditorDialogClosed(False)
        End If
    End Sub

    Private Sub partNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles partNameTextBox.TextChanged
        Me.ValidatePartName()
    End Sub

    Private Sub partNameTextBox_Validating(sender As Object, e As CancelEventArgs) Handles partNameTextBox.Validating
        If Me.m_needsClosingValidation AndAlso Not Me.ValidatePartName() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub RaisePartEditorDialogClosed(okButtonClicked As Boolean)
        RaiseEvent PartEditorDialogClosed(Me, New PartEditorDialogClosedEventArgs(Me.m_partEditorControl.ContextDocument, okButtonClicked))
    End Sub

    Private Sub RefreshData()
        Try
            Me.m_partEditorControl.RefreshData()
        Catch exception1 As Exception
            Dim exception As Exception = exception1
            Dim currentCulture As CultureInfo = CultureInfo.CurrentCulture
            Dim partEditorCustomRefreshException As String = My.Resources.PartEditor_CustomRefreshException
            Dim message As Object() = New Object() {exception.Message}
            Dim str As String = String.Format(currentCulture, partEditorCustomRefreshException, message)
            System.Windows.Forms.MessageBox.Show(str, My.Resources.PartEditor_Title, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub ReportApplyChangesException(e As Exception)
        Dim currentCulture As CultureInfo = CultureInfo.CurrentCulture
        Dim errorApplyChanges As String = My.Resources.Error_ApplyChanges
        Dim message As Object() = New Object() {e.Message}
        Dim str As String = String.Format(currentCulture, errorApplyChanges, message)
        Dim partEditorTitle As String = My.Resources.PartEditor_Title
        System.Windows.Forms.MessageBox.Show(Me, str, partEditorTitle, MessageBoxButtons.OK, MessageBoxIcon.Hand)
    End Sub

    Private Sub SetContextPart(part As IComponentDocument, interactionEvents As Object)
        Me.partNamePanel.Visible = False
        Me.Mode = frmParamEditor.ProcessingMode.Edit
        Me.LoadPartEditorControl(part)
        Me.SetInventorInteractionEventsObject(interactionEvents)
        Me.m_partEditorControl.ContextDocument = part
    End Sub

    Public Async Function SetCreationContext(parentPart As IComponentDocument, partDesign As IComponentDefinition, interactionEvents As Object) As Task
        Me.partNamePanel.Visible = True
        Me.Mode = frmParamEditor.ProcessingMode.Create
        If partDesign IsNot Nothing Then
            Dim str1 As String = myIntent.UniqueNameFromCode(partDesign.Name, parentPart)
            Dim part As IComponentDocument = Await Me.CreatePart(str1, parentPart, partDesign)
            Me.LoadPartEditorControl(part)
            Me.SetInventorInteractionEventsObject(interactionEvents)
            Me.partNameTextBox.Text = str1
            Me.m_partEditorControl.ContextDocument = part
        End If
    End Function

    Private Sub SetInventorInteractionEventsObject(interactionEvents As Object)
        Me.m_inventorInteractionEvents = interactionEvents
        Me.m_partEditorControl.InventorInteractionEventsObject = interactionEvents
    End Sub

    Private Sub UpdateApplyButtonStatus(sender As Object, args As UpdateButtonEventArgs)
        Me.applyButton.Enabled = args.Enabled
    End Sub

    Private Async Function UpdateModelAsync() As Task(Of Boolean)
        Dim status As Boolean = True
        Try
            Await provider.UpdateModelAsync(Me)
        Catch ex As Exception
            Dim result = MsgBox(ex.Message & vbCrLf & "Suspend?", MsgBoxStyle.YesNoCancel, myWinApp.Vars("appname"))
            If result = vbYes Then
                RaiseEvent DisableAutomaticModelUpdate(Me, EventArgs.Empty)
            ElseIf result = vbCancel Then
                status = False
            End If
        End Try
        Return status
    End Function

    Private Sub UpdateOkButtonStatus(sender As Object, args As UpdateButtonEventArgs)
        Me.okButton.Enabled = args.Enabled
    End Sub

    Private Function ValidatePartName() As Boolean
        If Not Me.partNamePanel.Visible Then
            Return True
        End If
        Dim oRet As clsProcOutput = myIntent.ValidateIdentifier(Me.partNameTextBox.Text, False)
        If Not oRet.Success Then
            Me.errorProvider1.SetError(Me.partNameTextBox, oRet.Description)
            Return False
        End If
        If Me.m_partEditorControl.ContextDocument.Parent IsNot Nothing Then
            Dim child = Me.m_partEditorControl.ContextDocument.Parent(Me.partNameTextBox.Text)
            If child IsNot Nothing AndAlso Not String.Equals(child.Name, Me.m_partEditorControl.ContextDocument.Name, StringComparison.OrdinalIgnoreCase) Then
                Me.errorProvider1.SetError(Me.partNameTextBox, My.Resources.PartWithThisNameAlreadyExists)
                Return False
            End If
        End If
        Me.errorProvider1.SetError(Me.partNameTextBox, String.Empty)
        Return True
    End Function

    Public Event DisableAutomaticModelUpdate As EventHandler

    Public Event PartEditorDialogClosed As EventHandler(Of PartEditorDialogClosedEventArgs)


    Public Delegate Function IsAutomaticUpdateEnabledHandler() As Boolean


    Friend Enum ProcessingMode
        Edit
        Create
    End Enum

End Class
