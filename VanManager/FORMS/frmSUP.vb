Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports Janus.Windows.GridEX

Public Class frmSUP
    Private ID As String
    Public Mode As Byte
    Private CBJanus As Janus.Windows.GridEX.EditControls.MultiColumnCombo

    Private Sub frmSUP_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call FillJanuscboCOU(cboCOU)
        Call FillJanuscboDOY(cboDOY)
        Call FillJanuscboPRF(cboPRF)
        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow
            If Not CBJanus Is Nothing Then
                ID = CBJanus.SelectedItem("id").ToString
            Else
                ID = Row1.Cells("ID").Value.ToString
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from sup where id ='" + ID + "'", cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("code")) = False Then txtCode.Text = sdr.GetInt32(sdr.GetOrdinal("code"))
                If sdr.IsDBNull(sdr.GetOrdinal("name")) = False Then txtName.Text = sdr.GetString(sdr.GetOrdinal("name"))
                If sdr.IsDBNull(sdr.GetOrdinal("lastname")) = False Then txtLastname.Text = sdr.GetString(sdr.GetOrdinal("lastname"))
                If sdr.IsDBNull(sdr.GetOrdinal("CouID")) = False Then cboCOU.Value = sdr.GetGuid(sdr.GetOrdinal("CouID"))
                If sdr.IsDBNull(sdr.GetOrdinal("AreaID")) = False Then cboArea.Value = sdr.GetGuid(sdr.GetOrdinal("AreaID"))
                If sdr.IsDBNull(sdr.GetOrdinal("ar")) = False Then txtAr.Text = sdr.GetString(sdr.GetOrdinal("ar"))
                If sdr.IsDBNull(sdr.GetOrdinal("Address")) = False Then txtAdr.Text = sdr.GetString(sdr.GetOrdinal("Address"))
                If sdr.IsDBNull(sdr.GetOrdinal("tk")) = False Then txtTK.Text = sdr.GetString(sdr.GetOrdinal("tk"))
                If sdr.IsDBNull(sdr.GetOrdinal("Phone1")) = False Then txtPhone1.Text = sdr.GetString(sdr.GetOrdinal("Phone1"))
                If sdr.IsDBNull(sdr.GetOrdinal("Phone2")) = False Then txtPhone2.Text = sdr.GetString(sdr.GetOrdinal("Phone2"))
                If sdr.IsDBNull(sdr.GetOrdinal("Mobile1")) = False Then txtMob1.Text = sdr.GetString(sdr.GetOrdinal("Mobile1"))
                If sdr.IsDBNull(sdr.GetOrdinal("Mobile2")) = False Then txtMob2.Text = sdr.GetString(sdr.GetOrdinal("Mobile2"))
                If sdr.IsDBNull(sdr.GetOrdinal("fax")) = False Then txtFax.Text = sdr.GetString(sdr.GetOrdinal("fax"))
                If sdr.IsDBNull(sdr.GetOrdinal("Email")) = False Then txtMail.Text = sdr.GetString(sdr.GetOrdinal("Email"))
                If sdr.IsDBNull(sdr.GetOrdinal("site")) = False Then txtWeb.Text = sdr.GetString(sdr.GetOrdinal("site"))
                If sdr.IsDBNull(sdr.GetOrdinal("comments")) = False Then txtComments.Text = sdr.GetString(sdr.GetOrdinal("comments"))
                If sdr.IsDBNull(sdr.GetOrdinal("afm")) = False Then txtAFM.Text = sdr.GetString(sdr.GetOrdinal("afm"))
                If sdr.IsDBNull(sdr.GetOrdinal("prfid")) = False Then cboPRF.Value = sdr.GetGuid(sdr.GetOrdinal("prfid"))
                If sdr.IsDBNull(sdr.GetOrdinal("doyid")) = False Then cboDOY.Value = sdr.GetGuid(sdr.GetOrdinal("doyid"))
                sdr.Close()
            End If
            Call LockUnlockAllControls(Me, Mode = FormMode.ViewRecord)
            cmdExit.Enabled = True
        Else
            txtCode.Text = GetNewCode("SUP")
            ID = System.Guid.NewGuid.ToString()
        End If
        txtCode.ReadOnly = True

    End Sub

    Private Sub txtMail_TextChanged(sender As Object, e As EventArgs) Handles txtMail.TextChanged
        txtMail.BackColor = Color.White
        Dim temp As String
        temp = txtMail.Text
        'Dim conditon As Boolean = False
        If emailaddresscheck(temp) = True Then
            ': If emailaddresscheck(conditon) = True Then
            txtMail.BackColor = Color.LightGreen
        Else
            'MessageBox.Show("Please enter your email address correctly", "Incorrect Email Entry")
            'TextBox1.Text = ""
            txtMail.BackColor = Color.LightSkyBlue
        End If

    End Sub
    Private Function emailaddresscheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            emailaddresscheck = True
        Else
            emailaddresscheck = False
        End If
    End Function

    Private Sub txtWeb_TextChanged(sender As Object, e As EventArgs) Handles txtWeb.TextChanged
        If websiteAddresscheck(txtWeb.Text) = True Then
            txtWeb.BackColor = Color.LightGreen
        Else
            txtWeb.BackColor = Color.LightSkyBlue
        End If
    End Sub
    Private Function websiteAddresscheck(ByVal siteAddress As String) As Boolean
        Dim pattern As String = "^((ht|f)tp(s?)\:\/\/|~/|/)?([\w]+:\w+@)?([a-zA-Z]{1}([\w\-]+\.)+([\w]{2,5}))(:[\d]{1,5})?((/?\w+/)+|/?)(\w+\.[\w]{3,4})?((\?\w+=\w+)?(&\w+=\w+)*)?"
        Dim webAddressMatch As Match = Regex.Match(siteAddress, pattern)
        If webAddressMatch.Success Then
            websiteAddresscheck = True
        Else
            websiteAddresscheck = False
        End If
    End Function

    Private Sub frmSUP_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Owner.Enabled = True
    End Sub

    Private Sub cboCOU_ValueChanged(sender As Object, e As EventArgs) Handles cboCOU.ValueChanged
        If Not cboCOU.SelectedItem Is Nothing Then FillJanuscboAREA(cboArea, cboCOU.SelectedItem("id").ToString)
    End Sub
    Public WriteOnly Property CTRLJannus As Janus.Windows.GridEX.EditControls.MultiColumnCombo
        Set(value As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
            CBJanus = value
        End Set
    End Property

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String
        Try
            If txtName.TextLength = 0 Or txtLastname.TextLength = 0 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE SUP set " &
                       "code = " & toSQLValueJ(txtCode, True) & "," &
                       "name =  " & toSQLValueJ(txtName) & "," &
                       "lastname = " & toSQLValueJ(txtLastname) & "," &
                       "AreaID = " & boSQLValuej(cboArea) & "," &
                       "CouID = " & boSQLValuej(cboCOU) & "," &
                       "ar = " & toSQLValueJ(txtAr) & "," &
                       "Address = " & toSQLValueJ(txtAdr) & "," &
                       "TK = " & toSQLValueJ(txtTK) & "," &
                       "Phone1 = " & toSQLValueJ(txtPhone1) & "," &
                       "Phone2 = " & toSQLValueJ(txtPhone2) & "," &
                       "Mobile1 = " & toSQLValueJ(txtMob1) & "," &
                       "Mobile2 = " & toSQLValueJ(txtMob2) & "," &
                       "Fax = " & toSQLValueJ(txtFax) & "," &
                       "Email = " & toSQLValueJ(txtMail) & "," &
                       "Site = " & toSQLValueJ(txtWeb) & "," &
                       "Comments = " & toSQLValueJ(txtComments) & "," &
                       "AFM = " & toSQLValueJ(txtAFM) & "," &
                       "PRFid = " & boSQLValuej(cboPRF) & "," &
                       "doyid = " & boSQLValuej(cboDOY) &
                       " where id = '" & ID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                If CBJanus Is Nothing Then frmMain.FillJanusGrid("SUP")
                If Not CBJanus Is Nothing Then
                    FillJanuscboSUP(CBJanus)
                    CBJanus.Value = ID
                    CBJanus.Text = txtLastname.Text + " " + txtName.Text
                    CBJanus.SelectedItem = CBJanus.Value
                End If

            ElseIf Mode = FormMode.NewRecord Then
                ' Καταχώρηση Δεδομένων
                sSQL = "INSERT INTO SUP ([id],[code],[name],[lastname],[AreaID],[CouID],[Ar],[Address],[TK],[Phone1] " &
                   ",[Phone2],[Mobile1],[Mobile2],[Fax],[Email],[site],[comments],[afm],[doyid],[prfid]) " &
                    "values (" & "'" & ID & "'," &
                                toSQLValueJ(txtCode, True) & ", " &
                                toSQLValueJ(txtName) & ", " &
                                toSQLValueJ(txtLastname) & ", " &
                                boSQLValuej(cboArea) & ", " &
                                boSQLValuej(cboCOU) & ", " &
                                toSQLValueJ(txtAr) & ", " &
                                toSQLValueJ(txtAdr) & ", " &
                                toSQLValueJ(txtTK) & ", " &
                                toSQLValueJ(txtPhone1) & ", " &
                                toSQLValueJ(txtPhone2) & ", " &
                                toSQLValueJ(txtMob1) & ", " &
                                toSQLValueJ(txtMob2) & ", " &
                                toSQLValueJ(txtFax) & ", " &
                                toSQLValueJ(txtMail) & ", " &
                                toSQLValueJ(txtWeb) & ", " &
                                toSQLValueJ(txtComments) & ", " &
                                toSQLValueJ(txtAFM) & ", " &
                                boSQLValuej(cboDOY) & ", " &
                                boSQLValuej(cboPRF) & ")"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    If CBJanus Is Nothing Then frmMain.FillJanusGrid("SUP")
                    If Not CBJanus Is Nothing Then
                        FillJanuscboSUP(CBJanus)
                        CBJanus.Value = GetLastSavedGuid("SUP", txtCode.Text).ToString
                        CBJanus.Text = txtLastname.Text + " " + txtName.Text
                        CBJanus.SelectedItem = CBJanus.Value
                        Me.Close()
                    Else
                        Call ClearAllControls(Me)
                        txtCode.Text = GetNewCode("CUS")
                        txtName.Select()
                    End If
                End Using
            End If
            MessageBox.Show("Ο Προμηθευτής αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cboDOY_KeyDown(sender As Object, e As KeyEventArgs) Handles cboDOY.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmDoy.Owner = Me
            frmDoy.CTRLJannus = cboDOY
            Me.Enabled = False
            frmDoy.Mode = FormMode.NewRecord
            frmDoy.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboDOY.SelectedItem Is Nothing Then
                frmDoy.Owner = Me
                frmDoy.CTRLJannus = cboDOY
                Me.Enabled = False
                frmDoy.Mode = FormMode.EditRecord
                frmDoy.Show()
            End If
        End If
    End Sub

    Private Sub cboPRF_KeyDown(sender As Object, e As KeyEventArgs) Handles cboPRF.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmprf.Owner = Me
            frmprf.CTRLJannus = cboPRF
            Me.Enabled = False
            frmprf.Mode = FormMode.NewRecord
            frmprf.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboPRF.SelectedItem Is Nothing Then
                frmprf.Owner = Me
                frmprf.CTRLJannus = cboPRF
                Me.Enabled = False
                frmprf.Mode = FormMode.EditRecord
                frmprf.Show()
            End If
        End If
    End Sub

    Private Sub cboArea_KeyDown(sender As Object, e As KeyEventArgs) Handles cboArea.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmArea.Owner = Me
            frmArea.CTRLJannus = cboArea
            Me.Enabled = False
            frmArea.Mode = FormMode.NewRecord
            frmArea.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboArea.SelectedItem Is Nothing Then
                frmArea.Owner = Me
                frmArea.CTRLJannus = cboArea
                Me.Enabled = False
                frmArea.Mode = FormMode.EditRecord
                frmArea.Show()
            End If
        End If

    End Sub

    Private Sub cboCOU_KeyDown(sender As Object, e As KeyEventArgs) Handles cboCOU.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmCou.Owner = Me
            frmCou.CTRLJannus = cboCOU
            Me.Enabled = False
            frmCou.Mode = FormMode.NewRecord
            frmCou.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboCOU.SelectedItem Is Nothing Then
                frmCou.Owner = Me
                frmCou.CTRLJannus = cboCOU
                Me.Enabled = False
                frmCou.Mode = FormMode.EditRecord
                frmCou.Show()
            End If
        End If
    End Sub

    Private Sub txtAFM_LostFocus(sender As Object, e As EventArgs) Handles txtAFM.LostFocus
        If Not CheckAFM(txtAFM.Text) Then MessageBox.Show("Το ΑΦΜ δεν είναι σωστό.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class