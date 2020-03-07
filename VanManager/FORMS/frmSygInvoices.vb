Imports System.Data.OleDb
Imports Janus.Windows.GridEX

Public Class frmSygInvoices
    Private dtd As DataTable
    Private ID As String
    Public Mode As Byte
    Private bs1 As New BindingSource
    Private adapter As New OleDb.OleDbDataAdapter
    Private mContextMenuColumn As GridEXColumn
    Private fieldChoser As frmFieldChooser
    Private Sub frmSygInvoices_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call FillJanuscboCUS(cboMainCus, "SYG = 1")  ' Πελάτες
        Call LoadLayout()
        Call InitialiseDataset()
        '1η Μέρα του Μήνα
        dtFromDate.Value = New DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, 1)
        'Τελευταία Μέρα του Μήνα
        dtToDate.Value = New Date(System.DateTime.Now.Year, System.DateTime.Now.Month, Date.DaysInMonth(System.DateTime.Now.Year, System.DateTime.Now.Month))
    End Sub
    Private Sub InitialiseDataset()
        Dim C1 As DataColumn
        Dim C2 As DataColumn
        Dim C3 As DataColumn
        Dim C4 As DataColumn
        Dim C5 As DataColumn

        dtd = New DataTable
        C1 = New DataColumn("C1", Type.GetType("System.Guid"))
        C2 = New DataColumn("C2", Type.GetType("System.Double"))
        C3 = New DataColumn("C3", Type.GetType("System.Double"))
        C4 = New DataColumn("C4", Type.GetType("System.Double"))
        C5 = New DataColumn("C5", Type.GetType("System.String"))

        dtd.Columns.Add(C1)
        dtd.Columns.Add(C2)
        dtd.Columns.Add(C3)
        dtd.Columns.Add(C4)
        dtd.Columns.Add(C5)

    End Sub
    Private Sub LoadLayout()
        Dim strLayoutPath As String
        strLayoutPath = Application.StartupPath & "\LayOuts\GridMainSYG.gxl"
        Dim fi As System.IO.FileInfo = New System.IO.FileInfo(strLayoutPath)
        If fi.Exists Then
            Try
                Dim stream As System.IO.FileStream = New System.IO.FileStream(fi.FullName, IO.FileMode.Open)
                GridMain.LoadLayoutFile(stream)
                stream.Close()
            Catch exc As Exception
                MessageBox.Show(exc.Message)
            End Try
        End If
    End Sub
    Private Sub cboMainCus_ValueChanged(sender As Object, e As EventArgs) Handles cboMainCus.ValueChanged
        grpSearch.Enabled = True
        Call FillJanusGridWithRecords()
    End Sub
    Private Sub FillJanusGridWithRecords()
        Dim sql As String
        Dim table As New DataTable
        table.Columns.Clear()
        GridMain.DataSource = Nothing
        table.Clear()
        If Not cboMainCus.SelectedItem Is Nothing Then
            adapter.SelectCommand = New OleDb.OleDbCommand("select * from vw_ROUTES WHERE INVOICED = 0 AND MAINCUSID = " & boSQLValuej(cboMainCus) &
                " and dtcreated >= '" & Format(dtFromDate.Value, "yyyy/MM/dd 00:00:00") & "' and dtcreated <= '" & Format(dtToDate.Value, "yyyy/MM/dd 23:59:59") & "'", cn)
            adapter.Fill(table)
            Dim newColumn As New Data.DataColumn("Checked", GetType(Boolean))
            newColumn.DefaultValue = False
            table.Columns.Add(newColumn)
            bs1.DataSource = table
            GridMain.SetDataBinding(table, "")
            GridMain.RetrieveStructure()
            GridMain.FilterMode = FilterMode.Automatic
            GridMain.FilterRowButtonStyle = FilterRowButtonStyle.ConditionOperatorDropDown
            With GridMain.RootTable
                .AllowEdit = InheritableBoolean.True
                .Columns("Checked").Position = 1
                .Columns("Checked").UseHeaderSelector = True
                .Columns("id").Visible = False
            End With
            Call LoadLayout()
            For Each column As DataColumn In table.Columns
                Select Case column.DataType.Name.ToString()
                    Case "Decimal"
                        'Γραμμή Συνόλων
                        GridMain.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
                        GridMain.RootTable.Columns(column.ColumnName).AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                        GridMain.RootTable.Columns(column.ColumnName).TotalFormatString = "c" 'Currency
                        GridMain.RootTable.Columns(column.ColumnName).TextAlignment = TextAlignment.Far
                        GridMain.TotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
                        GridMain.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
                        GridMain.TotalRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                End Select
                If column.ColumnName = "Checked" Then
                    GridMain.RootTable.Columns(column.ColumnName).EditType = EditType.CheckBox
                End If
            Next
        End If
    End Sub
    Private Sub cmdInvoice_Click(sender As Object, e As EventArgs) Handles cmdInvoice.Click
        Try
            If MessageBox.Show("Να εκδοθεί τιμολόγιο?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If MessageBox.Show("Το τιμολόγιο είναι χειρόγραφο?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    frmInvoice.IsHand = True
                End If

                Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
                Dim Am As Double
                Dim PARASTS As New List(Of String)
                Dim RouteIds As String
                Dim i As Integer, g As Integer
                Dim group As GridEXGroup
                Dim column As New GridEXColumn
                Dim dr As DataRow
                Dim JGroups As New List(Of String)
                For j = 0 To GridMain.RootTable.Groups.Count - 1
                    JGroups.Add(GridMain.RootTable.Groups.Item(j).Column.DataMember)
                Next
                GridMain.RootTable.Groups.Clear()
                checkedRows = GridMain.GetRows
                For Each row In checkedRows
                    If row.Cells("checked").Value = True Then
                        dr = dtd.NewRow()
                        dr("C1") = row.Cells("id").Value
                        dr("C2") = row.Cells("cost").Value
                        dr("C3") = row.Cells("fpacost").Value
                        dr("C4") = row.Cells("gentot").Value
                        dr("C5") = ConvertNumToWords.ConvertNumInGR(row.Cells("gentot").Value)
                        dtd.Rows.Add(dr)
                        PARASTS.Add(row.Cells("id").Value.ToString)
                        RouteIds = RouteIds & IIf(RouteIds <> "", ",", "") & "'" & row.Cells("id").Value.ToString & "'"
                        i = i + 1
                    End If
                Next

                'Add Groups Again
                For Each grp As String In JGroups
                    column = GridMain.RootTable.Columns(grp.ToString)
                    group = New GridEXGroup(column, SortOrder.Ascending)
                    'group.HeaderCaption = "Πελάτης"
                    group.GroupPrefix = ""
                    group.GroupFormatString = ""
                    GridMain.RootTable.Groups.Add(group)
                Next
                With GridMain.RootTable
                    .AllowEdit = InheritableBoolean.True
                    .Columns("Checked").Position = 1
                    .Columns("Checked").UseHeaderSelector = True
                End With
                If RouteIds Is Nothing Then
                    MessageBox.Show(" Δεν έχετε επιλέξει δρομολόγια.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                frmInvoice.Mode = FormMode.NewRecord
                frmInvoice.RouteID = RouteIds
                frmInvoice.RouteIDs = PARASTS
                frmInvoice.DTINF = dtd
                frmInvoice.Show()
            End If
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub GridMain_MouseUp(sender As Object, e As MouseEventArgs) Handles GridMain.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            If GridMain.HitTest(e.X, e.Y) = GridArea.ColumnHeader Then
                Dim colClicked As GridEXColumn = GridMain.ColumnFromPoint(e.X, e.Y)
                If Not colClicked Is Nothing Then
                    Me.ShowHeaderMenu(colClicked)
                End If
            End If
        End If
    End Sub
    Private Sub ShowHeaderMenu(ByVal column As GridEXColumn)

        mContextMenuColumn = column
        cmdRenameThisColumn.Control.Text = mContextMenuColumn.Caption
        If GridMain.View <> Janus.Windows.GridEX.View.TableView Or GridMain.RootTable.CellLayoutMode = CellLayoutMode.UseColumnSets Then
            cmdFieldChooser.IsEnabled = False
        Else
            cmdFieldChooser.IsEnabled = True
        End If
        If mContextMenuColumn.Table.CellLayoutMode = CellLayoutMode.UseColumnSets Then
            Me.cmdRemoveThisColumn.IsEnabled = False
        Else
            Me.cmdRemoveThisColumn.IsEnabled = True
        End If
        If GridMain.IsFieldChooserVisible() Then
            Me.comManager.Commands("cmdFieldChooser").Checked = Janus.Windows.UI.InheritableBoolean.True
        Else
            Me.comManager.Commands("cmdFieldChooser").Checked = Janus.Windows.UI.InheritableBoolean.False
        End If
        Me.cmHeader.Show(GridMain)
        mContextMenuColumn = Nothing
    End Sub
    Private Sub OnRemoveThisColumnCommand()
        mContextMenuColumn.Visible = False
    End Sub
    Private Sub OnFieldChooserCommand()
        If fieldChoser Is Nothing OrElse fieldChoser.IsDisposed Then
            fieldChoser = New frmFieldChooser()
            fieldChoser.Show(Me.GridMain, Me.FindForm())
        Else
            fieldChoser.Close()
            fieldChoser.Dispose()
            fieldChoser = Nothing
        End If
    End Sub
    Private Sub comManager_CommandControlValueChanged(sender As Object, e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles comManager.CommandControlValueChanged
        If e.Command.Key = "cmdRenameThisColumn" Then
            mContextMenuColumn.Caption = cmdRenameThisColumn.Control.Text
        End If
    End Sub

    Private Sub comManager_CommandClick(sender As Object, e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles comManager.CommandClick
        Select Case e.Command.Key
            Case "cmdRemoveThisColumn" : OnRemoveThisColumnCommand()
            Case "cmdFieldChooser" : OnFieldChooserCommand()
            Case "cmdSaveLayout" : SaveGrid()
            Case Else
        End Select
    End Sub
    Private Sub SaveGrid()
        Dim strLayoutPath As String
        strLayoutPath = Application.StartupPath & "\LayOuts\GridMainSYG.gxl"
        Try
            Dim stream As System.IO.FileStream = New System.IO.FileStream(strLayoutPath, IO.FileMode.Create)
            GridMain.SaveLayoutFile(stream)
            stream.Close()
            MessageBox.Show("Η Όψη αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch

        End Try
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Call FillJanusGridWithRecords()
    End Sub
End Class
