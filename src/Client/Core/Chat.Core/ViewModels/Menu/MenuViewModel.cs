using System.Collections.Generic;

namespace Chat.Core
{
    public class MenuViewModel : BaseViewModel
    {
        private readonly IMainViewModel _mainViewModel;

        public List<HomeMenuItem> MenuItems { get; } = new List<HomeMenuItem>()
        {
            new HomeMenuItem {Id = MenuItemType.Chat, Title = "Chat"},
            new HomeMenuItem {Id = MenuItemType.About, Title = "About"}
        };

        public HomeMenuItem SelectedItem { get; set; }

        public MenuViewModel(IMainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            SelectedItem = MenuItems[0];

            PropertyChanged += MenuViewModel_PropertyChanged;
        }

        private async void MenuViewModel_PropertyChanged(object sender,
            System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(SelectedItem))
            {
                if (SelectedItem != null)
                {
                    var id = (int) SelectedItem.Id;
                    await _mainViewModel.NavigateFromMenu(id);
                }
            }
        }
    }
}