using AutoMapper;
using BLL.DTOs;
using DAL.ZH_EF_CF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static TokenDTO Authenticate(int id, string password)
        {
            var comlogin = DataAccessFactory.AuthComloginDataAccess().Authenticate(id, password);
            var reslogin = DataAccessFactory.AuthResloginDataAccess().Authenticate(id, password);
            var emplogin = DataAccessFactory.AuthEmploginDataAccess().Authenticate(id, password);
            if (comlogin != null)
            {
                var token = new Token();
                token.Id = id;
                token.TKey = Guid.NewGuid().ToString();
                token.CreationTime = DateTime.Now;
                token.ExpirationTime = null;
                token.Type = "Company";
                var tk = DataAccessFactory.TokenDataAccess().Add(token);
                if (tk != null)
                {
                    var cfg = MapServices.OneTimeMapping<Token, TokenDTO>();
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(token);
                }
                return null;
            }
            else if (reslogin != null)
            {
                var token = new Token();
                token.Id = id;
                token.TKey = Guid.NewGuid().ToString();
                token.CreationTime = DateTime.Now;
                token.ExpirationTime = null;
                token.Type = "Restaurant";
                var tk = DataAccessFactory.TokenDataAccess().Add(token);
                if (tk != null)
                {
                    var cfg = MapServices.OneTimeMapping<Token, TokenDTO>();
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(token);
                }
                return null;
            }
            else if (emplogin != null)
            {
                var token = new Token();
                token.Id = id;
                token.TKey = Guid.NewGuid().ToString();
                token.CreationTime = DateTime.Now;
                token.ExpirationTime = null;
                token.Type = "Employee";
                var tk = DataAccessFactory.TokenDataAccess().Add(token);
                if (tk != null)
                {
                    var cfg = MapServices.OneTimeMapping<Token, TokenDTO>();
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(token);
                }
                return null;
            }
            else
            {
                return null;
            }
        }
        public static bool IsValid(string token)
        {
            var data = DataAccessFactory.TokenDataAccess().Get(token);
            if (data == null)
            {
                return true;
            }
            return false;
        }

        public static TokenDTO logout(string token)
        {
            var data = DataAccessFactory.TokenDataAccess().Get(token);

            if (data != null)
            {
                data.ExpirationTime = DateTime.Now;
                var tk = DataAccessFactory.TokenDataAccess().Update(data);
                var cfg = MapServices.OneTimeMapping<Token, TokenDTO>();
                var mapper = new Mapper(cfg);
                return mapper.Map<TokenDTO>(tk);
            }
            return null;
        }
    }
}