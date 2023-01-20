using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ZH_EF_CF.Models
{
    public class Company_login
    {
        [Key]
        public int com_id { get; set; }

        [Required]
        [StringLength(50)]
        public int com_pass { get; set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public virtual List<Collection_req_accept> Colrequestaccepts { get; set; }
        public Company_login()
        {
            Colrequestaccepts = new List<Collection_req_accept>();
        }
    }
}
