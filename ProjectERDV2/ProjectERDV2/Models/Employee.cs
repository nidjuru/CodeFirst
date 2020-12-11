using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectERDV2.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? PaymentId { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }//skapa alltid upp klasserna i tabellen som har foreign key,
        public Payment Payment { get; set; }//Fråga om dessa imorn, varför behövs de?   
        public ICollection<EmployeesProject> EmployeesProjects { get; set; }

    }
}
