using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectERDV2.Models
{
    public class EmployeesProject
    {
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
