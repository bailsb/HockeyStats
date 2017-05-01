using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyStats.Models
{
    class Shot
    {
        public int XFromNet { get; private set; }
        public int YFromNet { get; private set; }

        public int XInNet { get; private set; }
        public int YInNet { get; private set; }

        public Player Player { get; private set; }
        public Goalie Goalie { get; private set; }

        public Team ShotFor { get; private set; }
        public Team ShotAgainst { get; private set; }

        public Game Game { get; private set; }
        public int Period { get; private set; }
    }
}
