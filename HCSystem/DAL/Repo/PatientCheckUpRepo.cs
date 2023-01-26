using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class PatientCheckUpRepo : Repo, IRepo<PatientCheckUp, int, PatientCheckUp>,CheckUp
    {
        public PatientCheckUp Add(PatientCheckUp obj)
        {
            db.patientCheckUps.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(/*PatientCheckUp obj*/int id)
        {
            //var data = Get(obj.ID);
            var data = db.patientCheckUps.Find(id);
            db.patientCheckUps.Remove(data);
            if(db.SaveChanges() > 0)
            {
                return true;
            }return false;
        }

        public List<PatientCheckUp> Get()
        {
            throw new NotImplementedException();
        }

        public PatientCheckUp Get(int id)
        {
            return db.patientCheckUps.Find(id);
        }

        public PatientCheckUp Get(string DoctorName)
        {
            return db.patientCheckUps.FirstOrDefault(x => x.DoctorName == DoctorName);
        }

        public PatientCheckUp Update(PatientCheckUp obj)
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
