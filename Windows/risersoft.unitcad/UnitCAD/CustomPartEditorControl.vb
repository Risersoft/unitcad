Imports System.Globalization
Imports System.Windows
Imports System.Windows.Forms
Imports System.Windows.Forms.Integration
Imports risersoft.unitcad.API

Friend Class CustomPartEditorControl
    Public Property ClassName() As String
    Public Property CustomControlType() As CustomPartEditorControl.ControlType
    Private Property DefaultClassName() As String


    Public Sub New()
        Me.DefaultClassName = GetType(ctlParamEditor).AssemblyQualifiedName
        Me.InitializeVariables()
    End Sub

    Public Sub New(part As IComponentDocument)
        Me.New()
        Dim ParamEditorClass As String = part.Definition("ParamEditorClass")
        Dim flag As Boolean = Me.ParseEditorString(ParamEditorClass)
    End Sub

    Private Function CreatePartEditorControl(customPanel As Panel) As IParamEditorControl
        Dim partEditorControl As IParamEditorControl = Nothing
        If Me.CustomControlType = CustomPartEditorControl.ControlType.Xaml Then
            partEditorControl = Me.LoadPEControlFromXaml(customPanel)
        ElseIf Me.CustomControlType = CustomPartEditorControl.ControlType.WinForms Then
            partEditorControl = Me.LoadPEControlFromWinForm(customPanel)
        End If
        Return partEditorControl
    End Function


    Private Sub InitializeVariables()
        Me.ClassName = Me.DefaultClassName
        Me.CustomControlType = CustomPartEditorControl.ControlType.WinForms
    End Sub

    Public Function LoadControl(customPanel As Panel) As IParamEditorControl
        Dim partEditorControl As IParamEditorControl = Me.CreatePartEditorControl(customPanel)
        If partEditorControl Is Nothing AndAlso Not String.Equals(Me.ClassName, Me.DefaultClassName, StringComparison.Ordinal) Then
            Me.InitializeVariables()
            partEditorControl = Me.CreatePartEditorControl(customPanel)
        End If
        Return partEditorControl
    End Function

    Private Function LoadPEControlFromWinForm(customPanel As Panel) As IParamEditorControl
        Try
            Dim type__1 As Type = Type.[GetType](Me.ClassName)
            If type__1 Is Nothing Then
                Dim currentCulture As CultureInfo = CultureInfo.CurrentCulture
                Dim partEditorGetTypeFailed As String = My.Resources.PartEditor_GetTypeFailed
                Dim className As Object() = New Object() {Me.ClassName}
                Dim str As String = String.Format(currentCulture, partEditorGetTypeFailed, className)
                System.Windows.Forms.MessageBox.Show(str, My.Resources.PartEditor_Title, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                Dim control As Control = TryCast(Activator.CreateInstance(type__1), Control)
                If control IsNot Nothing Then
                    control.TabStop = True
                    control.TabIndex = 0
                    control.Dock = DockStyle.Fill
                    customPanel.Controls.Add(control)
                    Dim partEditorControl As IParamEditorControl = TryCast(control, IParamEditorControl)
                    If partEditorControl Is Nothing Then
                        Dim cultureInfo__2 As CultureInfo = CultureInfo.CurrentCulture
                        Dim partEditorDoesNotImplementIParamEditorControl As String = My.Resources.PartEditor_DoesNotImplementIPartEditorControl
                        Dim objArray As Object() = New Object() {Me.ClassName}
                        Dim str1 As String = String.Format(cultureInfo__2, partEditorDoesNotImplementIParamEditorControl, objArray)
                        System.Windows.Forms.MessageBox.Show(str1, My.Resources.PartEditor_Title, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                    Return partEditorControl
                End If
            End If
        Catch exception1 As Exception
            Dim exception As Exception = exception1
            Dim currentCulture1 As CultureInfo = CultureInfo.CurrentCulture
            Dim partEditorErrorLoadingControl As String = My.Resources.PartEditor_ErrorLoadingControl
            Dim className1 As Object() = New Object() {Me.ClassName, exception.Message}
            Dim str2 As String = String.Format(currentCulture1, partEditorErrorLoadingControl, className1)
            System.Windows.Forms.MessageBox.Show(str2, My.Resources.PartEditor_Title, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
        Return Nothing
    End Function

    Private Function LoadPEControlFromXaml(customPanel As Panel) As IParamEditorControl
        Try
            Dim frameworkElement As FrameworkElement = TryCast(System.Windows.Application.LoadComponent(New Uri(Me.ClassName, UriKind.Relative)), FrameworkElement)
            If frameworkElement Is Nothing Then
                Dim currentCulture As CultureInfo = CultureInfo.CurrentCulture
                Dim partEditorLoadComponentFailed As String = My.Resources.PartEditor_LoadComponentFailed
                Dim className As Object() = New Object() {Me.ClassName}
                Dim str As String = String.Format(currentCulture, partEditorLoadComponentFailed, className)
                System.Windows.Forms.MessageBox.Show(str, My.Resources.PartEditor_Title, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                Dim elementHost As New ElementHost() With {
                    .Child = frameworkElement,
                    .Dock = DockStyle.Fill
                }
                customPanel.Controls.Add(elementHost)
                Dim partEditorControl As IParamEditorControl = TryCast(frameworkElement, IParamEditorControl)
                If partEditorControl Is Nothing Then
                    Dim cultureInfo__1 As CultureInfo = CultureInfo.CurrentCulture
                    Dim partEditorDoesNotImplementIParamEditorControl As String = My.Resources.PartEditor_DoesNotImplementIPartEditorControl
                    Dim objArray As Object() = New Object() {Me.ClassName}
                    Dim str1 As String = String.Format(cultureInfo__1, partEditorDoesNotImplementIParamEditorControl, objArray)
                    System.Windows.Forms.MessageBox.Show(str1, My.Resources.PartEditor_Title, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
                Return partEditorControl
            End If
        Catch exception1 As Exception
            Dim exception As Exception = exception1
            Dim currentCulture1 As CultureInfo = CultureInfo.CurrentCulture
            Dim partEditorErrorLoadingControl As String = My.Resources.PartEditor_ErrorLoadingControl
            Dim className1 As Object() = New Object() {Me.ClassName, exception.Message}
            Dim str2 As String = String.Format(currentCulture1, partEditorErrorLoadingControl, className1)
            System.Windows.Forms.MessageBox.Show(str2, My.Resources.PartEditor_Title, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
        Return Nothing
    End Function

    Private Function ParseEditorString(editorString As String) As Boolean
        If editorString.Trim.Length > 0 Then
            Me.ClassName = editorString
            If Not editorString.EndsWith(".xaml", StringComparison.OrdinalIgnoreCase) Then
                Me.CustomControlType = CustomPartEditorControl.ControlType.WinForms
            Else
                Me.CustomControlType = CustomPartEditorControl.ControlType.Xaml
            End If
            Return True
        End If
    End Function

    Public Enum ControlType
        Xaml
        WinForms
    End Enum
End Class
Public Class PartEditorDialogClosedEventArgs
    Inherits EventArgs
    Private ReadOnly _contextPart As IComponentDocument

    Private ReadOnly _isOkButtonClicked As Boolean

    Public ReadOnly Property ContextPart() As IComponentDocument
        Get
            Return Me._contextPart
        End Get
    End Property

    Public ReadOnly Property IsOkButtonClicked() As Boolean
        Get
            Return Me._isOkButtonClicked
        End Get
    End Property

    Public Sub New(contextPart As IComponentDocument, okButtonClicked As Boolean)
        Me._contextPart = contextPart
        Me._isOkButtonClicked = okButtonClicked
    End Sub
End Class
