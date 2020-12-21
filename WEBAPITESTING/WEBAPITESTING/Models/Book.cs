using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPITESTING.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        public int ReleaseYear { get; set; }
        [Required]

        public long ISBN { get; set; }
        public Inventory Inventory { get; set; }

    }
}
