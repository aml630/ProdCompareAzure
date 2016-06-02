namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryTitleAndBody : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryArticleTitle", c => c.String());
            AddColumn("dbo.Categories", "CategoryArticleBody", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryArticleBody");
            DropColumn("dbo.Categories", "CategoryArticleTitle");
        }
    }
}
