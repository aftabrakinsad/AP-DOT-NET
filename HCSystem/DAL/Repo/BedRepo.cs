using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class BedRepo : Repo, IRepo<Bed, int, Bed>, ListofID<Bed,int>
    {
        public Bed Add(Bed obj)
        {
            db.Beds.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            db.Beds.Remove(Get(id));
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Bed> Get()
        {
            return db.Beds.ToList();
        }

        public Bed Get(int id)
        {
            return db.Beds.Find(id);
        }

        public List<Bed> GetListOfId(int id)
        {
            return db.Beds.Where(X=>X.BedCategoryID.Equals(id)).ToList();
        }

        public Bed Update(Bed obj)
        {
            var data = Get(obj.Id);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }return null;
        }
    }
}
