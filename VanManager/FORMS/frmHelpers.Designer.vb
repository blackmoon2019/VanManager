<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelpers
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
        Dim cboDOY_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelpers))
        Dim cboArea_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboCOU_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.txtSalary = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboDOY = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cmdSave = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        Me.cboArea = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cboCOU = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.txtComments = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtMail = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtFax = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtPhone2 = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtPhone1 = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtMob2 = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtMob1 = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtTK = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtAr = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtAdr = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtAFM = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtLastname = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtName = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtCode = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.cboDOY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCOU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSalary
        '
        Me.txtSalary.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtSalary.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.txtSalary.Location = New System.Drawing.Point(265, 178)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(53, 20)
        Me.txtSalary.TabIndex = 16
        Me.txtSalary.Text = "0,00 €"
        Me.txtSalary.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSalary.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'cboDOY
        '
        Me.cboDOY.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cboDOY.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboDOY_DesignTimeLayout.LayoutString = resources.GetString("cboDOY_DesignTimeLayout.LayoutString")
        Me.cboDOY.DesignTimeLayout = cboDOY_DesignTimeLayout
        Me.cboDOY.DisplayMember = "Name"
        Me.cboDOY.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboDOY.Location = New System.Drawing.Point(649, 24)
        Me.cboDOY.Name = "cboDOY"
        Me.cboDOY.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboDOY.SelectedIndex = -1
        Me.cboDOY.SelectedItem = Nothing
        Me.cboDOY.SettingsKey = "cboMainCus"
        Me.cboDOY.Size = New System.Drawing.Size(152, 20)
        Me.cboDOY.TabIndex = 4
        Me.cboDOY.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboDOY.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(686, 363)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 18
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(594, 363)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 19
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cboArea
        '
        Me.cboArea.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cboArea.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboArea_DesignTimeLayout.LayoutString = resources.GetString("cboArea_DesignTimeLayout.LayoutString")
        Me.cboArea.DesignTimeLayout = cboArea_DesignTimeLayout
        Me.cboArea.DisplayMember = "Name"
        Me.cboArea.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboArea.Location = New System.Drawing.Point(161, 70)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboArea.SelectedIndex = -1
        Me.cboArea.SelectedItem = Nothing
        Me.cboArea.SettingsKey = "cboMainCus"
        Me.cboArea.Size = New System.Drawing.Size(152, 20)
        Me.cboArea.TabIndex = 6
        Me.cboArea.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboArea.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'cboCOU
        '
        Me.cboCOU.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cboCOU.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboCOU_DesignTimeLayout.LayoutString = resources.GetString("cboCOU_DesignTimeLayout.LayoutString")
        Me.cboCOU.DesignTimeLayout = cboCOU_DesignTimeLayout
        Me.cboCOU.DisplayMember = "Name"
        Me.cboCOU.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboCOU.Location = New System.Drawing.Point(3, 70)
        Me.cboCOU.Name = "cboCOU"
        Me.cboCOU.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboCOU.SelectedIndex = -1
        Me.cboCOU.SelectedItem = Nothing
        Me.cboCOU.SettingsKey = "cboMainCus"
        Me.cboCOU.Size = New System.Drawing.Size(142, 20)
        Me.cboCOU.TabIndex = 5
        Me.cboCOU.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboCOU.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(3, 234)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(758, 119)
        Me.txtComments.TabIndex = 17
        Me.txtComments.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(3, 178)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(234, 20)
        Me.txtMail.TabIndex = 15
        Me.txtMail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(530, 122)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(101, 20)
        Me.txtFax.TabIndex = 14
        Me.txtFax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtPhone2
        '
        Me.txtPhone2.Location = New System.Drawing.Point(398, 122)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(101, 20)
        Me.txtPhone2.TabIndex = 13
        Me.txtPhone2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtPhone1
        '
        Me.txtPhone1.Location = New System.Drawing.Point(265, 123)
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.Size = New System.Drawing.Size(101, 20)
        Me.txtPhone1.TabIndex = 12
        Me.txtPhone1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtMob2
        '
        Me.txtMob2.Location = New System.Drawing.Point(136, 123)
        Me.txtMob2.Name = "txtMob2"
        Me.txtMob2.Size = New System.Drawing.Size(101, 20)
        Me.txtMob2.TabIndex = 11
        Me.txtMob2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtMob1
        '
        Me.txtMob1.Location = New System.Drawing.Point(3, 122)
        Me.txtMob1.Name = "txtMob1"
        Me.txtMob1.Size = New System.Drawing.Size(101, 20)
        Me.txtMob1.TabIndex = 10
        Me.txtMob1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtTK
        '
        Me.txtTK.Location = New System.Drawing.Point(649, 72)
        Me.txtTK.Name = "txtTK"
        Me.txtTK.Size = New System.Drawing.Size(82, 20)
        Me.txtTK.TabIndex = 9
        Me.txtTK.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtAr
        '
        Me.txtAr.Location = New System.Drawing.Point(549, 71)
        Me.txtAr.Name = "txtAr"
        Me.txtAr.Size = New System.Drawing.Size(82, 20)
        Me.txtAr.TabIndex = 8
        Me.txtAr.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtAdr
        '
        Me.txtAdr.Location = New System.Drawing.Point(351, 71)
        Me.txtAdr.Name = "txtAdr"
        Me.txtAdr.Size = New System.Drawing.Size(168, 20)
        Me.txtAdr.TabIndex = 7
        Me.txtAdr.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtAFM
        '
        Me.txtAFM.Location = New System.Drawing.Point(547, 23)
        Me.txtAFM.Name = "txtAFM"
        Me.txtAFM.Size = New System.Drawing.Size(86, 20)
        Me.txtAFM.TabIndex = 3
        Me.txtAFM.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtLastname
        '
        Me.txtLastname.BackColor = System.Drawing.SystemColors.Info
        Me.txtLastname.Location = New System.Drawing.Point(302, 23)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(217, 20)
        Me.txtLastname.TabIndex = 2
        Me.txtLastname.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Info
        Me.txtName.Location = New System.Drawing.Point(136, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(3, 24)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(82, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(0, 218)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 211
        Me.Label18.Text = "Σχόλια"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(646, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 13)
        Me.Label17.TabIndex = 210
        Me.Label17.Text = "ΔΟΥ"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(544, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 13)
        Me.Label16.TabIndex = 209
        Me.Label16.Text = "Αφμ"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(0, 162)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 208
        Me.Label13.Text = "Email"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(527, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 13)
        Me.Label14.TabIndex = 207
        Me.Label14.Text = "Fax"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(395, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 206
        Me.Label11.Text = "Τηλέφωνο 2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(262, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 205
        Me.Label12.Text = "Τηλέφωνο 1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(133, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 204
        Me.Label10.Text = "Κινητό 2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 203
        Me.Label9.Text = "Κινητό 1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(546, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 202
        Me.Label8.Text = "Αριθμός"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(646, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 201
        Me.Label4.Text = "Τ.Κ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 200
        Me.Label6.Text = "Περιοχή"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(348, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 199
        Me.Label5.Text = "Διεύθυνση"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 198
        Me.Label7.Text = "Νομός"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 197
        Me.Label2.Text = "Επώνυμο"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "Όνομα"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(0, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 195
        Me.Label20.Text = "Κωδικός"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(262, 162)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 13)
        Me.Label19.TabIndex = 194
        Me.Label19.Text = "Μισθός"
        '
        'frmHelpers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(813, 392)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.cboDOY)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.cboCOU)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtPhone2)
        Me.Controls.Add(Me.txtPhone1)
        Me.Controls.Add(Me.txtMob2)
        Me.Controls.Add(Me.txtMob1)
        Me.Controls.Add(Me.txtTK)
        Me.Controls.Add(Me.txtAr)
        Me.Controls.Add(Me.txtAdr)
        Me.Controls.Add(Me.txtAFM)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Name = "frmHelpers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Βοηθοί"
        CType(Me.cboDOY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCOU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSalary As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboDOY As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboArea As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cboCOU As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents txtComments As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtMail As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtFax As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtPhone2 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtPhone1 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtMob2 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtMob1 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtTK As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtAr As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtAdr As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtAFM As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtLastname As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtName As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtCode As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
End Class
