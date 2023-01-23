using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class Employee_infoDTO
    {
        public int ID { get; set; }

        public int emp_id { get; set; }

        public string emp_name { get; set; }

        public string emp_status { get; set; }
    }
}