using System.ComponentModel;

namespace BlogReader.ViewModels
{
    // PropertyChnaged.Fody will take care of the rest
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
