Imports System.Data.OleDb

Public Class frmEX
    Private ID As String
    Public Mode As Byte
    Private CBJanus As Janus.Windows.GridEX.EditControls.MultiColumnCombo

    Private Sub frmEX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FillJanuscboEXCAT(cboEXCat)  ' Τύποι εξόδων
        Call FillJanuscboVEH(cboVEH)      ' Οχήματα
        Call FillJanuscboDRV(cboJDRV)     ' Οδηγοί
        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow
            If Not CBJanus Is Nothing Then
                ID = CBJanus.SelectedItem("id").ToString
            Else
                ID = Row1.Cells("ID").Value.ToString
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from EX where id ='" + ID + "'", cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("code")) = False Then txtCode.Text = sdr.GetInt32(sdr.GetOrdinal("code"))
                If sdr.IsDBNull(sdr.GetOrdinal("EXCatID")) = False Then cboEXCat.Value = sdr.GetGuid(sdr.GetOrdinal("EXCatID"))
                If sdr.IsDBNull(sdr.GetOrdinal("price")) = False Then txtPrice.Text = sdr.GetDecimal(sdr.GetOrdinal("price"))
                If sdr.IsDBNull(sdr.GetOrdinal("price2")) = False Then txtPrice2.Text = sdr.GetDecimal(sdr.GetOrdinal("price2"))
                If sdr.IsDBNull(sdr.GetOrdinal("fpa")) = False Then txtFPA.Text = sdr.GetDecimal(sdr.GetOrdinal("fpa"))
                If sdr.IsDBNull(sdr.GetOrdinal("paid")) = False Then chkPaid.Checked = IIf(sdr.GetBoolean(sdr.GetOrdinal("paid")) = True, 1, 0)
                If sdr.IsDBNull(sdr.GetOrdinal("monkey")) = False Then chkMonkey.Checked = IIf(sdr.GetBoolean(sdr.GetOrdinal("monkey")) = True, 1, 0)
                If sdr.IsDBNull(sdr.GetOrdinal("dtCreated")) = False Then dtDateCreated.Value = (sdr.GetDateTime(sdr.GetOrdinal("dtCreated")))
                If sdr.IsDBNull(sdr.GetOrdinal("FilePath")) = False Then txtdeltPath.Text = sdr.GetString(sdr.GetOrdinal("FilePath"))
                If sdr.IsDBNull(sdr.GetOrdinal("descr")) = False Then txtDescr.Text = sdr.GetString(sdr.GetOrdinal("descr"))
                If sdr.IsDBNull(sdr.GetOrdinal("InvoiceNum")) = False Then txtInvoiceNum.Text = sdr.GetString(sdr.GetOrdinal("InvoiceNum"))
                If sdr.IsDBNull(sdr.GetOrdinal("VehID")) = False Then cboVEH.Value = sdr.GetGuid(sdr.GetOrdinal("VehID"))
                If sdr.IsDBNull(sdr.GetOrdinal("DrvID")) = False Then cboJDRV.Value = sdr.GetGuid(sdr.GetOrdinal("DrvID"))
                If sdr.IsDBNull(sdr.GetOrdinal("exType")) = False Then chkBlack.Checked = IIf(sdr.GetBoolean(sdr.GetOrdinal("exType")) = True, 1, 0)

                Select Case chkBlack.CheckState
                    Case CheckState.Checked : chkBlack.BackColor = Color.Black : chkBlack.ForeColor = Color.White
                    Case CheckState.Unchecked : chkBlack.BackColor = Color.White : chkBlack.ForeColor = Color.Black
                        'Case CheckState.Indeterminate : chkBlack.BackColor = Color.Transparent : chkBlack.ForeColor = Color.Black
                End Select

                sdr.Close()
            End If
            Call LockUnlockAllControls(Me, Mode = FormMode.ViewRecord)
            cmdExit.Enabled = True
        Else
            txtCode.Text = GetNewCode("EX")
            dtDateCreated.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            chkBlack.BackColor = Color.White : chkBlack.ForeColor = Color.Black
        End If
        cboEXCat.Select()

    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String

        Try
            If cboEXCat.Text.Length = 0 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE EX set " &
                   "code =  " & toSQLValueJ(txtCode, True) & "," &
                   "dtCreated = " & "'" & Format(dtDateCreated.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                   "ExCatID = " & boSQLValuej(cboEXCat) & ", " &
                   "price = " & Replace(txtPrice.Value, ",", ".") & "," &
                   "price2 = " & Replace(txtPrice2.Value, ",", ".") & "," &
                   "fpa = " & Replace(txtFPA.Value, ",", ".") & "," &
                   "filepath = " & toSQLValueJ(txtdeltPath) & "," &
                   "InvoiceNum = " & toSQLValueJ(txtInvoiceNum) & "," &
                   "descr = " & toSQLValueJ(txtDescr) & "," &
                   "paid = " & IIf(chkPaid.Checked = True, 1, 0) & "," &
                   "monkey = " & IIf(chkMonkey.Checked = True, 1, 0) & "," &
                   "DrvID = " & boSQLValuej(cboJDRV) & ", " &
                   "VehID = " & boSQLValuej(cboVEH) & "," &
                   "exType = " & IIf(chkBlack.CheckState = CheckState.Indeterminate, "NULL", IIf(chkBlack.Checked = True, 1, 0)) &
                    " where id = '" & ID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    'frmMain.FillJanusGrid("EX")
                End Using

                MessageBox.Show("Το έξοδο αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Mode = FormMode.NewRecord Then
                'Καταχώρηση Δεδομένων
                sSQL = "INSERT INTO EX ([code],[dtCreated],[ExCatID],[price],[paid],[monkey],[FilePath],[vehID],[DrvID],[exType],[descr],[price2],[fpa],[InvoiceNum]) " &
               "values (" & toSQLValueJ(txtCode, True) & ", " &
                      "'" & Format(dtDateCreated.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                            boSQLValuej(cboEXCat) & ", " &
                            Replace(txtPrice.Value, ",", ".") & ", " &
                            IIf(chkPaid.Checked = True, 1, 0) & ", " &
                            IIf(chkMonkey.Checked = True, 1, 0) & ", " &
                            toSQLValueJ(txtdeltPath) & ", " &
                            boSQLValuej(cboVEH) & ", " &
                            boSQLValuej(cboJDRV) & ", " &
                            IIf(chkBlack.CheckState = CheckState.Indeterminate, "NULL", IIf(chkBlack.Checked = True, 1, 0)) & ", " &
                            toSQLValueJ(txtDescr) & ", " &
                            Replace(txtPrice2.Value, ",", ".") & ", " &
                            Replace(txtFPA.Value, ",", ".") & ", " &
                            toSQLValueJ(txtInvoiceNum) &
                            ")"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    'frmMain.FillJanusGrid("EX")
                    Call ClearAllControls(Me)
                    txtPrice.Value = 0 : txtPrice2.Value = 0 : txtFPA.Value = 0

                    txtCode.Text = GetNewCode("EX")
                End Using
                MessageBox.Show("Το έξοδο αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub

    Private Sub cboEXCat_KeyDown(sender As Object, e As KeyEventArgs) Handles cboEXCat.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmEXcat.Owner = Me
            frmEXcat.CTRLJannus = cboEXCat
            Me.Enabled = False
            frmEXcat.Mode = FormMode.NewRecord
            frmEXcat.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboEXCat.SelectedItem Is Nothing Then
                frmEXcat.Owner = Me
                frmEXcat.CTRLJannus = cboEXCat
                Me.Enabled = False
                frmEXcat.Mode = FormMode.EditRecord
                frmEXcat.Show()
            End If
        End If
    End Sub

    Private Sub cmdAttach_Click(sender As Object, e As EventArgs) Handles cmdAttach.Click
        Dim res As DialogResult
        With dlgDeltia
            .AddExtension = True
            .CheckFileExists = True
            .Filter = "PDF  files(.pdf)|*.pdf"
            .Multiselect = False
            .FileName = ""
            .Title = "Επιλέξτε αρχείο"
            res = .ShowDialog()
            If res = DialogResult.OK Then txtdeltPath.Text = .FileName.ToString() ': cmdDelAttach.Enabled = True
        End With
    End Sub

    Private Sub cmdDet_Click(sender As Object, e As EventArgs) Handles cmdDet.Click
        txtdeltPath.Text = ""
    End Sub


    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        If txtdeltPath.Text.Length > 0 Then Process.Start(txtdeltPath.Text)
    End Sub


    Private Sub cboVEH_KeyDown(sender As Object, e As KeyEventArgs) Handles cboVEH.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmVeh.Owner = Me
            frmVeh.CTRLJannus = cboVEH
            Me.Enabled = False
            frmVeh.Mode = FormMode.NewRecord
            frmVeh.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboVEH.SelectedItem Is Nothing Then
                frmVeh.Owner = Me
                frmVeh.CTRLJannus = cboVEH
                Me.Enabled = False
                frmVeh.Mode = FormMode.EditRecord
                frmVeh.Show()
            End If
        End If

    End Sub



    Private Sub cboJDRV_KeyDown(sender As Object, e As KeyEventArgs) Handles cboJDRV.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmDRV.Owner = Me
            frmDRV.CTRLJannus = cboJDRV
            Me.Enabled = False
            frmDRV.Mode = FormMode.NewRecord
            frmDRV.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboJDRV.SelectedItem Is Nothing Then
                frmDRV.Owner = Me
                frmDRV.CTRLJannus = cboJDRV
                Me.Enabled = False
                frmDRV.Mode = FormMode.EditRecord
                frmDRV.Show()
            End If
        End If
    End Sub
    Private Sub chkBlack_CheckStateChanged(sender As Object, e As EventArgs) Handles chkBlack.CheckStateChanged
        Select Case chkBlack.CheckState
            Case CheckState.Checked : chkBlack.BackColor = Color.Black : chkBlack.ForeColor = Color.White
            Case CheckState.Unchecked : chkBlack.BackColor = Color.White : chkBlack.ForeColor = Color.Black
            Case CheckState.Indeterminate : chkBlack.BackColor = Color.Transparent : chkBlack.ForeColor = Color.Black
        End Select
    End Sub

    Private Sub txtPrice_Click(sender As Object, e As EventArgs) Handles txtPrice.Click

    End Sub

    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        Dim sTeliko As Double
        sTeliko = txtPrice.Value / 1.24
        txtFPA.Value = txtPrice.Value - sTeliko
    End Sub

    Private Sub chkBlack_CheckedChanged(sender As Object, e As EventArgs) Handles chkBlack.CheckedChanged

    End Sub
End Class