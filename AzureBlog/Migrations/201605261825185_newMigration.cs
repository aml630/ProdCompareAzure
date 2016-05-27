namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
            AlterColumn("dbo.Products", "ProductName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false));
        }
    }
}
