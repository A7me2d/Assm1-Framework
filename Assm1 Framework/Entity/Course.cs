using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm1_Framework.Entity
{
    [Table("Course", Schema = "dbo")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Duration { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Top_id { get; set; }
    }
}
