namespace FlacDownloader.Views
{
    partial class UC_Album
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
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelArtistName = new System.Windows.Forms.Label();
            this.labelDateValue = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTracksNumber = new System.Windows.Forms.Label();
            this.labelTracks = new System.Windows.Forms.Label();
            this.labelDurationValue = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.panelCover = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanelResults = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLoud = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBoxAlbumCover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.uC_MusicPlayer = new FlacDownloader.Views.UC_MusicPlayer();
            this.buttonAddToQueue = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panelCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbum.Location = new System.Drawing.Point(229, 30);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(45, 17);
            this.labelAlbum.TabIndex = 3;
            this.labelAlbum.Text = "Album";
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAlbumName.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumName.Location = new System.Drawing.Point(221, 47);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(448, 65);
            this.labelAlbumName.TabIndex = 4;
            this.labelAlbumName.Text = "Album long name";
            this.labelAlbumName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtist.Location = new System.Drawing.Point(229, 112);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(47, 17);
            this.labelArtist.TabIndex = 8;
            this.labelArtist.Text = "Artist •";
            // 
            // labelArtistName
            // 
            this.labelArtistName.AutoSize = true;
            this.labelArtistName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelArtistName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtistName.Location = new System.Drawing.Point(276, 112);
            this.labelArtistName.Name = "labelArtistName";
            this.labelArtistName.Size = new System.Drawing.Size(79, 17);
            this.labelArtistName.TabIndex = 9;
            this.labelArtistName.Text = "Artist name";
            this.labelArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelArtistName.Click += new System.EventHandler(this.labelArtistName_Click);
            // 
            // labelDateValue
            // 
            this.labelDateValue.AutoSize = true;
            this.labelDateValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDateValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateValue.Location = new System.Drawing.Point(276, 139);
            this.labelDateValue.Name = "labelDateValue";
            this.labelDateValue.Size = new System.Drawing.Size(35, 17);
            this.labelDateValue.TabIndex = 11;
            this.labelDateValue.Text = "Date";
            this.labelDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(229, 139);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(44, 17);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Date •";
            // 
            // labelTracksNumber
            // 
            this.labelTracksNumber.AutoSize = true;
            this.labelTracksNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTracksNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTracksNumber.Location = new System.Drawing.Point(284, 165);
            this.labelTracksNumber.Name = "labelTracksNumber";
            this.labelTracksNumber.Size = new System.Drawing.Size(93, 17);
            this.labelTracksNumber.TabIndex = 13;
            this.labelTracksNumber.Text = "Tracks number";
            this.labelTracksNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTracks
            // 
            this.labelTracks.AutoSize = true;
            this.labelTracks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTracks.Location = new System.Drawing.Point(229, 165);
            this.labelTracks.Name = "labelTracks";
            this.labelTracks.Size = new System.Drawing.Size(53, 17);
            this.labelTracks.TabIndex = 12;
            this.labelTracks.Text = "Tracks •";
            // 
            // labelDurationValue
            // 
            this.labelDurationValue.AutoSize = true;
            this.labelDurationValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDurationValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurationValue.Location = new System.Drawing.Point(295, 189);
            this.labelDurationValue.Name = "labelDurationValue";
            this.labelDurationValue.Size = new System.Drawing.Size(57, 17);
            this.labelDurationValue.TabIndex = 15;
            this.labelDurationValue.Text = "duration";
            this.labelDurationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(229, 189);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(67, 17);
            this.labelDuration.TabIndex = 14;
            this.labelDuration.Text = "Duration •";
            // 
            // panelCover
            // 
            this.panelCover.Controls.Add(this.buttonAddToQueue);
            this.panelCover.Location = new System.Drawing.Point(0, 0);
            this.panelCover.Name = "panelCover";
            this.panelCover.Size = new System.Drawing.Size(808, 235);
            this.panelCover.TabIndex = 16;
            // 
            // flowLayoutPanelResults
            // 
            this.flowLayoutPanelResults.AutoScroll = true;
            this.flowLayoutPanelResults.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelResults.Location = new System.Drawing.Point(3, 235);
            this.flowLayoutPanelResults.Name = "flowLayoutPanelResults";
            this.flowLayoutPanelResults.Size = new System.Drawing.Size(802, 311);
            this.flowLayoutPanelResults.TabIndex = 17;
            // 
            // buttonLoud
            // 
            this.buttonLoud.BackColor = System.Drawing.Color.Transparent;
            this.buttonLoud.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLoud.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLoud.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLoud.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLoud.Enabled = false;
            this.buttonLoud.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoud.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLoud.Image = global::FlacDownloader.Properties.Resources.Voice;
            this.buttonLoud.ImageSize = new System.Drawing.Size(15, 15);
            this.buttonLoud.Location = new System.Drawing.Point(762, 587);
            this.buttonLoud.Name = "buttonLoud";
            this.buttonLoud.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonLoud.Size = new System.Drawing.Size(38, 38);
            this.buttonLoud.TabIndex = 26;
            // 
            // pictureBoxAlbumCover
            // 
            this.pictureBoxAlbumCover.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlbumCover.BorderRadius = 6;
            this.pictureBoxAlbumCover.ImageRotate = 0F;
            this.pictureBoxAlbumCover.Location = new System.Drawing.Point(16, 16);
            this.pictureBoxAlbumCover.Name = "pictureBoxAlbumCover";
            this.pictureBoxAlbumCover.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumCover.TabIndex = 0;
            this.pictureBoxAlbumCover.TabStop = false;
            this.pictureBoxAlbumCover.UseTransparentBackground = true;
            // 
            // uC_MusicPlayer
            // 
            this.uC_MusicPlayer.Location = new System.Drawing.Point(3, 549);
            this.uC_MusicPlayer.Name = "uC_MusicPlayer";
            this.uC_MusicPlayer.Size = new System.Drawing.Size(802, 90);
            this.uC_MusicPlayer.TabIndex = 27;
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
            this.buttonAddToQueue.TabIndex = 32;
            this.buttonAddToQueue.Click += new System.EventHandler(this.buttonAddToQueue_Click);
            // 
            // UC_Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.uC_MusicPlayer);
            this.Controls.Add(this.buttonLoud);
            this.Controls.Add(this.flowLayoutPanelResults);
            this.Controls.Add(this.labelDurationValue);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelTracksNumber);
            this.Controls.Add(this.labelTracks);
            this.Controls.Add(this.labelDateValue);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelArtistName);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.pictureBoxAlbumCover);
            this.Controls.Add(this.panelCover);
            this.Name = "UC_Album";
            this.Size = new System.Drawing.Size(808, 639);
            this.Load += new System.EventHandler(this.UC_Album_Load);
            this.panelCover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxAlbumCover;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelArtistName;
        private System.Windows.Forms.Label labelDateValue;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTracksNumber;
        private System.Windows.Forms.Label labelTracks;
        private System.Windows.Forms.Label labelDurationValue;
        private System.Windows.Forms.Label labelDuration;
        private Guna.UI2.WinForms.Guna2Panel panelCover;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResults;
        private Guna.UI2.WinForms.Guna2CircleButton buttonLoud;
        private UC_MusicPlayer uC_MusicPlayer;
        private Guna.UI2.WinForms.Guna2CircleButton buttonAddToQueue;
    }
}
