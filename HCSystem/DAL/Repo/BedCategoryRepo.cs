using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class BedCategoryRepo : Repo, IRepo<BedCategory, int, BedCategory>
    {
        public BedCategory Add(BedCategory obj)
        {
            db.BedCategories.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }return null;
        }

        public bool Delete(int id)
        {
            db.BedCategories.Remove(Get(id));
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<BedCategory> Get()
        {
            return db.BedCategories.ToList();
        }

        public BedCategory Get(int id)
        {
            return db.BedCategories.Find(id);

        }

        public BedCategory Update(BedCategory obj)
        {
            var data = Get(obj.Id);
            db.Entry(data).CurrentValues.SetValues(obj);
            if(db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
            
        }
    }
}
