using DevSkill.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill.DbContexts
{
   public class TrainingContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public TrainingContext()
        {
            _connectionString = ConnectionStringReader.ConnectionString;
            _assemblyName = typeof(Program).Assembly.FullName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_assemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }
         
        protected override void OnModelCreating(ModelBuilder builder)  //Fluent API
        {
            builder.Entity<CourseStudent>()
                .HasKey(cs => new { cs.CourseId, cs.StudentId });  //For creating primary key

            #region One to Many
            builder.Entity<Course>()
               .HasMany(p => p.Topics) //Course has many topics
               .WithOne(i => i.Course); // Topic has  one course
            #endregion

            #region Many to Many

            builder.Entity<CourseStudent>()
                .HasOne(pc => pc.Course)
                .WithMany(p => p.CourseStudents)
                .HasForeignKey(p => p.CourseId);

            builder.Entity<CourseStudent>()
                .HasOne(pc => pc.Student)
                .WithMany(pc => pc.StudentCourses)
                .HasForeignKey(pc => pc.StudentId);
                
                

            #endregion




            base.OnModelCreating(builder);
        }



        public DbSet<Student> students { get; set; }
        public DbSet<Course> Course { get; set; }




    }
}
