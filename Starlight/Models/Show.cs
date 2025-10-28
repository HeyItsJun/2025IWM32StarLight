using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Starlight.Models
{
    public class Show
    {
        [Key]
        public int ShowId { get; set; }
        public String Title { get; set; }
        public String Type { get; set; }
        public String Place {  get; set; }
        public String City_Village { get; set; }
        public String Province { get; set; }
        public String AutonumusCommunity { get; set; }
        public String Country { get; set; }
        public int Duration { get; set; }
        public List<DayOfWeek> DayOfWeeks { get; set; }
        public String DateRange { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public String Photo_Video { get; set; }
        public String UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}