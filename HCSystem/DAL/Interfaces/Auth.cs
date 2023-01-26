using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface Auth<CLASS,ID>
    {
        CLASS Authenticate(string email,string password);
        CLASS Doctors(string name);
       
    }
}
