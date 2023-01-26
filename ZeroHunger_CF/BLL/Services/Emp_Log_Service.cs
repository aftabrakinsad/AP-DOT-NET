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
    public class Emp_Log_Service
    {
        public static Employee_loginDTO Add(Employee_loginDTO emplogDTO)
        {
            var config = MapServices.Mapping<Employee_loginDTO, Employee_login>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Employee_login>(emplogDTO);
            var repo = DataAccessFactory.EmploginDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<Employee_loginDTO>(repo);
            }
            return null;
        }

        public static List<Employee_loginDTO> Get()
        {
            var data = DataAccessFactory.EmploginDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Employee_login, Employee_loginDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<Employee_loginDTO>>(data);
        }

        public static Employee_loginDTO Get(int id)
        {
            var data = DataAccessFactory.EmploginDataAccess().Get(id);
            var config = MapServices.OneTimeMapping<Employee_login, Employee_loginDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<Employee_loginDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.EmploginDataAccess().Delete(id);
            return data;
        }

        public static Employee_loginDTO Update(Employee_loginDTO emplogDTO)
        {
            var config = MapServices.Mapping<Employee_login, Employee_loginDTO>();
            var mapper = new Mapper(config);
            var admin = mapper.Map<Employee_login>(emplogDTO);
            var data = DataAccessFactory.EmploginDataAccess().Update(admin);
            if (data != null)
            {
                return mapper.Map<Employee_loginDTO>(data);
            }
            return null;
        }

        /*public static Employee_loginDTO GetChecker(int id)
        {
            var data = DataAccessFactory.AuthEmploginCheckerDataAccess().GetChecker(id);
            var config = MapServices.OneTimeMapping<Employee_login, Employee_loginDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<Employee_loginDTO>(data);
        }*/
    }
}