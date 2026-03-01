using System.Windows;

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
    }
}