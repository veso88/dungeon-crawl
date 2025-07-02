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
    public partial class RagInfo : Form
    {
        public RagInfo()
        {
            InitializeComponent();
        }

        private void BackButtonRag_Click(object sender, EventArgs e)
        {
            Character_Selection charsel = new Character_Selection();
            charsel.Show();
            this.Hide();
        }
    }
}
