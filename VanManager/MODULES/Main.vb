'Άλλαξα το Scope και το Type από Project -->VanManager Properties-->Settings-->Type=String Scope=User
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Reflection

Module Main
    Public UDLStr As String
    Public cn As New OleDbConnection()
    Public UserCode As Integer = 1
    Public UserID As String = "C944A7E2-DF63-4446-9796-38399E58261F"

    Enum FormMode
        NewRecord = 1
        EditRecord = 2
        DeleteRecord = 3
        ViewRecord = 4
    End Enum

    Public Function GetMonthName(ByVal M As Integer) As String
        Select Case M
            Case 1 : GetMonthName = "Ιανουάριος"
            Case 2 : GetMonthName = "Φεβρουάριος"
            Case 3 : GetMonthName = "Μάρτιος"
            Case 4 : GetMonthName = "Απρίλιος"
            Case 5 : GetMonthName = "Μάϊος"
            Case 6 : GetMonthName = "Ιούνιος"
            Case 7 : GetMonthName = "Ιούλιος"
            Case 8 : GetMonthName = "Αύγουστος"
            Case 9 : GetMonthName = "Σεπτέμβριος"
            Case 10 : GetMonthName = "Οκτώβριος"
            Case 11 : GetMonthName = "Νοέμβριος"
            Case 12 : GetMonthName = "Δεκέμβριος"
        End Select
    End Function
    Public Function OpenConnection() As Boolean
        On Error GoTo CheckError
        Call CloseConnection(cn)
        cn = New OleDbConnection
        With cn
            .ConnectionString = "file name=" & UDLStr
            .Open()
            If .State = ConnectionState.Open Then
                Console.WriteLine("connection opened successfully")
                OpenConnection = True
            Else
                Console.WriteLine("connection could not be established")
                OpenConnection = False
            End If
        End With


        Exit Function
