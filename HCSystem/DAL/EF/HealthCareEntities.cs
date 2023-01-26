using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    internal class HealthCareEntities:DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<PatientCheckUp> patientCheckUps { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<BedCategory> BedCategories { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<BedAllotment> BedAllotments { get; set; }

        //public DbSet<HospitalDoctor> HospitalDoctors { get; set; }
        //public DbSet<HospitalStaff> HospitalStaffs { get; set; }
    }
}
