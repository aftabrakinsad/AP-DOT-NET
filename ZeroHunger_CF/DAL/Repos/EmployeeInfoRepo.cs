using DAL.Interface;
using DAL.ZH_EF_CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployeeInfoRepo : ERepo, IRepo<Employee_info, int, Employee_info>, IAuth<Employee_info, int>, IAuthC<Employee_info, int>
    {
        public Employee_info Add(Employee_info obj)
        {
            db.Employee_Infos.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public Employee_info Authenticate(int id, string pass)
        {
            var obj = db.Employee_Infos.FirstOrDefault(x => x.emp_id.Equals(id));
            return obj;
        }

        public bool Delete(int id)
        {
            var data = db.Employee_Infos.Find(id);
            db.Employee_Infos.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Employee_info> Get()
        {
            return db.Employee_Infos.ToList();
        }

        public Employee_info Get(int id)
        {
            return db.Employee_Infos.Find(id);
        }

        public Employee_info GetChecker(int id)
        {
            var obj = db.Employee_Infos.FirstOrDefault(x => x.emp_id.Equals(id));
            return obj;
        }

        public Employee_info Update(Employee_info obj)
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
