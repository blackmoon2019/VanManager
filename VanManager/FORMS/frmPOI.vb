Imports System.Data.OleDb

Public Class frmPOI
    Private ID As String
    Public Mode As Byte
    Private Sub frmPOI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbPoints.AutoGenerateColumns = False
        cmdDelAttach.Enabled = False
        'ID = GetLastSavedGuid("ROUTES", FrmRoute.txtCode_old.Text)
        Dim cmd As OleDbCommand = New OleDbCommand("select (cus.lastname + ' ' + cus.name) as cusname,
                                                    (drv.lastname + ' ' + drv.name) as drvname,
                                                    veh.plate, (hlp.lastname + ' ' + hlp.name) as hlpname
                                                    from ROUTES 
                                                    inner join cus on cus.id=ROUTES.CusID 
                                                    inner join drv on drv.id=ROUTES.DrvID 
                                                    inner join veh on veh.id=ROUTES.VehID  
                                                    left join hlp on hlp.id=ROUTES.hlpID  
                                                    where ROUTES.id= '" + ID + "'", cn)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("cusname")) = False Then txtCus.Text = sdr.GetString(sdr.GetOrdinal("cusname"))
            If sdr.IsDBNull(sdr.GetOrdinal("drvname")) = False Then txtDrv.Text = sdr.GetString(sdr.GetOrdinal("drvname"))
            If sdr.IsDBNull(sdr.GetOrdinal("hlpname")) = False Then txtDrv.Text = sdr.GetString(sdr.GetOrdinal("hlpname"))
            If sdr.IsDBNull(sdr.GetOrdinal("plate")) = False Then txtPlate.Text = sdr.GetString(sdr.GetOrdinal("plate"))
            sdr.Close()
        End If
        txtCus.ReadOnly = True : txtPlate.ReadOnly = True
        txtDrv.ReadOnly = True : txtHlp.ReadOnly = True
        txtCode.Text = GetNewCode("POI") : txtCode.ReadOnly = True
        txtArDelt.Select()
        If Mode = FormMode.EditRecord Then FillPoints()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String
        Try
            ' Καταχώρηση Δεδομένων
            sSQL = "INSERT INTO POI ([code],[routeID],[ardelt],[address],[Ar],[comments],[deltPath]) " &
                   "values (" & toSQLValue(txtCode, True) & ", " &
                                "'" & ID & "', " &
                                toSQLValue(txtArDelt) & ", " &
                                toSQLValue(txtAdress) & ", " &
                                toSQLValue(txtAr) & ", " &
                                toSQLValue(txtComments) & ", " &
                                toSQLValue(txtDelPath) & ")"
            Using oCmd As New OleDbCommand(sSQL, cn)
                oCmd.ExecuteNonQuery()
                FillPoints()
                txtCode.Text = GetNewCode("POI")
                txtArDelt.Text = "" : txtAdress.Text = "" : txtAr.Text = "" : txtComments.Text = ""
                txtDelPath.Text = "" : cmdDelAttach.Enabled = False
                txtArDelt.Select()
            End Using
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub
    Private Sub FillPoints()
        Dim sSQL As String
        Dim table As New DataTable
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim bs1 As New BindingSource
        Dim cs As New System.Windows.Forms.DataGridViewCellStyle
        sSQL = "Select  ID,code,ardelt,address,ar,comments,deltpath AS dtp,case when isnull(deltPath,'')='' then 'ΟΧΙ' else 'ΝΑΙ' end deltPath
                from poi where routeID = '" & ID & "'"
        adapter.SelectCommand = New OleDb.OleDbCommand(sSQL, cn)
        adapter.Fill(table)
        bs1.DataSource = table
        dbPoints.DataSource = bs1
        cs.BackColor = Color.FromArgb(219, 229, 241)
        dbPoints.AlternatingRowsDefaultCellStyle = cs
        dbPoints.Refresh()
        If dbPoints.Rows.Count > 0 Then dbPoints.CurrentCell = dbPoints.Rows(0).Cells(1)
    End Sub

    Private Sub frmPOI_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Owner.Enabled = True
    End Sub

    Private Sub dbPoints_KeyDown(sender As Object, e As KeyEventArgs) Handles dbPoints.KeyDown
        Dim sSQL As String
        Try
            If e.KeyCode = Keys.Delete Then
                If dbPoints.Rows.Count = 0 Then Exit Sub
                If MessageBox.Show("Να διαγραφεί η επιλεγμένη εγγραφή?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                    sSQL = "Delete from POI where routeID = '" & ID & "' and code = " & dbPoints.CurrentRow.Cells(4).Value
                    Using oCmd As New OleDbCommand(sSQL, cn)
                        oCmd.ExecuteNonQuery()
                    End Using
                    FillPoints()
                End If
            End If
        Catch myOLEDBException As OleDbException 'ole db exception
            'If myOLEDBException.ErrorCode.ToString = "-2147217873" Then
            MessageBox.Show(myOLEDBException.ErrorCode.ToString + vbCrLf + myOLEDBException.Message.ToString + vbCrLf + myOLEDBException.Source.ToString)
        End Try


    End Sub

    Private Sub dbPoints_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dbPoints.CellEndEdit
        Dim sSQL As String
        Try
            ' Ενημέρωση Δεδομένων
            sSQL = "UPDATE POI set " &
               "ardelt = '" & dbPoints.CurrentRow.Cells(0).Value & "'," &
               "address = '" & dbPoints.CurrentRow.Cells(1).Value & "'," &
               "Ar = '" & dbPoints.CurrentRow.Cells(2).Value & "'," &
               "comments = '" & dbPoints.CurrentRow.Cells(3).Value & "'," &
               "deltPath = '" & dbPoints.CurrentRow.Cells(4).Tag & "'" &
                " where routeid = '" & ID & "' and code = " & dbPoints.CurrentRow.Cells(5).Value
            Using oCmd As New OleDbCommand(sSQL, cn)
                oCmd.ExecuteNonQuery()
            End Using
        Catch myOLEDBException As OleDbException 'ole db exception
            'If myOLEDBException.ErrorCode.ToString = "-2147217873" Then
            MessageBox.Show(myOLEDBException.ErrorCode.ToString + vbCrLf + myOLEDBException.Message.ToString + vbCrLf + myOLEDBException.Source.ToString)
        End Try
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
            If res = DialogResult.OK Then txtDelPath.Text = .FileName.ToString() : cmdDelAttach.Enabled = True
        End With
    End Sub

    Private Sub cmdDelAttach_Click(sender As Object, e As EventArgs) Handles cmdDelAttach.Click
        txtDelPath.Text = ""
        cmdDelAttach.Enabled = False
    End Sub

    Private Sub dbPoints_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dbPoints.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.ColumnIndex = 6 Then
            Dim res As DialogResult
            With dlgDeltia
                .AddExtension = True
                .CheckFileExists = True
                .Filter = "PDF  files(.pdf)|*.pdf"
                .Multiselect = False
                .FileName = ""
                .Title = "Επιλέξτε αρχείο"
                res = .ShowDialog()
                If res = DialogResult.OK Then
                    dbPoints.CurrentRow.Cells(4).Tag = .FileName.ToString()
                    dbPoints.CurrentRow.Cells(4).Value = "ΝΑΙ"
                End If
            End With
            dbPoints_CellEndEdit(sender, e)
        ElseIf TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn And e.ColumnIndex = 7 Then
            dbPoints.CurrentRow.Cells(4).Tag = ""
            dbPoints.CurrentRow.Cells(4).Value = "ΟΧΙ"
            dbPoints_CellEndEdit(sender, e)
        End If
    End Sub

    Private Sub dbPoints_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dbPoints.CellDoubleClick
        If e.ColumnIndex = 4 And dbPoints.CurrentRow.Cells(4).Value = "ΝΑΙ" Then
            Process.Start(dbPoints.CurrentRow.Cells(8).Value)
        End If
    End Sub
End Class