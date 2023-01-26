using AutoMapper;
using BLL.DTOs;
using DAL.ZH_EF_CF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class Res_Log_Service
    {
        public static Restaurant_loginDTO Add(Restaurant_loginDTO reslogDTO)
        {
            var config = MapServices.Mapping<Restaurant_loginDTO, Restaurant_login>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Restaurant_login>(reslogDTO);
            var repo = DataAccessFactory.ResloginDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<Restaurant_loginDTO>(repo);
            }
            return null;
        }

        public static List<Restaurant_loginDTO> Get()
        {
            var data = DataAccessFactory.ResloginDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Restaurant_login, Restaurant_loginDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<Restaurant_loginDTO>>(data);
        }

        public static Restaurant_loginDTO Get(int id)
        {
            var data = DataAccessFactory.ResloginDataAccess().Get(id);
            var config = MapServices.OneTimeMapping<Restaurant_login, Restaurant_loginDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<Restaurant_loginDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.ResloginDataAccess().Delete(id);
            return data;
        }

        public static Restaurant_loginDTO Update(Restaurant_loginDTO reslogDTO)
        {
            var config = MapServices.Mapping<Restaurant_login, Restaurant_loginDTO>();
            var mapper = new Mapper(config);
            var admin = mapper.Map<Restaurant_login>(reslogDTO);
            var data = DataAccessFactory.ResloginDataAccess().Update(admin);
            if (data != null)
            {
                return mapper.Map<Restaurant_loginDTO>(data);
            }
            return null;
        }

        /*public static Restaurant_loginDTO GetChecker(int id)
        {
            var data = DataAccessFactory.AuthResloginCheckerDataAccess().GetChecker(id);
            var config = MapServices.OneTimeMapping<Restaurant_login, Restaurant_loginDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<Restaurant_loginDTO>(data);
        }*/
    }
}