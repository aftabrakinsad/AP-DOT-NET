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
    public class UserService
    {
        public static List<UserDTO> GetUsers()
        {
            var data = DataAccessFactory.UserDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>());
            var mapper = new Mapper(config);
            var users = mapper.Map<List<UserDTO>>(data);
            return users;
        }

        public static UserDTO Get(string uname)
        {
            var data = DataAccessFactory.UserDataAccess().Get(uname);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>());
            var mapper = new Mapper(config);
            var people = mapper.Map<UserDTO>(data);
            return people;
        }

        public static User Add(UserDTO add)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var people = mapper.Map<User>(add);
            var result = DataAccessFactory.UserDataAccess().Add(people);
            return result;
        }

        public static bool Update(UserDTO userupdate)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var group = mapper.Map<User>(userupdate);
            var result = DataAccessFactory.UserDataAccess().Update(group);
            return result;
        }

        public static bool Delete(string uname)
        {
            var result = DataAccessFactory.UserDataAccess().Delete(uname);
            return result;
        }
    }
}
