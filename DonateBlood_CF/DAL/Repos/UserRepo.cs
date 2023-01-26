using DAL.DB_EF_CF.Models;
using DAL.DB_EF_CF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Interface;

namespace DAL.Repos
{
    internal class UserRepo : IRepo<User, int, User>, IAuth<User, int>, IAuthC<User, string>
    {
        BloodDonateEntities db;
        internal UserRepo()
        {
            db = new BloodDonateEntities();
        }

        public User Add(User obj)
        {
            db.Users.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public User Authenticate(string uname, string pass)
        {
            var obj = db.Users.FirstOrDefault(x => x.Username.Equals(uname) && x.Password.Equals(pass));
            return obj;
        }

        public bool Delete(int id)
        {
            var data = db.Users.Find(id);
            db.Users.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public User GetChecker(string uname)
        {
            var obj = db.Users.FirstOrDefault(x => x.Username.Equals(uname));
            return obj;
        }

        public User Update(User obj)
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
