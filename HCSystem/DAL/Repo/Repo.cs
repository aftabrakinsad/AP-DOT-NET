using DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class Repo
    {
        protected HealthCareEntities db;
        internal Repo()
        {
            db = new HealthCareEntities();
        }
    }
}
