<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmES
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
        Dim cboGrids_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmES))
        Me.commandManager = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdExcel = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        Me.cmdPrint = New Janus.Windows.EditControls.UIButton()
        Me.FilterEditor1 = New Janus.Windows.FilterEditor.FilterEditor()
        Me.dbView = New Janus.Windows.GridEX.GridEX()
        Me.cboGrids = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cmdSaveView = New Janus.Windows.EditControls.UIButton()
        Me.cmdDelteView = New Janus.Windows.EditControls.UIButton()
        Me.cmdSaveAsDef = New Janus.Windows.EditControls.UIButton()
        Me.GridEXExporter1 = New Janus.Windows.GridEX.Export.GridEXExporter(Me.components)
        CType(Me.commandManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dbView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrids, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'commandManager
        '
        Me.commandManager.BottomRebar = Me.BottomRebar1
        Me.commandManager.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdFieldChooser, Me.cmdRemoveThisColumn, Me.cmdRenameThisColumn})
        Me.commandManager.ContainerControl = Me
        Me.commandManager.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.cmHeader})
        '
        '
        '
        Me.commandManager.EditContextMenu.Key = ""
        Me.commandManager.Id = New System.Guid("deb99014-92e4-4dbc-b2ca-598d67fccefe")
        Me.commandManager.LeftRebar = Me.LeftRebar1
        Me.commandManager.RightRebar = Me.RightRebar1
        Me.commandManager.TopRebar = Me.TopRebar1
        Me.commandManager.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.commandManager
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
        Me.cmHeader.CommandManager = Me.commandManager
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
        Me.cmdRenameThisColumn1.ControlValue = ""
        Me.cmdRenameThisColumn1.Key = "cmdRenameThisColumn"
        Me.cmdRenameThisColumn1.Name = "cmdRenameThisColumn1"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.commandManager
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.commandManager
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(0, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.commandManager
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(800, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.cmdExcel)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 537)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 38)
        Me.GroupBox1.TabIndex = 157
        Me.GroupBox1.TabStop = False
        '
        'cmdExcel
        '
        Me.cmdExcel.Location = New System.Drawing.Point(364, 11)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(75, 23)
        Me.cmdExcel.TabIndex = 171
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(624, 11)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 170
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(716, 11)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 23)
        Me.cmdPrint.TabIndex = 160
        Me.cmdPrint.Text = "Εκτύπωση"
        Me.cmdPrint.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'FilterEditor1
        '
        Me.FilterEditor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.FilterEditor1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilterEditor1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.UseFormatStyle
        Me.FilterEditor1.Location = New System.Drawing.Point(0, 0)
        Me.FilterEditor1.MinSize = New System.Drawing.Size(0, 0)
        Me.FilterEditor1.Name = "FilterEditor1"
        Me.FilterEditor1.ScrollMode = Janus.Windows.UI.Dock.ScrollMode.Both
        Me.FilterEditor1.ScrollStep = 15
        Me.FilterEditor1.Size = New System.Drawing.Size(800, 62)
        Me.FilterEditor1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2010
        '
        'dbView
        '
        Me.dbView.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.dbView.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Flat
        Me.dbView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dbView.Location = New System.Drawing.Point(0, 62)
        Me.dbView.Name = "dbView"
        Me.dbView.Size = New System.Drawing.Size(800, 475)
        Me.dbView.TabIndex = 161
        Me.dbView.TotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dbView.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.dbView.TotalRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'cboGrids
        '
        Me.cboGrids.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGrids.BackColor = System.Drawing.SystemColors.Info
        Me.cboGrids.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.cboGrids.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cboGrids_DesignTimeLayout.LayoutString = resources.GetString("cboGrids_DesignTimeLayout.LayoutString")
        Me.cboGrids.DesignTimeLayout = cboGrids_DesignTimeLayout
        Me.cboGrids.DisplayMember = "Name"
        Me.cboGrids.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboGrids.Location = New System.Drawing.Point(506, 14)
        Me.cboGrids.Name = "cboGrids"
        Me.cboGrids.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboGrids.SelectedIndex = -1
        Me.cboGrids.SelectedItem = Nothing
        Me.cboGrids.SettingsKey = "cboGrid"
        Me.cboGrids.Size = New System.Drawing.Size(177, 20)
        Me.cboGrids.TabIndex = 171
        Me.cboGrids.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboGrids.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'cmdSaveView
        '
        Me.cmdSaveView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSaveView.Image = CType(resources.GetObject("cmdSaveView.Image"), System.Drawing.Image)
        Me.cmdSaveView.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.cmdSaveView.Location = New System.Drawing.Point(689, 13)
        Me.cmdSaveView.Name = "cmdSaveView"
        Me.cmdSaveView.Size = New System.Drawing.Size(28, 24)
        Me.cmdSaveView.TabIndex = 170
        Me.cmdSaveView.ToolTipText = "Αποθήκευση Όψης"
        Me.cmdSaveView.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdDelteView
        '
        Me.cmdDelteView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelteView.Image = CType(resources.GetObject("cmdDelteView.Image"), System.Drawing.Image)
        Me.cmdDelteView.Location = New System.Drawing.Point(723, 14)
        Me.cmdDelteView.Name = "cmdDelteView"
        Me.cmdDelteView.Size = New System.Drawing.Size(31, 23)
        Me.cmdDelteView.TabIndex = 172
        Me.cmdDelteView.ToolTipText = "Διαγραφή Όψης"
        Me.cmdDelteView.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdSaveAsDef
        '
        Me.cmdSaveAsDef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSaveAsDef.Image = CType(resources.GetObject("cmdSaveAsDef.Image"), System.Drawing.Image)
        Me.cmdSaveAsDef.Location = New System.Drawing.Point(760, 13)
        Me.cmdSaveAsDef.Name = "cmdSaveAsDef"
        Me.cmdSaveAsDef.Size = New System.Drawing.Size(31, 23)
        Me.cmdSaveAsDef.TabIndex = 173
        Me.cmdSaveAsDef.ToolTipText = "Ορισμός ως Προεπιλογή"
        Me.cmdSaveAsDef.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'frmES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.cmdSaveAsDef)
        Me.Controls.Add(Me.cmdDelteView)
        Me.Controls.Add(Me.cboGrids)
        Me.Controls.Add(Me.cmdSaveView)
        Me.Controls.Add(Me.dbView)
        Me.Controls.Add(Me.FilterEditor1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TopRebar1)
        Me.Name = "frmES"
        Me.Text = "frmEsex"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.commandManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dbView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrids, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Protected WithEvents commandManager As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents cmdFieldChooser As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Protected WithEvents cmHeader As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents cmdFieldChooser1 As Janus.Windows.UI.CommandBars.UICommand
    Protected WithEvents cmdRemoveThisColumn As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRemoveThisColumn1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdRenameThisColumn As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRenameThisColumn1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents FilterEditor1 As Janus.Windows.FilterEditor.FilterEditor
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboGrids As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cmdSaveView As Janus.Windows.EditControls.UIButton
    Friend WithEvents dbView As Janus.Windows.GridEX.GridEX
    Friend WithEvents cmdSaveAsDef As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdDelteView As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents GridEXExporter1 As Janus.Windows.GridEX.Export.GridEXExporter
End Class
