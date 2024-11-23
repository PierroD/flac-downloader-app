namespace FlacDownloader.Views
{
    partial class UC_Track
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
            this.buttonAddToQueue = new Guna.UI2.WinForms.Guna2CircleButton();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelDurationValue = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelDateValue = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelArtistName = new System.Windows.Forms.Label();
            this.labelTrackName = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.pictureBoxTrackCover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.uC_MusicPlayer = new FlacDownloader.Views.UC_MusicPlayer();
            this.panelCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrackCover)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCover
            // 
            this.panelCover.Controls.Add(this.buttonAddToQueue);
            this.panelCover.Controls.Add(this.labelAlbumName);
            this.panelCover.Controls.Add(this.labelAlbum);
            this.panelCover.Controls.Add(this.labelDurationValue);
            this.panelCover.Controls.Add(this.labelDuration);
            this.panelCover.Controls.Add(this.labelDateValue);
            this.panelCover.Controls.Add(this.labelDate);
            this.panelCover.Controls.Add(this.labelArtistName);
            this.panelCover.Controls.Add(this.labelTrackName);
            this.panelCover.Controls.Add(this.labelArtist);
            this.panelCover.Controls.Add(this.pictureBoxTrackCover);
            this.panelCover.Location = new System.Drawing.Point(0, 0);
            this.panelCover.Name = "panelCover";
            this.panelCover.Size = new System.Drawing.Size(808, 235);
            this.panelCover.TabIndex = 17;
            // 
            // buttonAddToQueue
            // 
            this.buttonAddToQueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddToQueue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddToQueue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddToQueue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAddToQueue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAddToQueue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddToQueue.ForeColor = System.Drawing.Color.White;
            this.buttonAddToQueue.Image = global::FlacDownloader.Properties.Resources.Add;
            this.buttonAddToQueue.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonAddToQueue.Location = new System.Drawing.Point(737, 167);
            this.buttonAddToQueue.Name = "buttonAddToQueue";
            this.buttonAddToQueue.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonAddToQueue.Size = new System.Drawing.Size(50, 50);
            this.buttonAddToQueue.TabIndex = 31;
            this.buttonAddToQueue.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAlbumName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumName.Location = new System.Drawing.Point(282, 85);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(86, 17);
            this.labelAlbumName.TabIndex = 30;
            this.labelAlbumName.Text = "Album name";
            this.labelAlbumName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAlbumName.Click += new System.EventHandler(this.labelAlbumName_Click);
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbum.Location = new System.Drawing.Point(232, 85);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(54, 17);
            this.labelAlbum.TabIndex = 29;
            this.labelAlbum.Text = "Album •";
            // 
            // labelDurationValue
            // 
            this.labelDurationValue.AutoSize = true;
            this.labelDurationValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDurationValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurationValue.Location = new System.Drawing.Point(299, 164);
            this.labelDurationValue.Name = "labelDurationValue";
            this.labelDurationValue.Size = new System.Drawing.Size(57, 17);
            this.labelDurationValue.TabIndex = 28;
            this.labelDurationValue.Text = "duration";
            this.labelDurationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(232, 164);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(67, 17);
            this.labelDuration.TabIndex = 27;
            this.labelDuration.Text = "Duration •";
            // 
            // labelDateValue
            // 
            this.labelDateValue.AutoSize = true;
            this.labelDateValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDateValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateValue.Location = new System.Drawing.Point(276, 138);
            this.labelDateValue.Name = "labelDateValue";
            this.labelDateValue.Size = new System.Drawing.Size(35, 17);
            this.labelDateValue.TabIndex = 24;
            this.labelDateValue.Text = "Date";
            this.labelDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(232, 138);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(44, 17);
            this.labelDate.TabIndex = 23;
            this.labelDate.Text = "Date •";
            // 
            // labelArtistName
            // 
            this.labelArtistName.AutoSize = true;
            this.labelArtistName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelArtistName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtistName.Location = new System.Drawing.Point(279, 111);
            this.labelArtistName.Name = "labelArtistName";
            this.labelArtistName.Size = new System.Drawing.Size(79, 17);
            this.labelArtistName.TabIndex = 22;
            this.labelArtistName.Text = "Artist name";
            this.labelArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelArtistName.Click += new System.EventHandler(this.labelArtistName_Click);
            // 
            // labelTrackName
            // 
            this.labelTrackName.AutoSize = true;
            this.labelTrackName.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTrackName.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackName.Location = new System.Drawing.Point(224, 17);
            this.labelTrackName.Name = "labelTrackName";
            this.labelTrackName.Size = new System.Drawing.Size(302, 65);
            this.labelTrackName.TabIndex = 20;
            this.labelTrackName.Text = "Track name";
            this.labelTrackName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtist.Location = new System.Drawing.Point(232, 111);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(47, 17);
            this.labelArtist.TabIndex = 21;
            this.labelArtist.Text = "Artist •";
            // 
            // pictureBoxTrackCover
            // 
            this.pictureBoxTrackCover.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTrackCover.BorderRadius = 6;
            this.pictureBoxTrackCover.ImageRotate = 0F;
            this.pictureBoxTrackCover.Location = new System.Drawing.Point(18, 17);
            this.pictureBoxTrackCover.Name = "pictureBoxTrackCover";
            this.pictureBoxTrackCover.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxTrackCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTrackCover.TabIndex = 18;
            this.pictureBoxTrackCover.TabStop = false;
            this.pictureBoxTrackCover.UseTransparentBackground = true;
            // 
            // uC_MusicPlayer
            // 
            this.uC_MusicPlayer.Location = new System.Drawing.Point(3, 549);
            this.uC_MusicPlayer.Name = "uC_MusicPlayer";
            this.uC_MusicPlayer.Size = new System.Drawing.Size(802, 90);
            this.uC_MusicPlayer.TabIndex = 18;
            // 
            // UC_Track
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.uC_MusicPlayer);
            this.Controls.Add(this.panelCover);
            this.Name = "UC_Track";
            this.Size = new System.Drawing.Size(808, 639);
            this.Load += new System.EventHandler(this.UC_Track_Load);
            this.panelCover.ResumeLayout(false);
            this.panelCover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrackCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelCover;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxTrackCover;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelDurationValue;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelDateValue;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelArtistName;
        private System.Windows.Forms.Label labelTrackName;
        private System.Windows.Forms.Label labelArtist;
        private UC_MusicPlayer uC_MusicPlayer;
        private Guna.UI2.WinForms.Guna2CircleButton buttonAddToQueue;
    }
}
