namespace Kztek.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class k5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MN_Camera",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CameraCode = c.String(),
                        CameraName = c.String(),
                        HttpURL = c.String(),
                        HttpPort = c.String(),
                        RtspPort = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        FrameRate = c.Int(),
                        Resolution = c.String(),
                        Channel = c.Int(),
                        CameraType = c.String(),
                        StreamType = c.String(),
                        SDK = c.String(),
                        Cgi = c.String(),
                        EnableRecording = c.Boolean(nullable: false),
                        PCID = c.String(),
                        PositionIndex = c.Int(),
                        Inactive = c.Boolean(nullable: false),
                        SortOrder = c.Int(nullable: false, identity: true),
                        ServiceId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_Gate",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        GateCode = c.String(),
                        GateName = c.String(),
                        Description = c.String(),
                        Inactive = c.Boolean(nullable: false),
                        SortOrder = c.Int(nullable: false, identity: true),
                        ServiceId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_HwController",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ControllerCode = c.String(),
                        ControllerName = c.String(),
                        CommunicationType = c.Int(),
                        Comport = c.String(),
                        Baudrate = c.String(),
                        LineTypeID = c.Int(),
                        Reader1Type = c.Int(),
                        Reader2Type = c.Int(),
                        PCID = c.String(),
                        Address = c.Int(nullable: false),
                        Inactive = c.Boolean(nullable: false),
                        SortOrder = c.Int(nullable: false, identity: true),
                        ServiceId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_Lane",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        LaneCode = c.String(),
                        LaneName = c.String(),
                        PCID = c.String(),
                        LaneType = c.Int(),
                        IsLoop = c.Boolean(nullable: false),
                        CheckPlateLevelIn = c.Int(nullable: false),
                        CheckPlateLevelOut = c.Int(nullable: false),
                        IsPrint = c.Boolean(nullable: false),
                        C1 = c.String(),
                        C2 = c.String(),
                        C3 = c.String(),
                        C4 = c.String(),
                        C5 = c.String(),
                        C6 = c.String(),
                        Controller = c.String(),
                        Inactive = c.Boolean(nullable: false),
                        SortOrder = c.Int(nullable: false, identity: true),
                        IsLED = c.Boolean(nullable: false),
                        IsFree = c.Boolean(nullable: false),
                        AccessForEachSide = c.Boolean(nullable: false),
                        ServiceId = c.String(),
                        SelfHostIP = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MN_PC",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ComputerCode = c.String(),
                        ComputerName = c.String(),
                        GateID = c.String(),
                        IPAddress = c.String(),
                        PicPathIn = c.String(),
                        PicPathOut = c.String(),
                        VideoPath = c.String(),
                        Description = c.String(),
                        Inactive = c.Boolean(nullable: false),
                        SortOrder = c.Int(nullable: false, identity: true),
                        ServiceId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MN_PC");
            DropTable("dbo.MN_Lane");
            DropTable("dbo.MN_HwController");
            DropTable("dbo.MN_Gate");
            DropTable("dbo.MN_Camera");
        }
    }
}
