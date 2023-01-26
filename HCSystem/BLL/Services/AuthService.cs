using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static TokenDTO Authenticate(string email, string password)
        {
            var data=DataAccessFactory.DoctorAuthDataAccess().Authenticate(email,password);
            var token = new Token();
            token.Username = data.Name;
            token.TKey=Guid.NewGuid().ToString();
            token.CreationTime=DateTime.Now;
            token.ExpirationTime = null;
            var tk = DataAccessFactory.TokenDataAccess().Add(token);
            if (tk != null)
            {
                var cfg = Service.OneTimeMapping<Token, TokenDTO>();
                var mapper = new Mapper(cfg);
                return mapper.Map<TokenDTO>(token);
            }return null;
        }
        public static bool IsValid(string token)
        {
            var data = DataAccessFactory.TokenDataAccess().Get(token);
            if(data != null)
            {
                return true;
            }return false;
        }
    }
}
