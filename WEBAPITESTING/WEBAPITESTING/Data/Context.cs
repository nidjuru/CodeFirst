using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPITESTING.Models;

namespace WEBAPITESTING.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rental>()
                .HasKey(sc => new { sc.CustomerId, sc.InventoryId });

            modelBuilder.Entity<Rental>()
                .HasOne(sc => sc.Customer)
                .WithMany(s => s.Rentals)
                .HasForeignKey(sc => sc.CustomerId);

            modelBuilder.Entity<Rental>()
                .HasOne(sc => sc.Inventory)
                .WithMany(c => c.Rentals)
                .HasForeignKey(sc => sc.InventoryId);
        }
    }
}
