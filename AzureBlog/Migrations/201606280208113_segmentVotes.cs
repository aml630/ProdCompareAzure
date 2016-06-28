namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class segmentVotes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArticleSegments", "Votes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ArticleSegments", "Votes");
        }
    }
}
