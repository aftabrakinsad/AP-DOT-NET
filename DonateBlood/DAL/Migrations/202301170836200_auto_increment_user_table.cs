namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class auto_increment_user_table : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "ID", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "ID", c => c.Int(nullable: false));
        }
    }
}
