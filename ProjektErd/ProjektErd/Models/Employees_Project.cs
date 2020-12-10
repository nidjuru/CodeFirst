using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektErd.Models
{
    public class Employees_Project
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
        public Employees Employees { get; set; }
        public Project Project { get; set; }
    }
}
