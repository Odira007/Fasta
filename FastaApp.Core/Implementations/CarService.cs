using FastaApp.Entities;
using FastaApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastaApp.Core.Interfaces;
using Microsoft.Extensions.Logging;
using FastaApp.Persistence.Interfaces;
using FastaApp.DTOs;

namespace FastaApp.Core.Implementations
{
    public class CarService : ICarService
    {
        private readonly ILogger<CarService> _logger;
        private readonly ICarRepository _carRepository;

        public CarService(ILogger<CarService> logger, ICarRepository carRepository)
        {
            _logger = logger;
            _carRepository = carRepository;
        }
        public async Task AddNewCar(Car car)
        {
            int affectedRows = await _carRepository.AddCarAsync(car);
            string en = affectedRows <= 1 ? "row was" : "rows were";
            try
            {
                await _carRepository.AddCarAsync(car);
                _logger.LogInformation($"{affectedRows} {en} affected");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task DeleteCar(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CarRequestDto>> GetAllCars()
        {
            try
            {
                return await _carRepository.GetAllCarsAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task GetCarById(string id)
        {
            try
            {
                await _carRepository.GetSingleCarAsync(id);
                _logger.LogInformation($"All single order with id: {id} has been fetched");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
