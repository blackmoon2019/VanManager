Imports System.Data.OleDb
Imports Janus.Windows.GridEX


Public Class frmES
    Private ID As String
    Public Mode As Byte
    Private fieldChoser As frmFieldChooser
    Private mContextMenuColumn As GridEXColumn
    Private Sub frmEsex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim table As New DataTable
        Dim bs1 As New BindingSource
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim group As GridEXGroup
        Dim column As New GridEXColumn

        sql = "SELECT R.ID
	            ,CASE WHEN R.ID = P.routeID THEN '' ELSE '' END AS Groupings
                ,R.invoiced AS 'Τιμολογήθηκε'
	            ,MAINCUSName AS 'Πελάτης'
	            ,R.DrvName + ' ' + R.DrvLastname AS 'Οδηγός'
	            ,vw_HLP.HlpName + ' ' + R.DrvLastname AS 'Βοηθός'
	            ,R.dtCreated AS 'Ημερ/νία Δρομολογίου'
	            ,R.cost AS 'Κόστος'
	            ,R.DrvPrice AS 'Τιμή Οδηγού'
	            ,R.COLLECTION AS 'Είσπραξη'
	            ,R.HlpPrice AS 'Τιμή Βοηθού'
	            ,R.plate AS 'Αρ. Πινακίδας'
	            ,p.arDelt AS 'Αρ. Δελτίου'
                FROM vw_ROUTES R
                INNER JOIN vw_POI P ON P.routeID = R.ID
                left join vw_HLP_ROUTES HLPR on HLPR.routeid =R.id
                left join vw_HLP on vw_HLP.id=hlpr.hlpID"
        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(table)
        bs1.DataSource = table

        dbView.SetDataBinding(table, "")
        dbView.RetrieveStructure()
        dbView.EditMode = EditMode.EditOn
        dbView.VisualStyle = VisualStyle.Office2010

        'GROUP BY Ημερομηνία
        dbView.RootTable.Groups.Clear()
        'Ημερομηνία Δρομολογίου
        column = dbView.RootTable.Columns("Ημερ/νία Δρομολογίου")
        group = New GridEXGroup(column, SortOrder.Ascending)
        group.HeaderCaption = "Ημερομηνία Δρομολογίου"
        group.GroupPrefix = "Ημερομηνία Δρομολογίου:"
        dbView.RootTable.Groups.Add(group)
        'Δρομολόγιο
        column = dbView.RootTable.Columns("Groupings")
        group = New GridEXGroup(column, SortOrder.Ascending)
        group.HeaderCaption = "Σημεία"
        group.GroupPrefix = ""
        group.GroupFormatString = ""
        dbView.RootTable.Groups.Add(group)
        dbView.RootTable.Columns(1).Visible = False
        'Γραμμή Συνόλων
        dbView.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        dbView.RootTable.Columns(6).AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns(6).TotalFormatString = "c" 'Currency
        dbView.RootTable.Columns(7).AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns(7).TotalFormatString = "c" 'Currency
        dbView.RootTable.Columns(8).AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns(8).TotalFormatString = "c" 'Currency
        dbView.RootTable.Columns(9).AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum : dbView.RootTable.Columns(9).TotalFormatString = "c" 'Currency
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdCreateInvoice_Click(sender As Object, e As EventArgs) Handles cmdCreateInvoice.Click
        frmPrintPreview.Show()
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

    Private Sub ShowHeaderMenu(ByVal column As GridEXColumn)

        mContextMenuColumn = column
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

End Class