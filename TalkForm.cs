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
        public partial class TalkForm : Form
        {
            private List<string> dialogueLines;
            private int currentIndex = 0;
            private Label dialogueLabel;

            public TalkForm()
        {
            InitializeComponent();
            SetupDialogue();

        }
        private void SetupDialogue()
        {
            this.Width = 400;
            this.Height = 200;
            this.Text = "Talk / ACT";
            this.BackColor = System.Drawing.Color.Black;

            dialogueLabel = new Label
            {
                AutoSize = false,
                Width = this.ClientSize.Width - 40,
                Height = 100,
                Left = 20,
                Top = 50,
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.Transparent,
                Font = new System.Drawing.Font("Consolas", 12),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            this.Controls.Add(dialogueLabel);

            this.KeyPreview = true;
            this.KeyDown += TalkForm_KeyDown;

            // Example dialogue — customize this!
            dialogueLines = new List<string>
        {
            "Opitvash se da govorish s Pael Penchikliev",
            "Obache toi ima slabotokov mozuk",
            "Toi tweakva lekata",
            "Ti se chuvstvash neudobno",
            "Tva mojebi ne beshe mnogo efektivno"
        };

            ShowNextLine();
        }

        private void TalkForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Z)
            {
                ShowNextLine();
            }
        }

        private void ShowNextLine()
        {
            if (currentIndex < dialogueLines.Count)
            {
                dialogueLabel.Text = dialogueLines[currentIndex];
                currentIndex++;
            }
            else
            {
                this.Close(); // Exit when done
            }
        }
    }
}
