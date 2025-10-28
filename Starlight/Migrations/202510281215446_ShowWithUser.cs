namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShowWithUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shows", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Shows", "UserId");
            AddForeignKey("dbo.Shows", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shows", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Shows", new[] { "UserId" });
            DropColumn("dbo.Shows", "UserId");
        }
    }
}
