using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectERDV2.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManage { get; set; }
        public int ProjectBudget { get; set; }
        public ICollection<EmployeesProject> EmployeesProjects { get; set; }
    }
}
