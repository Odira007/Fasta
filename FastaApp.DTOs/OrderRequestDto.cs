using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastaApp.DTOs
{
    public class OrderRequestDto
    {
        public string Id { get; set; }
        public string CarId { get; set; }
        public string UserId { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
