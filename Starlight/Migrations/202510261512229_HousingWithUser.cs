namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HousingWithUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Housings", "UserId", c => c.String(maxLength: 128));
            AddColumn("dbo.Restaurants", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Housings", "UserId");
            CreateIndex("dbo.Restaurants", "UserId");
            AddForeignKey("dbo.Housings", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Restaurants", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Restaurants", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Housings", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Restaurants", new[] { "UserId" });
            DropIndex("dbo.Housings", new[] { "UserId" });
            DropColumn("dbo.Restaurants", "UserId");
            DropColumn("dbo.Housings", "UserId");
        }
    }
}
