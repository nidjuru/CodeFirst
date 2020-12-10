using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAlong.Models
{
    public class Course
    {
        public int CourseId { get; set; }//Primary key, EF fattar detta pga ID:et som finns i namnet.
        public string Name { get; set; }//Godtyckliga kolumner för vår tabell
        public string Level { get; set; }//Godtyckliga kolumner för vår tabell
        public int? TeacherId { get; set; }//Forgein Key, "?" gör att detta fält inte krävs.
        public Teacher Teacher { get; set; }//Fråga fredrik varför vi la in Teacher här igen.
        public ICollection<Student_Course> Student_Courses { get; set; }

    }
}
