Imports System.Data.OleDb

Public Class frmUSERS
    Private ID As String
    Public Mode As Byte
    Private Sub frmUSERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow
            ID = Row1.Cells("ID").Value.ToString
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from USERS where id ='" + ID + "'", cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("code")) = False Then txtCode.Text = sdr.GetInt32(sdr.GetOrdinal("code"))
                If sdr.IsDBNull(sdr.GetOrdinal("name")) = False Then txtName.Text = sdr.GetString(sdr.GetOrdinal("name"))
                If sdr.IsDBNull(sdr.GetOrdinal("lastname")) = False Then txtLastname.Text = sdr.GetString(sdr.GetOrdinal("lastname"))
                If sdr.IsDBNull(sdr.GetOrdinal("un")) = False Then txtUN.Text = sdr.GetString(sdr.GetOrdinal("un"))
                If sdr.IsDBNull(sdr.GetOrdinal("pwd")) = False Then txtPWD.Text = sdr.GetString(sdr.GetOrdinal("pwd"))
                sdr.Close()
            End If
            Call LockUnlockAllControls(Me, Mode = FormMode.ViewRecord)
            cmdExit.Enabled = True
        Else
            txtCode.Text = GetNewCode("USERS")
        End If
        txtCode.ReadOnly = True

    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String

        Try
            If txtCode.Text.Length = 0 Or txtName.Text.Length = 0 Or txtLastname.Text.Length = 0 Or txtUN.Text.Length = 0 Or txtPWD.Text.Length = 0 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE USERS set " &
                   "code =  " & toSQLValueJ(txtCode, True) & "," &
                   "Name = " & toSQLValueJ(txtName) & "," &
                   "lastname = " & toSQLValueJ(txtLastname) & "," &
                   "un = " & toSQLValueJ(txtUN) & "," &
                   "pwd = " & toSQLValueJ(txtPWD) &
                    " where id = '" & ID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    frmMain.FillJanusGrid("USERS")
                End Using

            ElseIf Mode = FormMode.NewRecord Then
                'Καταχώρηση Δεδομένων
                sSQL = "INSERT INTO USERS ([code],[name],[lastname],[un],[pwd]) " &
               "values (" & toSQLValueJ(txtCode, True) & ", " &
                            toSQLValueJ(txtName) & ", " &
                            toSQLValueJ(txtLastname) & ", " &
                            toSQLValueJ(txtUN) & ", " &
                            toSQLValueJ(txtPWD) & ")"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    frmMain.FillJanusGrid("USERS")
                End Using
                Call ClearAllControls(Me)
                txtCode.Text = GetNewCode("USERS")
                ID = System.Guid.NewGuid.ToString()
            End If
            MessageBox.Show("Ο Χρήστης αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub

End Class