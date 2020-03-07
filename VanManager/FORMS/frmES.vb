Imports System.Data.OleDb
Imports System.IO
Imports Janus.Windows.GridEX
Imports Janus.Windows.UI.CommandBars

Public Class frmES
    Private ID As String
    Public Mode As Byte
    Private fieldChoser As frmFieldChooser
    Private mContextMenuColumn As GridEXColumn
    Private _Active As New List(Of ActiveCB)
    Private Sub frmEsex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim table As New DataTable
        Dim bs1 As New BindingSource
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim group As GridEXGroup
        Dim column As New GridEXColumn
        Me.FilterEditor1.SourceControl = dbView


        sql = "SELECT * from vw_ROUTES R 
                left join vw_HLP_ROUTES HLPR on HLPR.routeid =R.id
                left join vw_HLP on vw_HLP.id=hlpr.hlpID"
        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(table)
        bs1.DataSource = table

        dbView.SetDataBinding(table, "")
        dbView.RetrieveStructure()
        dbView.VisualStyle = VisualStyle.Office2010

        ''GROUP BY Ημερομηνία
        dbView.RootTable.Groups.Clear()

        'Πελάτης
        column = dbView.RootTable.Columns("MainCusFullname")
        group = New GridEXGroup(column, SortOrder.Ascending)
        group.HeaderCaption = "Πελάτης"
        group.GroupPrefix = ""
        group.GroupFormatString = ""
        dbView.RootTable.Groups.Add(group)

        'Ημερομηνία Δρομολογίου
        column = dbView.RootTable.Columns("dtcreated")
        group = New GridEXGroup(column, SortOrder.Ascending)
        group.HeaderCaption = "Ημερομηνία Δρομολογίου"
        group.GroupPrefix = "Ημερομηνία Δρομολογίου:"
        dbView.RootTable.Groups.Add(group)


        Dim strLayoutPath As String
        strLayoutPath = Application.StartupPath & "\LayOuts\ES\Def.gxl"
        Dim fi As System.IO.FileInfo = New System.IO.FileInfo(strLayoutPath)
        If fi.Exists Then
            Dim stream As System.IO.FileStream = New System.IO.FileStream(fi.FullName, IO.FileMode.Open)
            dbView.LoadLayoutFile(stream)
            stream.Close()
        End If


        'Γραμμή Συνόλων
        dbView.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        dbView.RootTable.Columns("collection").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns("collection").TotalFormatString = "c" 'Currency
        dbView.RootTable.Columns("cost").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns("cost").TotalFormatString = "c" 'Currency
        dbView.RootTable.Columns("fpacost").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns("fpacost").TotalFormatString = "c" 'Currency
        dbView.RootTable.Columns("gentot").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns("gentot").TotalFormatString = "c" 'Currency
        dbView.RootTable.Columns("HlpPrice").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns("HlpPrice").TotalFormatString = "c" 'Currency
        dbView.RootTable.Columns("DrvPrice").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns("DrvPrice").TotalFormatString = "c" 'Currency

        dbView.RootTable.Columns(1).Visible = False

        Call LoadDesigns()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdCreateInvoice_Click(sender As Object, e As EventArgs)
        frmPrintPreview.Show()
    End Sub

    Private Sub ShowHeaderMenu(ByVal column As GridEXColumn)


        mContextMenuColumn = column
        cmdRenameThisColumn.Control.Text = mContextMenuColumn.Caption
        'Check SortAscending/SortDescending menus if the column is sorted
        'If mContextMenuColumn.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending Then
        '    Me.cmdSortAscending.IsChecked = True
        'Else
        '    Me.cmdSortAscending.IsChecked = False
        'End If
        'If mContextMenuColumn.SortOrder = Janus.Windows.GridEX.SortOrder.Descending Then
        '    Me.cmdSortDescending.IsChecked = True
        'Else
        '    Me.cmdSortDescending.IsChecked = False
        'End If
        ''Change the name of GroupByThisField menu depending on whether the column
        ''is grouped or not
        'If mContextMenuColumn.Group Is Nothing Then
        '    Me.cmdGroupByThisField.Text = "&Group By This Field"
        'Else
        '    Me.cmdGroupByThisField.Text = "Don't &Group By This Field"
        'End If
        ''check group by box menu if the group by box is visible
        'If Me.GridEX.GroupByBoxVisible Then
        '    Me.cmdGroupByBox.IsChecked = True
        'Else
        '    Me.cmdGroupByBox.IsChecked = False
        'End If
        'If mContextMenuColumn.ColumnType = ColumnType.CheckBox Then
        '    Me.cmdColumnAlignment.IsEnabled = False
        'Else
        '    Me.cmdColumnAlignment.IsEnabled = True
        '    Me.cmdAlignRight.IsChecked = (mContextMenuColumn.TextAlignment = TextAlignment.Far)
        '    Me.cmdAlignCenter.IsChecked = (mContextMenuColumn.TextAlignment = TextAlignment.Center)
        '    Me.cmdAlignLeft.IsChecked = (mContextMenuColumn.TextAlignment = TextAlignment.Near Or mContextMenuColumn.TextAlignment = TextAlignment.Empty)

        'End If
        If dbView.View <> Janus.Windows.GridEX.View.TableView Or Me.dbView.RootTable.CellLayoutMode = CellLayoutMode.UseColumnSets Then
            cmdFieldChooser.IsEnabled = False
        Else
            cmdFieldChooser.IsEnabled = True
        End If
        If mContextMenuColumn.Table.CellLayoutMode = CellLayoutMode.UseColumnSets Then
            Me.cmdRemoveThisColumn.IsEnabled = False
        Else
            Me.cmdRemoveThisColumn.IsEnabled = True
        End If
        If dbView.IsFieldChooserVisible() Then
            Me.commandManager.Commands("cmdFieldChooser").Checked = Janus.Windows.UI.InheritableBoolean.True
        Else
            Me.commandManager.Commands("cmdFieldChooser").Checked = Janus.Windows.UI.InheritableBoolean.False
        End If
        Me.cmHeader.Show(dbView)
        mContextMenuColumn = Nothing
    End Sub

    Private Sub cmHeader_CommandClick(sender As Object, e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmHeader.CommandClick
        Select Case e.Command.Key
            'Case "cmdSortAscending"
            '    OnSortAscendingCommand()
            'Case "cmdSortDescending"
            '    OnSortDescendingCommand()
            'Case "cmdGroupByThisField"
            '    OnGroupByThisFieldCommand()
            'Case "cmdGroupByBox"
            '    OnGroupByBoxCommand()
            Case "cmdRemoveThisColumn"
                OnRemoveThisColumnCommand()
            Case "cmdFieldChooser"
                OnFieldChooserCommand()
                'Case "cmdFilter"
                '    OnFilterCommand()
                'Case "cmdBestFit"
                '    mContextMenuColumn.AutoSize()
                'Case "cmdCustomizeView"
                '    Me.ShowViewSummaryDialog()
                'Case "cmdAlignLeft"
                '    mContextMenuColumn.TextAlignment = TextAlignment.Near
                'Case "cmdAlignRight"
                '    mContextMenuColumn.TextAlignment = TextAlignment.Far
                'Case "cmdAlignCenter"
                '    mContextMenuColumn.TextAlignment = TextAlignment.Center
            Case Else
        End Select
    End Sub
    Private Sub OnRemoveThisColumnCommand()
        mContextMenuColumn.Visible = False
    End Sub
    Private Sub OnFieldChooserCommand()
        If fieldChoser Is Nothing OrElse fieldChoser.IsDisposed Then
            fieldChoser = New frmFieldChooser()
            fieldChoser.Show(Me.dbView, Me.FindForm())
        Else
            fieldChoser.Close()
            fieldChoser.Dispose()
            fieldChoser = Nothing
        End If
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        frmPPreview.Owner = Me
        frmPPreview.GridEXPrintDocument1.GridEX = dbView
        frmPPreview.Show()
    End Sub
    Private Sub LoadDesigns()

        Dim dir = Application.StartupPath & "\LayOuts\ES\"
        Dim i As Integer = 1
        _Active.Clear()
        _Active.Add(New ActiveCB With {.Name = "", .ID = i})
        i = i + 1
        For Each file As String In System.IO.Directory.GetFiles(dir)
            If System.IO.Path.GetFileName(file) <> "Def.gxl" Then _Active.Add(New ActiveCB With {.Name = System.IO.Path.GetFileNameWithoutExtension(file), .ID = i})
            i = i + 1
        Next
        cboGrids.DataSource = _Active
        cboGrids.DisplayMember = "name"
        cboGrids.ValueMember = "ID"
        cboGrids.SettingsKey = "id"

    End Sub


    Private Sub cmHeader_CommandControlValueChanged(sender As Object, e As CommandEventArgs) Handles cmHeader.CommandControlValueChanged
        If e.Command.Key = "cmdRenameThisColumn" Then
            mContextMenuColumn.Caption = cmdRenameThisColumn.Control.Text
        End If
    End Sub

    Private Sub FilterEditor1_FilterConditionChanged(sender As Object, e As EventArgs) Handles FilterEditor1.FilterConditionChanged
        dbView.RootTable.FilterCondition = CType(Me.FilterEditor1.FilterCondition, IFilterCondition)
    End Sub
    Private Sub dbView_MouseUp(sender As Object, e As MouseEventArgs) Handles dbView.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            If dbView.HitTest(e.X, e.Y) = GridArea.ColumnHeader Then
                Dim colClicked As GridEXColumn = dbView.ColumnFromPoint(e.X, e.Y)
                If Not colClicked Is Nothing Then
                    Me.ShowHeaderMenu(colClicked)
                End If
            End If
        End If
    End Sub

    Private Sub cmdExit_Click_1(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSaveLayouts_Click(sender As Object, e As EventArgs) Handles cmdSaveView.Click
        Dim Input As String
        Dim strLayoutPath As String
        If cboGrids.Text.Length = 0 Then
            Input = InputBox("Πληκτρολογήστε το όνομα του αρχείου")
        End If

        If Input <> "" Then
            strLayoutPath = Application.StartupPath & "\LayOuts\ES\" & Input & ".gxl"
            Try
                Dim stream As System.IO.FileStream = New System.IO.FileStream(strLayoutPath, IO.FileMode.Create)
                dbView.SaveLayoutFile(stream)
                stream.Close()
                'Φόρτωση σχεδίων στην λίστα
                Call LoadDesigns()
                MessageBox.Show("Η Όψη αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch

            End Try
        ElseIf Input = "" And cboGrids.Text.Length > 0 Then
            strLayoutPath = Application.StartupPath & "\LayOuts\ES\" & cboGrids.Text & ".gxl"
            Try
                Dim stream As System.IO.FileStream = New System.IO.FileStream(strLayoutPath, IO.FileMode.Create)
                dbView.SaveLayoutFile(stream)
                stream.Close()
                'Φόρτωση σχεδίων στην λίστα
                Call LoadDesigns()
                MessageBox.Show("Η Όψη αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch

            End Try
        Else
            ' Cancelled, or empty
        End If
    End Sub


    Private Sub cboGrids_TextChanged(sender As Object, e As EventArgs) Handles cboGrids.TextChanged
        Dim strLayoutPath As String
        strLayoutPath = Application.StartupPath & "\LayOuts\ES\" & cboGrids.Text & ".gxl"
        Dim fi As System.IO.FileInfo = New System.IO.FileInfo(strLayoutPath)
        If fi.Exists Then
            Try
                Dim stream As System.IO.FileStream = New System.IO.FileStream(fi.FullName, IO.FileMode.Open)
                dbView.LoadLayoutFile(stream)
                'Γραμμή Συνόλων
                dbView.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
                dbView.RootTable.Columns("collection").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns("collection").TotalFormatString = "c" 'Currency
                dbView.RootTable.Columns("cost").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns("cost").TotalFormatString = "c" 'Currency
                dbView.RootTable.Columns("fpacost").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns("fpacost").TotalFormatString = "c" 'Currency
                dbView.RootTable.Columns("gentot").AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns("gentot").TotalFormatString = "c" 'Currency

                stream.Close()
            Catch exc As Exception
                MessageBox.Show(exc.Message)
            End Try
        End If
    End Sub

    Private Sub cmdDelteView_Click(sender As Object, e As EventArgs) Handles cmdDelteView.Click
        If cboGrids.Text.Length > 0 Then
            If MessageBox.Show("Να γίνει διαγραφή της όψης?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                If My.Computer.FileSystem.FileExists(Application.StartupPath & "\LayOuts\ES\" & cboGrids.Text & ".gxl") Then
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\LayOuts\ES\" & cboGrids.Text & ".gxl")
                End If
                'Φόρτωση σχεδίων στην λίστα
                Call LoadDesigns()
            End If
        End If
    End Sub

    Private Sub cmdSaveAsDef_Click(sender As Object, e As EventArgs) Handles cmdSaveAsDef.Click
        Dim strLayoutPath As String
        strLayoutPath = Application.StartupPath & "\LayOuts\ES\Def.gxl"
        Try
            Dim stream As System.IO.FileStream = New System.IO.FileStream(strLayoutPath, IO.FileMode.Create)
            dbView.SaveLayoutFile(stream)
            stream.Close()
            MessageBox.Show("Η Όψη αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

    Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
        Dim filep = ""
        Dim saveDialog As New SaveFileDialog
        saveDialog.DefaultExt = "xlsx"
        saveDialog.Filter = "Excel File (*.xlsx)|*.*"
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
            Dim fs As New System.IO.FileStream(sFileName, System.IO.FileMode.Create)
            GridEXExporter1.Export(fs)
            fs.Close()
            Process.Start(sFileName)

            filep = saveDialog.FileName
        End If
    End Sub
End Class