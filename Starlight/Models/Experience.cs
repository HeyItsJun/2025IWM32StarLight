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
        // public Boolean CityTown { get; set; }
        public String Province { get; set; }
        public String Community { get; set; }
        public String Country { get; set; }
        public String Sponsort { get; set; } // agencia patrocinadora
        public double Price { get; set; }
        // días de la semana que se ofrece
        public int Duration { get; set; }
        public String[] Media { get; set; } // vídeos/fotos
    }
}