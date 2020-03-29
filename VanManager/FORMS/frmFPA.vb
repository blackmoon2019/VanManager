﻿Imports System.Data.OleDb

Public Class frmFPA
    Private ID As String
    Public Mode As Byte
    Private CBJanus As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Private Sub frmFPA_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow
            If Not CBJanus Is Nothing Then
                ID = CBJanus.SelectedItem("id").ToString
            Else
                ID = Row1.Cells("ID").Value.ToString
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from fpa where id ='" + ID + "'", cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                txtCode.Text = sdr.GetInt32(sdr.GetOrdinal("code"))
                txtName.Text = sdr.GetDouble(sdr.GetOrdinal("name"))
                sdr.Close()
            End If
            txtCode.Enabled = (Mode <> FormMode.ViewRecord)
            txtName.Enabled = txtCode.Enabled
        Else
            txtCode.Text = GetNewCode("FPA")
            txtName.Select()
        End If
    End Sub

    Private Sub frmFPA_Closed(sender As Object, e As EventArgs) Handles Me.Closed
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
            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE FPA set code = " & toSQLValueJ(txtCode, True) & ", " &
                       "name =  " & Replace(txtName.Value, ",", ".") &
                       "where id = '" & ID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                If CBJanus Is Nothing Then frmMain.FillJanusGrid("FPA")
                If Not CBJanus Is Nothing Then
                    FillJanuscboFPA(CBJanus)
                    CBJanus.Value = ID
                    CBJanus.Text = txtName.Text
                    CBJanus.SelectedItem = CBJanus.Value
                End If
            ElseIf Mode = FormMode.NewRecord Then
                ' Καταχώρηση Δεδομένων
                sSQL = "INSERT INTO FPA (code,name) " &
                   "values (" & toSQLValueJ(txtCode, True) & ", " &
                                Replace(txtName.Value, ",", ".") & ")"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                If CBJanus Is Nothing Then frmMain.FillJanusGrid("FPA")
                If Not CBJanus Is Nothing Then
                    FillJanuscboFPA(CBJanus)
                    CBJanus.Value = GetLastSavedGuid("FPA", txtCode.Text).ToString
                    CBJanus.Text = txtName.Text
                    CBJanus.SelectedItem = CBJanus.Value
                    Me.Close()
                Else
                    Call ClearAllControls(Me)
                    txtCode.Text = GetNewCode("FPA")
                    txtName.Select()
                End If
            End If
            MessageBox.Show("Το ΦΠΑ αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class