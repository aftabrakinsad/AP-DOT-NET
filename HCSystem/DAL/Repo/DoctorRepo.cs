using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class DoctorRepo :Repo, IRepo<Doctor, int, Doctor>,Auth<Doctor,int>
    {
        
        public Doctor Add(Doctor obj)
        {
            db.Doctors.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public Doctor Doctors(string name)
        {
            var obj = db.Doctors.FirstOrDefault(x => x.Name.Equals(name));
            return obj;
        }

        public Doctor Authenticate(string Email, string password)
        {
            var obj = db.Doctors.FirstOrDefault(x => x.Email.Equals(Email) && x.Password.Equals(password));
            return obj;
        }

        public bool Delete(/*Doctor obj */int id)
        {
            //var data=Get(obj.ID);
            var data = db.Doctors.Find(id);
            db.Doctors.Remove(data);
            if(db.SaveChanges()>0)
            {
                return true;
            }
            return false;
        }

        public List<Doctor> Get()
        {
            return db.Doctors.ToList();
        }

        public Doctor Get(int id)
        {
            return db.Doctors.Find(id);
        }

        public Doctor Update(Doctor obj)
        {
            var data=Get(obj.ID);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        
    }
}
