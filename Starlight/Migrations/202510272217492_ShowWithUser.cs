namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShowWithUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shows", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Shows", "User_Id");
            AddForeignKey("dbo.Shows", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shows", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Shows", new[] { "User_Id" });
            DropColumn("dbo.Shows", "User_Id");
        }
    }
}
