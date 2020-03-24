<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUSERS
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
        Me.txtUN = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastname = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSave = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        Me.txtName = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPWD = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUN
        '
        Me.txtUN.BackColor = System.Drawing.SystemColors.Info
        Me.txtUN.Location = New System.Drawing.Point(83, 93)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.Size = New System.Drawing.Size(134, 20)
        Me.txtUN.TabIndex = 3
        Me.txtUN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Username"
        '
        'txtLastname
        '
        Me.txtLastname.BackColor = System.Drawing.SystemColors.Info
        Me.txtLastname.Location = New System.Drawing.Point(288, 51)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(134, 20)
        Me.txtLastname.TabIndex = 2
        Me.txtLastname.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Επώνυμο"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(347, 135)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(255, 135)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(83, 51)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(134, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Όνομα"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(85, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(83, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Κωδικός"
        '
        'txtPWD
        '
        Me.txtPWD.BackColor = System.Drawing.SystemColors.Info
        Me.txtPWD.Location = New System.Drawing.Point(288, 93)
        Me.txtPWD.Name = "txtPWD"
        Me.txtPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPWD.Size = New System.Drawing.Size(134, 20)
        Me.txtPWD.TabIndex = 4
        Me.txtPWD.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Password"
        '
        'frmUSERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 169)
        Me.Controls.Add(Me.txtPWD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmUSERS"
        Me.Text = "frmUSERS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUN As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLastname As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtName As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCode As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPWD As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label5 As Label
End Class
