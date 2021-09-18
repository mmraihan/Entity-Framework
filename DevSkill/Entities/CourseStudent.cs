using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill.Entities
{
    public class CourseStudent //Miiddle Table
    {
        //[Key]
        //[Column(Order = 1)] Composite Key For creating PK
        public int CourseId { get; set; }
        public Course Course { get; set; }

         
        //[Key]
        //[Column(Order = 1)] Composite Key For creating PK
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
