<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEX
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
        Dim cboEXCat_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEX))
        Dim cboVEH_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboJDRV_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboSUP_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.cboEXCat = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrice = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtDateCreated = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtCode = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkPaid = New Janus.Windows.EditControls.UICheckBox()
        Me.cmdSave = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdAttach = New Janus.Windows.EditControls.UIButton()
        Me.txtdeltPath = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.dlgDeltia = New System.Windows.Forms.OpenFileDialog()
        Me.cmdDet = New Janus.Windows.EditControls.UIButton()
        Me.cboVEH = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboJDRV = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmdView = New Janus.Windows.EditControls.UIButton()
        Me.chkBlack = New Janus.Windows.EditControls.UICheckBox()
        Me.txtPrice2 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescr = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtInvoiceNum = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtFPA = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkMonkey = New Janus.Windows.EditControls.UICheckBox()
        Me.cboSUP = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkReceipt = New Janus.Windows.EditControls.UICheckBox()
        CType(Me.cboEXCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVEH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboJDRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSUP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboEXCat
        '
        Me.cboEXCat.BackColor = System.Drawing.SystemColors.Info
        Me.cboEXCat.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboEXCat_DesignTimeLayout.LayoutString = resources.GetString("cboEXCat_DesignTimeLayout.LayoutString")
        Me.cboEXCat.DesignTimeLayout = cboEXCat_DesignTimeLayout
        Me.cboEXCat.DisplayMember = "Name"
        Me.cboEXCat.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboEXCat.Location = New System.Drawing.Point(267, 24)
        Me.cboEXCat.Name = "cboEXCat"
        Me.cboEXCat.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboEXCat.SelectedIndex = -1
        Me.cboEXCat.SelectedItem = Nothing
        Me.cboEXCat.SettingsKey = "cboEXCat"
        Me.cboEXCat.Size = New System.Drawing.Size(192, 20)
        Me.cboEXCat.TabIndex = 2
        Me.cboEXCat.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboEXCat.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Τύπος Εξόδου"
        '
        'txtPrice
        '
        Me.txtPrice.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtPrice.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.txtPrice.Location = New System.Drawing.Point(15, 209)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(74, 20)
        Me.txtPrice.TabIndex = 7
        Me.txtPrice.Text = "0,00 €"
        Me.txtPrice.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 192)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 13)
        Me.Label19.TabIndex = 194
        Me.Label19.Text = "Ποσό"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "Ημερ/νία"
        '
        'dtDateCreated
        '
        Me.dtDateCreated.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.dtDateCreated.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtDateCreated.Location = New System.Drawing.Point(91, 24)
        Me.dtDateCreated.Name = "dtDateCreated"
        Me.dtDateCreated.Size = New System.Drawing.Size(168, 20)
        Me.dtDateCreated.TabIndex = 1
        Me.dtDateCreated.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtDateCreated.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(14, 24)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(61, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 199
        Me.Label3.Text = "Κωδικός"
        '
        'chkPaid
        '
        Me.chkPaid.BackColor = System.Drawing.Color.Transparent
        Me.chkPaid.CheckedValue = True
        Me.chkPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.chkPaid.Location = New System.Drawing.Point(268, 207)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Size = New System.Drawing.Size(94, 23)
        Me.chkPaid.TabIndex = 10
        Me.chkPaid.Text = "Πληρώθηκε"
        Me.chkPaid.UncheckedValue = False
        Me.chkPaid.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(468, 300)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 16
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(376, 300)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 15
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 202
        Me.Label8.Text = "Αρχείο"
        '
        'cmdAttach
        '
        Me.cmdAttach.Appearance = Janus.Windows.UI.Appearance.Normal
        Me.cmdAttach.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.cmdAttach.Image = CType(resources.GetObject("cmdAttach.Image"), System.Drawing.Image)
        Me.cmdAttach.Location = New System.Drawing.Point(452, 257)
        Me.cmdAttach.Name = "cmdAttach"
        Me.cmdAttach.Size = New System.Drawing.Size(27, 23)
        Me.cmdAttach.TabIndex = 13
        Me.cmdAttach.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'txtdeltPath
        '
        Me.txtdeltPath.Location = New System.Drawing.Point(14, 258)
        Me.txtdeltPath.Name = "txtdeltPath"
        Me.txtdeltPath.ReadOnly = True
        Me.txtdeltPath.Size = New System.Drawing.Size(427, 20)
        Me.txtdeltPath.TabIndex = 12
        Me.txtdeltPath.TabStop = False
        Me.txtdeltPath.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'dlgDeltia
        '
        Me.dlgDeltia.FileName = "OpenFileDialog1"
        '
        'cmdDet
        '
        Me.cmdDet.Appearance = Janus.Windows.UI.Appearance.Normal
        Me.cmdDet.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.cmdDet.Image = CType(resources.GetObject("cmdDet.Image"), System.Drawing.Image)
        Me.cmdDet.Location = New System.Drawing.Point(513, 257)
        Me.cmdDet.Name = "cmdDet"
        Me.cmdDet.Size = New System.Drawing.Size(27, 23)
        Me.cmdDet.TabIndex = 15
        Me.cmdDet.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cboVEH
        '
        Me.cboVEH.BackColor = System.Drawing.SystemColors.Info
        Me.cboVEH.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboVEH_DesignTimeLayout.LayoutString = resources.GetString("cboVEH_DesignTimeLayout.LayoutString")
        Me.cboVEH.DesignTimeLayout = cboVEH_DesignTimeLayout
        Me.cboVEH.DisplayMember = "Name"
        Me.cboVEH.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboVEH.Location = New System.Drawing.Point(14, 69)
        Me.cboVEH.Name = "cboVEH"
        Me.cboVEH.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboVEH.SelectedIndex = -1
        Me.cboVEH.SelectedItem = Nothing
        Me.cboVEH.SettingsKey = "cboEXCat"
        Me.cboVEH.Size = New System.Drawing.Size(127, 20)
        Me.cboVEH.TabIndex = 3
        Me.cboVEH.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboVEH.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "Όχημα"
        '
        'cboJDRV
        '
        Me.cboJDRV.BackColor = System.Drawing.SystemColors.Info
        Me.cboJDRV.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboJDRV_DesignTimeLayout.LayoutString = resources.GetString("cboJDRV_DesignTimeLayout.LayoutString")
        Me.cboJDRV.DesignTimeLayout = cboJDRV_DesignTimeLayout
        Me.cboJDRV.DisplayMember = "Name"
        Me.cboJDRV.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboJDRV.Location = New System.Drawing.Point(148, 69)
        Me.cboJDRV.Name = "cboJDRV"
        Me.cboJDRV.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboJDRV.SelectedIndex = -1
        Me.cboJDRV.SelectedItem = Nothing
        Me.cboJDRV.SettingsKey = "cboMainCus"
        Me.cboJDRV.Size = New System.Drawing.Size(212, 20)
        Me.cboJDRV.TabIndex = 4
        Me.cboJDRV.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboJDRV.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(145, 53)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(44, 13)
        Me.Label26.TabIndex = 207
        Me.Label26.Text = "Οδηγός"
        '
        'cmdView
        '
        Me.cmdView.Appearance = Janus.Windows.UI.Appearance.Normal
        Me.cmdView.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.cmdView.Image = CType(resources.GetObject("cmdView.Image"), System.Drawing.Image)
        Me.cmdView.Location = New System.Drawing.Point(482, 257)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(27, 23)
        Me.cmdView.TabIndex = 14
        Me.cmdView.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'chkBlack
        '
        Me.chkBlack.BackColor = System.Drawing.Color.Transparent
        Me.chkBlack.CheckedValue = True
        Me.chkBlack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.chkBlack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBlack.Location = New System.Drawing.Point(368, 206)
        Me.chkBlack.Name = "chkBlack"
        Me.chkBlack.Size = New System.Drawing.Size(66, 23)
        Me.chkBlack.TabIndex = 11
        Me.chkBlack.Text = "Τύπος"
        Me.chkBlack.UncheckedValue = False
        Me.chkBlack.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txtPrice2
        '
        Me.txtPrice2.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtPrice2.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.txtPrice2.Location = New System.Drawing.Point(182, 209)
        Me.txtPrice2.Name = "txtPrice2"
        Me.txtPrice2.Size = New System.Drawing.Size(74, 20)
        Me.txtPrice2.TabIndex = 8
        Me.txtPrice2.Text = "0,00 €"
        Me.txtPrice2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrice2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(179, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 211
        Me.Label5.Text = "Ποσό2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 213
        Me.Label6.Text = "Περιγραφή"
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(14, 119)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(526, 20)
        Me.txtDescr.TabIndex = 6
        Me.txtDescr.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(362, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 215
        Me.Label7.Text = "Αρ. Τιμολογίου"
        '
        'txtInvoiceNum
        '
        Me.txtInvoiceNum.Location = New System.Drawing.Point(365, 69)
        Me.txtInvoiceNum.Name = "txtInvoiceNum"
        Me.txtInvoiceNum.Size = New System.Drawing.Size(90, 20)
        Me.txtInvoiceNum.TabIndex = 5
        Me.txtInvoiceNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtFPA
        '
        Me.txtFPA.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtFPA.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.txtFPA.Location = New System.Drawing.Point(97, 209)
        Me.txtFPA.Name = "txtFPA"
        Me.txtFPA.Size = New System.Drawing.Size(74, 20)
        Me.txtFPA.TabIndex = 9
        Me.txtFPA.Text = "0,00 €"
        Me.txtFPA.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFPA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(94, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 217
        Me.Label9.Text = "ΦΠΑ "
        '
        'chkMonkey
        '
        Me.chkMonkey.BackColor = System.Drawing.Color.Transparent
        Me.chkMonkey.CheckedValue = True
        Me.chkMonkey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.chkMonkey.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMonkey.Location = New System.Drawing.Point(442, 207)
        Me.chkMonkey.Name = "chkMonkey"
        Me.chkMonkey.Size = New System.Drawing.Size(98, 23)
        Me.chkMonkey.TabIndex = 218
        Me.chkMonkey.Text = "Από Αγορές"
        Me.chkMonkey.UncheckedValue = False
        Me.chkMonkey.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'cboSUP
        '
        Me.cboSUP.BackColor = System.Drawing.SystemColors.Info
        Me.cboSUP.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboSUP_DesignTimeLayout.LayoutString = resources.GetString("cboSUP_DesignTimeLayout.LayoutString")
        Me.cboSUP.DesignTimeLayout = cboSUP_DesignTimeLayout
        Me.cboSUP.DisplayMember = "Name"
        Me.cboSUP.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboSUP.Location = New System.Drawing.Point(14, 159)
        Me.cboSUP.Name = "cboSUP"
        Me.cboSUP.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboSUP.SelectedIndex = -1
        Me.cboSUP.SelectedItem = Nothing
        Me.cboSUP.SettingsKey = "cboMainCus"
        Me.cboSUP.Size = New System.Drawing.Size(242, 20)
        Me.cboSUP.TabIndex = 219
        Me.cboSUP.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboSUP.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 220
        Me.Label10.Text = "Προμηθευτής"
        '
        'chkReceipt
        '
        Me.chkReceipt.BackColor = System.Drawing.Color.Transparent
        Me.chkReceipt.CheckedValue = True
        Me.chkReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.chkReceipt.Location = New System.Drawing.Point(268, 157)
        Me.chkReceipt.Name = "chkReceipt"
        Me.chkReceipt.Size = New System.Drawing.Size(94, 23)
        Me.chkReceipt.TabIndex = 221
        Me.chkReceipt.Text = "Απόδειξη"
        Me.chkReceipt.UncheckedValue = False
        Me.chkReceipt.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'frmEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(552, 340)
        Me.Controls.Add(Me.chkReceipt)
        Me.Controls.Add(Me.cboSUP)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chkMonkey)
        Me.Controls.Add(Me.txtFPA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtInvoiceNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDescr)
        Me.Controls.Add(Me.txtPrice2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkBlack)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.cboJDRV)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.cboVEH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdDet)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdAttach)
        Me.Controls.Add(Me.txtdeltPath)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.chkPaid)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtDateCreated)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cboEXCat)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Έξοδα"
        CType(Me.cboEXCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVEH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboJDRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSUP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboEXCat As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrice As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtDateCreated As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtCode As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkPaid As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents cmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdAttach As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtdeltPath As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents dlgDeltia As OpenFileDialog
    Friend WithEvents cmdDet As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboVEH As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Label4 As Label
    Friend WithEvents cboJDRV As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Label26 As Label
    Friend WithEvents cmdView As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkBlack As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtPrice2 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescr As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtInvoiceNum As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtFPA As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label9 As Label
    Friend WithEvents chkMonkey As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents cboSUP As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Label10 As Label
    Friend WithEvents chkReceipt As Janus.Windows.EditControls.UICheckBox
End Class
