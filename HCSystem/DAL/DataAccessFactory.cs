using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Doctor, int, Doctor> DoctorDataAccess()
        {
            return new DoctorRepo();
        }
        public static Auth<Doctor,int> DoctorAuthDataAccess()
        {
            return new DoctorRepo();
        }
        public static IRepo<Patient, int, Patient> PatientDataAccess()
        {
            return new PatientRepo();
        }
        public static IRepo<Hospital, int, Hospital> HospitalDataAccess()
        {
            return new HospitalRepo();
        }
        public static IRepo<Staff, int, Staff> StaffDataAccess()
        {
            return new StaffRepo();
        }
        public static IRepo<Appointment,int,Appointment> AppointmentDataAccess()
        {
            return new AppointmentRepo();
        }
        public static IRepo<Token, string, Token> TokenDataAccess()
        {
            return new TokenRepo();
        }
        public static ListofID<Appointment,int> NewAppointmentDataAccess()
        {
            return new AppointmentRepo();
        }
        public static ListofID<Bed, int> BedListDataAccess()
        {
            return new BedRepo();
        }
        public static IRepo<PatientCheckUp, int,PatientCheckUp> PatientCheckUpDataAccess()
        {
            return new PatientCheckUpRepo();
        }
        public static IRepo<Medicine, int, Medicine> MedicineDataAccess()
        {
            return new MedicineRepo();
        }
        public static IRepo<BedAllotment, int, BedAllotment> BedAllotmentDataAccess()
        {
            return new BedAllotmentRepo();
        }
        public static IRepo<Bed, int, Bed> BedDataAccess()
        {
            return new BedRepo();
        }
        public static IRepo<BedCategory, int, BedCategory> BedCategoryDataAccess()
        {
            return new BedCategoryRepo();
        }
        public static CheckUp CheckupDataAccess()
        {
            return new PatientCheckUpRepo();
        }

        //public static IAuth AuthDataAccess()
        //{
        //    return new UserRepo();
        //}
        //public static IRepo<Token, string, Token> TokenDataAccess()
        //{
        //    return new TokenRepo();
        //}
    }
 }
