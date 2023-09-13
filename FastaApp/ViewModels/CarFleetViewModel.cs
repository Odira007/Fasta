using FastaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastaApp.ViewModels
{
    public class CarFleetViewModel
    {
        public IEnumerable<Car> Cars { get; set; }

        public List<Car> cars { get; set; }
    }
}
