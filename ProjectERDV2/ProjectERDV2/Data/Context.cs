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
        public Context(DbContextOptions<Context> options) : base(options) { }//Vad exakt gör detta??
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeesProject> EmployeesProjects { get; set; }//Behövs denna?? FRÅGA
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeesProject>()
                .HasKey(sc => new { sc.EmployeeId, sc.ProjectId });

            modelBuilder.Entity<EmployeesProject>()
                .HasOne(sc => sc.Employee)
                .WithMany(s => s.EmployeesProjects)
                .HasForeignKey(sc => sc.EmployeeId);

            modelBuilder.Entity<EmployeesProject>()
                .HasOne(sc => sc.Project)
                .WithMany(c => c.EmployeesProjects)
                .HasForeignKey(sc => sc.ProjectId);
        }



        }
}
