namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reviewsProductId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "ProductId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "ProductId");
        }
    }
}
