<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParking
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
        Dim cboMainCus_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParking))
        Dim cboVEHT_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboJVEH_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtDateIN = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtCode = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtPrice = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboMainCus = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Πελάτης = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPOS = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtDateOUT = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cmdSave = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        Me.GridPAR = New Janus.Windows.GridEX.GridEX()
        Me.cboVEHT = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cmdRefresh = New Janus.Windows.EditControls.UIButton()
        Me.cboJVEH = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Label25 = New System.Windows.Forms.Label()
        CType(Me.cboMainCus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVEHT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboJVEH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Ημερ/νία δέσμευσης θέσης"
        '
        'dtDateIN
        '
        Me.dtDateIN.DateFormat = Janus.Windows.CalendarCombo.DateFormat.[Long]
        '
        '
        '
        Me.dtDateIN.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtDateIN.Location = New System.Drawing.Point(313, 25)
        Me.dtDateIN.Name = "dtDateIN"
        Me.dtDateIN.Size = New System.Drawing.Size(217, 20)
        Me.dtDateIN.TabIndex = 5
        Me.dtDateIN.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtDateIN.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(15, 25)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(77, 20)
        Me.txtCode.TabIndex = 149
        Me.txtCode.TabStop = False
        Me.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(15, 86)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(28, 13)
        Me.Label27.TabIndex = 155
        Me.Label27.Text = "Τιμή"
        '
        'txtPrice
        '
        Me.txtPrice.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtPrice.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.txtPrice.Location = New System.Drawing.Point(15, 102)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(61, 20)
        Me.txtPrice.TabIndex = 4
        Me.txtPrice.Text = "0,00 €"
        Me.txtPrice.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'cboMainCus
        '
        Me.cboMainCus.BackColor = System.Drawing.SystemColors.Info
        Me.cboMainCus.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboMainCus_DesignTimeLayout.LayoutString = resources.GetString("cboMainCus_DesignTimeLayout.LayoutString")
        Me.cboMainCus.DesignTimeLayout = cboMainCus_DesignTimeLayout
        Me.cboMainCus.DisplayMember = "Name"
        Me.cboMainCus.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboMainCus.Location = New System.Drawing.Point(114, 25)
        Me.cboMainCus.Name = "cboMainCus"
        Me.cboMainCus.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboMainCus.SelectedIndex = -1
        Me.cboMainCus.SelectedItem = Nothing
        Me.cboMainCus.SettingsKey = "cboCus"
        Me.cboMainCus.Size = New System.Drawing.Size(192, 20)
        Me.cboMainCus.TabIndex = 0
        Me.cboMainCus.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboMainCus.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Πελάτης
        '
        Me.Πελάτης.AutoSize = True
        Me.Πελάτης.Location = New System.Drawing.Point(111, 9)
        Me.Πελάτης.Name = "Πελάτης"
        Me.Πελάτης.Size = New System.Drawing.Size(50, 13)
        Me.Πελάτης.TabIndex = 154
        Me.Πελάτης.Text = "Πελάτης"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Κωδικός"
        '
        'txtPOS
        '
        Me.txtPOS.BackColor = System.Drawing.SystemColors.Info
        Me.txtPOS.Location = New System.Drawing.Point(15, 64)
        Me.txtPOS.Name = "txtPOS"
        Me.txtPOS.Size = New System.Drawing.Size(77, 20)
        Me.txtPOS.TabIndex = 2
        Me.txtPOS.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Θέση"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Τύπος οχήματος"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 13)
        Me.Label4.TabIndex = 162
        Me.Label4.Text = "Ημερ/νία αποδέσμευσης θέσης"
        '
        'dtDateOUT
        '
        Me.dtDateOUT.DateFormat = Janus.Windows.CalendarCombo.DateFormat.[Long]
        '
        '
        '
        Me.dtDateOUT.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtDateOUT.Location = New System.Drawing.Point(313, 64)
        Me.dtDateOUT.Name = "dtDateOUT"
        Me.dtDateOUT.Size = New System.Drawing.Size(217, 20)
        Me.dtDateOUT.TabIndex = 6
        Me.dtDateOUT.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtDateOUT.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(378, 429)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(459, 429)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 8
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'GridPAR
        '
        Me.GridPAR.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPAR.Location = New System.Drawing.Point(5, 128)
        Me.GridPAR.Name = "GridPAR"
        Me.GridPAR.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPAR.Size = New System.Drawing.Size(529, 295)
        Me.GridPAR.TabIndex = 165
        Me.GridPAR.TotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GridPAR.TotalRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.GridPAR.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'cboVEHT
        '
        Me.cboVEHT.BackColor = System.Drawing.SystemColors.Info
        Me.cboVEHT.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboVEHT_DesignTimeLayout.LayoutString = resources.GetString("cboVEHT_DesignTimeLayout.LayoutString")
        Me.cboVEHT.DesignTimeLayout = cboVEHT_DesignTimeLayout
        Me.cboVEHT.DisplayMember = "Name"
        Me.cboVEHT.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboVEHT.Location = New System.Drawing.Point(210, 64)
        Me.cboVEHT.Name = "cboVEHT"
        Me.cboVEHT.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboVEHT.SelectedIndex = -1
        Me.cboVEHT.SelectedItem = Nothing
        Me.cboVEHT.SettingsKey = "cboMainCus"
        Me.cboVEHT.Size = New System.Drawing.Size(96, 20)
        Me.cboVEHT.TabIndex = 3
        Me.cboVEHT.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboVEHT.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(297, 429)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(75, 23)
        Me.cmdRefresh.TabIndex = 166
        Me.cmdRefresh.Text = "Ανανέωση"
        Me.cmdRefresh.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cboJVEH
        '
        Me.cboJVEH.BackColor = System.Drawing.SystemColors.Info
        Me.cboJVEH.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboJVEH_DesignTimeLayout.LayoutString = resources.GetString("cboJVEH_DesignTimeLayout.LayoutString")
        Me.cboJVEH.DesignTimeLayout = cboJVEH_DesignTimeLayout
        Me.cboJVEH.DisplayMember = "Name"
        Me.cboJVEH.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboJVEH.Location = New System.Drawing.Point(114, 64)
        Me.cboJVEH.Name = "cboJVEH"
        Me.cboJVEH.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboJVEH.SelectedIndex = -1
        Me.cboJVEH.SelectedItem = Nothing
        Me.cboJVEH.SettingsKey = "cboMainCus"
        Me.cboJVEH.Size = New System.Drawing.Size(87, 20)
        Me.cboJVEH.TabIndex = 167
        Me.cboJVEH.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboJVEH.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(111, 48)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(41, 13)
        Me.Label25.TabIndex = 168
        Me.Label25.Text = "Όχημα"
        '
        'frmParking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(543, 456)
        Me.Controls.Add(Me.cboJVEH)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cboVEHT)
        Me.Controls.Add(Me.GridPAR)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtDateOUT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPOS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtDateIN)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.cboMainCus)
        Me.Controls.Add(Me.Πελάτης)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmParking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Διαχείριση Πάρκινγκ"
        CType(Me.cboMainCus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVEHT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboJVEH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtDateIN As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtCode As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtPrice As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboMainCus As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Πελάτης As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPOS As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtDateOUT As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents GridPAR As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboVEHT As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cmdRefresh As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboJVEH As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Label25 As Label
End Class
