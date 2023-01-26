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
    public class Res_Coll_req_Service
    {
        public static Restaurant_Collection_requestDTO Add(Restaurant_Collection_requestDTO requestDTO)
        {
            var config = MapServices.Mapping<Restaurant_Collection_requestDTO, Restaurant_Collection_request>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Restaurant_Collection_request>(requestDTO);
            var repo = DataAccessFactory.ResCollReqDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<Restaurant_Collection_requestDTO>(repo);
            }
            return null;
        }

        public static List<Restaurant_Collection_requestDTO> Get()
        {
            var data = DataAccessFactory.ResCollReqDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Restaurant_Collection_request, Restaurant_Collection_requestDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<Restaurant_Collection_requestDTO>>(data);
        }

        public static Restaurant_Collection_requestDTO Get(int id)
        {
            var data = DataAccessFactory.ResCollReqDataAccess().Get(id);
            var config = MapServices.OneTimeMapping<Restaurant_Collection_request, Restaurant_Collection_requestDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<Restaurant_Collection_requestDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.ResCollReqDataAccess().Delete(id);
            return data;
        }

        public static Restaurant_Collection_requestDTO Update(Restaurant_Collection_requestDTO requestDTO)
        {
            var config = MapServices.Mapping<Restaurant_Collection_request, Restaurant_Collection_requestDTO>();
            var mapper = new Mapper(config);
            var admin = mapper.Map<Restaurant_Collection_request>(requestDTO);
            var data = DataAccessFactory.ResCollReqDataAccess().Update(admin);
            if (data != null)
            {
                return mapper.Map<Restaurant_Collection_requestDTO>(data);
            }
            return null;
        }

        /*public static Restaurant_Collection_requestDTO GetChecker(int id)
        {
            var data = DataAccessFactory.AuthResloginCheckerDataAccess().GetChecker(id);
            var config = MapServices.OneTimeMapping<Restaurant_Collection_request, Restaurant_Collection_requestDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<Restaurant_Collection_requestDTO>(data);
        }*/
    }
}