using System.Threading.Tasks;

namespace Chat.Core
{
    public interface IMainViewModel
    {
        Task NavigateFromMenu(int id);
    }
}