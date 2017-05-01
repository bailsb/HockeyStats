using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyStats.Models
{
    class Goalie : Player
    {
        public Goalie(Team team, int number, string name, ShotHand shoots) : base(team, number, name, Position.Goalie, shoots)
        {
        }
    }
}
