using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastaApp.Models
{
    public class CarRepository : ICarRepository
    {
        //private AppDbContext _appDbContext;
        //public CarRepository(AppDbContext appDbContext)
        //{
        //    _appDbContext = appDbContext;
        //}
        public List<Car> Cars => AppFileDbContext.Cars;
        public Car GetCarById(string id) => AppFileDbContext.Cars.FirstOrDefault(x => x.Id == id);
    }
}
