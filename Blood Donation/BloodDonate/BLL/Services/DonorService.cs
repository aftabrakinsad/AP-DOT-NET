using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DonorService
    {
        public static List<DonorDTO> Get()
        {
            var db = DataAccessFactory.DonorDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Donor, DonorDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<DonorDTO>>(db);
            return data;
        }

        public static DonorDTO Get(int id)
        {
            var db = DataAccessFactory.DonorDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Donor, DonorDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<DonorDTO>(db);
            return data;
        }

        public static DonorDTO Add(DonorDTO add)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Donor, DonorDTO>();
                cfg.CreateMap<DonorDTO, Donor>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Donor>(add);
            var result = DataAccessFactory.DonorDataAccess().Add(data);
            var redata = mapper.Map<DonorDTO>(add);
            return redata;
        }

        public static bool Update(DonorDTO update)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DonorDTO, Donor>();
                cfg.CreateMap<Donor, DonorDTO>();
            });
            var mapper = new Mapper(config);
            var donor = mapper.Map<Donor>(update);
            var result = DataAccessFactory.DonorDataAccess().Update(donor);
            return result;
        }

        public static bool Delete(int id)
        {
            var result = DataAccessFactory.DonorDataAccess().Delete(id);
            return result;
        }
    }
}
