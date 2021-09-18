using DevSkill.DbContexts;
using DevSkill.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevSkill
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingContext context = new TrainingContext();
            #region Data Insert
            //Student student = new Student()
            //{
            //    Name = "Raihan",
            //    DateOfBirth = new DateTime(1996, 1, 1),
            //    CGPA = 3.27,
            //};

            //context.students.Add(student);
            //context.SaveChanges();
            #endregion


            #region One to Many Relationship
            //Course course = new Course();
            //course.Title = "Advance C#";
            //course.Fees = 8500;

            //course.Topics = new List<Topic>();
            //course.Topics.Add(new Topic { Name = "Delegates" });
            //course.Topics.Add(new Topic { Name = "LINQ" });

            //context.Course.Add(course);
            //context.SaveChanges();

            #endregion

            #region Retrieving Data One to Many

            var course=context.Course.Where(x => x.Id == 2)
                .Include("Topics")
                .FirstOrDefault();

            Console.WriteLine($"Course Title: {course.Title}");
            Console.WriteLine("--------Topics:--------------");
            foreach (var item in course.Topics)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();

            #endregion

        }
    }
}
