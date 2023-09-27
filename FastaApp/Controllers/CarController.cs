using FastaApp.Core.Interfaces;
using FastaApp.Helpers;
using FastaApp.Models;
using FastaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastaApp.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        public ViewResult Fleet()
        {
            //await FileOperations.SeedCarData(AppFileDbContext.Cars);

            var carFleetViewModel = new CarFleetViewModel();

            carFleetViewModel.cars = _carService.Cars;
            //carFleetViewModel.cars = FileOperations.ReadCarData<Car>();

            return View(carFleetViewModel);
        }
    }
}
