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
    public partial class ItemForm : Form
    {
        int clickcount = 0;
        public ItemForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickcount++;
            new Bira().ShowDialog();
            if (clickcount > 4)
            {
                Piqnka piqn = new Piqnka();
                    piqn.Show();
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Battle bitka = new Battle();
            this.Hide();
            bitka.Show();
        }
    }
}
