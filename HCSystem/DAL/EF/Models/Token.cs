
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Token
    {
        public int Id { get; set; }
        [StringLength(36)]
        [Required]
        public string TKey { get; set; }
        [Required]
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> ExpirationTime { get; set; }
        [Required]
        public string Username { get; set; }
    }
}
