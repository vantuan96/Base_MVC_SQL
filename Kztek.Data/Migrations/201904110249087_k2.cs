namespace Kztek.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuildingService",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        Note = c.String(maxLength: 500),
                        AreaCode = c.String(maxLength: 100, unicode: false),
                        IconPath = c.String(maxLength: 150),
                        UrlLocationPath = c.String(maxLength: 250),
                        IsParking = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UserCreatedId = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BuildingService");
        }
    }
}
