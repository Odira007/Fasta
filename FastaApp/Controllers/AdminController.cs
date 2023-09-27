using FastaApp.Core.Interfaces;
using FastaApp.Entities;
using FastaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastaApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly ICarService _carService;
        private readonly IOrderService _orderService;

        public AdminController(ILogger<AdminController> logger, ICarService carService, 
            IOrderService orderService)
        {
            _logger = logger;
            _carService = carService;
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> Cars()
        {
            IEnumerable<Car> Cars = await _carService.GetAllCars()
            return View();
        }
    }
}
