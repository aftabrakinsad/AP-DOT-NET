namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tables_Inserted : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Donors",
                c => new
                    {
                        Donor_ID = c.Int(nullable: false, identity: true),
                        Donor_Name = c.String(nullable: false, maxLength: 100),
                        Group_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Donor_ID)
                .ForeignKey("dbo.Groups", t => t.Group_Id, cascadeDelete: true)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Group_Id = c.Int(nullable: false, identity: true),
                        Group_Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Group_Id);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 36),
                        CreationTime = c.DateTime(nullable: false),
                        ExpirationTime = c.DateTime(),
                        Username = c.String(nullable: false, maxLength: 36),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        ID = c.Int(nullable: false),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Donors", "Group_Id", "dbo.Groups");
            DropIndex("dbo.Donors", new[] { "Group_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Tokens");
            DropTable("dbo.Groups");
            DropTable("dbo.Donors");
        }
    }
}
