namespace DAL.Migrations
{
    using DAL.ZH_EF_CF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.ZH_EF_CF.ZeroHungerEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.ZH_EF_CF.ZeroHungerEntities context)
        {
            //Employee login info
            List<Employee_login> employee_Logins = new List<Employee_login>();
            for (int i = 1; i <= 1; i++)
            {
                employee_Logins.Add(new Employee_login()
                {
                    emp_id = 7956,
                    emp_pass = "88888"
                });
            }
            context.Employee_Logins.AddOrUpdate(employee_Logins.ToArray());

            //Restaurant login info
            List<Restaurant_login> restaurant_Logins = new List<Restaurant_login>();
            for (int i = 1; i <= 1; i++)
            {
                restaurant_Logins.Add(new Restaurant_login()
                {
                    res_id = 22222,
                    res_pass = "Restaurant"
                });
            }
            context.Restaurant_Logins.AddOrUpdate(restaurant_Logins.ToArray());
        }
    }
}
