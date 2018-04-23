Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace LimitNumberOfRecordsPerPage
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim detailreport As New XtraReport1()
            Dim printTool As New ReportPrintTool(detailreport)
            printTool.ShowPreview()
        End Sub
    End Class
End Namespace