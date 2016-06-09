namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResourceMOdel2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Resources", "Segment_SegmentId", "dbo.Segments");
            DropIndex("dbo.Resources", new[] { "Segment_SegmentId" });
            DropColumn("dbo.Resources", "SegmentId");
            RenameColumn(table: "dbo.Resources", name: "Segment_SegmentId", newName: "SegmentId");
            AlterColumn("dbo.Resources", "SegmentId", c => c.Int(nullable: false));
            AlterColumn("dbo.Resources", "SegmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Resources", "SegmentId");
            AddForeignKey("dbo.Resources", "SegmentId", "dbo.Segments", "SegmentId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Resources", "SegmentId", "dbo.Segments");
            DropIndex("dbo.Resources", new[] { "SegmentId" });
            AlterColumn("dbo.Resources", "SegmentId", c => c.Int());
            AlterColumn("dbo.Resources", "SegmentId", c => c.String());
            RenameColumn(table: "dbo.Resources", name: "SegmentId", newName: "Segment_SegmentId");
            AddColumn("dbo.Resources", "SegmentId", c => c.String());
            CreateIndex("dbo.Resources", "Segment_SegmentId");
            AddForeignKey("dbo.Resources", "Segment_SegmentId", "dbo.Segments", "SegmentId");
        }
    }
}
