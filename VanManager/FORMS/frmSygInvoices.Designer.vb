﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSygInvoices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSygInvoices))
        Dim GridMain_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboMainCus_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.GridMain = New Janus.Windows.GridEX.GridEX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboMainCus = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cmdInvoice = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        Me.comManager = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.cmdFieldChooser = New Janus.Windows.UI.CommandBars.UICommand("cmdFieldChooser")
        Me.cmdRemoveThisColumn = New Janus.Windows.UI.CommandBars.UICommand("cmdRemoveThisColumn")
        Me.cmdRenameThisColumn = New Janus.Windows.UI.CommandBars.UICommand("cmdRenameThisColumn")
        Me.cmdSaveLayout = New Janus.Windows.UI.CommandBars.UICommand("cmdSaveLayout")
        Me.cmHeader = New Janus.Windows.UI.CommandBars.UIContextMenu()
        Me.cmdFieldChooser1 = New Janus.Windows.UI.CommandBars.UICommand("cmdFieldChooser")
        Me.cmdRemoveThisColumn1 = New Janus.Windows.UI.CommandBars.UICommand("cmdRemoveThisColumn")
        Me.cmdRenameThisColumn1 = New Janus.Windows.UI.CommandBars.UICommand("cmdRenameThisColumn")
        Me.cmdSaveLayout1 = New Janus.Windows.UI.CommandBars.UICommand("cmdSaveLayout")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.grpSearch = New Janus.Windows.EditControls.UIGroupBox()
        Me.cmdSearch = New Janus.Windows.EditControls.UIButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtToDate = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtFromDate = New Janus.Windows.CalendarCombo.CalendarCombo()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMainCus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridMain
        '
        Me.GridMain.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridMain.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMain.AlternatingColors = True
        Me.GridMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMain.BuiltInTextsData = resources.GetString("GridMain.BuiltInTextsData")
        GridMain_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
        Me.GridMain.DesignTimeLayout = GridMain_DesignTimeLayout
        Me.GridMain.DynamicFiltering = True
        Me.GridMain.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridMain.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridMain.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridMain.Location = New System.Drawing.Point(2, 90)
        Me.GridMain.Name = "GridMain"
        Me.GridMain.RecordNavigator = True
        Me.GridMain.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridMain.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.GridMain.Size = New System.Drawing.Size(875, 511)
        Me.GridMain.TabIndex = 135
        Me.GridMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(875, 88)
        Me.Label1.TabIndex = 189
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(183, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Πελάτης"
        '
        'cboMainCus
        '
        Me.cboMainCus.BackColor = System.Drawing.SystemColors.Info
        Me.cboMainCus.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboMainCus_DesignTimeLayout.LayoutString = resources.GetString("cboMainCus_DesignTimeLayout.LayoutString")
        Me.cboMainCus.DesignTimeLayout = cboMainCus_DesignTimeLayout
        Me.cboMainCus.DisplayMember = "Name"
        Me.cboMainCus.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboMainCus.Location = New System.Drawing.Point(271, 30)
        Me.cboMainCus.Name = "cboMainCus"
        Me.cboMainCus.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboMainCus.SelectedIndex = -1
        Me.cboMainCus.SelectedItem = Nothing
        Me.cboMainCus.SettingsKey = "cboMainCus"
        Me.cboMainCus.Size = New System.Drawing.Size(233, 20)
        Me.cboMainCus.TabIndex = 133
        Me.cboMainCus.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboMainCus.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'cmdInvoice
        '
        Me.cmdInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cmdInvoice.Location = New System.Drawing.Point(672, 607)
        Me.cmdInvoice.Name = "cmdInvoice"
        Me.cmdInvoice.Size = New System.Drawing.Size(124, 23)
        Me.cmdInvoice.TabIndex = 190
        Me.cmdInvoice.Text = "Έκδοση Τιμολογίου"
        Me.cmdInvoice.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(802, 607)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 191
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'comManager
        '
        Me.comManager.BottomRebar = Me.BottomRebar1
        Me.comManager.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdFieldChooser, Me.cmdRemoveThisColumn, Me.cmdRenameThisColumn, Me.cmdSaveLayout})
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
        'cmdSaveLayout
        '
        Me.cmdSaveLayout.Key = "cmdSaveLayout"
        Me.cmdSaveLayout.Name = "cmdSaveLayout"
        Me.cmdSaveLayout.Text = "Αποθήκευση Σχεδίου"
        '
        'cmHeader
        '
        Me.cmHeader.CommandManager = Me.comManager
        Me.cmHeader.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdFieldChooser1, Me.cmdRemoveThisColumn1, Me.cmdRenameThisColumn1, Me.cmdSaveLayout1})
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
        'cmdSaveLayout1
        '
        Me.cmdSaveLayout1.Key = "cmdSaveLayout"
        Me.cmdSaveLayout1.Name = "cmdSaveLayout1"
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
        Me.TopRebar1.Size = New System.Drawing.Size(880, 0)
        '
        'grpSearch
        '
        Me.grpSearch.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.TabPage
        Me.grpSearch.Controls.Add(Me.cmdSearch)
        Me.grpSearch.Controls.Add(Me.Label2)
        Me.grpSearch.Controls.Add(Me.Label4)
        Me.grpSearch.Controls.Add(Me.dtToDate)
        Me.grpSearch.Controls.Add(Me.dtFromDate)
        Me.grpSearch.Enabled = False
        Me.grpSearch.Image = CType(resources.GetObject("grpSearch.Image"), System.Drawing.Image)
        Me.grpSearch.Location = New System.Drawing.Point(560, 4)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(179, 75)
        Me.grpSearch.TabIndex = 192
        Me.grpSearch.Text = "Διάστημα Από/Έως"
        Me.grpSearch.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'cmdSearch
        '
        Me.cmdSearch.Appearance = Janus.Windows.UI.Appearance.Normal
        Me.cmdSearch.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.Location = New System.Drawing.Point(148, 34)
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
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Έως"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "Από"
        '
        'dtToDate
        '
        '
        '
        '
        Me.dtToDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtToDate.HoverMode = Janus.Windows.CalendarCombo.HoverMode.Highlight
        Me.dtToDate.Location = New System.Drawing.Point(39, 47)
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
        Me.dtFromDate.Location = New System.Drawing.Point(39, 21)
        Me.dtFromDate.Name = "dtFromDate"
        Me.dtFromDate.Size = New System.Drawing.Size(103, 20)
        Me.dtFromDate.TabIndex = 158
        Me.dtFromDate.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtFromDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'frmSygInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(880, 636)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.cmdInvoice)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.GridMain)
        Me.Controls.Add(Me.cboMainCus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TopRebar1)
        Me.Name = "frmSygInvoices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSygInvoices"
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMainCus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridMain As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboMainCus As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cmdInvoice As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
    Protected WithEvents comManager As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents cmdFieldChooser As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRemoveThisColumn As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRenameThisColumn As Janus.Windows.UI.CommandBars.UICommand
    Protected WithEvents cmHeader As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents cmdFieldChooser1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRemoveThisColumn1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRenameThisColumn1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents cmdSaveLayout As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSaveLayout1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents grpSearch As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cmdSearch As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtToDate As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtFromDate As Janus.Windows.CalendarCombo.CalendarCombo
End Class
