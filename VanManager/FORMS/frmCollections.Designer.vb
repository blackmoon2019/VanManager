<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCollections
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
        Dim cboBank_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollections))
        Dim GridINV_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim colGRID_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.grpCollections = New Janus.Windows.EditControls.UIGroupBox()
        Me.grpCash = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCashPrice = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtCashDate = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.chkCheque = New Janus.Windows.EditControls.UICheckBox()
        Me.chkDeposit = New Janus.Windows.EditControls.UICheckBox()
        Me.chkcash = New Janus.Windows.EditControls.UICheckBox()
        Me.grpDeposit = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.cboBank = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridINV = New Janus.Windows.GridEX.GridEX()
        Me.colGRID = New Janus.Windows.GridEX.GridEX()
        Me.cmdExit = New Janus.Windows.EditControls.UIButton()
        Me.cmdSave = New Janus.Windows.EditControls.UIButton()
        Me.cmdPrint = New Janus.Windows.EditControls.UIButton()
        CType(Me.grpCollections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCollections.SuspendLayout()
        CType(Me.grpCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCash.SuspendLayout()
        CType(Me.grpDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDeposit.SuspendLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCheque.SuspendLayout()
        CType(Me.cboBank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridINV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCollections
        '
        Me.grpCollections.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCollections.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpCollections.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.TabPage
        Me.grpCollections.Controls.Add(Me.grpCash)
        Me.grpCollections.Controls.Add(Me.chkCheque)
        Me.grpCollections.Controls.Add(Me.chkDeposit)
        Me.grpCollections.Controls.Add(Me.chkcash)
        Me.grpCollections.Controls.Add(Me.grpDeposit)
        Me.grpCollections.Controls.Add(Me.grpCheque)
        Me.grpCollections.Location = New System.Drawing.Point(3, 27)
        Me.grpCollections.Name = "grpCollections"
        Me.grpCollections.Size = New System.Drawing.Size(933, 152)
        Me.grpCollections.TabIndex = 168
        Me.grpCollections.Text = "Στοιχεία Είσπραξης"
        Me.grpCollections.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'grpCash
        '
        Me.grpCash.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpCash.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.TabPage
        Me.grpCash.Controls.Add(Me.txtCashPrice)
        Me.grpCash.Controls.Add(Me.Label7)
        Me.grpCash.Controls.Add(Me.Label3)
        Me.grpCash.Controls.Add(Me.dtCashDate)
        Me.grpCash.DisabledFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grpCash.Enabled = False
        Me.grpCash.Location = New System.Drawing.Point(130, 0)
        Me.grpCash.Name = "grpCash"
        Me.grpCash.Size = New System.Drawing.Size(101, 151)
        Me.grpCash.TabIndex = 185
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(2, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 187
        Me.Label3.Text = "Ημερ/νία"
        '
        'dtCashDate
        '
        '
        '
        '
        Me.dtCashDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtCashDate.Location = New System.Drawing.Point(5, 82)
        Me.dtCashDate.Name = "dtCashDate"
        Me.dtCashDate.Size = New System.Drawing.Size(89, 20)
        Me.dtCashDate.TabIndex = 4
        Me.dtCashDate.Value = New Date(2019, 12, 1, 0, 0, 0, 0)
        Me.dtCashDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        '
        'chkCheque
        '
        Me.chkCheque.BackColor = System.Drawing.Color.Transparent
        Me.chkCheque.CheckedValue = True
        Me.chkCheque.Location = New System.Drawing.Point(9, 61)
        Me.chkCheque.Name = "chkCheque"
        Me.chkCheque.Size = New System.Drawing.Size(104, 23)
        Me.chkCheque.TabIndex = 2
        Me.chkCheque.TabStop = False
        Me.chkCheque.Text = "ΕΠΙΤΑΓΗ"
        Me.chkCheque.UncheckedValue = False
        Me.chkCheque.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'chkDeposit
        '
        Me.chkDeposit.BackColor = System.Drawing.Color.Transparent
        Me.chkDeposit.CheckedValue = True
        Me.chkDeposit.Location = New System.Drawing.Point(9, 106)
        Me.chkDeposit.Name = "chkDeposit"
        Me.chkDeposit.Size = New System.Drawing.Size(104, 23)
        Me.chkDeposit.TabIndex = 3
        Me.chkDeposit.TabStop = False
        Me.chkDeposit.Text = "ΚΑΤΑΘΕΣΗ"
        Me.chkDeposit.UncheckedValue = False
        Me.chkDeposit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'chkcash
        '
        Me.chkcash.BackColor = System.Drawing.Color.Transparent
        Me.chkcash.CheckedValue = True
        Me.chkcash.Location = New System.Drawing.Point(9, 16)
        Me.chkcash.Name = "chkcash"
        Me.chkcash.Size = New System.Drawing.Size(104, 23)
        Me.chkcash.TabIndex = 1
        Me.chkcash.TabStop = False
        Me.chkcash.Text = "ΜΕΤΡΗΤΑ"
        Me.chkcash.UncheckedValue = False
        Me.chkcash.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'grpDeposit
        '
        Me.grpDeposit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpDeposit.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.TabPage
        Me.grpDeposit.Controls.Add(Me.Label11)
        Me.grpDeposit.Controls.Add(Me.dtdepositDate)
        Me.grpDeposit.Controls.Add(Me.Label12)
        Me.grpDeposit.Controls.Add(Me.txtDepositPrice)
        Me.grpDeposit.Controls.Add(Me.txtdepositNum)
        Me.grpDeposit.Controls.Add(Me.Label13)
        Me.grpDeposit.DisabledFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grpDeposit.Enabled = False
        Me.grpDeposit.Location = New System.Drawing.Point(580, 0)
        Me.grpDeposit.Name = "grpDeposit"
        Me.grpDeposit.Size = New System.Drawing.Size(103, 151)
        Me.grpDeposit.TabIndex = 178
        Me.grpDeposit.Text = "Κατάθεση"
        Me.grpDeposit.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(5, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 177
        Me.Label11.Text = "Ημερ/νία"
        '
        'dtdepositDate
        '
        '
        '
        '
        Me.dtdepositDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.VS2010
        Me.dtdepositDate.Location = New System.Drawing.Point(8, 82)
        Me.dtdepositDate.Name = "dtdepositDate"
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
        Me.grpCheque.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.TabPage
        Me.grpCheque.Controls.Add(Me.Label10)
        Me.grpCheque.Controls.Add(Me.dtchequeDate)
        Me.grpCheque.Controls.Add(Me.Label9)
        Me.grpCheque.Controls.Add(Me.txtChequePrice)
        Me.grpCheque.Controls.Add(Me.txtchequeNum)
        Me.grpCheque.Controls.Add(Me.Label8)
        Me.grpCheque.DisabledFormatStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.grpCheque.Enabled = False
        Me.grpCheque.Location = New System.Drawing.Point(350, 0)
        Me.grpCheque.Name = "grpCheque"
        Me.grpCheque.Size = New System.Drawing.Size(105, 151)
        Me.grpCheque.TabIndex = 172
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
        'cboBank
        '
        Me.cboBank.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cboBank.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        cboBank_DesignTimeLayout.LayoutString = resources.GetString("cboBank_DesignTimeLayout.LayoutString")
        Me.cboBank.DesignTimeLayout = cboBank_DesignTimeLayout
        Me.cboBank.DisplayMember = "Name"
        Me.cboBank.HoverMode = Janus.Windows.GridEX.HoverMode.Highlight
        Me.cboBank.Location = New System.Drawing.Point(321, 2)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Black
        Me.cboBank.SelectedIndex = -1
        Me.cboBank.SelectedItem = Nothing
        Me.cboBank.SettingsKey = "cboMainCus"
        Me.cboBank.Size = New System.Drawing.Size(305, 20)
        Me.cboBank.TabIndex = 0
        Me.cboBank.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.cboBank.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Control
        Me.Label20.Location = New System.Drawing.Point(247, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 13)
        Me.Label20.TabIndex = 176
        Me.Label20.Text = "Τράπεζα"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(3, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(933, 19)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Εισπράξεις"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(1, -2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(937, 26)
        Me.Label2.TabIndex = 188
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridINV
        '
        Me.GridINV.AlternatingColors = True
        Me.GridINV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridINV_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
        Me.GridINV.DesignTimeLayout = GridINV_DesignTimeLayout
        Me.GridINV.DynamicFiltering = True
        Me.GridINV.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridINV.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridINV.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridINV.Location = New System.Drawing.Point(3, 180)
        Me.GridINV.Name = "GridINV"
        Me.GridINV.RecordNavigator = True
        Me.GridINV.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridINV.Size = New System.Drawing.Size(933, 260)
        Me.GridINV.TabIndex = 189
        Me.GridINV.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'colGRID
        '
        Me.colGRID.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.colGRID.AlternatingColors = True
        Me.colGRID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        colGRID_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
        Me.colGRID.DesignTimeLayout = colGRID_DesignTimeLayout
        Me.colGRID.DynamicFiltering = True
        Me.colGRID.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.None
        Me.colGRID.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.colGRID.GroupByBoxVisible = False
        Me.colGRID.Location = New System.Drawing.Point(3, 459)
        Me.colGRID.Name = "colGRID"
        Me.colGRID.RecordNavigator = True
        Me.colGRID.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.colGRID.Size = New System.Drawing.Size(933, 139)
        Me.colGRID.TabIndex = 187
        Me.colGRID.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(780, 604)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 13
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Location = New System.Drawing.Point(861, 604)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Location = New System.Drawing.Point(699, 604)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 23)
        Me.cmdPrint.TabIndex = 190
        Me.cmdPrint.Text = "Έκδοση"
        Me.cmdPrint.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010
        '
        'frmCollections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(940, 634)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.GridINV)
        Me.Controls.Add(Me.colGRID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboBank)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.grpCollections)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmCollections"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Εισπράξεις"
        CType(Me.grpCollections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCollections.ResumeLayout(False)
        CType(Me.grpCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCash.ResumeLayout(False)
        Me.grpCash.PerformLayout()
        CType(Me.grpDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDeposit.ResumeLayout(False)
        Me.grpDeposit.PerformLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCheque.ResumeLayout(False)
        Me.grpCheque.PerformLayout()
        CType(Me.cboBank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridINV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCollections As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpDeposit As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label11 As Label
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
    Friend WithEvents chkDeposit As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkcash As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkCheque As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents cboBank As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Label20 As Label
    Friend WithEvents grpCash As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCashPrice As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtCashDate As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GridINV As Janus.Windows.GridEX.GridEX
    Friend WithEvents colGRID As Janus.Windows.GridEX.GridEX
    Friend WithEvents cmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmdPrint As Janus.Windows.EditControls.UIButton
End Class
