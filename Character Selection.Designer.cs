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
            this.InfoRag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Enki_info = new System.Windows.Forms.Label();
            this.Enkisni = new System.Windows.Forms.PictureBox();
            this.Caharasni = new System.Windows.Forms.PictureBox();
            this.Ragsni = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Enkisni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caharasni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ragsni)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoRag
            // 
            this.InfoRag.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoRag.Location = new System.Drawing.Point(69, 404);
            this.InfoRag.Name = "InfoRag";
            this.InfoRag.Size = new System.Drawing.Size(249, 71);
            this.InfoRag.TabIndex = 3;
            this.InfoRag.Text = "Ragnavaldir";
            this.InfoRag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoRag.Click += new System.EventHandler(this.InfoRag_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(778, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 71);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cahara";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Cahara_info_Click);
            // 
            // Enki_info
            // 
            this.Enki_info.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enki_info.Location = new System.Drawing.Point(432, 404);
            this.Enki_info.Name = "Enki_info";
            this.Enki_info.Size = new System.Drawing.Size(234, 75);
            this.Enki_info.TabIndex = 13;
            this.Enki_info.Text = "Enki";
            this.Enki_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Enki_info.Click += new System.EventHandler(this.Enki_info_Click);
            // 
            // Enkisni
            // 
            this.Enkisni.BackgroundImage = global::dungeon_crawl.Properties.Resources.download__2_;
            this.Enkisni.Location = new System.Drawing.Point(428, 67);
            this.Enkisni.Name = "Enkisni";
            this.Enkisni.Size = new System.Drawing.Size(227, 334);
            this.Enkisni.TabIndex = 2;
            this.Enkisni.TabStop = false;
            this.Enkisni.Click += new System.EventHandler(this.Enkisni_Click);
            // 
            // Caharasni
            // 
            this.Caharasni.BackgroundImage = global::dungeon_crawl.Properties.Resources.download__1_;
            this.Caharasni.Location = new System.Drawing.Point(784, 67);
            this.Caharasni.Name = "Caharasni";
            this.Caharasni.Size = new System.Drawing.Size(229, 334);
            this.Caharasni.TabIndex = 1;
            this.Caharasni.TabStop = false;
            this.Caharasni.Click += new System.EventHandler(this.Caharasni_Click);
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
            // Character_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1122, 545);
            this.Controls.Add(this.Enki_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoRag);
            this.Controls.Add(this.Enkisni);
            this.Controls.Add(this.Caharasni);
            this.Controls.Add(this.Ragsni);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Character_Selection";
            this.Text = "Character_Selection";
            this.Load += new System.EventHandler(this.Character_Selection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Enkisni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caharasni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ragsni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Ragsni;
        private System.Windows.Forms.PictureBox Caharasni;
        private System.Windows.Forms.PictureBox Enkisni;
        private System.Windows.Forms.Label InfoRag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Enki_info
            ;
    }
}