namespace Kztek.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MN_Card",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CardNo = c.String(),
                        CardNumber = c.String(),
                        ServiceId = c.String(),
                        UserCreatedId = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_Class",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        PackageId = c.String(),
                        ScheduleIds = c.String(),
                        TeacherIds = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UserCreatedId = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_CustomerGroup",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                        Active = c.Boolean(nullable: false),
                        UserCreatedId = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_CustomerRegisterEvent",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        RegisterId = c.String(),
                        PackageId = c.String(),
                        ClassId = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        EventType = c.Int(nullable: false),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        UserCreatedId = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_CustomerRegister",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        RegisterCode = c.String(),
                        CustomerId = c.String(),
                        CustomerName = c.String(),
                        CustomerMobile = c.String(),
                        CustomerEmail = c.String(),
                        CustomerAddress = c.String(),
                        CustomerImagePath = c.String(),
                        PackageId = c.String(),
                        SheduleIds = c.String(),
                        ClassId = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        PriceConfig = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantityConfig = c.Int(nullable: false),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        Note = c.String(),
                        CardNo = c.String(),
                        CardNumber = c.String(),
                        Status = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UserCreatedId = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_Customer",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Avatar = c.String(),
                        Gender = c.Boolean(nullable: false),
                        CustomerGroupId = c.String(),
                        Note = c.String(maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                        Status = c.Int(nullable: false),
                        UserCreatedId = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_Package",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        Note = c.String(maxLength: 500),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        TimeConfig = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Active = c.Boolean(nullable: false),
                        UserCreatedId = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_Room",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        Note = c.String(maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                        Status = c.Int(nullable: false),
                        UserCreatedId = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_Schedule",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        Note = c.String(maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                        UserCreatedId = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DayType = c.String(),
                        Hours = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_Teacher",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Avatar = c.String(),
                        Note = c.String(maxLength: 500),
                        IsDeleted = c.Boolean(nullable: false),
                        Status = c.Int(nullable: false),
                        UserCreatedId = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MN_Teacher");
            DropTable("dbo.MN_Schedule");
            DropTable("dbo.MN_Room");
            DropTable("dbo.MN_Package");
            DropTable("dbo.MN_Customer");
            DropTable("dbo.MN_CustomerRegister");
            DropTable("dbo.MN_CustomerRegisterEvent");
            DropTable("dbo.MN_CustomerGroup");
            DropTable("dbo.MN_Class");
            DropTable("dbo.MN_Card");
        }
    }
}
