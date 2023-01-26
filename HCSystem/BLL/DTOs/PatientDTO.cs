using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PatientDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }    
        public string Password { get; set; }    
        public string Phone { get; set; }    
        public string Address { get; set; }    
        public string Dob { get; set; }    
        public string BloodGroup { get; set; }    
        public string Description { get; set; }

    }
}
