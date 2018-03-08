using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BlogReader.ViewModels
{
    public class ReaderViewModel : BaseViewModel
    {
        public ObservableCollection<BlogPost> BlogPosts { get; private set; }
        public ICommand RefreshCmd { get; set; }

        public ReaderViewModel()
        {
            var blogClient = (App.Current as App).BlogClient;
            RefreshCmd = new Command(async () =>
            {
                BlogPosts = await blogClient.ApiBlogGetAsync();
            });
        }
    }
}
