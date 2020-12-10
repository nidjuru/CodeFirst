using Microsoft.EntityFrameworkCore;
using ProjektErd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektErd.Data
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employees_Project> Employees_Projects { get; set; }
    }
}
