using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Model.Models
{
    //Rename Table
    [Table("tbl_category")]
    public class Category
    {
        [Key]
        
        public int Category_Id { get; set; }

        [Required]
        [Column("Categories_Name")] //Rename Column Name
        public string Name { get; set; }

    }
}
