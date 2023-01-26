using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Bed
    {
        public int Id { get; set; }
        [ForeignKey("BedCategories")]
        public int BedCategoryID { get; set; }
        [Required]
        public string BedCategory { get; set; }
        [Required]
        [StringLength(100)]
        public string BedName { get; set; }
        public virtual BedCategory BedCategories { get; set; }
        public virtual List<BedAllotment> BedAllotments { get; set; }
        public Bed()
        {
            this.BedAllotments = new List<BedAllotment>();
        }
    }
}
