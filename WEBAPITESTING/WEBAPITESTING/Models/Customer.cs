using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPITESTING.Models
{
    public class Customer
    {
        //Lägg inte på någon data annotation än, testa att göra det efter migreringen.
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(20),MinLength(4)]
        public string CustomerFirstName { get; set; }
        [Required]
        [MaxLength(20), MinLength(4)]
        public string CustomerLastName { get; set; }
        [Required]
        public int LibraryCard { get; set; }
        public List<Rental> Rentals { get; set; }
    }
}
