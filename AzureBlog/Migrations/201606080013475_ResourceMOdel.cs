namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResourceMOdel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        ResourceId = c.Int(nullable: false, identity: true),
                        ResourceTitle = c.String(),
                        ResourceLink = c.String(),
                        SegmentId = c.String(),
                        Segment_SegmentId = c.Int(),
                    })
                .PrimaryKey(t => t.ResourceId)
                .ForeignKey("dbo.Segments", t => t.Segment_SegmentId)
                .Index(t => t.Segment_SegmentId);
            
            AddColumn("dbo.Segments", "SegmentPar1", c => c.String());
            AddColumn("dbo.Segments", "SegmentPar4", c => c.String());
            AddColumn("dbo.Segments", "SegmentPar5", c => c.String());
            AddColumn("dbo.Segments", "SegmentPar6", c => c.String());
            AddColumn("dbo.Segments", "SegmentPar7", c => c.String());
            DropColumn("dbo.Segments", "SegmentBody");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Segments", "SegmentBody", c => c.String());
            DropForeignKey("dbo.Resources", "Segment_SegmentId", "dbo.Segments");
            DropIndex("dbo.Resources", new[] { "Segment_SegmentId" });
            DropColumn("dbo.Segments", "SegmentPar7");
            DropColumn("dbo.Segments", "SegmentPar6");
            DropColumn("dbo.Segments", "SegmentPar5");
            DropColumn("dbo.Segments", "SegmentPar4");
            DropColumn("dbo.Segments", "SegmentPar1");
            DropTable("dbo.Resources");
        }
    }
}
