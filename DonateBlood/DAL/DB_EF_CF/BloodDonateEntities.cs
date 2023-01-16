﻿using DAL.DB_EF_CF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB_EF_CF
{
    public class BloodDonateEntities : DbContext
    {
        public BloodDonateEntities()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Token> Tokens { get; set; }
    }
}
