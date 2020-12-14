using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek.Models
{
    public class Library
    {
        public int LibraryId { get; set; }
        public int? InventoryId { get; set; }
        public List<Inventory> Inventories { get; set; }
        public int? RentalID { get; set; }
        public List<Rental> Rentals { get; set; }

    }
}
