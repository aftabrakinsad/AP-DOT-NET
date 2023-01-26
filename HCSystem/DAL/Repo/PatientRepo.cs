using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class PatientRepo :Repo, IRepo<Patient, int, Patient>
    {
        public Patient Add(Patient obj)
        {
            db.Patients.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(/*Patient obj*/ int id)
        {
            //var data = Get(obj.ID);
            var data = db.Patients.Find(id);
            db.Patients.Remove(data);
            if(db.SaveChanges()>0)
            {
                return true;
            }
            return false;
        }

        public List<Patient> Get()
        {
            return db.Patients.ToList();
        }

        public Patient Get(int id)
        {
            return db.Patients.Find(id);
        }

        public Patient Update(Patient obj)
        {
            var data=Get(obj.ID);
            db.Entry(data).CurrentValues.SetValues(obj);
            if(db.SaveChanges()>0)
            {
                return obj;
            }
            return null;
        }
    }
}
