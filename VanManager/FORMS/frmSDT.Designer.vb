<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDT
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
        Me.txtCode = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSave = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        Me.txtName = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescr = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescrAk = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(87, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(83, 20)
        Me.txtCode.TabIndex = 58
        Me.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Κωδικός"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(272, 135)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 61
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(180, 135)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 62
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(260, 13)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(85, 20)
        Me.txtName.TabIndex = 60
        Me.txtName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "ΣΥΝΤ/ΦΙΑ"
        '
        'txtDescr
        '
        Me.txtDescr.BackColor = System.Drawing.SystemColors.Info
        Me.txtDescr.Location = New System.Drawing.Point(87, 51)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(260, 20)
        Me.txtDescr.TabIndex = 64
        Me.txtDescr.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Περιγραφή"
        '
        'txtDescrAk
        '
        Me.txtDescrAk.BackColor = System.Drawing.SystemColors.Info
        Me.txtDescrAk.Location = New System.Drawing.Point(87, 93)
        Me.txtDescrAk.Name = "txtDescrAk"
        Me.txtDescrAk.Size = New System.Drawing.Size(260, 20)
        Me.txtDescrAk.TabIndex = 66
        Me.txtDescrAk.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Περιγραφή Ακ."
        '
        'frmSDT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 173)
        Me.Controls.Add(Me.txtDescrAk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.Name = "frmSDT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSDT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCode As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtName As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescr As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescrAk As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label4 As Label
End Class
