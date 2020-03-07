<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVeh
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
        Dim cboVEHT_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVeh))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlate = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtCode = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.cmdSave = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        Me.cboVEHT = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        CType(Me.cboVEHT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 13)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Τύπος Οχήματος"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Πινακίδα"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Κωδικός"
        '
        'txtPlate
        '
        Me.txtPlate.BackColor = System.Drawing.SystemColors.Info
        Me.txtPlate.Location = New System.Drawing.Point(103, 26)
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(121, 20)
        Me.txtPlate.TabIndex = 1
        Me.txtPlate.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(12, 26)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(82, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(149, 107)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(57, 107)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cboVEHT
        '
        Me.cboVEHT.BackColor = System.Drawing.SystemColors.Info
        Me.cboVEHT.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboVEHT_DesignTimeLayout.LayoutString = resources.GetString("cboVEHT_DesignTimeLayout.LayoutString")
        Me.cboVEHT.DesignTimeLayout = cboVEHT_DesignTimeLayout
        Me.cboVEHT.DisplayMember = "Name"
        Me.cboVEHT.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboVEHT.Location = New System.Drawing.Point(11, 74)
        Me.cboVEHT.Name = "cboVEHT"
        Me.cboVEHT.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboVEHT.SelectedIndex = -1
        Me.cboVEHT.SelectedItem = Nothing
        Me.cboVEHT.SettingsKey = "cboMainCus"
        Me.cboVEHT.Size = New System.Drawing.Size(213, 20)
        Me.cboVEHT.TabIndex = 2
        Me.cboVEHT.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboVEHT.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'frmVeh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(232, 136)
        Me.Controls.Add(Me.cboVEHT)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtPlate)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmVeh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Οχήματα"
        CType(Me.cboVEHT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPlate As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtCode As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents cmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboVEHT As Janus.Windows.GridEX.EditControls.MultiColumnCombo
End Class
