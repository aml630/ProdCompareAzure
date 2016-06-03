namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addImageAndVideoToSegment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Segments", "SegmentImage", c => c.String());
            AddColumn("dbo.Segments", "SegmentVideo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Segments", "SegmentVideo");
            DropColumn("dbo.Segments", "SegmentImage");
        }
    }
}
