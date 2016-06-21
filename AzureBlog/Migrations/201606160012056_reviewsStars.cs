namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reviewsStars : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "ReviewStars", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "ReviewStars");
        }
    }
}
