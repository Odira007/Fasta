using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastaApp.DTOs
{
    public class OrderResposeDto
    {
        public string Id { get; set; }
        public string CarId { get; set; }
        public string UserId { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string PickUpLocation { get; set; }
        public string ReturnLocation { get; set; }
        public decimal Cost { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
