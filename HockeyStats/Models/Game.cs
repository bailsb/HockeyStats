using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyStats.Models
{
    class Game
    {
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }

        public List<Shot> HomeShots { get; set; }
        public List<Shot> AwayShots { get; set; }

        public DateTime Date { get; set; }
    }
}
