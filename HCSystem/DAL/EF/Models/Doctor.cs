using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
        [Required]
        [StringLength(50)]

        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        public string Qualification { get; set; }


        public Doctor() 
        {
            /*this.HospitalDoctors= new List<HospitalDoctor>();
            this.DoctorPatients= new List<DoctorPatient>();*/
            this.Appointments = new List<Appointment>();
            //this.PatientCheckUps = new List<PatientCheckUp>();
        }
        public virtual List<Appointment> Appointments { get; set; }
        //public virtual List<PatientCheckUp> PatientCheckUps { get; set; }
        //public virtual List<HospitalDoctor> HospitalDoctors { get; set; }
        //public virtual List<DoctorPatient> DoctorPatients { get; set; }
    }
}
