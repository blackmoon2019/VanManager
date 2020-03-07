Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports Janus.Windows.GridEX

Public Class frmCus
    Private ID As String
    Public Mode As Byte
    Private CBJanus As Janus.Windows.GridEX.EditControls.MultiColumnCombo

    Private Sub frmCus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FillJanuscboCOU(cboCOU)
        Call FillJanuscboDOY(cboDOY)
        Call FillJanuscboPRF(cboPRF)
        Call FillYesNoCombo(cboSyg)
        Call FillJanuscboCUSTYPE(cboCUSTYPE)
        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False : grpSYMV.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow
            If Not CBJanus Is Nothing Then
                ID = CBJanus.SelectedItem("id").ToString
            Else
                ID = Row1.Cells("ID").Value.ToString
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from cus where id ='" + ID + "'", cn)
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
                If sdr.IsDBNull(sdr.GetOrdinal("syg")) = False Then cboSyg.SelectedIndex = IIf(sdr.GetBoolean(sdr.GetOrdinal("syg")) = True, 1, 0)
                If sdr.IsDBNull(sdr.GetOrdinal("Parking")) = False Then chkRentParking.Checked = IIf(sdr.GetBoolean(sdr.GetOrdinal("Parking")) = True, 1, 0)
                If sdr.IsDBNull(sdr.GetOrdinal("cusTypeID")) = False Then cboCUSTYPE.Value = sdr.GetGuid(sdr.GetOrdinal("cusTypeID"))
                If sdr.IsDBNull(sdr.GetOrdinal("balance")) = False Then txtcusBalance.Text = sdr.GetDecimal(sdr.GetOrdinal("balance"))
                sdr.Close()
            End If
            Call LockUnlockAllControls(Me, Mode = FormMode.ViewRecord)
        Else
            txtCode.Text = GetNewCode("CUS")
            ID = System.Guid.NewGuid.ToString()
            grpSYMV.Enabled = False
            txtcusBalance.ReadOnly = True
        End If
        dtDateCreated.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        txtCode.ReadOnly = True
        Call FillSYMVGrid()      ' Συμβάσεις
    End Sub
    ' Συμβάσεις
    Public Sub FillSYMVGrid()
        Dim sql As String
        Dim table As New DataTable
        Dim bs1 As New BindingSource
        Dim adapter As New OleDb.OleDbDataAdapter
        table.Columns.Clear()
        GridSYMV.DataSource = Nothing
        GridSYMV.VisualStyle = VisualStyle.Office2010
        table.Clear()
        sql = "select id,cusid,symbash,dtcreated from symv where cusid = '" & ID & "' order by dtcreated"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(table)
        bs1.DataSource = table
        GridSYMV.SetDataBinding(table, "")
        GridSYMV.RetrieveStructure()
        GridSYMV.GroupByBoxVisible = False
        With GridSYMV.RootTable
            .Columns("id").Visible = False
            .Columns("cusid").Visible = False
            .Columns("symbash").Caption = "Σύμβαση" : .Columns("symbash").Width = 200
            .Columns("dtcreated").Caption = "Ημερομηνία" : .Columns("dtcreated").Width = 100
        End With

    End Sub

    Private Sub txtMail_TextChanged(sender As Object, e As EventArgs)
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
    Private Sub txtWeb_TextChanged(sender As Object, e As EventArgs)
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



    Private Sub frmCus_Closed(sender As Object, e As EventArgs) Handles Me.Closed
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
            Select Case Me.Owner.Name
                Case "frmParking"
                    If chkRentParking.Checked = False Then
                        MessageBox.Show("Δεν μπορείτε να καταχωρήσετε τον πελάτη. Πρέπει πρώτα να κάνετε κλικ στην επιλογή 'Νοικιάζει θέση Πάρκινγκ'", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
            End Select
            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE CUS set " &
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
                       "syg = " & cboSyg.SelectedIndex & "," &
                       "parking = " & IIf(chkRentParking.Checked = True, 1, 0) & "," &
                       "doyid = " & boSQLValuej(cboDOY) & "," &
                       "custypeid = " & boSQLValuej(cboCUSTYPE) &
                       " where id = '" & ID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                If CBJanus Is Nothing Then frmMain.FillJanusGrid("CUS")
                If Not CBJanus Is Nothing Then
                    FillJanuscboCUS(CBJanus)
                    CBJanus.Value = ID
                    CBJanus.Text = txtLastname.Text + " " + txtName.Text
                    CBJanus.SelectedItem = CBJanus.Value
                End If

            ElseIf Mode = FormMode.NewRecord Then
                ' Καταχώρηση Δεδομένων
                sSQL = "INSERT INTO cus ([id],[code],[name],[lastname],[AreaID],[CouID],[Ar],[Address],[TK],[Phone1] " &
                   ",[Phone2],[Mobile1],[Mobile2],[Fax],[Email],[site],[comments],[afm],[doyid],[prfid],[syg],[parking],[custypeid]) " &
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
                                boSQLValuej(cboPRF) & ", " &
                                cboSyg.SelectedIndex & "," &
                                 IIf(chkRentParking.Checked = True, 1, 0) & "," &
                                 boSQLValuej(cboCUSTYPE) & ")"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    If CBJanus Is Nothing Then frmMain.FillJanusGrid("CUS")
                    If Not CBJanus Is Nothing Then
                        FillJanuscboCUS(CBJanus)
                        CBJanus.Value = GetLastSavedGuid("CUS", txtCode.Text).ToString
                        CBJanus.Text = txtLastname.Text + " " + txtName.Text
                        CBJanus.SelectedItem = CBJanus.Value
                        Me.Close()
                    Else
                        Call ClearAllControls(Me)
                        txtCode.Text = GetNewCode("CUS")
                        txtName.Select()
                    End If
                    grpSYMV.Enabled = True
                End Using
            End If
            MessageBox.Show("Ο Πελάτης αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub cboCUSTYPE_KeyDown(sender As Object, e As KeyEventArgs) Handles cboCUSTYPE.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmCUSTYPE.Owner = Me
            frmCUSTYPE.CTRLJannus = cboCUSTYPE
            Me.Enabled = False
            frmCUSTYPE.Mode = FormMode.NewRecord
            frmCUSTYPE.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboCUSTYPE.SelectedItem Is Nothing Then
                frmCUSTYPE.Owner = Me
                frmCUSTYPE.CTRLJannus = cboCUSTYPE
                Me.Enabled = False
                frmCUSTYPE.Mode = FormMode.EditRecord
                frmCUSTYPE.Show()
            End If
        End If
    End Sub

    Private Sub cmdSaveSymv_Click(sender As Object, e As EventArgs) Handles cmdSaveSymv.Click
        'Αποθήκευση συμβάσεων αν υπάρχουν
        Dim sSQL As String
        If txtSymvash.Text.Length = 0 Then
            MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        sSQL = "INSERT INTO SYMV ([cusid],[dtcreated],[symbash]) " &
           "values (" & "'" & ID.ToString & "'," & "'" & Format(dtDateCreated.Value, "yyyy/MM/dd HH:mm:ss") & "'," & toSQLValueJ(txtSymvash) & ")"
        Using oCmd As New OleDbCommand(sSQL, cn)
            oCmd.ExecuteNonQuery()
        End Using
        txtSymvash.Text = "" : dtDateCreated.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        FillSYMVGrid()
    End Sub


    Private Sub GridSYMV_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles GridSYMV.CellValueChanged

    End Sub

    Private Sub GridSYMV_DeletingRecord(sender As Object, e As RowActionCancelEventArgs) Handles GridSYMV.DeletingRecord
        If MessageBox.Show("Να διαγραφεί η επιλεγμένη εγγραφή?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            Dim sSQL As String = "DELETE SYMV where id='" & e.Row.Cells("id").Value.ToString & "'"
            Using oCmd As New OleDbCommand(sSQL, cn)
                oCmd.ExecuteNonQuery()
            End Using

        End If
    End Sub



    Private Sub GridSYMV_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles GridSYMV.CellUpdated
        Dim sSQL As String
        Try
            ' Καταχώρηση Δεδομένων
            sSQL = "UPDATE SYMV SET " &
                "[symbash] = '" & e.Column.GridEX.CurrentRow.Cells("symbash").Value & "'," &
                "[dtcreated] = '" & Format(e.Column.GridEX.CurrentRow.Cells("dtcreated").Value, "yyyy/MM/dd HH:mm:ss") & "'" &
                "where id='" & e.Column.GridEX.CurrentRow.Cells("id").Value.ToString & "'"
            Using oCmd As New OleDbCommand(sSQL, cn)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub

    Private Sub txtAFM_TextChanged(sender As Object, e As EventArgs) Handles txtAFM.TextChanged

    End Sub

    Private Sub txtAFM_LostFocus(sender As Object, e As EventArgs) Handles txtAFM.LostFocus
        If Not CheckAFM(txtAFM.Text) Then MessageBox.Show("Το ΑΦΜ δεν είναι σωστό.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
