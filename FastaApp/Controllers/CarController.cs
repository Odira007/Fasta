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
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public ViewResult Fleet()
        {
            //await FileOperations.SeedCarData(AppFileDbContext.Cars);

            var carFleetViewModel = new CarFleetViewModel();

            carFleetViewModel.Cars = _carRepository.Cars;
            //carFleetViewModel.cars = FileOperations.ReadCarData<Car>();

            return View(carFleetViewModel);
        }
    }
}
