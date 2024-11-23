namespace FlacDownloader.Views
{
    partial class UC_LocalFilesAlbum
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
            this.separator = new Guna.UI2.WinForms.Guna2Separator();
            this.pictureBoxAlbumCover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelArtsitName = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonOpenFolder = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.buttonSeeTracks = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).BeginInit();
            this.SuspendLayout();
            // 
            // separator
            // 
            this.separator.Location = new System.Drawing.Point(3, 43);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(764, 10);
            this.separator.TabIndex = 23;
            // 
            // pictureBoxAlbumCover
            // 
            this.pictureBoxAlbumCover.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlbumCover.BorderRadius = 6;
            this.pictureBoxAlbumCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAlbumCover.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlbumCover.ImageRotate = 0F;
            this.pictureBoxAlbumCover.Location = new System.Drawing.Point(3, 1);
            this.pictureBoxAlbumCover.Name = "pictureBoxAlbumCover";
            this.pictureBoxAlbumCover.Size = new System.Drawing.Size(42, 42);
            this.pictureBoxAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumCover.TabIndex = 22;
            this.pictureBoxAlbumCover.TabStop = false;
            this.pictureBoxAlbumCover.Click += new System.EventHandler(this.buttonSeeTracks_Click);
            // 
            // labelArtsitName
            // 
            this.labelArtsitName.AutoSize = true;
            this.labelArtsitName.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelArtsitName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtsitName.Location = new System.Drawing.Point(98, 27);
            this.labelArtsitName.Name = "labelArtsitName";
            this.labelArtsitName.Size = new System.Drawing.Size(81, 17);
            this.labelArtsitName.TabIndex = 21;
            this.labelArtsitName.Text = "Artist Name";
            this.labelArtsitName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelArtist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtist.Location = new System.Drawing.Point(51, 27);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(47, 17);
            this.labelArtist.TabIndex = 20;
            this.labelArtist.Text = "Artist •";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(51, 1);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(111, 21);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "Album Name";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Click += new System.EventHandler(this.buttonSeeTracks_Click);
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.BorderRadius = 8;
            this.buttonOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonOpenFolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonOpenFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonOpenFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonOpenFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonOpenFolder.ForeColor = System.Drawing.Color.White;
            this.buttonOpenFolder.Location = new System.Drawing.Point(692, 8);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(64, 35);
            this.buttonOpenFolder.TabIndex = 24;
            this.buttonOpenFolder.Text = "Open";
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(676, 8);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 35);
            this.guna2VSeparator1.TabIndex = 25;
            // 
            // buttonSeeTracks
            // 
            this.buttonSeeTracks.BorderRadius = 8;
            this.buttonSeeTracks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeeTracks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSeeTracks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSeeTracks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSeeTracks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSeeTracks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSeeTracks.ForeColor = System.Drawing.Color.White;
            this.buttonSeeTracks.Location = new System.Drawing.Point(585, 8);
            this.buttonSeeTracks.Name = "buttonSeeTracks";
            this.buttonSeeTracks.Size = new System.Drawing.Size(85, 35);
            this.buttonSeeTracks.TabIndex = 26;
            this.buttonSeeTracks.Text = "See tracks";
            this.buttonSeeTracks.Click += new System.EventHandler(this.buttonSeeTracks_Click);
            // 
            // UC_LocalFilesAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSeeTracks);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.pictureBoxAlbumCover);
            this.Controls.Add(this.labelArtsitName);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UC_LocalFilesAlbum";
            this.Size = new System.Drawing.Size(770, 55);
            this.Load += new System.EventHandler(this.UC_LocalFilesAlbum_Load);
            this.DoubleClick += new System.EventHandler(this.buttonSeeTracks_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator separator;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxAlbumCover;
        private System.Windows.Forms.Label labelArtsitName;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2Button buttonOpenFolder;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Button buttonSeeTracks;
    }
}
