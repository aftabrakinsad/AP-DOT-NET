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
        public static IRepo<Restaurant_login, int, Restaurant_login> ResloginDataAccess()
        {
            return new RestaurantloginRepo();
        }

        public static IRepo<Employee_login, int, Employee_login> EmploginDataAccess()
        {
            return new EmployeeloginRepo();
        }

        public static IRepo<Restaurant_Collection_request, int, Restaurant_Collection_request> ResCollReqDataAccess()
        {
            return new CollectionReqRepo();
        }
    }
}
