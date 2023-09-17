using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastaApp.Models
{
    public class Car
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Mileage { get; set; }
        public Transmission Transmission { get; set; }
        public Condition Condition { get; set; }
        public string RentalLocation { get; set; }
        public Gps Gps { get; set; }
        public decimal PricePerDay { get; set; }
        public string BodyStyle { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbNailImageUrl { get; set; }
        public string Features { get; set; }
        public string Description { get; set; }
        public string RealImage { get; set; }
        public string EngineType { get; set; }
        public string HorsepowerHP { get; set; }
        public string HorsePowerKW { get; set; }
        public string AvailableFrom { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    }
}
