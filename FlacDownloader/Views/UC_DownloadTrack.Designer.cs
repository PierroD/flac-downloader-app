namespace FlacDownloader.Views
{
    partial class UC_DownloadTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DownloadTrack));
            this.labelArtsitName = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.separator = new Guna.UI2.WinForms.Guna2Separator();
            this.pictureBoxAlbumCover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).BeginInit();
            this.SuspendLayout();
            // 
            // labelArtsitName
            // 
            this.labelArtsitName.AutoSize = true;
            this.labelArtsitName.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelArtsitName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtsitName.Location = new System.Drawing.Point(98, 29);
            this.labelArtsitName.Name = "labelArtsitName";
            this.labelArtsitName.Size = new System.Drawing.Size(81, 17);
            this.labelArtsitName.TabIndex = 11;
            this.labelArtsitName.Text = "Artist Name";
            this.labelArtsitName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtist.Location = new System.Drawing.Point(51, 29);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(47, 17);
            this.labelArtist.TabIndex = 10;
            this.labelArtist.Text = "Artist •";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(51, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(105, 21);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Music Name";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // separator
            // 
            this.separator.Location = new System.Drawing.Point(0, 45);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(764, 10);
            this.separator.TabIndex = 13;
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
            this.pictureBoxAlbumCover.Size = new System.Drawing.Size(42, 42);
            this.pictureBoxAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumCover.TabIndex = 12;
            this.pictureBoxAlbumCover.TabStop = false;
            this.pictureBoxAlbumCover.UseTransparentBackground = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BorderRadius = 8;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(717, 7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(38, 36);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // UC_DownloadTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.pictureBoxAlbumCover);
            this.Controls.Add(this.labelArtsitName);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelTitle);
            this.Name = "UC_DownloadTrack";
            this.Size = new System.Drawing.Size(770, 55);
            this.Load += new System.EventHandler(this.UC_DownloadTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxAlbumCover;
        private System.Windows.Forms.Label labelArtsitName;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2Separator separator;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
    }
}
