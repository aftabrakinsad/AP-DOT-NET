using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Hospital
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
        public string Location { get; set; }

        /*public Hospital()
        {
            this.HospitalDoctors = new List<HospitalDoctor>();
            this.HospitalStaffs = new List<HospitalStaff>();
        }
        public virtual List<HospitalDoctor> HospitalDoctors { get; set; }
        public virtual List<HospitalStaff> HospitalStaffs { get; set; }*/
    }
}
