namespace dungeon_crawl
{
    partial class Cahara_info
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RagInfoText = new System.Windows.Forms.TextBox();
            this.BackButtonCahara = new System.Windows.Forms.Button();
            this.Caharasni = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Caharasni)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(98, 342);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(986, 44);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Cahara - Rogue";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RagInfoText
            // 
            this.RagInfoText.BackColor = System.Drawing.Color.Black;
            this.RagInfoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RagInfoText.Font = new System.Drawing.Font("Copperplate Gothic Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RagInfoText.ForeColor = System.Drawing.Color.White;
            this.RagInfoText.Location = new System.Drawing.Point(111, 415);
            this.RagInfoText.Multiline = true;
            this.RagInfoText.Name = "RagInfoText";
            this.RagInfoText.Size = new System.Drawing.Size(973, 60);
            this.RagInfoText.TabIndex = 6;
            this.RagInfoText.Text = "With a troubled youth and in dire need of money he isn\'t scared to venture in the" +
    " dungeons";
            this.RagInfoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackButtonCahara
            // 
            this.BackButtonCahara.BackColor = System.Drawing.Color.Black;
            this.BackButtonCahara.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButtonCahara.ForeColor = System.Drawing.Color.White;
            this.BackButtonCahara.Location = new System.Drawing.Point(320, 496);
            this.BackButtonCahara.Name = "BackButtonCahara";
            this.BackButtonCahara.Size = new System.Drawing.Size(534, 82);
            this.BackButtonCahara.TabIndex = 7;
            this.BackButtonCahara.Text = "BACK";
            this.BackButtonCahara.UseVisualStyleBackColor = false;
            this.BackButtonCahara.Click += new System.EventHandler(this.BackButtonCahara_Click_1);
            // 
            // Caharasni
            // 
            this.Caharasni.BackgroundImage = global::dungeon_crawl.Properties.Resources.download__1_;
            this.Caharasni.Location = new System.Drawing.Point(465, 2);
            this.Caharasni.Name = "Caharasni";
            this.Caharasni.Size = new System.Drawing.Size(229, 334);
            this.Caharasni.TabIndex = 2;
            this.Caharasni.TabStop = false;
            // 
            // Cahara_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.BackButtonCahara);
            this.Controls.Add(this.RagInfoText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Caharasni);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Cahara_info";
            this.Text = "Cahara_info";
            ((System.ComponentModel.ISupportInitialize)(this.Caharasni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Caharasni;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox RagInfoText;
        private System.Windows.Forms.Button BackButtonCahara;
    }
}