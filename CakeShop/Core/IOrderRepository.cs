using CakeShop.Core.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CakeShop.Core.Models
{
    public interface IOrderRepository
    {
        Task CreateOrderAsync(Order order);
        Task<IEnumerable<MyOrderViewModel>> GetAllOrdersAsync();
        Task<IEnumerable<MyOrderViewModel>> GetAllOrdersAsync(string userId);
    }
}