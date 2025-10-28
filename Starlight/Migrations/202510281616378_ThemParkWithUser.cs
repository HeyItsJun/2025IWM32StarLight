namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemParkWithUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ThemeParks", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.ThemeParks", "UserId");
            AddForeignKey("dbo.ThemeParks", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ThemeParks", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.ThemeParks", new[] { "UserId" });
            DropColumn("dbo.ThemeParks", "UserId");
        }
    }
}
