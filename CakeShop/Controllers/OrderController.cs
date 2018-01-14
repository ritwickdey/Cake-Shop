using CakeShop.Core.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout([FromForm]OrderDto orderDto)
        {
            if (!ModelState.IsValid)
            {
                return View(orderDto);
            }
            return RedirectToPage("/");
        }
    }
}