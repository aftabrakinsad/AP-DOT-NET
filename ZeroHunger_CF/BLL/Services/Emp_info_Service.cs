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
    public class Emp_info_Service
    {
        public static Employee_infoDTO Add(Employee_infoDTO einfoDTO)
        {
            var config = MapServices.Mapping<Employee_infoDTO, Employee_info>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Employee_info>(einfoDTO);
            var repo = DataAccessFactory.EmpInfoDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<Employee_infoDTO>(repo);
            }
            return null;
        }

        public static List<Employee_infoDTO> Get()
        {
            var data = DataAccessFactory.EmpInfoDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Employee_info, Employee_infoDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<Employee_infoDTO>>(data);
        }

        public static Employee_infoDTO Get(int id)
        {
            var data = DataAccessFactory.EmpInfoDataAccess().Get(id);
            var config = MapServices.OneTimeMapping<Employee_info, Employee_infoDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<Employee_infoDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.EmpInfoDataAccess().Delete(id);
            return data;
        }

        public static Employee_infoDTO Update(Employee_infoDTO einfoDTO)
        {
            var config = MapServices.Mapping<Employee_info, Employee_infoDTO>();
            var mapper = new Mapper(config);
            var admin = mapper.Map<Employee_info>(einfoDTO);
            var data = DataAccessFactory.EmpInfoDataAccess().Update(admin);
            if (data != null)
            {
                return mapper.Map<Employee_infoDTO>(data);
            }
            return null;
        }

        /*public static Employee_infoDTO GetChecker(int id)
        {
            var data = DataAccessFactory.EmpInfoDataAccess().GetChecker(id);
            var config = MapServices.OneTimeMapping<Employee_info, Employee_infoDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<Employee_infoDTO>(data);
        }*/
    }
}