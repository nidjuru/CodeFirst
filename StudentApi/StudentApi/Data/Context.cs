using Microsoft.EntityFrameworkCore;
using StudentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
