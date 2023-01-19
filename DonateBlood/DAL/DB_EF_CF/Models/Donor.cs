using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB_EF_CF.Models
{
    public class Donor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Donor_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Donor_Name { get; set; }

        [ForeignKey("Group")]
        public int Group_Id { get; set; }

        public virtual Group Group { get; set; }
    }
}
