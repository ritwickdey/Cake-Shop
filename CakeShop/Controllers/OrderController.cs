using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Checkout()
        {
            return View();
        }
    }
}