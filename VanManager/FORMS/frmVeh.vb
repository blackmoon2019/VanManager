Imports System.Data.OleDb
Public Class frmVeh
    Private ID As String
    Public Mode As Byte
    Private CBJanus As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Private Sub frmVeh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillJanuscboVEHT(cboVEHT)
        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow
            If Not CBJanus Is Nothing Then
                ID = CBJanus.SelectedItem("id").ToString
            Else
                ID = Row1.Cells("ID").Value.ToString
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from VEH where id ='" + ID + "'", cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                txtCode.Text = sdr.GetInt32(sdr.GetOrdinal("code"))
                If sdr.IsDBNull(sdr.GetOrdinal("plate")) = False Then txtPlate.Text = sdr.GetString(sdr.GetOrdinal("plate"))
                If sdr.IsDBNull(sdr.GetOrdinal("vehtid")) = False Then cboVEHT.Value = sdr.GetGuid(sdr.GetOrdinal("vehtid"))
                sdr.Close()
            End If
            txtCode.Enabled = (Mode <> FormMode.ViewRecord)
            txtPlate.Enabled = txtCode.Enabled
            cboVEHT.Enabled = txtCode.Enabled
        Else
            txtCode.Text = GetNewCode("VEH")
            txtPlate.Select()
        End If

    End Sub
    Private Sub frmveh_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Owner.Enabled = True
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String
        Try
            If txtPlate.TextLength = 0 Or cboVEHT.SelectedIndex = -1 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE veh set " &
                       "code =  " & toSQLValueJ(txtCode, True) & "," &
                       "plate = " & toSQLValueJ(txtPlate) & "," &
                       "vehtid = " & boSQLValuej(cboVEHT) &
                       "where id = '" & ID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                If CBJanus Is Nothing Then frmMain.FillJanusGrid("VEH")
                If Not CBJanus Is Nothing Then
                    FillJanuscboVEH(CBJanus)
                    CBJanus.Value = ID
                    CBJanus.Text = txtPlate.Text
                    CBJanus.SelectedItem = CBJanus.Value
                End If

            ElseIf Mode = FormMode.NewRecord Then
                ' Καταχώρηση Δεδομένων
                sSQL = "INSERT INTO veh (code,plate,vehtid) " &
                   "values (" & toSQLValueJ(txtCode, True) & ", " &
                                toSQLValueJ(txtPlate) & ", " &
                                boSQLValuej(cboVEHT) & ")"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    If CBJanus Is Nothing Then frmMain.FillJanusGrid("VEH")
                    If Not CBJanus Is Nothing Then
                        FillJanuscboVEH(CBJanus)
                        CBJanus.Value = GetLastSavedGuid("VEH", txtCode.Text).ToString
                        CBJanus.Text = txtPlate.Text
                        CBJanus.SelectedItem = CBJanus.Value
                        Me.Close()
                    Else
                        Call ClearAllControls(Me)
                        txtCode.Text = GetNewCode("VEH")
                        txtPlate.Select()
                    End If
                End Using
            End If
            MessageBox.Show("Το όχημα αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
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
End Class