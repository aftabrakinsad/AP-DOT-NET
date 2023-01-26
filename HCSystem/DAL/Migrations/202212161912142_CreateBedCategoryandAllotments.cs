namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBedCategoryandAllotments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BedAllotments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientID = c.Int(nullable: false),
                        PatientName = c.String(nullable: false, maxLength: 50),
                        BedID = c.Int(nullable: false),
                        BedCategory = c.String(nullable: false, maxLength: 50),
                        BedName = c.String(nullable: false, maxLength: 50),
                        AllotmentDate = c.DateTime(nullable: false),
                        DischargeDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Beds", t => t.BedID, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.PatientID)
                .Index(t => t.BedID);
            
            CreateTable(
                "dbo.Beds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BedCategoryID = c.Int(nullable: false),
                        BedCategory = c.String(nullable: false),
                        BedName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BedCategories", t => t.BedCategoryID, cascadeDelete: true)
                .Index(t => t.BedCategoryID);
            
            CreateTable(
                "dbo.BedCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BedAllotments", "PatientID", "dbo.Patients");
            DropForeignKey("dbo.BedAllotments", "BedID", "dbo.Beds");
            DropForeignKey("dbo.Beds", "BedCategoryID", "dbo.BedCategories");
            DropIndex("dbo.Beds", new[] { "BedCategoryID" });
            DropIndex("dbo.BedAllotments", new[] { "BedID" });
            DropIndex("dbo.BedAllotments", new[] { "PatientID" });
            DropTable("dbo.BedCategories");
            DropTable("dbo.Beds");
            DropTable("dbo.BedAllotments");
        }
    }
}
