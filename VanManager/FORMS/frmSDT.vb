Imports System.Data.OleDb

Public Class frmSDT
    Private ID As String
    Public Mode As Byte

    Private Sub frmSDT_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow
            ID = Row1.Cells("ID").Value.ToString
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from SDT where id ='" + ID + "'", cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("sdtcode")) = False Then txtCode.Text = sdr.GetString(sdr.GetOrdinal("SDTcode"))
                If sdr.IsDBNull(sdr.GetOrdinal("name")) = False Then txtName.Text = sdr.GetString(sdr.GetOrdinal("name"))
                If sdr.IsDBNull(sdr.GetOrdinal("descr")) = False Then txtDescr.Text = sdr.GetString(sdr.GetOrdinal("descr"))
                If sdr.IsDBNull(sdr.GetOrdinal("descrak")) = False Then txtDescrAk.Text = sdr.GetString(sdr.GetOrdinal("descrak"))
                sdr.Close()
            End If
            Call LockUnlockAllControls(Me, Mode = FormMode.ViewRecord)
            cmdExit.Enabled = True
        Else
            txtCode.Text = GetNewCode("SDT")
        End If
        txtCode.ReadOnly = True
    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String

        Try
            If txtCode.Text.Length = 0 Or txtName.Text.Length = 0 Or txtDescr.Text.Length = 0 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE SDT set " &
                   "SDTcode =  " & toSQLValueJ(txtCode, True) & "," &
                   "Name = " & toSQLValueJ(txtName) & "," &
                   "descr = " & toSQLValueJ(txtDescr) & "," &
                   "descrak = " & toSQLValueJ(txtDescrAk) &
                    " where id = '" & ID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    frmMain.FillJanusGrid("SDT")
                End Using

            ElseIf Mode = FormMode.NewRecord Then
                'Καταχώρηση Δεδομένων
                sSQL = "INSERT INTO SDT ([sdtcode],[name],[descr],[descrak]) " &
               "values (" & toSQLValueJ(txtCode, True) & ", " &
                            toSQLValueJ(txtName) & ", " &
                            toSQLValueJ(txtDescr) & ", " &
                            toSQLValueJ(txtDescrAk) & ")"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    frmMain.FillJanusGrid("SDT")
                End Using
                Call ClearAllControls(Me)
                txtCode.Text = GetNewCode("SDT")
            End If
            MessageBox.Show("Ο τύπος παραστατικού αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub

End Class