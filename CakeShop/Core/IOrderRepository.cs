using System.Threading.Tasks;

namespace CakeShop.Core.Models
{
    public interface IOrderRepository
    {
        Task CreateOrderAsync(Order order);
    }
}