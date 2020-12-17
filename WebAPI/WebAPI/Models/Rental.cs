using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Rental
    {
        public int RentalId { get; set; }
        public Inventory Inventory { get; set; }
        public int? InventoryId { get; set; }
        public DateTime? RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool Rented { get; set; } = false;
        public Customer Customer { get; set; }
        public int? CustomerId { get; set; }
    }
}
