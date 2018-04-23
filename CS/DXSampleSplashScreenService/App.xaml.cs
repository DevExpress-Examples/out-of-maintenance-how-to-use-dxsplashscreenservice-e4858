using System.Windows;

namespace DXSampleSplashScreenService {
    public partial class App : Application {
        private void OnAppStartup_UpdateThemeName(object sender, StartupEventArgs e) {
            DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName();
        }
    }
}
