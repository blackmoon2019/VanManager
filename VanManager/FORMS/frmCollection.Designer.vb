<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollection
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
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtInvoicesANEX = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDescr = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.UiGroupBox6 = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMCusADR = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtMCusPRF = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtMCusA = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtMCusL = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtBankName = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHolloPrice = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtInvoicesEX = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNumber = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtColdate = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtCode = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpCash = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCashPrice = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtCashDate = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.grpDeposit = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtdepositDate = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDepositPrice = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtdepositNum = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grpCheque = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtchequeDate = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtChequePrice = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtchequeNum = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdSave = New Janus.Windows.EditControls.UIButton()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPoso = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtYpol = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox6.SuspendLayout()
        CType(Me.grpCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCash.SuspendLayout()
        CType(Me.grpDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDeposit.SuspendLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCheque.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.txtInvoicesANEX)
        Me.UiGroupBox1.Controls.Add(Me.Label16)
        Me.UiGroupBox1.Controls.Add(Me.Label21)
        Me.UiGroupBox1.Controls.Add(Me.txtDescr)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox6)
        Me.UiGroupBox1.Controls.Add(Me.txtBankName)
        Me.UiGroupBox1.Controls.Add(Me.Label17)
        Me.UiGroupBox1.Controls.Add(Me.Label4)
        Me.UiGroupBox1.Controls.Add(Me.txtHolloPrice)
        Me.UiGroupBox1.Controls.Add(Me.txtInvoicesEX)
        Me.UiGroupBox1.Controls.Add(Me.Label11)
        Me.UiGroupBox1.Controls.Add(Me.txtNumber)
        Me.UiGroupBox1.Controls.Add(Me.Label6)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.dtColdate)
        Me.UiGroupBox1.Controls.Add(Me.txtCode)
        Me.UiGroupBox1.Controls.Add(Me.Label3)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 1)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(568, 240)
        Me.UiGroupBox1.TabIndex = 168
        Me.UiGroupBox1.Text = "Στοιχεία Είσπραξης"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtInvoicesANEX
        '
        Me.txtInvoicesANEX.Location = New System.Drawing.Point(162, 137)
        Me.txtInvoicesANEX.Name = "txtInvoicesANEX"
        Me.txtInvoicesANEX.ReadOnly = True
        Me.txtInvoicesANEX.Size = New System.Drawing.Size(131, 20)
        Me.txtInvoicesANEX.TabIndex = 202
        Me.txtInvoicesANEX.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(162, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 13)
        Me.Label16.TabIndex = 201
        Me.Label16.Text = "Tιμολόγια Έναντι"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 199)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 13)
        Me.Label21.TabIndex = 200
        Me.Label21.Text = "Αιτιολογία"
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(6, 215)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(551, 20)
        Me.txtDescr.TabIndex = 199
        Me.txtDescr.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'UiGroupBox6
        '
        Me.UiGroupBox6.BackColor = System.Drawing.SystemColors.Control
        Me.UiGroupBox6.Controls.Add(Me.Label15)
        Me.UiGroupBox6.Controls.Add(Me.txtMCusADR)
        Me.UiGroupBox6.Controls.Add(Me.txtMCusPRF)
        Me.UiGroupBox6.Controls.Add(Me.Label14)
        Me.UiGroupBox6.Controls.Add(Me.Label28)
        Me.UiGroupBox6.Controls.Add(Me.txtMCusA)
        Me.UiGroupBox6.Controls.Add(Me.Label30)
        Me.UiGroupBox6.Controls.Add(Me.txtMCusL)
        Me.UiGroupBox6.Location = New System.Drawing.Point(300, 8)
        Me.UiGroupBox6.Name = "UiGroupBox6"
        Me.UiGroupBox6.Size = New System.Drawing.Size(257, 164)
        Me.UiGroupBox6.TabIndex = 170
        Me.UiGroupBox6.Text = "Πελάτης"
        Me.UiGroupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(2, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 158
        Me.Label15.Text = "Διεύθυνση"
        '
        'txtMCusADR
        '
        Me.txtMCusADR.Location = New System.Drawing.Point(8, 93)
        Me.txtMCusADR.Name = "txtMCusADR"
        Me.txtMCusADR.ReadOnly = True
        Me.txtMCusADR.Size = New System.Drawing.Size(245, 20)
        Me.txtMCusADR.TabIndex = 157
        Me.txtMCusADR.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtMCusPRF
        '
        Me.txtMCusPRF.Location = New System.Drawing.Point(8, 137)
        Me.txtMCusPRF.Name = "txtMCusPRF"
        Me.txtMCusPRF.ReadOnly = True
        Me.txtMCusPRF.Size = New System.Drawing.Size(245, 20)
        Me.txtMCusPRF.TabIndex = 156
        Me.txtMCusPRF.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 155
        Me.Label14.Text = "Επάγγελμα"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(175, 27)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(32, 13)
        Me.Label28.TabIndex = 154
        Me.Label28.Text = "ΑΦΜ"
        '
        'txtMCusA
        '
        Me.txtMCusA.Location = New System.Drawing.Point(176, 43)
        Me.txtMCusA.Name = "txtMCusA"
        Me.txtMCusA.ReadOnly = True
        Me.txtMCusA.Size = New System.Drawing.Size(77, 20)
        Me.txtMCusA.TabIndex = 153
        Me.txtMCusA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(5, 27)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(51, 13)
        Me.Label30.TabIndex = 143
        Me.Label30.Text = "Επώνυμο"
        '
        'txtMCusL
        '
        Me.txtMCusL.Location = New System.Drawing.Point(8, 43)
        Me.txtMCusL.Name = "txtMCusL"
        Me.txtMCusL.ReadOnly = True
        Me.txtMCusL.Size = New System.Drawing.Size(164, 20)
        Me.txtMCusL.TabIndex = 2
        Me.txtMCusL.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtBankName
        '
        Me.txtBankName.Location = New System.Drawing.Point(156, 43)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.ReadOnly = True
        Me.txtBankName.Size = New System.Drawing.Size(137, 20)
        Me.txtBankName.TabIndex = 158
        Me.txtBankName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(153, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 157
        Me.Label17.Text = "Τράπεζα"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "Αξία Ολογράφως"
        '
        'txtHolloPrice
        '
        Me.txtHolloPrice.BackColor = System.Drawing.SystemColors.Info
        Me.txtHolloPrice.Location = New System.Drawing.Point(6, 177)
        Me.txtHolloPrice.Name = "txtHolloPrice"
        Me.txtHolloPrice.ReadOnly = True
        Me.txtHolloPrice.Size = New System.Drawing.Size(551, 20)
        Me.txtHolloPrice.TabIndex = 155
        Me.txtHolloPrice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtInvoicesEX
        '
        Me.txtInvoicesEX.Location = New System.Drawing.Point(6, 137)
        Me.txtInvoicesEX.Name = "txtInvoicesEX"
        Me.txtInvoicesEX.ReadOnly = True
        Me.txtInvoicesEX.Size = New System.Drawing.Size(150, 20)
        Me.txtInvoicesEX.TabIndex = 154
        Me.txtInvoicesEX.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 13)
        Me.Label11.TabIndex = 153
        Me.Label11.Text = "Tιμολόγια Εξοφλημένα"
        '
        'txtNumber
        '
        Me.txtNumber.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.txtNumber.Location = New System.Drawing.Point(87, 41)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.ReadOnly = True
        Me.txtNumber.Size = New System.Drawing.Size(49, 20)
        Me.txtNumber.TabIndex = 1
        Me.txtNumber.Text = "0"
        Me.txtNumber.Value = 0
        Me.txtNumber.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
        Me.txtNumber.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Αριθμός"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "Ημερ/νία"
        '
        'dtColdate
        '
        Me.dtColdate.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.dtColdate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtColdate.Location = New System.Drawing.Point(6, 93)
        Me.dtColdate.Name = "dtColdate"
        Me.dtColdate.Size = New System.Drawing.Size(150, 20)
        Me.dtColdate.TabIndex = 5
        Me.dtColdate.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtColdate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(6, 41)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(61, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.TabStop = False
        Me.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Σειρά"
        '
        'grpCash
        '
        Me.grpCash.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpCash.Controls.Add(Me.txtCashPrice)
        Me.grpCash.Controls.Add(Me.Label7)
        Me.grpCash.Controls.Add(Me.Label2)
        Me.grpCash.Controls.Add(Me.dtCashDate)
        Me.grpCash.DisabledFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grpCash.Location = New System.Drawing.Point(3, 247)
        Me.grpCash.Name = "grpCash"
        Me.grpCash.Size = New System.Drawing.Size(101, 161)
        Me.grpCash.TabIndex = 188
        Me.grpCash.Text = "Μετρητά"
        Me.grpCash.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtCashPrice
        '
        Me.txtCashPrice.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCashPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtCashPrice.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtCashPrice.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.txtCashPrice.Location = New System.Drawing.Point(5, 122)
        Me.txtCashPrice.Name = "txtCashPrice"
        Me.txtCashPrice.ReadOnly = True
        Me.txtCashPrice.Size = New System.Drawing.Size(89, 20)
        Me.txtCashPrice.TabIndex = 5
        Me.txtCashPrice.Text = "0,00 €"
        Me.txtCashPrice.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCashPrice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(2, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "Αξία "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(2, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 187
        Me.Label2.Text = "Ημερ/νία"
        '
        'dtCashDate
        '
        '
        '
        '
        Me.dtCashDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtCashDate.Location = New System.Drawing.Point(5, 82)
        Me.dtCashDate.Name = "dtCashDate"
        Me.dtCashDate.ReadOnly = True
        Me.dtCashDate.Size = New System.Drawing.Size(89, 20)
        Me.dtCashDate.TabIndex = 4
        Me.dtCashDate.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtCashDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'grpDeposit
        '
        Me.grpDeposit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpDeposit.Controls.Add(Me.Label5)
        Me.grpDeposit.Controls.Add(Me.dtdepositDate)
        Me.grpDeposit.Controls.Add(Me.Label12)
        Me.grpDeposit.Controls.Add(Me.txtDepositPrice)
        Me.grpDeposit.Controls.Add(Me.txtdepositNum)
        Me.grpDeposit.Controls.Add(Me.Label13)
        Me.grpDeposit.DisabledFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grpDeposit.Location = New System.Drawing.Point(336, 247)
        Me.grpDeposit.Name = "grpDeposit"
        Me.grpDeposit.Size = New System.Drawing.Size(103, 161)
        Me.grpDeposit.TabIndex = 187
        Me.grpDeposit.Text = "Κατάθεση"
        Me.grpDeposit.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(5, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "Ημερ/νία"
        '
        'dtdepositDate
        '
        '
        '
        '
        Me.dtdepositDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtdepositDate.Location = New System.Drawing.Point(8, 82)
        Me.dtdepositDate.Name = "dtdepositDate"
        Me.dtdepositDate.ReadOnly = True
        Me.dtdepositDate.Size = New System.Drawing.Size(89, 20)
        Me.dtdepositDate.TabIndex = 10
        Me.dtdepositDate.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtdepositDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(7, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 175
        Me.Label12.Text = "Αξία"
        '
        'txtDepositPrice
        '
        Me.txtDepositPrice.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDepositPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtDepositPrice.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtDepositPrice.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.txtDepositPrice.Location = New System.Drawing.Point(8, 122)
        Me.txtDepositPrice.Name = "txtDepositPrice"
        Me.txtDepositPrice.ReadOnly = True
        Me.txtDepositPrice.Size = New System.Drawing.Size(89, 20)
        Me.txtDepositPrice.TabIndex = 11
        Me.txtDepositPrice.Text = "0,00 €"
        Me.txtDepositPrice.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDepositPrice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtdepositNum
        '
        Me.txtdepositNum.Location = New System.Drawing.Point(6, 37)
        Me.txtdepositNum.Name = "txtdepositNum"
        Me.txtdepositNum.ReadOnly = True
        Me.txtdepositNum.Size = New System.Drawing.Size(91, 20)
        Me.txtdepositNum.TabIndex = 9
        Me.txtdepositNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(5, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 173
        Me.Label13.Text = "Αρ. Καταθετηρίου"
        '
        'grpCheque
        '
        Me.grpCheque.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpCheque.Controls.Add(Me.Label10)
        Me.grpCheque.Controls.Add(Me.dtchequeDate)
        Me.grpCheque.Controls.Add(Me.Label9)
        Me.grpCheque.Controls.Add(Me.txtChequePrice)
        Me.grpCheque.Controls.Add(Me.txtchequeNum)
        Me.grpCheque.Controls.Add(Me.Label8)
        Me.grpCheque.DisabledFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grpCheque.Location = New System.Drawing.Point(167, 247)
        Me.grpCheque.Name = "grpCheque"
        Me.grpCheque.Size = New System.Drawing.Size(105, 161)
        Me.grpCheque.TabIndex = 186
        Me.grpCheque.Text = "Επιταγή"
        Me.grpCheque.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(5, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 177
        Me.Label10.Text = "Ημερ/νία"
        '
        'dtchequeDate
        '
        '
        '
        '
        Me.dtchequeDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtchequeDate.Location = New System.Drawing.Point(8, 82)
        Me.dtchequeDate.Name = "dtchequeDate"
        Me.dtchequeDate.ReadOnly = True
        Me.dtchequeDate.Size = New System.Drawing.Size(89, 20)
        Me.dtchequeDate.TabIndex = 7
        Me.dtchequeDate.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtchequeDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(6, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 175
        Me.Label9.Text = "Αξία"
        '
        'txtChequePrice
        '
        Me.txtChequePrice.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtChequePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtChequePrice.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtChequePrice.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.txtChequePrice.Location = New System.Drawing.Point(8, 122)
        Me.txtChequePrice.Name = "txtChequePrice"
        Me.txtChequePrice.ReadOnly = True
        Me.txtChequePrice.Size = New System.Drawing.Size(89, 20)
        Me.txtChequePrice.TabIndex = 8
        Me.txtChequePrice.Text = "0,00 €"
        Me.txtChequePrice.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtChequePrice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtchequeNum
        '
        Me.txtchequeNum.Location = New System.Drawing.Point(6, 37)
        Me.txtchequeNum.Name = "txtchequeNum"
        Me.txtchequeNum.ReadOnly = True
        Me.txtchequeNum.Size = New System.Drawing.Size(91, 20)
        Me.txtchequeNum.TabIndex = 6
        Me.txtchequeNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(5, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 173
        Me.Label8.Text = "Αρ. Επιταγής"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(494, 415)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 189
        Me.cmdSave.Text = "Έκδοση"
        Me.cmdSave.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(402, 415)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 190
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(467, 249)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 192
        Me.Label18.Text = "Σύνολο Τιμολ."
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtTotal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtTotal.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.txtTotal.Location = New System.Drawing.Point(468, 265)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(89, 20)
        Me.txtTotal.TabIndex = 191
        Me.txtTotal.Text = "0,00 €"
        Me.txtTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(468, 313)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 194
        Me.Label19.Text = "Ποσό Είσπρ."
        '
        'txtPoso
        '
        Me.txtPoso.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPoso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtPoso.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtPoso.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.txtPoso.Location = New System.Drawing.Point(469, 329)
        Me.txtPoso.Name = "txtPoso"
        Me.txtPoso.ReadOnly = True
        Me.txtPoso.Size = New System.Drawing.Size(89, 20)
        Me.txtPoso.TabIndex = 193
        Me.txtPoso.Text = "0,00 €"
        Me.txtPoso.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPoso.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(468, 372)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 13)
        Me.Label20.TabIndex = 196
        Me.Label20.Text = "Υπόλοιπο"
        '
        'txtYpol
        '
        Me.txtYpol.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtYpol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtYpol.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtYpol.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.txtYpol.Location = New System.Drawing.Point(469, 388)
        Me.txtYpol.Name = "txtYpol"
        Me.txtYpol.ReadOnly = True
        Me.txtYpol.Size = New System.Drawing.Size(89, 20)
        Me.txtYpol.TabIndex = 195
        Me.txtYpol.Text = "0,00 €"
        Me.txtYpol.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtYpol.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'frmCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 446)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtYpol)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtPoso)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.grpCash)
        Me.Controls.Add(Me.grpDeposit)
        Me.Controls.Add(Me.grpCheque)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Name = "frmCollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCollection"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox6.ResumeLayout(False)
        Me.UiGroupBox6.PerformLayout()
        CType(Me.grpCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCash.ResumeLayout(False)
        Me.grpCash.PerformLayout()
        CType(Me.grpDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDeposit.ResumeLayout(False)
        Me.grpDeposit.PerformLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCheque.ResumeLayout(False)
        Me.grpCheque.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNumber As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtColdate As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtCode As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInvoicesEX As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHolloPrice As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grpCash As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCashPrice As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtCashDate As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grpDeposit As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtdepositDate As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDepositPrice As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtdepositNum As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label13 As Label
    Friend WithEvents grpCheque As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtchequeDate As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label9 As Label
    Friend WithEvents txtChequePrice As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtchequeNum As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtBankName As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPoso As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtYpol As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtDescr As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents UiGroupBox6 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtMCusADR As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtMCusPRF As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtMCusA As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtMCusL As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtInvoicesANEX As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label16 As Label
End Class
