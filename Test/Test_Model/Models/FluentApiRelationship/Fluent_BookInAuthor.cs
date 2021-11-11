using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Model.Models
{
   public class Fluent_BookInAuthor
    {

        public int Book_Id { get; set; }
        public Book Book { get; set; }
        public int Author_Id { get; set; }
        public Author Author { get; set; }
    }
}
