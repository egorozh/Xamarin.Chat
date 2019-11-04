using Chat.Core;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatMessageListView : ContentView
    {
        public ChatMessageListView()
        {
            BindingContext = new ChatMessageListViewModel();
            InitializeComponent();
        }
    }
}