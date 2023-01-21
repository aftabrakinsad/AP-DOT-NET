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
            //Company login info
            List<Company_login> company_Logins = new List<Company_login>();
            for (int i = 1; i <= 1; i++)
            {
                company_Logins.Add(new Company_login()
                {
                    com_id = 99999,
                    com_pass = "Company"
                });
            }
            context.Company_Logins.AddOrUpdate(company_Logins.ToArray());

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

            //Employee info
            List<Employee_info> employee_Infos = new List<Employee_info>();
            for (int i = 1; i <= 1; i++)
            {
                employee_Infos.Add(new Employee_info()
                {
                    emp_id = 7956,
                    emp_name = "Rakin Sad Aftab",
                    emp_status = "Free"
                });
            }
            context.Employee_Infos.AddOrUpdate(employee_Infos.ToArray());

            //Collection Request by Restaurant info
            List<Restaurant_Collection_request> restaurant_Collection_Requests = new List<Restaurant_Collection_request>();
            for (int i = 1; i <= 1; i++)
            {
                restaurant_Collection_Requests.Add(new Restaurant_Collection_request()
                {
                    res_id = 22222,
                    res_name = "XXYY",
                    c_id = i,
                    c_name = "Burger",
                    c_type = "Fast Food",
                    c_req_opening_time = DateTime.Now,
                    c_max_pre_time = "1 Hour"
                });
            }
            context.Restaurant_Collection_Requests.AddOrUpdate(restaurant_Collection_Requests.ToArray());

            //Collection Request Accept info
            List<Collection_req_accept> collection_Req_Accepts = new List<Collection_req_accept>();
            for (int i = 1; i <= 1; i++)
            {
                collection_Req_Accepts.Add(new Collection_req_accept()
                {
                    com_id = 99999,
                    res_id = 22222,
                    res_name = "XXYY",
                    c_name = "Burger",
                    c_type = "Fast Food",
                    accept_time = DateTime.Now,
                    assign_emp = "Rakin Sad Aftab"
                });
            }
            context.Collection_Req_Accepts.AddOrUpdate(collection_Req_Accepts.ToArray());
        }
    }
}