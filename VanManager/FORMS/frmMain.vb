Imports System.Data.OleDb
Imports System.Xml
Imports Janus.Windows.GridEX

Public Class frmMain
    Private bs1 As New BindingSource
    Private adapter As New OleDb.OleDbDataAdapter
    Private ds As DataSet = New DataSet
    Private TB As DataTable
    Private Frm As Byte
    Private fieldChoser As frmFieldChooser
    Private mContextMenuColumn As GridEXColumn
    Private ColWithoutSelection As String
    Private ColWithSelection As String
    Enum FormName
        DOY = 1
        CUS = 2
        AREAS = 3
        COU = 4
        DRV = 5
        EXCAT = 6
        VEH = 7
        HLP = 8
        ROUTES = 9
        ES = 10
        PRF = 11
        PAR = 12
        VEHT = 13
        STI = 14
        EX = 15
        COL = 16
        INV = 17
        HLP_ROUTES = 18
        SYG_INV = 19
        CUSTYPE = 20
        HAND_INV = 21
        PARD = 22
        PAY = 23
        DOS = 24
        SDT = 25
        USERS = 26
        STS = 27
        FPA = 28
    End Enum
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UDLStr = Application.StartupPath & "\UDL\van.udl"
        If Not Main.OpenConnection() Then
            MessageBox.Show("Η σύνδεση με τον Server δεν είναι εφικτή", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.Text = Me.Text & "   -  SQL Server: " & Main.cn.DataSource.ToString & "   -  Database: " & Main.cn.Database.ToString
        GridMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        'Φορτώνει την πλαϊνή μπάρα
        LoadLayout()
        'Disable RibbonBar
        ButtonCommand1.Enabled = False
        ButtonCommand2.Enabled = False
        ButtonCommand3.Enabled = False
        ButtonCommand4.Enabled = False
        ButtonCommand5.Enabled = False
        ButtonCommand6.Enabled = False
        ButtonCommand7.Enabled = False
        ButtonCommand8.Enabled = False
        ButtonCommand9.Enabled = False
        'Hide Group Date 
        grpSearch.Visible = False

        'Μήνες
        FillJanuscboMonths(cboMONTHS)
        cboMONTHS.Value = System.DateTime.Now.Month
        'Ετοι
        FillJanuscboYears(cboYears)
        cboYears.Value = System.DateTime.Now.Year
    End Sub


    Public Sub FillJanusGrid(ByVal TableName As String)
        Dim sql As String
        Dim table As New DataTable
        table.Columns.Clear()
        GridMain.DataSource = Nothing
        table.Clear()
        Select Case TableName
            Case "DOY" : sql = "select * from vw_DOY"
            Case "CUS" : sql = "select * from vw_CUS"
            Case "DRV" : sql = "select * from vw_DRV"
            Case "COU" : sql = "select * from vw_COU"
            Case "AREAS" : sql = "select * from vw_AREAS"
            Case "EXCAT" : sql = "select * from vw_EXCAT"
            Case "VEH" : sql = "select * from vw_VEH"
            Case "PAY" : sql = "select * from vw_PAY"
            Case "HLP" : sql = "select * from vw_HLP"
            Case "ROUTES" : sql = "select * from vw_ROUTES"
            Case "ES" : sql = "select * from vw_ES"' "EXEC sp_FindStringInTable '%" & tblFilter.Text & "%' , 'ES'"
            Case "PRF" : sql = "select * from VW_PRF"
            Case "VEHT" : sql = "select * from VW_VEHT"
            Case "PARH" : sql = "select * from VW_PARH"
            Case "PARD" : sql = "select * from VW_PARD"
            Case "STI" : sql = "select * from VW_STI"
            Case "EX" : sql = "select * from vw_EX"
            Case "COLH" : sql = "SELECT  * FROM vw_COL order by paydate"
            Case "INV" : sql = "SELECT  * FROM vw_INVOICES where invhsygid is null order by invdate"
            Case "HLP_ROUTES" : sql = "SELECT  * FROM vw_HLP_ROUTES order by dtCreated"
            Case "SYG_INV" : sql = "SELECT  * FROM vw_INVOICESSYG order by invdate"
            Case "CUSTYPE" : sql = "select * from VW_CUSTYPE"
            Case "HAND_INV" : sql = "SELECT  * FROM vw_INVOICES where invhsygid is null  and vw_INVOICES.sdtid in(select SDT.id from SDT 
                                                     inner join sts on sts.sdtid = sdt.id 
                                                     inner join dos on dos.id = sts.dosid 
                                                     inner join users on users.id  = sts.userid  where ishand =1 and sts.userid = '" & UserID & "') order by invdate"
            Case "DOS" : sql = "select * from DOS"
            Case "SDT" : sql = "select * from SDT"
            Case "USERS" : sql = "select * from USERS"
            Case "STS" : sql = "select * from vw_STS"
            Case "FPA" : sql = "select * from FPA"
        End Select
        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(table) : TB = table
        bs1.DataSource = table
        GridMain.SetDataBinding(table, "")
        GridMain.RetrieveStructure()
        GridMain.FilterRowButtonStyle = FilterRowButtonStyle.ConditionOperatorDropDown
        FormatGrid(GridMain)

        Dim strLayoutPath As String
        strLayoutPath = Application.StartupPath & "\LayOuts\GridMain" & GridMain.Tag & ".gxl"
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
        'Φόρτωση Φίλτρα Ημερομηνίας
        Dim fi2 As System.IO.FileInfo = New System.IO.FileInfo(strLayoutPath & "_DateFilters.xml")
        If fi2.Exists Then
            Try
                Dim xml_doc As New Xml.XmlDocument
                xml_doc.Load(strLayoutPath & "_DateFilters.xml")

                ' Get the desired children.
                Dim xnNode As XmlNode = xml_doc.SelectSingleNode("DateFilters/FDate")
                dtFromDate.Value = xnNode.InnerText
                xnNode = xml_doc.SelectSingleNode("DateFilters/TDate")
                dtToDate.Value = xnNode.InnerText

            Catch exc As Exception
                MessageBox.Show(exc.Message)
            End Try
        End If

        cmdSearch.PerformClick()

    End Sub
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Main.CloseConnection(cn)
    End Sub
    Private Sub NewRecord()
        Dim FRMS As New Form
        Select Case Frm
            Case FormName.DOY : frmDoy.Mode = FormMode.NewRecord : FRMS = frmDoy
            Case FormName.PAY : frmPAY.Mode = FormMode.NewRecord : FRMS = frmPAY
            Case FormName.CUS : frmCus.Mode = FormMode.NewRecord : FRMS = frmCus
            Case FormName.DRV : frmDRV.Mode = FormMode.NewRecord : FRMS = frmDRV
            Case FormName.COU : frmCou.Mode = FormMode.NewRecord : FRMS = frmCou
            Case FormName.AREAS : frmArea.Mode = FormMode.NewRecord : FRMS = frmArea
            Case FormName.EXCAT : frmEXcat.Mode = FormMode.NewRecord : FRMS = frmEXcat
            Case FormName.VEH : frmVeh.Mode = FormMode.NewRecord : FRMS = frmVeh
            Case FormName.HLP : frmHelpers.Mode = FormMode.NewRecord : FRMS = frmHelpers
            Case FormName.ROUTES : FrmRoute.Mode = FormMode.NewRecord : FRMS = FrmRoute
            Case FormName.ES : Exit Sub': frmES.Mode = FormMode.NewRecord : FRMS = frmES
            Case FormName.EX : frmEX.Mode = FormMode.NewRecord : FRMS = frmEX
            Case FormName.PRF : frmprf.Mode = FormMode.NewRecord : FRMS = frmprf
            Case FormName.VEHT : frmVeht.Mode = FormMode.NewRecord : FRMS = frmVeht
            Case FormName.PAR : frmParking.Mode = FormMode.NewRecord : FRMS = frmParking
            Case FormName.STI : frmSti.Mode = FormMode.NewRecord : FRMS = frmSti
            Case FormName.COL : frmCollections.Mode = FormMode.NewRecord : FRMS = frmCollections
            Case FormName.SYG_INV : frmSygInvoices.Mode = FormMode.NewRecord : FRMS = frmSygInvoices
            Case FormName.CUSTYPE : frmCUSTYPE.Mode = FormMode.NewRecord : FRMS = frmCUSTYPE
            Case FormName.DOS : FrmDOS.Mode = FormMode.NewRecord : FRMS = FrmDOS
            Case FormName.SDT : frmSDT.Mode = FormMode.NewRecord : FRMS = frmSDT
            Case FormName.USERS : frmUSERS.Mode = FormMode.NewRecord : FRMS = frmUSERS
            Case FormName.STS : frmSTS.Mode = FormMode.NewRecord : FRMS = frmSTS
            Case FormName.FPA : frmFPA.Mode = FormMode.NewRecord : FRMS = frmFPA
        End Select
        FRMS.Owner = Me
        FRMS.Show()
    End Sub

    Private Sub EditRecord()
        Dim FRMS As New Form
        Dim Row1 As Janus.Windows.GridEX.GridEXRow
        Row1 = GridMain.CurrentRow

        Select Case Frm
            Case FormName.DOY : frmDoy.Mode = FormMode.EditRecord : FRMS = frmDoy
            Case FormName.PAY : frmPAY.Mode = FormMode.EditRecord : FRMS = frmPAY
            Case FormName.CUS : frmCus.Mode = FormMode.EditRecord : FRMS = frmCus
            Case FormName.DRV : frmDRV.Mode = FormMode.EditRecord : FRMS = frmDRV
            Case FormName.COU : frmCou.Mode = FormMode.EditRecord : FRMS = frmCou
            Case FormName.AREAS : frmArea.Mode = FormMode.EditRecord : FRMS = frmArea
            Case FormName.EXCAT : frmEXcat.Mode = FormMode.EditRecord : FRMS = frmEXcat
            Case FormName.VEH : frmVeh.Mode = FormMode.EditRecord : FRMS = frmVeh
            Case FormName.HLP : frmHelpers.Mode = FormMode.EditRecord : FRMS = frmHelpers
            Case FormName.ROUTES : FrmRoute.Mode = FormMode.EditRecord : FRMS = FrmRoute
            Case FormName.ES : Exit Sub': frmES.Mode = FormMode.EditRecord : FRMS = frmES
            Case FormName.EX : frmEX.Mode = FormMode.EditRecord : FRMS = frmEX
            Case FormName.PRF : frmprf.Mode = FormMode.EditRecord : FRMS = frmprf
            Case FormName.VEHT : frmVeht.Mode = FormMode.EditRecord : FRMS = frmVeht
            Case FormName.PAR : frmParking.Mode = FormMode.EditRecord : FRMS = frmParking
            Case FormName.STI : frmSti.Mode = FormMode.EditRecord : FRMS = frmSti
            Case FormName.COL : frmCollections.Mode = FormMode.EditRecord : FRMS = frmCollections
            Case FormName.INV : frmInvoice.Mode = FormMode.EditRecord
                frmInvoice.RouteID = Row1.Cells("RouteID").Value.ToString()
                If Row1.Cells("idakiromeno").Value.ToString() <> "" Then frmInvoice.IsAkirotiko = True
                frmInvoice.INVID = Row1.Cells("id").Value.ToString()
                FRMS = frmInvoice
            Case FormName.HLP_ROUTES : FrmRoute.Mode = FormMode.EditRecord : FRMS = FrmRoute
            Case FormName.SYG_INV : frmInvoice.Mode = FormMode.EditRecord
                frmInvoice.SYGID = Row1.Cells("ID").Value.ToString()
                If Row1.Cells("idakiromeno").Value.ToString() <> "" Then frmInvoice.IsAkirotiko = True
                FRMS = frmInvoice
            Case FormName.CUSTYPE : frmCUSTYPE.Mode = FormMode.EditRecord : FRMS = frmCUSTYPE
            Case FormName.DOS : FrmDOS.Mode = FormMode.EditRecord : FRMS = FrmDOS
            Case FormName.SDT : frmSDT.Mode = FormMode.EditRecord : FRMS = frmSDT
            Case FormName.USERS : frmUSERS.Mode = FormMode.EditRecord : FRMS = frmUSERS
            Case FormName.STS : frmSTS.Mode = FormMode.EditRecord : FRMS = frmSTS
            Case FormName.FPA : frmFPA.Mode = FormMode.EditRecord : FRMS = frmFPA
        End Select
        FRMS.Owner = Me
        FRMS.Show()
    End Sub

    Private Sub ViewRecord()
        Dim FRMS As New Form
        Dim Row1 As Janus.Windows.GridEX.GridEXRow
        Row1 = GridMain.CurrentRow
        Select Case Frm
            Case FormName.DOY : frmDoy.Mode = FormMode.ViewRecord : FRMS = frmDoy
            Case FormName.PAY : frmPAY.Mode = FormMode.ViewRecord : FRMS = frmPAY
            Case FormName.CUS : frmCus.Mode = FormMode.ViewRecord : FRMS = frmCus
            Case FormName.DRV : frmDRV.Mode = FormMode.ViewRecord : FRMS = frmDRV
            Case FormName.COU : frmCou.Mode = FormMode.ViewRecord : FRMS = frmCou
            Case FormName.AREAS : frmArea.Mode = FormMode.ViewRecord : FRMS = frmArea
            Case FormName.EXCAT : frmEXcat.Mode = FormMode.ViewRecord : FRMS = frmEXcat
            Case FormName.VEH : frmVeh.Mode = FormMode.ViewRecord : FRMS = frmVeh
            Case FormName.HLP : frmHelpers.Mode = FormMode.ViewRecord : FRMS = frmHelpers
            Case FormName.ROUTES : FrmRoute.Mode = FormMode.ViewRecord : FRMS = FrmRoute
            Case FormName.ES : Exit Sub': frmES.Mode = FormMode.ViewRecord : FRMS = frmES
            Case FormName.EX : frmEX.Mode = FormMode.ViewRecord : FRMS = frmEX
            Case FormName.PRF : frmprf.Mode = FormMode.ViewRecord : FRMS = frmprf
            Case FormName.VEHT : frmVeht.Mode = FormMode.ViewRecord : FRMS = frmVeht
            Case FormName.PAR : frmParking.Mode = FormMode.ViewRecord : FRMS = frmParking
            Case FormName.STI : frmSti.Mode = FormMode.ViewRecord : FRMS = frmSti
            Case FormName.COL : frmCollections.Mode = FormMode.ViewRecord : FRMS = frmCollections
            Case FormName.HLP_ROUTES : FrmRoute.Mode = FormMode.ViewRecord : FRMS = FrmRoute
            Case FormName.INV : frmInvoice.Mode = FormMode.ViewRecord
                frmInvoice.RouteID = Row1.Cells("RouteID").Value.ToString()
                If Row1.Cells("idakiromeno").Value.ToString() <> "" Then frmInvoice.IsAkirotiko = True
                frmInvoice.INVID = Row1.Cells("id").Value.ToString()
                FRMS = frmInvoice
            Case FormName.SYG_INV : frmInvoice.Mode = FormMode.ViewRecord
                frmInvoice.SYGID = Row1.Cells("ID").Value.ToString()
                If Row1.Cells("idakiromeno").Value.ToString() <> "" Then frmInvoice.IsAkirotiko = True
                FRMS = frmInvoice
            Case FormName.CUSTYPE : frmCUSTYPE.Mode = FormMode.ViewRecord : FRMS = frmCUSTYPE
            Case FormName.DOS : FrmDOS.Mode = FormMode.ViewRecord : FRMS = FrmDOS
            Case FormName.SDT : frmSDT.Mode = FormMode.ViewRecord : FRMS = frmSDT
            Case FormName.USERS : frmUSERS.Mode = FormMode.ViewRecord : FRMS = frmUSERS
            Case FormName.STS : frmSTS.Mode = FormMode.ViewRecord : FRMS = frmSTS
            Case FormName.FPA : frmFPA.Mode = FormMode.ViewRecord : FRMS = frmFPA
        End Select
        FRMS.Owner = Me
        FRMS.Show()
    End Sub
    ' Διαγραφή Δεδομένων
    Private Sub DeleteRecord()
        Dim sSQL As String
        Dim Row1 As Janus.Windows.GridEX.GridEXRow
        Row1 = GridMain.CurrentRow

        Try
            If GridMain.RecordCount = 0 Then Exit Sub
            If Frm = FormName.COL Then
                If GridMain.CurrentRow.Cells("dosname").Value.ToString <> "" Then
                    MessageBox.Show("Δεν μπορεί να διαγραφεί η απόδειξη γιατί έχει εκτυπωθεί", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            If MessageBox.Show("Να διαγραφεί η επιλεγμένη εγγραφή?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                Select Case Frm
                    Case FormName.DOY
                        sSQL = "Delete from doy where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("DOY")
                        End Using
                    Case FormName.PAY
                        sSQL = "Delete from PAY where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("PAY")
                        End Using
                    Case FormName.CUS
                        sSQL = "Delete from cus where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("CUS")
                        End Using
                    Case FormName.DRV
                        sSQL = "Delete from DRV where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("DRV")
                        End Using
                    Case FormName.COU
                        sSQL = "Delete from COU where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("COU")
                        End Using
                    Case FormName.AREAS
                        sSQL = "Delete from AREAS where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("AREAS")
                        End Using
                    Case FormName.EXCAT
                        sSQL = "Delete from EXCAT where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("EXCAT")
                        End Using
                    Case FormName.VEH
                        sSQL = "Delete from VEH where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("VEH")
                        End Using
                    Case FormName.HLP
                        sSQL = "Delete from HLP where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("HLP")
                        End Using
                    Case FormName.ROUTES
                        sSQL = "Delete from ROUTES where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("ROUTES")
                        End Using
                    Case FormName.ES
                        sSQL = "Delete from es where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("ES")
                        End Using
                    Case FormName.PRF
                        sSQL = "Delete from PRF where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("PRF")
                        End Using
                    Case FormName.CUSTYPE
                        sSQL = "Delete from CUSTYPE  where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("CUSTYPE")
                        End Using
                    Case FormName.VEHT
                        sSQL = "Delete from VEHT where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("VEHT")
                        End Using
                    Case FormName.PAR
                        sSQL = "Delete from PARH where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("PARH")
                        End Using
                    Case FormName.STI
                        sSQL = "Delete from STI where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("STI")
                        End Using
                    Case FormName.EX
                        sSQL = "Delete from EX where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("EX")
                        End Using
                    Case FormName.COL
                        sSQL = "DELETE COLD  WHERE colID='" & Row1.Cells("id").Value.ToString & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "Delete from COLH where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("COLH")
                        End Using
                        'Ενημέρωση τιμολογίου ότι δεν πληρώθηκε
                        sSQL = "UPDATE INVH   SET paid =0
		                        FROM INVH 
		                        inner join COLD on COLD.invhid = INVH.id
		                        where colID='" & Row1.Cells("id").Value.ToString & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                        End Using
                        'Ενημέρωση τιμολογίου ότι δεν πληρώθηκε
                        sSQL = "UPDATE INVHSYG   SET paid =0
		                        FROM INVHSYG 
		                        inner join COLD on COLD.invhsygid = INVHSYG .id
		                        where colID='" & Row1.Cells("id").Value.ToString & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Case FormName.DOS
                        sSQL = "Delete from DOS where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("DOS")
                        End Using
                    Case FormName.SDT
                        sSQL = "Delete from SDT where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("SDT")
                        End Using
                    Case FormName.USERS
                        sSQL = "Delete from USERS where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("USERS")
                        End Using
                    Case FormName.STS
                        sSQL = "Delete from sts where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("STS")
                        End Using
                    Case FormName.FPA
                        sSQL = "Delete from FPA where id = '" & Row1.Cells("ID").Value.ToString() & "'"
                        Using oCmd As New OleDbCommand(sSQL, cn)
                            oCmd.ExecuteNonQuery()
                            FillJanusGrid("FPA")
                        End Using

                End Select
            End If
        Catch myOLEDBException As OleDbException 'ole db exception
            'If myOLEDBException.ErrorCode.ToString = "-2147217873" Then
            MessageBox.Show(myOLEDBException.ErrorCode.ToString + vbCrLf + myOLEDBException.Message.ToString + vbCrLf + myOLEDBException.Source.ToString)
        End Try
    End Sub
    Private Sub tblFilter_TextChanged(sender As Object, e As EventArgs)
        Dim FilteredRows As DataRow() = TB.Select(SetWhereClause(TB, txtFilter.Text))
        If (FilteredRows.Any()) Then
            GridMain.DataSource = FilteredRows.CopyToDataTable()
        Else
            GridMain.DataSource = Nothing
        End If
    End Sub

    Private Sub RefreshRecords()
        txtFilter.Text = ""
        Select Case Frm
            Case FormName.DOY : FillJanusGrid("DOY")
            Case FormName.PAY : FillJanusGrid("PAY")
            Case FormName.CUS : FillJanusGrid("CUS")
            Case FormName.COU : FillJanusGrid("COU")
            Case FormName.AREAS : FillJanusGrid("AREAS")
            Case FormName.DRV : FillJanusGrid("DRV")
            Case FormName.EXCAT : FillJanusGrid("EXCAT")
            Case FormName.VEH : FillJanusGrid("VEH")
            Case FormName.HLP : FillJanusGrid("HLP")
            Case FormName.ROUTES : FillJanusGrid("ROUTES")
            Case FormName.ES : FillJanusGrid("ES")
            Case FormName.PRF : FillJanusGrid("PRF")
            Case FormName.VEHT : FillJanusGrid("VEHT")
            Case FormName.PAR : FillJanusGrid("PARH")
            Case FormName.STI : FillJanusGrid("STI")
            Case FormName.EX : FillJanusGrid("EX")
            Case FormName.COL : FillJanusGrid("COLH")
            Case FormName.INV : FillJanusGrid("INV")
            Case FormName.HLP_ROUTES : FillJanusGrid("HLP_ROUTES")
            Case FormName.SYG_INV : FillJanusGrid("SYG_INV")
            Case FormName.CUSTYPE : FillJanusGrid("CUSTYPE")
            Case FormName.PARD : FillJanusGrid("PARD")
            Case FormName.DOS : FillJanusGrid("DOS")
            Case FormName.SDT : FillJanusGrid("SDT")
            Case FormName.USERS : FillJanusGrid("USERS")
            Case FormName.STS : FillJanusGrid("STS")
            Case FormName.FPA : FillJanusGrid("FPA")
        End Select
    End Sub

    Private Sub SaveGrid()
        Dim strLayoutPath As String
        strLayoutPath = Application.StartupPath & "\LayOuts\GridMain" & GridMain.Tag & ".gxl"
        Try
            Dim stream As System.IO.FileStream = New System.IO.FileStream(strLayoutPath, IO.FileMode.Create)
            GridMain.SaveLayoutFile(stream)
            stream.Close()
            SaveDateFilter(strLayoutPath)
            'Αποθήκευσ Πλαϊνής μπάρας
            SaveLayout()
            MessageBox.Show("Η Όψη αποθηκεύθηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch

        End Try
    End Sub
    Private Sub SaveDateFilter(ByVal sGridPath As String)
        Try
            Dim writer As New XmlTextWriter(sGridPath & "_DateFilters.xml", System.Text.Encoding.UTF8)
            writer.WriteStartDocument(True)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 2
            writer.WriteStartElement("DateFilters")
            writer.WriteStartElement("FDate")
            writer.WriteString(dtFromDate.Value)
            writer.WriteEndElement()
            writer.WriteStartElement("TDate")
            writer.WriteString(dtToDate.Value)
            writer.WriteEndElement()
            writer.WriteEndDocument()
            writer.Close()
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try

    End Sub
    Private Sub DeleteGrid()
        Dim FileToDelete As String
        If MessageBox.Show("Θέλετε να διαγραφεί η όψη?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            FileToDelete = Application.StartupPath & "\LayOuts\GridMain" & GridMain.Tag & ".gxl"

            If System.IO.File.Exists(FileToDelete) = True Then
                System.IO.File.Delete(FileToDelete)
                FileToDelete = Application.StartupPath & "\LayOuts\GridMain" & GridMain.Tag & ".gxl" & "_DateFilters.xml"
                If System.IO.File.Exists(FileToDelete) = True Then System.IO.File.Delete(FileToDelete)
                MessageBox.Show("Η Όψη διαγράφηκε με επιτυχία", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub PrintGrid()
        frmPPreview.Owner = Me
        frmPPreview.GridEXPrintDocument1.GridEX = GridMain
        frmPPreview.Show()

    End Sub
    Private Sub GridToExcel()
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
    Private Sub cmdExit_Click(sender As Object, e As EventArgs)
        Me.Close()
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
    Private Sub ShowCellMenu(ByVal column As GridEXColumn, ByVal sMenu As Byte)
        Select Case sMenu
            Case 0 : Me.cmdInv.Show(GridMain)
            Case 1 : Me.cmdFilters.Show(GridMain)
            Case 2 : Me.cmdCellChoices.Show(GridMain)
        End Select

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
    Private Sub SaveLayout()
        Dim layoutDir As String = Application.StartupPath & "\LayOuts\ButtonBarLayout.xml"
        Dim layoutStream As System.IO.FileStream = New System.IO.FileStream(layoutDir, System.IO.FileMode.Create)
        BBMain.SaveLayoutFile(layoutStream)
        layoutStream.Close()
    End Sub

    Private Sub LoadLayout()

        Dim layoutDir As String = Application.StartupPath & "\LayOuts\ButtonBarLayout.xml"
        Dim fi As System.IO.FileInfo = New System.IO.FileInfo(layoutDir)
        If fi.Exists Then
            Dim layoutStream As System.IO.FileStream = New System.IO.FileStream(layoutDir, System.IO.FileMode.Open)
            BBMain.LoadLayoutFile(layoutStream)
            layoutStream.Close()
        End If
    End Sub

    Private Sub RBMain_CommandClick(sender As Object, e As Janus.Windows.Ribbon.CommandEventArgs) Handles RBMain.CommandClick
        Select Case e.Command.Key
            Case "New" : NewRecord()
            Case "Edit" : EditRecord()
            Case "View" : ViewRecord()
            Case "Delete" : DeleteRecord()
            Case "Refresh" : RefreshRecords()
            Case "SaveL" : SaveGrid()
            Case "DeleteL" : DeleteGrid()
            Case "PrintL" : PrintGrid()
            Case "ExcelL" : GridToExcel()
            Case "ExitS", "ExitL" : Me.Close()
        End Select
    End Sub

    Private Sub BBMain_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BBMain.ItemClick
        Dim strLayoutPath As String

        '1η Μέρα του Μήνα
        dtFromDate.Value = New DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, 1)
        'Τελευταία Μέρα του Μήνα
        dtToDate.Value = New Date(System.DateTime.Now.Year, System.DateTime.Now.Month, Date.DaysInMonth(System.DateTime.Now.Year, System.DateTime.Now.Month))

        Select Case e.Item.Key
            Case "CUS" : grpSearch.Visible = False : Frm = FormName.CUS : GridMain.Tag = "CUS" : FillJanusGrid("CUS")
            Case "DRV" : grpSearch.Visible = False : Frm = FormName.DRV : GridMain.Tag = "DRV" : FillJanusGrid("DRV")
            Case "HLP" : grpSearch.Visible = False : Frm = FormName.HLP : GridMain.Tag = "HLP" : FillJanusGrid("HLP")
            Case "VEH" : grpSearch.Visible = False : Frm = FormName.VEH : GridMain.Tag = "VEH" : FillJanusGrid("VEH")
            Case "DOY" : grpSearch.Visible = False : Frm = FormName.DOY : GridMain.Tag = "DOY" : FillJanusGrid("DOY")
            Case "PRF" : grpSearch.Visible = False : Frm = FormName.PRF : GridMain.Tag = "PRF" : FillJanusGrid("PRF")
            Case "COU" : grpSearch.Visible = False : Frm = FormName.COU : GridMain.Tag = "COU" : FillJanusGrid("COU")
            Case "PAY" : grpSearch.Visible = False : Frm = FormName.PAY : GridMain.Tag = "PAY" : FillJanusGrid("PAY")
            Case "AREA" : grpSearch.Visible = False : Frm = FormName.AREAS : GridMain.Tag = "AREAS" : FillJanusGrid("AREAS")
            Case "PAR" : grpSearch.Visible = False : Frm = FormName.PAR : GridMain.Tag = "PARH" : FillJanusGrid("PARH")
            Case "PARD" : grpSearch.Visible = False : Frm = FormName.PARD : GridMain.Tag = "PARD" : FillJanusGrid("PARD")
            Case "VEHT" : grpSearch.Visible = False : Frm = FormName.VEHT : GridMain.Tag = "VEHT" : FillJanusGrid("VEHT")
            Case "STI" : grpSearch.Visible = False : Frm = FormName.STI : GridMain.Tag = "STI" : FillJanusGrid("STI")
            Case "EXCAT" : grpSearch.Visible = False : Frm = FormName.EXCAT : GridMain.Tag = "EXCAT" : FillJanusGrid("EXCAT")
            Case "ROUTES" : grpSearch.Visible = True : Frm = FormName.ROUTES : GridMain.Tag = "ROUTES" : FillJanusGrid("ROUTES")
            Case "ES" : grpSearch.Visible = True : Frm = FormName.ES : GridMain.Tag = "ES" : FillJanusGrid("ES")
            Case "COL" : grpSearch.Visible = False : Frm = FormName.COL : GridMain.Tag = "COL" : FillJanusGrid("COLH")
            Case "EX" : grpSearch.Visible = True : Frm = FormName.EX : GridMain.Tag = "EX" : FillJanusGrid("EX")
            Case "INV" : grpSearch.Visible = True : Frm = FormName.INV : GridMain.Tag = "INV" : FillJanusGrid("INV")
            Case "HLP_ROUTES" : grpSearch.Visible = True : Frm = FormName.HLP_ROUTES : GridMain.Tag = "HLP_ROUTES" : FillJanusGrid("HLP_ROUTES")
            Case "SYG_INV" : grpSearch.Visible = True : Frm = FormName.SYG_INV : GridMain.Tag = "SYG_INV" : FillJanusGrid("SYG_INV")
            Case "CUSTYPE" : grpSearch.Visible = False : Frm = FormName.CUSTYPE : GridMain.Tag = "CUSTYPE" : FillJanusGrid("CUSTYPE")
            Case "HAND_INV" : grpSearch.Visible = True : Frm = FormName.HAND_INV : GridMain.Tag = "HAND_INV" : FillJanusGrid("INV")
            Case "DOS" : grpSearch.Visible = False : Frm = FormName.DOS : GridMain.Tag = "DOS" : FillJanusGrid("DOS")
            Case "SDT" : grpSearch.Visible = False : Frm = FormName.SDT : GridMain.Tag = "SDT" : FillJanusGrid("SDT")
            Case "USERS" : grpSearch.Visible = False : Frm = FormName.USERS : GridMain.Tag = "USERS" : FillJanusGrid("USERS")
            Case "STS" : grpSearch.Visible = False : Frm = FormName.STS : GridMain.Tag = "STS" : FillJanusGrid("STS")
            Case "FPA" : grpSearch.Visible = False : Frm = FormName.FPA : GridMain.Tag = "FPA" : FillJanusGrid("FPA")
        End Select
        Select Case Frm
            Case FormName.HLP_ROUTES, FormName.PARD, FormName.ES
                ButtonCommand1.Enabled = False  'New Record
                ButtonCommand2.Enabled = False  'Edit Record
                ButtonCommand3.Enabled = False  'Delete Record
                ButtonCommand4.Enabled = False  'View Record
                ButtonCommand5.Enabled = True
                ButtonCommand6.Enabled = True
                ButtonCommand7.Enabled = True
                ButtonCommand8.Enabled = True
                ButtonCommand9.Enabled = True
            Case FormName.INV
                ButtonCommand1.Enabled = False  'New Record
                ButtonCommand2.Enabled = False  'Edit Record
                ButtonCommand3.Enabled = False  'Delete Record
                ButtonCommand4.Enabled = True   'View Record
                ButtonCommand5.Enabled = True
                ButtonCommand6.Enabled = True
                ButtonCommand7.Enabled = True
                ButtonCommand8.Enabled = True
                ButtonCommand9.Enabled = True
            Case FormName.SYG_INV
                ButtonCommand1.Enabled = True   'New Record
                ButtonCommand2.Enabled = False  'Edit Record
                ButtonCommand3.Enabled = False  'Delete Record
                ButtonCommand4.Enabled = True   'View Record
                ButtonCommand5.Enabled = True
                ButtonCommand6.Enabled = True
                ButtonCommand7.Enabled = True
                ButtonCommand8.Enabled = True
                ButtonCommand9.Enabled = True
            Case Else
                'Enable RibbonBar
                ButtonCommand1.Enabled = True   'New Record
                ButtonCommand2.Enabled = True   'Edit Record
                ButtonCommand3.Enabled = True   'Delete Reco
                ButtonCommand4.Enabled = True   'View Record
                ButtonCommand5.Enabled = True
                ButtonCommand6.Enabled = True
                ButtonCommand7.Enabled = True
                ButtonCommand8.Enabled = True
                ButtonCommand9.Enabled = True
        End Select

        'Φόρτωση Grid
        strLayoutPath = Application.StartupPath & "\LayOuts\GridMain" & GridMain.Tag & ".gxl"
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
        'Φόρτωση Φίλτρα Ημερομηνίας
        Dim fi2 As System.IO.FileInfo = New System.IO.FileInfo(strLayoutPath & "_DateFilters.xml")
        If fi2.Exists Then
            Try
                Dim xml_doc As New Xml.XmlDocument
                xml_doc.Load(strLayoutPath & "_DateFilters.xml")

                ' Get the desired children.
                Dim xnNode As XmlNode = xml_doc.SelectSingleNode("DateFilters/FDate")
                dtFromDate.Value = xnNode.InnerText
                xnNode = xml_doc.SelectSingleNode("DateFilters/TDate")
                dtToDate.Value = xnNode.InnerText

            Catch exc As Exception
                MessageBox.Show(exc.Message)
            End Try
        End If
        If grpSearch.Visible = True Then cmdSearch.PerformClick()
    End Sub
    Private Sub OnEkdosiAkirotikou()
        Dim Row1 As Janus.Windows.GridEX.GridEXRow
        Dim sCusid As String
        Try
            Row1 = GridMain.CurrentRow
            sCusid = Row1.Cells("MainCusID").Value.ToString()
            If Row1.Cells("idakirotiko").Value.ToString().Length > 0 Then
                MessageBox.Show("Έχει εκδοθεί ακυρωτικό για το τιμολόγιο αυτό.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Row1.Cells("idakiromeno").Value.ToString().Length > 0 Then
                MessageBox.Show("Δεν μπορείτε να ακυρώσετε ένα ακυρωτικό τιμολόγιο.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If MessageBox.Show("Να εκδοθεί ακυρωτικό τιμολόγιο?Θα γίνει διαγραφή των εξόδων για το συγκεκριμένο τιμολόγιο.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then

                'Καταχώρηση γραμμών
                Using oCmd As New OleDbCommand("EkdosiAkrotikou", cn)
                    oCmd.CommandType = 4
                    If GridMain.Tag = "SYG_INV" Then
                        oCmd.Parameters.AddWithValue("@invID", Row1.Cells("ID").Value.ToString())
                        oCmd.Parameters.AddWithValue("@isSyg", 1)
                        oCmd.ExecuteNonQuery()
                        FillJanusGrid("SYG_INV")
                    Else
                        oCmd.Parameters.AddWithValue("@invID", Row1.Cells("ID").Value.ToString())
                        oCmd.Parameters.AddWithValue("@isSyg", 0)
                        oCmd.ExecuteNonQuery()
                        FillJanusGrid("INV")
                    End If

                End Using

            End If
        Catch myOLEDBException As OleDbException 'ole db exception
            MessageBox.Show(myOLEDBException.ErrorCode.ToString + vbCrLf + myOLEDBException.Message.ToString + vbCrLf + myOLEDBException.Source.ToString)
        End Try
    End Sub
    Private Sub comManager_CommandControlValueChanged(sender As Object, e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles comManager.CommandControlValueChanged
        If e.Command.Key = "cmdRenameThisColumn" Then
            mContextMenuColumn.Caption = cmdRenameThisColumn.Control.Text
        End If
    End Sub
    Private Sub comManager2_CommandClick(sender As Object, e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles comManager2.CommandClick
        Select Case e.Command.Key
            Case "cmdAkirotiko" : OnEkdosiAkirotikou()
            Case "FChoice" : OnFilterWithSelection()
            Case "FWChoice" : OnFilterWithoutSelection()
            Case "FDefault" : ColWithoutSelection = "" : ColWithSelection = "" : RefreshRecords()
            Case "cmdRoutes"
                Dim FRMS As New Form
                Dim Row1 As Janus.Windows.GridEX.GridEXRow
                Row1 = GridMain.CurrentRow
                FRMS = frmGrid
                If GridMain.Tag = "SYG_INV" Then
                    frmGrid.SYGHID = Row1.Cells("ID").Value.ToString()
                Else
                    frmGrid.INVHID = Row1.Cells("ID").Value.ToString()
                End If


                FRMS.Owner = Me
                FRMS.Show()

        End Select
    End Sub
    Private Sub OnFilterWithSelection()
        Dim Row1 As Janus.Windows.GridEX.GridEXRow
        Dim Col As GridEXColumn
        Try
            Row1 = GridMain.CurrentRow
            Col = GridMain.CurrentColumn
            If ColWithSelection = "" Then
                Select Case GridMain.Tag
                    Case "ES", "ROUTES", "HLP_ROUTES", "EX"
                        ColWithSelection = "dtcreated >= #" & Format(dtFromDate.Value, "yyyy/MM/dd 00:00:00") & "# and dtcreated <= #" & Format(dtToDate.Value, "yyyy/MM/dd 23:59:59") & "#  "
                    Case "INV", "SYG_INV"
                        ColWithSelection = "invdate >= #" & Format(dtFromDate.Value, "yyyy/MM/dd 00:00:00") & "# and invdate <= #" & Format(dtToDate.Value, "yyyy/MM/dd 23:59:59") & "#  "
                End Select
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
                Select Case GridMain.Tag
                    Case "ES", "ROUTES", "HLP_ROUTES", "EX"
                        ColWithoutSelection = "dtcreated >= #" & Format(dtFromDate.Value, "yyyy/MM/dd 00:00:00") & "# and dtcreated <= #" & Format(dtToDate.Value, "yyyy/MM/dd 23:59:59") & "#  "
                    Case "INV", "SYG_INV"
                        ColWithoutSelection = "invdate >= #" & Format(dtFromDate.Value, "yyyy/MM/dd 00:00:00") & "# and invdate <= #" & Format(dtToDate.Value, "yyyy/MM/dd 23:59:59") & "#  "
                End Select
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
    Private Sub comManager_CommandClick(sender As Object, e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles comManager.CommandClick
        Select Case e.Command.Key
            Case "cmdRemoveThisColumn" : OnRemoveThisColumnCommand()
            Case "cmdFieldChooser" : OnFieldChooserCommand()
            Case Else
        End Select
    End Sub


    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        If GridMain.Tag = Nothing Then Exit Sub
        Dim FilteredRows As DataRow() = TB.Select(SetWhereClause(TB, txtFilter.Text))
        If (FilteredRows.Any()) Then
            GridMain.DataSource = FilteredRows.CopyToDataTable()
        Else
            GridMain.DataSource = Nothing
        End If
    End Sub
    Private Sub FormatGrid(ByVal GRD As Janus.Windows.GridEX.GridEX)
        For Each column As DataColumn In TB.Columns
            Select Case column.DataType.Name.ToString()
                Case "Decimal"
                    'Γραμμή Συνόλων
                    GRD.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
                    GRD.RootTable.Columns(column.ColumnName).AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum
                    GRD.RootTable.Columns(column.ColumnName).TotalFormatString = "c" 'Currency
                    GRD.RootTable.Columns(column.ColumnName).TextAlignment = TextAlignment.Far
                    GRD.TotalRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue
                    GRD.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
                    GRD.TotalRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                Case "Boolean"
                    GRD.RootTable.Columns(column.ColumnName).CheckBoxTriState = True
                Case "Byte"

                Case "Char"
                Case "String"
                    If column.ColumnName = "pwd" Then GRD.RootTable.Columns(column.ColumnName).PasswordChar = "*"
                Case "DateTime"
                Case "Double"
                Case "Int16"
                Case "Int32"
                Case "Int64"
                Case "SByte"
                Case "Single"
                Case "String"
                Case "TimeSpan"
                Case "UInt16"
                Case "UInt32"
                Case "UInt64"
            End Select
        Next
        Select Case GRD.Tag
            Case "INV", "SYG_INV"
                Dim fc As GridEXFormatCondition
                Dim column As GridEXColumn
                column = GRD.RootTable.Columns("idakiromeno")
                fc = New GridEXFormatCondition(column, ConditionOperator.NotIsEmpty, True)
                fc.FormatStyle.ForeColor = Color.Red
                'fc.TargetColumn = column
                GRD.RootTable.FormatConditions.Add(fc)
        End Select

    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Select Case GridMain.Tag
            Case "ES", "ROUTES", "HLP_ROUTES", "EX"
                Dim FilteredRows As DataRow() = TB.Select("dtcreated >= #" & Format(dtFromDate.Value, "yyyy/MM/dd 00:00:00") & "# and dtcreated <= #" & Format(dtToDate.Value, "yyyy/MM/dd 23:59:59") & "#")
                If (FilteredRows.Any()) Then
                    GridMain.DataSource = FilteredRows.CopyToDataTable()
                Else
                    GridMain.DataSource = Nothing
                End If
            Case "INV", "SYG_INV"
                Dim FilteredRows As DataRow() = TB.Select("invdate >= #" & Format(dtFromDate.Value, "yyyy/MM/dd 00:00:00") & "# and invdate <= #" & Format(dtToDate.Value, "yyyy/MM/dd 23:59:59") & "#")
                If (FilteredRows.Any()) Then
                    GridMain.DataSource = FilteredRows.CopyToDataTable()
                Else
                    GridMain.DataSource = Nothing
                End If
        End Select
    End Sub

    Private Sub GridMain_FormattingRow(sender As Object, e As RowLoadEventArgs)
        'Select Case GridMain.Tag
        '    Case "INV", "SYG_INV"
        '        If e.Row.Cells("akirotiko").Value.ToString.Length > 0 Then
        '            Dim style = New Janus.Windows.GridEX.GridEXFormatStyle()
        '            style.ForeColor = Color.Red
        '            e.Row.RowStyle = style
        '        Else
        '            Dim style = New Janus.Windows.GridEX.GridEXFormatStyle()
        '            style.ForeColor = Color.Black
        '        End If
        'End Select

        'Dim style = New Janus.Windows.GridEX.GridEXFormatStyle()
        'If e.Row.Cells("tempType").Value <> "" Then
        '    style.ForeColor = Color.Blue
        '    style.Font = New Font("Arial Unicode MS", 8)
        '    style.Font.GdiCharSet
        '    e.Row.Cells("tempType").FormatStyle = style
        'End If

    End Sub


    Private Sub cboMONTHS_ValueChanged(sender As Object, e As EventArgs) Handles cboMONTHS.ValueChanged
        If cboYears.SelectedIndex = -1 Then Exit Sub
        Select Case cboMONTHS.Value
            Case 1 : dtFromDate.Value = "01/01/" & cboYears.Value : dtToDate.Value = "31/01/" & cboYears.Value
            Case 2 : dtFromDate.Value = "01/02/" & cboYears.Value : dtToDate.Value = System.DateTime.DaysInMonth(cboYears.Value, cboMONTHS.Value) & "/02/" & cboYears.Value
            Case 3 : dtFromDate.Value = "01/03/" & cboYears.Value : dtToDate.Value = "31/03/" & cboYears.Value
            Case 4 : dtFromDate.Value = "01/04/" & cboYears.Value : dtToDate.Value = "30/04/" & cboYears.Value
            Case 5 : dtFromDate.Value = "01/05/" & cboYears.Value : dtToDate.Value = "31/05/" & cboYears.Value
            Case 6 : dtFromDate.Value = "01/06/" & cboYears.Value : dtToDate.Value = "30/06/" & cboYears.Value
            Case 7 : dtFromDate.Value = "01/07/" & cboYears.Value : dtToDate.Value = "31/07/" & cboYears.Value
            Case 8 : dtFromDate.Value = "01/08/" & cboYears.Value : dtToDate.Value = "31/08/" & cboYears.Value
            Case 9 : dtFromDate.Value = "01/09/" & cboYears.Value : dtToDate.Value = "30/09/" & cboYears.Value
            Case 10 : dtFromDate.Value = "01/10/" & cboYears.Value : dtToDate.Value = "31/10/" & cboYears.Value
            Case 11 : dtFromDate.Value = "01/11/" & cboYears.Value : dtToDate.Value = "30/11/" & cboYears.Value
            Case 12 : dtFromDate.Value = "01/12/" & cboYears.Value : dtToDate.Value = "31/12/" & cboYears.Value
        End Select
    End Sub

    Private Sub cboYears_ValueChanged(sender As Object, e As EventArgs) Handles cboYears.ValueChanged
        cboMONTHS_ValueChanged(sender, e)
    End Sub

    Private Sub GridMain_MouseUp(sender As Object, e As MouseEventArgs) Handles GridMain.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            If GridMain.HitTest(e.X, e.Y) = GridArea.ColumnHeader Then
                Dim colClicked As GridEXColumn = GridMain.ColumnFromPoint(e.X, e.Y)
                If Not colClicked Is Nothing Then
                    Me.ShowHeaderMenu(colClicked)
                End If
            ElseIf GridMain.HitTest(e.X, e.Y) = GridArea.Cell And (GridMain.Tag = "INV" Or GridMain.Tag = "SYG_INV") Then
                Dim colClicked As GridEXColumn = GridMain.ColumnFromPoint(e.X, e.Y)
                If Not colClicked Is Nothing Then Me.ShowCellMenu(colClicked, 2)
            Else
                Dim colClicked As GridEXColumn = GridMain.ColumnFromPoint(e.X, e.Y)
                If Not colClicked Is Nothing Then Me.ShowCellMenu(colClicked, 1)
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
                'Exit Sub
                group = Row1.Group
                Col = group.Column
                Select Case Frm
                    Case FormName.COL
                        frmCollections.Mode = FormMode.ViewRecord : frmCollections.GRPFIELD = Col.DataMember
                        frmCollections.GRPVALUE = Row1.GroupValue.ToString : FRMS = frmCollections
                End Select
            Case GridArea.GroupByBox, GridArea.GroupByBoxInfoText
            Case GridArea.Cell, GridArea.PreviewRow, GridArea.CardCaption
                Select Case Frm
                    Case FormName.DOY : frmDoy.Mode = FormMode.ViewRecord : FRMS = frmDoy
                    Case FormName.PAY : frmPAY.Mode = FormMode.ViewRecord : FRMS = frmPAY
                    Case FormName.CUS : frmCus.Mode = FormMode.ViewRecord : FRMS = frmCus
                    Case FormName.DRV : frmDRV.Mode = FormMode.ViewRecord : FRMS = frmDRV
                    Case FormName.COU : frmCou.Mode = FormMode.ViewRecord : FRMS = frmCou
                    Case FormName.AREAS : frmArea.Mode = FormMode.ViewRecord : FRMS = frmArea
                    Case FormName.EXCAT : frmEXcat.Mode = FormMode.ViewRecord : FRMS = frmEXcat
                    Case FormName.VEH : frmVeh.Mode = FormMode.ViewRecord : FRMS = frmVeh
                    Case FormName.HLP : frmHelpers.Mode = FormMode.ViewRecord : FRMS = frmHelpers
                    Case FormName.ROUTES : FrmRoute.Mode = FormMode.ViewRecord : FRMS = FrmRoute
                    Case FormName.ES : Exit Sub
                    Case FormName.PARD : Exit Sub
                    Case FormName.PRF : frmprf.Mode = FormMode.ViewRecord : FRMS = frmprf
                    Case FormName.VEHT : frmVeht.Mode = FormMode.ViewRecord : FRMS = frmVeht
                    Case FormName.PAR : frmParking.Mode = FormMode.ViewRecord : FRMS = frmParking
                    Case FormName.STI : frmSti.Mode = FormMode.ViewRecord : FRMS = frmSti
                    Case FormName.EX : frmEX.Mode = FormMode.ViewRecord : FRMS = frmEX
                    Case FormName.COL : frmCollections.Mode = FormMode.ViewRecord : FRMS = frmCollections
                    Case FormName.INV : frmInvoice.Mode = FormMode.EditRecord
                        frmInvoice.RouteID = Row1.Cells("RouteID").Value.ToString()
                        If Row1.Cells("idakiromeno").Value.ToString() <> "" Then frmInvoice.IsAkirotiko = True
                        frmInvoice.INVID = Row1.Cells("id").Value.ToString()
                        FRMS = frmInvoice
                    Case FormName.SYG_INV : frmInvoice.Mode = FormMode.EditRecord
                        frmInvoice.SYGID = Row1.Cells("ID").Value.ToString()
                        If Row1.Cells("idakiromeno").Value.ToString() <> "" Then frmInvoice.IsAkirotiko = True
                        FRMS = frmInvoice
                    Case FormName.HLP_ROUTES : FrmRoute.Mode = FormMode.ViewRecord : FRMS = FrmRoute
                    Case FormName.CUSTYPE : frmCUSTYPE.Mode = FormMode.ViewRecord : FRMS = frmCUSTYPE
                    Case FormName.DOS : FrmDOS.Mode = FormMode.ViewRecord : FRMS = FrmDOS
                    Case FormName.SDT : frmSDT.Mode = FormMode.ViewRecord : FRMS = frmSDT
                    Case FormName.USERS : frmUSERS.Mode = FormMode.ViewRecord : FRMS = frmUSERS
                    Case FormName.STS : frmSTS.Mode = FormMode.ViewRecord : FRMS = frmSTS
                    Case FormName.FPA : frmFPA.Mode = FormMode.ViewRecord : FRMS = frmFPA

                End Select

        End Select
        FRMS.Owner = Me
        FRMS.Show()
    End Sub

    Private Sub GridMain_DeletingRecord(sender As Object, e As RowActionCancelEventArgs) Handles GridMain.DeletingRecord
        Dim sSQL As String
        Try
            If Frm = FormName.INV Then e.Cancel = True : Exit Sub
            If Frm = FormName.PARD Then e.Cancel = True : Exit Sub
            If Frm = FormName.SYG_INV Then e.Cancel = True : Exit Sub
            If Frm = FormName.HLP_ROUTES Then e.Cancel = True : Exit Sub
            If Frm = FormName.COL Then
                If e.Row.Cells("dosname").Value.ToString <> "" Then
                    MessageBox.Show("Δεν μπορεί να διαγραφεί η απόδειξη γιατί έχει εκτυπωθεί", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Cancel = True
                    Exit Sub
                End If
            End If
            If Frm = FormName.ROUTES Then
                If e.Row.Cells("invoiced").Value = True Then
                    MessageBox.Show("Δεν μπορεί να διαγραφεί το δρομολόγιο γιατί είναι τιμολογημένο", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Cancel = True
                    Exit Sub
                End If
            End If

            If MessageBox.Show("Να διαγραφεί η επιλεγμένη εγγραφή?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                Select Case Frm
                    Case FormName.DOY : sSQL = "DELETE DOY where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.PAY : sSQL = "DELETE PAY where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.CUS : sSQL = "DELETE CUS where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.DRV : sSQL = "DELETE DRV where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.COU : sSQL = "DELETE COU where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.AREAS : sSQL = "DELETE AREAS where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.EXCAT : sSQL = "DELETE EXCAT where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.VEH : sSQL = "DELETE VEH where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.HLP : sSQL = "DELETE HLP where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.ROUTES : sSQL = "DELETE ROUTES where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.ES : sSQL = "DELETE ES where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.PRF : sSQL = "DELETE PRF where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.VEHT : sSQL = "DELETE VEHT where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.PAR : sSQL = "DELETE PARH where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.STI : sSQL = "DELETE STI where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.EX : sSQL = "DELETE EX where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.COL : sSQL = "DELETE COLD  WHERE colID='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.CUSTYPE : sSQL = "DELETE CUSTYPE where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.DOS : sSQL = "DELETE DOS where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.SDT : sSQL = "DELETE SDT where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.USERS : sSQL = "DELETE USERS where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.STS : sSQL = "DELETE STS where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Case FormName.FPA : sSQL = "DELETE FPA where id='" & e.Row.Cells("id").Value.ToString & "'"
                End Select

                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                If Frm = FormName.COL Then
                    ''Ενημέρωση τιμολογίου ότι δεν πληρώθηκε
                    'sSQL = "UPDATE INVH SET PAID=0 WHERE ID='" & e.Row.Cells("invHid").Value.ToString & "'"
                    'Using oCmd As New OleDbCommand(sSQL, cn)
                    '    oCmd.ExecuteNonQuery()
                    'End Using
                    'Διαγραφή Detail
                    sSQL = "DELETE COLH where id='" & e.Row.Cells("id").Value.ToString & "'"
                    Using oCmd As New OleDbCommand(sSQL, cn)
                        oCmd.ExecuteNonQuery()
                    End Using
                End If
            Else
                e.Cancel = True
            End If
        Catch myOLEDBException As OleDbException 'ole db exception
            e.Cancel = True
            MessageBox.Show(myOLEDBException.ErrorCode.ToString + vbCrLf + myOLEDBException.Message.ToString + vbCrLf + myOLEDBException.Source.ToString)
        End Try
    End Sub

End Class
