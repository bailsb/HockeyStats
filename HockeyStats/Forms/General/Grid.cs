using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HockeyStats.Forms;

namespace HockeyStats.Forms
{
    /// <summary>
    /// Normalized grid for determining location
    /// </summary>
    public class Grid
    {
        private const int ICE_HEIGHT = 1000;
        private const int ICE_WIDTH = 2000;
        private const int NET_HEIGHT = 720;
        private const int NET_WIDTH = 480;

        private GridType Type; 

        public Grid(GridType type)
        {
            this.Type = type;
        }
    }
}
