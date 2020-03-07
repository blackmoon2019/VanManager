<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPPreview))
        Me.Ribbon1 = New Janus.Windows.Ribbon.Ribbon()
        Me.RibbonTab1 = New Janus.Windows.Ribbon.RibbonTab()
        Me.RibbonGroup1 = New Janus.Windows.Ribbon.RibbonGroup()
        Me.BCPrint = New Janus.Windows.Ribbon.ButtonCommand()
        Me.BCPageSetup = New Janus.Windows.Ribbon.ButtonCommand()
        Me.RibbonGroup2 = New Janus.Windows.Ribbon.RibbonGroup()
        Me.ButtonCommand2 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.ButtonCommand3 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.ButtonCommand4 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.RibbonGroup3 = New Janus.Windows.Ribbon.RibbonGroup()
        Me.ButtonCommand5 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.ButtonCommand6 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.SeparatorCommand1 = New Janus.Windows.Ribbon.SeparatorCommand()
        Me.ButtonCommand7 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.RibbonTab2 = New Janus.Windows.Ribbon.RibbonTab()
        Me.RibbonGroup4 = New Janus.Windows.Ribbon.RibbonGroup()
        Me.DropDownCommand1 = New Janus.Windows.Ribbon.DropDownCommand()
        Me.DropDownCommand2 = New Janus.Windows.Ribbon.DropDownCommand()
        Me.DropDownCommand3 = New Janus.Windows.Ribbon.DropDownCommand()
        Me.DropDownCommand4 = New Janus.Windows.Ribbon.DropDownCommand()
        Me.DropDownCommand5 = New Janus.Windows.Ribbon.DropDownCommand()
        Me.rcmdPrint = New Janus.Windows.Ribbon.ButtonCommand()
        Me.ButtonCommand1 = New Janus.Windows.Ribbon.ButtonCommand()
        Me.rcmdPageSetup = New Janus.Windows.Ribbon.ButtonCommand()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument()
        CType(Me.Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ribbon1
        '
        Me.Ribbon1.BackstageMenuData = "<?xml version=""1.0"" encoding=""utf-8""?><BackstageMenu><ImageKey /><Key /><Text>Fil" &
    "e</Text></BackstageMenu>"
        '
        '
        '
        Me.Ribbon1.HelpButton.Image = CType(resources.GetObject("Ribbon1.HelpButton.Image"), System.Drawing.Image)
        Me.Ribbon1.HelpButton.Key = "HelpButton"
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Name = "Ribbon1"
        Me.Ribbon1.Size = New System.Drawing.Size(800, 146)
        '
        '
        '
        Me.Ribbon1.SuperTipComponent.AutoPopDelay = 2000
        Me.Ribbon1.SuperTipComponent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Ribbon1.SuperTipComponent.ImageList = Nothing
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.AddRange(New Janus.Windows.Ribbon.RibbonTab() {Me.RibbonTab1, Me.RibbonTab2})
        Me.Ribbon1.Text = ""
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Groups.AddRange(New Janus.Windows.Ribbon.RibbonGroup() {Me.RibbonGroup1, Me.RibbonGroup2, Me.RibbonGroup3})
        Me.RibbonTab1.Key = "RibbonTab1"
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Print Preview"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.BCPrint, Me.BCPageSetup})
        Me.RibbonGroup1.DialogButtonSuperTipSettings.ImageListProvider = Me.RibbonGroup1
        Me.RibbonGroup1.Key = "RibbonGroup1"
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Text = "Print"
        '
        'BCPrint
        '
        Me.BCPrint.Image = CType(resources.GetObject("BCPrint.Image"), System.Drawing.Image)
        Me.BCPrint.Key = "Print"
        Me.BCPrint.Name = "BCPrint"
        Me.BCPrint.Text = "Εκτύπωση"
        '
        'BCPageSetup
        '
        Me.BCPageSetup.Image = CType(resources.GetObject("BCPageSetup.Image"), System.Drawing.Image)
        Me.BCPageSetup.Key = "Page_Setup"
        Me.BCPageSetup.Name = "BCPageSetup"
        Me.BCPageSetup.Text = "Πριθώρια"
        '
        'RibbonGroup2
        '
        Me.RibbonGroup2.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.ButtonCommand2, Me.ButtonCommand3, Me.ButtonCommand4})
        Me.RibbonGroup2.DialogButtonSuperTipSettings.ImageListProvider = Me.RibbonGroup2
        Me.RibbonGroup2.Key = "RibbonGroup2"
        Me.RibbonGroup2.Name = "RibbonGroup2"
        Me.RibbonGroup2.Text = "Προβολή"
        '
        'ButtonCommand2
        '
        Me.ButtonCommand2.Image = CType(resources.GetObject("ButtonCommand2.Image"), System.Drawing.Image)
        Me.ButtonCommand2.Key = "Actual_Size"
        Me.ButtonCommand2.Name = "ButtonCommand2"
        Me.ButtonCommand2.Text = "Πλάτος Σελίδας"
        '
        'ButtonCommand3
        '
        Me.ButtonCommand3.Image = CType(resources.GetObject("ButtonCommand3.Image"), System.Drawing.Image)
        Me.ButtonCommand3.Key = "One_Page"
        Me.ButtonCommand3.Name = "ButtonCommand3"
        Me.ButtonCommand3.Text = "1 Σελίδα"
        '
        'ButtonCommand4
        '
        Me.ButtonCommand4.Image = CType(resources.GetObject("ButtonCommand4.Image"), System.Drawing.Image)
        Me.ButtonCommand4.Key = "Two_Pages"
        Me.ButtonCommand4.Name = "ButtonCommand4"
        Me.ButtonCommand4.Text = "2 Σελίδες"
        '
        'RibbonGroup3
        '
        Me.RibbonGroup3.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.ButtonCommand5, Me.ButtonCommand6, Me.SeparatorCommand1, Me.ButtonCommand7})
        Me.RibbonGroup3.DialogButtonSuperTipSettings.ImageListProvider = Me.RibbonGroup3
        Me.RibbonGroup3.Key = "RibbonGroup3"
        Me.RibbonGroup3.Name = "RibbonGroup3"
        Me.RibbonGroup3.Text = "Προεπισκόπηση"
        '
        'ButtonCommand5
        '
        Me.ButtonCommand5.Image = CType(resources.GetObject("ButtonCommand5.Image"), System.Drawing.Image)
        Me.ButtonCommand5.Key = "Next_Page"
        Me.ButtonCommand5.Name = "ButtonCommand5"
        Me.ButtonCommand5.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.ButtonCommand5.Text = "Επόμενη Σελίδα"
        '
        'ButtonCommand6
        '
        Me.ButtonCommand6.Image = CType(resources.GetObject("ButtonCommand6.Image"), System.Drawing.Image)
        Me.ButtonCommand6.Key = "Previews_Page"
        Me.ButtonCommand6.Name = "ButtonCommand6"
        Me.ButtonCommand6.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.ButtonCommand6.Text = "Προηγούμενη Σελίδα"
        '
        'SeparatorCommand1
        '
        Me.SeparatorCommand1.Key = "SeparatorCommand1"
        Me.SeparatorCommand1.Name = "SeparatorCommand1"
        '
        'ButtonCommand7
        '
        Me.ButtonCommand7.Image = CType(resources.GetObject("ButtonCommand7.Image"), System.Drawing.Image)
        Me.ButtonCommand7.Key = "Close_Preview"
        Me.ButtonCommand7.Name = "ButtonCommand7"
        Me.ButtonCommand7.Text = "Κλείσιμο Προεπισκόπησης"
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Groups.AddRange(New Janus.Windows.Ribbon.RibbonGroup() {Me.RibbonGroup4})
        Me.RibbonTab2.Key = "RibbonTab2"
        Me.RibbonTab2.Name = "RibbonTab2"
        Me.RibbonTab2.Text = "Διάταξη"
        '
        'RibbonGroup4
        '
        Me.RibbonGroup4.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.DropDownCommand1, Me.DropDownCommand3})
        Me.RibbonGroup4.DialogButtonSuperTipSettings.ImageListProvider = Me.RibbonGroup4
        Me.RibbonGroup4.Key = "RibbonGroup4"
        Me.RibbonGroup4.Name = "RibbonGroup4"
        Me.RibbonGroup4.Text = "Διαμόρφωση Σελίδας"
        '
        'DropDownCommand1
        '
        Me.DropDownCommand1.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.DropDownCommand2})
        Me.DropDownCommand1.Key = "DropDownCommand1"
        Me.DropDownCommand1.Name = "DropDownCommand1"
        Me.DropDownCommand1.Text = "Περιθώρια"
        '
        'DropDownCommand2
        '
        Me.DropDownCommand2.Key = "DropDownCommand2"
        Me.DropDownCommand2.Name = "DropDownCommand2"
        Me.DropDownCommand2.Text = "Κανονικά"
        '
        'DropDownCommand3
        '
        Me.DropDownCommand3.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.DropDownCommand4, Me.DropDownCommand5})
        Me.DropDownCommand3.Key = "DropDownCommand3"
        Me.DropDownCommand3.Name = "DropDownCommand3"
        Me.DropDownCommand3.Text = "Προσανατολισμός"
        '
        'DropDownCommand4
        '
        Me.DropDownCommand4.Key = "Portrait"
        Me.DropDownCommand4.Name = "DropDownCommand4"
        Me.DropDownCommand4.Text = "Κατακόρυφος"
        '
        'DropDownCommand5
        '
        Me.DropDownCommand5.Key = "LandScape"
        Me.DropDownCommand5.Name = "DropDownCommand5"
        Me.DropDownCommand5.Text = "Οριζόντιος"
        '
        'rcmdPrint
        '
        Me.rcmdPrint.Key = "rcmdPrint"
        Me.rcmdPrint.LargeImageKey = "Printing.ico"
        Me.rcmdPrint.Name = "rcmdPrint"
        Me.rcmdPrint.Text = "Print"
        '
        'ButtonCommand1
        '
        Me.ButtonCommand1.Key = "rcmdPrint"
        Me.ButtonCommand1.LargeImageKey = "Printing.ico"
        Me.ButtonCommand1.Name = "rcmdPrint"
        Me.ButtonCommand1.Text = "Print"
        '
        'rcmdPageSetup
        '
        Me.rcmdPageSetup.Key = "rcmdPageSetup"
        Me.rcmdPageSetup.LargeImageKey = "Page Setup.ico"
        Me.rcmdPageSetup.Name = "rcmdPageSetup"
        Me.rcmdPageSetup.Text = "Page Setup"
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(0, 146)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(800, 431)
        Me.PrintPreviewControl1.TabIndex = 2
        Me.PrintPreviewControl1.UseAntiAlias = True
        Me.PrintPreviewControl1.Zoom = 1.0R
        '
        'GridEXPrintDocument1
        '
        '
        'frmPPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 577)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Controls.Add(Me.Ribbon1)
        Me.Name = "frmPPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPPreview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ribbon1 As Janus.Windows.Ribbon.Ribbon
    Friend WithEvents RibbonTab1 As Janus.Windows.Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As Janus.Windows.Ribbon.RibbonGroup
    Friend WithEvents BCPrint As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents BCPageSetup As Janus.Windows.Ribbon.ButtonCommand
    Private WithEvents rcmdPrint As Janus.Windows.Ribbon.ButtonCommand
    Private WithEvents ButtonCommand1 As Janus.Windows.Ribbon.ButtonCommand
    Private WithEvents rcmdPageSetup As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents RibbonGroup2 As Janus.Windows.Ribbon.RibbonGroup
    Friend WithEvents ButtonCommand2 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents ButtonCommand3 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents ButtonCommand4 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents RibbonGroup3 As Janus.Windows.Ribbon.RibbonGroup
    Friend WithEvents ButtonCommand5 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents ButtonCommand6 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents SeparatorCommand1 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents ButtonCommand7 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents RibbonTab2 As Janus.Windows.Ribbon.RibbonTab
    Friend WithEvents RibbonGroup4 As Janus.Windows.Ribbon.RibbonGroup
    Friend WithEvents DropDownCommand1 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents DropDownCommand2 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents DropDownCommand3 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents DropDownCommand4 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents DropDownCommand5 As Janus.Windows.Ribbon.DropDownCommand
End Class
