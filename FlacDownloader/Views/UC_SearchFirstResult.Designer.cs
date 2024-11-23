namespace FlacDownloader.Views
{
    partial class UC_SearchFirstResult
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelArtsitName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.separator = new Guna.UI2.WinForms.Guna2Separator();
            this.buttonPlayMusic = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBoxAlbumCover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonAddToQueue = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(141, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(140, 30);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Music Name";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtist.Location = new System.Drawing.Point(141, 38);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(47, 17);
            this.labelArtist.TabIndex = 2;
            this.labelArtist.Text = "Artist •";
            // 
            // labelArtsitName
            // 
            this.labelArtsitName.AutoSize = true;
            this.labelArtsitName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelArtsitName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtsitName.Location = new System.Drawing.Point(188, 38);
            this.labelArtsitName.Name = "labelArtsitName";
            this.labelArtsitName.Size = new System.Drawing.Size(79, 17);
            this.labelArtsitName.TabIndex = 3;
            this.labelArtsitName.Text = "Artist name";
            this.labelArtsitName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelArtsitName.Click += new System.EventHandler(this.labelArtsitName_Click);
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(202, 108);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(81, 23);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "3:33";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separator
            // 
            this.separator.Location = new System.Drawing.Point(3, 137);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(764, 10);
            this.separator.TabIndex = 5;
            // 
            // buttonPlayMusic
            // 
            this.buttonPlayMusic.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlayMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayMusic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPlayMusic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPlayMusic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPlayMusic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPlayMusic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPlayMusic.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPlayMusic.Image = global::FlacDownloader.Properties.Resources.Play;
            this.buttonPlayMusic.ImageOffset = new System.Drawing.Point(1, 0);
            this.buttonPlayMusic.Location = new System.Drawing.Point(146, 81);
            this.buttonPlayMusic.Name = "buttonPlayMusic";
            this.buttonPlayMusic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonPlayMusic.Size = new System.Drawing.Size(50, 50);
            this.buttonPlayMusic.TabIndex = 7;
            this.buttonPlayMusic.Click += new System.EventHandler(this.buttonPlayMusic_Click);
            // 
            // pictureBoxAlbumCover
            // 
            this.pictureBoxAlbumCover.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlbumCover.BorderRadius = 6;
            this.pictureBoxAlbumCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAlbumCover.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlbumCover.ImageRotate = 0F;
            this.pictureBoxAlbumCover.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxAlbumCover.Name = "pictureBoxAlbumCover";
            this.pictureBoxAlbumCover.Size = new System.Drawing.Size(132, 132);
            this.pictureBoxAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumCover.TabIndex = 0;
            this.pictureBoxAlbumCover.TabStop = false;
            this.pictureBoxAlbumCover.UseTransparentBackground = true;
            this.pictureBoxAlbumCover.Click += new System.EventHandler(this.pictureBoxAlbumCover_Click);
            // 
            // buttonAddToQueue
            // 
            this.buttonAddToQueue.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddToQueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddToQueue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddToQueue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddToQueue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAddToQueue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAddToQueue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddToQueue.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddToQueue.Image = global::FlacDownloader.Properties.Resources.Add;
            this.buttonAddToQueue.Location = new System.Drawing.Point(705, 81);
            this.buttonAddToQueue.Name = "buttonAddToQueue";
            this.buttonAddToQueue.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonAddToQueue.Size = new System.Drawing.Size(50, 50);
            this.buttonAddToQueue.TabIndex = 8;
            this.buttonAddToQueue.Click += new System.EventHandler(this.buttonAddToQueue_Click);
            // 
            // UC_SearchFirstResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddToQueue);
            this.Controls.Add(this.buttonPlayMusic);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelArtsitName);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxAlbumCover);
            this.Name = "UC_SearchFirstResult";
            this.Size = new System.Drawing.Size(770, 150);
            this.Load += new System.EventHandler(this.UC_SearchFirstResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxAlbumCover;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelArtsitName;
        private System.Windows.Forms.Label labelTime;
        private Guna.UI2.WinForms.Guna2Separator separator;
        private Guna.UI2.WinForms.Guna2CircleButton buttonPlayMusic;
        private Guna.UI2.WinForms.Guna2CircleButton buttonAddToQueue;
    }
}
