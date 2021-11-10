using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Fees { get; set; }
        public List<Topic> Topics { get; set; } //1 to Many Relationship
        public List<CourseStudent> CourseStudents { get; set; }


    }
}
