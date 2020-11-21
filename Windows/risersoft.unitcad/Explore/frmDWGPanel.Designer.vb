<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDWGPanel
    Inherits frmMax

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDWGPanel))
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.AxDwgThumbnail1 = New AxDWGTHUMBNAILLib.AxDwgThumbnail()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraPictureBox1 = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkBlocks = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnInsert = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTree2 = New Infragistics.Win.UltraWinTree.UltraTree()
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.AxDwgThumbnail1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.chkBlocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTree2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.AxDwgThumbnail1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(484, 203)
        '
        'AxDwgThumbnail1
        '
        Me.AxDwgThumbnail1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxDwgThumbnail1.Location = New System.Drawing.Point(0, 0)
        Me.AxDwgThumbnail1.Name = "AxDwgThumbnail1"
        Me.AxDwgThumbnail1.OcxState = CType(resources.GetObject("AxDwgThumbnail1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxDwgThumbnail1.Size = New System.Drawing.Size(484, 203)
        Me.AxDwgThumbnail1.TabIndex = 437
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraPictureBox1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(484, 203)
        '
        'UltraPictureBox1
        '
        Me.UltraPictureBox1.BorderShadowColor = System.Drawing.Color.Empty
        Me.UltraPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPictureBox1.Name = "UltraPictureBox1"
        Me.UltraPictureBox1.ScaleImage = Infragistics.Win.ScaleImage.Always
        Me.UltraPictureBox1.Size = New System.Drawing.Size(484, 203)
        Me.UltraPictureBox1.TabIndex = 0
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(484, 203)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraTabControl1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.UltraTree2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(759, 203)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(186, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(484, 203)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard
        Me.UltraTabControl1.TabIndex = 2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "tab1"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "tab2"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "tab3"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(484, 203)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkBlocks)
        Me.Panel2.Controls.Add(Me.btnInsert)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(670, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(89, 203)
        Me.Panel2.TabIndex = 1
        '
        'chkBlocks
        '
        Me.chkBlocks.Checked = True
        Me.chkBlocks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBlocks.Location = New System.Drawing.Point(12, 74)
        Me.chkBlocks.Name = "chkBlocks"
        Me.chkBlocks.Size = New System.Drawing.Size(65, 31)
        Me.chkBlocks.TabIndex = 4
        Me.chkBlocks.Text = "Show Blocks"
        '
        'btnInsert
        '
        Appearance35.FontData.BoldAsString = "True"
        Me.btnInsert.Appearance = Appearance35
        Me.btnInsert.Location = New System.Drawing.Point(11, 19)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(66, 42)
        Me.btnInsert.TabIndex = 3
        Me.btnInsert.Text = "Insert"
        '
        'UltraTree2
        '
        Me.UltraTree2.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraTree2.Location = New System.Drawing.Point(0, 0)
        Me.UltraTree2.Name = "UltraTree2"
        Me.UltraTree2.Size = New System.Drawing.Size(186, 203)
        Me.UltraTree2.TabIndex = 0
        '
        'frmDWGPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "frmDWGPanel"
        Me.ClientSize = New System.Drawing.Size(759, 203)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDWGPanel"
        Me.Text = "frmDWGPanel"
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.AxDwgThumbnail1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.chkBlocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTree2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents AxDwgThumbnail1 As AxDWGTHUMBNAILLib.AxDwgThumbnail
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraPictureBox1 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents chkBlocks As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Public WithEvents btnInsert As Infragistics.Win.Misc.UltraButton
    Public WithEvents UltraTree2 As Infragistics.Win.UltraWinTree.UltraTree
End Class
