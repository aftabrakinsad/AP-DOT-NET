using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class PatientCheckUp
    {
        public int ID { set; get; }
        [Required]
        public int PatientID { set; get; }
        [Required]
        [StringLength(100)]
        public string PatientName { set; get; }
        [Required]
        public int DoctorID { set; get; }
        [Required,StringLength(100)]
        public string DoctorName { set; get; }
        [Required]
        public System.DateTime CheckUpDate { set; get; }
        [Required]
        [StringLength(100)]
        public string Symptoms { set; get; }
        [Required]
        [StringLength(100)]
        public string MedicineName { set; get; }
        [Required]
        public int No_Of_Days { set; get; }
        [Required]
        [StringLength(100)]
        public string MedTaking_Time { set; get; }
        [Required]
        [StringLength(100)]
        public string BeforeMeal {set;get;}
    }
}
