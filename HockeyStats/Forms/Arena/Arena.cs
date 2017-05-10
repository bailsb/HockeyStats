using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeyStats
{
    public partial class Arena : Form
    {
        public Grid ArenaGrid;

        public Arena()
        {
            InitializeComponent();
        }

        private void Arena_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;

            ArenaGrid = new Grid();
        }

        private void RinkBackground_Click(object sender, EventArgs e)
        {
            ShotTracker.TrackShot(sender, e);
        }

        private void SizeGrid(Grid grid)
        {
            
        }
    }
}
