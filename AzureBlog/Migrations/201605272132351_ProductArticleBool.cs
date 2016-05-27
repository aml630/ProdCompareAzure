namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductArticleBool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductArticle", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductArticle");
        }
    }
}
