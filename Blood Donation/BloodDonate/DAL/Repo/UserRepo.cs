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

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User update)
        {
            throw new NotImplementedException();
        }

        public User Authenticate(string uname, string pass)
        {
            return null;
        }
    }
}
