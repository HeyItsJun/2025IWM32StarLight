namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewExcursion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Excursions",
                c => new
                    {
                        ExcursionId = c.Int(nullable: false, identity: true),
                        City_Village = c.String(),
                        Province = c.String(),
                        AutonumusCommunity = c.String(),
                        Country = c.String(),
                        Route = c.String(),
                        Payment = c.String(),
                        Agency = c.String(),
                        Type = c.String(),
                        Duration = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        PhotoVideo = c.String(),
                        DateRange = c.String(),
                    })
                .PrimaryKey(t => t.ExcursionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Excursions");
        }
    }
}
