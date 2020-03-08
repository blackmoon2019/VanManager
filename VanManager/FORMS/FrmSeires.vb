Imports System.Data.OleDb

Public Class FrmSeires
    Private ID As String
    Public Mode As Byte

    Private Sub FrmSeires_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        'If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
        '    Dim Row1 As Janus.Windows.GridEX.GridEXRow
        '    Row1 = frmMain.GridMain.CurrentRow
        '    If Not CBJanus Is Nothing Then
        '        ID = CBJanus.SelectedItem("id").ToString
        '    Else
        '        ID = Row1.Cells("ID").Value.ToString
        '    End If
        '    Dim cmd As OleDbCommand = New OleDbCommand("Select * from EX where id ='" + ID + "'", cn)
        '    Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        '    If (sdr.Read() = True) Then
        '        If sdr.IsDBNull(sdr.GetOrdinal("code")) = False Then txtCode.Text = sdr.GetInt32(sdr.GetOrdinal("code"))
        '        If sdr.IsDBNull(sdr.GetOrdinal("EXCatID")) = False Then cboEXCat.Value = sdr.GetGuid(sdr.GetOrdinal("EXCatID"))
        '        If sdr.IsDBNull(sdr.GetOrdinal("price")) = False Then txtPrice.Text = sdr.GetDecimal(sdr.GetOrdinal("price"))
        '        If sdr.IsDBNull(sdr.GetOrdinal("price2")) = False Then txtPrice2.Text = sdr.GetDecimal(sdr.GetOrdinal("price2"))
        '        If sdr.IsDBNull(sdr.GetOrdinal("fpa")) = False Then txtFPA.Text = sdr.GetDecimal(sdr.GetOrdinal("fpa"))
        '        If sdr.IsDBNull(sdr.GetOrdinal("paid")) = False Then chkPaid.Checked = IIf(sdr.GetBoolean(sdr.GetOrdinal("paid")) = True, 1, 0)
        '        If sdr.IsDBNull(sdr.GetOrdinal("monkey")) = False Then chkMonkey.Checked = IIf(sdr.GetBoolean(sdr.GetOrdinal("monkey")) = True, 1, 0)
        '        If sdr.IsDBNull(sdr.GetOrdinal("dtCreated")) = False Then dtDateCreated.Value = (sdr.GetDateTime(sdr.GetOrdinal("dtCreated")))
        '        If sdr.IsDBNull(sdr.GetOrdinal("FilePath")) = False Then txtdeltPath.Text = sdr.GetString(sdr.GetOrdinal("FilePath"))
        '        If sdr.IsDBNull(sdr.GetOrdinal("descr")) = False Then txtDescr.Text = sdr.GetString(sdr.GetOrdinal("descr"))
        '        If sdr.IsDBNull(sdr.GetOrdinal("InvoiceNum")) = False Then txtInvoiceNum.Text = sdr.GetString(sdr.GetOrdinal("InvoiceNum"))
        '        If sdr.IsDBNull(sdr.GetOrdinal("VehID")) = False Then cboVEH.Value = sdr.GetGuid(sdr.GetOrdinal("VehID"))
        '        If sdr.IsDBNull(sdr.GetOrdinal("DrvID")) = False Then cboJDRV.Value = sdr.GetGuid(sdr.GetOrdinal("DrvID"))
        '        If sdr.IsDBNull(sdr.GetOrdinal("exType")) = False Then chkBlack.Checked = IIf(sdr.GetBoolean(sdr.GetOrdinal("exType")) = True, 1, 0)

        '        Select Case chkBlack.CheckState
        '            Case CheckState.Checked : chkBlack.BackColor = Color.Black : chkBlack.ForeColor = Color.White
        '            Case CheckState.Unchecked : chkBlack.BackColor = Color.White : chkBlack.ForeColor = Color.Black
        '                'Case CheckState.Indeterminate : chkBlack.BackColor = Color.Transparent : chkBlack.ForeColor = Color.Black
        '        End Select

        '        sdr.Close()
        '    End If
        '    Call LockUnlockAllControls(Me, Mode = FormMode.ViewRecord)
        '    cmdExit.Enabled = True
        'Else
        '    txtCode.Text = GetNewCode("EX")
        '    dtDateCreated.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        '    chkBlack.BackColor = Color.White : chkBlack.ForeColor = Color.Black
        'End If
        'cboEXCat.Select()


    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class