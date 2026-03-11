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
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://s-iguchi09.github.io/",
                UseShellExecute = true
            });
        }
    }

}
