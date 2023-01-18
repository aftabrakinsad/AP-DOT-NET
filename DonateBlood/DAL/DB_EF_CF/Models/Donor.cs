using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL.DB_EF_CF.Models
{
    public class Donor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Donor_Name { get; set; }

        [ForeignKey("Group")]
        public int GrpId { get; set; }

        public virtual Group Group { get; set; }
    }
}
