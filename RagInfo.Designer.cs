namespace dungeon_crawl
{
    partial class RagInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RagInfoText = new System.Windows.Forms.TextBox();
            this.BackButtonRag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::dungeon_crawl.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(429, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 333);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(59, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(986, 44);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Ragnavaldir";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RagInfoText
            // 
            this.RagInfoText.BackColor = System.Drawing.Color.Black;
            this.RagInfoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RagInfoText.Font = new System.Drawing.Font("Copperplate Gothic Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RagInfoText.ForeColor = System.Drawing.Color.White;
            this.RagInfoText.Location = new System.Drawing.Point(59, 395);
            this.RagInfoText.Multiline = true;
            this.RagInfoText.Name = "RagInfoText";
            this.RagInfoText.Size = new System.Drawing.Size(973, 60);
            this.RagInfoText.TabIndex = 3;
            this.RagInfoText.Text = "A great warrior , whose village was burnt down by wealthy royalty. Now he is seek" +
    "ing riches and power inside the dungeon to inact his revenge.";
            this.RagInfoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackButtonRag
            // 
            this.BackButtonRag.BackColor = System.Drawing.Color.Black;
            this.BackButtonRag.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButtonRag.ForeColor = System.Drawing.Color.White;
            this.BackButtonRag.Location = new System.Drawing.Point(287, 461);
            this.BackButtonRag.Name = "BackButtonRag";
            this.BackButtonRag.Size = new System.Drawing.Size(534, 82);
            this.BackButtonRag.TabIndex = 4;
            this.BackButtonRag.Text = "BACK";
            this.BackButtonRag.UseVisualStyleBackColor = false;
            this.BackButtonRag.Click += new System.EventHandler(this.BackButtonRag_Click);
            // 
            // RagInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1096, 555);
            this.Controls.Add(this.BackButtonRag);
            this.Controls.Add(this.RagInfoText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RagInfo";
            this.Text = "RagInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox RagInfoText;
        private System.Windows.Forms.Button BackButtonRag;
    }
}