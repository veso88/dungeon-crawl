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
            InfoRag.MouseEnter += Inforag_MouseEnter;
            InfoRag.MouseLeave += Inforag_MouseLeave;
            Enki_info.MouseLeave += EnkiInfo_MouseLeave;
            Enki_info.MouseEnter += EnkiInfo_MouseEnter;
            CaharaInfo.MouseEnter += CaharaInfo_MouseEnter;
            CaharaInfo.MouseLeave += CaharaInfo_MouseLeave;
        }
       
private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Ragsni.BorderStyle = BorderStyle.FixedSingle; // Show border on hover
        }
 private void Inforag_MouseEnter(object sender, EventArgs e)
        {
            InfoRag.BorderStyle = BorderStyle.FixedSingle;
        }
        private void Inforag_MouseLeave(object sender, EventArgs e)
        {
            InfoRag.BorderStyle = BorderStyle.None;
        }
        private void EnkiInfo_MouseEnter(object sender, EventArgs e)
        {
            Enki_info.BorderStyle = BorderStyle.FixedSingle;
        }
        private void EnkiInfo_MouseLeave(object sender, EventArgs e)
        {
            Enki_info.BorderStyle = BorderStyle.None;
        }
        private void CaharaInfo_MouseEnter(object sender, EventArgs e)
        {
            CaharaInfo.BorderStyle = BorderStyle.FixedSingle;
        }
        private void CaharaInfo_MouseLeave(object sender, EventArgs e)
        {
            CaharaInfo.BorderStyle = BorderStyle.None;
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

        public void Ragsni_Click(object sender, EventArgs e)
        {
            mapgrid spawn = new mapgrid();
            spawn.Show();
            this.Hide();
           
 
        }

        public void InfoRag_Click(object sender, EventArgs e)
        {
            RagInfo info = new RagInfo();
            info.Show();
            this.Hide();
        }

        public void Cahara_info_Click(object sender, EventArgs e)
        {
            Cahara_info informac = new Cahara_info();
            informac.Show();
            this.Hide();
        }

        public void Enkisni_Click(object sender, EventArgs e)
        {
            mapgrid spawn = new mapgrid();
            spawn.Show();
            this.Hide();
           

        }

        public void Enki_info_Click(object sender, EventArgs e)
        {
            Enki_Info informa = new Enki_Info();
            informa.Show();
            this.Hide();
            
        }

        private void Character_Selection_Load(object sender, EventArgs e)
        {

        }

        private void Caharasni_Click(object sender, EventArgs e)
        {
            mapgrid spawn = new mapgrid();
            spawn.Show();
            this.Hide();
        }
    }
}
