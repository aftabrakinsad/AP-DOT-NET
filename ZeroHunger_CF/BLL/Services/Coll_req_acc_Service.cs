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
    public class Coll_req_acc_Service
    {
        public static Collection_req_acceptDTO Add(Collection_req_acceptDTO acceptDTO)
        {
            var config = MapServices.Mapping<Collection_req_acceptDTO, Collection_req_accept>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Collection_req_accept>(acceptDTO);
            var repo = DataAccessFactory.CollReqAcceptDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<Collection_req_acceptDTO>(repo);
            }
            return null;
        }

        public static List<Collection_req_acceptDTO> Get()
        {
            var data = DataAccessFactory.CollReqAcceptDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Collection_req_accept, Collection_req_acceptDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<Collection_req_acceptDTO>>(data);
        }

        public static Collection_req_acceptDTO Get(int id)
        {
            var data = DataAccessFactory.CollReqAcceptDataAccess().Get(id);
            var config = MapServices.OneTimeMapping<Collection_req_accept, Collection_req_acceptDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<Collection_req_acceptDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.CollReqAcceptDataAccess().Delete(id);
            return data;
        }

        public static Collection_req_acceptDTO Update(Collection_req_acceptDTO acceptDTO)
        {
            var config = MapServices.Mapping<Collection_req_accept, Collection_req_acceptDTO>();
            var mapper = new Mapper(config);
            var admin = mapper.Map<Collection_req_accept>(acceptDTO);
            var data = DataAccessFactory.CollReqAcceptDataAccess().Update(admin);
            if (data != null)
            {
                return mapper.Map<Collection_req_acceptDTO>(data);
            }
            return null;
        }

        /*public static Collection_req_acceptDTO GetChecker(int id)
        {
            var data = DataAccessFactory.CollReqAcceptDataAccess().GetChecker(id);
            var config = MapServices.OneTimeMapping<Collection_req_accept, Collection_req_acceptDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<Collection_req_acceptDTO>(data);
        }*/
    }
}