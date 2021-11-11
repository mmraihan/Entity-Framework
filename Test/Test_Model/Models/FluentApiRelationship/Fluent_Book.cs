using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Model.Models
{
   public class Fluent_Book
        
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

        [ForeignKey("BookDetail")]
        public int BookDetail_Id { get; set; }
        public BookDetail BookDetail { get; set; } //Navigation Property 


        // One to many. Publisher has many books

        [ForeignKey("Publisher")]
        public int Publisher_Id { get; set; }
        public Publisher Publisher { get; set; }


        #region Many To Mnay
        //Book has many writers and Many writers has many books

        public ICollection<BookInAuthor> BookInAuthors { get; set; }
        #endregion

    }
}
