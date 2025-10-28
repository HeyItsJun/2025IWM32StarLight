namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HousingWithUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Housings", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Housings", "UserId");
            AddForeignKey("dbo.Housings", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Housings", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Housings", new[] { "UserId" });
            DropColumn("dbo.Housings", "UserId");
        }
    }
}
