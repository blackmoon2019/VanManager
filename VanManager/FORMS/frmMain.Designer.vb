<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim BBMain_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim BBMain_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_0_4 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_0_5 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_0_6 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_0_7 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_0_8 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Group_1 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim BBMain_Item_1_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_1_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_1_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Group_2 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim BBMain_Item_2_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_4 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_5 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_6 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_7 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_8 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_9 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_10 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_11 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_12 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_13 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BBMain_Item_2_14 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim GridMain_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboYears_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboMONTHS_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.comManager = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.cmdFieldChooser = New Janus.Windows.UI.CommandBars.UICommand("cmdFieldChooser")
        Me.cmdRemoveThisColumn = New Janus.Windows.UI.CommandBars.UICommand("cmdRemoveThisColumn")
        Me.cmdRenameThisColumn = New Janus.Windows.UI.CommandBars.UICommand("cmdRenameThisColumn")
        Me.cmHeader = New Janus.Windows.UI.CommandBars.UIContextMenu()
        Me.cmdFieldChooser1 = New Janus.Windows.UI.CommandBars.UICommand("cmdFieldChooser")
        Me.cmdRemoveThisColumn1 = New Janus.Windows.UI.CommandBars.UICommand("cmdRemoveThisColumn")
        Me.cmdRenameThisColumn1 = New Janus.Windows.UI.CommandBars.UICommand("cmdRenameThisColumn")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.RBMain = New Janus.Windows.Ribbon.Ribbon()
        Me.RBExit = New Janus.Windows.Ribbon.ButtonCommand()
        Me.DropDownCommand1 = New Janus.Windows.Ribbon.DropDownCommand()
        Me.TBMain = New Janus.Windows.Ribbon.RibbonTab()
        Me.RibbonGroup1 = New Janus.Windows.Ribbon.RibbonGroup()
        Me.ButtonCommand1 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.ButtonCommand2 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.ButtonCommand3 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.ButtonCommand4 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.ButtonCommand5 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.RibbonGroup3 = New Janus.Windows.Ribbon.RibbonGroup()
        Me.ButtonCommand6 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.ButtonCommand7 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.RibbonGroup2 = New Janus.Windows.Ribbon.RibbonGroup()
        Me.ButtonCommand8 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.ButtonCommand9 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.RibbonGroup4 = New Janus.Windows.Ribbon.RibbonGroup()
        Me.ButtonCommand10 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.BBMain = New Janus.Windows.ButtonBar.ButtonBar()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtFilter = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.GridEXExporter1 = New Janus.Windows.GridEX.Export.GridEXExporter(Me.components)
        Me.GridMain = New Janus.Windows.GridEX.GridEX()
        Me.grpSearch = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboYears = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboMONTHS = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSearch = New Janus.Windows.EditControls.UIButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtToDate = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtFromDate = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.comManager2 = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.UiRebar2 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.cmdAkirotiko = New Janus.Windows.UI.CommandBars.UICommand("cmdAkirotiko")
        Me.FChoice = New Janus.Windows.UI.CommandBars.UICommand("FChoice")
        Me.FWChoice = New Janus.Windows.UI.CommandBars.UICommand("FWChoice")
        Me.FDefault = New Janus.Windows.UI.CommandBars.UICommand("FDefault")
        Me.cmdInv = New Janus.Windows.UI.CommandBars.UIContextMenu()
        Me.cmdAkirotiko1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAkirotiko")
        Me.cmdFilters = New Janus.Windows.UI.CommandBars.UIContextMenu()
        Me.FChoice1 = New Janus.Windows.UI.CommandBars.UICommand("FChoice")
        Me.FWChoice1 = New Janus.Windows.UI.CommandBars.UICommand("FWChoice")
        Me.FDefault1 = New Janus.Windows.UI.CommandBars.UICommand("FDefault")
        Me.cmdCellChoices = New Janus.Windows.UI.CommandBars.UIContextMenu()
        Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdAkirotiko2 = New Janus.Windows.UI.CommandBars.UICommand("cmdAkirotiko")
        Me.UiRebar3 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.UiRebar4 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.UiRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.UiPanelManager1 = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.cmdRoutes = New Janus.Windows.UI.CommandBars.UICommand("cmdRoutes")
        Me.cmdRoutes1 = New Janus.Windows.UI.CommandBars.UICommand("cmdRoutes")
        CType(Me.comManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RBMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BBMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        CType(Me.cboYears, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMONTHS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiRebar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCellChoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiRebar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiRebar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comManager
        '
        Me.comManager.BottomRebar = Me.BottomRebar1
        Me.comManager.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdFieldChooser, Me.cmdRemoveThisColumn, Me.cmdRenameThisColumn})
        Me.comManager.ContainerControl = Me
        Me.comManager.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.cmHeader})
        '
        '
        '
        Me.comManager.EditContextMenu.Key = ""
        Me.comManager.Id = New System.Guid("deb99014-92e4-4dbc-b2ca-598d67fccefe")
        Me.comManager.LeftRebar = Me.LeftRebar1
        Me.comManager.RightRebar = Me.RightRebar1
        Me.comManager.TopRebar = Me.TopRebar1
        Me.comManager.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.comManager
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 0)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'cmdFieldChooser
        '
        Me.cmdFieldChooser.CommandType = Janus.Windows.UI.CommandBars.CommandType.ToggleButton
        Me.cmdFieldChooser.Key = "cmdFieldChooser"
        Me.cmdFieldChooser.Name = "cmdFieldChooser"
        Me.cmdFieldChooser.Text = "Στήλες"
        '
        'cmdRemoveThisColumn
        '
        Me.cmdRemoveThisColumn.Key = "cmdRemoveThisColumn"
        Me.cmdRemoveThisColumn.Name = "cmdRemoveThisColumn"
        Me.cmdRemoveThisColumn.Text = "Απόκρυψη"
        '
        'cmdRenameThisColumn
        '
        Me.cmdRenameThisColumn.CommandType = Janus.Windows.UI.CommandBars.CommandType.TextBoxCommand
        Me.cmdRenameThisColumn.ControlValue = ""
        Me.cmdRenameThisColumn.IsEditableControl = Janus.Windows.UI.InheritableBoolean.[True]
        Me.cmdRenameThisColumn.Key = "cmdRenameThisColumn"
        Me.cmdRenameThisColumn.Name = "cmdRenameThisColumn"
        Me.cmdRenameThisColumn.Text = "Μετονομασία"
        '
        'cmHeader
        '
        Me.cmHeader.CommandManager = Me.comManager
        Me.cmHeader.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdFieldChooser1, Me.cmdRemoveThisColumn1, Me.cmdRenameThisColumn1})
        Me.cmHeader.Key = "HeaderMenu"
        '
        'cmdFieldChooser1
        '
        Me.cmdFieldChooser1.Key = "cmdFieldChooser"
        Me.cmdFieldChooser1.Name = "cmdFieldChooser1"
        '
        'cmdRemoveThisColumn1
        '
        Me.cmdRemoveThisColumn1.Key = "cmdRemoveThisColumn"
        Me.cmdRemoveThisColumn1.Name = "cmdRemoveThisColumn1"
        '
        'cmdRenameThisColumn1
        '
        Me.cmdRenameThisColumn1.AccessibleDescription = ""
        Me.cmdRenameThisColumn1.AccessibleName = ""
        Me.cmdRenameThisColumn1.ControlValue = ""
        Me.cmdRenameThisColumn1.Key = "cmdRenameThisColumn"
        Me.cmdRenameThisColumn1.Name = "cmdRenameThisColumn1"
        Me.cmdRenameThisColumn1.ShowTextInContainers = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.comManager
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.comManager
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(0, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.comManager
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(1276, 0)
        '
        'RBMain
        '
        Me.RBMain.BackstageCommands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.RBExit})
        Me.RBMain.BackstageMenuData = resources.GetString("RBMain.BackstageMenuData")
        Me.RBMain.ControlBoxMenu.LeftCommands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.DropDownCommand1})
        '
        '
        '
        Me.RBMain.HelpButton.Image = CType(resources.GetObject("RBMain.HelpButton.Image"), System.Drawing.Image)
        Me.RBMain.HelpButton.Key = "HelpButton"
        Me.RBMain.Location = New System.Drawing.Point(0, 0)
        Me.RBMain.Name = "RBMain"
        Me.RBMain.Size = New System.Drawing.Size(1276, 144)
        '
        '
        '
        Me.RBMain.SuperTipComponent.AutoPopDelay = 2000
        Me.RBMain.SuperTipComponent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.RBMain.SuperTipComponent.ImageList = Nothing
        Me.RBMain.TabIndex = 7
        Me.RBMain.Tabs.AddRange(New Janus.Windows.Ribbon.RibbonTab() {Me.TBMain})
        Me.RBMain.Text = ""
        Me.RBMain.VisualStyle = Janus.Windows.Ribbon.VisualStyle.Office2010
        '
        'RBExit
        '
        Me.RBExit.Image = CType(resources.GetObject("RBExit.Image"), System.Drawing.Image)
        Me.RBExit.Key = "ExitS"
        Me.RBExit.Name = "RBExit"
        Me.RBExit.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.RBExit.Text = "Έξοδος"
        '
        'DropDownCommand1
        '
        Me.DropDownCommand1.Key = "DropDownCommand1"
        Me.DropDownCommand1.Name = "DropDownCommand1"
        Me.DropDownCommand1.Text = "Έξοδος"
        '
        'TBMain
        '
        Me.TBMain.Groups.AddRange(New Janus.Windows.Ribbon.RibbonGroup() {Me.RibbonGroup1, Me.RibbonGroup3, Me.RibbonGroup2, Me.RibbonGroup4})
        Me.TBMain.Key = "RibbonTab1"
        Me.TBMain.Name = "TBMain"
        Me.TBMain.Text = "Διαχείριση"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.ButtonCommand1, Me.ButtonCommand2, Me.ButtonCommand3, Me.ButtonCommand4, Me.ButtonCommand5})
        Me.RibbonGroup1.DialogButtonSuperTipSettings.ImageListProvider = Me.RibbonGroup1
        Me.RibbonGroup1.Key = "RibbonGroup1"
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Text = "Διαχείριση"
        '
        'ButtonCommand1
        '
        Me.ButtonCommand1.Image = CType(resources.GetObject("ButtonCommand1.Image"), System.Drawing.Image)
        Me.ButtonCommand1.Key = "New"
        Me.ButtonCommand1.Name = "ButtonCommand1"
        Me.ButtonCommand1.Text = "Νέα Εγγραφή"
        '
        'ButtonCommand2
        '
        Me.ButtonCommand2.Image = CType(resources.GetObject("ButtonCommand2.Image"), System.Drawing.Image)
        Me.ButtonCommand2.Key = "Edit"
        Me.ButtonCommand2.Name = "ButtonCommand2"
        Me.ButtonCommand2.Text = "Επεξεργασία"
        '
        'ButtonCommand3
        '
        Me.ButtonCommand3.Image = CType(resources.GetObject("ButtonCommand3.Image"), System.Drawing.Image)
        Me.ButtonCommand3.Key = "Delete"
        Me.ButtonCommand3.Name = "ButtonCommand3"
        Me.ButtonCommand3.Text = "Διαγραφή"
        '
        'ButtonCommand4
        '
        Me.ButtonCommand4.Image = CType(resources.GetObject("ButtonCommand4.Image"), System.Drawing.Image)
        Me.ButtonCommand4.Key = "View"
        Me.ButtonCommand4.Name = "ButtonCommand4"
        Me.ButtonCommand4.Text = "Προβολή"
        '
        'ButtonCommand5
        '
        Me.ButtonCommand5.Image = CType(resources.GetObject("ButtonCommand5.Image"), System.Drawing.Image)
        Me.ButtonCommand5.Key = "Refresh"
        Me.ButtonCommand5.Name = "ButtonCommand5"
        Me.ButtonCommand5.Text = "Ανανέωση"
        '
        'RibbonGroup3
        '
        Me.RibbonGroup3.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.ButtonCommand6, Me.ButtonCommand7})
        Me.RibbonGroup3.DialogButtonSuperTipSettings.ImageListProvider = Me.RibbonGroup3
        Me.RibbonGroup3.Key = "RibbonGroup3"
        Me.RibbonGroup3.Name = "RibbonGroup3"
        Me.RibbonGroup3.Text = "Όψεις"
        '
        'ButtonCommand6
        '
        Me.ButtonCommand6.Image = CType(resources.GetObject("ButtonCommand6.Image"), System.Drawing.Image)
        Me.ButtonCommand6.Key = "SaveL"
        Me.ButtonCommand6.Name = "ButtonCommand6"
        Me.ButtonCommand6.Text = "Αποθήκευση"
        '
        'ButtonCommand7
        '
        Me.ButtonCommand7.Image = CType(resources.GetObject("ButtonCommand7.Image"), System.Drawing.Image)
        Me.ButtonCommand7.Key = "DeleteL"
        Me.ButtonCommand7.Name = "ButtonCommand7"
        Me.ButtonCommand7.Text = "Διαγραφή"
        '
        'RibbonGroup2
        '
        Me.RibbonGroup2.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.ButtonCommand8, Me.ButtonCommand9})
        Me.RibbonGroup2.DialogButtonSuperTipSettings.ImageListProvider = Me.RibbonGroup2
        Me.RibbonGroup2.Key = "RibbonGroup2"
        Me.RibbonGroup2.Name = "RibbonGroup2"
        Me.RibbonGroup2.Text = "Εξαγωγή"
        '
        'ButtonCommand8
        '
        Me.ButtonCommand8.Key = "PrintL"
        Me.ButtonCommand8.LargeImage = CType(resources.GetObject("ButtonCommand8.LargeImage"), System.Drawing.Image)
        Me.ButtonCommand8.Name = "ButtonCommand8"
        Me.ButtonCommand8.Text = "Εκτύπωση"
        '
        'ButtonCommand9
        '
        Me.ButtonCommand9.Image = CType(resources.GetObject("ButtonCommand9.Image"), System.Drawing.Image)
        Me.ButtonCommand9.Key = "ExcelL"
        Me.ButtonCommand9.Name = "ButtonCommand9"
        Me.ButtonCommand9.Text = "Excel"
        '
        'RibbonGroup4
        '
        Me.RibbonGroup4.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.ButtonCommand10})
        Me.RibbonGroup4.DialogButtonSuperTipSettings.ImageListProvider = Me.RibbonGroup4
        Me.RibbonGroup4.Key = "RibbonGroup4"
        Me.RibbonGroup4.Name = "RibbonGroup4"
        '
        'ButtonCommand10
        '
        Me.ButtonCommand10.Image = CType(resources.GetObject("ButtonCommand10.Image"), System.Drawing.Image)
        Me.ButtonCommand10.Key = "ExitL"
        Me.ButtonCommand10.Name = "ButtonCommand10"
        Me.ButtonCommand10.Text = "Έξοδος"
        '
        'BBMain
        '
        Me.BBMain.Dock = System.Windows.Forms.DockStyle.Left
        BBMain_Item_0_0.Image = CType(resources.GetObject("BBMain_Item_0_0.Image"), System.Drawing.Image)
        BBMain_Item_0_0.Key = "CUS"
        BBMain_Item_0_0.Text = "Πελάτες"
        BBMain_Item_0_1.Image = CType(resources.GetObject("BBMain_Item_0_1.Image"), System.Drawing.Image)
        BBMain_Item_0_1.Key = "DRV"
        BBMain_Item_0_1.Text = "Οδηγοί"
        BBMain_Item_0_2.Image = CType(resources.GetObject("BBMain_Item_0_2.Image"), System.Drawing.Image)
        BBMain_Item_0_2.Key = "HLP"
        BBMain_Item_0_2.Text = "Βοηθοί"
        BBMain_Item_0_3.Image = CType(resources.GetObject("BBMain_Item_0_3.Image"), System.Drawing.Image)
        BBMain_Item_0_3.Key = "PAR"
        BBMain_Item_0_3.Text = "Παρκινγκ"
        BBMain_Item_0_4.Image = CType(resources.GetObject("BBMain_Item_0_4.Image"), System.Drawing.Image)
        BBMain_Item_0_4.Key = "PARD"
        BBMain_Item_0_4.Text = "Κινήσεις Πάρκινγκ"
        BBMain_Item_0_5.Image = CType(resources.GetObject("BBMain_Item_0_5.Image"), System.Drawing.Image)
        BBMain_Item_0_5.Key = "ROUTES"
        BBMain_Item_0_5.Text = "Δρομολόγια"
        BBMain_Item_0_6.Image = CType(resources.GetObject("BBMain_Item_0_6.Image"), System.Drawing.Image)
        BBMain_Item_0_6.Key = "ES"
        BBMain_Item_0_6.Text = "Έσοδα"
        BBMain_Item_0_7.Image = CType(resources.GetObject("BBMain_Item_0_7.Image"), System.Drawing.Image)
        BBMain_Item_0_7.Key = "EX"
        BBMain_Item_0_7.Text = "Έξοδα"
        BBMain_Item_0_8.Image = CType(resources.GetObject("BBMain_Item_0_8.Image"), System.Drawing.Image)
        BBMain_Item_0_8.Key = "HLP_ROUTES"
        BBMain_Item_0_8.Text = "Κινήσεις Βοηθών"
        BBMain_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BBMain_Item_0_0, BBMain_Item_0_1, BBMain_Item_0_2, BBMain_Item_0_3, BBMain_Item_0_4, BBMain_Item_0_5, BBMain_Item_0_6, BBMain_Item_0_7, BBMain_Item_0_8})
        BBMain_Group_0.Key = "grpMan"
        BBMain_Group_0.Text = "Διαχείριση"
        BBMain_Item_1_0.Image = CType(resources.GetObject("BBMain_Item_1_0.Image"), System.Drawing.Image)
        BBMain_Item_1_0.Key = "INV"
        BBMain_Item_1_0.Text = "Τιμολόγια"
        BBMain_Item_1_1.Image = CType(resources.GetObject("BBMain_Item_1_1.Image"), System.Drawing.Image)
        BBMain_Item_1_1.Key = "SYG_INV"
        BBMain_Item_1_1.Text = "Συγκεντρωτικά Τιμολόγια"
        BBMain_Item_1_2.Image = CType(resources.GetObject("BBMain_Item_1_2.Image"), System.Drawing.Image)
        BBMain_Item_1_2.Key = "COL"
        BBMain_Item_1_2.Text = "Εισπράξεις"
        BBMain_Group_1.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BBMain_Item_1_0, BBMain_Item_1_1, BBMain_Item_1_2})
        BBMain_Group_1.Key = "grdInvoices"
        BBMain_Group_1.Text = "Τιμολόγηση"
        BBMain_Item_2_0.Image = CType(resources.GetObject("BBMain_Item_2_0.Image"), System.Drawing.Image)
        BBMain_Item_2_0.Key = "VEH"
        BBMain_Item_2_0.Text = "Οχήματα"
        BBMain_Item_2_1.Image = CType(resources.GetObject("BBMain_Item_2_1.Image"), System.Drawing.Image)
        BBMain_Item_2_1.Key = "DOY"
        BBMain_Item_2_1.Text = "ΔΟΥ"
        BBMain_Item_2_2.Image = CType(resources.GetObject("BBMain_Item_2_2.Image"), System.Drawing.Image)
        BBMain_Item_2_2.Key = "PRF"
        BBMain_Item_2_2.Text = "Επαγγέλματα"
        BBMain_Item_2_3.Image = CType(resources.GetObject("BBMain_Item_2_3.Image"), System.Drawing.Image)
        BBMain_Item_2_3.Key = "COU"
        BBMain_Item_2_3.Text = "Νομοί"
        BBMain_Item_2_4.Image = CType(resources.GetObject("BBMain_Item_2_4.Image"), System.Drawing.Image)
        BBMain_Item_2_4.Key = "AREA"
        BBMain_Item_2_4.Text = "Περιοχές"
        BBMain_Item_2_5.Image = CType(resources.GetObject("BBMain_Item_2_5.Image"), System.Drawing.Image)
        BBMain_Item_2_5.Key = "VEHT"
        BBMain_Item_2_5.Text = "Τύποι Οχημάτων"
        BBMain_Item_2_6.Image = CType(resources.GetObject("BBMain_Item_2_6.Image"), System.Drawing.Image)
        BBMain_Item_2_6.Key = "STI"
        BBMain_Item_2_6.Text = "Είδη Μεταφοράς"
        BBMain_Item_2_7.Image = CType(resources.GetObject("BBMain_Item_2_7.Image"), System.Drawing.Image)
        BBMain_Item_2_7.Key = "EXCAT"
        BBMain_Item_2_7.Text = "Κατ. Εξόδων"
        BBMain_Item_2_8.Image = CType(resources.GetObject("BBMain_Item_2_8.Image"), System.Drawing.Image)
        BBMain_Item_2_8.Key = "CUSTYPE"
        BBMain_Item_2_8.Text = "Τύπος Πελάτη"
        BBMain_Item_2_9.Image = CType(resources.GetObject("BBMain_Item_2_9.Image"), System.Drawing.Image)
        BBMain_Item_2_9.Key = "PAY"
        BBMain_Item_2_9.Text = "Τρόποι Πληρωμής"
        BBMain_Item_2_10.Image = CType(resources.GetObject("BBMain_Item_2_10.Image"), System.Drawing.Image)
        BBMain_Item_2_10.Key = "DOS"
        BBMain_Item_2_10.Text = "Σειρές"
        BBMain_Item_2_11.Image = CType(resources.GetObject("BBMain_Item_2_11.Image"), System.Drawing.Image)
        BBMain_Item_2_11.Key = "SDT"
        BBMain_Item_2_11.Text = "Τύποι Παραστατικών"
        BBMain_Item_2_12.Image = CType(resources.GetObject("BBMain_Item_2_12.Image"), System.Drawing.Image)
        BBMain_Item_2_12.Key = "USERS"
        BBMain_Item_2_12.Text = "Χρήστες"
        BBMain_Item_2_13.Image = CType(resources.GetObject("BBMain_Item_2_13.Image"), System.Drawing.Image)
        BBMain_Item_2_13.Key = "STS"
        BBMain_Item_2_13.Text = "Δεσίματα"
        BBMain_Item_2_14.Image = CType(resources.GetObject("BBMain_Item_2_14.Image"), System.Drawing.Image)
        BBMain_Item_2_14.Key = "FPA"
        BBMain_Item_2_14.Text = "Φ.Π.Α"
        BBMain_Group_2.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BBMain_Item_2_0, BBMain_Item_2_1, BBMain_Item_2_2, BBMain_Item_2_3, BBMain_Item_2_4, BBMain_Item_2_5, BBMain_Item_2_6, BBMain_Item_2_7, BBMain_Item_2_8, BBMain_Item_2_9, BBMain_Item_2_10, BBMain_Item_2_11, BBMain_Item_2_12, BBMain_Item_2_13, BBMain_Item_2_14})
        BBMain_Group_2.Key = "grpHlp"
        BBMain_Group_2.Text = "Βοηθητικοί Πίνακες"
        Me.BBMain.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {BBMain_Group_0, BBMain_Group_1, BBMain_Group_2})
        Me.BBMain.Location = New System.Drawing.Point(0, 144)
        Me.BBMain.Name = "BBMain"
        Me.BBMain.ShadowOnHover = True
        Me.BBMain.Size = New System.Drawing.Size(131, 368)
        Me.BBMain.TabIndex = 9
        Me.BBMain.Text = "ButtonBar1"
        Me.BBMain.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.TabPage
        Me.UiGroupBox1.Controls.Add(Me.txtFilter)
        Me.UiGroupBox1.Image = CType(resources.GetObject("UiGroupBox1.Image"), System.Drawing.Image)
        Me.UiGroupBox1.Location = New System.Drawing.Point(629, 72)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(238, 51)
        Me.UiGroupBox1.TabIndex = 13
        Me.UiGroupBox1.Text = "Αναζήτηση"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(6, 21)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(227, 20)
        Me.txtFilter.TabIndex = 13
        Me.txtFilter.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'GridEXExporter1
        '
        Me.GridEXExporter1.GridEX = Me.GridMain
        '
        'GridMain
        '
        Me.GridMain.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridMain.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMain.AlternatingColors = True
        Me.GridMain.BuiltInTextsData = resources.GetString("GridMain.BuiltInTextsData")
        GridMain_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
        Me.GridMain.DesignTimeLayout = GridMain_DesignTimeLayout
        Me.GridMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMain.DynamicFiltering = True
        Me.GridMain.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridMain.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridMain.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridMain.Location = New System.Drawing.Point(134, 147)
        Me.GridMain.Name = "GridMain"
        Me.GridMain.RecordNavigator = True
        Me.GridMain.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridMain.Size = New System.Drawing.Size(1139, 362)
        Me.GridMain.TabIndex = 15
        Me.GridMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'grpSearch
        '
        Me.grpSearch.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.TabPage
        Me.grpSearch.Controls.Add(Me.cboYears)
        Me.grpSearch.Controls.Add(Me.Label4)
        Me.grpSearch.Controls.Add(Me.cboMONTHS)
        Me.grpSearch.Controls.Add(Me.Label3)
        Me.grpSearch.Controls.Add(Me.cmdSearch)
        Me.grpSearch.Controls.Add(Me.Label2)
        Me.grpSearch.Controls.Add(Me.Label1)
        Me.grpSearch.Controls.Add(Me.dtToDate)
        Me.grpSearch.Controls.Add(Me.dtFromDate)
        Me.grpSearch.Image = CType(resources.GetObject("grpSearch.Image"), System.Drawing.Image)
        Me.grpSearch.Location = New System.Drawing.Point(899, 63)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(360, 75)
        Me.grpSearch.TabIndex = 14
        Me.grpSearch.Text = "Διάστημα Από/Έως"
        Me.grpSearch.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'cboYears
        '
        Me.cboYears.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cboYears.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.cboYears.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cboYears_DesignTimeLayout.LayoutString = resources.GetString("cboYears_DesignTimeLayout.LayoutString")
        Me.cboYears.DesignTimeLayout = cboYears_DesignTimeLayout
        Me.cboYears.DisplayMember = "Name"
        Me.cboYears.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboYears.Location = New System.Drawing.Point(52, 21)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboYears.SelectedIndex = -1
        Me.cboYears.SelectedItem = Nothing
        Me.cboYears.SettingsKey = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(120, 20)
        Me.cboYears.TabIndex = 218
        Me.cboYears.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboYears.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 217
        Me.Label4.Text = "Έτος"
        '
        'cboMONTHS
        '
        Me.cboMONTHS.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cboMONTHS.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.cboMONTHS.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cboMONTHS_DesignTimeLayout.LayoutString = resources.GetString("cboMONTHS_DesignTimeLayout.LayoutString")
        Me.cboMONTHS.DesignTimeLayout = cboMONTHS_DesignTimeLayout
        Me.cboMONTHS.DisplayMember = "Name"
        Me.cboMONTHS.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboMONTHS.Location = New System.Drawing.Point(52, 50)
        Me.cboMONTHS.Name = "cboMONTHS"
        Me.cboMONTHS.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboMONTHS.SelectedIndex = -1
        Me.cboMONTHS.SelectedItem = Nothing
        Me.cboMONTHS.SettingsKey = "cboMainCus"
        Me.cboMONTHS.Size = New System.Drawing.Size(120, 20)
        Me.cboMONTHS.TabIndex = 216
        Me.cboMONTHS.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboMONTHS.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 215
        Me.Label3.Text = "Μήνας"
        '
        'cmdSearch
        '
        Me.cmdSearch.Appearance = Janus.Windows.UI.Appearance.Normal
        Me.cmdSearch.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.Location = New System.Drawing.Point(330, 34)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(27, 23)
        Me.cmdSearch.TabIndex = 209
        Me.cmdSearch.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Έως"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Από"
        '
        'dtToDate
        '
        '
        '
        '
        Me.dtToDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtToDate.HoverMode = Janus.Windows.CalendarCombo.HoverMode.Highlight
        Me.dtToDate.Location = New System.Drawing.Point(221, 47)
        Me.dtToDate.Name = "dtToDate"
        Me.dtToDate.Size = New System.Drawing.Size(103, 20)
        Me.dtToDate.TabIndex = 159
        Me.dtToDate.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtToDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'dtFromDate
        '
        '
        '
        '
        Me.dtFromDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtFromDate.HoverMode = Janus.Windows.CalendarCombo.HoverMode.Highlight
        Me.dtFromDate.Location = New System.Drawing.Point(221, 21)
        Me.dtFromDate.Name = "dtFromDate"
        Me.dtFromDate.Size = New System.Drawing.Size(103, 20)
        Me.dtFromDate.TabIndex = 158
        Me.dtFromDate.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtFromDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'comManager2
        '
        Me.comManager2.BottomRebar = Me.UiRebar2
        Me.comManager2.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdAkirotiko, Me.FChoice, Me.FWChoice, Me.FDefault, Me.cmdRoutes})
        Me.comManager2.ContainerControl = Me
        Me.comManager2.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.cmdInv, Me.cmdFilters, Me.cmdCellChoices})
        '
        '
        '
        Me.comManager2.EditContextMenu.Key = ""
        Me.comManager2.Id = New System.Guid("c9d49d23-0add-4b8f-a155-4df3ea54ff10")
        Me.comManager2.LeftRebar = Me.UiRebar3
        Me.comManager2.RightRebar = Me.UiRebar4
        Me.comManager2.TopRebar = Me.UiRebar1
        '
        'UiRebar2
        '
        Me.UiRebar2.CommandManager = Me.comManager2
        Me.UiRebar2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UiRebar2.Location = New System.Drawing.Point(0, 0)
        Me.UiRebar2.Name = "UiRebar2"
        Me.UiRebar2.Size = New System.Drawing.Size(0, 0)
        '
        'cmdAkirotiko
        '
        Me.cmdAkirotiko.Key = "cmdAkirotiko"
        Me.cmdAkirotiko.Name = "cmdAkirotiko"
        Me.cmdAkirotiko.Text = "Έκδοση Ακυρωτικού"
        '
        'FChoice
        '
        Me.FChoice.Key = "FChoice"
        Me.FChoice.Name = "FChoice"
        Me.FChoice.Text = "Φίλτρο με επιλογή"
        '
        'FWChoice
        '
        Me.FWChoice.Key = "FWChoice"
        Me.FWChoice.Name = "FWChoice"
        Me.FWChoice.Text = "Φίλτρο με εξαίρεση"
        '
        'FDefault
        '
        Me.FDefault.Key = "FDefault"
        Me.FDefault.Name = "FDefault"
        Me.FDefault.Text = "Αφαίρεση φίλτρων"
        '
        'cmdInv
        '
        Me.cmdInv.CommandManager = Me.comManager2
        Me.cmdInv.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdAkirotiko1})
        Me.cmdInv.Key = "cmdInv"
        '
        'cmdAkirotiko1
        '
        Me.cmdAkirotiko1.Key = "cmdAkirotiko"
        Me.cmdAkirotiko1.Name = "cmdAkirotiko1"
        '
        'cmdFilters
        '
        Me.cmdFilters.CommandManager = Me.comManager2
        Me.cmdFilters.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.FChoice1, Me.FWChoice1, Me.FDefault1})
        Me.cmdFilters.Key = "cmdFilters"
        '
        'FChoice1
        '
        Me.FChoice1.Key = "FChoice"
        Me.FChoice1.Name = "FChoice1"
        '
        'FWChoice1
        '
        Me.FWChoice1.Key = "FWChoice"
        Me.FWChoice1.Name = "FWChoice1"
        '
        'FDefault1
        '
        Me.FDefault1.Key = "FDefault"
        Me.FDefault1.Name = "FDefault1"
        '
        'cmdCellChoices
        '
        Me.cmdCellChoices.CommandManager = Me.comManager2
        Me.cmdCellChoices.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.FChoice1, Me.FWChoice1, Me.FDefault1, Me.Separator1, Me.cmdAkirotiko2, Me.cmdRoutes1})
        Me.cmdCellChoices.Key = "cmdCellChoices"
        '
        'Separator1
        '
        Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator1.Key = "Separator"
        Me.Separator1.Name = "Separator1"
        '
        'cmdAkirotiko2
        '
        Me.cmdAkirotiko2.Key = "cmdAkirotiko"
        Me.cmdAkirotiko2.Name = "cmdAkirotiko2"
        '
        'UiRebar3
        '
        Me.UiRebar3.CommandManager = Me.comManager2
        Me.UiRebar3.Dock = System.Windows.Forms.DockStyle.Left
        Me.UiRebar3.Location = New System.Drawing.Point(0, 0)
        Me.UiRebar3.Name = "UiRebar3"
        Me.UiRebar3.Size = New System.Drawing.Size(0, 0)
        '
        'UiRebar4
        '
        Me.UiRebar4.CommandManager = Me.comManager2
        Me.UiRebar4.Dock = System.Windows.Forms.DockStyle.Right
        Me.UiRebar4.Location = New System.Drawing.Point(0, 0)
        Me.UiRebar4.Name = "UiRebar4"
        Me.UiRebar4.Size = New System.Drawing.Size(0, 0)
        '
        'UiRebar1
        '
        Me.UiRebar1.CommandManager = Me.comManager2
        Me.UiRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UiRebar1.Location = New System.Drawing.Point(131, 144)
        Me.UiRebar1.Name = "UiRebar1"
        Me.UiRebar1.Size = New System.Drawing.Size(1145, 0)
        '
        'UiPanelManager1
        '
        Me.UiPanelManager1.ContainerControl = Me
        '
        'cmdRoutes
        '
        Me.cmdRoutes.Key = "cmdRoutes"
        Me.cmdRoutes.Name = "cmdRoutes"
        Me.cmdRoutes.Text = "Εμφάνιση Δρομολογίων"
        '
        'cmdRoutes1
        '
        Me.cmdRoutes1.Key = "cmdRoutes"
        Me.cmdRoutes1.Name = "cmdRoutes1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 512)
        Me.Controls.Add(Me.GridMain)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Controls.Add(Me.UiRebar1)
        Me.Controls.Add(Me.BBMain)
        Me.Controls.Add(Me.RBMain)
        Me.Controls.Add(Me.TopRebar1)
        Me.Name = "frmMain"
        Me.Text = "Κεντρικό Μενού"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.comManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RBMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BBMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.cboYears, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMONTHS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiRebar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCellChoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiRebar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiRebar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents comManager As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Protected WithEvents cmHeader As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents cmdFieldChooser As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRemoveThisColumn As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdFieldChooser1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRemoveThisColumn1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRenameThisColumn As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRenameThisColumn1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents RBMain As Janus.Windows.Ribbon.Ribbon
    Friend WithEvents TBMain As Janus.Windows.Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As Janus.Windows.Ribbon.RibbonGroup
    Friend WithEvents ButtonCommand1 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents ButtonCommand2 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents ButtonCommand3 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents ButtonCommand4 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents ButtonCommand5 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents RibbonGroup3 As Janus.Windows.Ribbon.RibbonGroup
    Friend WithEvents ButtonCommand6 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents ButtonCommand7 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents BBMain As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents DropDownCommand1 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtFilter As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents RibbonGroup2 As Janus.Windows.Ribbon.RibbonGroup
    Friend WithEvents ButtonCommand8 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents ButtonCommand9 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents GridEXExporter1 As Janus.Windows.GridEX.Export.GridEXExporter
    Friend WithEvents RBExit As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents RibbonGroup4 As Janus.Windows.Ribbon.RibbonGroup
    Friend WithEvents ButtonCommand10 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents grpSearch As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtToDate As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtFromDate As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdSearch As Janus.Windows.EditControls.UIButton
    Friend WithEvents comManager2 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents cmdInv As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents cmdAkirotiko As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents FChoice As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents FWChoice As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAkirotiko1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdFilters As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents FChoice1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents FWChoice1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents FDefault As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents FDefault1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents UiRebar2 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents UiRebar3 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents UiRebar4 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents UiRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents cboYears As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Label4 As Label
    Friend WithEvents cboMONTHS As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Label3 As Label
    Friend WithEvents UiPanelManager1 As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents GridMain As Janus.Windows.GridEX.GridEX
    Friend WithEvents cmdCellChoices As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAkirotiko2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRoutes As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRoutes1 As Janus.Windows.UI.CommandBars.UICommand
End Class
