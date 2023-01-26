using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AppointMentService
    {
        public static AppointmentDTO Add(AppointmentDTO appointment,string name)
        {
            var config = Service.Mapping<AppointmentDTO, Appointment>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.DoctorAuthDataAccess().Doctors(name);
            var addappointment = new Appointment();
            addappointment.PatientID=appointment.PatientID;
            addappointment.PatientName= appointment.PatientName;
            addappointment.AppointCreateDate= DateTime.Now;
            addappointment.DoctorID=data.ID;
            addappointment.DoctorName=data.Name;
            addappointment.Status=appointment.Status;
            var access = DataAccessFactory.AppointmentDataAccess().Add(addappointment);
            if(access != null)
            {
                return mapper.Map<AppointmentDTO>(access);
            }return null;
        }
        public static List<AppointmentDTO> ShowAppointments(string name)
        {
                var data = DataAccessFactory.DoctorAuthDataAccess().Doctors(name);
                var appDoc = DataAccessFactory.NewAppointmentDataAccess().GetListOfId(data.ID);
                var config = Service.OneTimeMapping<Appointment, AppointmentDTO>();
                var mapper = new Mapper(config);             
                return mapper.Map<List<AppointmentDTO>>(appDoc);          
                
        }
        public static AppointmentDTO Get(int id)
        {
            var data = DataAccessFactory.DoctorDataAccess().Get(id);
            var config = Service.OneTimeMapping<Appointment, AppointmentDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<AppointmentDTO>(data);
        }
        public static AppointmentDTO Get()
        {
            var data = DataAccessFactory.DoctorDataAccess().Get();
            var config = Service.OneTimeMapping<Appointment, AppointmentDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<AppointmentDTO>(data);
        }
    }
}
