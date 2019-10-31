using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Chat
{
    public class AboutViewModel : TitledViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}