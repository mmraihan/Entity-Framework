using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Model.Models;

namespace Test_DataAccess.Data
{
   public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genries { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }

        public DbSet <BookInAuthor> BookInAuthor { get; set; }




        #region Fluent API

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Creating composite key using Fluent API
            modelBuilder.Entity<BookInAuthor>().HasKey(ba => new { ba.Author_Id, ba.Book_Id });

            //Fluent_BookDetails Model

            modelBuilder.Entity<Fluent_BookDetail>().HasKey(b => b.BookDetail_Id); //Set PK 
            modelBuilder.Entity<Fluent_BookDetail>().Property(c => c.NumberOfchapters).IsRequired(); //Set Required
        }


        #endregion


    }
}
