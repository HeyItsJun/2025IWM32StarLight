namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewThemePark : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ThemeParks",
                c => new
                    {
                        ThemeParkId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TypeThemePark = c.String(),
                        City_Village = c.String(),
                        Province = c.String(),
                        AutonumusCommunity = c.String(),
                        Country = c.String(),
                        MinPrice = c.Double(nullable: false),
                        MaxPrice = c.Double(nullable: false),
                        Photo_Video = c.String(),
                    })
                .PrimaryKey(t => t.ThemeParkId);
            
            DropTable("dbo.ThemeParks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AmusementParks",
                c => new
                    {
                        AmusementParkId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TypeAmusementPark = c.String(),
                        City_Village = c.String(),
                        Province = c.String(),
                        AutonumusCommunity = c.String(),
                        Country = c.String(),
                        MinPrice = c.Int(nullable: false),
                        MaxPrice = c.Int(nullable: false),
                        Photo_Video = c.String(),
                    })
                .PrimaryKey(t => t.AmusementParkId);
            
            DropTable("dbo.ThemeParks");
        }
    }
}
