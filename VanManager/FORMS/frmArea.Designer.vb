<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArea
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
        Dim cboCOU_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArea))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCode = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.cboCOU = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.txtName = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.cmdSave = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        CType(Me.cboCOU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Κωδικός"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Περιοχή"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Νομός"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(85, 11)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(83, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'cboCOU
        '
        Me.cboCOU.BackColor = System.Drawing.SystemColors.Info
        Me.cboCOU.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboCOU_DesignTimeLayout.LayoutString = resources.GetString("cboCOU_DesignTimeLayout.LayoutString")
        Me.cboCOU.DesignTimeLayout = cboCOU_DesignTimeLayout
        Me.cboCOU.DisplayMember = "Name"
        Me.cboCOU.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboCOU.Location = New System.Drawing.Point(85, 41)
        Me.cboCOU.Name = "cboCOU"
        Me.cboCOU.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboCOU.SelectedIndex = -1
        Me.cboCOU.SelectedItem = Nothing
        Me.cboCOU.SettingsKey = "cboMainCus"
        Me.cboCOU.Size = New System.Drawing.Size(189, 20)
        Me.cboCOU.TabIndex = 1
        Me.cboCOU.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboCOU.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(85, 68)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(191, 20)
        Me.txtName.TabIndex = 2
        Me.txtName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(201, 92)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(109, 92)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'frmArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 121)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cboCOU)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "frmArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Περιοχές"
        CType(Me.cboCOU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCode As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents cboCOU As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents txtName As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents cmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
End Class
