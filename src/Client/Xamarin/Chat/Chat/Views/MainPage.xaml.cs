﻿using Chat.Core;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chat
{
    public partial class MainPage : IMainViewModel
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();

        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int) MenuItemType.Chat, (NavigationPage) Detail);

            Master = new MenuPage(this);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int) MenuItemType.Chat:
                        MenuPages.Add(id, new NavigationPage(new ChatPage()));
                        break;
                    case (int) MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}