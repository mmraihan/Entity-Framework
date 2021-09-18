using DevSkill.DbContexts;
using DevSkill.Entities;
using System;

namespace DevSkill
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingContext context = new TrainingContext();
            Student student = new Student()
            {
                Name = "Raihan",
                DateOfBirth = new DateTime(1996, 1, 1),
                CGPA = 3.27,
            };

            context.students.Add(student);
            context.SaveChanges();


        }
    }
}
