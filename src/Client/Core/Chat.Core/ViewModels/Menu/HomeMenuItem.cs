namespace Chat.Core
{
    public enum MenuItemType
    {
        Chat,
        About
    }

    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}