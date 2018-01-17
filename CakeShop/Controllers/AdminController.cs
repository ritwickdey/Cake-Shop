using CakeShop.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CakeShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public AdminController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AllOrders()
        {
            ViewBag.ActionTitle = "All Orders";
            var orders = await _orderRepository.GetAllOrdersAsync();
            return View(orders);
        }
    }
}