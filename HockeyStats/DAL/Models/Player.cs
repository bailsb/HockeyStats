using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace HockeyStats.Models
{
    class Player
    {     
        public Team Team { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public ShotHand Shoots { get; set; }

        public Player(Team team, int number, string name, Position position, ShotHand shoots)
        {
            this.Team = team;
            this.Number = number;
            this.Name = name;
            this.Position = position;
            this.Shoots = shoots;
        }
    }
}
