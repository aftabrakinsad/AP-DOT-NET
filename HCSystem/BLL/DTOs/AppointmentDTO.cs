using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AppointmentDTO
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public System.DateTime AppointCreateDate { get; set; }
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string Status { get; set; }
    }
}
