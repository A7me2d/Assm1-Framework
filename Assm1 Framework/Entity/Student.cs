using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm1_Framework.Entity
{



    [Table("Student" , Schema = "dbo")]

    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
         [Column(TypeName = "varchar")]
          [MaxLength(50)]
           [StringLength(50,MinimumLength = 10)]
        public string FName { get; set; }


        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string LName { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }

        public int Dep_id { get; set; }
    }

}
