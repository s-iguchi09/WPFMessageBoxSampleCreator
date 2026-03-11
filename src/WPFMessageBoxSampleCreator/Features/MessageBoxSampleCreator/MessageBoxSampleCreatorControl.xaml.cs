using System.Windows;
using System.Windows.Controls;

namespace WPFMessageBoxSampleCreator.Features.MessageBoxSampleCreator
{
    /// <summary>
    /// MessageBoxSampleCreatorControl.xaml の相互作用ロジック
    /// </summary>
    public partial class MessageBoxSampleCreatorControl : UserControl
    {
        private MessageBoxSampleCreatorViewModel? _viewModel = null;
        private MessageBoxSampleCreatorViewModel ViewModel => _viewModel ??= (MessageBoxSampleCreatorViewModel)DataContext;
        public MessageBoxSampleCreatorControl()
        {
            InitializeComponent();
            Loaded += (sender,e) => _viewModel = DataContext as MessageBoxSampleCreatorViewModel ?? new MessageBoxSampleCreatorViewModel();
        }

        private void ShowMessageBox_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel is null)
                return;

            MessageBox.Show(ViewModel.MessageBoxText, ViewModel.Caption, ViewModel.MessageBoxButton, ViewModel.MessageBoxImage, ViewModel.MessageBoxResult, ViewModel.MessageBoxOptions);
        }

    }
}
