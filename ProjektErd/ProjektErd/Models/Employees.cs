using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektErd.Models
{
    public class Employees
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? PaymentId { get; set; }
        public int? ProjectId { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
        public Payment Payment { get; set; }
        public Project Project { get; set; }


    }
}
