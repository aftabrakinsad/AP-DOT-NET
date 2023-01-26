using DAL.Interface;
using DAL.Repos;
using DAL.ZH_EF_CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        //Auth
        public static IAuth<Restaurant_login, int> AuthResloginCheckerDataAccess()
        {
            return new RestaurantloginRepo();
        }

        public static IAuth<Employee_login, int> AuthEmploginCheckerDataAccess()
        {
            return new EmployeeloginRepo();
        }

        public static IAuth<Company_login, int> AuthComloginCheckerDataAccess()
        {
            return new CompanyloginRepo();
        }

        //Repo
        public static IRepo<Restaurant_login, int, Restaurant_login> ResloginDataAccess()
        {
            return new RestaurantloginRepo();
        }

        public static IRepo<Employee_login, int, Employee_login> EmploginDataAccess()
        {
            return new EmployeeloginRepo();
        }

        public static IRepo<Company_login, int, Company_login> ComloginDataAccess()
        {
            return new CompanyloginRepo();
        }

        public static IRepo<Restaurant_Collection_request, int, Restaurant_Collection_request> ResCollReqDataAccess()
        {
            return new CollectionReqRepo();
        }

        public static IRepo<Collection_req_accept, int, Collection_req_accept> CollReqAcceptDataAccess()
        {
            return new CollectionReqAcceptRepo();
        }

        public static IRepo<Employee_info, int, Employee_info> EmpInfoDataAccess()
        {
            return new EmployeeInfoRepo();
        }

        public static IRepo<Token, string, Token> TokenDataAccess()
        {
            return new TokenRepo();
        }
    }
}