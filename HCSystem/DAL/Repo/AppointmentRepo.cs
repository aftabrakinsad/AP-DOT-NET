using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class AppointmentRepo : Repo, IRepo<Appointment, int, Appointment>,ListofID<Appointment,int>
    {
        public Appointment Add(Appointment obj)
        {
            db.Appointments.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }return null;
        }

        public bool Delete(/*Appointment obj*/int id)
        {
            //var data = Get(obj.Id);
            var data = db.Appointments.Find(id);
            db.Appointments.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Appointment> Get()
        {
            return db.Appointments.ToList();
        }

        public Appointment Get(int id)
        {
            return db.Appointments.Find(id);
        }

        public Appointment Update(Appointment obj)
        {
            var data = Get(obj.Id);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public List<Appointment> GetListOfId(int id)
        {
            return db.Appointments.Where(x => x.DoctorID == id).ToList();
        }
    }
}
