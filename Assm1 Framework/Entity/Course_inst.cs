using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm1_Framework.Entity
{

    [Table("Course_inst", Schema = "dbo")]
    public class Course_inst
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Inst_Id { get; set; }

        [Required]
        public int Course_id { get; set; }

        public string evaluation { get; set; }

    }
}
