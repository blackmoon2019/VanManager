<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEXcat
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
        Dim cboFixed_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEXcat))
        Dim cboRepeat_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtPayment = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtCode = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.cmdSave = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        Me.cboFixed = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cboRepeat = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.dtDateContract = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.cboFixed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRepeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "Είναι Πάγιο"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Έξοδο"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Κωδικός"
        '
        'dtPayment
        '
        Me.dtPayment.BackColor = System.Drawing.SystemColors.Menu
        Me.dtPayment.Location = New System.Drawing.Point(237, 26)
        Me.dtPayment.Name = "dtPayment"
        Me.dtPayment.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Ημερομηνία Πληρωμής"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Επανάληψη κάθε"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(9, 71)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(171, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(9, 26)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(82, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(375, 191)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(283, 191)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cboFixed
        '
        Me.cboFixed.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cboFixed.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.cboFixed.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cboFixed_DesignTimeLayout.LayoutString = resources.GetString("cboFixed_DesignTimeLayout.LayoutString")
        Me.cboFixed.DesignTimeLayout = cboFixed_DesignTimeLayout
        Me.cboFixed.DisplayMember = "Name"
        Me.cboFixed.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboFixed.Location = New System.Drawing.Point(9, 126)
        Me.cboFixed.Name = "cboFixed"
        Me.cboFixed.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboFixed.SelectedIndex = -1
        Me.cboFixed.SelectedItem = Nothing
        Me.cboFixed.SettingsKey = "cboMainCus"
        Me.cboFixed.Size = New System.Drawing.Size(82, 20)
        Me.cboFixed.TabIndex = 2
        Me.cboFixed.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboFixed.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'cboRepeat
        '
        Me.cboRepeat.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cboRepeat.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.cboRepeat.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cboRepeat_DesignTimeLayout.LayoutString = resources.GetString("cboRepeat_DesignTimeLayout.LayoutString")
        Me.cboRepeat.DesignTimeLayout = cboRepeat_DesignTimeLayout
        Me.cboRepeat.DisplayMember = "Name"
        Me.cboRepeat.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboRepeat.Location = New System.Drawing.Point(117, 126)
        Me.cboRepeat.Name = "cboRepeat"
        Me.cboRepeat.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboRepeat.SelectedIndex = -1
        Me.cboRepeat.SelectedItem = Nothing
        Me.cboRepeat.SettingsKey = "cboRepeat"
        Me.cboRepeat.Size = New System.Drawing.Size(108, 20)
        Me.cboRepeat.TabIndex = 3
        Me.cboRepeat.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboRepeat.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'dtDateContract
        '
        Me.dtDateContract.DateFormat = Janus.Windows.CalendarCombo.DateFormat.[Long]
        '
        '
        '
        Me.dtDateContract.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtDateContract.Enabled = False
        Me.dtDateContract.Location = New System.Drawing.Point(8, 186)
        Me.dtDateContract.Name = "dtDateContract"
        Me.dtDateContract.Size = New System.Drawing.Size(217, 20)
        Me.dtDateContract.TabIndex = 157
        Me.dtDateContract.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtDateContract.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 13)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Ημερομηνία Λήξης συμβολαίου"
        '
        'frmEXcat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(461, 218)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtDateContract)
        Me.Controls.Add(Me.cboRepeat)
        Me.Controls.Add(Me.cboFixed)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtPayment)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.Name = "frmEXcat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Κατηγορίες Εξόδων"
        CType(Me.cboFixed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRepeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtPayment As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtCode As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents cmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboFixed As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cboRepeat As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents dtDateContract As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label5 As Label
End Class
