Imports System.Data.OleDb
Public Class frmSTS
    Private ID As String
    Public Mode As Byte
    Private CBJanus As Janus.Windows.GridEX.EditControls.MultiColumnCombo

    Private Sub frmSTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FillJanuscboUSERS(cboUSERS)
        Call FillJanuscboSDT(cboSDT)
        Call FillJanuscboDOS(cboDOS)
        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow
            If Not CBJanus Is Nothing Then
                ID = CBJanus.SelectedItem("id").ToString
            Else
                ID = Row1.Cells("ID").Value.ToString
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from STS where id ='" + ID + "'", cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("code")) = False Then txtCode.Text = sdr.GetInt32(sdr.GetOrdinal("code"))
                If sdr.IsDBNull(sdr.GetOrdinal("sdtid")) = False Then cboSDT.Value = sdr.GetGuid(sdr.GetOrdinal("sdtid"))
                If sdr.IsDBNull(sdr.GetOrdinal("dosid")) = False Then cboDOS.Value = sdr.GetGuid(sdr.GetOrdinal("dosid"))
                If sdr.IsDBNull(sdr.GetOrdinal("userid")) = False Then cboUSERS.Value = sdr.GetGuid(sdr.GetOrdinal("userid"))
                sdr.Close()
            End If
            Call LockUnlockAllControls(Me, Mode = FormMode.ViewRecord)
            cmdExit.Enabled = True
        Else
            txtCode.Text = GetNewCode("STS")
        End If

    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String
        Try
            If cboUSERS.TextLength = 0 Or cboSDT.TextLength = 0 Or cboDOS.TextLength = 0 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE STS set " &
                       "code = " & toSQLValueJ(txtCode, True) & "," &
                       "userid = " & boSQLValuej(cboUSERS) & "," &
                       "dosid = " & boSQLValuej(cboDOS) & "," &
                       "sdtid = " & boSQLValuej(cboSDT) &
                       " where id = '" & ID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                frmMain.FillJanusGrid("STS")
            ElseIf Mode = FormMode.NewRecord Then
                ' Καταχώρηση Δεδομένων
                sSQL = "INSERT INTO STS ([code],[userid],[dosid],[sdtid]) " &
                    "values (" & toSQLValueJ(txtCode, True) & ", " &
                                boSQLValuej(cboUSERS) & ", " &
                                boSQLValuej(cboDOS) & ", " &
                                boSQLValuej(cboSDT) & ")"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    frmMain.FillJanusGrid("STS")
                    Call ClearAllControls(Me)
                    txtCode.Text = GetNewCode("STS")
                    cboUSERS.Select()
                End Using
            End If
            MessageBox.Show("Το δέσιμο αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub
End Class