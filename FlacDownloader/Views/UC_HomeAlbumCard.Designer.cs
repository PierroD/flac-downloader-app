namespace FlacDownloader.Views
{
    partial class UC_HomeAlbumCard
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
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.pictureBoxAlbum = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseForm
            // 
            this.elipseForm.BorderRadius = 12;
            this.elipseForm.TargetControl = this;
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.BackColor = System.Drawing.Color.Transparent;
            this.labelAlbumName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAlbumName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumName.Location = new System.Drawing.Point(10, 149);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(108, 21);
            this.labelAlbumName.TabIndex = 11;
            this.labelAlbumName.Text = "Album name";
            this.labelAlbumName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAlbum.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlbum.ImageRotate = 0F;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(0, -1);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 1;
            this.pictureBoxAlbum.TabStop = false;
            this.pictureBoxAlbum.UseTransparentBackground = true;
            this.pictureBoxAlbum.DoubleClick += new System.EventHandler(this.OnCard_DoubleClick);
            // 
            // UC_HomeAlbumCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Name = "UC_HomeAlbumCard";
            this.Size = new System.Drawing.Size(180, 180);
            this.Load += new System.EventHandler(this.UC_HomeAlbumCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxAlbum;
        private System.Windows.Forms.Label labelAlbumName;
    }
}
