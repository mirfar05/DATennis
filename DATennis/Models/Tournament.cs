using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DATennis.Models
{
    public class Tournament
    {
        public int Id { get; set; }

        public virtual List<Group> Groups { get; set; }
    }
}