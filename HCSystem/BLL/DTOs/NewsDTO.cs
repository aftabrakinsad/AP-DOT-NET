using DAL.HCS_EF_DF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class NewsDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public int categoryId { get; set; }
        public System.DateTime date { get; set; }

        public virtual Category Category { get; set; }

    }
}
