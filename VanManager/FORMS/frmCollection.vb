﻿Imports System.Data.OleDb
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
        Try

            sSQL = "Select dos.name,sdt.id as sdtid ,DOS.id as dosid , " &
            IIf(Mode = FormMode.NewRecord, " isnull(sen.number,0) + 1", " isnull(sen.number,1) ") & "  as number
                    From SDT 
                        inner join sts on sts.sdtid = sdt.id 
                        inner join dos on dos.id = sts.dosid 
                        inner join users on users.id  = sts.userid 
                        left join sen on sen.dosid=dos.id
                        where sdtcode = 2 and sts.userid = '" & UserID & "'"

            cmd = New OleDbCommand(sSQL, cn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()

            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("sdtid")) = False Then sdtID = sdr.GetGuid(sdr.GetOrdinal("sdtid")).ToString
                If sdr.IsDBNull(sdr.GetOrdinal("name")) = False Then txtCode.Text = sdr.GetString(sdr.GetOrdinal("name"))
                If sdr.IsDBNull(sdr.GetOrdinal("dosid")) = False Then DosID = sdr.GetGuid(sdr.GetOrdinal("dosid")).ToString
                If sdr.IsDBNull(sdr.GetOrdinal("number")) = False Then txtNumber.Value = sdr.GetInt64(sdr.GetOrdinal("number"))
                sdr.Close()
            End If
            'Sen = GetSen(DosID)

            cmd = New OleDbCommand("select bankname,VC.DOSNAME,
	                                vc.cashDate,vc.cashPrice,vc.chequeDate,vc.chequeNum,vc.chequePrice ,
	                                vc.depositDate,vc.depositNum,vc.depositPrice,vc.MainCusFullName,
	                                vc.MainCusAddress ,vc.MainCusafm,vc.MainCusPrfName,
                                (select sum(price) 	FROM vw_INVOICES VWI  
                                inner join COLD  on COLD.invhid  =VWI.id     
                                where  COLD.COLID =vc.id        ) as posokal,
                                (select sum(gentot) 	FROM vw_INVOICES VWI  
                                inner join COLD  on COLD.invhid  =VWI.id     
                                where  COLD.COLID =vc.id        ) as gentot,
                                (select sum(ypol) 	FROM vw_INVOICES VWI  
                                inner join COLD  on COLD.invhid  =VWI.id     
                                where  COLD.COLID =vc.id        ) as ypol,
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
                                where  COLD.COLID =vc.id    and vwi.ypol<>0      FOR XML PATH('') ), 1, 1, '')) as SeiraANEX
                               from vw_col VC
                                where vc.id='" & CID & "'", cn)
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
                If sdr.IsDBNull(sdr.GetOrdinal("ypol")) = False Then txtYpol.Value = sdr.GetDecimal(sdr.GetOrdinal("ypol"))
                If sdr.IsDBNull(sdr.GetOrdinal("gentot")) = False Then txtTotal.Value = sdr.GetDecimal(sdr.GetOrdinal("gentot"))
                If sdr.IsDBNull(sdr.GetOrdinal("posokal")) = False Then txtPoso.Value = sdr.GetDecimal(sdr.GetOrdinal("posokal"))
                If sdr.IsDBNull(sdr.GetOrdinal("SeiraEXOF")) = False Then txtInvoicesEX.Text = sdr.GetString(sdr.GetOrdinal("SeiraEXOF"))
                If sdr.IsDBNull(sdr.GetOrdinal("SeiraANEX")) = False Then txtInvoicesANEX.Text = sdr.GetString(sdr.GetOrdinal("SeiraANEX"))
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
            'Dim colcmd As OleDbCommand = New OleDbCommand("Select dos.name,DOS.id as dosid
            '                                                        from SDT 
            '                                                         inner join sts on sts.sdtid = sdt.id 
            '                                                         inner join dos on dos.id = sts.dosid 
            '                                                         inner join users on users.id  = sts.userid 
            '                                                         where sdtcode = 2 and sts.userid = '" & UserID & "'", cn)
            'Dim colsdr As OleDbDataReader = colcmd.ExecuteReader()
            'Dim DosName As String
            'Dim snum As Long
            'Dim DosID As String
            'Dim Sen As Long
            'If (colsdr.Read() = True) Then
            '    If colsdr.IsDBNull(colsdr.GetOrdinal("name")) = False Then DosName = colsdr.GetString(colsdr.GetOrdinal("name"))
            '    If colsdr.IsDBNull(colsdr.GetOrdinal("dosid")) = False Then DosID = colsdr.GetGuid(colsdr.GetOrdinal("dosid")).ToString
            'Ενημέρωση αρίθμησης σειράς
            If Mode = FormMode.NewRecord Then Sen = GetSen(DosID, True)
            '    colsdr.Close()
            'Else
            '    Sen = 1
            'End If

            Dim sSQL As String
            sSQL = "UPDATE COLH SET PRINTED = 1,PRINTEDDATE = '" & Format(Date.Now, "yyyy-MM-dd") & "',DOSNAME='" & txtCode.Text & IIf(Mode = FormMode.NewRecord, Sen, txtNumber.Value) & "', " &
                    "holloprice = '" & txtHolloPrice.Text & "',descr = '" & txtDescr.Text & "', docnumber = '" & IIf(Mode = FormMode.NewRecord, Sen, txtNumber.Value) & "' WHERE ID = '" & CID & "'"
            Using oCmd As New OleDbCommand(sSQL, cn)
                oCmd.ExecuteNonQuery()
            End Using
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