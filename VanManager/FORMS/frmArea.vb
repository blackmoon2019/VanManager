Imports System.Data.OleDb

Public Class frmArea
    Private ID As String
    Public Mode As Byte
    Private CBJanus As Janus.Windows.GridEX.EditControls.MultiColumnCombo

    Private Sub frmArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FillJanuscboCOU()
        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow
            If Not CBJanus Is Nothing Then
                ID = CBJanus.SelectedItem("id").ToString
            Else
                ID = Row1.Cells("ID").Value.ToString
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from areas where id ='" + ID + "'", cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("code")) = False Then txtCode.Text = sdr.GetInt32(sdr.GetOrdinal("code"))
                txtName.Text = sdr.GetString(sdr.GetOrdinal("name"))
                cboCOU.Value = sdr.GetGuid(sdr.GetOrdinal("CouID"))
                sdr.Close()
            End If
            txtCode.Enabled = (Mode <> FormMode.ViewRecord)
            txtName.Enabled = txtCode.Enabled
        Else
            txtCode.Text = GetNewCode("AREAS")
            cboCOU.Select()
        End If
    End Sub
    Private Sub FillJanuscboCOU()
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT id,name from vw_COU order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cboCOU.DataSource = ds.Tables(0)
        cboCOU.DisplayMember = "name"
        cboCOU.ValueMember = "id"
        cboCOU.SettingsKey = "id"
        cboCOU.Text = ""

    End Sub
    Private Sub frmArea_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Owner.Enabled = True
    End Sub
    Public WriteOnly Property CTRLJannus As Janus.Windows.GridEX.EditControls.MultiColumnCombo
        Set(value As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
            CBJanus = value
        End Set
    End Property

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String
        Try
            If txtName.TextLength = 0 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If cboCOU.Text = String.Empty Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE AREAS set code =  " & toSQLValueJ(txtCode, True) & "," &
                       "name = " & toSQLValueJ(txtName) & "," &
                       "CouID = " & boSQLValuej(cboCOU) &
                       " where id = '" & ID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                If CBJanus Is Nothing Then frmMain.FillJanusGrid("AREAS")
                If Not CBJanus Is Nothing Then
                    FillJanuscboAREA(CBJanus)
                    CBJanus.Value = ID
                    CBJanus.Text = txtName.Text
                    CBJanus.SelectedItem = CBJanus.Value
                End If
            ElseIf Mode = FormMode.NewRecord Then
                ' Καταχώρηση Δεδομένων
                sSQL = "INSERT INTO areas ([code],[name],[CouID]) " &
                        "values (" & toSQLValueJ(txtCode, True) & ", " &
                                     toSQLValueJ(txtName) & ", " &
                                     boSQLValuej(cboCOU) & ")"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                If CBJanus Is Nothing Then frmMain.FillJanusGrid("AREAS")
                If Not CBJanus Is Nothing Then
                    FillJanuscboAREA(CBJanus, cboCOU.Value.ToString)
                    CBJanus.Value = GetLastSavedGuid("AREAS", txtCode.Text).ToString
                    CBJanus.Text = txtName.Text
                    CBJanus.SelectedItem = CBJanus.Value
                    Me.Close()
                Else
                    Call ClearAllControls(Me)
                    txtCode.Text = GetNewCode("AREAS")
                    txtName.Select()
                End If
            End If
            MessageBox.Show("Η Περιοχή αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class