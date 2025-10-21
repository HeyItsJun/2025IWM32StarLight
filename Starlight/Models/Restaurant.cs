using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Starlight.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantID { get; set; }
        public String Name { get; set; }
        public String CityTown { get; set; }
        public String Province { get; set; }
        public String Community { get; set; }
        public String Country { get; set; }
        public String FoodType { get; set; }
        public String Style { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public double AverageScore { get; set; }
        public List<String> Media { get; set; }
    }
}