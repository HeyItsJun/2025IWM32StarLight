using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Starlight.Models
{
    public class ThemePark
    {
        [Key]

        public int ThemeParkId { get; set; }
        public String Name { get; set; }
        public String TypeThemePark { get; set; }
        public String City_Village { get; set; }
        public String Province { get; set; }
        public String AutonumusCommunity { get; set; }
        public String Country { get; set; }
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }
        public String Photo_Video { get; set; }
        public String UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}