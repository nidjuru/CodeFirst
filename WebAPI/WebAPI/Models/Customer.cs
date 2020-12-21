﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [MaxLength(40), MinLength(4)]

        public string CustomerFirstName { get; set; }
        [MaxLength(40), MinLength(4)]

        public string CustomerLastName { get; set; }
        [Required]
        public int LibraryCard { get; set; }
        public List<Rental> Rentals { get; set; }
    }
}
