using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class StaffRepo :Repo, IRepo<Staff, int, Staff>
    {
        public Staff Add(Staff obj)
        {
            db.Staffs.Add(obj);
            if(db.SaveChanges()>0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(/*Staff obj*/ int id)
        {

            //var data = Get(obj.ID);
            var data = db.Staffs.Find(id);
            db.Staffs.Remove(data);
            if(db.SaveChanges()>0)
            {
                return true;
            }
            return false;

        }

        public List<Staff> Get()
        {
            return db.Staffs.ToList();
        }

        public Staff Get(int id)
        {
            var data= db.Staffs.Find(id);
            return data;
        }

        public Staff Update(Staff obj)
        {
            var data= Get(obj.ID);
            db.Entry(data).CurrentValues.SetValues(obj);
            if(db.SaveChanges()>0)
            {
                return obj;
            }
            return null;
        }
    }
}
