using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Starlight.Models
{
    public class AmusementPark
    {
        [Key]

        public int AmusementParkId { get; set; }
        public String Name { get; set; }
        public String TypeAmusementPark { get; set; }
        public String City_Village { get; set; }
        public String Province { get; set; }
        public String AutonumusCommunity { get; set; }
        public String Country { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public String Photo_Video { get; set; }
    }
}