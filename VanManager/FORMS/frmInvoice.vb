Imports System.Data.OleDb

Public Class frmInvoice
    Private RID As String
    Private IsHandWritting As Boolean = False
    Private IsAk As Boolean = False
    Private SYGINVHID As String
    Private RIDs As List(Of String)
    Private DInf As DataTable
    Private sdtID As String
    Public Mode As Byte
    Private InvHcode As Int64
    Private Sen As Int64
    Private INVHID As String
    Private INVH_ID As String
    Private DosID As String
    Private CusID As String
    Private IsPrinted As Boolean
    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As OleDbCommand
        Dim sdr As OleDbDataReader

        Try
            Call FillJanusPay()
            'Απλό Τιμολόγιο
            If RIDs Is Nothing And SYGINVHID Is Nothing Then
                If Mode = FormMode.NewRecord Then
                    cmd = New OleDbCommand("Select dosname as name,sdtid ,dosid ,isnull(number,0) as number
                                            from vw_seires 
                                            where sdtcode = " & IIf(IsHandWritting = True, 4, 1) & "  and userid = '" & UserID & "'" & IIf(IsAk = True, " and vw_seires.iscancel=1 ", "and vw_seires.iscancel=0 "), cn)
                    sdr = cmd.ExecuteReader()

                    If (sdr.Read() = True) Then
                        If sdr.IsDBNull(sdr.GetOrdinal("sdtid")) = False Then sdtID = sdr.GetGuid(sdr.GetOrdinal("sdtid")).ToString
                        If sdr.IsDBNull(sdr.GetOrdinal("name")) = False Then txtCode.Text = sdr.GetString(sdr.GetOrdinal("name"))
                        If sdr.IsDBNull(sdr.GetOrdinal("dosid")) = False Then DosID = sdr.GetGuid(sdr.GetOrdinal("dosid")).ToString
                        If sdr.IsDBNull(sdr.GetOrdinal("number")) = False Then txtNumber.Value = sdr.GetInt64(sdr.GetOrdinal("number"))
                        If IsHandWritting = True Then txtNumber.ReadOnly = False
                        sdr.Close()
                    End If
                    If Mode = FormMode.NewRecord Then txtNumber.Value = txtNumber.Value + 1
                    'Sen = GetSen(DosID)
                Else
                    LockUnlockAllControls(Me, True) : cmdExit.Enabled = True : cmdSave.Enabled = True : cmdSygAnal.Enabled = True
                End If
                If INVH_ID = Nothing Then
                    cmd = New OleDbCommand("SELECT	 R.FAreaName ,R.TAreaName 
                                            ,R.FCusLastname ,R.FCusName ,R.FAFM ,R.TCusLastname 
                                      ,R.TCusName ,R.TAFM ,R.MAINCUSLastname ,R.MAINCUSname
                                      ,R.MAINCusAFM ,DrvLastname ,DrvName ,R.cost ,R.plate,R.fpacost,R.gentot,R.code,R.MAINCusID  
                                            ,INVH.ID AS INVHID,INVH.Prosv
                                            FROM vw_ROUTES R
                                            LEFT JOIN INVH ON INVH.routeID = R.ID
                                            where R.ID = '" & RID & "'", cn)
                Else
                    cmd = New OleDbCommand("Select R.FAreaName ,R.TAreaName ,R.FCusLastname ,R.FCusName ,
                                        R.FAFM ,R.TCusLastname ,R.TCusName ,R.TAFM ,R.MAINCUSLastname ,R.MAINCUSname,
                                        R.MAINCusAFM ,DrvLastname ,DrvName ,R.cost ,R.plate,R.fpacost,R.gentot,R.code,
                                        R.MAINCusID ,INVH.ID AS INVHID,INVH.Prosv
                                        From vw_ROUTES R
				                        inner Join INVH on invh.routeID=r.id
                                        inner join vw_seires vs on vs.sdtid=INVH.sdtid " & IIf(IsAk = True, " and VS.iscancel=1 ", " and VS.iscancel=0 ") &
                                        "where INVH.id = ('" & INVH_ID & "') ", cn)
                End If
                sdr = cmd.ExecuteReader()
                    If (sdr.Read() = True) Then
                        If sdr.IsDBNull(sdr.GetOrdinal("FAreaName")) = False Then txtFArea.Text = sdr.GetString(sdr.GetOrdinal("FAreaName"))
                        If sdr.IsDBNull(sdr.GetOrdinal("TAreaName")) = False Then txtTArea.Text = sdr.GetString(sdr.GetOrdinal("TAreaName"))
                        If sdr.IsDBNull(sdr.GetOrdinal("FCusLastname")) = False Then txtFCusL.Text = sdr.GetString(sdr.GetOrdinal("FCusLastname"))
                        If sdr.IsDBNull(sdr.GetOrdinal("FCusName")) = False Then txtFCusN.Text = sdr.GetString(sdr.GetOrdinal("FCusName"))
                        If sdr.IsDBNull(sdr.GetOrdinal("FAFM")) = False Then txtFCusA.Text = sdr.GetString(sdr.GetOrdinal("FAFM"))
                        If sdr.IsDBNull(sdr.GetOrdinal("TCusLastname")) = False Then txtTCusL.Text = sdr.GetString(sdr.GetOrdinal("TCusLastname"))
                        If sdr.IsDBNull(sdr.GetOrdinal("TCusName")) = False Then txtTCusN.Text = sdr.GetString(sdr.GetOrdinal("TCusName"))
                        If sdr.IsDBNull(sdr.GetOrdinal("TAFM")) = False Then txtTCusA.Text = sdr.GetString(sdr.GetOrdinal("TAFM"))
                        If sdr.IsDBNull(sdr.GetOrdinal("MAINCUSLastname")) = False Then txtMCusL.Text = sdr.GetString(sdr.GetOrdinal("MAINCUSLastname"))
                        If sdr.IsDBNull(sdr.GetOrdinal("MAINCUSname")) = False Then txtMCusN.Text = sdr.GetString(sdr.GetOrdinal("MAINCUSname"))
                        If sdr.IsDBNull(sdr.GetOrdinal("MAINCusAFM")) = False Then txtMCusA.Text = sdr.GetString(sdr.GetOrdinal("MAINCusAFM"))
                        If sdr.IsDBNull(sdr.GetOrdinal("DrvLastname")) = False Then txtDrvL.Text = sdr.GetString(sdr.GetOrdinal("DrvLastname"))
                        If sdr.IsDBNull(sdr.GetOrdinal("DrvName")) = False Then txtDrvN.Text = sdr.GetString(sdr.GetOrdinal("DrvName"))
                        If sdr.IsDBNull(sdr.GetOrdinal("plate")) = False Then txtPlate.Text = sdr.GetString(sdr.GetOrdinal("plate"))
                        If sdr.IsDBNull(sdr.GetOrdinal("cost")) = False Then txtAxia.Value = sdr.GetDecimal(sdr.GetOrdinal("cost"))
                        If sdr.IsDBNull(sdr.GetOrdinal("fpacost")) = False Then txtFPA.Value = sdr.GetDecimal(sdr.GetOrdinal("fpacost"))
                        If sdr.IsDBNull(sdr.GetOrdinal("gentot")) = False Then txtTotal.Value = sdr.GetDecimal(sdr.GetOrdinal("gentot"))
                        If sdr.IsDBNull(sdr.GetOrdinal("code")) = False Then txtRoute.Value = sdr.GetInt32(sdr.GetOrdinal("code"))
                        If sdr.IsDBNull(sdr.GetOrdinal("MainCusID")) = False Then txtMCusL.Tag = sdr.GetGuid(sdr.GetOrdinal("MainCusID"))
                    If sdr.IsDBNull(sdr.GetOrdinal("INVHID")) = False Then INVH_ID = sdr.GetGuid(sdr.GetOrdinal("INVHID")).ToString
                    If sdr.IsDBNull(sdr.GetOrdinal("Prosv")) = False Then txtProsvasis.Text = sdr.GetString(sdr.GetOrdinal("Prosv"))
                    'Εαν αφορά ακυρωτικό τιμολόγιο
                    If IsAk Then
                            txtAxia.Value = txtAxia.Value * (-1) : txtAxia.ForeColor = Color.Red
                            txtFPA.Value = txtFPA.Value * (-1) : txtFPA.ForeColor = Color.Red
                            txtTotal.Value = txtTotal.Value * (-1) : txtTotal.ForeColor = Color.Red
                        End If
                        txtHolloPrice.Text = ConvertNumToWords.ConvertNumInGR(txtTotal.Value)
                        sdr.Close()
                    Else
                        Sen = 1
                    End If
                    If Mode = FormMode.NewRecord Then
                        InvHcode = GetNewCode("INVH")
                        dtinvdate.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                        INVHID = System.Guid.NewGuid.ToString()
                    Else
                        cmd = New OleDbCommand("SELECT *,vs.ishand  from invh 
                                            inner join vw_seires vs on vs.sdtid=invh.sdtid " & IIf(IsAk = True, " and VS.iscancel=1 ", "and VS.iscancel=0 ") &
                                                "where invh.ID = '" & INVH_ID & "'", cn)
                        sdr = cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then INVHID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                            If sdr.IsDBNull(sdr.GetOrdinal("docnumber")) = False Then txtNumber.Value = sdr.GetInt64(sdr.GetOrdinal("docnumber"))
                            If sdr.IsDBNull(sdr.GetOrdinal("description")) = False Then txtDescr.Text = sdr.GetString(sdr.GetOrdinal("description"))
                            If sdr.IsDBNull(sdr.GetOrdinal("holloprice")) = False Then txtHolloPrice.Text = sdr.GetString(sdr.GetOrdinal("holloprice"))
                            If sdr.IsDBNull(sdr.GetOrdinal("invdate")) = False Then dtinvdate.Value = sdr.GetDateTime(sdr.GetOrdinal("invdate"))
                            If sdr.IsDBNull(sdr.GetOrdinal("payid")) = False Then cboPay.Value = sdr.GetGuid(sdr.GetOrdinal("payid"))
                            If sdr.IsDBNull(sdr.GetOrdinal("sdtid")) = False Then sdtID = sdr.GetGuid(sdr.GetOrdinal("sdtid")).ToString
                            If sdr.IsDBNull(sdr.GetOrdinal("dosname")) = False Then txtCode.Text = sdr.GetString(sdr.GetOrdinal("dosname"))
                            If sdr.IsDBNull(sdr.GetOrdinal("printed")) = False Then IsPrinted = sdr.GetBoolean(sdr.GetOrdinal("printed"))
                            If sdr.IsDBNull(sdr.GetOrdinal("FilePath")) = False Then txtdeltPath.Text = sdr.GetString(sdr.GetOrdinal("FilePath"))
                            If sdr.IsDBNull(sdr.GetOrdinal("ishand")) = False Then IsHandWritting = sdr.GetBoolean(sdr.GetOrdinal("ishand"))
                            Sen = txtNumber.Value
                        End If
                        sdr.Close()
                    LockUnlockAllControls(Me, True) : cmdExit.Enabled = True : cmdSave.Enabled = True : cmdSygAnal.Enabled = True
                End If
                Else
                    If Mode = FormMode.NewRecord Then
                    cmd = New OleDbCommand("Select dosname as name ,sdtid ,dosid ,isnull(number,0) as number
                                            from vw_seires 
                                            where sdtcode = " & IIf(IsHandWritting = True, 5, 3) & "  and userid = '" & UserID & "' " & IIf(IsAk = True, " and vw_seires.iscancel=1 ", "and vw_seires.iscancel=0 "), cn)
                    sdr = cmd.ExecuteReader()

                    If (sdr.Read() = True) Then
                        If sdr.IsDBNull(sdr.GetOrdinal("sdtid")) = False Then sdtID = sdr.GetGuid(sdr.GetOrdinal("sdtid")).ToString
                        If sdr.IsDBNull(sdr.GetOrdinal("name")) = False Then txtCode.Text = sdr.GetString(sdr.GetOrdinal("name"))
                        If sdr.IsDBNull(sdr.GetOrdinal("dosid")) = False Then DosID = sdr.GetGuid(sdr.GetOrdinal("dosid")).ToString
                        If sdr.IsDBNull(sdr.GetOrdinal("number")) = False Then txtNumber.Value = sdr.GetInt64(sdr.GetOrdinal("number"))
                        sdr.Close()
                    End If
                    dtinvdate.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    txtNumber.Value = txtNumber.Value + 1
                    txtFArea.ReadOnly = False
                    txtTArea.ReadOnly = False
                Else
                    LockUnlockAllControls(Me, True) : cmdExit.Enabled = True : cmdSave.Enabled = True : cmdSygAnal.Enabled = True
                End If
                'Συγκεντρωτικό Τιμολόγιο
                If SYGINVHID <> "" Then
                    cmd = New OleDbCommand("Select R.MainCusID,R.MAINCUSLastname ,R.MAINCUSname,R.MAINCusAFM,sum(cost) As cost,sum(R.fpacost) As fpacost,
                                            sum(R.gentot) As gentot,INVHSYG.Tarea,INVHSYG.Farea,INVHSYG.Tarea,INVHSYG.Farea,INVHSYG.dosname,
                                            INVHSYG.docnumber,INVHSYG.payID,INVHSYG.description,INVHSYG.printed,INVHSYG.holloprice,INVHSYG.invdate,INVHSYG.skopos, 
                                            INVHSYG.FilePath,vs.ishand,INVHSYG.Prosv 
                                            From vw_ROUTES R
				                            inner Join INVH on invh.routeID=r.id
                                            inner Join INVHSYG  on INVHSYG.id=invh.invhsygid 
                                            inner join vw_seires vs on vs.sdtid=INVHSYG.sdtid " & IIf(IsAk = True, " and VS.iscancel=1 ", "and VS.iscancel=0") &
                                           "where INVHSYG.id = ('" & SYGINVHID & "' ) 
                                            group by R.MainCusID,R.MAINCUSLastname , R.MAINCUSname, R.MAINCusAFM,INVHSYG.Tarea,
                                            INVHSYG.Farea,INVHSYG.dosname,INVHSYG.docnumber,INVHSYG.payID,INVHSYG.description,INVHSYG.printed,
                                            INVHSYG.holloprice,	INVHSYG.invdate,INVHSYG.skopos ,INVHSYG.FilePath,vs.ishand,INVHSYG.Prosv      ", cn)
                Else
                    cmd = New OleDbCommand("SELECT	R.MainCusID,R.MAINCUSLastname ,R.MAINCUSname,R.MAINCusAFM,sum(cost) as cost,sum(fpacost) as fpacost,sum(gentot) as gentot
                                    From vw_ROUTES R
                                    where id in ( " & RID & ") group by R.MainCusID,R.MAINCUSLastname ,R.MAINCUSname,R.MAINCusAFM", cn)
                End If
                sdr = cmd.ExecuteReader()
                If (sdr.Read() = True) Then
                    If sdr.IsDBNull(sdr.GetOrdinal("MAINCUSLastname")) = False Then txtMCusL.Text = sdr.GetString(sdr.GetOrdinal("MAINCUSLastname"))
                    If sdr.IsDBNull(sdr.GetOrdinal("MainCusID")) = False Then txtMCusL.Tag = sdr.GetGuid(sdr.GetOrdinal("MainCusID"))
                    If sdr.IsDBNull(sdr.GetOrdinal("MAINCUSname")) = False Then txtMCusN.Text = sdr.GetString(sdr.GetOrdinal("MAINCUSname"))
                    If sdr.IsDBNull(sdr.GetOrdinal("MAINCusAFM")) = False Then txtMCusA.Text = sdr.GetString(sdr.GetOrdinal("MAINCusAFM"))

                    If sdr.IsDBNull(sdr.GetOrdinal("cost")) = False Then txtAxia.Value = sdr.GetDecimal(sdr.GetOrdinal("cost"))
                    If sdr.IsDBNull(sdr.GetOrdinal("fpacost")) = False Then txtFPA.Value = sdr.GetDecimal(sdr.GetOrdinal("fpacost"))
                    If sdr.IsDBNull(sdr.GetOrdinal("gentot")) = False Then txtTotal.Value = sdr.GetDecimal(sdr.GetOrdinal("gentot"))
                    'Εαν αφορά ακυρωτικό τιμολόγιο
                    If IsAk Then
                        txtAxia.Value = txtAxia.Value * (-1) : txtAxia.ForeColor = Color.Red
                        txtFPA.Value = txtFPA.Value * (-1) : txtFPA.ForeColor = Color.Red
                        txtTotal.Value = txtTotal.Value * (-1) : txtTotal.ForeColor = Color.Red
                    End If
                    If SYGINVHID <> "" Then
                        If sdr.IsDBNull(sdr.GetOrdinal("ishand")) = False Then IsHandWritting = sdr.GetBoolean(sdr.GetOrdinal("ishand"))
                    End If
                    If Mode <> FormMode.NewRecord Then
                        If sdr.IsDBNull(sdr.GetOrdinal("Farea")) = False Then txtFArea.Text = sdr.GetString(sdr.GetOrdinal("Farea"))
                        If sdr.IsDBNull(sdr.GetOrdinal("Tarea")) = False Then txtTArea.Text = sdr.GetString(sdr.GetOrdinal("Tarea"))
                        If sdr.IsDBNull(sdr.GetOrdinal("payid")) = False Then cboPay.Value = sdr.GetGuid(sdr.GetOrdinal("payid"))
                        If sdr.IsDBNull(sdr.GetOrdinal("description")) = False Then txtDescr.Text = sdr.GetString(sdr.GetOrdinal("description"))
                        If sdr.IsDBNull(sdr.GetOrdinal("dosname")) = False Then txtCode.Text = sdr.GetString(sdr.GetOrdinal("dosname"))
                        If sdr.IsDBNull(sdr.GetOrdinal("docnumber")) = False Then txtNumber.Value = sdr.GetInt64(sdr.GetOrdinal("docnumber"))
                        If sdr.IsDBNull(sdr.GetOrdinal("printed")) = False Then IsPrinted = sdr.GetBoolean(sdr.GetOrdinal("printed"))
                        If sdr.IsDBNull(sdr.GetOrdinal("holloprice")) = False Then txtHolloPrice.Text = sdr.GetString(sdr.GetOrdinal("holloprice"))
                        If sdr.IsDBNull(sdr.GetOrdinal("invdate")) = False Then dtinvdate.Value = sdr.GetDateTime(sdr.GetOrdinal("invdate"))
                        If sdr.IsDBNull(sdr.GetOrdinal("skopos")) = False Then txtSkopos.Text = sdr.GetString(sdr.GetOrdinal("skopos"))
                        If sdr.IsDBNull(sdr.GetOrdinal("FilePath")) = False Then txtdeltPath.Text = sdr.GetString(sdr.GetOrdinal("FilePath"))
                        If sdr.IsDBNull(sdr.GetOrdinal("Prosv")) = False Then txtProsvasis.Text = sdr.GetString(sdr.GetOrdinal("Prosv"))
                        LockUnlockAllControls(Me, True) : cmdExit.Enabled = True : cmdSave.Enabled = True : cmdSygAnal.Enabled = True
                    Else
                        txtHolloPrice.Text = ConvertNumToWords.ConvertNumInGR(txtTotal.Value)
                    End If
                    sdr.Close()
                Else
                    Sen = 1
                End If
                If Mode = FormMode.NewRecord Then
                    InvHcode = GetNewCode("INVH")
                    dtinvdate.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    INVHID = System.Guid.NewGuid.ToString()
                End If
            End If
            'Έαν είναι χειρόγραφο ανοίγω τον αριθμό να μπορεί να τον αλλάξει
            If IsHandWritting = True Then txtNumber.ReadOnly = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
        End Try
    End Sub
    Public WriteOnly Property SYGID As String
        Set(value As String)
            SYGINVHID = value
        End Set
    End Property
    Public WriteOnly Property INVID As String
        Set(value As String)
            INVH_ID = value
        End Set
    End Property
    Public WriteOnly Property RouteID As String
        Set(value As String)
            RID = value
        End Set
    End Property
    Public WriteOnly Property IsHand As Boolean
        Set(value As Boolean)
            IsHandWritting = value
        End Set
    End Property
    Public WriteOnly Property IsAkirotiko As Boolean
        Set(value As Boolean)
            IsAk = value
        End Set
    End Property

    Public WriteOnly Property DTINF As DataTable
        Set(value As DataTable)
            DInf = value
        End Set
    End Property
    Public WriteOnly Property RouteIDs As List(Of String)
        Set(value As List(Of String))
            RIDs = value
        End Set
    End Property

    Public Sub FillJanusPay()
        Dim ds As DataSet = New DataSet
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sql As String

        sql = "SELECT id,name from vw_PAY order by name"

        adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
        adapter.Fill(ds)
        cboPay.DataSource = ds.Tables(0)
        cboPay.DisplayMember = "name"
        cboPay.ValueMember = "id"
        cboPay.SettingsKey = "id"
        cboPay.Text = ""

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim INVHSYGID As String, sSQL As String
        Dim InvHSYGcode As Int64
        Dim cBalance As Double, cPrevBalance As Double
        Try
            If txtFArea.Text.Length = 0 Or txtTArea.Text.Length = 0 Or cboPay.Text.Length = 0 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Mode = FormMode.NewRecord Then
                'Εαν δεν αφορά συγκεντρωτικό τιμολόγιο
                If RIDs Is Nothing Then
                    'Δημιουργία Τιμολογίου
                    If InsertInvoice(RID, INVHID) = True Then
                        'Ενημέρωση υπολοίπου πελάτη
                        Using oCmd As New OleDbCommand("CusBalance ", cn)
                            oCmd.CommandType = 4
                            oCmd.Parameters.AddWithValue("@CusId", txtMCusL.Tag.ToString)
                            oCmd.Parameters.AddWithValue("@invID", INVHID)
                            oCmd.Parameters.AddWithValue("@isSyg", 0)
                            oCmd.Parameters.AddWithValue("@CalledFromCol", 0)
                            oCmd.Parameters.AddWithValue("@CusBalance", cBalance)
                            oCmd.Parameters("@CusBalance").Direction = ParameterDirection.Output
                            oCmd.Parameters.AddWithValue("@PrevBalance", cPrevBalance)
                            oCmd.Parameters("@PrevBalance").Direction = ParameterDirection.Output
                            oCmd.ExecuteNonQuery()
                        End Using
                        frmPrintPreview.sTable = "INVH"
                        frmPrintPreview.INVHID = INVHID
                        frmPrintPreview.Show()
                        Mode = FormMode.EditRecord
                    End If
                Else
                    pInv.Visible = True
                    ' Καταχώρηση συγκεντρωτικού
                    INVHSYGID = System.Guid.NewGuid.ToString()
                    InvHSYGcode = GetNewCode("INVHSYG")

                    'Καταχώρηση Δεδομένων
                    sSQL = "INSERT INTO INVHSYG ([ID], [code], [docnumber], [invdate], [description], [holloprice], [payid], [sdtID], [dosname],
                                [kAxia], [fpacost], [gentot], [CusID], [FArea], [Tarea], [printed], [skopos], [filepath],[Prosv]) " &
                       "values (" & "'" & INVHSYGID & "'," &
                                 InvHSYGcode & "," &
                                txtNumber.Value & ", " &
                              "'" & Format(dtinvdate.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                                    toSQLValueJ(txtDescr) & ", " &
                                    toSQLValueJ(txtHolloPrice) & ", " &
                                    boSQLValuej(cboPay) & ", " &
                                    "'" & sdtID & "'," &
                                    toSQLValueJ(txtCode) & "," &
                                    Replace(txtAxia.Value, ",", ".") & "," &
                                    Replace(txtFPA.Value, ",", ".") & "," &
                                    Replace(txtTotal.Value, ",", ".") & "," &
                                    "'" & txtMCusL.Tag.ToString & "'," &
                                    toSQLValueJ(txtFArea) & "," &
                                    toSQLValueJ(txtTArea) & ",1," &
                                    toSQLValueJ(txtSkopos) & "," &
                                    toSQLValueJ(txtdeltPath) & "," &
                                    toSQLValueJ(txtProsvasis) & ")"
                    Using oCmd As New OleDbCommand(sSQL, cn)
                        oCmd.ExecuteNonQuery()
                    End Using
                    pInv.Maximum = RIDs.Count - 1
                    For i As Integer = 0 To RIDs.Count - 1
                        If InsertInvoice(RIDs(i).ToString, INVHID, INVHSYGID) = True Then
                            InvHcode = GetNewCode("INVH")
                            INVHID = System.Guid.NewGuid.ToString()
                            pInv.Value = i
                        End If
                    Next i
                    ' Καταχώρηση ποσόυ εξόδου (ΦΠΑ)
                    sSQL = "INSERT INTO EX ([code],[dtCreated],[price],[invhsygid],[excatid],[FilePath]) " &
                              "values (" & GetNewCode("EX") & ", " &
                                     "'" & Format(dtinvdate.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                                           Replace(txtFPA.Value, ",", ".") & "," &
                                           "'" & INVHSYGID & "'" & ",'F2FC308E-A583-4DD7-829D-6626819E106F'," &
                                           toSQLValueJ(txtdeltPath) & ")"
                    Using oCmd As New OleDbCommand(sSQL, cn)
                        oCmd.ExecuteNonQuery()
                    End Using

                    pInv.Visible = False
                    'Ενημέρωση υπολοίπου πελάτη
                    Using oCmd As New OleDbCommand("CusBalance ", cn)
                        oCmd.CommandType = 4
                        oCmd.Parameters.AddWithValue("@CusId", txtMCusL.Tag.ToString)
                        oCmd.Parameters.AddWithValue("@invID", INVHSYGID)
                        oCmd.Parameters.AddWithValue("@isSyg", 1)
                        oCmd.Parameters.AddWithValue("@CalledFromCol", 0)
                        oCmd.Parameters.AddWithValue("@CusBalance", cBalance)
                        oCmd.Parameters("@CusBalance").Direction = ParameterDirection.Output
                        oCmd.Parameters.AddWithValue("@PrevBalance", cPrevBalance)
                        oCmd.Parameters("@PrevBalance").Direction = ParameterDirection.Output
                        oCmd.ExecuteNonQuery()
                    End Using
                    Dim Sen As String = GetSen(DosID, True)
                    frmPrintPreview.sTable = "INVHSYG"
                    frmPrintPreview.SYGHID = INVHSYGID
                    frmPrintPreview.IsAkirotiko = IsAk
                    frmPrintPreview.Show()
                    frmSygInvoices.cboMainCus.SelectedIndex = -1
                    frmMain.FillJanusGrid("SYG_INV")
                    Me.Close()
                End If
            Else
                'Συγκεντρωτικό
                If SYGINVHID <> "" Then
                    If MessageBox.Show("Να γίνει επανεκτύπωση του τιμολογίου?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        ' Ενημέρωση Δεδομένων
                        'sSQL = "UPDATE INVHSYG set " &
                        '       "invdate = " & "'" & Format(dtinvdate.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                        '       "description =  " & toSQLValueJ(txtDescr) & "," &
                        '       "Tarea =  " & toSQLValueJ(txtTArea) & "," &
                        '       "Farea =  " & toSQLValueJ(txtFArea) & "," &
                        '       "holloprice =  " & toSQLValueJ(txtHolloPrice) & "," &
                        '       "payid = " & boSQLValuej(cboPay) & "," &
                        '       "skopos =  " & toSQLValueJ(txtSkopos) & "," &
                        '       "docnumber =  " & txtNumber.Value & "," &
                        '       "filepath = " & toSQLValueJ(txtdeltPath) &
                        '        " where id = '" & SYGINVHID & "'"
                        'Using oCmd As New OleDbCommand(sSQL, cn)
                        '    oCmd.ExecuteNonQuery()
                        'End Using
                        frmPrintPreview.sTable = "INVHSYG"
                        frmPrintPreview.SYGHID = SYGINVHID
                        frmPrintPreview.IsAkirotiko = IsAk
                        frmPrintPreview.Show()
                    End If
                Else
                    If MessageBox.Show("Να γίνει επανεκτύπωση του τιμολογίου?", "VanManager", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        If InsertInvoice(RID, INVHID) = True Then
                            'Κανονικό
                            frmPrintPreview.sTable = "INVH"
                            frmPrintPreview.INVHID = INVHID
                            frmPrintPreview.IsAkirotiko = IsAk
                            frmPrintPreview.Show()
                        End If
                    End If
                End If
            End If
        Catch ex As OleDbException
            Select Case ex.ErrorCode
                Case -2147217873
                    MessageBox.Show("Έχει εκδοθεί τιμολόγιο γι' αυτό το δρομολόγιο.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show(ex.ErrorCode.ToString + vbCrLf + ex.Message.ToString + vbCrLf + ex.Source.ToString)
            End Select
        Finally

        End Try
    End Sub
    Private Function InsertInvoice(ByVal R As String, ByVal I As String, Optional ByVal SI As String = "NULL") As Boolean
        Dim sSQL As String
        Try
            If cboPay.Text.Length = 0 Or txtHolloPrice.Text.Length = 0 Then
                MessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If Mode = FormMode.EditRecord Then
                ' Ενημέρωση Δεδομένων
                sSQL = "UPDATE INVH set " &
                   "routeid = " & "'" & R & "'," &
                   "docnumber =  " & txtNumber.Value & "," &
                   "invdate = " & "'" & Format(dtinvdate.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                   "description =  " & toSQLValueJ(txtDescr) & "," &
                   "holloprice =  " & toSQLValueJ(txtHolloPrice) & "," &
                   "payid = " & boSQLValuej(cboPay) & ", " &
                   "sdtid = '" & sdtID & "', " &
                   "kAxia = '" & Replace(txtAxia.Value, ",", ".") & "', " &
                   "fpacost = '" & Replace(txtFPA.Value, ",", ".") & "', " &
                   "gentot = '" & Replace(txtTotal.Value, ",", ".") & "', " &
                   "cusid = '" & txtMCusL.Tag.ToString & "'," &
                   "FilePath =  " & toSQLValueJ(txtdeltPath) & ", " &
                   "Prosv = " & toSQLValueJ(txtProsvasis) &
                    " where INVH.ID = '" & I & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                'Καταχώρηση γραμμών
                Using oCmd As New OleDbCommand("InsertInvDetails", cn)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@invHid", I)
                    oCmd.ExecuteNonQuery()
                End Using

                ' Ενημέρωση ποσόυ εξόδου (ΦΠΑ)
                sSQL = "UPDATE EX set " &
                        "dtCreated = '" & Format(dtinvdate.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                        "price = " & Replace(txtFPA.Value, ",", ".") & "," &
                        "excatid = 'F2FC308E-A583-4DD7-829D-6626819E106F'" &
                        " where invhid = '" & I & "'"

                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
            ElseIf Mode = FormMode.NewRecord Then
                Dim FilteredRows As DataRow()
                If SI <> "NULL" Then
                    FilteredRows = DInf.Select("C1='" & R & "'")
                    SI = "'" & SI & "'"

                    sSQL = "INSERT INTO INVH ([ID],[routeid],[code],[invdate],[description],[holloprice],[payid],[sdtid],[dosname],[kAxia],[fpacost],
                            [gentot],[invhsygid],[docnumber],[cusid],[printed],[Prosv]) " &
                            "values (" & "'" & I & "'," &
                          "'" & R & "'," &
                             InvHcode & ", " &
                      "'" & Format(dtinvdate.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                            toSQLValueJ(txtDescr) & ", " &
                             "'" & FilteredRows(0).Item("C5") & "'" & ", " &
                            boSQLValuej(cboPay) & ", " &
                            "'" & sdtID & "'," &
                            toSQLValueJ(txtCode) & "," &
                            Replace(FilteredRows(0).Item("C2"), ",", ".") & "," &
                            Replace(FilteredRows(0).Item("C3"), ",", ".") & "," &
                            Replace(FilteredRows(0).Item("C4"), ",", ".") & "," &
                              SI & "," &
                             txtNumber.Value & "," &
                            "'" & txtMCusL.Tag.ToString & "', 1 ," &
                            toSQLValueJ(txtProsvasis) & ")"
                Else
                    If CheckIfHandInvoiceExist(sdtID, txtNumber.Value) Then
                        MessageBox.Show("Έχει εκδοθεί τιμολόγιο με αυτόν τον αριθμό.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    sSQL = "INSERT INTO INVH ([ID],[routeid],[code],[invdate],[description],[holloprice],[payid],[sdtid],[dosname],[kAxia],[fpacost],
                            [gentot],[invhsygid],[docnumber],[printed],[cusid],[FilePath],[Prosv]) " &
                            "values (" & "'" & I & "'," &
                          "'" & R & "'," &
                             InvHcode & ", " &
                      "'" & Format(dtinvdate.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                            toSQLValueJ(txtDescr) & ", " &
                            toSQLValueJ(txtHolloPrice) & ", " &
                            boSQLValuej(cboPay) & ", " &
                            "'" & sdtID & "'," &
                            toSQLValueJ(txtCode) & "," &
                            Replace(txtAxia.Value, ",", ".") & "," &
                            Replace(txtFPA.Value, ",", ".") & "," &
                            Replace(txtTotal.Value, ",", ".") & "," &
                              SI & "," &
                             txtNumber.Value & ",1" & "," &
                            "'" & txtMCusL.Tag.ToString & "'," &
                            toSQLValueJ(txtdeltPath) & "," &
                            toSQLValueJ(txtProsvasis) & ")"
                End If
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                    If SI Is Nothing Then Call ClearAllControls(Me)
                End Using
                'Καταχώρηση γραμμών
                Using oCmd As New OleDbCommand("InsertInvDetails", cn)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@invHid", I)
                    oCmd.ExecuteNonQuery()
                End Using
                'Ενημέρωση αρίθμησης σειράς όταν δεν είναι συγκεντρωτικό
                If SI = "NULL" Then Sen = GetSen(DosID, True)
                'Ενημέρωση δρομολογίου ότι τιμολογήθηκε
                sSQL = "UPDATE ROUTES SET invoiced = 1 where id = '" & R & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
                'Αφορά συγκεντρωτικό τιμολόγιο και η καταχώρηση εξόδου γίνεται έξω από αυτην την Procedure συγκεντρωτικά
                If SI = "NULL" Then
                    ' Καταχώρηση ποσόυ εξόδου (ΦΠΑ)
                    sSQL = "INSERT INTO EX ([code],[dtCreated],[price],[invhid],[excatid],[FilePath]) " &
                              "values (" & GetNewCode("EX") & ", " &
                                     "'" & Format(dtinvdate.Value, "yyyy/MM/dd HH:mm:ss") & "'," &
                                           Replace(txtFPA.Value, ",", ".") & "," &
                                           "'" & I & "'" & ",'F2FC308E-A583-4DD7-829D-6626819E106F'," & toSQLValueJ(txtdeltPath) & ")"
                    Using oCmd As New OleDbCommand(sSQL, cn)
                        oCmd.ExecuteNonQuery()
                    End Using
                End If
            End If
            Return True
            'Εκτύπωση
        Catch ex As OleDbException
            Select Case ex.ErrorCode
                Case -2147217873
                    MessageBox.Show("Έχει εκδοθεί τιμολόγιο γι' αυτό το δρομολόγιο.", "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                Case Else
                    MessageBox.Show(ex.ErrorCode.ToString + vbCrLf + ex.Message.ToString + vbCrLf + ex.Source.ToString)
                    Return False
            End Select
        Finally

        End Try
    End Function
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
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
    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        If txtdeltPath.Text.Length > 0 Then Process.Start(txtdeltPath.Text)
    End Sub
    Private Function CheckIfHandInvoiceExist(ByVal sdtid As String, ByVal docnumber As String) As Boolean
        Dim sSQL As String
        Dim cmd As OleDbCommand
        Dim sdr As OleDbDataReader
        sSQL = "select count(*) as exist from invh 
                inner join vw_seires vs on vs.sdtid=invh.sdtid
                where vs.sdtid= '" & sdtid & "' and docnumber = " & docnumber & " and ishand = 1"
        cmd = New OleDbCommand(sSQL, cn)
        sdr = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("exist")) = False Then
                If sdr.GetInt32(sdr.GetOrdinal("exist")) > 0 Then Return True Else Return False
            End If
            sdr.Close()
        End If

    End Function

    Private Sub cmdSygAnal_Click(sender As Object, e As EventArgs) Handles cmdSygAnal.Click
        frmPrintPreview.sTable = "SYGWITHDELT"
        frmPrintPreview.SYGHID = SYGINVHID
        frmPrintPreview.IsAkirotiko = IsAk
        frmPrintPreview.Show()
    End Sub
End Class