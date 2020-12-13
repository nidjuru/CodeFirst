using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KopplingsTabell.Models
{
    public class Book//Principal entity
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public long ISBN { get; set; }
        public List<ReleaseDate> ReleaseDates { get; set; }// navpropp, many ifrån Releasedates, och den andra är many to one, dvs en bok perdatum medans datum är tvärtom.
        public List<AuthorBook> AuthorBooks { get; set; }//navpropp, many to many mellan author och book.

    }
}
