using DAL.DB_EF_CF.Models;
using DAL.Interface;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, int, User> UserDataAccess()
        {
            return new UserRepo();
        }

        public static IAuth<User, int> UserAuthDataAccess()
        {
            return new UserRepo();
        }

        public static IAuthC<User, string> UserAuthCheckerDataAccess()
        {
            return new UserRepo();
        }

        public static IRepo<Group, string, Group> GroupDataAccess()
        {
            return new GroupRepo();
        }

        public static IAuthC<Group, string> GroupAuthCheckerDataAccess()
        {
            return new GroupRepo();
        }

        public static IRepo<Donor, int, Donor> DonorDataAccess()
        {
            return new DonorRepo();
        }

        public static IAuthC<Donor, string> DonorAuthCheckerDataAccess()
        {
            return new DonorRepo();
        }

        public static IRepo<Token, string, Token> TokenDataAccess()
        {
            return new TokenRepo();
        }
    }
}
