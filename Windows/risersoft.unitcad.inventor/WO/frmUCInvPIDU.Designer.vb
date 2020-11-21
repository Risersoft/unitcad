Imports System.Xml
Imports Infragistics.Win.UltraWinTabControl
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmUCInvPIDU
    Inherits frmWizMax

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_OrderDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl17 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Customer As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents txt_DescripWO As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab22 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab23 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl17 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_FileNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Customer = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txt_DescripWO = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_OrderDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_FileNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DescripWO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_OrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraProgressBar1
        '
        Me.UltraProgressBar1.Size = New System.Drawing.Size(200, 39)
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(0, 521)
        Me.Panel4.Size = New System.Drawing.Size(856, 39)
        '
        'PanelBtn
        '
        Me.PanelBtn.Location = New System.Drawing.Point(0, 463)
        Me.PanelBtn.Size = New System.Drawing.Size(856, 58)
        '
        'UltraTabPageControl17
        '
        Me.UltraTabPageControl17.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl17.Name = "UltraTabPageControl17"
        Me.UltraTabPageControl17.Size = New System.Drawing.Size(852, 379)
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(852, 379)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_FileNum)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_Customer)
        Me.Panel1.Controls.Add(Me.lblNum)
        Me.Panel1.Controls.Add(Me.txt_DescripWO)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.dt_OrderDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 58)
        Me.Panel1.TabIndex = 4
        '
        'txt_FileNum
        '
        Me.txt_FileNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FileNum.Location = New System.Drawing.Point(710, 33)
        Me.txt_FileNum.Name = "txt_FileNum"
        Me.txt_FileNum.ReadOnly = True
        Me.txt_FileNum.Size = New System.Drawing.Size(143, 21)
        Me.txt_FileNum.TabIndex = 238
        Me.txt_FileNum.Text = "UltraTextEditor8"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(655, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 239
        Me.Label1.Text = "File No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(19, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 235
        Me.Label6.Text = "Customer"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Customer
        '
        Me.txt_Customer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Customer.Location = New System.Drawing.Point(84, 8)
        Me.txt_Customer.Name = "txt_Customer"
        Me.txt_Customer.ReadOnly = True
        Me.txt_Customer.Size = New System.Drawing.Size(554, 21)
        Me.txt_Customer.TabIndex = 234
        Me.txt_Customer.Text = "UltraTextEditor1"
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNum.Location = New System.Drawing.Point(18, 31)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(63, 16)
        Me.lblNum.TabIndex = 231
        Me.lblNum.Text = "Description"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_DescripWO
        '
        Me.txt_DescripWO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance9.FontData.BoldAsString = "True"
        Appearance9.FontData.SizeInPoints = 10.0!
        Me.txt_DescripWO.Appearance = Appearance9
        Me.txt_DescripWO.Location = New System.Drawing.Point(84, 31)
        Me.txt_DescripWO.Name = "txt_DescripWO"
        Me.txt_DescripWO.ReadOnly = True
        Me.txt_DescripWO.Size = New System.Drawing.Size(554, 24)
        Me.txt_DescripWO.TabIndex = 230
        Me.txt_DescripWO.Text = "UltraTextEditor1"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance12.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance12
        Me.UltraLabel1.Location = New System.Drawing.Point(664, 9)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(40, 23)
        Me.UltraLabel1.TabIndex = 16
        Me.UltraLabel1.Text = "Date"
        '
        'dt_OrderDate
        '
        Me.dt_OrderDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_OrderDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_OrderDate.Location = New System.Drawing.Point(710, 8)
        Me.dt_OrderDate.Name = "dt_OrderDate"
        Me.dt_OrderDate.NullText = "Not Defined"
        Me.dt_OrderDate.ReadOnly = True
        Me.dt_OrderDate.Size = New System.Drawing.Size(143, 21)
        Me.dt_OrderDate.TabIndex = 15
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl17)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl12)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 58)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance11.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance11
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.ShowTabListButton = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraTabControl1.Size = New System.Drawing.Size(856, 405)
        Me.UltraTabControl1.TabIndex = 10
        Me.UltraTabControl1.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.SingleRowSizeToFit
        UltraTab22.Key = "params"
        UltraTab22.TabPage = Me.UltraTabPageControl17
        UltraTab22.Text = "Global Parameters"
        UltraTab23.Key = "output"
        UltraTab23.TabPage = Me.UltraTabPageControl12
        UltraTab23.Text = "Output"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab22, UltraTab23})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(852, 379)
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(756, 409)
        '
        'frmUCInvPIDU
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Work Order CAD Output"
        Me.ClientSize = New System.Drawing.Size(856, 560)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(607, 0)
        Me.Name = "frmUCInvPIDU"
        Me.Text = "Work Order CAD Output"
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.PanelBtn, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.UltraTabControl1, 0)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_FileNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DescripWO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_OrderDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_FileNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label

#End Region
End Class

