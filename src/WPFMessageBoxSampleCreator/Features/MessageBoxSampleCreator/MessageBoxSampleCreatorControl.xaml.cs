using System.Windows;
using System.Windows.Controls;

namespace WPFMessageBoxSampleCreator.Features.MessageBoxSampleCreator
{
    /// <summary>
    /// MessageBoxSampleCreatorControl.xaml の相互作用ロジック
    /// </summary>
    public partial class MessageBoxSampleCreatorControl : UserControl
    {
        private MessageBoxSampleCreatorViewModel _viewModel;
        public MessageBoxSampleCreatorControl()
        {
            InitializeComponent();
            Loaded += (sender,e) => _viewModel = DataContext as MessageBoxSampleCreatorViewModel ?? new MessageBoxSampleCreatorViewModel();
        }

        private void ShowMessageBox_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show(_viewModel.MessageBoxText, _viewModel.Caption, _viewModel.MessageBoxButton, _viewModel.MessageBoxImage, _viewModel.MessageBoxResult, _viewModel.MessageBoxOptions);
        }

    }
}
