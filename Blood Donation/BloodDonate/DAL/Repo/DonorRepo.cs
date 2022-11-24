using DAL.Database;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class DonorRepo : IRepo<Donor, int, Donor>
    {
        BloodDonateEntities db;
        internal DonorRepo()
        {
            db = new BloodDonateEntities();
        }

        public Donor Add(Donor add)
        {
            db.Donors.Add(add);
            db.SaveChanges();
            return add;
        }

        public bool Delete(int id)
        {
            db.Donors.Remove(db.Donors.Find(id));
            return db.SaveChanges() > 0;
        }

        public bool Update(Donor update)
        {
            var resu = Get(update.Id);
            db.Entry(resu).CurrentValues.SetValues(update);
            return db.SaveChanges() > 0;
        }

        public List<Donor> Get()
        {
            return db.Donors.ToList();
        }

        public Donor Get(int id)
        {
            return db.Donors.Find(id);
        }
    }
}
