using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Starlight.Models
{
    public class Housing
    {
        [Key]

        public int HousingId { get; set; }
        public String Name { get; set; }
        public String City_Village { get; set; }
        public String Province { get; set; }
        public String AutonumusCommunity { get; set; }
        public String Country { get; set; }
        public String Type { get; set; }
        public String Description { get; set; }
        public bool Parking { get; set; }
        public bool Pool { get; set; }
        public bool SportsFacility { get; set; }
        public bool ChildrenFacility { get; set; }
        public String Photo_Video { get; set; }

        public String UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}