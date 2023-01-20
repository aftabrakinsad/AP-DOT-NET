using DAL.ZH_EF_CF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ZH_EF_CF
{
    internal class ZeroHungerEntities : DbContext
    {
        public DbSet<Restaurant_login> Reslogins { get; set; }
        public DbSet<Company_login> Comlogins { get; set; }
        public DbSet<Employee_login> Emplogins { get; set; }
        public DbSet<Restaurant_Collection_request> Rescolrequests { get; set; }
        public DbSet<Collection_req_accept> Colrequestaccepts { get; set; }
        public DbSet<Employee_info> Empinfos { get; set; }
    }
}