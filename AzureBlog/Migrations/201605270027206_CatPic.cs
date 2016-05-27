namespace AzureBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CatPic : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryPic", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryPic");
        }
    }
}
