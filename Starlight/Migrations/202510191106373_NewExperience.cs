namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewExperience : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        ExperienceID = c.Int(nullable: false, identity: true),
                        ExperienceType = c.String(),
                        Location = c.String(),
                        Description = c.String(),
                        LocationType = c.String(),
                        CityTown = c.String(),
                        Province = c.String(),
                        Community = c.String(),
                        Country = c.String(),
                        Sponsor = c.String(),
                        Price = c.Double(nullable: false),
                        Duration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExperienceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Experiences");
        }
    }
}
