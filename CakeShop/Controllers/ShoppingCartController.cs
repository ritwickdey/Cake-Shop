using CakeShop.Core.Models;
using CakeShop.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CakeShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly IShoppingCartService _shoppingCart;

        public ShoppingCartController(ICakeRepository cakeRepository, IShoppingCartService shoppingCart)
        {
            _cakeRepository = cakeRepository;
            _shoppingCart = shoppingCart;
        }

        public async Task<IActionResult> Index()
        {
            await _shoppingCart.GetShoppingCartItemsAsync();
            var shoppingCartCountTotal = await _shoppingCart.GetCartCountAndTotalAmmountAsync();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartItemsTotal = shoppingCartCountTotal.ItemCount,
                ShoppingCartTotal = shoppingCartCountTotal.TotalAmmount,
            };


            return View(shoppingCartViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddToShoppingCart(int cakeId)
        {
            var selectedCake = await _cakeRepository.GetCakeById(cakeId);
            if (selectedCake == null)
            {
                return NotFound();
            }

            await _shoppingCart.AddToCartAsync(selectedCake);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromShoppingCart(int cakeId)
        {
            var selectedCake = await _cakeRepository.GetCakeById(cakeId);
            if (selectedCake == null)
            {
                return NotFound();
            }

            await _shoppingCart.RemoveFromCartAsync(selectedCake);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveAllCart()
        {
            await _shoppingCart.ClearCartAsync();
            return RedirectToAction("Index");
        }
    }
}