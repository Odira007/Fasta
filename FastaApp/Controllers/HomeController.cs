using FastaApp.Helpers;
using FastaApp.Models;
using FastaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FastaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ICarRepository _carRepository;

        public HomeController(ILogger<HomeController> logger, ICarRepository carRepository)
        {
            _logger = logger;
            _carRepository = carRepository;
        }


        public async Task<IActionResult> Index()
        {
            await FileOperations.SeedCarData(AppFileDbContext.Cars);

            var carFleetViewModel = new CarFleetViewModel();

            //carFleetViewModel.Cars = _carRepository.Cars;
            carFleetViewModel.cars = FileOperations.ReadCarData<Car>();
            return View(carFleetViewModel);
        }

        public IActionResult Details(string id)
        {
            var car = _carRepository.GetCarById(id);

            if (car == null) return NotFound();

            return View(car);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
