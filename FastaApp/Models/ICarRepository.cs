using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastaApp.Models
{
    public interface ICarRepository
    {
        List<Car> Cars { get; }
        Car GetCarById(string id);
    }
}
