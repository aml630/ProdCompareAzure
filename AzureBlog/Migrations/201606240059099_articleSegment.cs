namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class articleSegment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Segments", "ArticleModel_ArticleId", "dbo.Articles");
            DropIndex("dbo.Segments", new[] { "ArticleModel_ArticleId" });
            CreateTable(
                "dbo.ArticleSegments",
                c => new
                    {
                        ArticleSegmentId = c.Int(nullable: false, identity: true),
                        ArticleSegmentTitle = c.String(),
                        ArticleSegmentPar1 = c.String(),
                        ArticleSegmentPar2 = c.String(),
                        ArticleSegmentPar3 = c.String(),
                        ArticleSegmentPar4 = c.String(),
                        ArticleSegmentPar5 = c.String(),
                        ArticleSegmentPar6 = c.String(),
                        ArticleSegmentPar7 = c.String(),
                        ArticleSegmentImage = c.String(),
                        ArticleSegmentVideo = c.String(),
                        ArticleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleSegmentId)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: true)
                .Index(t => t.ArticleId);
            
            AddColumn("dbo.Products", "ArticleSegmentModel_ArticleSegmentId", c => c.Int());
            CreateIndex("dbo.Products", "ArticleSegmentModel_ArticleSegmentId");
            AddForeignKey("dbo.Products", "ArticleSegmentModel_ArticleSegmentId", "dbo.ArticleSegments", "ArticleSegmentId");
            DropColumn("dbo.Segments", "ArticleModel_ArticleId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Segments", "ArticleModel_ArticleId", c => c.Int());
            DropForeignKey("dbo.Products", "ArticleSegmentModel_ArticleSegmentId", "dbo.ArticleSegments");
            DropForeignKey("dbo.ArticleSegments", "ArticleId", "dbo.Articles");
            DropIndex("dbo.Products", new[] { "ArticleSegmentModel_ArticleSegmentId" });
            DropIndex("dbo.ArticleSegments", new[] { "ArticleId" });
            DropColumn("dbo.Products", "ArticleSegmentModel_ArticleSegmentId");
            DropTable("dbo.ArticleSegments");
            CreateIndex("dbo.Segments", "ArticleModel_ArticleId");
            AddForeignKey("dbo.Segments", "ArticleModel_ArticleId", "dbo.Articles", "ArticleId");
        }
    }
}
