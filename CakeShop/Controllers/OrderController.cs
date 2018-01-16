using AutoMapper;
using CakeShop.Core.Dto;
using CakeShop.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CakeShop.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public OrderController(
            IShoppingCartService shoppingCartService,
            IMapper mapper,
            IOrderRepository orderRepository)
        {
            _shoppingCartService = shoppingCartService;
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public async Task<IActionResult> Checkout()
        {
            var cartItems = await _shoppingCartService.GetShoppingCartItemsAsync();
            if (cartItems?.Count() <= 0)
            {
                return Redirect("/shoppingcart");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Checkout([FromForm]OrderDto orderDto)
        {
            if (!ModelState.IsValid)
            {
                return View(orderDto);
            }

            var cartItems = await _shoppingCartService.GetShoppingCartItemsAsync();

            if (cartItems?.Count() <= 0)
            {
                ModelState.AddModelError("", "Your Cart is empty. Please add some cakes before checkout");
                return View(orderDto);
            }

            var order = _mapper.Map<OrderDto, Order>(orderDto);
            order.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _orderRepository.CreateOrderAsync(order);

            await _shoppingCartService.ClearCartAsync();


            return View("CheckoutComplete");
        }


        public async Task<IActionResult> MyOrder()
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var orders = await _orderRepository.GetAllOrdersAsync(userId);
            return View(orders);
        }
    }
}