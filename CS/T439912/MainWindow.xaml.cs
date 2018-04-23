using System.Windows;
using DevExpress.Xpf.Printing;

namespace T439912 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void createReport_Click(object sender, RoutedEventArgs e) {
            var report = new SampleReport();
            report.xrPictureBox1.Image = this.CreateBitmap();
            PrintHelper.ShowPrintPreviewDialog(this, report);
        }
    }
}
