using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek.Models
{
    public class Inventory
    {
        public int IventoryId { get; set; }
        public int? BookId { get; set; }
        public List<Book> Books { get; set; }
        public Library Library { get; set; }

    }
}
