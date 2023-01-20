using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ZH_EF_CF.Models
{
    public class Restaurant_Collection_request
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("Restaurant_login")]
        public int res_id { get; set; }
        public virtual Restaurant_login Restaurant_login { get; set; }

        [Required]
        public string res_name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int c_id { get; set; }

        [Required]
        public string c_name { get; set; }

        [Required]
        public string c_type { get; set; }

        [Required]
        public DateTime c_req_opening_time { get; set; }

        [Required]
        public string c_max_pre_time { get; set; }

        public int Operation { get; set; }
    }
}