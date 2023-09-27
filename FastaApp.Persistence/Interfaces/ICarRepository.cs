using FastaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastaApp.Persistence.Interfaces
{
    public interface ICarRepository
    {
        public Task<int> AddCarAsync(Car car);
        public Task<Car> GetSingleCarAsync(string carId);
        public Task<List<Car>> GetAllCarsAsync();
        public Task<int> DeleteCarAsync(string carId);
    }
}
