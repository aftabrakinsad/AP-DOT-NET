using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IAuth<CLASS, ID>
    {
        CLASS Authenticate(int id , string pass);
    }
}