Imports System.Windows.Forms

<System.Runtime.InteropServices.ComVisible(False)> Public Class EditAttribute
    Public Property AttributeName() As String
        Get
            Return Me.txtAttributeName.Text
        End Get
        Set(ByVal value As String)
            Me.txtAttributeName.Text = value
        End Set
    End Property

    Public Property AttributeValue() As String
        Get
            If AttributeType <> Inventor.ValueTypeEnum.kBooleanType Then
                Return Me.txtAttributeValue.Text
            Else
                Return Me.cboBooleanValue.Text
            End If
        End Get
        Set(ByVal value As String)
            If AttributeType <> Inventor.ValueTypeEnum.kBooleanType Then
                Me.txtAttributeValue.Text = value
            Else
                Dim boolValue As Boolean = CType(value, Boolean)

                If boolValue = True Then
                    cboBooleanValue.SelectedIndex = 0
                Else
                    cboBooleanValue.SelectedIndex = 1
                End If
            End If
        End Set
    End Property

    Public Property AttributeType() As Inventor.ValueTypeEnum
        Get
            Select Case cboAttributeType.SelectedIndex
                Case 0
                    Return Inventor.ValueTypeEnum.kStringType
                Case 1
                    Return Inventor.ValueTypeEnum.kIntegerType
                Case 2
                    Return Inventor.ValueTypeEnum.kDoubleType
                Case 3
                    Return Inventor.ValueTypeEnum.kByteArrayType
                    'Case 4
                    '    Return Inventor.ValueTypeEnum.kBooleanType
            End Select
        End Get
        Set(ByVal value As Inventor.ValueTypeEnum)
            ' Set the default.
            txtAttributeValue.Visible = True
            cboBooleanValue.Visible = False

            Select Case value
                Case Inventor.ValueTypeEnum.kStringType
                    cboAttributeType.SelectedIndex = 0
                Case Inventor.ValueTypeEnum.kIntegerType
                    cboAttributeType.SelectedIndex = 1
                Case Inventor.ValueTypeEnum.kDoubleType
                    cboAttributeType.SelectedIndex = 2
                Case Inventor.ValueTypeEnum.kByteArrayType
                    cboAttributeType.SelectedIndex = 3
                    'Case Inventor.ValueTypeEnum.kBooleanType
                    '    cboAttributeType.SelectedIndex = 4

                    '    ' Change the default for a boolean value.
                    '    txtAttributeValue.Visible = False
                    '    cboBooleanValue.Visible = True

                    '    cboAttributeType.SelectedIndex = 0
            End Select
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public WriteOnly Property EditMode() As Boolean
        Set(ByVal value As Boolean)
            If value = True Then
                Me.Text = "Edit Attribute"
                Me.cboAttributeType.Enabled = False
            Else
                Me.Text = "Create Attribute"
                Me.txtAttributeName.Text = ""
                Me.txtAttributeValue.Text = ""
                Me.cboAttributeType.SelectedIndex = -1
                Me.cboAttributeType.Enabled = True
            End If
        End Set
    End Property

    Private Sub EditAttribute_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Me.Text = "Create Attribute" Then
            Me.txtAttributeName.Focus()
            Me.txtAttributeName.SelectAll()
        End If
    End Sub


    'Private Sub cboAttributeType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAttributeType.SelectedIndexChanged
    '    Select Case cboAttributeType.SelectedIndex
    '        Case 0, 1, 2, 4
    '            txtAttributeValue.Visible = True
    '            cboBooleanValue.Visible = False
    '        Case 3
    '            txtAttributeValue.Visible = False
    '            cboBooleanValue.Visible = True
    '            cboBooleanValue.SelectedIndex = 0
    '    End Select
    'End Sub

    Private Sub EditAttribute_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
