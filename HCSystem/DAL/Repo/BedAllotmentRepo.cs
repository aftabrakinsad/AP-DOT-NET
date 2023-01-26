using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class BedAllotmentRepo : Repo, IRepo<BedAllotment, int, BedAllotment>
    {
        public BedAllotment Add(BedAllotment obj)
        {
            db.BedAllotments.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            db.BedAllotments.Remove(Get(id));
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<BedAllotment> Get()
        {
            return db.BedAllotments.ToList();
        }

        public BedAllotment Get(int id)
        {
            return db.BedAllotments.Find(id);
        }

        public BedAllotment Update(BedAllotment obj)
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
