namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Segments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Segments",
                c => new
                    {
                        SegmentId = c.Int(nullable: false, identity: true),
                        SegmentTitle = c.String(),
                        SegmentBody = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SegmentId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Segments", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Segments", new[] { "CategoryId" });
            DropTable("dbo.Segments");
        }
    }
}
