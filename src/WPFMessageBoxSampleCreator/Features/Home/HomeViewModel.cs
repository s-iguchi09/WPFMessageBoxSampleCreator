using System.ComponentModel;
using WPFMessageBoxSampleCreator.Core.Interfaces;

namespace WPFMessageBoxSampleCreator.Features.Home
{
    public class HomeViewModel : INotifyPropertyChanged, IListBoxItem
    {
        public event PropertyChangedEventHandler? PropertyChanged = delegate { };
        public string Name => "Home";

        public override string ToString()
        {
            return "Home";
        }
    }
}
