Imports System.Xml
Imports Infragistics.Win.UltraWinTabControl
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmUC3Explorer
    Inherits frmMax


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitForm()
        'Add any initialization after the InitializeComponent() call

    End Sub

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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUC3Explorer))
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim PopupMenuTool2 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("ID_Context")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ID_Params")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ID_AddChild")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ID_GlobalParams")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ID_EditDef")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ID_Delete")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ID_EditChildRule")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ID_Params")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ID_AddChild")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ID_GlobalParams")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ID_EditDef")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ID_Delete")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ID_EditChildRule")
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.btn_Print = New Infragistics.Win.Misc.UltraButton()
        Me.btnPrepModel3D = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraListView1 = New Infragistics.Win.UltraWinListView.UltraListView()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTree1 = New Infragistics.Win.UltraWinTree.UltraTree()
        Me.imageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.UltraProgressBar1 = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel2_Fill_Panel = New Infragistics.Win.Misc.UltraPanel()
        Me.lbl_WOInfo = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me._Panel2_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._Panel2_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._Panel2_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._Panel2_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButtons.SuspendLayout()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.UltraTabSharedControlsPage1.SuspendLayout()
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel2_Fill_Panel.ClientArea.SuspendLayout()
        Me.Panel2_Fill_Panel.SuspendLayout()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl2.Controls.Add(Me.PanelButtons)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(368, 303)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(368, 262)
        Me.UltraGrid2.TabIndex = 18
        Me.UltraGrid2.Text = "Delivery Schedule"
        '
        'PanelButtons
        '
        Me.PanelButtons.Controls.Add(Me.UltraButton1)
        Me.PanelButtons.Controls.Add(Me.btn_Print)
        Me.PanelButtons.Controls.Add(Me.btnPrepModel3D)
        Me.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelButtons.Location = New System.Drawing.Point(0, 262)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(368, 41)
        Me.PanelButtons.TabIndex = 3
        '
        'UltraButton1
        '
        Me.UltraButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraButton1.Location = New System.Drawing.Point(179, 0)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(93, 41)
        Me.UltraButton1.TabIndex = 659
        Me.UltraButton1.Text = "Refresh Explorer"
        '
        'btn_Print
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.btn_Print.Appearance = Appearance1
        Me.btn_Print.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Print.Location = New System.Drawing.Point(85, 0)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(94, 41)
        Me.btn_Print.TabIndex = 655
        Me.btn_Print.Text = "Print"
        '
        'btnPrepModel3D
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnPrepModel3D.Appearance = Appearance2
        Me.btnPrepModel3D.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrepModel3D.Location = New System.Drawing.Point(0, 0)
        Me.btnPrepModel3D.Name = "btnPrepModel3D"
        Me.btnPrepModel3D.Size = New System.Drawing.Size(85, 41)
        Me.btnPrepModel3D.TabIndex = 657
        Me.btnPrepModel3D.Text = "Update Model"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(368, 303)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(368, 303)
        Me.UltraGrid1.TabIndex = 17
        Me.UltraGrid1.Text = "Delivery Schedule"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraListView1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(368, 303)
        '
        'UltraListView1
        '
        Me.UltraListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraListView1.Location = New System.Drawing.Point(0, 0)
        Me.UltraListView1.Name = "UltraListView1"
        Me.UltraListView1.Size = New System.Drawing.Size(368, 303)
        Me.UltraListView1.TabIndex = 4
        Me.UltraListView1.Text = "UltraListView1"
        Me.UltraListView1.View = Infragistics.Win.UltraWinListView.UltraListViewStyle.Tiles
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.RichTextBox1)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(368, 303)
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(368, 303)
        Me.RichTextBox1.TabIndex = 21
        Me.RichTextBox1.Text = ""
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(756, 409)
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.BackColorInternal = System.Drawing.SystemColors.Control
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance3.BorderColor = System.Drawing.Color.Transparent
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.TextTrimming = Infragistics.Win.TextTrimming.None
        Me.UltraTabControl1.SelectedTabAppearance = Appearance3
        Me.UltraTabControl1.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.PanelButtons})
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(372, 329)
        Me.UltraTabControl1.TabIndex = 0
        Me.UltraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.TopLeft
        UltraTab2.Key = "compref"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Component Builtup"
        UltraTab6.Key = "bomtank2"
        UltraTab6.TabPage = Me.UltraTabPageControl9
        UltraTab6.Text = "Bill of Material"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Components 3D"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Log"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab6, UltraTab1, UltraTab3})
        Me.UltraTabControl1.TabsPerRow = 1
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Controls.Add(Me.PanelButtons)
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(368, 303)
        '
        'UltraTree1
        '
        Me.UltraToolbarsManager1.SetContextMenuUltra(Me.UltraTree1, "ID_Context")
        Me.UltraTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTree1.ImageList = Me.imageList
        Me.UltraTree1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTree1.Name = "UltraTree1"
        Me.UltraTree1.Size = New System.Drawing.Size(372, 341)
        Me.UltraTree1.TabIndex = 1
        '
        'imageList
        '
        Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList.Images.SetKeyName(0, "")
        Me.imageList.Images.SetKeyName(1, "")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 39)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraTree1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraProgressBar1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UltraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(372, 699)
        Me.SplitContainer1.SplitterDistance = 366
        Me.SplitContainer1.TabIndex = 2
        '
        'UltraProgressBar1
        '
        Appearance6.FontData.BoldAsString = "True"
        Me.UltraProgressBar1.Appearance = Appearance6
        Me.UltraProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraProgressBar1.Location = New System.Drawing.Point(0, 341)
        Me.UltraProgressBar1.Name = "UltraProgressBar1"
        Me.UltraProgressBar1.Size = New System.Drawing.Size(372, 25)
        Me.UltraProgressBar1.TabIndex = 583
        Me.UltraProgressBar1.Text = "Analyzing Item no. 1 ( [Formatted])"
        Me.UltraProgressBar1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraProgressBar1.Value = 50
        Me.UltraProgressBar1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel2_Fill_Panel)
        Me.Panel2.Controls.Add(Me._Panel2_Toolbars_Dock_Area_Left)
        Me.Panel2.Controls.Add(Me._Panel2_Toolbars_Dock_Area_Right)
        Me.Panel2.Controls.Add(Me._Panel2_Toolbars_Dock_Area_Bottom)
        Me.Panel2.Controls.Add(Me._Panel2_Toolbars_Dock_Area_Top)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 39)
        Me.Panel2.TabIndex = 5
        '
        'Panel2_Fill_Panel
        '
        '
        'Panel2_Fill_Panel.ClientArea
        '
        Me.Panel2_Fill_Panel.ClientArea.Controls.Add(Me.lbl_WOInfo)
        Me.Panel2_Fill_Panel.ClientArea.Controls.Add(Me.UltraLabel6)
        Me.Panel2_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2_Fill_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel2_Fill_Panel.Name = "Panel2_Fill_Panel"
        Me.Panel2_Fill_Panel.Size = New System.Drawing.Size(372, 39)
        Me.Panel2_Fill_Panel.TabIndex = 0
        '
        'lbl_WOInfo
        '
        Me.lbl_WOInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.TextVAlignAsString = "Middle"
        Me.lbl_WOInfo.Appearance = Appearance4
        Me.lbl_WOInfo.Location = New System.Drawing.Point(129, 12)
        Me.lbl_WOInfo.Name = "lbl_WOInfo"
        Me.lbl_WOInfo.Size = New System.Drawing.Size(229, 16)
        Me.lbl_WOInfo.TabIndex = 15
        Me.lbl_WOInfo.Text = "WOInfo"
        '
        'UltraLabel6
        '
        Appearance5.TextHAlignAsString = "Right"
        Appearance5.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance5
        Me.UltraLabel6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(18, 12)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(105, 16)
        Me.UltraLabel6.TabIndex = 14
        Me.UltraLabel6.Text = "Work Order No."
        '
        '_Panel2_Toolbars_Dock_Area_Left
        '
        Me._Panel2_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Panel2_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._Panel2_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._Panel2_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Panel2_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 0)
        Me._Panel2_Toolbars_Dock_Area_Left.Name = "_Panel2_Toolbars_Dock_Area_Left"
        Me._Panel2_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 39)
        Me._Panel2_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 0
        Me.UltraToolbarsManager1.DockWithinContainer = Me.Panel2
        Me.UltraToolbarsManager1.ShowFullMenusDelay = 500
        PopupMenuTool2.SharedPropsInternal.Caption = "Context"
        ButtonTool3.InstanceProps.IsFirstInGroup = True
        ButtonTool4.InstanceProps.IsFirstInGroup = True
        PopupMenuTool2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2, ButtonTool3, ButtonTool4, ButtonTool5, ButtonTool6})
        ButtonTool7.SharedPropsInternal.Caption = "Parameters..."
        ButtonTool8.SharedPropsInternal.Caption = "Add Child..."
        ButtonTool9.SharedPropsInternal.Caption = "Global Parameters..."
        ButtonTool10.SharedPropsInternal.Caption = "Edit Definition"
        ButtonTool11.SharedPropsInternal.Caption = "Delete"
        ButtonTool12.SharedPropsInternal.Caption = "Edit Child Rule..."
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {PopupMenuTool2, ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool10, ButtonTool11, ButtonTool12})
        '
        '_Panel2_Toolbars_Dock_Area_Right
        '
        Me._Panel2_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Panel2_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._Panel2_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._Panel2_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Panel2_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(372, 0)
        Me._Panel2_Toolbars_Dock_Area_Right.Name = "_Panel2_Toolbars_Dock_Area_Right"
        Me._Panel2_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 39)
        Me._Panel2_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_Panel2_Toolbars_Dock_Area_Bottom
        '
        Me._Panel2_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Panel2_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._Panel2_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._Panel2_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Panel2_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 39)
        Me._Panel2_Toolbars_Dock_Area_Bottom.Name = "_Panel2_Toolbars_Dock_Area_Bottom"
        Me._Panel2_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(372, 0)
        Me._Panel2_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_Panel2_Toolbars_Dock_Area_Top
        '
        Me._Panel2_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Panel2_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._Panel2_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._Panel2_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Panel2_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._Panel2_Toolbars_Dock_Area_Top.Name = "_Panel2_Toolbars_Dock_Area_Top"
        Me._Panel2_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(372, 0)
        Me._Panel2_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'frmUC3Explorer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Model Explorer"
        Me.ClientSize = New System.Drawing.Size(372, 738)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmUC3Explorer"
        Me.ShowInTaskbar = False
        Me.Text = "Model Explorer"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButtons.ResumeLayout(False)
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.UltraTabSharedControlsPage1.ResumeLayout(False)
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2_Fill_Panel.ClientArea.ResumeLayout(False)
        Me.Panel2_Fill_Panel.ResumeLayout(False)
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelButtons As System.Windows.Forms.Panel
    Friend WithEvents btn_Print As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnPrepModel3D As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraListView1 As Infragistics.Win.UltraWinListView.UltraListView
    Friend WithEvents UltraTabPageControl3 As UltraTabPageControl
    Friend WithEvents RichTextBox1 As Windows.Forms.RichTextBox
    Friend WithEvents UltraTree1 As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_WOInfo As Infragistics.Win.Misc.UltraLabel
    Public WithEvents UltraProgressBar1 As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents imageList As Windows.Forms.ImageList
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents Panel2_Fill_Panel As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents _Panel2_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Panel2_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Panel2_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Panel2_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea

#End Region
End Class

