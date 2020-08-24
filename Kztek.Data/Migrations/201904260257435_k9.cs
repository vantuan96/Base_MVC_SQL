namespace Kztek.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Yoga_SchedulePlanDetail",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ClassId = c.String(),
                        DayId = c.String(),
                        PlanId = c.String(),
                        HoursId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Yoga_SchedulePlan",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(maxLength: 500),
                        UserCreatedId = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Yoga_Package", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.Yoga_Schedule", "DayType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Yoga_Schedule", "DayType", c => c.String());
            DropColumn("dbo.Yoga_Package", "Type");
            DropTable("dbo.Yoga_SchedulePlan");
            DropTable("dbo.Yoga_SchedulePlanDetail");
        }
    }
}
