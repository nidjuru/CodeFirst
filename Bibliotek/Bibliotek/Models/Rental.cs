using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek.Models
{
    public class Rental
    {
        public int RentalId { get; set; }
        public int RentalDate { get; set; }
        public int? ReturnDate { get; set; }
        public bool? Rented { get; set; }
        public int? CustomerId { get; set; }
        public List<Customer> Customers { get; set; }
        public int? LibraryId { get; set; }
        public Library Library { get; set; }
        

    }
}
