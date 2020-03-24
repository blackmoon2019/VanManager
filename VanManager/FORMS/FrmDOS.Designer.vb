<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDOS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpSYMV = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkCollection = New Janus.Windows.EditControls.UICheckBox()
        Me.chkHand = New Janus.Windows.EditControls.UICheckBox()
        Me.chkCancel = New Janus.Windows.EditControls.UICheckBox()
        Me.cmdSave = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        CType(Me.grpSYMV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSYMV.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.SystemColors.Info
        Me.txtCode.Location = New System.Drawing.Point(12, 29)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(61, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Κωδικός"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(94, 29)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(61, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Σειρά"
        '
        'grpSYMV
        '
        Me.grpSYMV.Controls.Add(Me.chkCollection)
        Me.grpSYMV.Controls.Add(Me.chkHand)
        Me.grpSYMV.Controls.Add(Me.chkCancel)
        Me.grpSYMV.Location = New System.Drawing.Point(15, 74)
        Me.grpSYMV.Name = "grpSYMV"
        Me.grpSYMV.Size = New System.Drawing.Size(151, 157)
        Me.grpSYMV.TabIndex = 199
        Me.grpSYMV.Text = "Συμπεριφορά"
        Me.grpSYMV.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'chkCollection
        '
        Me.chkCollection.CheckedValue = False
        Me.chkCollection.Location = New System.Drawing.Point(6, 106)
        Me.chkCollection.Name = "chkCollection"
        Me.chkCollection.Size = New System.Drawing.Size(139, 23)
        Me.chkCollection.TabIndex = 4
        Me.chkCollection.Text = "Αφορά Είσπραξη"
        Me.chkCollection.UncheckedValue = False
        Me.chkCollection.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'chkHand
        '
        Me.chkHand.CheckedValue = False
        Me.chkHand.Location = New System.Drawing.Point(6, 61)
        Me.chkHand.Name = "chkHand"
        Me.chkHand.Size = New System.Drawing.Size(139, 23)
        Me.chkHand.TabIndex = 3
        Me.chkHand.Text = "Χειρόγραφη"
        Me.chkHand.UncheckedValue = False
        Me.chkHand.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'chkCancel
        '
        Me.chkCancel.CheckedValue = False
        Me.chkCancel.Location = New System.Drawing.Point(6, 19)
        Me.chkCancel.Name = "chkCancel"
        Me.chkCancel.Size = New System.Drawing.Size(139, 23)
        Me.chkCancel.TabIndex = 2
        Me.chkCancel.Text = "Ακυρωτική"
        Me.chkCancel.UncheckedValue = False
        Me.chkCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(104, 252)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(12, 252)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'FrmDOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(191, 292)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.grpSYMV)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSeires"
        CType(Me.grpSYMV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSYMV.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCode As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grpSYMV As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents chkCollection As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkHand As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkCancel As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents cmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
End Class
