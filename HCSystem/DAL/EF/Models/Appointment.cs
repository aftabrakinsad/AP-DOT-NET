using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        [ForeignKey("Patients")]
        public int PatientID { get; set; }
        [Required]
        [StringLength(100)]
        public string PatientName { get; set; }
        [Required]
        public System.DateTime AppointCreateDate { get; set; }
        [Required]
        [StringLength(100)]
        public string Status { get; set; }
        [ForeignKey("Doctors")]
        public int DoctorID { get; set; }
        [Required,StringLength(100)]
        public string DoctorName { get; set; }
        public virtual Doctor Doctors { get; set; }
        public virtual Patient Patients { get; set; }
    }
}
