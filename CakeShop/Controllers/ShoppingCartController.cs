using CakeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartController(ICakeRepository cakeRepository, IShoppingCart shoppingCart)
        {
            _cakeRepository = cakeRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}