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
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dbView = New Janus.Windows.GridEX.GridEX()
        Me.cmdCreateInvoice = New System.Windows.Forms.Button()
        Me.commandManager = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.cmdFieldChooser = New Janus.Windows.UI.CommandBars.UICommand("cmdFieldChooser")
        Me.cmdRemoveThisColumn = New Janus.Windows.UI.CommandBars.UICommand("cmdRemoveThisColumn")
        Me.cmHeader = New Janus.Windows.UI.CommandBars.UIContextMenu()
        Me.cmdFieldChooser1 = New Janus.Windows.UI.CommandBars.UICommand("cmdFieldChooser")
        Me.cmdRemoveThisColumn1 = New Janus.Windows.UI.CommandBars.UICommand("cmdRemoveThisColumn")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dbView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.commandManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(604, 540)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(89, 23)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(699, 540)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(89, 23)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cboCus)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(799, 98)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Φίλτρα"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Έως"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Από"
        '
        'cboCus
        '
        Me.cboCus.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboCus.FormattingEnabled = True
        Me.cboCus.Location = New System.Drawing.Point(6, 35)
        Me.cboCus.Name = "cboCus"
        Me.cboCus.Size = New System.Drawing.Size(185, 21)
        Me.cboCus.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Πελάτης"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(244, 62)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(244, 36)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'dbView
        '
        Me.dbView.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Flat
        Me.dbView.Location = New System.Drawing.Point(1, 98)
        Me.dbView.Name = "dbView"
        Me.dbView.Size = New System.Drawing.Size(799, 414)
        Me.dbView.TabIndex = 8
        Me.dbView.TotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dbView.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.dbView.TotalRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'cmdCreateInvoice
        '
        Me.cmdCreateInvoice.Location = New System.Drawing.Point(1, 540)
        Me.cmdCreateInvoice.Name = "cmdCreateInvoice"
        Me.cmdCreateInvoice.Size = New System.Drawing.Size(119, 23)
        Me.cmdCreateInvoice.TabIndex = 9
        Me.cmdCreateInvoice.Text = "Έκδοση Τιμολογίου"
        Me.cmdCreateInvoice.UseVisualStyleBackColor = True
        '
        'commandManager
        '
        Me.commandManager.BottomRebar = Me.BottomRebar1
        Me.commandManager.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdFieldChooser, Me.cmdRemoveThisColumn})
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
        'cmHeader
        '
        Me.cmHeader.CommandManager = Me.commandManager
        Me.cmHeader.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdFieldChooser1, Me.cmdRemoveThisColumn1})
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
        'frmES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.cmdCreateInvoice)
        Me.Controls.Add(Me.dbView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.TopRebar1)
        Me.Name = "frmES"
        Me.Text = "frmEsex"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dbView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.commandManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dbView As Janus.Windows.GridEX.GridEX
    Friend WithEvents cmdCreateInvoice As Button
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
End Class
