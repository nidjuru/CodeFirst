using KopplingsTabell.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KopplingsTabell.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<ReleaseDate> ReleaseDates { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBook>()
                .HasKey(t => new { t.AuthorId, t.BookId });//FK TILLDELNING

            modelBuilder.Entity<AuthorBook>()
                .HasOne(pt => pt.Book)//relationen one
                .WithMany(p => p.AuthorBooks)//relationen many
                .HasForeignKey(pt => pt.BookId);//FK kopplingen som vi gjort på rad 25&26

            modelBuilder.Entity<AuthorBook>()
                .HasOne(pt => pt.Author)
                .WithMany(t => t.AuthorBooks)
                .HasForeignKey(pt => pt.AuthorId);
        }
    }
}
