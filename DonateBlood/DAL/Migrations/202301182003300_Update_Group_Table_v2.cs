namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Group_Table_v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "Group_Name", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Groups", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Groups", "Name", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Groups", "Group_Name");
        }
    }
}
