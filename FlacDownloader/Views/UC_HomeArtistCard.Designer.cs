namespace FlacDownloader.Views
{
    partial class UC_HomeArtistCard
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
            this.components = new System.ComponentModel.Container();
            this.elipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBoxArtist = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBoxDefaultIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelArtistName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefaultIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseForm
            // 
            this.elipseForm.BorderRadius = 12;
            this.elipseForm.TargetControl = this;
            // 
            // pictureBoxArtist
            // 
            this.pictureBoxArtist.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxArtist.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxArtist.ImageRotate = 0F;
            this.pictureBoxArtist.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxArtist.Name = "pictureBoxArtist";
            this.pictureBoxArtist.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxArtist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArtist.TabIndex = 0;
            this.pictureBoxArtist.TabStop = false;
            this.pictureBoxArtist.UseTransparentBackground = true;
            this.pictureBoxArtist.DoubleClick += new System.EventHandler(this.OnCard_DoubleClick);
            // 
            // pictureBoxDefaultIcon
            // 
            this.pictureBoxDefaultIcon.Image = global::FlacDownloader.Properties.Resources.Artist;
            this.pictureBoxDefaultIcon.ImageRotate = 0F;
            this.pictureBoxDefaultIcon.Location = new System.Drawing.Point(65, 65);
            this.pictureBoxDefaultIcon.Name = "pictureBoxDefaultIcon";
            this.pictureBoxDefaultIcon.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxDefaultIcon.TabIndex = 1;
            this.pictureBoxDefaultIcon.TabStop = false;
            // 
            // labelArtistName
            // 
            this.labelArtistName.AutoSize = true;
            this.labelArtistName.BackColor = System.Drawing.Color.Transparent;
            this.labelArtistName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelArtistName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtistName.Location = new System.Drawing.Point(10, 149);
            this.labelArtistName.Name = "labelArtistName";
            this.labelArtistName.Size = new System.Drawing.Size(98, 21);
            this.labelArtistName.TabIndex = 10;
            this.labelArtistName.Text = "Artist name";
            this.labelArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_HomeArtistCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelArtistName);
            this.Controls.Add(this.pictureBoxArtist);
            this.Controls.Add(this.pictureBoxDefaultIcon);
            this.Name = "UC_HomeArtistCard";
            this.Size = new System.Drawing.Size(180, 180);
            this.Load += new System.EventHandler(this.UC_HomeArtistCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefaultIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxArtist;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxDefaultIcon;
        private System.Windows.Forms.Label labelArtistName;
    }
}
