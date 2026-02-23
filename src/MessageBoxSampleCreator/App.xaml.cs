using System.Configuration;
using System.Data;
using System.Windows;

namespace WPFMessageBoxSampleCreator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private WebView2Window dialog = new();
        private bool isDialogClosed = false;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            dialog.Closed += (sender, e) => isDialogClosed = true;
            dialog.Show();
            MainWindow = new MainWindow();
            MainWindow.Closed += MainWindow_Closed;
            MainWindow.Show();
        }

        private void MainWindow_Closed(object? sender, EventArgs e)
        {
            if (!isDialogClosed)
            {
                dialog.Close();
            }
        }
    }

}
