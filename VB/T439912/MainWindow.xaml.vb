Imports System.Windows
Imports DevExpress.Xpf.Printing

Namespace T439912
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub createReport_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim report = New SampleReport()
			report.xrPictureBox1.Image = Me.CreateBitmap()
			PrintHelper.ShowPrintPreviewDialog(Me, report)
		End Sub
	End Class
End Namespace
