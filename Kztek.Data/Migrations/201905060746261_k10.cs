namespace Kztek.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BuildingService", "InOutLimit", c => c.Int(nullable: false));
            AddColumn("dbo.BuildingService", "TimeLimit", c => c.Boolean(nullable: false));
            AddColumn("dbo.BuildingService", "InOutType", c => c.String());
            AddColumn("dbo.Yoga_CustomerRegister", "IsTime", c => c.Boolean(nullable: false));
            AddColumn("dbo.Yoga_Package", "IsTime", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Yoga_Package", "IsTime");
            DropColumn("dbo.Yoga_CustomerRegister", "IsTime");
            DropColumn("dbo.BuildingService", "InOutType");
            DropColumn("dbo.BuildingService", "TimeLimit");
            DropColumn("dbo.BuildingService", "InOutLimit");
        }
    }
}
