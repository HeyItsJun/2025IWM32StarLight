using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Starlight.Models
{
    public class Excursion
    {
        [Key]
        public int ExcursionId { get; set; }
        public String City_Village { get; set; }
        public String Province { get; set; }
        public String AutonumusCommunity { get; set; }
        public String Country { get; set; }
        public String Route { get; set; }
        public String Payment { get; set; }
        public String Agency { get; set; }
        public String Type { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }
        public String PhotoVideo { get; set; }
        public String DateRange { get; set; }
        public String UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}