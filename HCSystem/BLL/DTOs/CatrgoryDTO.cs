using DAL.HCS_EF_DF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CatrgoryDTO
    {
        public int id { get; set; }
        public string name { get; set; }

        public virtual News News { get; set; }
    }
}
