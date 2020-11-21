Imports System.Xml
Imports Infragistics.Win.UltraWinTabControl
Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmEntityMarker
    Inherits frmMax


#Region " Windows Form Designer generated code "

    

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSelect = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnDeleteAll = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelSel = New Infragistics.Win.Misc.UltraButton()
        Me.btnUnHighlightAll = New Infragistics.Win.Misc.UltraButton()
        Me.btnHightLightAll = New Infragistics.Win.Misc.UltraButton()
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(756, 409)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.UltraLabel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 44)
        Me.Panel1.TabIndex = 0
        '
        'btnSelect
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnSelect.Appearance = Appearance2
        Me.btnSelect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSelect.Location = New System.Drawing.Point(350, 0)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 44)
        Me.btnSelect.TabIndex = 357
        Me.btnSelect.Text = "Select"
        '
        'UltraLabel3
        '
        Appearance1.TextHAlignAsString = "Left"
        Me.UltraLabel3.Appearance = Appearance1
        Me.UltraLabel3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.UltraLabel3.Location = New System.Drawing.Point(35, 12)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(300, 14)
        Me.UltraLabel3.TabIndex = 356
        Me.UltraLabel3.Text = "Select a face or edge to make it appear in this list"
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 44)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(438, 370)
        Me.UltraGrid1.TabIndex = 24
        Me.UltraGrid1.Text = "Core Material"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.btnUnHighlightAll)
        Me.Panel4.Controls.Add(Me.btnHightLightAll)
        Me.Panel4.Controls.Add(Me.btnDeleteAll)
        Me.Panel4.Controls.Add(Me.btnDelSel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 414)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(438, 34)
        Me.Panel4.TabIndex = 74
        '
        'btnDeleteAll
        '
        Appearance5.FontData.BoldAsString = "True"
        Me.btnDeleteAll.Appearance = Appearance5
        Me.btnDeleteAll.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDeleteAll.Location = New System.Drawing.Point(262, 0)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(88, 34)
        Me.btnDeleteAll.TabIndex = 1
        Me.btnDeleteAll.Text = "Delete All"
        '
        'btnDelSel
        '
        Appearance6.FontData.BoldAsString = "True"
        Me.btnDelSel.Appearance = Appearance6
        Me.btnDelSel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelSel.Location = New System.Drawing.Point(350, 0)
        Me.btnDelSel.Name = "btnDelSel"
        Me.btnDelSel.Size = New System.Drawing.Size(88, 34)
        Me.btnDelSel.TabIndex = 0
        Me.btnDelSel.Text = "Delete Selected"
        '
        'btnUnHighlightAll
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnUnHighlightAll.Appearance = Appearance3
        Me.btnUnHighlightAll.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnUnHighlightAll.Location = New System.Drawing.Point(86, 0)
        Me.btnUnHighlightAll.Name = "btnUnHighlightAll"
        Me.btnUnHighlightAll.Size = New System.Drawing.Size(88, 34)
        Me.btnUnHighlightAll.TabIndex = 3
        Me.btnUnHighlightAll.Text = "Unhighlight All"
        '
        'btnHightLightAll
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnHightLightAll.Appearance = Appearance4
        Me.btnHightLightAll.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnHightLightAll.Location = New System.Drawing.Point(174, 0)
        Me.btnHightLightAll.Name = "btnHightLightAll"
        Me.btnHightLightAll.Size = New System.Drawing.Size(88, 34)
        Me.btnHightLightAll.TabIndex = 2
        Me.btnHightLightAll.Text = "Highlight All"
        '
        'frmEntityMarker
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Entity Marker"
        Me.ClientSize = New System.Drawing.Size(438, 448)
        Me.Controls.Add(Me.UltraGrid1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.risersoft.unitcad.iv.My.MySettings.Default, "EntityMarkerLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = Global.risersoft.unitcad.iv.My.MySettings.Default.EntityMarkerLocation
        Me.Name = "frmEntityMarker"
        Me.ShowInTaskbar = False
        Me.Text = "Entity Marker"
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnDeleteAll As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelSel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnSelect As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnUnHighlightAll As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnHightLightAll As Infragistics.Win.Misc.UltraButton

#End Region
End Class

