using AutoMapper;
using BLL.DTOs;
using DAL.DB_EF_CF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DonorService
    {
        public static DonorDTO Add(DonorDTO c)
        {
            var config = MapServices.Mapping<DonorDTO, Donor>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Donor>(c);
            var repo = DataAccessFactory.DonorDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<DonorDTO>(repo);
            }
            return null;
        }

        public static List<DonorDTO> Get()
        {
            var cfg = MapServices.OneTimeMapping<Donor, DonorDTO>();
            var mapper = new Mapper(cfg);
            var access = DataAccessFactory.DonorDataAccess().Get();
            return mapper.Map<List<DonorDTO>>(access);
        }

        public static DonorDTO Get(int id)
        {
            var config = MapServices.OneTimeMapping<Donor, DonorDTO>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.DonorDataAccess().Get(id);
            return mapper.Map<DonorDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.DonorDataAccess().Delete(id);
            return data;
        }

        public static DonorDTO Update(DonorDTO donorDTO)
        {
            var config = MapServices.Mapping<Donor, DonorDTO>();
            var mapper = new Mapper(config);
            var ca = mapper.Map<Donor>(donorDTO);
            var data = DataAccessFactory.DonorDataAccess().Update(ca);
            if (data != null)
            {
                return mapper.Map<DonorDTO>(data);
            }
            return null;
        }
        public static DonorDTO GetChecker(string name)
        {
            var data = DataAccessFactory.DonorAuthCheckerDataAccess().GetChecker(name);
            var config = MapServices.OneTimeMapping<Donor, DonorDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<DonorDTO>(data);
        }
    }
}
