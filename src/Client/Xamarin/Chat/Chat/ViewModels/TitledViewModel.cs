using Chat.Core;
using Xamarin.Forms;

namespace Chat
{
    public class TitledViewModel : BaseViewModel
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        public bool IsBusy { get; set; }

        public string Title { get; set; }
    }
}