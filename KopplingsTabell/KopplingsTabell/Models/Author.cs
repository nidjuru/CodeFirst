using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KopplingsTabell.Models
{
    public class Author//Principal entity
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int MyProperty { get; set; }
        public List<AuthorBook> AuthorBooks { get; set; }//navpropp, many to many mellan author och book.
    }
}
