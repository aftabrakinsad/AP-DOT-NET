using DAL.Interface;
using DAL.ZH_EF_CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployeeloginRepo : ERepo, IRepo<Employee_login, int, Employee_login>, IAuth<Employee_login, int>, IAuthC<Employee_login, int>
    {
        public Employee_login Add(Employee_login obj)
        {
            db.Employee_Logins.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public Employee_login Authenticate(int id, string pass)
        {
            var obj = db.Employee_Logins.FirstOrDefault(x => x.emp_id.Equals(id) && x.emp_pass.Equals(pass));
            return obj;
        }

        public bool Delete(int id)
        {
            var data = db.Employee_Logins.Find(id);
            db.Employee_Logins.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Employee_login> Get()
        {
            return db.Employee_Logins.ToList();
        }

        public Employee_login Get(int id)
        {
            return db.Employee_Logins.Find(id);
        }

        public Employee_login GetChecker(int id)
        {
            var obj = db.Employee_Logins.FirstOrDefault(x => x.emp_id.Equals(id));
            return obj;
        }

        public Employee_login Update(Employee_login obj)
        {
            var data = Get(obj.emp_id);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
