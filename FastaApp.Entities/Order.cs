using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastaApp.Entities
{
    public class Order
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CarId { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public DateTime PickUpDate { get; set; } = DateTime.Now;
        public DateTime ReturnDate { get; set; } = DateTime.Now;
        public string PickUpLocation { get; set; }
        public string ReturnLocation { get; set; }
        public decimal Cost { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
