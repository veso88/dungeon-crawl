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
    public partial class Character_Selection : Form
    {
        public Character_Selection()
        {
            InitializeComponent();
            Ragsni.MouseEnter += PictureBox1_MouseEnter;
            Ragsni.MouseLeave += PictureBox1_MouseLeave;
        }

private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Ragsni.BorderStyle = BorderStyle.FixedSingle; // Show border on hover
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Ragsni.BorderStyle = BorderStyle.None; // Remove border when not hovered
        }
        

        private void Ragsni_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InfoRag_Click(object sender, EventArgs e)
        {
            RagInfo info = new RagInfo();
            info.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
