namespace Kztek.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Yoga_CustomerAppointment",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        RegisterId = c.String(),
                        ServiceType = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        UserCreatedId = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateAppointment = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Yoga_CustomerRegisterEvent", "PackageType", c => c.String());
            AddColumn("dbo.Yoga_CustomerRegisterEvent", "isVisitDoctor", c => c.Boolean(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegisterEvent", "isSteam", c => c.Boolean(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegisterEvent", "isMassage", c => c.Boolean(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegisterEvent", "VisitDoctorQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegisterEvent", "VisitDoctorFrequency", c => c.Int(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegisterEvent", "SteamQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegisterEvent", "SteamFrequency", c => c.Int(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegisterEvent", "MassageQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegisterEvent", "MassageFrequency", c => c.Int(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegister", "PackageType", c => c.String());
            AddColumn("dbo.Yoga_CustomerRegister", "isVisitDoctor", c => c.Boolean(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegister", "isSteam", c => c.Boolean(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegister", "isMassage", c => c.Boolean(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegister", "VisitDoctorQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegister", "VisitDoctorFrequency", c => c.Int(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegister", "SteamQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegister", "SteamFrequency", c => c.Int(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegister", "MassageQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Yoga_CustomerRegister", "MassageFrequency", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Yoga_CustomerRegister", "MassageFrequency");
            DropColumn("dbo.Yoga_CustomerRegister", "MassageQuantity");
            DropColumn("dbo.Yoga_CustomerRegister", "SteamFrequency");
            DropColumn("dbo.Yoga_CustomerRegister", "SteamQuantity");
            DropColumn("dbo.Yoga_CustomerRegister", "VisitDoctorFrequency");
            DropColumn("dbo.Yoga_CustomerRegister", "VisitDoctorQuantity");
            DropColumn("dbo.Yoga_CustomerRegister", "isMassage");
            DropColumn("dbo.Yoga_CustomerRegister", "isSteam");
            DropColumn("dbo.Yoga_CustomerRegister", "isVisitDoctor");
            DropColumn("dbo.Yoga_CustomerRegister", "PackageType");
            DropColumn("dbo.Yoga_CustomerRegisterEvent", "MassageFrequency");
            DropColumn("dbo.Yoga_CustomerRegisterEvent", "MassageQuantity");
            DropColumn("dbo.Yoga_CustomerRegisterEvent", "SteamFrequency");
            DropColumn("dbo.Yoga_CustomerRegisterEvent", "SteamQuantity");
            DropColumn("dbo.Yoga_CustomerRegisterEvent", "VisitDoctorFrequency");
            DropColumn("dbo.Yoga_CustomerRegisterEvent", "VisitDoctorQuantity");
            DropColumn("dbo.Yoga_CustomerRegisterEvent", "isMassage");
            DropColumn("dbo.Yoga_CustomerRegisterEvent", "isSteam");
            DropColumn("dbo.Yoga_CustomerRegisterEvent", "isVisitDoctor");
            DropColumn("dbo.Yoga_CustomerRegisterEvent", "PackageType");
            DropTable("dbo.Yoga_CustomerAppointment");
        }
    }
}
