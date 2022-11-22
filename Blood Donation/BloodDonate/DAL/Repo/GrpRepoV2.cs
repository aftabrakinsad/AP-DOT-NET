using DAL.Interfaces;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class GrpRepoV2 : IRepo<Group, int, bool>
    {
        public bool Add(Group add)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Group> Get()
        {
            throw new NotImplementedException();
        }

        public Group Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Group update)
        {
            throw new NotImplementedException();
        }
    }
}
