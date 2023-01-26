using DAL.Interface;
using DAL.ZH_EF_CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CollectionReqRepo : ERepo, IRepo<Restaurant_Collection_request, int, Restaurant_Collection_request>, IAuth<Restaurant_Collection_request, int>, IAuthC<Restaurant_Collection_request, int>
    {
        public Restaurant_Collection_request Add(Restaurant_Collection_request obj)
        {
            db.Restaurant_Collection_Requests.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public Restaurant_Collection_request Authenticate(int id, string pass)
        {
            var obj = db.Restaurant_Collection_Requests.FirstOrDefault(x => x.res_id.Equals(id));
            return obj;
        }

        public bool Delete(int id)
        {
            var data = db.Restaurant_Collection_Requests.Find(id);
            db.Restaurant_Collection_Requests.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Restaurant_Collection_request> Get()
        {
            return db.Restaurant_Collection_Requests.ToList();
        }

        public Restaurant_Collection_request Get(int id)
        {
            return db.Restaurant_Collection_Requests.Find(id);
        }

        public Restaurant_Collection_request GetChecker(int id)
        {
            var obj = db.Restaurant_Collection_Requests.FirstOrDefault(x => x.res_id.Equals(id));
            return obj;
        }

        public Restaurant_Collection_request Update(Restaurant_Collection_request obj)
        {
            var data = Get(obj.c_id);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
