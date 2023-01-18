namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Donor_table_v1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Donors", "Donor_Name", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Donors", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Donors", "Name", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Donors", "Donor_Name");
        }
    }
}
