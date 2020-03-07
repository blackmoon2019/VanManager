Imports System.Drawing.Printing
Imports Janus.Windows.Ribbon

Public Class frmPPreview
    Private Sub frmPPreview_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Ribbon1_CommandClick(sender As Object, e As CommandEventArgs) Handles Ribbon1.CommandClick
        Select Case e.Command.Key
            Case "Page_Setup"
                PrintPreviewControl1.AutoZoom = False
                PrintPreviewControl1.Zoom = 1
            Case "LandScape"
                PrintPreviewControl1.Document.DefaultPageSettings.Landscape = True
                PrintPreviewControl1.Refresh()
            Case "Portrait" : PrintPreviewControl1.Document.DefaultPageSettings.Landscape = False
            Case "Next_Page" : Me.PrintPreviewControl1.StartPage = Me.PrintPreviewControl1.StartPage + 1
            Case "Previews_Page" : Me.PrintPreviewControl1.StartPage = Me.PrintPreviewControl1.StartPage - 1
            Case "One_Page"
                Me.PrintPreviewControl1.AutoZoom = True
                Me.PrintPreviewControl1.Rows = 1
                Me.PrintPreviewControl1.Columns = 1
            Case "Two_Pages"
                Me.PrintPreviewControl1.AutoZoom = True
                Me.PrintPreviewControl1.Rows = 1
                Me.PrintPreviewControl1.Columns = 2
            Case "Print"
                Me.PrintPreviewControl1.Document.Print()
                Me.Close()
            Case "Close_Preview" : Me.Close()
        End Select
    End Sub

    Private Sub GridEXPrintDocument1_QueryPageSettings(sender As Object, e As QueryPageSettingsEventArgs) Handles GridEXPrintDocument1.QueryPageSettings
        'PrintPreviewControl1.Document.DefaultPageSettings.Landscape = True
        Dim ps As New PaperSize("A4Landscape", 1169, 827)
        ps.PaperName = PaperKind.A4
        e.PageSettings.Landscape = True
        e.PageSettings.Margins.Left = 1
        e.PageSettings.Margins.Right = 1
        e.PageSettings.Margins.Top = 1
        e.PageSettings.Margins.Bottom = 1
        'PrintPreviewControl1.Document.DefaultPageSettings.PaperSize = ps
        'PrintPreviewControl1.Document.DefaultPageSettings.Landscape = True


    End Sub
End Class