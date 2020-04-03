Imports System.Data.OleDb
Imports Janus.Windows.GridEX

Public Class frmGrid
    Private ID As String
    Public Mode As Byte
    Private bs1 As New BindingSource
    Private adapter As New OleDb.OleDbDataAdapter
    Private mContextMenuColumn As GridEXColumn
    Private fieldChoser As frmFieldChooser
    Private HID As String
    Private CID As String
    Private SID As String

    Private Sub frmGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadLayout()
        Call FillJanusGridWithRecords()
    End Sub
    Private Sub FillJanusGridWithRecords()
        Dim sql As String
        Dim table As New DataTable
        table.Columns.Clear()
        GridMain.DataSource = Nothing
        table.Clear()

        Dim Row1 As Janus.Windows.GridEX.GridEXRow
        'Row1 = frmMain.GridMain.CurrentRow
        'ID = Row1.Cells("ID").Value.ToString
        If SID <> Nothing Then
            adapter.SelectCommand = New OleDb.OleDbCommand("select * from vw_Routes_INV WHERE InvhSygID=  '" & SID & "'", cn)
        ElseIf HID <> Nothing Then
            adapter.SelectCommand = New OleDb.OleDbCommand("select * from vw_Routes_INV WHERE InvhID=  '" & HID & "'", cn)
        End If
        adapter.Fill(table)
        bs1.DataSource = table
        GridMain.SetDataBinding(table, "")
            GridMain.RetrieveStructure()
            GridMain.FilterMode = FilterMode.Automatic
            GridMain.FilterRowButtonStyle = FilterRowButtonStyle.ConditionOperatorDropDown
            With GridMain.RootTable
                .AllowEdit = InheritableBoolean.True
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

    End Sub
    Private Sub LoadLayout()
        Dim strLayoutPath As String
        If HID <> Nothing Then
            strLayoutPath = Application.StartupPath & "\LayOuts\GridMainGRIDINV.gxl"
        Else
            strLayoutPath = Application.StartupPath & "\LayOuts\GridMainGRIDINVSYG.gxl"
        End If
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
    Private Sub GridMain_DoubleClick(sender As Object, e As EventArgs) Handles GridMain.DoubleClick
        Dim clickArea As GridArea = GridMain.HitTest()
        Dim FRMS As New Form
        Dim Row1 As Janus.Windows.GridEX.GridEXRow
        Dim group As GridEXGroup
        Dim Col As GridEXColumn
        Row1 = GridMain.CurrentRow

        Select Case clickArea
            Case GridArea.GroupRow
                Exit Sub
                group = Row1.Group
                Col = group.Column
            Case GridArea.GroupByBox, GridArea.GroupByBoxInfoText
            Case GridArea.Cell, GridArea.PreviewRow, GridArea.CardCaption

        End Select

        FrmRoute.Mode = FormMode.ViewRecord : FrmRoute.RouteID = Row1.Cells("ID").Value.ToString : FRMS = FrmRoute
        FRMS.Owner = Me
        FRMS.Show()
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
        If HID <> Nothing Then
            strLayoutPath = Application.StartupPath & "\LayOuts\GridMainGRIDINV.gxl"
        Else
            strLayoutPath = Application.StartupPath & "\LayOuts\GridMainGRIDINVSYG.gxl"
        End If

        Try
            Dim stream As System.IO.FileStream = New System.IO.FileStream(strLayoutPath, IO.FileMode.Create)
            GridMain.SaveLayoutFile(stream)
            stream.Close()
            MessageBox.Show("Η Όψη αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch

        End Try
    End Sub

    Public WriteOnly Property INVHID As String
        Set(value As String)
            HID = value
        End Set
    End Property
    Public WriteOnly Property COLHID As String
        Set(value As String)
            CID = value
        End Set
    End Property
    Public WriteOnly Property SYGHID As String
        Set(value As String)
            SID = value
        End Set
    End Property
End Class