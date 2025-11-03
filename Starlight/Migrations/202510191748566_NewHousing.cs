namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewHousing : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Housings",
                c => new
                    {
                        HousingId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City_Village = c.String(),
                        Province = c.String(),
                        AutonumusCommunity = c.String(),
                        Country = c.String(),
                        Type = c.String(),
                        Description = c.String(),
                        Parking = c.Boolean(nullable: false),
                        Pool = c.Boolean(nullable: false),
                        SportsFacility = c.Boolean(nullable: false),
                        ChildrenFacility = c.Boolean(nullable: false),
                        Photo_Video = c.String(),
                    })
                .PrimaryKey(t => t.HousingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Housings");
        }
    }
}
