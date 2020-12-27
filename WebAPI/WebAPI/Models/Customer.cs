using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required]
        //[Column(TypeName = "VARCHAR")]
        [MaxLength(40), MinLength(4)]
        public string CustomerFirstName { get; set; }
        [Required]
        //[Column(TypeName = "VARCHAR")]
        [MaxLength(40), MinLength(4)]

        public string CustomerLastName { get; set; }
        [Required]
        [Range(0,100000000)]
        public long LibraryCard { get; set; }
        public List<Rental> Rentals { get; set; }
    }
}
