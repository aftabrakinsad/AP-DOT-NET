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
        public List<DonorDTO>Get()
        {
            var db = DataAccessFactory.DonorDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Donor, DonorDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<DonorDTO>>(db);
            return data;
        }

        public DonorDTO Get(int id)
        {
            var db = DataAccessFactory.DonorDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Donor, DonorDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<DonorDTO>(db);
            return data;
        }

        public DonorDTO Add(DonorDTO add)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Donor, DonorDTO>();
                cfg.CreateMap<DonorDTO, Donor>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Donor>(add);
            var result = DataAccessFactory.DonorDataAccess().Add(data);
            var redata = mapper.Map<DonorDTO>(add);
            return redata;
        }
    }
}
