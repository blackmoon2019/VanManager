<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrid
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrid))
        Dim GridMain_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.GridMain = New Janus.Windows.GridEX.GridEX()
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
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridMain.Location = New System.Drawing.Point(1, 0)
        Me.GridMain.Name = "GridMain"
        Me.GridMain.RecordNavigator = True
        Me.GridMain.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridMain.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.GridMain.Size = New System.Drawing.Size(1296, 734)
        Me.GridMain.TabIndex = 137
        Me.GridMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(1210, 748)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 192
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
        Me.TopRebar1.Size = New System.Drawing.Size(1297, 0)
        '
        'frmGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 783)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.GridMain)
        Me.Controls.Add(Me.TopRebar1)
        Me.Name = "frmGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Δρομολόγια"
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridMain As Janus.Windows.GridEX.GridEX
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
    Protected WithEvents comManager As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Protected WithEvents cmHeader As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents cmdFieldChooser As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRemoveThisColumn As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRenameThisColumn As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSaveLayout As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdFieldChooser1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRemoveThisColumn1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRenameThisColumn1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSaveLayout1 As Janus.Windows.UI.CommandBars.UICommand
End Class
