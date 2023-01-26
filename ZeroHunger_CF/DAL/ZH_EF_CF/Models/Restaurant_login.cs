using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ZH_EF_CF.Models
{
    public class Restaurant_login
    {
        [Key]
        public int res_id { get; set; }

        [Required]
        [StringLength(50)]
        public string res_pass { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public virtual List<Restaurant_Collection_request> Rescolrequests { get; set; }
        public Restaurant_login()
        {
            Rescolrequests = new List<Restaurant_Collection_request>();
        }
    }
}
