using AutoMapper;
using CakeShop.Core;
using CakeShop.Core.Dto;
using CakeShop.Core.Models;
using CakeShop.Core.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CakeShop.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("/admin/manageCakes")]
    public class AdminController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICakeRepository _cakeRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryRepository _categoryRepository;

        public AdminController(
            IOrderRepository orderRepository,
            ICakeRepository cakeRepository,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            ICategoryRepository categoryRepository)
        {
            _orderRepository = orderRepository;
            _cakeRepository = cakeRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }

        [HttpGet("allOrders")]
        public async Task<IActionResult> AllOrders()
        {
            ViewBag.ActionTitle = "All Orders";
            var orders = await _orderRepository.GetAllOrdersAsync();
            return View(orders);
        }

        [HttpGet("")]
        public async Task<IActionResult> ManageCakes()
        {
            var cakes = await _cakeRepository.GetAllCakesNameId();
            return View(cakes);
        }

        [HttpGet("add")]
        public async Task<IActionResult> AddCake()
        {
            var category = await _categoryRepository.GetCategories();
            return View(new CakeCreateUpdateViewModel
            {
                Categories = category
            });
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddCake(CakeDto cakeDto)
        {
            if (!ModelState.IsValid)
            {
                var category = await _categoryRepository.GetCategories();
                return View(new CakeCreateUpdateViewModel
                {
                    CakeDto = cakeDto,
                    Categories = category
                });
            }
            var cake = _mapper.Map<CakeDto, Cake>(cakeDto);
            await _cakeRepository.AddCakeAsync(cake);
            await _unitOfWork.CompleteAsync();
            return RedirectToAction("ManageCakes");
        }

        [HttpGet("edit/{id}")]
        public async Task<IActionResult> EditCake(int id)
        {
            var cake = await _cakeRepository.GetCakeById(id);
            var cakeDto = _mapper.Map<Cake, CakeDto>(cake);
            var category = await _categoryRepository.GetCategories();

            return View(new CakeCreateUpdateViewModel
            {
                Categories = category,
                CakeDto = cakeDto
            });
        }

        [HttpPost("edit/{id}")]
        public async Task<IActionResult> EditCake(int id, [FromForm]CakeDto cakeDto)
        {
            if (!ModelState.IsValid)
            {
                var category = await _categoryRepository.GetCategories();
                return View(new CakeCreateUpdateViewModel
                {
                    Categories = category,
                    CakeDto = cakeDto
                });
            }
            var cake = _mapper.Map<CakeDto, Cake>(cakeDto);
            cake.Id = id;
            _cakeRepository.UpdateCake(cake);
            await _unitOfWork.CompleteAsync();

            return RedirectToAction("ManageCakes");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCake(int id)
        {
            _cakeRepository.Delete(id);
            await _unitOfWork.CompleteAsync();
            return Ok();
        }


    }
}