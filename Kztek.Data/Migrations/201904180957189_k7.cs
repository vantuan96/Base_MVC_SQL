namespace Kztek.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k7 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MN_CustomerRegisterEvent", newName: "Yoga_CustomerRegisterEvent");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Yoga_CustomerRegisterEvent", newName: "MN_CustomerRegisterEvent");
        }
    }
}
