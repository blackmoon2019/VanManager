Imports System.Data.OleDb

Public Class FrmDOS
    Private ID As String
    Public Mode As Byte

    Private Sub FrmSeires_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow
            ID = Row1.Cells("ID").Value.ToString
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from DOS where id ='" + ID + "'", cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("code")) = False Then txtCode.Text = sdr.GetInt32(sdr.GetOrdinal("code"))
                If sdr.IsDBNull(sdr.GetOrdinal("name")) = False Then txtName.Text = sdr.GetString(sdr.GetOrdinal("name"))
                If sdr.IsDBNull(sdr.GetOrdinal("iscancel")) = False Then chkCancel.Checked = IIf(sdr.GetBoolean(sdr.GetOrdinal("iscancel")) = True, 1, 0)
                If sdr.IsDBNull(sdr.GetOrdinal("iscollection")) = False Then chkCollection.Checked = IIf(sdr.GetBoolean(sdr.GetOrdinal("iscollection")) = True, 1, 0)
                If sdr.IsDBNull(sdr.GetOrdinal("ishand")) = False Then chkHand.Checked = IIf(sdr.GetBoolean(sdr.GetOrdinal("ishand")) = True, 1, 0)


                sdr.Close()
            End If
            Call LockUnlockAllControls(Me, Mode = FormMode.ViewRecord)
            cmdExit.Enabled = True
        Else
            txtCode.Text = GetNewCode("DOS")
        End If
        txtCode.ReadOnly = True

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String

        Try
            If txtCode.Text.Length = 0 Or txtName.Text.Length = 0 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE DOS set " &
                   "code =  " & toSQLValueJ(txtCode, True) & "," &
                   "Name = " & toSQLValueJ(txtName) & "," &
                   "iscancel = " & IIf(chkCancel.Checked = True, 1, 0) & "," &
                   "iscollection = " & IIf(chkCollection.Checked = True, 1, 0) & "," &
                   "ishand = " & IIf(chkHand.Checked = True, 1, 0) &
                    " where id = '" & ID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    frmMain.FillJanusGrid("DOS")
                End Using

            ElseIf Mode = FormMode.NewRecord Then
                'Καταχώρηση Δεδομένων
                sSQL = "INSERT INTO DOS ([id],[code],[iscancel],[ishand],[iscollection]) " &
               "values (" & "'" & ID.ToString & "'," &
                            toSQLValueJ(txtCode, True) & ", " &
                            toSQLValueJ(txtName, True) & ", " &
                            IIf(chkCancel.Checked = True, 1, 0) & ", " &
                            IIf(chkHand.Checked = True, 1, 0) & ", " &
                            IIf(chkCollection.Checked = True, 1, 0) & ")"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    frmMain.FillJanusGrid("DOS")
                End Using
                Call ClearAllControls(Me)
                txtCode.Text = GetNewCode("DOS")
                ID = System.Guid.NewGuid.ToString()
            End If
            MessageBox.Show("Η σειρά αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub


End Class