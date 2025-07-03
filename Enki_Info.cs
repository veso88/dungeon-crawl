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
    public partial class Enki_Info : Form
    {
        public Enki_Info()
        {
            InitializeComponent();
        }

        private void BackButtonEnki_Click(object sender, EventArgs e)
        {
            Character_Selection charsel1 = new Character_Selection();
            charsel1.Show();
            this.Hide();
        }
    }
}
