using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Inferface
{
    public interface IREPO<CLASS, ID>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        void Create(CLASS item);
        void Update(CLASS obj);
        void Delete(ID id);

    }
}
