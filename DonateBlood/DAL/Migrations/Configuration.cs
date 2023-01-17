namespace DAL.Migrations
{
    using DAL.DB_EF_CF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.DB_EF_CF.BloodDonateEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.DB_EF_CF.BloodDonateEntities context)
        {
            List<Donor> donors = new List<Donor>();
            for (int i = 1; i <= 12; i++)
            {
                donors.Add(new Donor()
                {
                    Id = i,
                    Name = Guid.NewGuid().ToString().Substring(0, 5),
                    GrpId= i,
                });
            }
            context.Donors.AddOrUpdate(donors.ToArray());
        }
    }
}
