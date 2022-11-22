using DAL.Interfaces;
using DAL.Database;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Group, int, bool> GroupDataAccess()
        {
            return new GrpRepo();
            //return new GrpRepoV2();
        }
        public static IRepo<Donor, int, Donor> DonorDataAccess()
        {
            return new DonorRepo();
        }

        public static IRepo<User, string, User> UserDataAccess()
        {
            return new UserRepo();
        }
        public static IAuth AuthDataAccess()
        {
            return new UserRepo();
        }
    }
}
