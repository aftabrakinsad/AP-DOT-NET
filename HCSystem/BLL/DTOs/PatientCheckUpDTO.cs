using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PatientCheckUpDTO
    {
        public int DoctorID { get; set; } 
        public string DoctorName { get; set; }
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public System.DateTime CheckUpDate { get; set; }
        public string Symptoms { get; set; }
        public string MedicineName { get; set; }
        public int No_Of_Days { get; set; }
        public string MedTaking_Time { get; set; }
        public string BeforeMeal { get; set; }
    }
}
