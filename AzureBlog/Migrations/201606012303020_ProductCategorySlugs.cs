namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductCategorySlugs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategorySlug", c => c.String());
            AddColumn("dbo.Products", "ProductSlug", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductSlug");
            DropColumn("dbo.Categories", "CategorySlug");
        }
    }
}
