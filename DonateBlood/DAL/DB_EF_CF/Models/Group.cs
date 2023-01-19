using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB_EF_CF.Models
{
    public class Group
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Group_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Group_Name { get; set; }

        public virtual List<Donor> Donors { get; set; }
        public Group()
        {
            Donors = new List<Donor>();
        }
    }
}
