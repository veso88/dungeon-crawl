namespace dungeon_crawl
{
    partial class Enki_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RagInfoText = new System.Windows.Forms.TextBox();
            this.BackButtonRag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::dungeon_crawl.Properties.Resources.download__2_;
            this.pictureBox3.Location = new System.Drawing.Point(454, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(227, 334);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(74, 352);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(986, 44);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Enki -Magician";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RagInfoText
            // 
            this.RagInfoText.BackColor = System.Drawing.Color.Black;
            this.RagInfoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RagInfoText.Font = new System.Drawing.Font("Copperplate Gothic Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RagInfoText.ForeColor = System.Drawing.Color.White;
            this.RagInfoText.Location = new System.Drawing.Point(87, 402);
            this.RagInfoText.Multiline = true;
            this.RagInfoText.Name = "RagInfoText";
            this.RagInfoText.Size = new System.Drawing.Size(973, 60);
            this.RagInfoText.TabIndex = 5;
            this.RagInfoText.Text = "A shadowy practician of magic drawn to the dungeon by his thirst for knowledge";
            this.RagInfoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackButtonRag
            // 
            this.BackButtonRag.BackColor = System.Drawing.Color.Black;
            this.BackButtonRag.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButtonRag.ForeColor = System.Drawing.Color.White;
            this.BackButtonRag.Location = new System.Drawing.Point(298, 492);
            this.BackButtonRag.Name = "BackButtonRag";
            this.BackButtonRag.Size = new System.Drawing.Size(534, 82);
            this.BackButtonRag.TabIndex = 6;
            this.BackButtonRag.Text = "BACK";
            this.BackButtonRag.UseVisualStyleBackColor = false;
            this.BackButtonRag.Click += new System.EventHandler(this.BackButtonEnki_Click);
            // 
            // Enki_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.BackButtonRag);
            this.Controls.Add(this.RagInfoText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Enki_Info";
            this.Text = "Enki_Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox RagInfoText;
        private System.Windows.Forms.Button BackButtonRag;
    }
}