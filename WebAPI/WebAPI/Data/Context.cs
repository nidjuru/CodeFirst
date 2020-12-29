using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book_Author> Book_Authors { get; set; }
        public DbSet<Rating> Rating { get; set; }

        //Skapa upp seed data, på grund av alla gånger jag varit tvungen att deleta databasen för ny funktion
        //nalitet

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //Many to many mellan books och authors till Book_Author
                modelBuilder.Entity<Book_Author>()
                    .HasKey(sc => new { sc.AuthorId, sc.BookId });

                modelBuilder.Entity<Book_Author>()
                    .HasOne(sc => sc.Author)
                    .WithMany(s => s.Book_Authors)
                    .HasForeignKey(sc => sc.AuthorId);

                modelBuilder.Entity<Book_Author>()
                    .HasOne(sc => sc.Book)
                    .WithMany(c => c.Book_Authors)
                    .HasForeignKey(sc => sc.BookId);
                
                //Many to many mellan Customer och Inventory till Rentals.
                modelBuilder.Entity<Rental>()
                .HasKey(sc => new { sc.InventoryId, sc.CustomerId });

                modelBuilder.Entity<Rental>()
                    .HasOne(sc => sc.Inventory)
                    .WithMany(s => s.Rentals)
                    .HasForeignKey(sc => sc.InventoryId);

                modelBuilder.Entity<Rental>()
                    .HasOne(sc => sc.Customer)
                    .WithMany(c => c.Rentals)
                    .HasForeignKey(sc => sc.CustomerId);

               
                modelBuilder.Entity<Rental>()
                        .Property(l => l.RentalDate)
                        .HasDefaultValueSql("GETDATE()");

            //Testar med fluent api att tvinga fram FK, för allt annat fungerar inte. MISERIA
            //modelBuilder.Entity<Inventory>()
            //        .HasKey(sc => new { sc.BookId, sc.RentalId });

            //modelBuilder.Entity<Inventory>()
            //        .HasMany(c => c.Books)
            //        .WithOne(e => e.Inventory)
            //        .HasForeignKey(sc => sc.BookId);
            //        .IsRequired();

            //modelBuilder.Entity<Inventory>()
            //        .HasMany(c => c.Rentals)
            //        .WithOne(e => e.Inventory)
            //        .HasForeignKey(sc => sc.RentalId)
            //        .IsRequired();

        }
    }
}
