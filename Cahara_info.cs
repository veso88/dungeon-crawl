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
    public partial class Cahara_info : Form
    {
        public Cahara_info()
        {
            InitializeComponent();
        }



      

        private void BackButtonCahara_Click_1(object sender, EventArgs e)
    
        {
            Character_Selection charsel654 = new Character_Selection();
            charsel654.Show();
            this.Hide();
        }
    }
    }
