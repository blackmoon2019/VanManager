Imports System.Data.OleDb
Imports Janus.Windows.GridEX

Public Class frmCollections

    Public Mode As Byte
    Private fieldChoser As frmFieldChooser
    Private mContextMenuColumn As GridEXColumn
    Private _Active As New List(Of ActiveCB)
    Private Colid As String
    Private GROUPFIELD As String
    Private GROUPVALUE As String
    Private APrinted As Boolean = False
    '    Private AlreadyPrinted As Boolean = False
    Private CID As String

    Private Sub frmCollections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ssql As String
        Dim table As New DataTable
        Dim bs1 As New BindingSource
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim column As New GridEXColumn


        FillJanuscboBANKS(cboBank)  ' Τράπεζες

        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            ''grpCollections.Visible = False : GridINV.Location = New Point(3, 27)
            ''Label1.Location = New Point(3, 290)
            ''colGRID.Location = New Point(3, 310)
            ''colGRID.Height = 290 : cboBank.Visible = False : Label20.Visible = False
            'GridINV.Anchor = AnchorStyles.Top + AnchorStyles.Left + AnchorStyles.Bottom + AnchorStyles.Right
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow

            'Dim sSQL As String
            'If GROUPFIELD <> "" Then
            '    sSQL = "Select * from [vw_COL]  inner join vw_INVOICES VI on vi.id = vw_COL.invhid " &
            '            "where " & GROUPFIELD & " = '" + GROUPVALUE + "'"
            'Else
            If GROUPFIELD = "" Then
                If CID <> Nothing Then
                    Colid = CID
                Else
                    Colid = Row1.Cells("ID").Value.ToString
                End If
            End If
            Ssql = "Select * from [COLH]   where id ='" + Colid + "'"
            'End If

            Dim cmd As OleDbCommand = New OleDbCommand(sSQL, cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("BankID")) = False Then cboBank.Value = sdr.GetGuid(sdr.GetOrdinal("BankID"))
                If sdr.IsDBNull(sdr.GetOrdinal("cashPrice")) = False Then txtCashPrice.Value = sdr.GetDecimal(sdr.GetOrdinal("cashPrice"))
                If sdr.IsDBNull(sdr.GetOrdinal("chequePrice")) = False Then txtChequePrice.Value = sdr.GetDecimal(sdr.GetOrdinal("chequePrice"))
                If sdr.IsDBNull(sdr.GetOrdinal("depositPrice")) = False Then txtDepositPrice.Value = sdr.GetDecimal(sdr.GetOrdinal("depositPrice"))
                If sdr.IsDBNull(sdr.GetOrdinal("chequeNum")) = False Then txtchequeNum.Text = sdr.GetString(sdr.GetOrdinal("chequeNum"))
                If sdr.IsDBNull(sdr.GetOrdinal("DepositNum")) = False Then txtdepositNum.Text = sdr.GetString(sdr.GetOrdinal("DepositNum"))
                If sdr.IsDBNull(sdr.GetOrdinal("cashdate")) = False Then dtCashDate.Value = (sdr.GetDateTime(sdr.GetOrdinal("cashdate")))
                If sdr.IsDBNull(sdr.GetOrdinal("chequedate")) = False Then dtchequeDate.Value = (sdr.GetDateTime(sdr.GetOrdinal("chequedate")))
                If sdr.IsDBNull(sdr.GetOrdinal("depositdate")) = False Then dtdepositDate.Value = (sdr.GetDateTime(sdr.GetOrdinal("depositdate")))
                If sdr.IsDBNull(sdr.GetOrdinal("printed")) = False Then AlreadyPrinted = sdr.GetBoolean(sdr.GetOrdinal("printed"))
                If txtCashPrice.Value > 0 Then chkcash.Checked = True
                If txtChequePrice.Value > 0 Then chkCheque.Checked = True
                If txtDepositPrice.Value > 0 Then chkDeposit.Checked = True

                '    ' Ακάλυπτα Τιμολόγια
                '    If sdr.IsDBNull(sdr.GetOrdinal("invhid")) = False Then
                '        Dim invhid As String = sdr.GetGuid(sdr.GetOrdinal("invhID")).ToString
                '        FillInvoicesGRID(invhid)
                '    End If
                'FillInvoicesGRID(invhid)
                sdr.Close()
            End If
            If GROUPFIELD = "" Then FillInvoicesGRID() Else FillInvoicesGRID(True)
        Else
            grpCollections.Visible = True
            dtCashDate.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            dtchequeDate.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            dtdepositDate.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            cmdPrint.Enabled = False
            FillInvoicesGRID() ' Ακάλυπτα Τιμολόγια
        End If
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        Dim row As Janus.Windows.GridEX.GridEXRow
        Dim group As GridEXGroup
        Dim column As New GridEXColumn
        Dim sSQL As String, Parasts As String, sCusid As String
        Dim Pass As Boolean = False
        Dim Amount As Double
        'Έλεγχος 1
        If chkcash.Checked = True And txtCashPrice.Value = "0" Then
            MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'Έλεγχος 2
        If chkCheque.Checked = True And (cboBank.SelectedIndex = -1 Or txtChequePrice.Value = "0" Or txtchequeNum.Text.Length = 0) Then
            MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'Έλεγχος 3
        If chkDeposit.Checked = True And (cboBank.SelectedIndex = -1 Or txtDepositPrice.Value = "0" Or txtdepositNum.Text.Length = 0) Then
            MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'Έλεγχος 4
        If chkDeposit.Checked = False And chkCheque.Checked = False And chkcash.Checked = False Then
            MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        GridINV.RootTable.Groups.Clear()
        'Έλεγχος 5
        If CheckForDifCus(sCusid) = True Then
            'Πελάτης
            column = GridINV.RootTable.Columns("MainCusFullname")
            group = New GridEXGroup(column, SortOrder.Ascending)
            group.HeaderCaption = "Πελάτης"
            group.GroupPrefix = ""
            group.GroupFormatString = ""
            GridINV.RootTable.Groups.Add(group)
            MessageBox.Show("Δεν μπορείτε να κόψετε είσπραξη σε διαφορετικούς πελάτες.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'Έλεγχος 6
        If CheckForColAmountisBiger() = True Then
            'Πελάτης
            column = GridINV.RootTable.Columns("MainCusFullname")
            group = New GridEXGroup(column, SortOrder.Ascending)
            group.HeaderCaption = "Πελάτης"
            group.GroupPrefix = ""
            group.GroupFormatString = ""
            GridINV.RootTable.Groups.Add(group)
            MessageBox.Show("Δεν μπορείτε να κόψετε είσπραξη όταν το σύνολο της είσπραξης είναι μεγαλύτερο " &
                            "από το σύνολο των παραστατικών που επιλέξατε.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Mode = FormMode.NewRecord Then
            Colid = System.Guid.NewGuid.ToString()
            'Καταχώρηση HEADER Είσπραξης
            sSQL = "INSERT INTO COLH ([id],[Cusid],[cashprice],[cashdate],[Paydate],[bankid],[chequedate], " &
                                " [chequenum],[chequeprice],[depositnum],[depositdate],[depositprice]) " &
                       "values (" & "'" & Colid & "'," &
                                    "'" & sCusid & "'," &
                                    Replace(txtCashPrice.Value, ",", ".") & ", " &
                                IIf(chkcash.Checked = True, "'" & Format(dtCashDate.Value, "yyyy-MM-dd") & "'", "NULL") & "," &
                                "'" & Format(Date.Now, "yyyy-MM-dd") & "'," &
                                    boSQLValuej(cboBank) & ", " &
                                IIf(chkCheque.Checked = True, "'" & Format(dtchequeDate.Value, "yyyy-MM-dd") & "'", "NULL") & "," &
                                    toSQLValueJ(txtchequeNum) & "," &
                                    Replace(txtChequePrice.Value, ",", ".") & ", " &
                                    toSQLValueJ(txtdepositNum) & "," &
                                IIf(chkDeposit.Checked = True, "'" & Format(dtdepositDate.Value, "yyyy-MM-dd") & "'", "NULL") & "," &
                                    Replace(txtDepositPrice.Value, ",", ".") & ")"
            Mode = FormMode.EditRecord
        Else
            sSQL = "DELETE COLD where COLid='" & Colid & "'"

            Using oCmd As New OleDbCommand(sSQL, cn)
                oCmd.ExecuteNonQuery()
            End Using
            ' Καταχώρηση Δεδομένων
            sSQL = "UPDATE COLH SET " &
            "[cashprice] = " & "'" & Replace(txtCashPrice.Value, ",", ".") & "'," &
            "[chequenum] = " & "" & toSQLValueJ(txtchequeNum) & "," &
            "[chequeprice] = " & "'" & Replace(txtChequePrice.Value, ",", ".") & "'," &
            "[depositnum] = " & "" & toSQLValueJ(txtdepositNum) & "," &
            "[depositprice] = " & "'" & Replace(txtDepositPrice.Value, ",", ".") & "'," &
            "[cashdate] = " & IIf(chkcash.Checked = True, "'" & Format(dtCashDate.Value, "yyyy-MM-dd") & "'", "NULL") & "," &
            "[chequedate] = " & IIf(chkCheque.Checked = True, "'" & Format(dtchequeDate.Value, "yyyy-MM-dd") & "'", "NULL") & "," &
            "[depositdate] = " & IIf(chkDeposit.Checked = True, "'" & Format(dtdepositDate.Value, "yyyy-MM-dd") & "'", "NULL") & "," &
            "[bankid] = " & boSQLValuej(cboBank) &
            " where id='" & Colid & "'"

        End If
        Using oCmd As New OleDbCommand(sSQL, cn)
            oCmd.ExecuteNonQuery()
        End Using
        'Παίρνω τα παραστατικά που έχουν επιλεχθεί και τα στέλνω για επιμερισμό
        checkedRows = GridINV.GetRows
        Parasts = ""
        For Each row In checkedRows
            If row.Cells("checked").Value = True Then
                Pass = True
                Parasts = Parasts & "," & "'" & row.Cells(0).Value.ToString & "'"
            End If
        Next
        Parasts = Mid(Parasts, 2, Parasts.Length)
        'Καταχώρηση γραμμών
        Using oCmd As New OleDbCommand("ColectionsDivision", cn)
            oCmd.CommandType = CommandType.StoredProcedure
            oCmd.Parameters.AddWithValue("@Parasts", Parasts)
            Amount = txtCashPrice.Value + txtChequePrice.Value + txtDepositPrice.Value
            oCmd.Parameters.AddWithValue("@amount", Amount)
            oCmd.Parameters.AddWithValue("@Colid", Colid)
            oCmd.ExecuteNonQuery()
            'Dim reader As OleDbDataReader
            'reader = oCmd.ExecuteReader()
            'While reader.Read()
            '    MsgBox(reader.Item(0))
            'End While
            'reader.Close()
            Call ClearAllControls(Me)
            txtCashPrice.Value = 0
            txtChequePrice.Value = 0
            txtDepositPrice.Value = 0
        End Using
        FillInvoicesGRID()
        frmMain.FillJanusGrid("COLH")
        cboBank.Select()
        If Pass = False Then
            MessageBox.Show("Δεν έχει επιλεχθεί κανένα τιμολόγιο προς είσπραξη", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Η είσπραξη αποθηκέυθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmdPrint.Enabled = True
            Call PrintCollection(False)
        End If
    End Sub

    'Function όπου επιστρέφει αν έχουν επιλεχθεί διαφορετικοί πελάτες
    Private Function CheckForDifCus(ByRef cusid As String) As Boolean
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        checkedRows = GridINV.GetRows
        Dim CusName As String
        For Each row In checkedRows
            If row.Cells("checked").Value = True Then
                cusid = row.Cells("MainCusID").Value.ToString
                If CusName <> "" And CusName <> row.Cells("MainCusFullname").Value Then Return True
                CusName = row.Cells("MainCusFullname").Value
            End If
        Next
        Return False
    End Function
    'Function όπου επιστρέφει αν το ποσό της είσπραξης είναι μεγαλύτερο από το συνολικό ποσό των τιμολογίων
    Private Function CheckForColAmountisBiger() As Boolean
        Dim TotalInv As Double
        Dim TotalCol As Double = txtCashPrice.Value + txtChequePrice.Value + txtDepositPrice.Value
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        checkedRows = GridINV.GetRows
        For Each row In checkedRows
            If Mode = FormMode.NewRecord Then
                If row.Cells("checked").Value = True Then TotalInv = TotalInv + row.Cells("ypol").Value
            Else
                If row.Cells("checked").Value = True Then TotalInv = TotalInv + row.Cells("gentot").Value
            End If
        Next
        If TotalCol > Math.Round(TotalInv, 2) Then Return True Else Return False
    End Function

    Private Sub chkcash_CheckedChanged(sender As Object, e As EventArgs) Handles chkcash.CheckedChanged
        grpCash.Enabled = chkcash.Checked
        'If chkcash.Checked = False Then txtCashPrice.Value = "0"
        'If chkCheque.Checked = False Then txtchequeNum.Text = "" : txtChequePrice.Value = "0"
        'If chkDeposit.Checked = False Then txtdepositNum.Text = "" : txtDepositPrice.Value = "0"
    End Sub

    Private Sub chkDeposit_CheckedChanged(sender As Object, e As EventArgs) Handles chkDeposit.CheckedChanged
        grpDeposit.Enabled = chkDeposit.Checked
    End Sub

    Private Sub chkCheque_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheque.CheckedChanged
        grpCheque.Enabled = chkCheque.Checked
    End Sub
    Private Sub FillInvoicesGRID(Optional groupf As Boolean = False)
        Dim sql As String
        Dim table As New DataTable
        Dim bs1 As New BindingSource
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim group As GridEXGroup
        Dim column As New GridEXColumn
        Try

            If Colid <> "" Then
                sql = "SELECT  I.id,rowcolor,InvhCode,c.MainCusFullname,c.MainCusPrfname,c.MainCusAddress,c.MainCusAFM,I.MainCusID,C.MAINCUSDOYNAME,
                    kaxia,fpacost,gentot,seira,invdate,name,COLS,ypol,ROUTEid,C.id as ColID,I.PAID,i.invhsygid,i.sdtid,i.idakiromeno,i.idakirotiko 
                    FROM [vw_INVOICES]  I
                    LEFT join COLD on COLD.invhid = I.id
                    inner join vw_col C on C.id = COLD.colid 
                    where C.id =  '" & Colid & "' and idakiromeno is null  and idakirotiko is null
                    union
                    SELECT  I.id,rowcolor,InvhCode,c.MainCusFullname,c.MainCusPrfname,c.MainCusAddress,c.MainCusAFM,I.MainCusID,C.MAINCUSDOYNAME,
                    kaxia,fpacost,gentot,seira,invdate,name,COLS,ypol,ROUTEid,C.id as ColID,I.PAID,i.invhsygid,i.sdtid,i.idakiromeno,i.idakirotiko 
                    FROM [vw_INVOICESsyg]  I
                    LEFT join COLD on COLD.invhsygid = I.id
                    inner join vw_col C on C.id = COLD.colid 
                    where C.id =  '" & Colid & "' and idakiromeno is null and idakirotiko is null"
            ElseIf groupf = True Then
                sql = "SELECT  * FROM [vw_INVOICES] where " & GROUPFIELD & " = '" & GROUPVALUE & "' and idakiromeno is null and idakirotiko is null"
            Else
                sql = "SELECT  id, Seira, invdate, MainCusFullname, name, kAxia, fpacost, gentot, RouteID, COLS, paid, 
			        CASE WHEN COLS = GENTOT THEN 'GREEN' 
			        WHEN COLS > GENTOT THEN 'RED' 
			        WHEN COLS < GENTOT AND COLS <> 0 THEN 'ORANGE' ELSE 'WHITE' END AS ROWCOLOR, 
			        gentot - COLS AS ypol, InvhCode, MAINCUSPrfName, MAINCusAFM, MAINCUSAddress, 
			        MAINCUSDoyname, MainCusID, invhsygid, sdtid,idakiromeno,idakirotiko FROM [vw_INVOICES] 
                    where invhsygid is null and idakiromeno is null and idakirotiko is null and paid=0
                  union 
                 SELECT id, Seira, invdate, MainCusFullname, name, kAxia, fpacost, gentot, RouteID, COLS, paid, 
			     CASE WHEN COLS = GENTOT THEN 'GREEN' 
			     WHEN COLS > GENTOT THEN 'RED' 
			     WHEN COLS < GENTOT AND COLS <> 0 THEN 'ORANGE' ELSE 'WHITE' END AS ROWCOLOR, 
			     gentot - COLS AS ypol, InvhCode, MAINCUSPrfName, MAINCusAFM, MAINCUSAddress, 
			     MAINCUSDoyname, MainCusID, invhsygid, sdtid,idakiromeno,idakirotiko  
                FROM [vw_INVOICESSYG]  where idakiromeno is null and idakirotiko is null  and paid=0 order by invdate"
            End If
            adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
            adapter.Fill(table)
            Dim newColumn As New Data.DataColumn("Checked", GetType(Boolean))
            newColumn.DefaultValue = IIf(Colid <> "", True, False)
            table.Columns.Add(newColumn)
            bs1.DataSource = table
            GridINV.SetDataBinding(table, "")
            GridINV.RetrieveStructure()
            GridINV.VisualStyle = VisualStyle.Office2010
            'GROUP BY Ημερομηνία
            GridINV.RootTable.Groups.Clear()
            'Πελάτης
            column = GridINV.RootTable.Columns("MainCusFullname")
            group = New GridEXGroup(column, SortOrder.Ascending)
            group.HeaderCaption = "Πελάτης"
            group.GroupPrefix = ""
            group.GroupFormatString = ""
            GridINV.RootTable.Groups.Add(group)
            If Colid <> "" Then
                column = GridINV.RootTable.Columns("ColID")
                group = New GridEXGroup(column, SortOrder.Ascending)
                group.HeaderCaption = "Είσπραξη"
                group.GroupPrefix = ""
                group.GroupFormatString = ""
                GridINV.RootTable.Groups.Add(group)
            End If
            'Γραμμή Συνόλων
            GridINV.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True

            With GridINV.RootTable
                'Απόκρυψη στηλών 
                .Columns("rowcolor").Visible = False
                .Columns("InvhCode").Visible = False
                .Columns("MainCusFullname").Visible = True
                .Columns("MainCusPrfname").Visible = False
                .Columns("MainCusDOYname").Visible = False
                .Columns("MainCusAddress").Visible = False
                .Columns("MainCusAFM").Visible = False
                .Columns("MainCusID").Visible = False
                .Columns("invhsygid").Visible = False
                .Columns("sdtid").Visible = False
                .Columns("idakiromeno").Visible = False
                .Columns("idakirotiko").Visible = False
                .Columns("id").Visible = False
                .Columns("PAID").Visible = False
                If Colid <> "" Then .Columns("colid").Visible = False
                .Columns("ROUTEid").Visible = False
                'Ονόματα Στηλών
                .Columns("checked").Caption = ""
                .Columns("seira").Caption = "Αριθμός"
                .Columns("invdate").Caption = "Ημερ/νία"
                .Columns("name").Caption = "Τρ. Πληρωμής"
                .Columns("MainCusFullname").Caption = "Πελάτης"
                .Columns("kaxia").Caption = "Καθ. Αξία"
                .Columns("fpacost").Caption = "ΦΠΑ"
                .Columns("gentot").Caption = "Τελ. Αξία"
                .Columns("COLS").Caption = "Συν. Εισπράξεων"
                .Columns("ypol").Caption = "Υπόλοιπο"
                'Θέσεις στηλών
                .Columns("checked").Position = 1
                'Πλάτος Στηλών
                .Columns("checked").Width = 30
                .Columns("seira").Width = 60
                .Columns("invdate").Width = 70
                .Columns("MainCusFullname").Width = 250
                .Columns("name").Width = 100
                .Columns("kaxia").Width = 70
                .Columns("fpacost").Width = 70
                .Columns("gentot").Width = 70
                .Columns("COLS").Width = 120
                .Columns("ypol").Width = 70
                'Σύνολα
                .Columns("kaxia").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : .Columns("kaxia").TotalFormatString = "c" 'Currency
                .Columns("kaxia").TextAlignment = TextAlignment.Far
                .Columns("fpacost").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : .Columns("fpacost").TotalFormatString = "c" 'Currency
                .Columns("fpacost").TextAlignment = TextAlignment.Far
                .Columns("gentot").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : .Columns("gentot").TotalFormatString = "c" 'Currency
                .Columns("gentot").TextAlignment = TextAlignment.Far
                .Columns("ypol").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : .Columns("ypol").TotalFormatString = "c" 'Currency
                .Columns("ypol").TextAlignment = TextAlignment.Far
                .Columns("COLS").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : .Columns("COLS").TotalFormatString = "c" 'Currency
                .Columns("COLS").TextAlignment = TextAlignment.Far
            End With
            GridINV.TotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
            GridINV.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
            GridINV.TotalRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            Dim col As Janus.Windows.GridEX.GridEXColumn
            Dim ColType As String
            For Each col In GridINV.RootTable.Columns
                ColType = col.EditType
                col.EditType = EditType.NoEdit
                col.FilterEditType = ColType
            Next
            GridINV.RootTable.Columns("checked").EditType = EditType.CheckBox
            FillColsGRID(GridINV.CurrentRow.Cells("id").Value.ToString, Colid)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub FillColsGRID(ByVal invhid As String, Optional ByVal ColHid As String = "0")
        Dim sql As String
        Dim table As New DataTable
        Dim bs1 As New BindingSource
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim column As New GridEXColumn

        sql = "SELECT  *,COLD.id as coldid,COLD.price as Kal FROM [vw_col] 
              inner join COLD on COLD.colid = vw_col.id  where invhid = '" & invhid & "' or invhsygid = '" & invhid & "'"
        If ColHid <> "" And ColHid <> "0" Then sql = sql & "and vw_col.id  = '" & ColHid & "'"
        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(table)
        'Dim newColumn As New Data.DataColumn("Checked", GetType(Boolean))
        'newColumn.DefaultValue = False
        'table.Columns.Add(newColumn)

        bs1.DataSource = table
        colGRID.SetDataBinding(table, "")
        colGRID.RetrieveStructure()
        colGRID.VisualStyle = VisualStyle.Office2010
        'colGRID.EditMode = EditMode.EditOff
        'colGRID.AutoEdit = False
        'Γραμμή Συνόλων
        colGRID.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        With colGRID.RootTable
            'Θέσεις
            '.Columns("checked").Position = 1
            .Columns("MainCusFullname").Position = 1
            .Columns("dosname").Position = 2
            .Columns("printedDate").Position = 3
            .Columns("kal").Position = 4
            .Columns("cashDate").Position = 5
            'Ονόματα στηλών
            .Columns("MainCusFullname").Caption = "Πελάτης"
            '.Columns("checked").Caption = ""
            .Columns("paydate").Caption = "Ημερ/νία Καταχ"
            .Columns("dosname").Caption = "Σειρά"
            .Columns("printedDate").Caption = "Ημερ/νία Έκδοσης"
            .Columns("CashPrice").Caption = "Μετρητά"
            .Columns("CashPrice").Caption = "Μετρητά"
            .Columns("cashDate").Caption = "Ημερ/νία"
            .Columns("chequePrice").Caption = "Επιταγή"
            .Columns("chequeNum").Caption = "Αρ. Επιταγής"
            .Columns("chequeDate").Caption = "Ημερ/νία"
            .Columns("depositPrice").Caption = "Κατάθεση"
            .Columns("depositNum").Caption = "Αρ. Καταθ."
            .Columns("depositDate").Caption = "Ημερ/νία"
            .Columns("total").Caption = "Σύνολο"
            .Columns("BANKNAME").Caption = "Τράπεζα"
            .Columns("kal").Caption = "Ποσό Κάλυψης"
            'Πλάτος Στηλών
            .Columns("depositPrice").Width = 70
            .Columns("MainCusFullname").Width = 150
            '.Columns("checked").Width = 30
            .Columns("paydate").Width = 90
            .Columns("dosname").Width = 50
            .Columns("printedDate").Width = 100
            .Columns("CashPrice").Width = 70
            .Columns("chequePrice").Width = 70
            .Columns("kal").Width = 90
            'Enable
            '.Columns("BANKNAME").EditType = EditType.NoEdit
            '.Columns("total").EditType = EditType.NoEdit
            '.Columns("kal").EditType = EditType.NoEdit
            '.Columns("dosname").EditType = EditType.NoEdit
            '.Columns("printedDate").EditType = EditType.NoEdit
            '.Columns("MainCusFullname").EditType = EditType.NoEdit
            Dim col As Janus.Windows.GridEX.GridEXColumn
            Dim ColType As String
            For Each col In colGRID.RootTable.Columns
                ColType = col.EditType
                col.EditType = EditType.NoEdit
                col.FilterEditType = ColType
            Next

            'Σύνολα
            .Columns("kal").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : .Columns("kal").TotalFormatString = "c" 'Currency
            .Columns("kal").TextAlignment = TextAlignment.Far
            .Columns("CashPrice").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : .Columns("CashPrice").TotalFormatString = "c" 'Currency
            .Columns("CashPrice").TextAlignment = TextAlignment.Far
            .Columns("chequePrice").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : .Columns("chequePrice").TotalFormatString = "c" 'Currency
            .Columns("chequePrice").TextAlignment = TextAlignment.Far
            .Columns("depositPrice").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : .Columns("depositPrice").TotalFormatString = "c" 'Currency
            .Columns("depositPrice").TextAlignment = TextAlignment.Far
            .Columns("total").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : .Columns("total").TotalFormatString = "c" 'Currency
            .Columns("total").TextAlignment = TextAlignment.Far
            'Απόκρυψη
            .Columns("price").Visible = False
            .Columns("id1").Visible = False
            .Columns("id").Visible = False
            .Columns("colid").Visible = False
            .Columns("coldid").Visible = False
            .Columns("invhid").Visible = False
            .Columns("bankid").Visible = False
            .Columns("paydate").Visible = False
            .Columns("Maincusafm").Visible = False
            .Columns("Maincusprfname").Visible = False
            .Columns("Maincusaddress").Visible = False
            .Columns("MainCusDOYname").Visible = False
            .Columns("holloprice").Visible = False
            .Columns("descr").Visible = False
            .Columns("docnumber").Visible = False
            .Columns("MainCusID").Visible = False
            .Columns("cusInvPrevBalance").Visible = False
            .Columns("cusInvbalance").Visible = False
            .Columns("invhsygid").Visible = False

            'Χρώματα
            Dim style1 = New Janus.Windows.GridEX.GridEXFormatStyle()
            Dim style2 = New Janus.Windows.GridEX.GridEXFormatStyle()
            Dim style3 = New Janus.Windows.GridEX.GridEXFormatStyle()
            Dim style4 = New Janus.Windows.GridEX.GridEXFormatStyle()
            Dim style5 = New Janus.Windows.GridEX.GridEXFormatStyle()
            Dim style6 = New Janus.Windows.GridEX.GridEXFormatStyle()
            Dim style7 = New Janus.Windows.GridEX.GridEXFormatStyle()
            Dim style8 = New Janus.Windows.GridEX.GridEXFormatStyle()

            style1.BackColor = Color.Gold
            style2.BackColor = Color.Gold
            style3.BackColor = Color.Gold
            style4.BackColor = Color.Coral
            style5.BackColor = Color.Coral
            style6.BackColor = Color.Coral
            style7.BackColor = Color.GreenYellow
            style8.BackColor = Color.GreenYellow

            .Columns("chequeDate").CellStyle = style1
            .Columns("chequePrice").CellStyle = style2
            .Columns("chequeNum").CellStyle = style3
            .Columns("depositDate").CellStyle = style4
            .Columns("depositPrice").CellStyle = style5
            .Columns("depositNum").CellStyle = style6
            .Columns("CashPrice").CellStyle = style7
            .Columns("cashDate").CellStyle = style8
        End With
        colGRID.TotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
        colGRID.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        colGRID.TotalRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far

    End Sub

    Private Sub colGRID_RecordUpdated(sender As Object, e As EventArgs) Handles colGRID.RecordUpdated
        Dim sSQL As String
        Try
            With colGRID.CurrentRow
                If colGRID.CurrentColumn.EditType = EditType.CheckBox Then Exit Sub
                ' Καταχώρηση Δεδομένων
                sSQL = "UPDATE COLH SET " &
                "[cashprice] = " & "'" & Replace(.Cells("cashprice").Value, ",", ".") & "'," &
                "[chequenum] = " & "'" & .Cells("chequenum").Value & "'," &
                "[chequeprice] = " & "'" & Replace(.Cells("chequeprice").Value, ",", ".") & "'," &
                "[depositnum] = " & "'" & .Cells("depositnum").Value & "'," &
                "[depositprice] = " & "'" & Replace(.Cells("depositprice").Value, ",", ".") & "'"

                If IsDBNull(.Cells("chequedate").Value) = False Then
                    sSQL = sSQL & ",[chequedate] = " & "'" & Format(.Cells("chequedate").Value, "yyyy/MM/dd") & "'"
                End If
                If IsDBNull(.Cells("depositdate").Value) = False Then
                    sSQL = sSQL & ",[depositdate] = " & "'" & Format(.Cells("depositdate").Value, "yyyy/MM/dd") & "'"
                End If
                If IsDBNull(.Cells("cashdate").Value) = False Then
                    sSQL = sSQL & ",[cashdate] = " & "'" & Format(.Cells("cashdate").Value, "yyyy/MM/dd") & "'"
                End If
                sSQL = sSQL & " where id='" & .Cells("id").Value.ToString & "'"
            End With
            Using oCmd As New OleDbCommand(sSQL, cn)
                oCmd.ExecuteNonQuery()
            End Using
            Dim Amount As Double
            Amount = colGRID.CurrentRow.Cells("cashprice").Value + colGRID.CurrentRow.Cells("chequeprice").Value + colGRID.CurrentRow.Cells("depositprice").Value

            sSQL = "UPDATE COLD SET Price = " & Replace(Amount, ",", ".") & " where id = '" & colGRID.CurrentRow.Cells("coldid").Value.ToString & "'"
            Using oCmd As New OleDbCommand(sSQL, cn)
                oCmd.ExecuteNonQuery()
            End Using

            FillInvoicesGRID()
            frmMain.FillJanusGrid("COLH")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Sub GridINV_FormattingRow(sender As Object, e As RowLoadEventArgs) Handles GridINV.FormattingRow
        If e.Row.RowType = RowType.TotalRow Then Exit Sub
        Dim style2 = New Janus.Windows.GridEX.GridEXFormatStyle()

        If e.Row.RowType = RowType.GroupHeader Then
            If e.Row.Group.HeaderCaption = "Είσπραξη" Then e.Row.GroupCaption = "Είσπραξη"
            Exit Sub
        End If
        If e.Row.Cells("checked").Value = True Then
            style2.ForeColor = Color.Blue
            e.Row.RowStyle = style2
        Else
            style2.ForeColor = Color.Black
        End If
        Dim style = New Janus.Windows.GridEX.GridEXFormatStyle()
        Select Case e.Row.Cells("ROWCOLOR").Value
            Case "WHITE" : style.BackColor = Color.White
            Case "ORANGE"
                style.BackColor = Color.Orange
                If Mode = FormMode.EditRecord Or Mode = FormMode.ViewRecord Then
                    e.Row.Cells("CHECKED").EditType = EditType.NoEdit
                End If
            Case "GREEN" : style.BackColor = Color.Green : e.Row.Cells("CHECKED").EditType = EditType.NoEdit
            Case "RED" : style.BackColor = Color.Red
        End Select
        e.Row.RowStyle = style
    End Sub

    Private Sub GridINV_Click(sender As Object, e As EventArgs) Handles GridINV.Click
        If GridINV.CurrentRow.RowType = RowType.Record Then
            If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
                FillColsGRID(GridINV.CurrentRow.Cells("id").Value.ToString, Colid)
            Else
                FillColsGRID(GridINV.CurrentRow.Cells("id").Value.ToString)
            End If
        End If
    End Sub

    Private Sub colGRID_DeletingRecord(sender As Object, e As RowActionCancelEventArgs) Handles colGRID.DeletingRecord
        Dim sSQL As String
        Try
            If Not IsDBNull(e.Row.Cells("dosname").Value) Then
                MessageBox.Show("Δεν μπορεί να διαγραφεί η απόδειξη γιατί έχει εκτυπωθεί", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Cancel = True
                Exit Sub
            End If

            If MessageBox.Show("Να διαγραφεί η επιλεγμένη εγγραφή?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                sSQL = "DELETE COLD where id='" & e.Row.Cells("coldid").Value.ToString & "'"

                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                'Grid Τιμολογίων
                FillInvoicesGRID()
            Else
                e.Cancel = True
            End If
        Catch myOLEDBException As OleDbException 'ole db exception
            e.Cancel = True
            MessageBox.Show(myOLEDBException.ErrorCode.ToString + vbCrLf + myOLEDBException.Message.ToString + vbCrLf + myOLEDBException.Source.ToString)
        End Try
    End Sub
    Public WriteOnly Property GRPFIELD As String
        Set(value As String)
            GROUPFIELD = value
        End Set
    End Property
    Public WriteOnly Property AlreadyPrinted As Boolean
        Set(value As Boolean)
            APrinted = value
        End Set
    End Property

    Public WriteOnly Property GRPVALUE As String
        Set(value As String)
            GROUPVALUE = value
        End Set
    End Property

    Private Sub PrintCollection(Optional ByVal checks As Boolean = True)
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        Dim i As Integer = 0
        'If checks Then
        '    checkedRows = colGRID.GetRows
        '    For Each row In checkedRows
        '        If row.Cells("checked").Value = True Then
        '            i = i + 1
        '            Colid = row.Cells("coldid").Value.ToString
        '        End If
        '    Next

        '    If i > 1 Then
        '        MessageBox.Show("Έχετε επιλέξει περισσότερες από μια αποδείξεις. Για εκτύπωση παρακαλώ επιλέξτε κάθε μια ξεχωριστά.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        '    If i = 0 Then
        '        MessageBox.Show("Δεν έχετε επιλέξει αποδείξεις.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        '    If colGRID.CurrentRow.Cells("dosname").Value.ToString <> "" Then
        '        If MessageBox.Show("Να γίνει επανεκτύπωση της είσπραξης?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
        '            frmCollection.COLID = Colid
        '            frmCollection.Show()
        '        End If
        '    Else
        '        If MessageBox.Show("Να γίνει εκτύπωση της είσπραξης?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
        '            frmCollection.COLID = Colid
        '            frmCollection.Show()
        '        End If
        '    End If
        'Else
        If APrinted Then
            If MessageBox.Show("Να γίνει επανεκτύπωση της είσπραξης?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                frmCollection.Mode = Mode
                frmCollection.ISALREADYPRINTED = True
                frmCollection.COLID = Colid
                frmCollection.ShowDialog()
            End If
        Else
            If MessageBox.Show("Να γίνει εκτύπωση της είσπραξης?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                frmCollection.Mode = Mode
                frmCollection.ISALREADYPRINTED = False
                frmCollection.COLID = Colid
                frmCollection.ShowDialog()
            End If
        End If
        'End If

    End Sub
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim row As Janus.Windows.GridEX.GridEXRow
        Dim group As GridEXGroup
        Dim column As New GridEXColumn
        GridINV.RootTable.Groups.Clear()

        If CheckForColAmountisBiger() = True Then

            MessageBox.Show("Δεν μπορείτε να εκδόσετε είσπραξη όταν το σύνολο της είσπραξης είναι μεγαλύτερο " &
                            "από το σύνολο των παραστατικών που επιλέξατε.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Else
            Call PrintCollection()
        End If
        'Πελάτης
        column = GridINV.RootTable.Columns("MainCusFullname")
        group = New GridEXGroup(column, SortOrder.Ascending)
        group.HeaderCaption = "Πελάτης"
        group.GroupPrefix = ""
        group.GroupFormatString = ""
        GridINV.RootTable.Groups.Add(group)
        If Colid <> "" Then
            column = GridINV.RootTable.Columns("ColID")
            group = New GridEXGroup(column, SortOrder.Ascending)
            group.HeaderCaption = "Είσπραξη"
            group.GroupPrefix = ""
            group.GroupFormatString = ""
            GridINV.RootTable.Groups.Add(group)
        End If
    End Sub

    Private Sub colGRID_FormattingRow(sender As Object, e As RowLoadEventArgs) Handles colGRID.FormattingRow
        If e.Row.RowType = RowType.TotalRow Then Exit Sub
        If Not IsDBNull(e.Row.Cells("dosname").Value) Then
            Dim i As Integer
            For i = 0 To e.Row.Cells.Count - 1
                e.Row.Cells(i).EditType = EditType.NoEdit
            Next
            e.Row.Cells("checked").EditType = EditType.CheckBox
        End If
    End Sub

    Private Sub colGRID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles colGRID.KeyPress
        If e.KeyChar = "." Then e.Handled = True
    End Sub
    Public WriteOnly Property COLHID As String
        Set(value As String)
            CID = value
        End Set
    End Property

End Class