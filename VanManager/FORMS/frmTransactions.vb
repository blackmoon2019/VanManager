Imports System.Data.OleDb
Imports Janus.Windows.GridEX
Imports Janus.Windows.UI.CommandBars

Public Class frmTransactions
    Private dtd As DataTable
    Private ID As String
    Public Mode As Byte
    Private TB As DataTable
    Private bs1 As New BindingSource
    Private adapter As New OleDb.OleDbDataAdapter
    Private mContextMenuColumn As GridEXColumn
    Private fieldChoser As frmFieldChooser
    Private ColWithoutSelection As String
    Private ColWithSelection As String
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
        strLayoutPath = Application.StartupPath & "\LayOuts\GridMainTRANS.gxl"
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
        'grpSearch.Enabled = True
        Call FillJanusGridWithRecords()
    End Sub
    Private Sub FillJanusGridWithRecords()
        Dim sql As String
        Dim table As New DataTable
        table.Columns.Clear()
        GridMain.DataSource = Nothing
        table.Clear()
        adapter.SelectCommand = New OleDb.OleDbCommand("SELECT  '1' as sKey, id ,(SELECT NAME FROM SDT_TYPES WHERE CODE = 1) AS InvType ,Seira,  invdate,  MainCusFullname,  kAxia,  fpacost,  gentot,  COLS,  paid, 
                                                                    ypol,  MAINCUSPrfName,  MAINCusAFM,  MAINCUSAddress,  MAINCUSDoyname,idakiromeno,RouteID
                                                            FROM  dbo.vw_INVOICES where " & IIf(Not cboMainCus.SelectedItem Is Nothing, "  MainCusID = " & boSQLValuej(cboMainCus) & "AND ", "") &
                                                        "invhsygid IS NULL and invdate >= '" & Format(dtFromDate.Value, "yyyy/MM/dd 00:00:00") & "' and invdate <= '" & Format(dtToDate.Value, "yyyy/MM/dd 23:59:59") & "'" &
                                                        "union " &
                                                        "Select '2' as sKey, id , (SELECT NAME FROM SDT_TYPES WHERE CODE = 2) AS InvType,Seira,  invdate,  MainCusFullname,  kAxia,  fpacost,  gentot,  COLS,  paid, 
                                                                   ypol,  MAINCUSPrfName,  MAINCusAFM,  MAINCUSAddress,  MAINCUSDoyname,idakiromeno,RouteID
                                                            from   dbo.vw_INVOICESSYG where " & IIf(Not cboMainCus.SelectedItem Is Nothing, "  MainCusID = " & boSQLValuej(cboMainCus) & "AND ", "") &
                                                        " invdate >= '" & Format(dtFromDate.Value, "yyyy/MM/dd 00:00:00") & "' and invdate <= '" & Format(dtToDate.Value, "yyyy/MM/dd 23:59:59") & "'" &
                                                        "union " &
                                                        "select '3' as sKey, id ,(SELECT NAME FROM SDT_TYPES WHERE CODE = 3) AS InvType ,dosname as Seira,  paydate as invdate,  MainCusFullname,  0 as kAxia,  0 as fpacost,  
	                                                               total * (-1) as gentot,  0 as COLS,  0 as paid, 0 as ypol,  MAINCUSPrfName,  MAINCusAFM,  
	                                                               MAINCUSAddress,  MAINCUSDoyname , NULL AS idakiromeno,null as RouteID
                                                            From vw_col Where " & IIf(Not cboMainCus.SelectedItem Is Nothing, "  MainCusID = " & boSQLValuej(cboMainCus) & "AND ", "") &
                                                        " paydate >= '" & Format(dtFromDate.Value, "yyyy/MM/dd 00:00:00") & "' and paydate <= '" & Format(dtToDate.Value, "yyyy/MM/dd 23:59:59") & "'", cn)


        adapter.Fill(table) : TB = table
        bs1.DataSource = table
        GridMain.SetDataBinding(table, "")
        GridMain.RetrieveStructure()
        GridMain.FilterMode = FilterMode.Automatic
        GridMain.FilterRowButtonStyle = FilterRowButtonStyle.ConditionOperatorDropDown
        With GridMain.RootTable
            .Columns("id").Visible = False
            .Columns("sKey").Visible = False
        End With
        Call LoadLayout()
        Call AddConditionalFormatting()

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
        Next

    End Sub
    Private Sub AddConditionalFormatting()
        'Imports Janus.Windows.GridEX is used in this module

        'Adding a condition using Discontinued field

        Dim fc As GridEXFormatCondition
        fc = New GridEXFormatCondition(
            GridMain.RootTable.Columns("InvType"), ConditionOperator.Equal, "ΕΙΣΠΡΑΞΗ")

        'setting Format style properties to be applied to all the rows
        'that met this condition
        fc.FormatStyle.ForeColor = Color.Green


        'adding a format condition to use font bold when OnSale field is true
        'fc = New Janus.Windows.GridEX.GridEXFormatCondition(GridMain.RootTable.Columns("OnSale"), ConditionOperator.Equal, True)
        'fc.FormatStyle.FontBold = Janus.Windows.GridEX.TriState.True
        'fc.FormatStyle.ForeColor = Color.Red
        GridMain.RootTable.FormatConditions.Add(fc)

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub GridMain_MouseUp(sender As Object, e As MouseEventArgs) Handles GridMain.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            Dim colClicked As GridEXColumn = GridMain.ColumnFromPoint(e.X, e.Y)
            If GridMain.HitTest(e.X, e.Y) = GridArea.ColumnHeader Then
                If Not colClicked Is Nothing Then
                    Me.ShowHeaderMenu(colClicked)
                End If
            Else
                If Not colClicked Is Nothing Then Me.ShowCellMenu(colClicked, 1)
            End If
        End If

    End Sub
    Private Sub ShowCellMenu(ByVal column As GridEXColumn, ByVal sMenu As Byte)
        Select Case sMenu
            Case 1 : Me.cmdFilters.Show(GridMain)
        End Select

        mContextMenuColumn = Nothing
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

    Private Sub SaveGrid()
        Dim strLayoutPath As String
        strLayoutPath = Application.StartupPath & "\LayOuts\GridMainTRANS.gxl"
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

    Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
        Dim filep = ""
        Dim saveDialog As New SaveFileDialog
        saveDialog.DefaultExt = "xls"
        saveDialog.Filter = "Excel File (*.xls)|*.*"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            GridEXExporter1.ExportMode = ExportMode.AllRows
            Dim sFileName As String
            sFileName = saveDialog.FileName
            GridEXExporter1.ExportMode = Janus.Windows.GridEX.ExportMode.AllRows

            GridEXExporter1.IncludeChildTables = False
            GridEXExporter1.IncludeCollapsedRows = True
            GridEXExporter1.IncludeFormatStyle = True
            GridEXExporter1.IncludeHeaders = True
            GridEXExporter1.IncludeExcelProcessingInstruction = True
            GridEXExporter1.SheetName = "Project DashBoard"
            Using st As New IO.FileStream(sFileName, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
                'Dim fs As New System.IO.FileStream(sFileName, System.IO.FileMode.Create)
                GridEXExporter1.Export(st)
                st.Close()
            End Using
            Process.Start(sFileName)

            filep = saveDialog.FileName
        End If
    End Sub

    Private Sub GridMain_FormattingRow(sender As Object, e As RowLoadEventArgs) Handles GridMain.FormattingRow

    End Sub

    Private Sub GridMain_DoubleClick(sender As Object, e As EventArgs) Handles GridMain.DoubleClick
        Dim FRMS As New Form
        Dim Row1 As Janus.Windows.GridEX.GridEXRow
        Row1 = GridMain.CurrentRow
        frmInvoice.Mode = FormMode.ViewRecord
        frmInvoice.RouteID = Row1.Cells("RouteID").Value.ToString()
        If Row1.Cells("idakiromeno").Value.ToString() <> "" Then frmInvoice.IsAkirotiko = True
        Select Case Row1.Cells("sKey").Value.ToString()
            Case "1" : frmInvoice.INVID = Row1.Cells("id").Value.ToString() : FRMS = frmInvoice : FRMS.Owner = Me : FRMS.Show()
            Case "2" : frmInvoice.SYGID = Row1.Cells("id").Value.ToString() : FRMS = frmInvoice : FRMS.Owner = Me : FRMS.Show()
            Case "3" : frmCollection.COLID = Row1.Cells("id").Value.ToString() : FRMS = frmCollection : FRMS.Owner = Me : FRMS.Show()
        End Select

    End Sub
    Private Sub OnFilterWithSelection()
        Dim Row1 As Janus.Windows.GridEX.GridEXRow
        Dim Col As GridEXColumn
        Try
            Row1 = GridMain.CurrentRow
            Col = GridMain.CurrentColumn
            If ColWithSelection = "" Then
                ColWithSelection = "invdate >= #" & Format(dtFromDate.Value, "yyyy/MM/dd 00:00:00") & "# and invdate <= #" & Format(dtToDate.Value, "yyyy/MM/dd 23:59:59") & "#  "
            End If
            ColWithSelection = ColWithSelection & IIf(ColWithSelection <> Nothing, " and ", "") & Col.DataMember & " = '" & Row1.Cells(Col.DataMember).Value.ToString() & "'"

            Dim FilteredRows As DataRow() = TB.Select(ColWithSelection)
            If (FilteredRows.Any()) Then
                GridMain.DataSource = FilteredRows.CopyToDataTable()
            Else
                GridMain.DataSource = Nothing
            End If
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try

    End Sub
    Private Sub OnFilterWithoutSelection()
        Dim Row1 As Janus.Windows.GridEX.GridEXRow
        Dim Col As GridEXColumn
        Try
            Row1 = GridMain.CurrentRow
            Col = GridMain.CurrentColumn
            If ColWithoutSelection = "" Then
                ColWithoutSelection = "invdate >= #" & Format(dtFromDate.Value, "yyyy/MM/dd 00:00:00") & "# and invdate <= #" & Format(dtToDate.Value, "yyyy/MM/dd 23:59:59") & "#  "
            End If
            ColWithoutSelection = ColWithoutSelection & IIf(ColWithoutSelection <> Nothing, " and ", "") & Col.DataMember & " <> '" & Row1.Cells(Col.DataMember).Value.ToString() & "'"

            Dim FilteredRows As DataRow() = TB.Select(ColWithoutSelection)
            If (FilteredRows.Any()) Then
                GridMain.DataSource = FilteredRows.CopyToDataTable()
            Else
                GridMain.DataSource = Nothing
            End If
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try

    End Sub

    Private Sub comManager2_CommandClick(sender As Object, e As CommandEventArgs) Handles comManager2.CommandClick
        Select Case e.Command.Key
            Case "FChoice" : OnFilterWithSelection()
            Case "FWChoice" : OnFilterWithoutSelection()
            Case "FDefault" : ColWithoutSelection = "" : ColWithSelection = "invdate >= #" & Format(dtFromDate.Value, "yyyy/MM/dd 00:00:00") & "# and invdate <= #" & Format(dtToDate.Value, "yyyy/MM/dd 23:59:59") & "#  "
                Dim FilteredRows As DataRow() = TB.Select(ColWithSelection)
                If (FilteredRows.Any()) Then
                    GridMain.DataSource = FilteredRows.CopyToDataTable()
                Else
                    GridMain.DataSource = Nothing
                End If

            Case Else
        End Select
    End Sub
End Class