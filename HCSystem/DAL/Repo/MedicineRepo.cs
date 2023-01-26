using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class MedicineRepo : Repo, IRepo<Medicine, int, Medicine>
    {
        public Medicine Add(Medicine obj)
        {
            db.Medicines.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(/*Medicine obj*/int id)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> Get()
        {
            return db.Medicines.ToList();
        }

        public Medicine Get(int id)
        {
            throw new NotImplementedException();
        }

        public Medicine Update(Medicine obj)
        {
            throw new NotImplementedException();
        }
    }
}
