using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BedAllotmentDTO
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public int BedID { get; set; }
        public string BedCategory { get; set; }
        public string BedName { get; set; }
        public System.DateTime AllotmentDate { get; set; }
        public Nullable<System.DateTime> DischargeDate { get; set; }
    }
}
