using System.Windows;
using DevExpress.Xpf.Core;

namespace T439912 {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            ApplicationThemeHelper.ApplicationThemeName = Theme.Office2013LightGrayName;
        }
    }
}
