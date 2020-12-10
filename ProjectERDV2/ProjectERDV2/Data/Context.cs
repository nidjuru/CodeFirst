using Microsoft.EntityFrameworkCore;
using ProjectERDV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectERDV2.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payment> Payments { get; set; }

    }
}
