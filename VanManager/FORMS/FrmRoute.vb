Imports System.Data.OleDb
Imports Janus.Windows.GridEX


Public Class FrmRoute
    Private ID As String
    Private RID As String
    Public Mode As Byte
    Private Sub FrmRoute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FillJanuscboCUS(cboMainCus)  ' Πελάτες
        Call FillJanuscboCUS(cboFCus)  ' Πελάτες
        Call FillJanuscboCUS(cboTCus)  ' Πελάτες
        Call FillJanuscboCOU(cboFCou)  ' Νομός
        Call FillJanuscboCOU(cboTCou)  ' Νομός
        Call FillJanuscboVEH(cboJVEH)  ' Αυτοκίνητα
        Call FillJanuscboDRV(cboJDRV)  ' Οδηγοί
        Call FillJanuscboSTI(cboSti)   ' Είδη
        Call FillTypeTempCombo()       ' Τύπος Φορτίου

        If Mode = FormMode.ViewRecord Then cmdSave.Enabled = False
        If Mode = FormMode.NewRecord Then cmdInvoice.Enabled = False
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            cmdInvoice.Enabled = True
            Dim Row1 As Janus.Windows.GridEX.GridEXRow
            Row1 = frmMain.GridMain.CurrentRow
            If RID <> Nothing Then
                ID = RID
            Else
                ID = Row1.Cells("ID").Value.ToString
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from ROUTES where id ='" + ID + "'", cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("code")) = False Then txtCode.Text = sdr.GetInt32(sdr.GetOrdinal("code"))
                If sdr.IsDBNull(sdr.GetOrdinal("Descr")) = False Then txtDescr.Text = sdr.GetString(sdr.GetOrdinal("Descr"))
                If sdr.IsDBNull(sdr.GetOrdinal("comments")) = False Then txtComments.Text = sdr.GetString(sdr.GetOrdinal("comments"))
                If sdr.IsDBNull(sdr.GetOrdinal("CusID")) = False Then cboMainCus.Value = sdr.GetGuid(sdr.GetOrdinal("CusID"))
                If sdr.IsDBNull(sdr.GetOrdinal("FromCusID")) = False Then cboFCus.Value = sdr.GetGuid(sdr.GetOrdinal("FromCusID"))
                If sdr.IsDBNull(sdr.GetOrdinal("FromCouID")) = False Then cboFCou.Value = sdr.GetGuid(sdr.GetOrdinal("FromCouID"))
                If sdr.IsDBNull(sdr.GetOrdinal("FromAreaID")) = False Then cboFArea.Value = sdr.GetGuid(sdr.GetOrdinal("FromAreaID"))
                If sdr.IsDBNull(sdr.GetOrdinal("ToCusID")) = False Then cboTCus.Value = sdr.GetGuid(sdr.GetOrdinal("ToCusID"))
                If sdr.IsDBNull(sdr.GetOrdinal("ToCouID")) = False Then cboTCou.Value = sdr.GetGuid(sdr.GetOrdinal("ToCouID"))
                If sdr.IsDBNull(sdr.GetOrdinal("ToAreaID")) = False Then cboTArea.Value = sdr.GetGuid(sdr.GetOrdinal("ToAreaID"))
                If sdr.IsDBNull(sdr.GetOrdinal("DrvID")) = False Then cboJDRV.Value = sdr.GetGuid(sdr.GetOrdinal("DrvID"))
                If sdr.IsDBNull(sdr.GetOrdinal("VehID")) = False Then cboJVEH.Value = sdr.GetGuid(sdr.GetOrdinal("VehID"))
                If sdr.IsDBNull(sdr.GetOrdinal("DrvPrice")) = False Then txtdrvPrice.Text = sdr.GetDecimal(sdr.GetOrdinal("DrvPrice"))
                If sdr.IsDBNull(sdr.GetOrdinal("temp")) = False Then cboTempType.Value = sdr.GetByte(sdr.GetOrdinal("temp"))
                If sdr.IsDBNull(sdr.GetOrdinal("cost")) = False Then txtCost.Text = sdr.GetDecimal(sdr.GetOrdinal("cost"))
                If sdr.IsDBNull(sdr.GetOrdinal("collection")) = False Then txtCollection.Text = sdr.GetDecimal(sdr.GetOrdinal("collection"))
                If sdr.IsDBNull(sdr.GetOrdinal("dtCreated")) = False Then dtDateCreated.Value = (sdr.GetDateTime(sdr.GetOrdinal("dtCreated")))
                If sdr.IsDBNull(sdr.GetOrdinal("kg")) = False Then txtKG.Text = sdr.GetDouble(sdr.GetOrdinal("kg"))
                If sdr.IsDBNull(sdr.GetOrdinal("pal")) = False Then txtPal.Text = sdr.GetInt32(sdr.GetOrdinal("pal"))
                If sdr.IsDBNull(sdr.GetOrdinal("kola")) = False Then txtKola.Text = sdr.GetInt32(sdr.GetOrdinal("kola"))
                If sdr.IsDBNull(sdr.GetOrdinal("invoiced")) = False Then chkInvoiced.Checked = IIf(sdr.GetBoolean(sdr.GetOrdinal("invoiced")) = True, 1, 0)
                If sdr.IsDBNull(sdr.GetOrdinal("stiID")) = False Then cboSti.Value = sdr.GetGuid(sdr.GetOrdinal("stiID"))
                If sdr.IsDBNull(sdr.GetOrdinal("paid")) = False Then chkPaid.Checked = IIf(sdr.GetBoolean(sdr.GetOrdinal("paid")) = True, 1, 0)
                If sdr.IsDBNull(sdr.GetOrdinal("ispartofsyg")) = False Then
                    If sdr.GetBoolean(sdr.GetOrdinal("ispartofsyg")) = True And Mode <> FormMode.ViewRecord Then
                        MessageBox.Show("Δεν μπορείτε να αλλάξετε δρομολόγιο που συμμετέχει σε συγκεντρωτικό τιμολόγιο.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Mode = FormMode.ViewRecord
                    End If

                End If
                sdr.Close()
            End If
        Else
            txtCode.Text = GetNewCode("ROUTES")
            ID = System.Guid.NewGuid.ToString()
            dtDateCreated.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            cmdInvoice.Enabled = False
        End If
        txtCode.ReadOnly = True
        cboMainCus.Select()
        Call FillHLPGrid()      ' Βοηθοί    
        Call FillPOIGrid()      ' Σημεία    
        'Εαν το δρομολόγιο έχει κοπεί σε τιμολόγιο δεν μπορεί να επεξεργαστει
        If chkInvoiced.Checked = True Then LockUnlockAllControls(Me, True)
        If Mode <> FormMode.ViewRecord Then
            GridPOI.Enabled = True : cmdSave.Enabled = True
            GridHLP.Enabled = True : txtdrvPrice.ReadOnly = False
            cmdInvoice.Enabled = True
        End If
        If Mode = FormMode.ViewRecord Then LockUnlockAllControls(Me, True)
        cmdExit.Enabled = True
    End Sub

    Private Sub FillTypeTempCombo()
        Dim _Active As New List(Of ActiveCB)

        _Active.Add(New ActiveCB With {.Name = "ΞΗΡΟ", .ID = 0})
        _Active.Add(New ActiveCB With {.Name = "ΨΥΞΗ", .ID = 1})
        _Active.Add(New ActiveCB With {.Name = "ΚΑΤΑΨΥΞΗ", .ID = 2})
        _Active.Add(New ActiveCB With {.Name = "ΜΕΤΑΚΟΜΙΣΗ", .ID = 3})

        cboTempType.DataSource = _Active
        cboTempType.DisplayMember = "name"
        cboTempType.ValueMember = "ID"
        cboTempType.SettingsKey = "id"

    End Sub

    Private Sub cboFCou_ValueChanged(sender As Object, e As EventArgs) Handles cboFCou.ValueChanged
        If Not cboFCou.SelectedItem Is Nothing Then FillJanuscboAREA(cboFArea, cboFCou.SelectedItem("id").ToString, "F")
    End Sub

    Private Sub cboTCou_ValueChanged(sender As Object, e As EventArgs) Handles cboTCou.ValueChanged
        If Not cboTCou.SelectedItem Is Nothing Then FillJanuscboAREA(cboTArea, cboTCou.SelectedItem("id").ToString, "T")
    End Sub
    ' Βοηθοί
    Public Sub FillHLPGrid()
        Dim sql As String
        Dim table As New DataTable
        Dim bs1 As New BindingSource
        Dim adapter As New OleDb.OleDbDataAdapter
        table.Columns.Clear()
        GridHLP.DataSource = Nothing
        GridHLP.VisualStyle = VisualStyle.Office2010
        table.Clear()
        If Mode = FormMode.ViewRecord Or Mode = FormMode.EditRecord Then
            sql = "select id,hlpid,name,afm,ADR,Checked,Price from vw_HLP_ROUTES where routeid = '" & ID & "' order by name"
        Else
            sql = "select id,name,afm,ADR from vw_HLP order by name"
        End If

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(table)
        If Mode = FormMode.NewRecord Then
            Dim newColumn As New Data.DataColumn("Checked", GetType(Boolean))
            newColumn.DefaultValue = "0"
            table.Columns.Add(newColumn)
            Dim newColumn2 As New Data.DataColumn("Price", GetType(Decimal))
            newColumn2.DefaultValue = "0.00"
            table.Columns.Add(newColumn2)
        End If
        bs1.DataSource = table
        GridHLP.SetDataBinding(table, "")
        GridHLP.RetrieveStructure()
        GridHLP.GroupByBoxVisible = False
        With GridHLP.RootTable
            .Columns("ID").Visible = False
            If Mode <> FormMode.NewRecord Then .Columns("hlpID").Visible = False
            .Columns("name").Caption = "Επωνυμία" : .Columns("name").EditType = EditType.NoEdit : .Columns("name").Width = 150
            .Columns("afm").Caption = "ΑΦΜ" : .Columns("afm").EditType = EditType.NoEdit : .Columns("afm").Width = 70
            .Columns("ADR").Caption = "Διεύθυνση" : .Columns("ADR").EditType = EditType.NoEdit
            .Columns("Price").Caption = "Τιμή" : .Columns("Price").Width = 50
            .Columns("Checked").Caption = "" : .Columns("Checked").Width = 20 : .Columns("Checked").Position = 1
        End With

    End Sub
    ' Σημεία
    Public Sub FillPOIGrid()
        Dim sql As String
        Dim tbPOI As New DataTable
        Dim bs1 As New BindingSource
        Dim adapter As New OleDb.OleDbDataAdapter
        tbPOI.Columns.Clear()
        GridPOI.DataSource = Nothing
        GridPOI.VisualStyle = VisualStyle.Office2010
        tbPOI.Clear()
        sql = "select id,routeid,code,arDelt,address,ar, deliveryNum, Lastname, deliveryPrice,comments,deltPath from vw_POI where routeID='" & ID & "'"
        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(tbPOI)
        bs1.DataSource = tbPOI
        GridPOI.SetDataBinding(tbPOI, "")
        GridPOI.RetrieveStructure()
        GridPOI.GroupByBoxVisible = False
        Dim ButtonCol As New Janus.Windows.GridEX.GridEXColumn
        ButtonCol.Key = "PDF"
        ButtonCol.ButtonText = "PDF"
        ButtonCol.ButtonDisplayMode = CellButtonDisplayMode.Always 'The button is visible even if the row is not selected
        ButtonCol.ButtonStyle = ButtonStyle.ButtonCell
        ButtonCol.Width = 40

        With GridPOI.RootTable
            .Columns.Add(ButtonCol)
            .Columns("id").Visible = False
            .Columns("routeid").Visible = False
            .Columns("code").Visible = False
            .Columns("arDelt").Caption = "Αρ. Δελτίου" : .Columns("arDelt").Width = 70
            .Columns("address").Caption = "Διεύθυνση" : .Columns("address").Width = 150
            .Columns("ar").Caption = "Αριθμός" : .Columns("ar").Width = 50
            .Columns("deliverynum").Caption = "Αρ. Αντικαταβολής" : .Columns("deliverynum").Width = 120
            .Columns("lastname").Caption = "Έπ. Πελάτη" : .Columns("lastname").Width = 120
            .Columns("deliveryprice").Caption = "Ποσό" : .Columns("deliveryprice").Width = 80
            .Columns("comments").Caption = "Σχόλια" : .Columns("comments").Width = 100
            .Columns("deltpath").Caption = "Αρχείο" : .Columns("deltpath").Width = 140
        End With
        'Γραμμή Συνόλων
        GridPOI.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        GridPOI.RootTable.Columns("deliveryprice").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
        GridPOI.RootTable.Columns("deliveryprice").TotalFormatString = "c" 'Currency

    End Sub

    Private Sub cmdSaveDelt_Click(sender As Object, e As EventArgs) Handles cmdSaveDelt.Click
        Dim sSQL As String
        Try
            If txtArDelt.Text.Length = 0 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            ' Καταχώρηση Δεδομένων
            sSQL = "INSERT INTO POI ([code],[routeID],[ardelt],[address],[Ar],[comments],[deltPath], deliveryNum, Lastname, deliveryPrice) " &
                   "values (" & GetNewCode("POI") & ", " &
                                "'" & ID & "', " &
                                toSQLValueJ(txtArDelt) & ", " &
                                toSQLValueJ(txtAdress) & ", " &
                                toSQLValueJ(txtAr) & ", " &
                                toSQLValueJ(txtPComments) & ", " &
                                toSQLValueJ(txtdeltPath) & ", " &
                                toSQLValueJ(txtDelivNum) & ", " &
                                toSQLValueJ(txtDelivLastname) & ", " &
                                Replace(txtDelivPrice.Value, ",", ".") & ")"
            Using oCmd As New OleDbCommand(sSQL, cn)
                oCmd.ExecuteNonQuery()
                FillPOIGrid()
                txtArDelt.Text = "" : txtAdress.Text = "" : txtAr.Text = "" : txtDelivNum.Text = ""
                txtDelivLastname.Text = "" : txtDelivPrice.Value = 0 : txtPComments.Text = ""
                txtdeltPath.Text = ""
                txtArDelt.Select()
            End Using
            ' Σύνολο
            txtCollection.Value = GridPOI.GetRow(GridPOI.RecordCount).Cells("deliveryprice").Value
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

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
            If res = DialogResult.OK Then txtdeltPath.Text = .FileName.ToString() ': cmdDelAttach.Enabled = True
        End With
    End Sub

    Private Sub cmdDet_Click(sender As Object, e As EventArgs) Handles cmdDet.Click
        txtdeltPath.Text = ""
    End Sub

    Private Sub GridPOI_ColumnButtonClick(sender As Object, e As ColumnActionEventArgs) Handles GridPOI.ColumnButtonClick
        If e.Column.Key = "PDF" Then
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
                    e.Column.GridEX.CurrentRow.Cells("deltpath").Value = .FileName.ToString()
                    GridPOI_CellValueChanged(sender, e)
                End If
            End With
        End If
    End Sub

    Private Sub GridPOI_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles GridPOI.CellValueChanged

    End Sub
    Private Sub GridPOI_DeletingRecord(sender As Object, e As RowActionCancelEventArgs) Handles GridPOI.DeletingRecord
        Dim sSQL As String
        Try
            If MessageBox.Show("Να διαγραφεί η επιλεγμένη εγγραφή?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                'Διαγραφή από τιμολόγιο πρώτα
                sSQL = "DELETE INVD where Poiid='" & e.Row.Cells("id").Value.ToString & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                'Διαγραφή σημείων
                sSQL = "DELETE POI where id='" & e.Row.Cells("id").Value.ToString & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
            Else
                e.Cancel = True
            End If
        Catch myOLEDBException As OleDbException 'ole db exception
            e.Cancel = True
            MessageBox.Show(myOLEDBException.ErrorCode.ToString + vbCrLf + myOLEDBException.Message.ToString + vbCrLf + myOLEDBException.Source.ToString)
        End Try
    End Sub

    Private Sub cboMainCus_KeyDown(sender As Object, e As KeyEventArgs) Handles cboMainCus.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmCus.Owner = Me
            frmCus.CTRLJannus = cboMainCus
            Me.Enabled = False
            frmCus.Mode = FormMode.NewRecord
            frmCus.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboMainCus.SelectedItem Is Nothing Then
                frmCus.Owner = Me
                frmCus.CTRLJannus = cboMainCus
                Me.Enabled = False
                frmCus.Mode = FormMode.EditRecord
                frmCus.Show()
            End If
        End If
    End Sub

    Private Sub cmdSave_Click_1(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String

        Try
            If cboMainCus.Text.Length = 0 Or cboJDRV.Text.Length = 0 Or cboJVEH.Text.Length = 0 Or
               cboFCus.Text.Length = 0 Or cboTCus.Text.Length = 0 Or cboFCou.Text.Length = 0 Or
               cboTCou.Text.Length = 0 Or cboFArea.Text.Length = 0 Or cboTArea.Text.Length = 0 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE ROUTES set " &
                   "code =  " & toSQLValueJ(txtCode, True) & "," &
                   "dtCreated = " & "'" & Format(dtDateCreated.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                   "DrvID = " & boSQLValuej(cboJDRV) & ", " &
                   "VehID = " & boSQLValuej(cboJVEH) & ", " &
                   "CusID = " & boSQLValuej(cboMainCus) & ", " &
                   "FromCusID = " & boSQLValuej(cboFCus) & ", " &
                   "ToCusID = " & boSQLValuej(cboTCus) & ", " &
                   "FromCouID = " & boSQLValuej(cboFCou) & "," &
                   "ToCouID = " & boSQLValuej(cboTCou) & "," &
                   "FromAreaID = " & boSQLValuej(cboFArea) & "," &
                   "ToAreaID = " & boSQLValuej(cboTArea) & "," &
                   "comments = " & toSQLValueJ(txtComments) & "," &
                   "DrvPrice = " & Replace(txtdrvPrice.Value, ",", ".") & "," &
                   "cost = " & Replace(txtCost.Value, ",", ".") & "," &
                   "collection = " & Replace(txtCollection.Value, ",", ".") & "," &
                   "temp = " & boSQLValuej(cboTempType) & "," &
                   "Descr = " & toSQLValueJ(txtDescr) & "," &
                   "kg = " & Replace(txtKG.Value, ",", ".") & "," &
                   "pal = " & txtPal.Value & "," &
                   "stiID = " & boSQLValuej(cboSti) & "," &
                   "paid = " & IIf(chkPaid.Checked = True, 1, 0) & "," &
                   "kola = " & txtKola.Value &
                    " where id = '" & ID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    'frmMain.FillJanusGrid("ROUTES")
                End Using

                'Αποθήκευση Βοηθών αν υπάρχουν
                Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
                Dim row As Janus.Windows.GridEX.GridEXRow
                checkedRows = GridHLP.GetRows
                For Each row In checkedRows
                    sSQL = "If EXISTS(SELECT * FROM HLP_ROUTES   where routeid = '" & ID & "' and hlpid = '" & row.Cells(1).Value.ToString & "' )" &
                        " UPDATE HLP_ROUTES SET " &
                           "[hlpid] = '" & row.Cells(1).Value.ToString & "'," &
                           "[checked] = " & IIf(row.Cells(5).Value = "True", 1, 0) & "," &
                           "[Price] = " & Replace(row.Cells(6).Value, ",", ".") & " where routeid = '" & ID & "' and hlpid = '" & row.Cells(1).Value.ToString & "'" &
                     " Else " &
                        "INSERT INTO HLP_ROUTES ([routeid],[hlpid],[checked],[Price]) " &
                        "values (" & "'" & ID.ToString & "'," &
                        "'" & row.Cells(1).Value.ToString & "'," & IIf(row.Cells(5).Value = "True", 1, 0) & "," &
                         "'" & Replace(row.Cells(6).Value, ",", ".") & "')"
                    Using oCmd As New OleDbCommand(sSQL, cn)
                        oCmd.ExecuteNonQuery()
                    End Using
                Next
                ' Ενημέρωση ποσόυ εσόδου 
                sSQL = "UPDATE ES set " &
                        "dtCreated = '" & Format(dtDateCreated.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                        "price = " & Replace(txtCost.Value, ",", ".") &
                        " where routeid = '" & ID & "'"

                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Το δρομολόγιο αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If chkInvoiced.Checked = True Then
                    If MessageBox.Show("Να γίνει επανεκτύπωση του τιμολογίου?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        frmInvoice.Mode = FormMode.EditRecord
                        frmInvoice.RouteID = ID.ToString
                        frmInvoice.Show()
                    End If
                Else
                    If MessageBox.Show("Να εκδοθεί τιμολόγιο?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        frmInvoice.Mode = FormMode.NewRecord
                        frmInvoice.RouteID = ID.ToString
                        frmInvoice.Show()
                    End If
                End If
            ElseIf Mode = FormMode.NewRecord Then
                'Καταχώρηση Δεδομένων
                sSQL = "INSERT INTO ROUTES ([id],[code],[dtCreated],[DrvID],[VehID],[CusID],[FromCusID],[ToCusID],[FromCouID],[ToCouID],[FromAreaID],[ToAreaID] " &
               ",[comments],[DrvPrice],[cost],[collection],[temp],[Descr],[kg],[pal],[kola],[stiid],[Paid]) " &
               "values (" & "'" & ID.ToString & "'," &
                            toSQLValueJ(txtCode, True) & ", " &
                      "'" & Format(dtDateCreated.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                            boSQLValuej(cboJDRV) & ", " &
                            boSQLValuej(cboJVEH) & ", " &
                            boSQLValuej(cboMainCus) & ", " &
                            boSQLValuej(cboFCus) & ", " &
                            boSQLValuej(cboTCus) & ", " &
                            boSQLValuej(cboFCou) & ", " &
                            boSQLValuej(cboTCou) & ", " &
                            boSQLValuej(cboFArea) & ", " &
                            boSQLValuej(cboTArea) & ", " &
                            toSQLValueJ(txtComments) & ", " &
                            Replace(txtdrvPrice.Value, ",", ".") & ", " &
                            Replace(txtCost.Value, ",", ".") & ", " &
                            Replace(txtCollection.Value, ",", ".") & ", " &
                            boSQLValuej(cboTempType) & ", " &
                            toSQLValueJ(txtDescr) & ", " &
                            Replace(txtKG.Value, ",", ".") & ", " &
                            txtPal.Value & ", " &
                            txtKola.Value & ", " &
                            boSQLValuej(cboSti) & ", " &
                            IIf(chkPaid.Checked = True, 1, 0) & ")"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    ' frmMain.FillJanusGrid("ROUTES")
                End Using
                'Αποθήκευση Βοηθών αν υπάρχουν
                Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
                Dim row As Janus.Windows.GridEX.GridEXRow
                checkedRows = GridHLP.GetRows
                For Each row In checkedRows

                    sSQL = "INSERT INTO HLP_ROUTES ([routeid],[hlpid],[checked],[Price]) " &
                            "values (" & "'" & ID.ToString & "'," &
                            "'" & row.Cells(0).Value.ToString & "'," & IIf(row.Cells(4).Value = "True", 1, 0) & "," &
                             "'" & Replace(row.Cells(5).Value, ",", ".") & "')"
                    Using oCmd As New OleDbCommand(sSQL, cn)
                        oCmd.ExecuteNonQuery()
                    End Using
                Next
                ' Αποθήκευση  ποσόυ εσόδου 
                sSQL = "INSERT INTO ES ([code],[dtCreated],[price],[routeid]) " &
                              "values (" & GetNewCode("ES") & ", " &
                                     "'" & Format(dtDateCreated.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                                           Replace(txtCost.Value, ",", ".") & "," &
                                           "'" & ID & "')"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Το δρομολόγιο αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If MessageBox.Show("Να εκδοθεί τιμολόγιο?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    frmInvoice.Mode = FormMode.NewRecord
                    frmInvoice.RouteID = ID.ToString
                    frmInvoice.Show()
                End If
                Call ClearAllControls(Me)
                txtCode.Text = GetNewCode("ROUTES")
                ID = System.Guid.NewGuid.ToString()
                Call FillHLPGrid()      ' Βοηθοί    
                Call FillPOIGrid()      ' Σημεία  
                'cmdInvoice.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdInvoice_Click(sender As Object, e As EventArgs) Handles cmdInvoice.Click
        If chkInvoiced.Checked = True Then
            If MessageBox.Show("Να γίνει επανεκτύπωση του τιμολογίου?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                frmInvoice.Mode = FormMode.EditRecord
                frmInvoice.RouteID = ID.ToString
                frmInvoice.Show()
            End If
        Else
            If MessageBox.Show("Να εκδοθεί τιμολόγιο?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If MessageBox.Show("Το τιμολόγιο είναι χειρόγραφο?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    frmInvoice.IsHand = True
                End If
                frmInvoice.Mode = FormMode.NewRecord
                frmInvoice.RouteID = ID.ToString
                frmInvoice.Show()
            End If
        End If
    End Sub

    Private Sub cboFCou_KeyDown(sender As Object, e As KeyEventArgs) Handles cboFCou.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmCou.Owner = Me
            frmCou.CTRLJannus = cboFCou
            Me.Enabled = False
            frmCou.Mode = FormMode.NewRecord
            frmCou.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboFCou.SelectedItem Is Nothing Then
                frmCou.Owner = Me
                frmCou.CTRLJannus = cboFCou
                Me.Enabled = False
                frmCou.Mode = FormMode.EditRecord
                frmCou.Show()
            End If
        End If

    End Sub

    Private Sub cboTCou_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTCou.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmCou.Owner = Me
            frmCou.CTRLJannus = cboTCou
            Me.Enabled = False
            frmCou.Mode = FormMode.NewRecord
            frmCou.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboTCou.SelectedItem Is Nothing Then
                frmCou.Owner = Me
                frmCou.CTRLJannus = cboTCou
                Me.Enabled = False
                frmCou.Mode = FormMode.EditRecord
                frmCou.Show()
            End If
        End If

    End Sub

    Private Sub cboFArea_KeyDown(sender As Object, e As KeyEventArgs) Handles cboFArea.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmArea.Owner = Me
            frmArea.CTRLJannus = cboFArea
            Me.Enabled = False
            frmArea.Mode = FormMode.NewRecord
            frmArea.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboFArea.SelectedItem Is Nothing Then
                frmArea.Owner = Me
                frmArea.CTRLJannus = cboFArea
                Me.Enabled = False
                frmArea.Mode = FormMode.EditRecord
                frmArea.Show()
            End If
        End If
    End Sub

    Private Sub cboTArea_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTArea.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmArea.Owner = Me
            frmArea.CTRLJannus = cboTArea
            Me.Enabled = False
            frmArea.Mode = FormMode.NewRecord
            frmArea.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboTArea.SelectedItem Is Nothing Then
                frmArea.Owner = Me
                frmArea.CTRLJannus = cboTArea
                Me.Enabled = False
                frmArea.Mode = FormMode.EditRecord
                frmArea.Show()
            End If
        End If
    End Sub

    Private Sub cboFCus_KeyDown(sender As Object, e As KeyEventArgs) Handles cboFCus.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmCus.Owner = Me
            frmCus.CTRLJannus = cboFCus
            Me.Enabled = False
            frmCus.Mode = FormMode.NewRecord
            frmCus.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboFCus.SelectedItem Is Nothing Then
                frmCus.Owner = Me
                frmCus.CTRLJannus = cboFCus
                Me.Enabled = False
                frmCus.Mode = FormMode.EditRecord
                frmCus.Show()
            End If
        End If
    End Sub

    Private Sub cboTCus_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTCus.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmCus.Owner = Me
            frmCus.CTRLJannus = cboTCus
            Me.Enabled = False
            frmCus.Mode = FormMode.NewRecord
            frmCus.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboTCus.SelectedItem Is Nothing Then
                frmCus.Owner = Me
                frmCus.CTRLJannus = cboTCus
                Me.Enabled = False
                frmCus.Mode = FormMode.EditRecord
                frmCus.Show()
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

    Private Sub cboJVEH_KeyDown(sender As Object, e As KeyEventArgs) Handles cboJVEH.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmVeh.Owner = Me
            frmVeh.CTRLJannus = cboJVEH
            Me.Enabled = False
            frmVeh.Mode = FormMode.NewRecord
            frmVeh.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboJVEH.SelectedItem Is Nothing Then
                frmVeh.Owner = Me
                frmVeh.CTRLJannus = cboJVEH
                Me.Enabled = False
                frmVeh.Mode = FormMode.EditRecord
                frmVeh.Show()
            End If
        End If
    End Sub

    Private Sub cboSti_KeyDown(sender As Object, e As KeyEventArgs) Handles cboSti.KeyDown
        If e.KeyCode = Keys.Insert Then
            frmSti.Owner = Me
            frmSti.CTRLJannus = cboSti
            Me.Enabled = False
            frmSti.Mode = FormMode.NewRecord
            frmSti.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            If Not cboSti.SelectedItem Is Nothing Then
                frmSti.Owner = Me
                frmSti.CTRLJannus = cboSti
                Me.Enabled = False
                frmSti.Mode = FormMode.EditRecord
                frmSti.Show()
            End If
        End If
    End Sub
    Private Sub GridPOI_LostFocus(sender As Object, e As EventArgs) Handles GridPOI.LostFocus
        ' Σύνολο
        txtCollection.Value = GridPOI.GetRow(GridPOI.RecordCount).Cells("deliveryprice").Value
    End Sub

    Private Sub cmdInsertHlp_Click(sender As Object, e As EventArgs) Handles cmdInsertHlp.Click
        Dim command As New OleDbCommand("SELECT id FROM HLP", cn)
        Dim reader As OleDbDataReader = command.ExecuteReader()
        Try
            While reader.Read()
                'Καταχώρηση γραμμών
                Using oCmd As New OleDbCommand("FixRouteHlps", cn)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@@HlpID", reader(0).ToString())
                    oCmd.Parameters.AddWithValue("@@RouteID", ID)
                    oCmd.ExecuteNonQuery()
                End Using
            End While
            reader.Close()
            Call FillHLPGrid()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Sub cboFCus_ValueChanged(sender As Object, e As EventArgs) Handles cboFCus.ValueChanged
        If Not cboFCus.SelectedItem Is Nothing Then
            Dim cmd As OleDbCommand = New OleDbCommand("Select COUID,AREAID from CUS where id = " + boSQLValuej(cboFCus), cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("COUID")) = False Then cboFCou.Value = sdr.GetGuid(sdr.GetOrdinal("COUID"))
                If sdr.IsDBNull(sdr.GetOrdinal("AREAID")) = False Then cboFArea.Value = sdr.GetGuid(sdr.GetOrdinal("AREAID"))
            End If
            sdr.Close()
        End If
    End Sub

    Private Sub cboTCus_ValueChanged(sender As Object, e As EventArgs) Handles cboTCus.ValueChanged
        If Not cboTCus.SelectedItem Is Nothing Then
            Dim cmd As OleDbCommand = New OleDbCommand("Select COUID,AREAID from CUS where id = " + boSQLValuej(cboTCus), cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("COUID")) = False Then cboTCou.Value = sdr.GetGuid(sdr.GetOrdinal("COUID"))
                If sdr.IsDBNull(sdr.GetOrdinal("AREAID")) = False Then cboTArea.Value = sdr.GetGuid(sdr.GetOrdinal("AREAID"))
            End If
            sdr.Close()
        End If

    End Sub

    Private Sub cmdTransferRight_Click(sender As Object, e As EventArgs) Handles cmdTransferRight.Click
        cboTCus.Value = cboFCus.Value
        cboTCou.Value = cboFCou.Value
        cboTArea.Value = cboFArea.Value
    End Sub

    Private Sub GridPOI_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles GridPOI.CellUpdated
        Dim sSQL As String
        If chkInvoiced.Checked = True Then
            MessageBox.Show("Σε τιμολογημένο δρομολόγιο δεν επιτρέπεται καμμία αλλαγή", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            ' Καταχώρηση Δεδομένων
            sSQL = "UPDATE POI SET " &
                "[ardelt] = '" & e.Column.GridEX.CurrentRow.Cells("arDelt").Value & "'," &
                "[address] = '" & e.Column.GridEX.CurrentRow.Cells("address").Value & "'," &
                "[ar] = '" & e.Column.GridEX.CurrentRow.Cells("ar").Value & "'," &
                "[comments] = '" & e.Column.GridEX.CurrentRow.Cells("comments").Value & "'," &
                "[deltPath] = '" & e.Column.GridEX.CurrentRow.Cells("deltpath").Value & "'," &
                "[deliverynum] = '" & e.Column.GridEX.CurrentRow.Cells("deliverynum").Value & "'," &
                "[lastname] = '" & e.Column.GridEX.CurrentRow.Cells("lastname").Value & "'," &
                "[deliveryprice] = '" & Replace(e.Column.GridEX.CurrentRow.Cells("deliveryprice").Value, ",", ".") & "'" &
                "where routeid='" & e.Column.GridEX.CurrentRow.Cells("routeid").Value.ToString & "'" &
                " and id = '" & e.Column.GridEX.CurrentRow.Cells("id").Value.ToString & "'"
            Using oCmd As New OleDbCommand(sSQL, cn)
                oCmd.ExecuteNonQuery()
            End Using
            ' Σύνολο
            txtCollection.Value = GridPOI.GetRow(GridPOI.RecordCount).Cells("deliveryprice").Value
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub
    Public WriteOnly Property RouteID As String
        Set(value As String)
            RID = value
        End Set
    End Property


End Class