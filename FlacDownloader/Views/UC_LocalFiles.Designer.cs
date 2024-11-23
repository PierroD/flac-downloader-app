namespace FlacDownloader.Views
{
    partial class UC_LocalFiles
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
            this.labelLocalPath = new System.Windows.Forms.Label();
            this.flowLayoutPanelResults = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNavigationLeft = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // labelLocalPath
            // 
            this.labelLocalPath.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalPath.Location = new System.Drawing.Point(3, 16);
            this.labelLocalPath.Name = "labelLocalPath";
            this.labelLocalPath.Size = new System.Drawing.Size(802, 23);
            this.labelLocalPath.TabIndex = 4;
            this.labelLocalPath.Text = "C:\\\\";
            // 
            // flowLayoutPanelResults
            // 
            this.flowLayoutPanelResults.AutoScroll = true;
            this.flowLayoutPanelResults.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelResults.Location = new System.Drawing.Point(3, 86);
            this.flowLayoutPanelResults.Name = "flowLayoutPanelResults";
            this.flowLayoutPanelResults.Size = new System.Drawing.Size(802, 550);
            this.flowLayoutPanelResults.TabIndex = 8;
            // 
            // buttonNavigationLeft
            // 
            this.buttonNavigationLeft.BorderRadius = 8;
            this.buttonNavigationLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNavigationLeft.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonNavigationLeft.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonNavigationLeft.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonNavigationLeft.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonNavigationLeft.Enabled = false;
            this.buttonNavigationLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonNavigationLeft.ForeColor = System.Drawing.Color.White;
            this.buttonNavigationLeft.Image = global::FlacDownloader.Properties.Resources.Left;
            this.buttonNavigationLeft.Location = new System.Drawing.Point(7, 44);
            this.buttonNavigationLeft.Name = "buttonNavigationLeft";
            this.buttonNavigationLeft.Size = new System.Drawing.Size(38, 36);
            this.buttonNavigationLeft.TabIndex = 12;
            this.buttonNavigationLeft.Click += new System.EventHandler(this.buttonNavigationLeft_Click);
            // 
            // UC_LocalFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNavigationLeft);
            this.Controls.Add(this.flowLayoutPanelResults);
            this.Controls.Add(this.labelLocalPath);
            this.Name = "UC_LocalFiles";
            this.Size = new System.Drawing.Size(808, 639);
            this.Load += new System.EventHandler(this.UC_LocalFiles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLocalPath;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResults;
        private Guna.UI2.WinForms.Guna2Button buttonNavigationLeft;
    }
}
