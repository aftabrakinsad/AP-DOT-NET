using DAL.DB_EF_CF;
using DAL.DB_EF_CF.Models;
using DAL.Interface;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Repos
{
    internal class DonorRepo : IRepo<Donor, int, Donor>, IAuthC<Donor, string>
    {
        BloodDonateEntities db;
        internal DonorRepo()
        {
            db = new BloodDonateEntities();
        }

        public Donor Add(Donor obj)
        {
            db.Donors.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var data = db.Donors.Find(id);
            db.Donors.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Donor> Get()
        {
            return db.Donors.ToList();
        }

        public Donor Get(int id)
        {
            return db.Donors.Find(id);
        }

        public Donor GetChecker(string name)
        {
            var obj = db.Donors.FirstOrDefault(x => x.Name.Equals(name));
            return obj;
        }

        public Donor Update(Donor obj)
        {
            var data = Get(obj.Id);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
