using CakeShop.Core.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Persistence
{
    public class OrderRepository : IOrderRepository
    {
        private readonly CakeShopDbContext _context;
        private readonly IShoppingCartService _shoppingCartService;

        public OrderRepository(
            CakeShopDbContext context,
            IShoppingCartService shoppingCartService)
        {
            _context = context;
            _shoppingCartService = shoppingCartService;
        }

        public async Task CreateOrderAsync(Order order)
        {
            order.OrderPlacedTime = DateTime.Now;
            await _context.Orders.AddAsync(order);

            var shoppingCartItems = await _shoppingCartService.GetShoppingCartItemsAsync();
            order.OrderTotal = (await _shoppingCartService.GetCartCountAndTotalAmmountAsync()).TotalAmmount;

            await _context.OrderDetails.AddRangeAsync(shoppingCartItems.Select(e => new OrderDetail
            {
                Qty = e.Qty,
                CakeId = e.CakeId,
                OrderId = order.Id,
                Price = e.Cake.Price
            }));

            await _context.SaveChangesAsync();
        }
    }
}
