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
        public DbSet<Restaurant_login> Restaurant_Logins { get; set; }
        public DbSet<Company_login> Company_Logins { get; set; }
        public DbSet<Employee_login> Employee_Logins { get; set; }
        public DbSet<Restaurant_Collection_request> Restaurant_Collection_Requests { get; set; }
        public DbSet<Collection_req_accept> Collection_Req_Accepts { get; set; }
        public DbSet<Employee_info> Employee_Infos { get; set; }
        public DbSet<Token> Tokens { get; set; }
    }
}