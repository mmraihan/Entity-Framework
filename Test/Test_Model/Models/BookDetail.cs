using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Model.Models
{
    public class BookDetail
    {
        [Key]
        public int BookDetail_Id { get; set; }
        public int NumberOfchapters { get; set; }
        public int NumberOfPages { get; set; }
        public Double Weight { get; set; }

        public Book Book { get; set; }

    }
}
