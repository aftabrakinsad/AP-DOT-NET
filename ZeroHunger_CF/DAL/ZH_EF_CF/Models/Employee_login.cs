using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ZH_EF_CF.Models
{
    public class Employee_login
    {
        [Key]
        public int emp_id { get; set; }

        [Required]
        [StringLength(50)]
        public string emp_pass { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public virtual List<Employee_info> Empinfos { get; set; }
        public Employee_login()
        {
            Empinfos = new List<Employee_info>();
        }
    }
}