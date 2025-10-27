namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewVideo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        VideoId = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        Community = c.String(),
                        Province = c.String(),
                        Resource = c.String(),
                        TravelType = c.String(),
                        Format = c.String(),
                        LikedColors = c.String(),
                        Music = c.String(),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VideoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Videos");
        }
    }
}
