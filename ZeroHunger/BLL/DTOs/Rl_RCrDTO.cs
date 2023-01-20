using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class Rl_RCrDTO
    {
        public virtual List<Restaurant_Collection_requestDTO> Restaurant_Collection_Requests { get; set; }
        public Rl_RCrDTO()
        {
            Restaurant_Collection_Requests = new List<Restaurant_Collection_requestDTO>();
        }
    }
}