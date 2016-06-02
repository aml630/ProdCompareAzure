namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryPostStuff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Intro", c => c.String());
            AddColumn("dbo.Categories", "Sec1Title", c => c.String());
            AddColumn("dbo.Categories", "Sec1Body", c => c.String());
            AddColumn("dbo.Categories", "Sec2Title", c => c.String());
            AddColumn("dbo.Categories", "Sec2Body", c => c.String());
            AddColumn("dbo.Categories", "Sec3Title", c => c.String());
            AddColumn("dbo.Categories", "Sec3Body", c => c.String());
            DropColumn("dbo.Categories", "CategoryArticleTitle");
            DropColumn("dbo.Categories", "CategoryArticleBody");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryArticleBody", c => c.String());
            AddColumn("dbo.Categories", "CategoryArticleTitle", c => c.String());
            DropColumn("dbo.Categories", "Sec3Body");
            DropColumn("dbo.Categories", "Sec3Title");
            DropColumn("dbo.Categories", "Sec2Body");
            DropColumn("dbo.Categories", "Sec2Title");
            DropColumn("dbo.Categories", "Sec1Body");
            DropColumn("dbo.Categories", "Sec1Title");
            DropColumn("dbo.Categories", "Intro");
        }
    }
}
