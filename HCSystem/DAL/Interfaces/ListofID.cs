using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ListofID<CLASS,RET>
    {
        List<CLASS> GetListOfId(int id);
        
    }
}
