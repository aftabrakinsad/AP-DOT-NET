namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tables_Created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Collection_req_accept",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        com_id = c.Int(nullable: false),
                        res_id = c.Int(nullable: false),
                        res_name = c.String(nullable: false, maxLength: 100),
                        c_name = c.String(nullable: false, maxLength: 100),
                        c_type = c.String(nullable: false, maxLength: 50),
                        accept_time = c.DateTime(nullable: false),
                        assign_emp = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Company_login", t => t.com_id, cascadeDelete: true)
                .ForeignKey("dbo.Restaurant_login", t => t.res_id, cascadeDelete: true)
                .Index(t => t.com_id)
                .Index(t => t.res_id);
            
            CreateTable(
                "dbo.Company_login",
                c => new
                    {
                        com_id = c.Int(nullable: false),
                        com_pass = c.String(nullable: false, maxLength: 50),
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.com_id);
            
            CreateTable(
                "dbo.Restaurant_login",
                c => new
                    {
                        res_id = c.Int(nullable: false),
                        res_pass = c.String(nullable: false, maxLength: 50),
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.res_id);
            
            CreateTable(
                "dbo.Restaurant_Collection_request",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        res_id = c.Int(nullable: false),
                        res_name = c.String(nullable: false),
                        c_id = c.Int(nullable: false),
                        c_name = c.String(nullable: false),
                        c_type = c.String(nullable: false),
                        c_req_opening_time = c.DateTime(nullable: false),
                        c_max_pre_time = c.String(nullable: false),
                        Operation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Restaurant_login", t => t.res_id, cascadeDelete: true)
                .Index(t => t.res_id);
            
            CreateTable(
                "dbo.Employee_info",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        emp_id = c.Int(nullable: false),
                        emp_name = c.String(nullable: false, maxLength: 100),
                        emp_status = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employee_login", t => t.emp_id, cascadeDelete: true)
                .Index(t => t.emp_id);
            
            CreateTable(
                "dbo.Employee_login",
                c => new
                    {
                        emp_id = c.Int(nullable: false),
                        emp_pass = c.String(nullable: false, maxLength: 50),
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.emp_id);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 36),
                        CreationTime = c.DateTime(nullable: false),
                        ExpirationTime = c.DateTime(),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee_info", "emp_id", "dbo.Employee_login");
            DropForeignKey("dbo.Collection_req_accept", "res_id", "dbo.Restaurant_login");
            DropForeignKey("dbo.Restaurant_Collection_request", "res_id", "dbo.Restaurant_login");
            DropForeignKey("dbo.Collection_req_accept", "com_id", "dbo.Company_login");
            DropIndex("dbo.Employee_info", new[] { "emp_id" });
            DropIndex("dbo.Restaurant_Collection_request", new[] { "res_id" });
            DropIndex("dbo.Collection_req_accept", new[] { "res_id" });
            DropIndex("dbo.Collection_req_accept", new[] { "com_id" });
            DropTable("dbo.Tokens");
            DropTable("dbo.Employee_login");
            DropTable("dbo.Employee_info");
            DropTable("dbo.Restaurant_Collection_request");
            DropTable("dbo.Restaurant_login");
            DropTable("dbo.Company_login");
            DropTable("dbo.Collection_req_accept");
        }
    }
}
