using DAL.ZH_EF_CF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ERepo
    {
        protected ZeroHungerEntities db;
        internal ERepo()
        {
            db = new ZeroHungerEntities();
        }
    }
}
