using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class GroupDonorDTO
    {
        public virtual List<DonorDTO> Donors { get; set; }
        public GroupDonorDTO()
        {
            Donors = new List<DonorDTO>();
        }
    }
}