CheckError:
        OpenConnection = False
    End Function
    Public Function OpenConnectionSQL()
        'Dim connetionString As String
        'Dim cnn As SqlConnection
        'connetionString = "data source=blackmoon-lapto\sqlexpress;initial catalog=VanManager;Password=mavros1!;Persist Security Info=True;User ID=sa"
        'cnn = New SqlConnection(connetionString)
        'My.Settings.VanManagerConnectionString = connetionString
        'My.Settings.Save()

        Try
            'cnn.Open()
            'Form1.DOYTableAdapter.Fill(Form1.VanManagerDataSet.DOY)
            'Form1.dbView.DataSource = Form1.VanManagerDataSet
            'Form1.dbView.DataMember = "DOY"
            'Form1.DOYTableAdapter.Connection.ConnectionString = connetionString
            'Form1.DOYTableAdapter.Update(Form1.VanManagerDataSet)
            'Form1.DOYTableAdapter.Fill(Form1.VanManagerDataSet.DOY)
            MsgBox("Connection Open ! ")
            'cnn.Close()
        Catch ex As Exception
            'MsgBox("Can not open connection ! ")
            MsgBox(ex.Message)
        End Try
    End Function
    ' Κλείσιμο σύνδεσης
    Public Sub CloseConnection(ByRef Conn As OleDbConnection)
        On Error Resume Next
        Conn.Close()
        cn = Nothing
    End Sub
    Public Function CheckAFM(sAFM As String) As Boolean
        Dim iSum As Integer
        Dim btRem As Byte
        Dim i As Byte

        If sAFM = "" Or Len(sAFM) <> 9 Then
            CheckAFM = False
            Exit Function
        End If

        iSum = 0
        CheckAFM = False

        For i = 1 To Len(sAFM) - 1
            If Asc(Mid(sAFM, i, 1)) < 48 Or Asc(Mid(sAFM, i, 1)) > 57 Then
                CheckAFM = False
                Exit Function
            End If
            iSum = iSum + Val(Mid(sAFM, i, 1)) * (2 ^ (Len(sAFM) - i))
        Next i

        If iSum = 0 Then
            CheckAFM = False
        Else
            btRem = iSum Mod 11
            If Val(Strings.Right(sAFM, 1)) = btRem Or (btRem = 10 And Val(Strings.Right(sAFM, 1)) = 0) Then CheckAFM = True
        End If
    End Function
    Public Function toSQLValue(t As TextBox, Optional ByVal isnum As Boolean = False) As String
        If t.TextLength = 0 Then
            Return "NULL" 'this will pass through any SQL statement without notice  
        Else 'Lets suppose our textbox is checked to contain only numbers, so we count on it  
            If Not isnum Then Return "'" + t.Text + "'" Else Return t.Text
        End If
    End Function
    Public Function toSQLValueM(t As String, Optional ByVal isnum As Boolean = False) As String
        If t.Length = 0 Then
            Return "NULL" 'this will pass through any SQL statement without notice  
        Else 'Lets suppose our textbox is checked to contain only numbers, so we count on it  
            If Not isnum Then Return "'" + t + "'" Else Return t
        End If
    End Function
    Public Function toSQLValueJ(t As Janus.Windows.GridEX.EditControls.EditBox, Optional ByVal isnum As Boolean = False) As String
        If t.TextLength = 0 Then
            Return "NULL" 'this will pass through any SQL statement without notice  
        Else 'Lets suppose our textbox is checked to contain only numbers, so we count on it  
            If Not isnum Then Return "'" + t.Text + "'" Else Return t.Text
        End If
    End Function
    Public Function boSQLValue(b As ComboBox, Optional ByVal isnum As Boolean = False) As String
        If b.Text.Length = 0 Then
            'Return "'" & Guid.Empty.ToString & "'"   'this will pass through any SQL statement without notice  
            Return "NULL"
        Else 'Lets suppose our textbox is checked to contain only numbers, so we count on it  
            If Not isnum Then Return "'" + b.SelectedValue.ToString + "'" Else Return b.SelectedValue
        End If
    End Function
    Public Function boSQLValuej(b As Janus.Windows.GridEX.EditControls.MultiColumnCombo, Optional ByVal isnum As Boolean = False) As String
        If b.Text.Length = 0 Then
            'Return "'" & Guid.Empty.ToString & "'"   'this will pass through any SQL statement without notice  
            Return "NULL"
        Else 'Lets suppose our textbox is checked to contain only numbers, so we count on it  
            If Not isnum Then Return "'" + b.Value.ToString + "'" Else Return b.Value
        End If
    End Function
    'Επιστρέφει νέο κωδικό για οποιονδήποτε πίνακα + 1
    Public Function GetNewCode(ByVal sTable As String) As Integer
        Dim sSQL As String
        If sTable <> "SDT" Then
            sSQL = "SELECT ISNULL(max(code),0) + 1  as code FROM " & sTable
        Else
            sSQL = "SELECT ISNULL(max(SDTcode),0) + 1  as code FROM " & sTable
        End If

        Dim cmd As OleDbCommand = New OleDbCommand(sSQL, cn)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            If sTable = "INVH" Or sTable = "INVHSYG" Then
                GetNewCode = sdr.GetInt64(sdr.GetOrdinal("code"))
            Else
                GetNewCode = sdr.GetInt32(sdr.GetOrdinal("code"))
                End If
            Else
                GetNewCode = 1
        End If
        sdr.Close()

    End Function
    Public Function GetSen(ByVal Dosid As String, Optional UPD As Boolean = False) As Int64
        Dim sSQL As String
        sSQL = "SELECT number FROM sen where dosid='" & Dosid & "'"

        Dim cmd As OleDbCommand = New OleDbCommand(sSQL, cn)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            GetSen = sdr.GetInt64(sdr.GetOrdinal("number")) + 1
            If UPD = True Then
                sSQL = "update SEN set  " &
                    "number = " & GetSen & "," &
                    "[lastupdate] = " & "'" & Format(Date.Now, "yyyy/MM/dd HH:mm:ss") & "' " &
                    "where dosid = '" & Dosid & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        Else
            GetSen = 1
            sSQL = "INSERT SEN ([dosid],[number],[lastupdate]) " &
                          "values (" & "'" & Dosid & "'," &
                                      GetSen & "," &
                                    "'" & Format(Date.Now, "yyyy/MM/dd HH:mm:ss") & "')"
            Using oCmd As New OleDbCommand(sSQL, cn)
                oCmd.ExecuteNonQuery()
            End Using
        End If
        sdr.Close()

    End Function
    Public Sub LockUnlockAllControls(ByVal frm As Form, ByVal Locked As Boolean)
        'On Error Resume Next
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is TextBox Then CType(ctrl, TextBox).ReadOnly = Locked
            If TypeOf ctrl Is MaskedTextBox Then CType(ctrl, MaskedTextBox).ReadOnly = Locked
            If TypeOf ctrl Is ComboBox Then CType(ctrl, ComboBox).Enabled = Not Locked
            If TypeOf ctrl Is Janus.Windows.EditControls.UIGroupBox Then
                For Each ctrl2 As Control In ctrl.Controls
                    If TypeOf ctrl2 Is Janus.Windows.GridEX.EditControls.EditBox Then CType(ctrl2, Janus.Windows.GridEX.EditControls.EditBox).ReadOnly = Locked
                    If TypeOf ctrl2 Is Janus.Windows.GridEX.EditControls.NumericEdit Then CType(ctrl2, Janus.Windows.GridEX.EditControls.NumericEdit).ReadOnly = Locked
                    If TypeOf ctrl2 Is Janus.Windows.GridEX.EditControls.NumericEditBox Then CType(ctrl2, Janus.Windows.GridEX.EditControls.NumericEditBox).ReadOnly = Locked
                    If TypeOf ctrl2 Is Janus.Windows.EditControls.UICheckBox Then CType(ctrl2, Janus.Windows.EditControls.UICheckBox).Enabled = Not Locked
                    If TypeOf ctrl2 Is Janus.Windows.CalendarCombo.CalendarCombo Then CType(ctrl2, Janus.Windows.CalendarCombo.CalendarCombo).ReadOnly = Locked
                    If TypeOf ctrl2 Is Janus.Windows.GridEX.EditControls.MultiColumnCombo Then CType(ctrl2, Janus.Windows.GridEX.EditControls.MultiColumnCombo).ReadOnly = Locked
                    If TypeOf ctrl2 Is Janus.Windows.EditControls.UIButton Then CType(ctrl2, Janus.Windows.EditControls.UIButton).Enabled = Not Locked
                    If TypeOf ctrl2 Is Janus.Windows.GridEX.GridEX Then CType(ctrl2, Janus.Windows.GridEX.GridEX).Enabled = Not Locked
                    If TypeOf ctrl2 Is Janus.Windows.EditControls.UIGroupBox Then
                        For Each ctrl3 As Control In ctrl2.Controls
                            If TypeOf ctrl3 Is Janus.Windows.GridEX.EditControls.EditBox Then CType(ctrl3, Janus.Windows.GridEX.EditControls.EditBox).ReadOnly = Locked
                            If TypeOf ctrl3 Is Janus.Windows.GridEX.EditControls.NumericEditBox Then CType(ctrl3, Janus.Windows.GridEX.EditControls.NumericEditBox).ReadOnly = Locked
                            If TypeOf ctrl3 Is Janus.Windows.GridEX.EditControls.NumericEdit Then CType(ctrl3, Janus.Windows.GridEX.EditControls.NumericEdit).ReadOnly = Locked
                            If TypeOf ctrl3 Is Janus.Windows.EditControls.UICheckBox Then CType(ctrl3, Janus.Windows.EditControls.UICheckBox).Enabled = Not Locked
                            If TypeOf ctrl3 Is Janus.Windows.CalendarCombo.CalendarCombo Then CType(ctrl3, Janus.Windows.CalendarCombo.CalendarCombo).ReadOnly = Locked
                            If TypeOf ctrl3 Is Janus.Windows.GridEX.EditControls.MultiColumnCombo Then CType(ctrl3, Janus.Windows.GridEX.EditControls.MultiColumnCombo).ReadOnly = Locked
                            If TypeOf ctrl3 Is Janus.Windows.EditControls.UIButton Then CType(ctrl3, Janus.Windows.EditControls.UIButton).Enabled = Not Locked
                            If TypeOf ctrl3 Is Janus.Windows.GridEX.GridEX Then CType(ctrl3, Janus.Windows.GridEX.GridEX).Enabled = Not Locked
                        Next
                    End If
                Next
            End If
            If TypeOf ctrl Is Janus.Windows.GridEX.EditControls.MultiColumnCombo Then CType(ctrl, Janus.Windows.GridEX.EditControls.MultiColumnCombo).ReadOnly = Locked
            If TypeOf ctrl Is Janus.Windows.GridEX.EditControls.EditBox Then CType(ctrl, Janus.Windows.GridEX.EditControls.EditBox).ReadOnly = Locked
            If TypeOf ctrl Is Janus.Windows.GridEX.EditControls.NumericEdit Then CType(ctrl, Janus.Windows.GridEX.EditControls.NumericEdit).ReadOnly = Locked
            If TypeOf ctrl Is Janus.Windows.GridEX.EditControls.NumericEditBox Then CType(ctrl, Janus.Windows.GridEX.EditControls.NumericEditBox).ReadOnly = Locked
            If TypeOf ctrl Is Janus.Windows.EditControls.UIButton Then CType(ctrl, Janus.Windows.EditControls.UIButton).Enabled = Not Locked
            If TypeOf ctrl Is Janus.Windows.GridEX.GridEX Then   CType(ctrl, Janus.Windows.GridEX.GridEX ).Enabled = Not Locked
        Next
    End Sub
    Public Sub ClearAllControls(ByVal frm As Form)
        On Error Resume Next
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is TextBox Then CType(ctrl, TextBox).Text = ""
            If TypeOf ctrl Is MaskedTextBox Then CType(ctrl, MaskedTextBox).Text = ""
            If TypeOf ctrl Is ComboBox Then CType(ctrl, ComboBox).SelectedIndex = 0
            If TypeOf ctrl Is Janus.Windows.GridEX.EditControls.NumericEditBox Then CType(ctrl, Janus.Windows.GridEX.EditControls.NumericEditBox).Value = "0"
            If TypeOf ctrl Is Janus.Windows.EditControls.UICheckBox Then CType(ctrl, Janus.Windows.EditControls.UICheckBox).Checked = False
            If TypeOf ctrl Is Janus.Windows.EditControls.UIGroupBox Then
                For Each ctrl2 As Control In ctrl.Controls
                    If TypeOf ctrl2 Is Janus.Windows.GridEX.EditControls.EditBox Then CType(ctrl2, Janus.Windows.GridEX.EditControls.EditBox).Text = ""
                    If TypeOf ctrl2 Is Janus.Windows.GridEX.EditControls.NumericEdit Then CType(ctrl2, Janus.Windows.GridEX.EditControls.NumericEdit).Value = "0"
                    If TypeOf ctrl2 Is Janus.Windows.EditControls.UICheckBox Then CType(ctrl2, Janus.Windows.EditControls.UICheckBox).Checked = False
                    If TypeOf ctrl2 Is Janus.Windows.CalendarCombo.CalendarCombo Then CType(ctrl2, Janus.Windows.CalendarCombo.CalendarCombo).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    If TypeOf ctrl2 Is Janus.Windows.GridEX.EditControls.MultiColumnCombo Then CType(ctrl2, Janus.Windows.GridEX.EditControls.MultiColumnCombo).SelectedIndex = -1
                    If TypeOf ctrl2 Is Janus.Windows.EditControls.UICheckBox Then CType(ctrl2, Janus.Windows.EditControls.UICheckBox).Checked = False
                    If TypeOf ctrl2 Is Janus.Windows.GridEX.EditControls.NumericEditBox Then CType(ctrl2, Janus.Windows.GridEX.EditControls.NumericEditBox).Value = "0"
                    If TypeOf ctrl2 Is Janus.Windows.EditControls.UIGroupBox Then
                        For Each ctrl3 As Control In ctrl2.Controls
                            If TypeOf ctrl3 Is Janus.Windows.GridEX.EditControls.EditBox Then CType(ctrl3, Janus.Windows.GridEX.EditControls.EditBox).Text = ""
                            If TypeOf ctrl3 Is Janus.Windows.GridEX.EditControls.NumericEdit Then CType(ctrl3, Janus.Windows.GridEX.EditControls.NumericEdit).Value = "0"
                            If TypeOf ctrl3 Is Janus.Windows.EditControls.UICheckBox Then CType(ctrl3, Janus.Windows.EditControls.UICheckBox).Checked = False
                            If TypeOf ctrl3 Is Janus.Windows.CalendarCombo.CalendarCombo Then CType(ctrl3, Janus.Windows.CalendarCombo.CalendarCombo).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                            If TypeOf ctrl3 Is Janus.Windows.GridEX.EditControls.MultiColumnCombo Then CType(ctrl3, Janus.Windows.GridEX.EditControls.MultiColumnCombo).SelectedIndex = -1
                            If TypeOf ctrl3 Is Janus.Windows.EditControls.UICheckBox Then CType(ctrl3, Janus.Windows.EditControls.UICheckBox).Checked = False
                            If TypeOf ctrl3 Is Janus.Windows.GridEX.EditControls.NumericEditBox Then CType(ctrl3, Janus.Windows.GridEX.EditControls.NumericEditBox).Value = "0"
                        Next
                    End If
                Next
            End If
            If TypeOf ctrl Is Janus.Windows.GridEX.EditControls.MultiColumnCombo Then CType(ctrl, Janus.Windows.GridEX.EditControls.MultiColumnCombo).SelectedIndex = -1
            If TypeOf ctrl Is Janus.Windows.GridEX.EditControls.EditBox Then CType(ctrl, Janus.Windows.GridEX.EditControls.EditBox).Text = ""
            If TypeOf ctrl Is Janus.Windows.GridEX.EditControls.NumericEdit Then CType(ctrl, Janus.Windows.GridEX.EditControls.NumericEdit).Value = "0"
        Next
    End Sub
    Public Sub FillYesNoCombo(ByVal ctrl As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim _Active As New List(Of ActiveCB)

        _Active.Add(New ActiveCB With {.Name = "ΟΧΙ", .ID = 0})
        _Active.Add(New ActiveCB With {.Name = "ΝΑΙ", .ID = 1})

        ctrl.DataSource = _Active
        ctrl.DisplayMember = "name"
        ctrl.ValueMember = "ID"
        ctrl.SettingsKey = "id"
    End Sub
    Class ActiveCB
        Property Name As String
        Property ID As Byte
    End Class
    Public Sub FillRepeatEveryCombo(ByVal ctrl As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim _Active As New List(Of ActiveCB)

        _Active.Add(New ActiveCB With {.Name = "", .ID = 0})
        _Active.Add(New ActiveCB With {.Name = "Εβδομάδα", .ID = 1})
        _Active.Add(New ActiveCB With {.Name = "15 Μέρες", .ID = 2})
        _Active.Add(New ActiveCB With {.Name = "Μήνα", .ID = 3})
        _Active.Add(New ActiveCB With {.Name = "Δίμηνο", .ID = 4})
        _Active.Add(New ActiveCB With {.Name = "Τρίμηνο", .ID = 5})
        _Active.Add(New ActiveCB With {.Name = "Εξάμηνο", .ID = 6})
        _Active.Add(New ActiveCB With {.Name = "Έτος", .ID = 7})

        ctrl.DataSource = _Active
        ctrl.DisplayMember = "name"
        ctrl.ValueMember = "ID"
        ctrl.SettingsKey = "id"
    End Sub
    Public Function SetWhereClause(ByVal TB As DataTable, ByVal sFind As String) As String
        Dim i As Integer
        Dim Cols As String
        Cols = ""
        For i = 0 To TB.Columns.Count - 1
            Select Case TB.Columns(i).DataType.Name.ToString()
                Case "Guid"
                Case "Boolean"
                Case "Byte"
                Case "Char"
                Case "DateTime"  'Cols = Cols + IIf(Cols.Length > 0, " OR ", "") + TB.Columns(i).ColumnName & sFind
                Case "Decimal"
                Case "Double"
                Case "Int16" : Cols = Cols + IIf(Cols.Length > 0, " OR ", "") + "Convert( [" + TB.Columns(i).ColumnName + "], 'System.String') LIKE '%" + sFind + "%'"
                Case "Int32" : Cols = Cols + IIf(Cols.Length > 0, " OR ", "") + "Convert( [" + TB.Columns(i).ColumnName + "], 'System.String') LIKE '%" + sFind + "%'"
                Case "Int64" : Cols = Cols + IIf(Cols.Length > 0, " OR ", "") + "Convert( [" + TB.Columns(i).ColumnName + "], 'System.String') LIKE '%" + sFind + "%'"
                Case "SByte"
                Case "Single"
                Case "String" : Cols = Cols + IIf(Cols.Length > 0, " OR ", "") + "[" + TB.Columns(i).ColumnName + "] LIKE '%" + sFind + "%'"
                Case "TimeSpan"
                Case "UInt16"
                Case "UInt32"
                Case "UInt64"
            End Select
        Next
        Return Cols
    End Function

    Sub MenuTextChanged(ByVal sender As Object, ByVal e As EventArgs)
        'Dim item2 As New ToolStripTextBox
        'item2 = sender
        'item2.OwnerItem.Text = item2.Text
        'frmMain.dbView.Columns(item2.Tag).HeaderText = item2.Text
    End Sub
    'Μειώνει τα Refresh του GRID και αυξάνει την ταχύτητα
    Public Sub EnableDoubleBuffered(ByVal dgv As DataGridView)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, True, Nothing)
    End Sub
    'Επισστρέφει το νέο GUID που καταχωρήθηκε
    Public Function GetLastSavedGuid(ByVal sTable As String, ByVal sCode As Integer) As String
        Dim sSQL As String
        sSQL = "SELECT ID  FROM " & sTable & " where code =" & sCode

        Dim cmd As OleDbCommand = New OleDbCommand(sSQL, cn)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then GetLastSavedGuid = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString Else GetLastSavedGuid = ""
        sdr.Close()

    End Function
    Public Sub FillJanuscboDOY(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT  id,name from vw_DOY order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""
    End Sub
    Public Sub FillJanuscboPAY(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT  id,name from vw_PAY order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""
    End Sub
    Public Sub FillJanuscboCOU(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT id,name from vw_COU order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""

    End Sub
    Public Sub FillJanuscboUSERS(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT id,fullname from vw_USERS order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "fullname"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""

    End Sub
    Public Sub FillJanuscboSDT(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT id,name,descr from SDT order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.DisplayMember = "descr"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""

    End Sub
    Public Sub FillJanuscboDOS(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT id,name,iscancel,iscollection,ishand from DOS order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""

    End Sub
    Public Sub FillJanuscboMonths(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT code,name from MONTHS order by code"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "code"
        cbo.SettingsKey = "code"
        cbo.Text = ""
    End Sub
    Public Sub FillJanuscboYears(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT name from YEARS order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "name"
        cbo.SettingsKey = "name"
        cbo.Text = ""
    End Sub

    Public Sub FillJanuscboPRF(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT id,name from vw_prf order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""

    End Sub

    Public Sub FillJanuscboCUSTYPE(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT id,name from vw_CUSTYPE order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""

    End Sub
    Public Sub FillJanuscboAREA(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo, Optional ByVal id As String = "00000000-0000-0000-0000-000000000000", Optional ByVal W As String = "")
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String
        sql = "SELECT * from AREAS where couid = '" & id & "' order by name"
        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.DataSource = ds.Tables(0)
    End Sub
    Public Sub FillJanuscboCUS(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo, Optional Filter As String = "0")
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        If Filter = "0" Then
            sql = "SELECT id,(lastname + ' ' + name) as name,afm,(address + ' ' + ar) as ADR from cus order by lastname"
        Else
            sql = "SELECT id,(lastname + ' ' + name) as name,afm,(address + ' ' + ar) as ADR from cus where " & Filter & " order by lastname"
        End If
        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""

    End Sub
    Public Sub FillJanuscboVEHT(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT  id,name from vw_VEHT order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
    End Sub
    Public Sub FillJanuscboVEH(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT vw_VEH.id,plate,name from vw_VEH left join vw_VEHT on vw_VEHT.id = vw_VEH.vehtid order by plate"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "plate"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""
    End Sub
    Public Sub FillJanuscboDRV(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT id,(lastname + ' ' + name) as name,afm,(address + ' ' + ar) as ADR,salary from vw_DRV order by lastname"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""

    End Sub
    Public Sub FillJanuscboSTI(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT id,name from vw_STI "

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""

    End Sub
    Public Sub FillJanuscboEXCAT(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT id, name from [vw_EXCAT] order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""

    End Sub
    Public Sub FillJanuscboBANKS(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT id, name from [vw_BANKS] order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""

    End Sub
    Public Sub FillJanuscboFPA(ByRef cbo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT id, name from FPA order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cbo.DataSource = ds.Tables(0)
        cbo.DisplayMember = "name"
        cbo.ValueMember = "id"
        cbo.SettingsKey = "id"
        cbo.Text = ""

    End Sub
End Module
