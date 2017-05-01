﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyStats.Models
{
    class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public List<Goalie> Goalies { get; set; }
    }
}
