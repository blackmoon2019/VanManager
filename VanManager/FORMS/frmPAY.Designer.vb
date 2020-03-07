<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPAY
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
        Me.cmdSave = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        Me.txtName = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtCode = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(209, 64)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(117, 64)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 9
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(107, 38)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(177, 20)
        Me.txtName.TabIndex = 7
        Me.txtName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(107, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(78, 20)
        Me.txtCode.TabIndex = 6
        Me.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Κωδικός"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Τρόπος Πληρωμής"
        '
        'frmPAY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 104)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmPAY"
        Me.Text = "frmPAY"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtName As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtCode As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
