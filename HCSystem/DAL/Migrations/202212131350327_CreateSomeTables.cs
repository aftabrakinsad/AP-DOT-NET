namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSomeTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientID = c.Int(nullable: false),
                        PatientName = c.String(nullable: false, maxLength: 100),
                        AppointCreateDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 100),
                        DoctorID = c.Int(nullable: false),
                        DoctorName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorID, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.PatientID)
                .Index(t => t.DoctorID);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 50),
                        Qualification = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 50),
                        Dob = c.String(nullable: false, maxLength: 50),
                        BloodGroup = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Hospitals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Location = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MedicineName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PatientCheckUps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PatientID = c.Int(nullable: false),
                        PatientName = c.String(nullable: false, maxLength: 100),
                        DoctorID = c.Int(nullable: false),
                        DoctorName = c.String(nullable: false, maxLength: 100),
                        CheckUpDate = c.DateTime(nullable: false),
                        Symptoms = c.String(nullable: false, maxLength: 100),
                        MedicineName = c.String(nullable: false, maxLength: 100),
                        No_Of_Days = c.Int(nullable: false),
                        MedTaking_Time = c.String(nullable: false, maxLength: 100),
                        BeforeMeal = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 36),
                        CreationTime = c.DateTime(nullable: false),
                        ExpirationTime = c.DateTime(),
                        Username = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "PatientID", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "DoctorID", "dbo.Doctors");
            DropIndex("dbo.Appointments", new[] { "DoctorID" });
            DropIndex("dbo.Appointments", new[] { "PatientID" });
            DropTable("dbo.Tokens");
            DropTable("dbo.Staffs");
            DropTable("dbo.PatientCheckUps");
            DropTable("dbo.Medicines");
            DropTable("dbo.Hospitals");
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appointments");
        }
    }
}
