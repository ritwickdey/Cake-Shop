using CakeShop.Models;
using CakeShop.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CakeShop.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CakeController(ICakeRepository cakeRepository, ICategoryRepository categoryRepository)
        {
            _cakeRepository = cakeRepository;
            _categoryRepository = categoryRepository;
        }


        [HttpGet]
        public async Task<IActionResult> List()
        {
            var cakesListViewModel = new CakesListViewModel
            {
                Cakes = await _cakeRepository.GetCakes(),
                CurrentCategory = "Some Category"
            };
            return View(cakesListViewModel);
        }
    }
}
