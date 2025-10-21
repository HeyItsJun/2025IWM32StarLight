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
                        Name = c.String(),
                        CityTown = c.String(),
                        Province = c.String(),
                        Community = c.String(),
                        Country = c.String(),
                        FoodType = c.String(),
                        Style = c.String(),
                        MinPrice = c.Int(nullable: false),
                        MaxPrice = c.Int(nullable: false),
                        AverageScore = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.RestaurantID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Restaurants");
        }
    }
}
