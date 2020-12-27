using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        [MaxLength(40), MinLength(4)]
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        [Required]
        public long ISBN { get; set; }

        public Rating Rating { get; set; }
        [Required]
        public int? RatingId { get; set; }
        public List<Book_Author> Book_Authors { get; set; }
        public Inventory Inventory { get; set; }

    }
}
