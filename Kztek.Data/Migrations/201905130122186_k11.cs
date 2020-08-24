namespace Kztek.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Spa_CustomerRegisterEvent",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        RegisterId = c.String(),
                        PackageId = c.String(),
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
                "dbo.Spa_CustomerRegister",
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
                "dbo.Spa_Package",
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
                "dbo.Spa_Room",
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Spa_Room");
            DropTable("dbo.Spa_Package");
            DropTable("dbo.Spa_CustomerRegister");
            DropTable("dbo.Spa_CustomerRegisterEvent");
        }
    }
}
