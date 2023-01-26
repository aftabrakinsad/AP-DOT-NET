using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class BedAllotment
    {
        public int Id { get; set; }
        [ForeignKey("Patients")]
        public int PatientID { get; set; }
        [Required]
        [StringLength(50)]
        public string PatientName { get; set; }
        [ForeignKey("Beds")]
        public int BedID { get; set; }
        [Required,StringLength(50)]
        public string BedCategory { get; set; }
        [Required,StringLength(50)]
        public string BedName { get; set; }
        [Required]
        public System.DateTime AllotmentDate { get; set; }
        public Nullable<System.DateTime> DischargeDate { get; set; }
        public virtual Patient Patients { get; set; }
        public virtual Bed Beds { get; set; }

    }
}
