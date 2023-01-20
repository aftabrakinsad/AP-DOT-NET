using DAL.Interface;
using DAL.ZH_EF_CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CollectionReqAcceptRepo : ERepo, IRepo<Collection_req_accept, int, Collection_req_accept>, IAuth<Collection_req_accept, int>, IAuthC<Collection_req_accept, int>
    {
        public Collection_req_accept Add(Collection_req_accept obj)
        {
            db.Colrequestaccepts.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public Collection_req_accept Authenticate(int id, string pass)
        {
            var obj = db.Colrequestaccepts.FirstOrDefault(x => x.ID.Equals(id));
            return obj;
        }

        public bool Delete(int id)
        {
            var data = db.Colrequestaccepts.Find(id);
            db.Colrequestaccepts.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Collection_req_accept> Get()
        {
            return db.Colrequestaccepts.ToList();
        }

        public Collection_req_accept Get(int id)
        {
            return db.Colrequestaccepts.Find(id);
        }

        public Collection_req_accept GetChecker(int id)
        {
            var obj = db.Colrequestaccepts.FirstOrDefault(x => x.ID.Equals(id));
            return obj;
        }

        public Collection_req_accept Update(Collection_req_accept obj)
        {
            var data = Get(obj.ID);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
