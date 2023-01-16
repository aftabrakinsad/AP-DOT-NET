using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DonorGroupDTO
    {
        public virtual List<DonorDTO> Cases { get; set; }
        public DonorGroupDTO()
        {
            Cases = new List<DonorDTO>();
        }
    }
}
