using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public int? CourseId { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
