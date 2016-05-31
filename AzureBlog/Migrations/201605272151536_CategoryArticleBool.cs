namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryArticleBool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryArticle", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryArticle");
        }
    }
}
