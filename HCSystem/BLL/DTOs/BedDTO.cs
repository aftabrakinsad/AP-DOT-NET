using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BedDTO
    {
        public int Id { get; set; }
        public int BedCategoryID { get; set; }
        public string BedCategory { get; set; }
        public string BedName { get; set; }
    }
}
