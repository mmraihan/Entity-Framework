﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_DataAccess.Data;

namespace Test_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Test_Model.Models.Author", b =>
                {
                    b.Property<int>("Author_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Test_Model.Models.Book", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookDetail_Id")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Publisher_Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Book_Id");

                    b.HasIndex("BookDetail_Id")
                        .IsUnique();

                    b.HasIndex("Publisher_Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Test_Model.Models.BookDetail", b =>
                {
                    b.Property<int>("BookDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfchapters")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("BookDetail_Id");

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("Test_Model.Models.BookInAuthor", b =>
                {
                    b.Property<int>("Author_Id")
                        .HasColumnType("int");

                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Author_Id1")
                        .HasColumnType("int");

                    b.Property<int?>("Book_Id1")
                        .HasColumnType("int");

                    b.HasKey("Author_Id", "Book_Id");

                    b.HasIndex("Author_Id1");

                    b.HasIndex("Book_Id1");

                    b.ToTable("BookInAuthor");
                });

            modelBuilder.Entity("Test_Model.Models.Category", b =>
                {
                    b.Property<int>("Category_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Categories_Name");

                    b.HasKey("Category_Id");

                    b.ToTable("tbl_category");
                });

            modelBuilder.Entity("Test_Model.Models.FluentApiRelationship.Fluent_Book", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("PriceRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Book_Id");

                    b.ToTable("Fluent_Book");
                });

            modelBuilder.Entity("Test_Model.Models.FluentApiRelationship.Fluent_BookDetail", b =>
                {
                    b.Property<int>("BookDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfchapters")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("BookDetail_Id");

                    b.ToTable("Fluent_BookDetails");
                });

            modelBuilder.Entity("Test_Model.Models.FluentApiRelationship.Fluent_BookInAuthor", b =>
                {
                    b.Property<int>("Author_Id")
                        .HasColumnType("int");

                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Author_Id1")
                        .HasColumnType("int");

                    b.Property<int?>("Book_Id1")
                        .HasColumnType("int");

                    b.HasKey("Author_Id", "Book_Id");

                    b.HasIndex("Author_Id1");

                    b.HasIndex("Book_Id1");

                    b.ToTable("fluent_BookInAuthors");
                });

            modelBuilder.Entity("Test_Model.Models.FluentApiRelationship.Fluent_Category", b =>
                {
                    b.Property<int>("Category_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Category_Name");

                    b.HasKey("Category_Id");

                    b.ToTable("tblUpdate_category");
                });

            modelBuilder.Entity("Test_Model.Models.FluentApiRelationship.Fluent_Publisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_Id");

                    b.ToTable("fluent_Publishers");
                });

            modelBuilder.Entity("Test_Model.Models.Fluent_Author", b =>
                {
                    b.Property<int>("Author_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_Id");

                    b.ToTable("Fluent_Authors");
                });

            modelBuilder.Entity("Test_Model.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genries");
                });

            modelBuilder.Entity("Test_Model.Models.Publisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Test_Model.Models.Book", b =>
                {
                    b.HasOne("Test_Model.Models.BookDetail", "BookDetail")
                        .WithOne("Book")
                        .HasForeignKey("Test_Model.Models.Book", "BookDetail_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test_Model.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("Publisher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookDetail");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Test_Model.Models.BookInAuthor", b =>
                {
                    b.HasOne("Test_Model.Models.Author", "Author")
                        .WithMany("BookInAuthors")
                        .HasForeignKey("Author_Id1");

                    b.HasOne("Test_Model.Models.Book", "Book")
                        .WithMany("BookInAuthors")
                        .HasForeignKey("Book_Id1");

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Test_Model.Models.FluentApiRelationship.Fluent_BookInAuthor", b =>
                {
                    b.HasOne("Test_Model.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("Author_Id1");

                    b.HasOne("Test_Model.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("Book_Id1");

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Test_Model.Models.Author", b =>
                {
                    b.Navigation("BookInAuthors");
                });

            modelBuilder.Entity("Test_Model.Models.Book", b =>
                {
                    b.Navigation("BookInAuthors");
                });

            modelBuilder.Entity("Test_Model.Models.BookDetail", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("Test_Model.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
