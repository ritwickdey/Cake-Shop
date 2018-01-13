using CakeShop.Models;
using CakeShop.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CakeShop.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartSummary(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = await _shoppingCart.GetShoppingCartTotalAsync()
            });
        }

    }
}
