﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StaffDTO
    {
        public int ID { get; set; }
      
        public string Name { get; set; }
      
        public string Email { get; set; }
       
        public string Password { get; set; }
      
        public string Phone { get; set; }
       

        public string Address { get; set; }
    }
}
