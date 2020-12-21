using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        [Required]
        [Range(0, 5,ErrorMessage = "Ange ett tal mellan 0-5")]
        public int Ratings { get; set; }
        public List<Book> Books { get; set; }
    }
}
