using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Models
{
    public class Animal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        [Index("Ix_AnimalName")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [Index("Ix_AnimalOrigin")]
        public string Origin { get; set; }
        

        public virtual ICollection<AnimalFood> AnimalFoods { get; set; }
    }

    public class Food
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Index("Ix_FoodName")]
        public string Name { get; set; }

        public virtual ICollection<AnimalFood> AnimalFoods { get; set; }

    }

    public class AnimalFood
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Primary key generator ,increment by 1
        public int Id { get; set; }

        [ForeignKey("Animal")]
        [Required]
        public int AnimaId { get; set; }
        public virtual Animal Animal { get; set; }


        [ForeignKey("Food")]
        [Required]
        public int FoodId { get; set; }

        public virtual Food Food { get; set; }

        [Required]
        public int Quantity { get; set; }

    }


}
