using DAL.Interface;
using DAL.ZH_EF_CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CompanyloginRepo : ERepo, IRepo<Company_login, int, Company_login>, IAuth<Company_login, int>, IAuthC<Company_login, int>
    {
        public Company_login Add(Company_login obj)
        {
            db.Company_Logins.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public Company_login Authenticate(int id, string pass)
        {
            var obj = db.Company_Logins.FirstOrDefault(x => x.com_id.Equals(id) && x.com_pass.Equals(pass));
            return obj;
        }

        public bool Delete(int id)
        {
            var data = db.Company_Logins.Find(id);
            db.Company_Logins.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Company_login> Get()
        {
            return db.Company_Logins.ToList();
        }

        public Company_login Get(int id)
        {
            return db.Company_Logins.Find(id);
        }

        public Company_login GetChecker(int id)
        {
            var obj = db.Company_Logins.FirstOrDefault(x => x.com_id.Equals(id));
            return obj;
        }

        public Company_login Update(Company_login obj)
        {
            var data = Get(obj.com_id);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
