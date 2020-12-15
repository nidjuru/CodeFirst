using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VänstraSidan.Models
{
    public class Inventory//skapa en many to many
    {
        public int InventoryId { get; set; }
        public int? BookId { get; set; }
        public List<Book> Books { get; set; }
        public int? RentalId { get; set; }
        public List<Rental> Rentals { get; set; }
    }
}
