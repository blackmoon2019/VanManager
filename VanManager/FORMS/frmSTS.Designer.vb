<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSTS
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
        Dim cboUSERS_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSTS))
        Dim cboSDT_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboDOS_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.txtCode = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboUSERS = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboSDT = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDOS = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdSave = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        CType(Me.cboUSERS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(88, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(83, 20)
        Me.txtCode.TabIndex = 70
        Me.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Κωδικός"
        '
        'cboUSERS
        '
        Me.cboUSERS.BackColor = System.Drawing.SystemColors.Info
        Me.cboUSERS.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboUSERS_DesignTimeLayout.LayoutString = resources.GetString("cboUSERS_DesignTimeLayout.LayoutString")
        Me.cboUSERS.DesignTimeLayout = cboUSERS_DesignTimeLayout
        Me.cboUSERS.DisplayMember = "Name"
        Me.cboUSERS.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboUSERS.Location = New System.Drawing.Point(88, 51)
        Me.cboUSERS.Name = "cboUSERS"
        Me.cboUSERS.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboUSERS.SelectedIndex = -1
        Me.cboUSERS.SelectedItem = Nothing
        Me.cboUSERS.SettingsKey = "cboTempType"
        Me.cboUSERS.Size = New System.Drawing.Size(229, 20)
        Me.cboUSERS.TabIndex = 198
        Me.cboUSERS.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboUSERS.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 55)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 13)
        Me.Label21.TabIndex = 199
        Me.Label21.Text = "Χρήστης"
        '
        'cboSDT
        '
        Me.cboSDT.BackColor = System.Drawing.SystemColors.Info
        Me.cboSDT.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboSDT_DesignTimeLayout.LayoutString = resources.GetString("cboSDT_DesignTimeLayout.LayoutString")
        Me.cboSDT.DesignTimeLayout = cboSDT_DesignTimeLayout
        Me.cboSDT.DisplayMember = "Name"
        Me.cboSDT.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboSDT.Location = New System.Drawing.Point(88, 97)
        Me.cboSDT.Name = "cboSDT"
        Me.cboSDT.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboSDT.SelectedIndex = -1
        Me.cboSDT.SelectedItem = Nothing
        Me.cboSDT.SettingsKey = "cboTempType"
        Me.cboSDT.Size = New System.Drawing.Size(229, 20)
        Me.cboSDT.TabIndex = 200
        Me.cboSDT.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboSDT.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 201
        Me.Label1.Text = "Τύπος Παρασ."
        '
        'cboDOS
        '
        Me.cboDOS.BackColor = System.Drawing.SystemColors.Info
        Me.cboDOS.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboDOS_DesignTimeLayout.LayoutString = resources.GetString("cboDOS_DesignTimeLayout.LayoutString")
        Me.cboDOS.DesignTimeLayout = cboDOS_DesignTimeLayout
        Me.cboDOS.DisplayMember = "Name"
        Me.cboDOS.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboDOS.Location = New System.Drawing.Point(88, 142)
        Me.cboDOS.Name = "cboDOS"
        Me.cboDOS.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboDOS.SelectedIndex = -1
        Me.cboDOS.SelectedItem = Nothing
        Me.cboDOS.SettingsKey = "cboTempType"
        Me.cboDOS.Size = New System.Drawing.Size(229, 20)
        Me.cboDOS.TabIndex = 202
        Me.cboDOS.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboDOS.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 203
        Me.Label2.Text = "Σειρά"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(242, 183)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 205
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(150, 183)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 204
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'frmSTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 217)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cboDOS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSDT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboUSERS)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.Name = "frmSTS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSTS"
        CType(Me.cboUSERS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCode As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboUSERS As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Label21 As Label
    Friend WithEvents cboSDT As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Label1 As Label
    Friend WithEvents cboDOS As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
End Class
