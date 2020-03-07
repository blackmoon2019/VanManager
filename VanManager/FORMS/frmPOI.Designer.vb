<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOI))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHlp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPlate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDrv = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCus = New System.Windows.Forms.TextBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdDelAttach = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDelPath = New System.Windows.Forms.TextBox()
        Me.cmdAttach = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.dbPoints = New System.Windows.Forms.DataGridView()
        Me.cArDelt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDeltPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cDelFile = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtArDelt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.dlgDeltia = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dbPoints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtHlp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPlate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDrv)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtCus)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(771, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Πληροφορίες Δρομολογίου"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(353, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Βοηθός"
        '
        'txtHlp
        '
        Me.txtHlp.BackColor = System.Drawing.Color.Bisque
        Me.txtHlp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtHlp.Location = New System.Drawing.Point(356, 83)
        Me.txtHlp.Name = "txtHlp"
        Me.txtHlp.Size = New System.Drawing.Size(217, 20)
        Me.txtHlp.TabIndex = 114
        Me.txtHlp.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Όχημα"
        '
        'txtPlate
        '
        Me.txtPlate.BackColor = System.Drawing.Color.Bisque
        Me.txtPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtPlate.Location = New System.Drawing.Point(356, 44)
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(217, 20)
        Me.txtPlate.TabIndex = 112
        Me.txtPlate.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Οδηγός"
        '
        'txtDrv
        '
        Me.txtDrv.BackColor = System.Drawing.Color.Bisque
        Me.txtDrv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtDrv.Location = New System.Drawing.Point(114, 83)
        Me.txtDrv.Name = "txtDrv"
        Me.txtDrv.Size = New System.Drawing.Size(217, 20)
        Me.txtDrv.TabIndex = 110
        Me.txtDrv.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(111, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 15)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Πελάτης"
        '
        'txtCus
        '
        Me.txtCus.BackColor = System.Drawing.Color.Bisque
        Me.txtCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtCus.Location = New System.Drawing.Point(114, 40)
        Me.txtCus.Name = "txtCus"
        Me.txtCus.Size = New System.Drawing.Size(217, 20)
        Me.txtCus.TabIndex = 108
        Me.txtCus.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(588, 521)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(89, 23)
        Me.cmdExit.TabIndex = 9
        Me.cmdExit.Text = "Έξοδος"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(683, 521)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(89, 23)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "Αποθήκευση"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdDelAttach)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtDelPath)
        Me.GroupBox2.Controls.Add(Me.cmdAttach)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtComments)
        Me.GroupBox2.Controls.Add(Me.dbPoints)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtAr)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtArDelt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtAdress)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCode)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 393)
        Me.GroupBox2.TabIndex = 116
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Σημεία"
        '
        'cmdDelAttach
        '
        Me.cmdDelAttach.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cmdDelAttach.Image = CType(resources.GetObject("cmdDelAttach.Image"), System.Drawing.Image)
        Me.cmdDelAttach.Location = New System.Drawing.Point(634, 77)
        Me.cmdDelAttach.Name = "cmdDelAttach"
        Me.cmdDelAttach.Size = New System.Drawing.Size(34, 23)
        Me.cmdDelAttach.TabIndex = 5
        Me.cmdDelAttach.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Αρχείο"
        '
        'txtDelPath
        '
        Me.txtDelPath.BackColor = System.Drawing.Color.Snow
        Me.txtDelPath.Location = New System.Drawing.Point(11, 77)
        Me.txtDelPath.Multiline = True
        Me.txtDelPath.Name = "txtDelPath"
        Me.txtDelPath.ReadOnly = True
        Me.txtDelPath.Size = New System.Drawing.Size(577, 20)
        Me.txtDelPath.TabIndex = 120
        Me.txtDelPath.TabStop = False
        '
        'cmdAttach
        '
        Me.cmdAttach.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cmdAttach.Image = CType(resources.GetObject("cmdAttach.Image"), System.Drawing.Image)
        Me.cmdAttach.Location = New System.Drawing.Point(594, 77)
        Me.cmdAttach.Name = "cmdAttach"
        Me.cmdAttach.Size = New System.Drawing.Size(34, 23)
        Me.cmdAttach.TabIndex = 4
        Me.cmdAttach.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 106)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 13)
        Me.Label18.TabIndex = 118
        Me.Label18.Text = "Σχόλια"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(11, 122)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(657, 51)
        Me.txtComments.TabIndex = 6
        '
        'dbPoints
        '
        Me.dbPoints.AllowUserToAddRows = False
        Me.dbPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbPoints.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cArDelt, Me.cAddress, Me.cAr, Me.cComments, Me.cDeltPath, Me.cCode, Me.cView, Me.cDelFile, Me.cPath})
        Me.dbPoints.Location = New System.Drawing.Point(11, 179)
        Me.dbPoints.Name = "dbPoints"
        Me.dbPoints.RowHeadersVisible = False
        Me.dbPoints.Size = New System.Drawing.Size(751, 208)
        Me.dbPoints.TabIndex = 7
        '
        'cArDelt
        '
        Me.cArDelt.DataPropertyName = "ardelt"
        Me.cArDelt.HeaderText = "Αρ. Δελτίου"
        Me.cArDelt.Name = "cArDelt"
        '
        'cAddress
        '
        Me.cAddress.DataPropertyName = "address"
        Me.cAddress.HeaderText = "Διεύθυνση"
        Me.cAddress.Name = "cAddress"
        Me.cAddress.Width = 200
        '
        'cAr
        '
        Me.cAr.DataPropertyName = "ar"
        Me.cAr.HeaderText = "Αρ."
        Me.cAr.Name = "cAr"
        Me.cAr.Width = 50
        '
        'cComments
        '
        Me.cComments.DataPropertyName = "comments"
        Me.cComments.HeaderText = "Σχόλια"
        Me.cComments.Name = "cComments"
        Me.cComments.Width = 200
        '
        'cDeltPath
        '
        Me.cDeltPath.DataPropertyName = "deltPath"
        Me.cDeltPath.HeaderText = "Αρχείο"
        Me.cDeltPath.Name = "cDeltPath"
        Me.cDeltPath.ReadOnly = True
        Me.cDeltPath.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cDeltPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cDeltPath.Width = 50
        '
        'cCode
        '
        Me.cCode.DataPropertyName = "code"
        Me.cCode.HeaderText = "Κωδικός"
        Me.cCode.Name = "cCode"
        Me.cCode.Visible = False
        '
        'cView
        '
        Me.cView.HeaderText = "Επιλογή"
        Me.cView.Name = "cView"
        Me.cView.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cView.Width = 70
        '
        'cDelFile
        '
        Me.cDelFile.HeaderText = "Διαγραφή"
        Me.cDelFile.Name = "cDelFile"
        Me.cDelFile.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cDelFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cDelFile.Width = 70
        '
        'cPath
        '
        Me.cPath.DataPropertyName = "dtp"
        Me.cPath.HeaderText = "Διαδρομή"
        Me.cPath.Name = "cPath"
        Me.cPath.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(614, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Αριθμός"
        '
        'txtAr
        '
        Me.txtAr.BackColor = System.Drawing.Color.Snow
        Me.txtAr.Location = New System.Drawing.Point(617, 36)
        Me.txtAr.Name = "txtAr"
        Me.txtAr.Size = New System.Drawing.Size(51, 20)
        Me.txtAr.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Αρ. Δελτίου"
        '
        'txtArDelt
        '
        Me.txtArDelt.BackColor = System.Drawing.Color.Snow
        Me.txtArDelt.Location = New System.Drawing.Point(100, 36)
        Me.txtArDelt.Name = "txtArDelt"
        Me.txtArDelt.Size = New System.Drawing.Size(84, 20)
        Me.txtArDelt.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(187, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Διεύθυνση"
        '
        'txtAdress
        '
        Me.txtAdress.BackColor = System.Drawing.Color.Snow
        Me.txtAdress.Location = New System.Drawing.Point(190, 36)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(421, 20)
        Me.txtAdress.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Κωδικός"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.Snow
        Me.txtCode.Location = New System.Drawing.Point(10, 36)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(84, 20)
        Me.txtCode.TabIndex = 0
        '
        'dlgDeltia
        '
        Me.dlgDeltia.FileName = "OpenFileDialog1"
        '
        'frmPOI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(776, 552)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPOI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Σημεία"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dbPoints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCus As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPlate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDrv As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHlp As TextBox
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAr As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtArDelt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAdress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents dbPoints As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents txtComments As TextBox
    Friend WithEvents cmdAttach As Button
    Friend WithEvents dlgDeltia As OpenFileDialog
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDelPath As TextBox
    Friend WithEvents cmdDelAttach As Button
    Friend WithEvents cArDelt As DataGridViewTextBoxColumn
    Friend WithEvents cAddress As DataGridViewTextBoxColumn
    Friend WithEvents cAr As DataGridViewTextBoxColumn
    Friend WithEvents cComments As DataGridViewTextBoxColumn
    Friend WithEvents cDeltPath As DataGridViewTextBoxColumn
    Friend WithEvents cCode As DataGridViewTextBoxColumn
    Friend WithEvents cView As DataGridViewButtonColumn
    Friend WithEvents cDelFile As DataGridViewButtonColumn
    Friend WithEvents cPath As DataGridViewTextBoxColumn
End Class
