using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.DB_EF_CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static UserDTO Add(UserDTO userDTO)
        {
            var config = MapServices.Mapping<UserDTO, User>();
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(userDTO);
            var repo = DataAccessFactory.UserDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<UserDTO>(repo);
            }
            return null;
        }

        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.UserDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<UserDTO>>(data);
        }

        public static UserDTO Get(int id)
        {
            var data = DataAccessFactory.UserDataAccess().Get(id);
            var config = MapServices.OneTimeMapping<User, UserDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<UserDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.UserDataAccess().Delete(id);
            return data;
        }

        public static UserDTO Update(UserDTO userDTO)
        {
            var config = MapServices.Mapping<User, UserDTO>();
            var mapper = new Mapper(config);
            var user = mapper.Map<User>(userDTO);
            var data = DataAccessFactory.UserDataAccess().Update(user);
            if (data != null)
            {
                return mapper.Map<UserDTO>(data);
            }
            return null;
        }

        public static UserDTO GetChecker(string name)
        {
            var data = DataAccessFactory.UserAuthCheckerDataAccess().GetChecker(name);
            var config = MapServices.OneTimeMapping<User, UserDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<UserDTO>(data);
        }
    }
}
