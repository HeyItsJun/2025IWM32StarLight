namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewShow : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        ShowId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Type = c.String(),
                        Place = c.String(),
                        City_Village = c.String(),
                        Province = c.String(),
                        AutonumusCommunity = c.String(),
                        Country = c.String(),
                        Duration = c.Int(nullable: false),
                        DateRange = c.String(),
                        MinPrice = c.Int(nullable: false),
                        MaxPrice = c.Int(nullable: false),
                        Photo_Video = c.String(),
                    })
                .PrimaryKey(t => t.ShowId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Shows");
        }
    }
}
