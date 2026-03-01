using System.ComponentModel;

namespace WPFMessageBoxSampleCreator
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged = delegate { };
    }
}
