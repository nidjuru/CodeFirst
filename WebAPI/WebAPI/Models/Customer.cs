using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        [Range(0, 100000000)]
        public long TelephoneNumber { get; set; }
        [MaxLength(40), MinLength(4)]
        [Required]
        public string CustomerFirstName { get; set; }
        [MaxLength(40), MinLength(4)]
        [Required]

        public string CustomerLastName { get; set; }
        [Required]
        [Range(0,100000000)]
        public long LibraryCard { get; set; }
        public List<Rental> Rentals { get; set; }
    }
}
