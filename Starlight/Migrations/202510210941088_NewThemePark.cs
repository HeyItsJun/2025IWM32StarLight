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
        }
        
        public override void Down()
        {
            DropTable("dbo.ThemeParks");
        }
    }
}
