﻿using Microsoft.EntityFrameworkCore;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
        }
        public DbSet<WebAPI.Models.Rating> Rating { get; set; }
    }
}
