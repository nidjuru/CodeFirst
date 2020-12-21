using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        [MaxLength(40), MinLength(4)]

        public string AuthorFirstName { get; set; }
        [MaxLength(40), MinLength(4)]

        public string AuthorLastName { get; set; }
        public List<Book_Author> Book_Authors { get; set; }
    }
}
