using System.Threading.Tasks;

namespace CakeShop.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
