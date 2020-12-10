using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektErd.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectName { get; set; }
        public int ProjectBudget { get; set; }
        public int ProjectCode { get; set; }

    }
}
