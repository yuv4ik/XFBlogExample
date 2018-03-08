using System;
using Xamarin.Forms;

namespace BlogReader
{
    public partial class App : Application
    {
        public BlogService BlogClient { get; }

        public App()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.iOS)
                BlogClient = new BlogService("http://localhost:5000/");
            else if (Device.RuntimePlatform == Device.Android)
                BlogClient = new BlogService("http://10.0.2.2:5000/");
            else
                throw new NotSupportedException($"{Device.RuntimePlatform} is not supported.");

            MainPage = new DashboardPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
