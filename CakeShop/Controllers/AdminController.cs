using AutoMapper;
using CakeShop.Core;
using CakeShop.Core.Dto;
using CakeShop.Core.Models;
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

        public AdminController(
            IOrderRepository orderRepository,
            ICakeRepository cakeRepository,
            IMapper mapper,
            IUnitOfWork unitOfWork)
        {
            _orderRepository = orderRepository;
            _cakeRepository = cakeRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
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

        [HttpGet("edit/{id}")]
        public async Task<IActionResult> EditCake(int id)
        {
            var cake = await _cakeRepository.GetCakeById(id);
            var cakeDto = _mapper.Map<Cake, CakeDto>(cake);
            return View(cakeDto);
        }

        [HttpPost("edit/{id}")]
        public async Task<IActionResult> EditCake(int id, [FromForm]CakeDto cakeDto)
        {
            if (!ModelState.IsValid)
            {
                return View(cakeDto);
            }
            var cake = _mapper.Map<CakeDto, Cake>(cakeDto);
            _cakeRepository.UpdateCake(cake);
            await _unitOfWork.CompleteAsync();


            return RedirectToAction("ManageCakes");
        }


    }
}