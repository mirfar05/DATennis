using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DATennis.Models
{
    public class Group
    {
        public int Id { get; set; }

        public virtual List<Player> Players { get; set; }
    }
}