using FastaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastaApp.ViewModels
{
    public class DashboardViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
