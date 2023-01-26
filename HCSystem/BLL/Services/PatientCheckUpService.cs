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
    public class PatientCheckUpService
    {
        public static PatientCheckUpDTO Add(PatientCheckUpDTO patientCheck,int id)
        {
            var cfg = Service.Mapping<PatientCheckUpDTO, PatientCheckUp>();
            var mapper = new Mapper(cfg);
            var data = DataAccessFactory.AppointmentDataAccess().Get(id);
            var check = new PatientCheckUp();
            check.PatientID=data.PatientID;
            check.PatientName=data.PatientName;
            check.DoctorID=data.DoctorID;
            check.DoctorName = data.DoctorName;
            check.CheckUpDate = DateTime.Now;
            check.Symptoms = patientCheck.Symptoms;
            check.MedicineName=patientCheck.MedicineName;
            check.No_Of_Days = patientCheck.No_Of_Days;
            check.BeforeMeal = patientCheck.BeforeMeal;
            check.MedTaking_Time = patientCheck.MedTaking_Time;
            var access = DataAccessFactory.PatientCheckUpDataAccess().Add(check);
            if(access != null)
            {
                return mapper.Map<PatientCheckUpDTO>(access);
            }
            return null;
        }
        
        public static PatientCheckUpDTO Get(int id)
        {
            var cfg = Service.OneTimeMapping<PatientCheckUp, PatientCheckUpDTO>();
            var mapper = new Mapper(cfg);
            var access = DataAccessFactory.AppointmentDataAccess().Get(id);
            var send = DataAccessFactory.CheckupDataAccess().Get(access.DoctorName);
            return mapper.Map<PatientCheckUpDTO>(send);
        }
        public static /*PatientCheckUpDTO*/bool Delete(/*PatientCheckUpDTO patientCheck*/int id)
        {
            //var cfg=Service.OneTimeMapping<PatientCheckUp, PatientCheckUpDTO>();
            //var mapper = new Mapper(cfg);
            //var data=mapper.Map<PatientCheckUp>(patientCheck);   
            var access = DataAccessFactory.PatientCheckUpDataAccess().Delete(/*data*/id);
            return access;
            //return mapper.Map<PatientCheckUpDTO>(access);
        }
        public static PatientCheckUpDTO Update(PatientCheckUpDTO patientCheck)
        {
            var cfg=Service.Mapping<PatientCheckUpDTO, PatientCheckUp>();
            var mapper = new Mapper(cfg);
            var map = mapper.Map<PatientCheckUp>(patientCheck);
            var access=DataAccessFactory.PatientCheckUpDataAccess().Update(map);
            if (access != null)
            {
                return mapper.Map<PatientCheckUpDTO>(access);
            }return null;
        }
    }
}
