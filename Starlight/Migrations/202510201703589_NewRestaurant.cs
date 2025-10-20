namespace Starlight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewRestaurant : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurants",
                c => new
                {
                    RestaurantID = c.Int(nullable: false, identity: true),
                    ExperienceType = c.String(),
                    Name = c.String(),
                    CityTown = c.String(),
                    Province = c.String(),
                    Community = c.String(),
                    Country = c.String(),
                    FoodType = c.String(),
                    Style = c.String(),
                    MinPrice = c.Double(nullable: false),
                    MaxPrice = c.Double(nullable: false),
                    AverageScore = c.Double()
                })
                .PrimaryKey(t => t.RestaurantID);
        }
        
        public override void Down()
        {
            DropTable("dbo.Restaurants");
        }
    }
}
