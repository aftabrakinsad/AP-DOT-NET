using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class Cl_CraDTO
    {
        public virtual List<Collection_req_acceptDTO> Collection_Req_Accepts { get; set; }
        public Cl_CraDTO()
        {
            Collection_Req_Accepts = new List<Collection_req_acceptDTO>();
        }
    }
}