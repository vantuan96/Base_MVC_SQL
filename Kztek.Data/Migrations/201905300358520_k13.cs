namespace Kztek.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yoga_SchedulePlanDetail", "TeacherId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Yoga_SchedulePlanDetail", "TeacherId");
        }
    }
}
