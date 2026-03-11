using System.ComponentModel;
using System.Windows;

namespace WPFMessageBoxSampleCreator.Features.MessageBoxSampleCreator
{
    public class MessageBoxSampleCreatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged = delegate { };

        public override string ToString()
        {
            return "MessageBox";
        }

        public string MessageBoxText { get; set; } = string.Empty;
        public string Caption { get; set; } = string.Empty;

        public MessageBoxButton MessageBoxButton { get; set; } = MessageBoxButton.OK;
        public Dictionary<string, MessageBoxImage> MessageBoxImagePair { get; set; } = new()
        {
            { "None", MessageBoxImage.None },
            { "Error", MessageBoxImage.Error },
            { "Hand", MessageBoxImage.Hand },
            { "Stop", MessageBoxImage.Stop },
            { "Question", MessageBoxImage.Question },
            { "Exclamation", MessageBoxImage.Exclamation },
            { "Warning", MessageBoxImage.Warning },
            { "Asterisk", MessageBoxImage.Asterisk },
            { "Information", MessageBoxImage.Information}
        };
        public MessageBoxImage MessageBoxImage { get; set; } = MessageBoxImage.None;
        public MessageBoxResult MessageBoxResult { get; set; } = MessageBoxResult.OK;
        public MessageBoxOptions MessageBoxOptions { get; set; } = MessageBoxOptions.None;
    }
}
