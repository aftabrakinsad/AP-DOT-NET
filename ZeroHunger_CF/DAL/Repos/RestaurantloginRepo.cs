using DAL.Interface;
using DAL.ZH_EF_CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RestaurantloginRepo : ERepo, IRepo<Restaurant_login, int, Restaurant_login>, IAuth<Restaurant_login, int>, IAuthC<Restaurant_login, int>
    {
        public Restaurant_login Add(Restaurant_login obj)
        {
            db.Restaurant_Logins.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public Restaurant_login Authenticate(int id, string pass)
        {
            var obj = db.Restaurant_Logins.FirstOrDefault(x => x.res_id.Equals(id) && x.res_pass.Equals(pass));
            return obj;
        }

        public bool Delete(int id)
        {
            var data = db.Restaurant_Logins.Find(id);
            db.Restaurant_Logins.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Restaurant_login> Get()
        {
            return db.Restaurant_Logins.ToList();
        }

        public Restaurant_login Get(int id)
        {
            return db.Restaurant_Logins.Find(id);
        }

        public Restaurant_login GetChecker(int id)
        {
            var obj = db.Restaurant_Logins.FirstOrDefault(x => x.res_id.Equals(id));
            return obj;
        }

        public Restaurant_login Update(Restaurant_login obj)
        {
            var data = Get(obj.res_id);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
