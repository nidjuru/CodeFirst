using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KopplingsTabell.Models
{
    public class ReleaseDate//Dependant entity
    {
        public int ReleasteDateId { get; set; }
        public int RelaseDate { get; set; }
        public Book Book { get; set; }//navprop denna är one to many, dvs en bara här
    }
}
