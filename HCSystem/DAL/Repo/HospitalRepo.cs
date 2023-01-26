using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class HospitalRepo : IRepo<Hospital, int, Hospital>
    {
        public Hospital Add(Hospital obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(/*Hospital obj*/int id)
        {
            throw new NotImplementedException();
        }

        public List<Hospital> Get()
        {
            throw new NotImplementedException();
        }

        public Hospital Get(int id)
        {
            throw new NotImplementedException();
        }

        public Hospital Update(Hospital obj)
        {
            throw new NotImplementedException();
        }
    }
}
