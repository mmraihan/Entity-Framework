using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Model.Models;
using Test_Model.Models.FluentApiRelationship;

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


        //-----------------Fluent -------------------------//

        public DbSet<Fluent_BookDetail> Fluent_BookDetails { get; set; }
        public DbSet<Fluent_Book> Fluent_Book { get; set; }
        public DbSet<Fluent_BookInAuthor> fluent_BookInAuthors { get; set; }
        public DbSet<Fluent_Publisher> fluent_Publishers { get; set; }
        public DbSet<Fluent_Author> Fluent_Authors { get; set; }

      
       




        #region Fluent API

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Creating composite key using Fluent API
            modelBuilder.Entity<BookInAuthor>().HasKey(ba => new { ba.Author_Id, ba.Book_Id });

            //Fluent_BookDetails Model
            modelBuilder.Entity<Fluent_BookDetail>().HasKey(b => b.BookDetail_Id); //Set PK 
            modelBuilder.Entity<Fluent_BookDetail>().Property(c => c.NumberOfchapters).IsRequired(); //Set Required


            //Fluent Book

            modelBuilder.Entity<Fluent_Book>().HasKey(b=>b.Book_Id);
            modelBuilder.Entity<Fluent_Book>().Property(b => b.Title).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Fluent_Book>().Property(b => b.ISBN).IsRequired();
            modelBuilder.Entity<Fluent_Book>().Property(b => b.Price).IsRequired();


            //Fluent Author
            modelBuilder.Entity<Fluent_Author>().HasKey(b => b.Author_Id);
            modelBuilder.Entity<Fluent_Author>().Property(b => b.FirstName).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Fluent_Author>().Property(b => b.LastName).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Fluent_Author>().Property(b => b.BirthDate).IsRequired();
            modelBuilder.Entity<Fluent_Author>().Ignore(b => b.FullName); //Not Mapped

            //Fluent Publisher
            modelBuilder.Entity<Fluent_Publisher>().HasKey(p => p.Publisher_Id);
            modelBuilder.Entity<Fluent_Publisher>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Fluent_Publisher>().Property(p => p.Location).IsRequired();

            //Creating Composite Key Using Fluent API

            modelBuilder.Entity<Fluent_BookInAuthor>().HasKey(ba => new { ba.Author_Id, ba.Book_Id });


            //Rename Category table and Column Name
            modelBuilder.Entity<Fluent_Category>().HasKey(b => b.Category_Id);
            modelBuilder.Entity<Fluent_Category>().ToTable("tblUpdate_category");
            modelBuilder.Entity<Fluent_Category>().Property(a => a.Name).HasColumnName("Category_Name");




        }


        #endregion


    }
}
