namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shares : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "FbShares", c => c.Int(nullable: false));
            AddColumn("dbo.Categories", "TwitShares", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "TwitShares");
            DropColumn("dbo.Categories", "FbShares");
        }
    }
}
