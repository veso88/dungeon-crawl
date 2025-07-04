using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dungeon_crawl
{
    public partial class Bira : Form
    {
        private Timer closeTimer;
        public Bira()
        {
            InitializeComponent();
            // Initialize and configure the timer
            closeTimer = new Timer();
            closeTimer.Interval = 500;
            closeTimer.Tick += CloseTimer_Tick;
        }
        private void Bira_Load(object sender, EventArgs e)
        {
            closeTimer.Start();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Stop(); // Stop the timer
            this.Close();      // Close the form
        }
    }
}
