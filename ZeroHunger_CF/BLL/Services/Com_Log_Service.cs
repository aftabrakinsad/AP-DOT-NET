using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.ZH_EF_CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class Com_Log_Service
    {
        public static Company_loginDTO Add(Company_loginDTO comlogDTO)
        {
            var config = MapServices.Mapping<Company_loginDTO, Company_login>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Company_login>(comlogDTO);
            var repo = DataAccessFactory.ComloginDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<Company_loginDTO>(repo);
            }
            return null;
        }

        public static List<Company_loginDTO> Get()
        {
            var data = DataAccessFactory.ComloginDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Company_login, Company_loginDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<Company_loginDTO>>(data);
        }

        public static Company_loginDTO Get(int id)
        {
            var data = DataAccessFactory.ComloginDataAccess().Get(id);
            var config = MapServices.OneTimeMapping<Company_login, Company_loginDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<Company_loginDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.ComloginDataAccess().Delete(id);
            return data;
        }

        public static Company_loginDTO Update(Company_loginDTO comlogDTO)
        {
            var config = MapServices.Mapping<Company_login, Company_loginDTO>();
            var mapper = new Mapper(config);
            var admin = mapper.Map<Company_login>(comlogDTO);
            var data = DataAccessFactory.ComloginDataAccess().Update(admin);
            if (data != null)
            {
                return mapper.Map<Company_loginDTO>(data);
            }
            return null;
        }

        /*public static Company_loginDTO GetChecker(int id)
        {
            var data = DataAccessFactory.AuthComloginCheckerDataAccess().GetChecker(id);
            var config = MapServices.OneTimeMapping<Company_login, Company_loginDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<Company_loginDTO>(data);
        }*/
    }
}