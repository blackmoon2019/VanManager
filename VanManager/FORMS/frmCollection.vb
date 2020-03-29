Imports System.Data.OleDb
Public Class frmCollection
    Private sdtID As String
    Public Mode As Byte
    Private InvHcode As Int64
    Private Sen As Int64
    Private CID As String
    Private DosID As String
    Private Sub frmCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sSQL As String
        Dim cmd As OleDbCommand
        Dim sdr As OleDbDataReader
        Try

            'sSQL = "Select dos.name,sdt.id as sdtid ,DOS.id as dosid , " &
            'IIf(Mode = FormMode.NewRecord, " isnull(sen.number,0) + 1", " isnull(sen.number,1) ") & "  as number
            '        From SDT 
            '            inner join sts on sts.sdtid = sdt.id 
            '            inner join dos on dos.id = sts.dosid 
            '            inner join users on users.id  = sts.userid 
            '            left join sen on sen.dosid=dos.id
            '            where sdtcode = 2 and sts.userid = '" & UserID & "'"
            'If Mode = FormMode.NewRecord Then
            cmd = New OleDbCommand("Select dosname as name,sdtid ,dosid ,isnull(number,0) + 1 as number
                                            from vw_seires 
                                            where sdtcode = 2   and userid = '" & UserID & "'", cn)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                    If sdr.IsDBNull(sdr.GetOrdinal("sdtid")) = False Then sdtID = sdr.GetGuid(sdr.GetOrdinal("sdtid")).ToString
                    If sdr.IsDBNull(sdr.GetOrdinal("name")) = False Then txtCode.Text = sdr.GetString(sdr.GetOrdinal("name"))
                    If sdr.IsDBNull(sdr.GetOrdinal("dosid")) = False Then DosID = sdr.GetGuid(sdr.GetOrdinal("dosid")).ToString
                    If sdr.IsDBNull(sdr.GetOrdinal("number")) = False Then txtNumber.Value = sdr.GetInt64(sdr.GetOrdinal("number"))
                    sdr.Close()
                End If
            'Else


            'End If
            'Sen = GetSen(DosID)

            cmd = New OleDbCommand("SELECT 	bankname,DOSNAME,cashDate,cashPrice,chequeDate,chequeNum,chequePrice ,
                                    depositDate,depositNum,depositPrice,MainCusFullName,MainCusAddress ,docnumber, 
			                        MainCusafm,MainCusPrfName,printedDate ,COALESCE(SeiraEXOF,SeiraEXOFSYG) AS SeiraEXOF,
			                        COALESCE(EXOF,EXOFSYG) AS EXOF,COALESCE(ANEX,ANEXSYG) AS ANEX,
			                        COALESCE(SeiraANEX,SeiraANEXSYG) AS SeiraANEX,
			                        COALESCE(posokal,posokalsyg) as posokal,COALESCE(gentot,gentotsyg) as gentot,
			                        COALESCE(ypol,ypolsyg) as ypol 
                        FROM (        
                        select		bankname,VC.DOSNAME,vc.cashDate,vc.cashPrice,vc.chequeDate,vc.chequeNum,vc.chequePrice ,
                                    vc.depositDate,vc.depositNum,vc.depositPrice,vc.MainCusFullName,vc.MainCusAddress ,
			                        vc.MainCusafm,vc.MainCusPrfName,vc.printedDate,VC.docnumber ,
                                    (select sum(price) 	FROM vw_INVOICES VWI  
                                    inner join COLD  on COLD.invhid  =VWI.id     
                                    where  COLD.COLID =vc.id        ) as posokal,
                                    (select sum(gentot) 	FROM vw_INVOICES VWI  
                                    inner join COLD  on COLD.invhid  =VWI.id     
                                    where  COLD.COLID =vc.id        ) as gentot,
                                    (select sum(ypol) 	FROM vw_INVOICES VWI  
                                    inner join COLD  on COLD.invhid  =VWI.id     
                                    where  COLD.COLID =vc.id        ) as ypol,
			                        (select sum(price) 	FROM vw_INVOICESSYG  VWI  
                                    inner join COLD  on COLD.invhsygid   =VWI.id     
                                    where  COLD.COLID =vc.id        ) as posokalsyg,
                                    (select sum(gentot) 	FROM vw_INVOICESSYG VWI  
                                    inner join COLD  on COLD.invhsygid  =VWI.id     
                                    where  COLD.COLID =vc.id        ) as gentotsyg,
                                    (select sum(ypol) 	FROM vw_INVOICESSYG VWI  
                                    inner join COLD  on COLD.invhsygid  =VWI.id     
                                    where  COLD.COLID =vc.id        ) as ypolsyg,
                                    (SELECT STUFF((SELECT ',' + SEIRA     
                                    FROM vw_INVOICES VWI  
                                    inner join COLD  on COLD.invhid  =VWI.id     
                                    where  COLD.COLID =vc.id    and vwi.ypol=0      FOR XML PATH('') ), 1, 1, '')) as SeiraEXOF,
                                    (SELECT 'ΕΞΟΦΛΗΣΗ ΤΙΜΟΛΟΓΙΩΝ:' + STUFF((SELECT ',' + SEIRA
                                    FROM vw_INVOICES VWI  
                                    inner join COLD  on COLD.invhid  =VWI.id     
                                    where  COLD.COLID =vc.id   and vwi.ypol=0     FOR XML PATH('') ), 1, 1, '')) as EXOF,
                                    (SELECT 'ΕΝΑΝΤΙ ΤΙΜΟΛΟΓΙΩΝ:' + STUFF((SELECT ',' + SEIRA
                                    FROM vw_INVOICES VWI  
                                    inner join COLD  on COLD.invhid  =VWI.id     
                                    where  COLD.COLID =vc.id   and vwi.ypol<>0     FOR XML PATH('') ), 1, 1, '')) as ANEX,
                                    (SELECT STUFF((SELECT ',' + SEIRA
                                    FROM vw_INVOICES VWI  
                                    inner join COLD  on COLD.invhid  =VWI.id     
                                    where  COLD.COLID =vc.id    and vwi.ypol<>0      FOR XML PATH('') ), 1, 1, '')) as SeiraANEX,
			                        (SELECT STUFF((SELECT ',' + SEIRA     
                                    FROM vw_INVOICESSYG VWI  
                                    inner join COLD  on COLD.invhsygid  =VWI.invhsygid 
                                    where  COLD.COLID =vc.id    and vwi.ypol=0      FOR XML PATH('') ), 1, 1, '')) as SeiraEXOFSYG,
                                    (SELECT 'ΕΞΟΦΛΗΣΗ ΤΙΜΟΛΟΓΙΩΝ:' + STUFF((SELECT ',' + SEIRA
                                    FROM vw_INVOICESSYG VWI  
                                    inner join COLD  on COLD.invhsygid  =VWI.invhsygid 
                                    where  COLD.COLID =vc.id   and vwi.ypol=0     FOR XML PATH('') ), 1, 1, '')) as EXOFSYG,
                                    (SELECT 'ΕΝΑΝΤΙ ΤΙΜΟΛΟΓΙΩΝ:' + STUFF((SELECT ',' + SEIRA
                                    FROM vw_INVOICESSYG VWI  
                                    inner join COLD  on COLD.invhsygid  =VWI.invhsygid 
                                    where  COLD.COLID =vc.id   and vwi.ypol<>0     FOR XML PATH('') ), 1, 1, '')) as ANEXSYG,
                                    (SELECT STUFF((SELECT ',' + SEIRA
                                    FROM vw_INVOICESSYG VWI  
                                    inner join COLD  on COLD.invhsygid  =VWI.invhsygid 
                                    where  COLD.COLID =vc.id    and vwi.ypol<>0      FOR XML PATH('') ), 1, 1, '')) as SeiraANEXSYG
                        from vw_col VC
                                                        where vc.id='" & CID & "' ) AS COLS", cn)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("bankname")) = False Then txtBankName.Text = sdr.GetString(sdr.GetOrdinal("bankname"))
                If sdr.IsDBNull(sdr.GetOrdinal("MainCusFullname")) = False Then txtMCusL.Text = sdr.GetString(sdr.GetOrdinal("MainCusFullname"))
                If sdr.IsDBNull(sdr.GetOrdinal("MAINCUSPrfName")) = False Then txtMCusPRF.Text = sdr.GetString(sdr.GetOrdinal("MAINCUSPrfName"))
                If sdr.IsDBNull(sdr.GetOrdinal("MAINCusAFM")) = False Then txtMCusA.Text = sdr.GetString(sdr.GetOrdinal("MAINCusAFM"))
                If sdr.IsDBNull(sdr.GetOrdinal("MAINCUSAddress")) = False Then txtMCusADR.Text = sdr.GetString(sdr.GetOrdinal("MAINCUSAddress"))
                If sdr.IsDBNull(sdr.GetOrdinal("cashPrice")) = False Then txtCashPrice.Value = sdr.GetDecimal(sdr.GetOrdinal("cashPrice"))
                If sdr.IsDBNull(sdr.GetOrdinal("chequePrice")) = False Then txtChequePrice.Value = sdr.GetDecimal(sdr.GetOrdinal("chequePrice"))
                If sdr.IsDBNull(sdr.GetOrdinal("depositPrice")) = False Then txtDepositPrice.Value = sdr.GetDecimal(sdr.GetOrdinal("depositPrice"))
                If sdr.IsDBNull(sdr.GetOrdinal("chequeNum")) = False Then txtchequeNum.Text = sdr.GetString(sdr.GetOrdinal("chequeNum"))
                If sdr.IsDBNull(sdr.GetOrdinal("DepositNum")) = False Then txtdepositNum.Text = sdr.GetString(sdr.GetOrdinal("DepositNum"))
                If sdr.IsDBNull(sdr.GetOrdinal("cashdate")) = False Then dtCashDate.Value = (sdr.GetDateTime(sdr.GetOrdinal("cashdate")))
                If sdr.IsDBNull(sdr.GetOrdinal("chequedate")) = False Then dtchequeDate.Value = (sdr.GetDateTime(sdr.GetOrdinal("chequedate")))
                If sdr.IsDBNull(sdr.GetOrdinal("depositdate")) = False Then dtdepositDate.Value = (sdr.GetDateTime(sdr.GetOrdinal("depositdate")))
                If sdr.IsDBNull(sdr.GetOrdinal("docnumber")) = False Then txtNumber.Value = sdr.GetInt32(sdr.GetOrdinal("docnumber"))
                If sdr.IsDBNull(sdr.GetOrdinal("dosname")) = False Then txtCode.Text = sdr.GetString(sdr.GetOrdinal("dosname")).Substring(0, 3)
                If sdr.IsDBNull(sdr.GetOrdinal("printedDate")) = False Then
                    dtColdate.Value = (sdr.GetDateTime(sdr.GetOrdinal("printedDate")))
                    dtColdate.ReadOnly = True
                Else
                    dtColdate.Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    dtColdate.ReadOnly = False
                End If
                If sdr.IsDBNull(sdr.GetOrdinal("ypol")) = False Then txtYpol.Value = sdr.GetDecimal(sdr.GetOrdinal("ypol"))
                If sdr.IsDBNull(sdr.GetOrdinal("gentot")) = False Then txtTotal.Value = sdr.GetDecimal(sdr.GetOrdinal("gentot"))
                If sdr.IsDBNull(sdr.GetOrdinal("posokal")) = False Then txtPoso.Value = sdr.GetDecimal(sdr.GetOrdinal("posokal"))
                If sdr.IsDBNull(sdr.GetOrdinal("SeiraANEX")) = False Then txtInvoicesANEX.Text = sdr.GetString(sdr.GetOrdinal("SeiraANEX"))
                If sdr.IsDBNull(sdr.GetOrdinal("SeiraEXOF")) = False Then txtInvoicesEX.Text = sdr.GetString(sdr.GetOrdinal("SeiraEXOF"))
                If sdr.IsDBNull(sdr.GetOrdinal("EXOF")) = False Then txtDescr.Text = sdr.GetString(sdr.GetOrdinal("EXOF"))
                If sdr.IsDBNull(sdr.GetOrdinal("ANEX")) = False Then txtDescr.Text = txtDescr.Text & " / " & sdr.GetString(sdr.GetOrdinal("ANEX"))
                txtHolloPrice.Text = ConvertNumToWords.ConvertNumInGR(Replace(txtPoso.Text, "€", ""))
                sdr.Close()
            Else
                Sen = 1
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
        End Try
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Try
            'Ενημέρωση αρίθμησης σειράς
            If Mode = FormMode.NewRecord Then
                Sen = GetSen(DosID, True)
                Dim sSQL As String
                sSQL = "UPDATE COLH SET PRINTED = 1,PRINTEDDATE = '" & Format(dtColdate.Value, "yyyy-MM-dd") & "',DOSNAME='" & txtCode.Text & Sen & "', " &
                    "holloprice = '" & txtHolloPrice.Text & "',descr = '" & txtDescr.Text & "', docnumber = '" & Sen & "' WHERE ID = '" & CID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
            Else
                Dim sSQL As String
                sSQL = "UPDATE COLH SET PRINTED = 1,PRINTEDDATE = '" & Format(dtColdate.Value, "yyyy-MM-dd") & "',DOSNAME='" & txtCode.Text & txtNumber.Value & "', " &
                    "holloprice = '" & txtHolloPrice.Text & "',descr = '" & txtDescr.Text & "', docnumber = '" & txtNumber.Value & "' WHERE ID = '" & CID & "'"
                Using oCmd As New OleDbCommand(sSQL, cn)
                    oCmd.ExecuteNonQuery()
                End Using
            End If

            frmPrintPreview.sTable = "COLH"
            frmPrintPreview.COLHID = CID
            frmPrintPreview.Show()
            Mode = FormMode.EditRecord
        Catch ex As Exception
            MessageBox.Show(ex.Message, "VanManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
        End Try

    End Sub
    Public WriteOnly Property COLID As String
        Set(value As String)
            CID = value
        End Set
    End Property

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class