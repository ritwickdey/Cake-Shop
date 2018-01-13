using CakeShop.Core.Models;

namespace CakeShop.Core.ViewModel
{
    public class ShoppingCartViewModel
    {
        public IShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
        public int ShoppingCartItemsTotal { get; set; }
    }
}
