using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Starlight.Models
{
    public class Video
    {
        [Key]
        public int VideoId { get; set; }
        public String Country { get; set; }
        public String Community { get; set; }
        public String Province { get; set; }
        public String Resource { get; set; }
        public String TravelType { get; set; }
        public String Format { get; set; }
        public String LikedColors { get; set; }
        public String Music { get; set; }
        public int Score { get; set; }
    }
}