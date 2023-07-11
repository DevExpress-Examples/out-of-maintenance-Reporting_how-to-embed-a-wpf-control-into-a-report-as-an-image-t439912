Imports System.Windows
Imports DevExpress.Xpf.Printing

Namespace T439912

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub createReport_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim report = New SampleReport()
            report.xrPictureBox1.Image = CreateBitmap()
            PrintHelper.ShowPrintPreviewDialog(Me, report)
        End Sub
    End Class
End Namespace
