namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class segmentPar2Par3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Segments", "SegmentPar2", c => c.String());
            AddColumn("dbo.Segments", "SegmentPar3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Segments", "SegmentPar3");
            DropColumn("dbo.Segments", "SegmentPar2");
        }
    }
}
