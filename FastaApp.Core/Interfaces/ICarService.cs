using FastaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastaApp.Core.Interfaces
{
    public interface ICarService
    {
        public Task GetCarById(string id);
        public Task GetAllCars();
        public Task DeleteCar(string id);
        public Task AddNewCar(Car car);

    }
}
