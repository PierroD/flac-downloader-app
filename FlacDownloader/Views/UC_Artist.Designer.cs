namespace FlacDownloader.Views
{
    partial class UC_Artist
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
            this.panelCover = new Guna.UI2.WinForms.Guna2Panel();
            this.labelArtistName = new System.Windows.Forms.Label();
            this.pictureBoxArtistPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelAlbumNumber = new System.Windows.Forms.Label();
            this.labelFans = new System.Windows.Forms.Label();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.labelFanNumber = new System.Windows.Forms.Label();
            this.panelCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtistPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCover
            // 
            this.panelCover.Controls.Add(this.labelFanNumber);
            this.panelCover.Controls.Add(this.labelArtistName);
            this.panelCover.Controls.Add(this.labelAlbums);
            this.panelCover.Controls.Add(this.labelFans);
            this.panelCover.Controls.Add(this.pictureBoxArtistPicture);
            this.panelCover.Controls.Add(this.labelAlbumNumber);
            this.panelCover.Location = new System.Drawing.Point(0, 1);
            this.panelCover.Name = "panelCover";
            this.panelCover.Size = new System.Drawing.Size(808, 235);
            this.panelCover.TabIndex = 17;
            // 
            // labelArtistName
            // 
            this.labelArtistName.AutoSize = true;
            this.labelArtistName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelArtistName.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtistName.Location = new System.Drawing.Point(225, 31);
            this.labelArtistName.Name = "labelArtistName";
            this.labelArtistName.Size = new System.Drawing.Size(306, 65);
            this.labelArtistName.TabIndex = 6;
            this.labelArtistName.Text = "Artist name";
            this.labelArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxArtistPicture
            // 
            this.pictureBoxArtistPicture.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxArtistPicture.BorderRadius = 6;
            this.pictureBoxArtistPicture.ImageRotate = 0F;
            this.pictureBoxArtistPicture.Location = new System.Drawing.Point(19, 16);
            this.pictureBoxArtistPicture.Name = "pictureBoxArtistPicture";
            this.pictureBoxArtistPicture.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxArtistPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArtistPicture.TabIndex = 5;
            this.pictureBoxArtistPicture.TabStop = false;
            this.pictureBoxArtistPicture.UseTransparentBackground = true;
            // 
            // labelAlbumNumber
            // 
            this.labelAlbumNumber.AutoSize = true;
            this.labelAlbumNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAlbumNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumNumber.Location = new System.Drawing.Point(292, 96);
            this.labelAlbumNumber.Name = "labelAlbumNumber";
            this.labelAlbumNumber.Size = new System.Drawing.Size(94, 17);
            this.labelAlbumNumber.TabIndex = 18;
            this.labelAlbumNumber.Text = "Album number";
            this.labelAlbumNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFans
            // 
            this.labelFans.AutoSize = true;
            this.labelFans.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFans.Location = new System.Drawing.Point(233, 120);
            this.labelFans.Name = "labelFans";
            this.labelFans.Size = new System.Drawing.Size(43, 17);
            this.labelFans.TabIndex = 19;
            this.labelFans.Text = "Fans •";
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbums.Location = new System.Drawing.Point(233, 96);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(60, 17);
            this.labelAlbums.TabIndex = 17;
            this.labelAlbums.Text = "Albums •";
            // 
            // labelFanNumber
            // 
            this.labelFanNumber.AutoSize = true;
            this.labelFanNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFanNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFanNumber.Location = new System.Drawing.Point(282, 120);
            this.labelFanNumber.Name = "labelFanNumber";
            this.labelFanNumber.Size = new System.Drawing.Size(81, 17);
            this.labelFanNumber.TabIndex = 20;
            this.labelFanNumber.Text = "fans number";
            this.labelFanNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_Artist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelCover);
            this.Name = "UC_Artist";
            this.Size = new System.Drawing.Size(808, 639);
            this.Load += new System.EventHandler(this.UC_Artist_Load);
            this.panelCover.ResumeLayout(false);
            this.panelCover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtistPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelCover;
        private System.Windows.Forms.Label labelArtistName;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxArtistPicture;
        private System.Windows.Forms.Label labelFanNumber;
        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.Label labelFans;
        private System.Windows.Forms.Label labelAlbumNumber;
    }
}
