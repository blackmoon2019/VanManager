Imports System.Data.OleDb

Public Class frmEXcat
    Private ID As String
    Public Mode As Byte
    Private CBJanus As Janus.Windows.GridEX.EditControls.MultiColumnCombo

    Private Sub frmEXcat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FillYesNoCombo(cboFixed)
        Call FillRepeatEveryCombo(cboRepeat)
        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow
            If Not CBJanus Is Nothing Then
                ID = CBJanus.SelectedItem("id").ToString
            Else
                ID = Row1.Cells("ID").Value.ToString
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from excat where id ='" + ID + "'", cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("code")) = False Then txtCode.Text = sdr.GetInt32(sdr.GetOrdinal("code"))
                If sdr.IsDBNull(sdr.GetOrdinal("name")) = False Then txtName.Text = sdr.GetString(sdr.GetOrdinal("name"))
                If sdr.IsDBNull(sdr.GetOrdinal("isfixed")) = False Then cboFixed.SelectedIndex = IIf(sdr.GetBoolean(sdr.GetOrdinal("isfixed")) = True, 1, 0)
                If sdr.IsDBNull(sdr.GetOrdinal("dtpayment")) = False Then dtPayment.SetDate(sdr.GetDateTime(sdr.GetOrdinal("dtpayment")))
                If sdr.IsDBNull(sdr.GetOrdinal("repeat")) = False Then cboRepeat.SelectedIndex = sdr.GetByte(sdr.GetOrdinal("repeat"))
                If sdr.IsDBNull(sdr.GetOrdinal("dtDateContract")) = False Then dtDateContract.Value = (sdr.GetDateTime(sdr.GetOrdinal("dtDateContract")))
                sdr.Close()
            End If
            txtCode.Enabled = (Mode <> FormMode.ViewRecord)
            txtName.Enabled = txtCode.Enabled
        Else
            txtCode.Text = GetNewCode("EXCAT")
            dtDateContract.Value = DateTime.Now.ToString("yyyy/MM/dd")
            cboFixed.SelectedIndex = 0
            txtName.Select()
        End If

    End Sub

    Private Sub frmEXcat_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Owner.Enabled = True
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String
        Dim excatid As String
        Try
            If txtName.TextLength = 0 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If cboFixed.SelectedIndex = 1 And Format(dtDateContract.Value, "yyyy/MM/dd") = Format(Date.Now, "yyyy/MM/dd") Then
                MessageBox.Show("Θα πρέπει να επιλέξεται ημερομηνία λήξης συμβολαίου", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE EXCAT set " &
                   "code =  " & toSQLValueJ(txtCode, True) & "," &
                   "name =  " & toSQLValueJ(txtName) & "," &
                   "isfixed = " & cboFixed.SelectedIndex & "," &
                   "dtpayment = " & IIf(cboRepeat.Text.Length > 0, "'" & Format(dtPayment.SelectionStart, "yyyy-MM-dd") & "'", "NULL") & "," &
                   "dtDateContract = " & IIf(cboFixed.SelectedIndex = 0, "NULL", "'" & Format(dtDateContract.Value, "yyyy/MM/dd HH:mm:ss") & "'") & "," &
                   "repeat = " & boSQLValuej(cboRepeat, True) & " where id = '" & ID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                If CBJanus Is Nothing Then frmMain.FillJanusGrid("EXCAT")
                If Not CBJanus Is Nothing Then
                    FillJanuscboEXCAT(CBJanus)
                    CBJanus.Value = ID
                    CBJanus.Text = txtName.Text
                    CBJanus.SelectedItem = CBJanus.Value
                End If
            ElseIf Mode = FormMode.NewRecord Then
                ' Καταχώρηση Δεδομένων
                sSQL = "INSERT INTO EXCAT ([code],[name],[isfixed],[dtpayment],[repeat],[dtDateContract]) " &
                        "values (" & toSQLValueJ(txtCode, True) & ", " &
                                     toSQLValueJ(txtName) & ", " &
                                     cboFixed.SelectedIndex & ", " &
                                     IIf(cboRepeat.Text.Length > 0, "'" & Format(dtPayment.SelectionStart, "yyyy-MM-dd") & "'", "NULL") & "," &
                                     boSQLValuej(cboRepeat, True) & "," &
                                     IIf(cboFixed.SelectedIndex = 0, "NULL", "'" & Format(dtDateContract.Value, "yyyy/MM/dd HH:mm:ss") & "'") & ")"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    If CBJanus Is Nothing Then frmMain.FillJanusGrid("EXCAT")
                    If Not CBJanus Is Nothing Then
                        FillJanuscboEXCAT(CBJanus)
                        CBJanus.Value = GetLastSavedGuid("EXCAT", txtCode.Text).ToString
                        CBJanus.Text = txtName.Text
                        CBJanus.SelectedItem = CBJanus.Value
                    End If
                    excatid = GetLastSavedGuid("EXCAT", txtCode.Text)
                End Using
                If cboFixed.SelectedIndex = 1 Then
                    If MessageBox.Show("Θέλετε να δημιουργηθούν αυτόματα τα έξοδα για το πάγιο?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        'Καταχώρηση γραμμών
                        Using oCmd As New OleDbCommand("CreateEx", cn)
                            oCmd.CommandType = CommandType.StoredProcedure
                            oCmd.Parameters.AddWithValue("@Paydate", Format(dtPayment.SelectionStart, "yyyy/MM/dd"))
                            oCmd.Parameters.AddWithValue("@Repeat", cboRepeat.SelectedIndex)
                            oCmd.Parameters.AddWithValue("@ContractDate", Format(dtDateContract.Value, "yyyy/MM/dd"))
                            oCmd.Parameters.AddWithValue("@ExCatID", excatid)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If
                End If
                Call ClearAllControls(Me)
                txtCode.Text = GetNewCode("EXCAT")
                txtName.Select()
                dtDateContract.Value = Date.Now
                dtDateContract.Enabled = False
            End If
            MessageBox.Show("Η κατηγορία εξόδου αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If Not CBJanus Is Nothing Then Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub

    Public WriteOnly Property CTRLJannus As Janus.Windows.GridEX.EditControls.MultiColumnCombo
        Set(value As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
            CBJanus = value
        End Set
    End Property

    Private Sub cboFixed_ValueChanged(sender As Object, e As EventArgs) Handles cboFixed.ValueChanged
        If Not cboFixed.SelectedIndex = 0 Then dtDateContract.Enabled = True Else dtDateContract.Enabled = False
    End Sub
End Class