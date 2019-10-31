using Chat.Core;

namespace Chat
{
    public partial class MenuPage
    {
        public MenuPage(IMainViewModel mainViewModel)
        {
            InitializeComponent();

            BindingContext = new MenuViewModel(mainViewModel);
        }
    }
}