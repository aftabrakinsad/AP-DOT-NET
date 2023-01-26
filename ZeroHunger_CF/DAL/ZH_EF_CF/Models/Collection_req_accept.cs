using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ZH_EF_CF.Models
{
    public class Collection_req_accept
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("Company_login")]
        public int com_id { get; set; }
        public virtual Company_login Company_login { get; set; }

        [ForeignKey("Restaurant_login")]
        public int res_id { get; set;}
        public virtual Restaurant_login Restaurant_login { get; set; }

        [Required]
        [StringLength(100)]
        public string res_name { get; set; }

        [Required]
        [StringLength(100)]
        public string c_name { get; set; }

        [Required]
        [StringLength(50)]
        public string c_type { get; set; }

        [Required]
        public DateTime accept_time { get; set; }

        public string assign_emp { get; set;}
    }
}