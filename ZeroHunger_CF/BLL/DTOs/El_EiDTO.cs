using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class El_EiDTO
    {
        public virtual List<Employee_infoDTO> Employee_Infos { get; set; }
        public El_EiDTO()
        {
            Employee_Infos = new List<Employee_infoDTO>();
        }
    }
}