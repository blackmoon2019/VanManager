Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports Microsoft.Reporting.WinForms
Public Class frmPrintPreview
    Private HID As String
    Private CID As String
    Private SID As String
    Private IsAk As Boolean = False
    Public sTable As String
    Private PdfFilename As String
    Private Sub frmPrintPreview_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim rptDataSource As ReportDataSource
        Dim rptDataSource2 As ReportDataSource
        Dim sql As String
        Dim table As New DataTable
        Dim table2 As New DataTable
        Dim bs1 As New BindingSource
        Dim adapter As New OleDb.OleDbDataAdapter

        Try
            Select Case sTable
                'ΑΠΟΔΕΙΞΗ ΕΙΣΠΡΑΞΗΣ
                Case "COLH"
                    'HID = "044DF391-746D-44A7-9EE6-A6C6E03649A1"
                    With Me.ReportViewer1.LocalReport
                        .ReportPath = Application.StartupPath & "\Reports\COLLECTION.rdl"
                        .DataSources.Clear()
                    End With
                    sql = "select bankname,vc.holloprice,VC.DESCR AS Aitiologia,
	                                vc.MAINCUSDoyname,vc.dosname as SEIRA,vc.cashDate,vc.cashPrice,vc.chequeDate,vc.chequeNum,vc.chequePrice ,VC.TOTAL AS TotalEisp,
	                                vc.depositDate,vc.depositNum,vc.depositPrice,vc.MainCusFullName,
	                                vc.MainCusAddress ,vc.MainCusafm,vc.MainCusPrfName,
                                convert(varchar(10), printedDate , 108) as printedTime,
		                        CONVERT(VARCHAR(10), printedDate, 103) as printedDate,
	                            ISNULL(VC.cusInvbalance  ,0) AS balance,
	                            ISNULL(VC.cusInvPrevBalance ,0) AS PrevBalance,
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
                                inner join vw_cus C on c.id=vc.MainCusID 
                                where vc.id = '" & CID & "'"
                    adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
                    adapter.Fill(table)
                    bs1.DataSource = table
                    '' Use the same name as defined in the report Data Source Definition
                    rptDataSource = New ReportDataSource("COLLECTIONS", table)
                    Me.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
                'ΤΙΜΟΛΟΓΙΟ
                Case "INVH"

                    'HID = "044DF391-746D-44A7-9EE6-A6C6E03649A1"
                    With Me.ReportViewer1.LocalReport
                        .ReportPath = Application.StartupPath & "\Reports\ROUTESBCK.rdl"
                        .DataSources.Clear()
                    End With

                    sql = "SELECT	 
		                     INVH.id
                            ,INVH.docnumber
		                    ,R.CODE
                            ,R.FAreaName 
		                    ,R.TAreaName 
		                    ,R.FCusLastname 
		                    ,R.FCusName 
		                    ,R.FCusAddress 
		                    ,R.FCusPrfName 
		                    ,R.FDoyname 
		                    ,R.FAFM 
		                    ,R.TCusLastname 
		                    ,R.TCusName 
		                    ,R.TCusAddress 
		                    ,R.TCusPrfName 
		                    ,R.TDoyname 
		                    ,R.TAFM 
		                    ,R.MAINCUSLastname 
		                    ,R.MAINCUSname
		                    ,R.MAINCUSAddress  
		                    ,R.MAINCUSPrfName 
		                    ,R.MAINCUSDoyname 
		                    ,R.MAINCusAFM 
		                    ,R.invoiced AS 'Τιμολογήθηκε'
	                        ,DRVFullName
	                        ,R.dtCreated AS 'Ημερ/νία Δρομολογίου'
	                        ,R.cost AS 'Κόστος'
	                        ,R.plate AS 'Αρ. Πινακίδας'
		                    ,R.DRVAddress 
		                    ,R.kg
		                    ,R.pal
		                    ,R.kola
                            ,R.stiname
		                    ,INVH.description
		                    ,INVH.holloprice
                            ,convert(varchar(10), invdate , 108) as InvTime
		                    ,CONVERT(VARCHAR(10), invdate, 103) as invdate
		                    ,P.NAME as Pname
                            ,P.Code as PayCode
		                    ,INVH.DOSNAME
		                    ,INVH.CODE as parnumber
		                    ,INVH.kAxia
		                    ,INVH.fpacost 
		                    ,INVH.gentot 
                            ,dos.ishand 
                            ,case when INVH.idakiromeno is  null then  sdt.descr else sdt.descrak end  AS sdtDescr
							,ISNULL(INVH.cusInvbalance,0) AS cusInvbalance
							,ISNULL(INVH.cusInvPrevBalance,0) AS cusInvPrevBalance
                            FROM INVH 
		                    INNER JOIN vw_ROUTES R ON INVH.routeID=R.ID
		                    INNER JOIN VW_PAY P ON P.id=INVH.payID 
                            INNER JOIN vw_CUS C ON c.id = R.MainCusID 
		                    INNER JOIN SDT ON SDT.id = INVH.sdtid 
		                    inner join sts on sts.sdtid = sdt.id 
                            inner join dos on dos.id = sts.dosid " & IIf(IsAk = True, " and dos.iscancel=1 ", "and dos.iscancel=0") &
                            "WHERE  INVH.id = '" & HID & "'"
                    adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
                    adapter.Fill(table)
                    bs1.DataSource = table
                    PdfFilename = table.Rows(0).Item("dosname") & table.Rows(0).Item("docnumber") & ".PDF"
                    '' Use the same name as defined in the report Data Source Definition
                    rptDataSource = New ReportDataSource("INVOICES", table)
                    sql = "select ardelt,R.stiname ,P.ROUTEID
                            from INVD 
                            INNER JOIN vw_POI P ON P.id = INVD.poiId 
                            inner join vw_ROUTES R on P.routeID = R.ID 
                            WHERE  INVD.iNVHID = '" & HID & "' order by 1"
                    adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
                    adapter.Fill(table2)
                    bs1.DataSource = table2
                    rptDataSource2 = New ReportDataSource("POI", table2)

                    Me.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
                    Me.ReportViewer1.LocalReport.DataSources.Add(rptDataSource2)
                Case "INVHSYG"

                    'HID = "044DF391-746D-44A7-9EE6-A6C6E03649A1"
                    With Me.ReportViewer1.LocalReport
                        .ReportPath = Application.StartupPath & "\Reports\SYGINVOICE.rdl"
                        .DataSources.Clear()
                    End With

                    sql = "SELECT C.code,C.CusName,C.PRFNAME,C.CusAddress,C.AreasName + ' ' + C.TK AS A,C.afm,C.DoyName,
					S.Farea,S.Tarea,S.holloprice ,S.description ,P.NAME as Payname,s.kAxia,s.fpacost,s.gentot ,
					case when s.idakiromeno is  null then  sdt.descr else sdt.descrak end  AS sdtDescr,s.dosname ,s.docnumber,convert(varchar(10), s.invdate , 108) as InvTime,
					CONVERT(VARCHAR(10), s.invdate, 103) as invdate, S.skopos,P.code AS PayCode,
                    ISNULL(S.cusInvbalance,0) AS cusInvbalance,ISNULL(S.cusInvPrevBalance ,0) AS cusInvPrevBalance
					FROM INVHSYG S
					INNER JOIN SDT ON SDT.id=S.sdtid 
		            inner join sts on sts.sdtid = sdt.id 
                    inner join dos on dos.id = sts.dosid " & IIf(IsAk = True, " and dos.iscancel=1 ", "and dos.iscancel=0") &
                    "INNER JOIN vw_CUS C ON C.id = S.cusid 
					INNER JOIN vw_PAY P ON S.payID = P.id
                    WHERE  S.id = '" & SID & "'"
                    adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
                    adapter.Fill(table)
                    bs1.DataSource = table
                    '' Use the same name as defined in the report Data Source Definition
                    rptDataSource = New ReportDataSource("HEADER", table)
                    sql = "SELECT R.CODE,stiname,CONVERT(VARCHAR(10), r.dtCreated, 103) as dtCreated,plate ,R.cost ,R.fpacost,R.gentot 
					FROM INVHSYG S
					INNER JOIN vw_INVOICES I ON I.invhsygid = S.ID
					INNER JOIN VW_ROUTES R ON R.ID = I.ROUTEID
                    WHERE  S.ID = '" & SID & "' order by dtcreated"
                    adapter.SelectCommand = New OleDb.OleDbCommand(sql, cn)
                    adapter.Fill(table2)
                    bs1.DataSource = table2
                    rptDataSource2 = New ReportDataSource("DETAILS", table2)

                    Me.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
                    Me.ReportViewer1.LocalReport.DataSources.Add(rptDataSource2)

            End Select
            'Dim parameters(0) As ReportParameter
            'parameters(0) = New ReportParameter("INVHID", HID)
            'ReportViewer1.LocalReport.SetParameters(parameters)
            'Me.ReportViewer1.RefreshReport()


            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Public WriteOnly Property IsAkirotiko As Boolean
        Set(value As Boolean)
            IsAk = value
        End Set
    End Property

    Private Sub ReportViewer1_ReportExport(sender As Object, e As ReportExportEventArgs) Handles ReportViewer1.ReportExport
        Select Case e.Extension.Name
            Case "PDF"
                'Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
                'Dim saveFileDialog1 As New SaveFileDialog()
                'saveFileDialog1.Filter = "*PDF files (*.pdf)|*.pdf"
                'saveFileDialog1.FilterIndex = 2
                'saveFileDialog1.RestoreDirectory = True
                'Dim newFile As New FileStream("C:\Users\blackmoon-home\source\repos\VanManager\VanManager\bin\Debug\test.pdf", FileMode.Create)
                'newFile.Write(byteViewer, 0, byteViewer.Length)
                'newFile.Close()
                e.Cancel = True

                Using SFD As New Windows.Forms.SaveFileDialog()
                    With SFD
                        .DefaultExt = "PDF"
                        .AddExtension = True
                        .Filter = "PDF files (*.PDF)|*.PDF"
                        .InitialDirectory = Application.ExecutablePath
                    End With
                    If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
                        Dim newFile As New FileStream(SFD.FileName, FileMode.Create)
                        newFile.Write(byteViewer, 0, byteViewer.Length)
                        newFile.Close()
                        Process.Start(SFD.FileName)
                        'Call SendMailOneAttachment("johnmavroselinos@gmail.com", "j.mavroselinos@gmail.com", "test", "Το τιμολόγιο σας", newFile.Name)
                    End If
                End Using

        End Select
    End Sub
    Private Sub SendMailOneAttachment(ByVal From As String,
      ByVal sendTo As String, ByVal Subject As String,
      ByVal Body As String,
      Optional ByVal AttachmentFile As String = "",
      Optional ByVal CC As String = "",
      Optional ByVal BCC As String = "",
      Optional ByVal SMTPServer As String = "")

        Using mm As New MailMessage(From, sendTo)
            mm.Subject = Subject
            mm.Body = Body
            If File.Exists(AttachmentFile) Then
                Dim fileName As String = Path.GetFileName(AttachmentFile)
                mm.Attachments.Add(New Attachment(AttachmentFile))
            End If

            mm.IsBodyHtml = False
            Dim smtp As New SmtpClient()
            smtp.Host = "smtp.gmail.com"
            smtp.EnableSsl = True
            Dim NetworkCred As New NetworkCredential(From, "mavros18!")
            smtp.UseDefaultCredentials = False
            smtp.Credentials = NetworkCred
            smtp.Port = 587
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            smtp.Send(mm)
            MessageBox.Show("Email sent.", "Message")
        End Using


    End Sub
End Class