using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WPFMessageBoxSampleCreator.Features.About
{
    /// <summary>
    /// AboutControl.xaml の相互作用ロジック
    /// </summary>
    public partial class AboutControl : UserControl
    {
        public AboutControl()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
            e.Handled = true;
        }
    }
}
