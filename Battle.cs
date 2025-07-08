using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dungeon_crawl
{
    public partial class Battle : Form
    {


        int selectedIndex = 0;
        Label[] menuOptions;

        void UpdateMenuHighlight()
        {
            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == selectedIndex)
                {
                    menuOptions[i].BackColor = Color.Yellow;  // Highlighted
                    menuOptions[i].ForeColor = Color.Black;
                }
                else
                {
                    menuOptions[i].BackColor = Color.Transparent;  // Normal
                    menuOptions[i].ForeColor = Color.White;
                }
            }

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                selectedIndex--;
                if (selectedIndex < 0) selectedIndex = menuOptions.Length - 1;
                UpdateMenuHighlight();
            }
            else if (e.KeyCode == Keys.Right)
            {
                selectedIndex++;
                if (selectedIndex >= menuOptions.Length) selectedIndex = 0;
                UpdateMenuHighlight();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                

                string selectedText = menuOptions[selectedIndex].Text;

                if (selectedText == "Fight")
                {
                    var fightForm = new FightForm();
                    fightForm.ShowDialog();
                    this.Hide();
                }
                else if (selectedText == "Item")
                {
                    var itemForm = new ItemForm();
                    itemForm.ShowDialog();
                    this.Hide();

                }
                else if (selectedText == "Talk")
                {
                    var talkForm = new TalkForm();
                    talkForm.ShowDialog();
                }
                else if (selectedText == "Flee")
                {
                    var fleeForm = new mapgrid();
                    fleeForm.ShowDialog();
                    this.Hide();
                    

                }



            }
        }

       



        public Battle()
        {
            InitializeComponent();
            menuOptions = new Label[] { label1, label2, label3, label4 };
            UpdateMenuHighlight();
            this.KeyPreview = true;  // Let form detect key presses first
            this.KeyDown += Form1_KeyDown;
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            if (Enemy.Health == 0)
            {
                Pobeda pobeda = new Pobeda();
                pobeda.Show();
                this.Close();
            }else if (Hero.health == 0)
            {
                YouDiedcs umrq = new YouDiedcs();
                umrq.Show();
                this.Close();
            }

                progressBar1.Value = Enemy.Health;
            progressBar2.Value = Hero.health;
           

        }
    }
}
