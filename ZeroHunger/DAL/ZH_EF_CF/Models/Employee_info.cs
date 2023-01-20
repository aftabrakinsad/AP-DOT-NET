using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ZH_EF_CF.Models
{
    public class Employee_info
    {
        [ForeignKey("Employee_login")]
        public int emp_id { get; set; }
        public virtual Employee_login Employee_login { get; set; }

        [Required]
        [StringLength(100)]
        public string emp_name { get; set; }

        [Required]
        [StringLength(100)]
        public string emp_status { get; set; }
    }
}