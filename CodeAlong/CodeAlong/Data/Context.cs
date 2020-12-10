using CodeAlong.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAlong.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Course>()
                .HasKey(sc => new { sc.Id, sc.CourseId });

            modelBuilder.Entity<Student_Course>()
                            .HasOne(sc => sc.Student)
                            .WithMany(s => s.Student_Courses)
                            .HasForeignKey(sc => sc.Id);
            modelBuilder.Entity<Student_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(s => s.Student_Courses)
                .HasForeignKey(sc => sc.CourseId);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
