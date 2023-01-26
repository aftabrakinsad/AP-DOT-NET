using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class BedCategory
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }
        public virtual List<Bed> Beds { get; set; }
        public BedCategory()
        {
            this.Beds=new List<Bed>();
        }
    }
}
