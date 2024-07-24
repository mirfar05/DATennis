using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DATennis.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public int Ranking { get; set; }

        [Display(Name = "Year of Birth")]
        public int DobYear { get; set; }

        [Display(Name = "Month of Birth")]
        public int DobMonth { get; set; }

        [Display(Name = "Day of Birth")]
        public int DobDay { get; set; }

        [Display(Name = "Year Turned Pro")]
        public int TurnedProYear { get; set; }

        public string Weight { get; set; }

        public string Height { get; set; }

        public string Birthplace { get; set; }

        public string Residence { get; set; }

        public string Plays { get; set; }

        public string Coach { get; set; }

        [Display(Name = "Number of Singles Titles Won")]
        public int Singlestitles { get; set; }
    }
}