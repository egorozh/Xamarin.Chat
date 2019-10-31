namespace Chat
{
    public class ItemDetailViewModel : TitledViewModel
    {
        public Item Item { get; set; }

        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
