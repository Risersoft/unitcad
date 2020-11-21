<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExp
    Inherits frmMax

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExp))
        Me.Browser1 = New ExplorerControls.Browser()
        Me.ExpListColumn7 = CType(New ExplorerControls.ExpListColumn(), ExplorerControls.ExpListColumn)
        Me.ExpListColumn8 = CType(New ExplorerControls.ExpListColumn(), ExplorerControls.ExpListColumn)
        Me.ExpListColumn9 = CType(New ExplorerControls.ExpListColumn(), ExplorerControls.ExpListColumn)
        Me.ExpListColumn10 = CType(New ExplorerControls.ExpListColumn(), ExplorerControls.ExpListColumn)
        Me.ExpListColumn11 = CType(New ExplorerControls.ExpListColumn(), ExplorerControls.ExpListColumn)
        Me.ExpListColumn12 = CType(New ExplorerControls.ExpListColumn(), ExplorerControls.ExpListColumn)
        Me.subFoldersColumn = CType(New ExplorerControls.ExpListColumn(), ExplorerControls.ExpListColumn)
        Me.BrowseForFolder1 = New ExplorerControls.BrowseForFolder(Me.components)
        Me.OpenFileDialog1 = New ExplorerControls.OpenFileDialog(Me.components)
        Me.ExpListColumn13 = CType(New ExplorerControls.ExpListColumn(), ExplorerControls.ExpListColumn)
        Me.ExpListColumn14 = CType(New ExplorerControls.ExpListColumn(), ExplorerControls.ExpListColumn)
        Me.ExpListColumn15 = CType(New ExplorerControls.ExpListColumn(), ExplorerControls.ExpListColumn)
        Me.ExpListColumn16 = CType(New ExplorerControls.ExpListColumn(), ExplorerControls.ExpListColumn)
        Me.ExpListColumn17 = CType(New ExplorerControls.ExpListColumn(), ExplorerControls.ExpListColumn)
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Browser1
        '
        Me.Browser1.Columns.AddRange(New ExplorerControls.ExpListColumn() {Me.ExpListColumn7, Me.ExpListColumn8, Me.ExpListColumn9, Me.ExpListColumn10, Me.ExpListColumn11, Me.ExpListColumn12, Me.subFoldersColumn})
        Me.Browser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Browser1.Filter = New String() {"doc", "pdf", "xls", "txt", "jpg", "iam", "ipt"}
        Me.Browser1.Location = New System.Drawing.Point(0, 0)
        Me.Browser1.Name = "Browser1"
        Me.Browser1.Size = New System.Drawing.Size(793, 452)
        Me.Browser1.TabIndex = 0
        Me.Browser1.TileSize = New System.Drawing.Size(200, 80)
        Me.Browser1.View = ExplorerControls.ExpListView.Thumbnail
        '
        'ExpListColumn7
        '
        Me.ExpListColumn7.ColumnType = ExplorerControls.ExpListColumnType.Name
        Me.ExpListColumn7.Name = "ExpListColumn7"
        Me.ExpListColumn7.Text = "Name"
        Me.ExpListColumn7.Width = 130
        '
        'ExpListColumn8
        '
        Me.ExpListColumn8.ColumnType = ExplorerControls.ExpListColumnType.Type
        Me.ExpListColumn8.Name = "ExpListColumn8"
        Me.ExpListColumn8.Text = "Type"
        Me.ExpListColumn8.Visible = False
        Me.ExpListColumn8.Width = 90
        '
        'ExpListColumn9
        '
        Me.ExpListColumn9.ColumnType = ExplorerControls.ExpListColumnType.Size
        Me.ExpListColumn9.Name = "ExpListColumn9"
        Me.ExpListColumn9.Text = "Size"
        Me.ExpListColumn9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ExpListColumn9.Visible = False
        Me.ExpListColumn9.Width = 50
        '
        'ExpListColumn10
        '
        Me.ExpListColumn10.ColumnType = ExplorerControls.ExpListColumnType.Modified
        Me.ExpListColumn10.Name = "ExpListColumn10"
        Me.ExpListColumn10.Text = "Date Modified"
        Me.ExpListColumn10.Visible = False
        Me.ExpListColumn10.Width = 85
        '
        'ExpListColumn11
        '
        Me.ExpListColumn11.ColumnType = ExplorerControls.ExpListColumnType.Created
        Me.ExpListColumn11.Name = "ExpListColumn11"
        Me.ExpListColumn11.Text = "Date Created"
        Me.ExpListColumn11.Visible = False
        Me.ExpListColumn11.Width = 85
        '
        'ExpListColumn12
        '
        Me.ExpListColumn12.ColumnType = ExplorerControls.ExpListColumnType.Path
        Me.ExpListColumn12.Name = "ExpListColumn12"
        Me.ExpListColumn12.Text = "Path"
        Me.ExpListColumn12.Visible = False
        Me.ExpListColumn12.Width = 185
        '
        'subFoldersColumn
        '
        Me.subFoldersColumn.ColumnType = ExplorerControls.ExpListColumnType.CustomText
        Me.subFoldersColumn.Text = "HasSubFolders"
        Me.subFoldersColumn.Width = 130
        '
        'BrowseForFolder1
        '
        Me.BrowseForFolder1.StartLocation = System.Windows.Forms.FormStartPosition.CenterParent
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Columns.AddRange(New ExplorerControls.ExpListColumn() {Me.ExpListColumn13, Me.ExpListColumn14, Me.ExpListColumn15, Me.ExpListColumn16, Me.ExpListColumn17})
        Me.OpenFileDialog1.Filter = "Text Documents (*.txt|*.txt|All Files (*.*)|*.*"
        Me.OpenFileDialog1.SelectedFilterIndex = 0
        Me.OpenFileDialog1.StartLocation = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.OpenFileDialog1.ViewStyle = ExplorerControls.ExpListView.Details
        '
        'ExpListColumn13
        '
        Me.ExpListColumn13.ColumnType = ExplorerControls.ExpListColumnType.Name
        Me.ExpListColumn13.Text = "Name"
        Me.ExpListColumn13.Width = 130
        '
        'ExpListColumn14
        '
        Me.ExpListColumn14.ColumnType = ExplorerControls.ExpListColumnType.Size
        Me.ExpListColumn14.Text = "Size"
        Me.ExpListColumn14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ExpListColumn14.Width = 50
        '
        'ExpListColumn15
        '
        Me.ExpListColumn15.ColumnType = ExplorerControls.ExpListColumnType.Type
        Me.ExpListColumn15.Text = "Type"
        Me.ExpListColumn15.Width = 90
        '
        'ExpListColumn16
        '
        Me.ExpListColumn16.ColumnType = ExplorerControls.ExpListColumnType.Modified
        Me.ExpListColumn16.Text = "Date Modified"
        Me.ExpListColumn16.Width = 85
        '
        'ExpListColumn17
        '
        Me.ExpListColumn17.ColumnType = ExplorerControls.ExpListColumnType.Created
        Me.ExpListColumn17.Text = "Date Created"
        Me.ExpListColumn17.Visible = False
        Me.ExpListColumn17.Width = 85
        '
        'frmExp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "TestApp"
        Me.ClientSize = New System.Drawing.Size(793, 452)
        Me.Controls.Add(Me.Browser1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmExp"
        Me.Text = "TestApp"
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ExpListColumn7 As ExplorerControls.ExpListColumn
    Friend WithEvents ExpListColumn8 As ExplorerControls.ExpListColumn
    Friend WithEvents ExpListColumn9 As ExplorerControls.ExpListColumn
    Friend WithEvents ExpListColumn10 As ExplorerControls.ExpListColumn
    Friend WithEvents ExpListColumn11 As ExplorerControls.ExpListColumn
    Friend WithEvents ExpListColumn12 As ExplorerControls.ExpListColumn
    Friend WithEvents BrowseForFolder1 As ExplorerControls.BrowseForFolder
    Friend WithEvents OpenFileDialog1 As ExplorerControls.OpenFileDialog
    Friend WithEvents subFoldersColumn As ExplorerControls.ExpListColumn
    Friend WithEvents ExpListColumn13 As ExplorerControls.ExpListColumn
    Friend WithEvents ExpListColumn14 As ExplorerControls.ExpListColumn
    Friend WithEvents ExpListColumn15 As ExplorerControls.ExpListColumn
    Friend WithEvents ExpListColumn16 As ExplorerControls.ExpListColumn
    Friend WithEvents ExpListColumn17 As ExplorerControls.ExpListColumn
    Public WithEvents Browser1 As ExplorerControls.Browser
End Class
