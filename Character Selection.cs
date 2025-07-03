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
            Enkisni.MouseEnter += PictureBox2_MouseEnter;
            Enkisni.MouseLeave += PictureBox2_MouseLeave;
            Caharasni.MouseEnter += PictureBox3_MouseEnter;
            Caharasni.MouseLeave += PictureBox3_MouseLeave;
        }

private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Ragsni.BorderStyle = BorderStyle.FixedSingle; // Show border on hover
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Ragsni.BorderStyle = BorderStyle.None; // Remove border when not hovered
        }
        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Enkisni.BorderStyle = BorderStyle.FixedSingle; // Show border on hover
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Enkisni.BorderStyle = BorderStyle.None; // Remove border when not hovered
        }
        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            Caharasni.BorderStyle = BorderStyle.FixedSingle; // Show border on hover
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Caharasni.BorderStyle = BorderStyle.None; // Remove border when not hovered
        }

        private void Ragsni_Click(object sender, EventArgs e)
        {
            mapgrid spawn = new mapgrid();
            spawn.Show();
            this.Hide();
        }

        private void InfoRag_Click(object sender, EventArgs e)
        {
            RagInfo info = new RagInfo();
            info.Show();
            this.Hide();
        }

        private void Cahara_info_Click(object sender, EventArgs e)
        {

        }

        private void Enkisni_Click(object sender, EventArgs e)
        {
            
        }

        private void Enki_info_Click(object sender, EventArgs e)
        {
            Enki_Info informa = new Enki_Info();
            informa.Show();
            this.Hide();
            Image heroImage= Properties.Resources.
        }

        private void Character_Selection_Load(object sender, EventArgs e)
        {

        }
    }
}
