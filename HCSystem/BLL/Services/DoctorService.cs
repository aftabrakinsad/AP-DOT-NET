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
    public class DoctorService
    {
        public static DoctorDTO Add(DoctorDTO doctor)
        {
            var config = Service.Mapping<DoctorDTO, Doctor>();
            var mapper=new Mapper(config);
            var data=mapper.Map<Doctor>(doctor);
            var repo = DataAccessFactory.DoctorDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<DoctorDTO>(repo);
            }
            return null;
        }
        public static List<DoctorDTO> Get()
        {
            var data = DataAccessFactory.DoctorDataAccess().Get();
            //var config= Service.OneTimeMapping<Doctor, DoctorDTO>();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Doctor, DoctorDTO>();
            });
            var mapper=new Mapper(config);
            return mapper.Map<List<DoctorDTO>>(data);
        }
        public static DoctorDTO Get(int id)
        {
            var data = DataAccessFactory.DoctorDataAccess().Get(id);
            var config = Service.OneTimeMapping<Doctor, DoctorDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<DoctorDTO>(data);
        }


        public static bool Delete(/*DoctorDTO doctorDTO*/ int id)
        {
            //var config = Service.OneTimeMapping<Doctor, DoctorDTO>();
            //var mapper = new Mapper(config);
            //var doctor = mapper.Map<Doctor>(doctorDTO);
            var data = DataAccessFactory.DoctorDataAccess().Delete(/*doctor*/ id);
            return data;

        }


        public static DoctorDTO Update(DoctorDTO doctorDTO)
        {
            var config = Service.Mapping<Doctor, DoctorDTO>();
            var mapper = new Mapper(config);
            var doctor = mapper.Map<Doctor>(doctorDTO);
            var data = DataAccessFactory.DoctorDataAccess().Update(doctor);
            if (data != null)
            {
                return mapper.Map<DoctorDTO>(data);
            }

            return null;

        }
    }
}
