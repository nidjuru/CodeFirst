using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KopplingsTabell.Models
{
    public class AuthorBook//Kopplingstabell(Vad är detta för entity?)
    {
        public int AuthorId { get; set; }
        public Author Author { get; set; }//Här är det inte lists som ska in i kopplingstabellen, utan vi deklarerar bara klasserna, för varje FK.

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
