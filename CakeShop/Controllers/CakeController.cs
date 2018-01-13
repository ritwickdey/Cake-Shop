using CakeShop.Core.Models;
using CakeShop.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CakeShop.Controllers
{
    [Route("/cakes")]
    public class CakeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CakeController(ICakeRepository cakeRepository, ICategoryRepository categoryRepository)
        {
            _cakeRepository = cakeRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpGet("{category?}")]
        public async Task<IActionResult> List(string category)
        {
            var selectedCategory = !string.IsNullOrWhiteSpace(category) ? category : null;
            var cakesListViewModel = new CakesListViewModel
            {
                Cakes = await _cakeRepository.GetCakes(selectedCategory),
                CurrentCategory = selectedCategory ?? "All Cakes"
            };
            return View(cakesListViewModel);
        }

        [HttpGet("details/{id}")]
        public async Task<IActionResult> Details(int id)
        {

            var cake = await _cakeRepository.GetCakeById(id);

            return View(cake);
        }
    }
}
