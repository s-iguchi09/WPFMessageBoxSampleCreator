using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMessageBoxSampleCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _viewModel = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _viewModel;

        }

        private void ShowMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_viewModel.MessageBoxText, _viewModel.Caption, _viewModel.MessageBoxButton, _viewModel.MessageBoxImage, _viewModel.MessageBoxResult, _viewModel.MessageBoxOptions);
        }
    }
}