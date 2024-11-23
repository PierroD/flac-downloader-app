namespace FlacDownloader.Views
{
    partial class UC_Home
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
            this.labelArtists = new System.Windows.Forms.Label();
            this.flowLayoutPanelArtists = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelDownloaded = new System.Windows.Forms.Label();
            this.buttonRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // labelArtists
            // 
            this.labelArtists.AutoSize = true;
            this.labelArtists.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelArtists.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtists.Location = new System.Drawing.Point(19, 68);
            this.labelArtists.Name = "labelArtists";
            this.labelArtists.Size = new System.Drawing.Size(118, 45);
            this.labelArtists.TabIndex = 7;
            this.labelArtists.Text = "Artists";
            this.labelArtists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelArtists
            // 
            this.flowLayoutPanelArtists.AutoScroll = true;
            this.flowLayoutPanelArtists.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelArtists.Location = new System.Drawing.Point(2, 126);
            this.flowLayoutPanelArtists.Name = "flowLayoutPanelArtists";
            this.flowLayoutPanelArtists.Size = new System.Drawing.Size(805, 210);
            this.flowLayoutPanelArtists.TabIndex = 8;
            this.flowLayoutPanelArtists.WrapContents = false;
            // 
            // flowLayoutPanelAlbums
            // 
            this.flowLayoutPanelAlbums.AutoScroll = true;
            this.flowLayoutPanelAlbums.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(2, 410);
            this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
            this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(805, 210);
            this.flowLayoutPanelAlbums.TabIndex = 10;
            this.flowLayoutPanelAlbums.WrapContents = false;
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelAlbum.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbum.Location = new System.Drawing.Point(19, 352);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(134, 45);
            this.labelAlbum.TabIndex = 9;
            this.labelAlbum.Text = "Albums";
            this.labelAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDownloaded
            // 
            this.labelDownloaded.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDownloaded.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownloaded.Location = new System.Drawing.Point(0, 0);
            this.labelDownloaded.Name = "labelDownloaded";
            this.labelDownloaded.Size = new System.Drawing.Size(808, 45);
            this.labelDownloaded.TabIndex = 11;
            this.labelDownloaded.Text = "Downloaded";
            this.labelDownloaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BorderRadius = 8;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Image = global::FlacDownloader.Properties.Resources.Refresh;
            this.buttonRefresh.Location = new System.Drawing.Point(8, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(38, 36);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelDownloaded);
            this.Controls.Add(this.flowLayoutPanelAlbums);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.flowLayoutPanelArtists);
            this.Controls.Add(this.labelArtists);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(808, 639);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelArtists;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelArtists;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelDownloaded;
        private Guna.UI2.WinForms.Guna2Button buttonRefresh;
    }
}
