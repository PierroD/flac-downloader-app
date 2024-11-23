namespace FlacDownloader.Views
{
    partial class UC_MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MusicPlayer));
            this.labelArtistName = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMusicTime = new System.Windows.Forms.Label();
            this.trackbarMusic = new Guna.UI2.WinForms.Guna2TrackBar();
            this.buttonPlayMusic = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBoxMusicPlaying = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonLoud = new Guna.UI2.WinForms.Guna2CircleButton();
            this.trackbarVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.windowsMediaPlayerSong = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusicPlaying)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayerSong)).BeginInit();
            this.SuspendLayout();
            // 
            // labelArtistName
            // 
            this.labelArtistName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtistName.Location = new System.Drawing.Point(138, 48);
            this.labelArtistName.Name = "labelArtistName";
            this.labelArtistName.Size = new System.Drawing.Size(111, 17);
            this.labelArtistName.TabIndex = 16;
            this.labelArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtist.Location = new System.Drawing.Point(91, 48);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(47, 17);
            this.labelArtist.TabIndex = 15;
            this.labelArtist.Text = "Artist •";
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(91, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(158, 28);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMusicTime
            // 
            this.labelMusicTime.AutoSize = true;
            this.labelMusicTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusicTime.Location = new System.Drawing.Point(454, 50);
            this.labelMusicTime.Name = "labelMusicTime";
            this.labelMusicTime.Size = new System.Drawing.Size(99, 17);
            this.labelMusicTime.TabIndex = 19;
            this.labelMusicTime.Text = "00 : 00 / 00 : 30";
            // 
            // trackbarMusic
            // 
            this.trackbarMusic.Enabled = false;
            this.trackbarMusic.Location = new System.Drawing.Point(224, 47);
            this.trackbarMusic.Maximum = 30;
            this.trackbarMusic.Name = "trackbarMusic";
            this.trackbarMusic.Size = new System.Drawing.Size(223, 23);
            this.trackbarMusic.TabIndex = 18;
            this.trackbarMusic.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackbarMusic.Value = 0;
            // 
            // buttonPlayMusic
            // 
            this.buttonPlayMusic.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlayMusic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPlayMusic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPlayMusic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPlayMusic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPlayMusic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPlayMusic.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPlayMusic.Image = global::FlacDownloader.Properties.Resources.Play;
            this.buttonPlayMusic.ImageOffset = new System.Drawing.Point(1, 0);
            this.buttonPlayMusic.Location = new System.Drawing.Point(323, 5);
            this.buttonPlayMusic.Name = "buttonPlayMusic";
            this.buttonPlayMusic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonPlayMusic.Size = new System.Drawing.Size(40, 40);
            this.buttonPlayMusic.TabIndex = 17;
            this.buttonPlayMusic.Click += new System.EventHandler(this.buttonPlayMusic_Click);
            // 
            // pictureBoxMusicPlaying
            // 
            this.pictureBoxMusicPlaying.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMusicPlaying.BorderRadius = 6;
            this.pictureBoxMusicPlaying.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxMusicPlaying.ImageRotate = 0F;
            this.pictureBoxMusicPlaying.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxMusicPlaying.Name = "pictureBoxMusicPlaying";
            this.pictureBoxMusicPlaying.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxMusicPlaying.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMusicPlaying.TabIndex = 13;
            this.pictureBoxMusicPlaying.TabStop = false;
            this.pictureBoxMusicPlaying.UseTransparentBackground = true;
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
            this.buttonLoud.Location = new System.Drawing.Point(744, 37);
            this.buttonLoud.Name = "buttonLoud";
            this.buttonLoud.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonLoud.Size = new System.Drawing.Size(38, 38);
            this.buttonLoud.TabIndex = 22;
            // 
            // trackbarVolume
            // 
            this.trackbarVolume.Location = new System.Drawing.Point(617, 48);
            this.trackbarVolume.Name = "trackbarVolume";
            this.trackbarVolume.Size = new System.Drawing.Size(121, 23);
            this.trackbarVolume.TabIndex = 21;
            this.trackbarVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackbarVolume.Value = 10;
            this.trackbarVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackbarVolume_Scroll);
            // 
            // windowsMediaPlayerSong
            // 
            this.windowsMediaPlayerSong.Enabled = true;
            this.windowsMediaPlayerSong.Location = new System.Drawing.Point(648, 4);
            this.windowsMediaPlayerSong.Name = "windowsMediaPlayerSong";
            this.windowsMediaPlayerSong.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayerSong.OcxState")));
            this.windowsMediaPlayerSong.Size = new System.Drawing.Size(75, 44);
            this.windowsMediaPlayerSong.TabIndex = 20;
            this.windowsMediaPlayerSong.Visible = false;
            this.windowsMediaPlayerSong.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.windowsMediaPlayerSong_PlayStateChange);
            // 
            // UC_MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLoud);
            this.Controls.Add(this.trackbarVolume);
            this.Controls.Add(this.windowsMediaPlayerSong);
            this.Controls.Add(this.labelMusicTime);
            this.Controls.Add(this.buttonPlayMusic);
            this.Controls.Add(this.trackbarMusic);
            this.Controls.Add(this.labelArtistName);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxMusicPlaying);
            this.Name = "UC_MusicPlayer";
            this.Size = new System.Drawing.Size(802, 90);
            this.Load += new System.EventHandler(this.UC_MusicPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusicPlaying)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayerSong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelArtistName;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxMusicPlaying;
        private System.Windows.Forms.Label labelMusicTime;
        private Guna.UI2.WinForms.Guna2CircleButton buttonPlayMusic;
        private Guna.UI2.WinForms.Guna2TrackBar trackbarMusic;
        private Guna.UI2.WinForms.Guna2CircleButton buttonLoud;
        private Guna.UI2.WinForms.Guna2TrackBar trackbarVolume;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayerSong;
    }
}
