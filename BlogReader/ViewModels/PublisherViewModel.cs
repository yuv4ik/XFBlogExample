using System.Windows.Input;
using Xamarin.Forms;

namespace BlogReader.ViewModels
{
    public class PublisherViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICommand PublishCmd { get; }

        public PublisherViewModel()
        {
            var blogClient = (App.Current as App).BlogClient;
            PublishCmd = new Command(async () => await blogClient.ApiBlogPostAsync(new BlogPost{ Title = Title, Description = Description}));
        }
    }
}
