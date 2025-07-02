namespace dungeon_crawl
{
    partial class Character_Selection
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Ragsni = new System.Windows.Forms.PictureBox();
            this.InfoRag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ragsni)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::dungeon_crawl.Properties.Resources.download__2_;
            this.pictureBox3.Location = new System.Drawing.Point(428, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(227, 334);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::dungeon_crawl.Properties.Resources.download__1_;
            this.pictureBox2.Location = new System.Drawing.Point(784, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 334);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Ragsni
            // 
            this.Ragsni.BackgroundImage = global::dungeon_crawl.Properties.Resources.download;
            this.Ragsni.Location = new System.Drawing.Point(75, 68);
            this.Ragsni.Name = "Ragsni";
            this.Ragsni.Size = new System.Drawing.Size(224, 333);
            this.Ragsni.TabIndex = 0;
            this.Ragsni.TabStop = false;
            this.Ragsni.Click += new System.EventHandler(this.Ragsni_Click);
            // 
            // InfoRag
            // 
            this.InfoRag.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoRag.Location = new System.Drawing.Point(86, 404);
            this.InfoRag.Name = "InfoRag";
            this.InfoRag.Size = new System.Drawing.Size(213, 40);
            this.InfoRag.TabIndex = 3;
            this.InfoRag.Text = "INFO";
            this.InfoRag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoRag.Click += new System.EventHandler(this.InfoRag_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(800, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "INFO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "INFO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Character_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1064, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoRag);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Ragsni);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Character_Selection";
            this.Text = "Character_Selection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ragsni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Ragsni;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label InfoRag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}