using ProjectX.Xamarin.Services;
using ProjectX.Xamarin.Views;
using Xamarin.Forms;

namespace ProjectX.Xamarin
{
    public partial class App
    {
        public static string EgorozhBackendUrl = "https://egorozh.ru/chat";

        public App()
        {
            InitializeComponent();

            DependencyService.Register<EgorozhChatDataStore>();

            MainPage = new ItemsPage();
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