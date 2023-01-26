using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string MedicineName { get; set; }
        
    }
}
