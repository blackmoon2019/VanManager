<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportFilters
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
        Dim cboMainCus_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportFilters))
        Me.dtDateOUT = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtDateIN = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboMainCus = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Πελάτης = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdPrint = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        CType(Me.cboMainCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtDateOUT
        '
        Me.dtDateOUT.DateFormat = Janus.Windows.CalendarCombo.DateFormat.[Long]
        '
        '
        '
        Me.dtDateOUT.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtDateOUT.Location = New System.Drawing.Point(12, 74)
        Me.dtDateOUT.Name = "dtDateOUT"
        Me.dtDateOUT.Size = New System.Drawing.Size(217, 20)
        Me.dtDateOUT.TabIndex = 157
        Me.dtDateOUT.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtDateOUT.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'dtDateIN
        '
        Me.dtDateIN.DateFormat = Janus.Windows.CalendarCombo.DateFormat.[Long]
        '
        '
        '
        Me.dtDateIN.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtDateIN.Location = New System.Drawing.Point(12, 26)
        Me.dtDateIN.Name = "dtDateIN"
        Me.dtDateIN.Size = New System.Drawing.Size(217, 20)
        Me.dtDateIN.TabIndex = 156
        Me.dtDateIN.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtDateIN.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'cboMainCus
        '
        Me.cboMainCus.BackColor = System.Drawing.SystemColors.Info
        Me.cboMainCus.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboMainCus_DesignTimeLayout.LayoutString = resources.GetString("cboMainCus_DesignTimeLayout.LayoutString")
        Me.cboMainCus.DesignTimeLayout = cboMainCus_DesignTimeLayout
        Me.cboMainCus.DisplayMember = "Name"
        Me.cboMainCus.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboMainCus.Location = New System.Drawing.Point(15, 124)
        Me.cboMainCus.Name = "cboMainCus"
        Me.cboMainCus.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboMainCus.SelectedIndex = -1
        Me.cboMainCus.SelectedItem = Nothing
        Me.cboMainCus.SettingsKey = "cboCus"
        Me.cboMainCus.Size = New System.Drawing.Size(214, 20)
        Me.cboMainCus.TabIndex = 155
        Me.cboMainCus.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboMainCus.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Πελάτης
        '
        Me.Πελάτης.AutoSize = True
        Me.Πελάτης.Location = New System.Drawing.Point(12, 108)
        Me.Πελάτης.Name = "Πελάτης"
        Me.Πελάτης.Size = New System.Drawing.Size(50, 13)
        Me.Πελάτης.TabIndex = 158
        Me.Πελάτης.Text = "Πελάτης"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Από"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Έως"
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(74, 164)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 23)
        Me.cmdPrint.TabIndex = 161
        Me.cmdPrint.Text = "Εκτύπωση"
        Me.cmdPrint.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(155, 164)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 162
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'frmReportFilters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 203)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtDateOUT)
        Me.Controls.Add(Me.dtDateIN)
        Me.Controls.Add(Me.cboMainCus)
        Me.Controls.Add(Me.Πελάτης)
        Me.Name = "frmReportFilters"
        Me.Text = "frmReportFilters"
        CType(Me.cboMainCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtDateOUT As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtDateIN As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboMainCus As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Πελάτης As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
End Class
