namespace Kztek.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k6 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MN_Class", newName: "Yoga_Class");
            RenameTable(name: "dbo.MN_CustomerRegister", newName: "Yoga_CustomerRegister");
            RenameTable(name: "dbo.MN_Package", newName: "Yoga_Package");
            RenameTable(name: "dbo.MN_Room", newName: "Yoga_Room");
            RenameTable(name: "dbo.MN_Schedule", newName: "Yoga_Schedule");
            RenameTable(name: "dbo.MN_Teacher", newName: "Yoga_Teacher");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Yoga_Teacher", newName: "MN_Teacher");
            RenameTable(name: "dbo.Yoga_Schedule", newName: "MN_Schedule");
            RenameTable(name: "dbo.Yoga_Room", newName: "MN_Room");
            RenameTable(name: "dbo.Yoga_Package", newName: "MN_Package");
            RenameTable(name: "dbo.Yoga_CustomerRegister", newName: "MN_CustomerRegister");
            RenameTable(name: "dbo.Yoga_Class", newName: "MN_Class");
        }
    }
}
