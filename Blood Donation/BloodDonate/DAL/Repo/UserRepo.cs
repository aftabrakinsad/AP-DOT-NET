using DAL.Database;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class UserRepo : IRepo<User, string, User>, IAuth
    {
        BloodDonateEntities db;
        internal UserRepo()
        {
            db = new BloodDonateEntities();
        }
        public User Add(User add)
        {
            db.Users.Add(add);
            db.SaveChanges();
            return add;
        }

        public bool Update(User update)
        {
            var ext = Get(update.Username);
            db.Entry(ext).CurrentValues.SetValues(update);
            return db.SaveChanges() > 0;
        }

        public bool Delete(string uname)
        {
            var delete = db.Users.Find(uname);
            db.Users.Remove(delete);
            return db.SaveChanges() > 0;
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(string uname)
        {
            return db.Users.Find(uname);
        }

        public User Authenticate(string uname, string pass)
        {
            return null;
        }
    }
}
