namespace FlacDownloaderUpdater
{
    partial class FormFlacDownloaderUpdater
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFlacDownloaderUpdater));
            this.progressbarUpdateProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.buttonClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUpdateStatus = new System.Windows.Forms.Label();
            this.buttonLaunch = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // progressbarUpdateProgress
            // 
            this.progressbarUpdateProgress.Location = new System.Drawing.Point(12, 77);
            this.progressbarUpdateProgress.Name = "progressbarUpdateProgress";
            this.progressbarUpdateProgress.ProgressColor = System.Drawing.Color.Red;
            this.progressbarUpdateProgress.Size = new System.Drawing.Size(289, 30);
            this.progressbarUpdateProgress.TabIndex = 0;
            this.progressbarUpdateProgress.Text = "guna2ProgressBar1";
            this.progressbarUpdateProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FillColor = System.Drawing.Color.Transparent;
            this.buttonClose.IconColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(347, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(45, 29);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(8, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(196, 21);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "FlacDownloaderUpdater";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUpdateStatus
            // 
            this.labelUpdateStatus.AutoSize = true;
            this.labelUpdateStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelUpdateStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelUpdateStatus.Location = new System.Drawing.Point(12, 53);
            this.labelUpdateStatus.Name = "labelUpdateStatus";
            this.labelUpdateStatus.Size = new System.Drawing.Size(157, 21);
            this.labelUpdateStatus.TabIndex = 17;
            this.labelUpdateStatus.Text = "Downloading files....";
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.BorderRadius = 8;
            this.buttonLaunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLaunch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLaunch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLaunch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLaunch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLaunch.Enabled = false;
            this.buttonLaunch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLaunch.ForeColor = System.Drawing.Color.White;
            this.buttonLaunch.Location = new System.Drawing.Point(307, 77);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(85, 30);
            this.buttonLaunch.TabIndex = 33;
            this.buttonLaunch.Text = "Launch";
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // FormFlacDownloaderUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 119);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.labelUpdateStatus);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.progressbarUpdateProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFlacDownloaderUpdater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormFlacDownloaderUpdater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar progressbarUpdateProgress;
        private Guna.UI2.WinForms.Guna2ControlBox buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUpdateStatus;
        private Guna.UI2.WinForms.Guna2Button buttonLaunch;
    }
}

