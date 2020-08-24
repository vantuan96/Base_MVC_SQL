namespace Kztek.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MN_MenuFunction",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MenuName = c.String(nullable: false),
                        ControllerName = c.String(maxLength: 150),
                        MenuType = c.String(maxLength: 10),
                        ActionName = c.String(maxLength: 150),
                        Url = c.String(maxLength: 1000),
                        Icon = c.String(maxLength: 100),
                        ParentId = c.String(maxLength: 100),
                        Active = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        OrderNumber = c.Int(),
                        Breadcrumb = c.String(),
                        Dept = c.Int(),
                        IsSystem = c.Boolean(nullable: false),
                        ServiceId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_RoleMenu",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MenuId = c.String(maxLength: 128, unicode: false),
                        RoleId = c.String(maxLength: 128, unicode: false),
                        ServiceId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_Role",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        RoleName = c.String(maxLength: 128),
                        Description = c.String(),
                        ServiceId = c.String(),
                        Active = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_UserRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(maxLength: 128, unicode: false),
                        RoleId = c.String(maxLength: 128, unicode: false),
                        ServiceId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_User",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(maxLength: 255),
                        UserName = c.String(maxLength: 255),
                        Password = c.String(maxLength: 255, unicode: false),
                        PasswordSalat = c.String(maxLength: 255, unicode: false),
                        Address = c.String(maxLength: 500),
                        Phone = c.String(maxLength: 50),
                        Email = c.String(maxLength: 255, unicode: false),
                        ServiceIds = c.String(),
                        Admin = c.Boolean(nullable: false),
                        Active = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MN_User");
            DropTable("dbo.MN_UserRole");
            DropTable("dbo.MN_Role");
            DropTable("dbo.MN_RoleMenu");
            DropTable("dbo.MN_MenuFunction");
        }
    }
}
