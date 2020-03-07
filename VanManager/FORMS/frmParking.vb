Imports System.Data.OleDb
Imports Janus.Windows.GridEX
Public Class frmParking
    Private ID As String
    Public Mode As Byte
    Private tablePARD As New DataTable
    Private FormIsActivated As Boolean = False
    Private CBJanus As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Private Sub frmParking_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call FillJanuscboCUS(cboMainCus, "Parking = 1")  ' Πελάτες
        Call FillJanuscboVEHT(cboVEHT)    'Τύποι οχημάτων
        Call FillJanuscboVEH(cboJVEH)  ' Αυτοκίνητα
        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow
            If Not CBJanus Is Nothing Then
                ID = CBJanus.SelectedItem("id").ToString
            Else
                ID = Row1.Cells("ID").Value.ToString
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from vw_PARH where id ='" + ID + "'", cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("code")) = False Then txtCode.Text = sdr.GetInt32(sdr.GetOrdinal("code"))
                If sdr.IsDBNull(sdr.GetOrdinal("pos")) = False Then txtPOS.Text = sdr.GetString(sdr.GetOrdinal("pos"))
                If sdr.IsDBNull(sdr.GetOrdinal("cusid")) = False Then cboMainCus.Value = sdr.GetGuid(sdr.GetOrdinal("cusid"))
                If sdr.IsDBNull(sdr.GetOrdinal("vehtid")) = False Then cboVEHT.Value = sdr.GetGuid(sdr.GetOrdinal("vehtid"))
                If sdr.IsDBNull(sdr.GetOrdinal("VehID")) = False Then cboJVEH.Value = sdr.GetGuid(sdr.GetOrdinal("VehID"))
                If sdr.IsDBNull(sdr.GetOrdinal("Price")) = False Then txtPrice.Text = sdr.GetDecimal(sdr.GetOrdinal("Price"))
                If sdr.IsDBNull(sdr.GetOrdinal("datein")) = False Then dtDateIN.Value = (sdr.GetDateTime(sdr.GetOrdinal("DateIN")))
                If sdr.IsDBNull(sdr.GetOrdinal("dateout")) = False Then dtDateOUT.Value = (sdr.GetDateTime(sdr.GetOrdinal("Dateout")))
                sdr.Close()
            End If
            '    Call LockUnlockAllControls(Me, Mode = FormMode.ViewRecord)
        Else
            ID = System.Guid.NewGuid.ToString()
            dtDateIN.Value = Date.Now
            dtDateIN.Value = Date.Now
            txtCode.Text = GetNewCode("PARH")
        End If
        txtCode.ReadOnly = True
        cboMainCus.Select()
        Call FillPARDGrid()      ' Κινήσεις Parking    

    End Sub

    Public Sub FillPARDGrid()
        Dim sql As String
        Dim bs1 As New BindingSource
        Dim adapter As New OleDb.OleDbDataAdapter
        tablePARD.Columns.Clear()
        GridPAR.DataSource = Nothing
        GridPAR.VisualStyle = VisualStyle.Office2010
        tablePARD.Clear()
        sql = "select id,parid,month,year,paid,price,MonthC from vw_PARD where parid = '" & ID & "' order by year,month "

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(tablePARD)
        Dim newColumn As New Data.DataColumn("NewLine", GetType(Boolean))
        newColumn.DefaultValue = "0"
        tablePARD.Columns.Add(newColumn)
        bs1.DataSource = tablePARD
        GridPAR.SetDataBinding(tablePARD, "")
        GridPAR.RetrieveStructure()
        GridPAR.GroupByBoxVisible = False
        Call FormatGrid()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String
        Try
            If cboMainCus.Text.Length = 0 Or txtPOS.Text.Length = 0 Or cboVEHT.SelectedIndex = -1 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If GridPAR.GetRows.Length = 0 Then
                MessageBox.Show("Δεν έχετε καταχωρήσει κανέναν μήνα.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE PARH set " &
                       "code =  " & toSQLValueJ(txtCode, True) & "," &
                       "datein = " & "'" & Format(dtDateIN.Value, "yyyy-MM-dd") & "'," &
                       "dateout = " & "'" & Format(dtDateOUT.Value, "yyyy-MM-dd") & "'," &
                       "cusid = " & boSQLValuej(cboMainCus) & ", " &
                       "VehtID = " & boSQLValuej(cboVEHT) & ", " &
                       "VehID = " & boSQLValuej(cboJVEH) & ", " &
                       "pos = " & toSQLValueJ(txtPOS) & "," &
                       "Price = " & Replace(txtPrice.Value, ",", ".") &
                        " where id = '" & ID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    'frmMain.FillJanusGrid("PARH")
                End Using
            ElseIf Mode = FormMode.NewRecord Then
                'Καταχώρηση Δεδομένων
                sSQL = "INSERT INTO PARH ([id],[code],[datein],[dateout],[cusid],[VehtID],[pos],[VehID],[Price]) " &
               "values (" & "'" & ID.ToString & "'," &
                            toSQLValueJ(txtCode, True) & ", " &
                      "'" & Format(dtDateIN.Value, "yyyy-MM-dd") & "'," &
                      "'" & Format(dtDateOUT.Value, "yyyy-MM-dd") & "'," &
                            boSQLValuej(cboMainCus) & ", " &
                            boSQLValuej(cboVEHT) & ", " &
                            toSQLValueJ(txtPOS) & ", " &
                            boSQLValuej(cboJVEH) & ", " &
                            txtPrice.Value & ")"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    'frmMain.FillJanusGrid("PARH")
                    Call ClearAllControls(Me)
                    txtCode.Text = GetNewCode("PARH")
                    cboMainCus.Select()
                End Using
            End If
            'ΚΑταχώρηση γραμμών Detail Parking
            Call InsertLinesToGridPar()
            ID = System.Guid.NewGuid.ToString()
            FillPARDGrid()
            MessageBox.Show("Η θέση αποθηκέυθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub dtDateOUT_ValueChanged(sender As Object, e As EventArgs) Handles dtDateOUT.ValueChanged
        If FormIsActivated Then
            Dim a As DateTime = New DateTime(Microsoft.VisualBasic.DateAndTime.Year(dtDateIN.Value), Microsoft.VisualBasic.DateAndTime.Month(dtDateIN.Value), Microsoft.VisualBasic.DateAndTime.Day(dtDateIN.Value))
            Dim b As DateTime = New DateTime(Microsoft.VisualBasic.DateAndTime.Year(dtDateOUT.Value), Microsoft.VisualBasic.DateAndTime.Month(dtDateOUT.Value), Microsoft.VisualBasic.DateAndTime.Day(dtDateOUT.Value))
            Dim daysList As New List(Of Integer) From {28, 30, 31}
            Dim NumOfMonths As Integer = DateDiff(DateInterval.Month, a, b) + 1
            Dim NumOfYears As Integer = DateDiff(DateInterval.Year, a, b) + 1
            Dim I As Integer
            Dim y As Integer = Year(a)
            Dim M As Integer = Month(a)
            'if tablePARD.Rows.Clear()

            For j = 1 To NumOfYears
                For I = 1 To NumOfMonths
                    Dim result() As DataRow = tablePARD.Select("month = " & M & " AND year = " & y)
                    If result.Length = 0 Then
                        tablePARD.Rows.Add(ID.ToString, ID.ToString, M, y, 0, "0.00", GetMonthName(M), 1)
                    End If
                    M = M + 1
                    If M > 12 Then Exit For
                Next I
                I = 1
                M = 1
                y = y + 1
            Next j
            Call cmdRefresh_Click(sender, e)
        End If
    End Sub
    Private Sub FormatGrid()
        With GridPAR.RootTable
            .Columns("ID").Visible = False
            .Columns("parid").Visible = False
            .Columns("month").Visible = False
            .Columns("NewLine").Visible = False
            .Columns("month").Caption = "Μήνας" : .Columns("month").EditType = EditType.NoEdit : .Columns("month").Width = 70
            .Columns("year").Caption = "Έτος" : .Columns("year").EditType = EditType.NoEdit
            .Columns("Price").Caption = "Τιμή" : .Columns("Price").Width = 80 : .Columns("Price").HeaderAlignment = TextAlignment.Center
            .Columns("paid").Caption = "Πληρώθηκε" : .Columns("paid").Width = 70
            .Columns("MonthC").EditType = EditType.NoEdit : .Columns("MonthC").Caption = "Μήνας" : .Columns("MonthC").Position = 1
            GridPAR.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
            .Columns("Price").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : .Columns("Price").TotalFormatString = "c" 'Currency
        End With

    End Sub

    Private Sub InsertLinesToGridPar()
        'Αποθήκευση Βοηθών αν υπάρχουν
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        Dim row As Janus.Windows.GridEX.GridEXRow
        Dim sSQL As String, PardID As String
        Try
            checkedRows = GridPAR.GetRows
            For Each row In checkedRows
                If row.Cells(7).Value = "True" Then
                    PardID = System.Guid.NewGuid.ToString()
                    sSQL = "INSERT INTO PARD ([id],[parid],[month],[year],[price],[paid]) " &
                        "values (" & "'" & PardID & "','" & ID.ToString & "'," &
                             row.Cells(2).Value.ToString & "," &
                             row.Cells(3).Value.ToString & "," &
                         "'" & Replace(row.Cells(5).Value, ",", ".") & "'," &
                         IIf(row.Cells(4).Value = "True", 1, 0) & ")"
                    Using oCmd As New OleDbCommand(sSQL, cn)
                        oCmd.ExecuteNonQuery()
                    End Using
                    'Καταχωρεί τους μήνες και στα έσοδα
                    sSQL = "INSERT INTO ES ([code],[dtCreated],[price],[parkid]) " &
                              "values (" & GetNewCode("ES") & ", " &
                                     "'" & Convert.ToDateTime("01" & "/" & row.Cells(2).Value.ToString & "/" & row.Cells(3).Value.ToString) & "'," &
                                           Replace(row.Cells(5).Value, ",", ".") & "," &
                                           "'" & PardID & "')"
                    Using oCmd As New OleDbCommand(sSQL, cn)
                        oCmd.ExecuteNonQuery()
                    End Using
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub
    Private Sub frmParking_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        FormIsActivated = True
    End Sub

    Private Sub GridPAR_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles GridPAR.CellEdited
        Dim sSQL As String
        If Mode = FormMode.EditRecord Or Mode = FormMode.ViewRecord Then
            Try
                If e.Column.GridEX.CurrentRow.Cells("NewLine").Value = False Then
                    ' Ενημέρωση Δεδομένων
                    sSQL = "UPDATE PARD SET " &
                            "[month] = " & e.Column.GridEX.CurrentRow.Cells("month").Value & "," &
                            "[year] = " & e.Column.GridEX.CurrentRow.Cells("year").Value & "," &
                            "[price] = '" & Replace(e.Column.GridEX.CurrentRow.Cells("price").Value, ",", ".") & "'," &
                            "[paid] = '" & IIf(e.Column.GridEX.CurrentRow.Cells("paid").Value = "True", 1, 0) & "'" &
                            "where parid='" & e.Column.GridEX.CurrentRow.Cells("parid").Value.ToString & "' and " &
                            "id='" & e.Column.GridEX.CurrentRow.Cells("id").Value.ToString & "' "
                    Using oCmd As New OleDbCommand(sSQL, cn)
                        oCmd.ExecuteNonQuery()
                    End Using
                    sSQL = "UPDATE ES SET paid = " & IIf(e.Column.GridEX.CurrentRow.Cells("paid").Value = "True", 1, 0) & "," &
                            "[price] = '" & Replace(e.Column.GridEX.CurrentRow.Cells("price").Value, ",", ".") & "'" &
                            " where parkid = '" & e.Column.GridEX.CurrentRow.Cells("id").Value.ToString & "' "
                    Using oCmd As New OleDbCommand(sSQL, cn)
                        oCmd.ExecuteNonQuery()
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally

            End Try
        End If
    End Sub

    Private Sub GridPAR_FormattingRow(sender As Object, e As RowLoadEventArgs) Handles GridPAR.FormattingRow
        If e.Row.Cells("paid").Value = True Then
            Dim style = New Janus.Windows.GridEX.GridEXFormatStyle()
            style.ForeColor = Color.Blue
            e.Row.RowStyle = style
        Else
            Dim style = New Janus.Windows.GridEX.GridEXFormatStyle()
            style.ForeColor = Color.Black
        End If

    End Sub

    Private Sub GridPAR_DeletingRecord(sender As Object, e As RowActionCancelEventArgs) Handles GridPAR.DeletingRecord
        Dim sSQL As String
        Try
            If MessageBox.Show("Να διαγραφεί η επιλεγμένη εγγραφή?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                'Διαγραφεί από το Πάρκινγκ
                sSQL = "DELETE PARD where id='" & e.Row.Cells("id").Value.ToString & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                'Διαγραφεί από τα Έσοδα
                sSQL = "DELETE ES where parkid='" & e.Row.Cells("id").Value.ToString & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using

            Else
                e.Cancel = True
            End If
        Catch myOLEDBException As OleDbException 'ole db exception
            e.Cancel = True
            MessageBox.Show(myOLEDBException.ErrorCode.ToString + vbCrLf + myOLEDBException.Message.ToString + vbCrLf + myOLEDBException.Source.ToString)

        End Try
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        tablePARD.DefaultView.Sort = "year asc,month asc"
        GridPAR.SetDataBinding(tablePARD, "")
        GridPAR.RetrieveStructure()
        Call FormatGrid()
    End Sub

    Private Sub cboMainCus_KeyDown(sender As Object, e As KeyEventArgs) Handles cboMainCus.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmCus.Owner = Me
            frmCus.CTRLJannus = cboMainCus
            Me.Enabled = False
            frmCus.Mode = FormMode.NewRecord
            frmCus.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboMainCus.SelectedItem Is Nothing Then
                frmCus.Owner = Me
                frmCus.CTRLJannus = cboMainCus
                Me.Enabled = False
                frmCus.Mode = FormMode.EditRecord
                frmCus.Show()
            End If
        End If
    End Sub

    Private Sub cboVEHT_KeyDown(sender As Object, e As KeyEventArgs) Handles cboVEHT.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmVeht.Owner = Me
            frmVeht.CTRLJannus = cboVEHT
            Me.Enabled = False
            frmVeht.Mode = FormMode.NewRecord
            frmVeht.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboVEHT.SelectedItem Is Nothing Then
                frmVeht.Owner = Me
                frmVeht.CTRLJannus = cboVEHT
                Me.Enabled = False
                frmVeht.Mode = FormMode.EditRecord
                frmVeht.Show()
            End If
        End If
    End Sub

    Public WriteOnly Property CTRLJannus As Janus.Windows.GridEX.EditControls.MultiColumnCombo
        Set(value As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
            CBJanus = value
        End Set
    End Property
    Private Sub cboJVEH_KeyDown(sender As Object, e As KeyEventArgs) Handles cboJVEH.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmVeh.Owner = Me
            frmVeh.CTRLJannus = cboJVEH
            Me.Enabled = False
            frmVeh.Mode = FormMode.NewRecord
            frmVeh.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboJVEH.SelectedItem Is Nothing Then
                frmVeh.Owner = Me
                frmVeh.CTRLJannus = cboJVEH
                Me.Enabled = False
                frmVeh.Mode = FormMode.EditRecord
                frmVeh.Show()
            End If
        End If
    End Sub
End Class