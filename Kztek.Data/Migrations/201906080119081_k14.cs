namespace Kztek.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k14 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yoga_CustomerRegister", "CustomerGroupId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Yoga_CustomerRegister", "CustomerGroupId");
        }
    }
}
