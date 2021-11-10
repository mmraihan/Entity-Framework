using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Model.Models
{
   public class Book
    {
        [Key]
        public int Book_Id { get; set; }

        [Required]
        [MaxLength(50), MinLength(10)]
        public string Title { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required ]
        public double Price { get; set; }

        [NotMapped]
        public string PriceRange { get; set; }

        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        public Category Category { get; set; }
    }
}
