using DAL.DB_EF_CF;
using DAL.DB_EF_CF.Models;
using DAL.Interface;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class GroupRepo : IRepo<Group, string, Group>, IAuthC<Group, string>
    {
        BloodDonateEntities db;
        internal GroupRepo()
        {
            db = new BloodDonateEntities();
        }

        public Group Add(Group obj)
        {
            db.Groups.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(string id)
        {
            var data = db.Groups.Find(id);
            db.Groups.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Group> Get()
        {
            return db.Groups.ToList();
        }

        public Group Get(string id)
        {
            return db.Groups.Find(id);
        }

        public Group GetChecker(string gname)
        {
            var obj = db.Groups.FirstOrDefault(x => x.Group_Name.Equals(gname));
            return obj;
        }

        public Group Update(Group obj)
        {
            var data = Get(obj.Group_Name);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
