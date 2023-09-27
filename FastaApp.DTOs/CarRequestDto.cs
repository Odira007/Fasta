using FastaApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastaApp.DTOs
{
    public class CarRequestDto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Transmission Transmission { get; set; }
        public Condition Condition { get; set; }
        public decimal PricePerDay { get; set; }
        public string Year { get; set; }
        public string ImageUrl { get; set; }
        public string Features { get; set; }
        public string Description { get; set; }
        public string RealImage { get; set; }
    }
}
