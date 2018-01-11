using CakeShop.Models;
using CakeShop.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;


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
        public IActionResult List()
        {
            var cakesListViewModel = new CakesListViewModel
            {
                Cakes = _cakeRepository.Cakes,
                CurrentCategory = "Some Category"
            };
            return View(cakesListViewModel);
        }
    }
}
