namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestaurantsWithUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Restaurants", "User_Id");
            AddForeignKey("dbo.Restaurants", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Restaurants", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Restaurants", new[] { "User_Id" });
            DropColumn("dbo.Restaurants", "User_Id");
        }
    }
}
