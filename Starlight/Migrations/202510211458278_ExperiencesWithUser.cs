namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExperiencesWithUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Experiences", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Experiences", "UserId");
            AddForeignKey("dbo.Experiences", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Experiences", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Experiences", new[] { "UserId" });
            DropColumn("dbo.Experiences", "UserId");
        }
    }
}
