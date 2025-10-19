using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Starlight.Models
{
    public class Experience
    {
        [Key]
        public int ExperienceID { get; set; }
        public String ExperienceType { get; set; }
        public String Location { get; set; }
        public String Description { get; set; }
        public String LocationType { get; set; }
        public String CityTown { get; set; }
        public String Province { get; set; }
        public String Community { get; set; }
        public String Country { get; set; }
        public String Sponsor { get; set; }
        public double Price { get; set; }
        public List <DayOfWeek> DayOfWeeks { get; set; }
        public int Duration { get; set; }
        public List<String> Media { get; set; } 
    }
}