using CakeShop.Core.Models;
using CakeShop.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CakeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;

        public HomeController(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(new HomeViewModel
            {
                CakeOfTheWeek = await _cakeRepository.GetCakesOfTheWeek()
            });
        }
    }
}