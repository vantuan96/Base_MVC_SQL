namespace Kztek.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WebInfo", "IsMifare", c => c.Boolean(nullable: false));
            AddColumn("dbo.WebInfo", "IsAddZero", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WebInfo", "IsAddZero");
            DropColumn("dbo.WebInfo", "IsMifare");
        }
    }
}
