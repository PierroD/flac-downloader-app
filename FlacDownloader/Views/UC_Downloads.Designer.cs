namespace FlacDownloader.Views
{
    partial class UC_Downloads
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
            this.comboBoxSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.buttonSearchClear = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonDownload = new Guna.UI2.WinForms.Guna2Button();
            this.separatorDownload = new Guna.UI2.WinForms.Guna2VSeparator();
            this.flowLayoutPanelResults = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStopDownloads = new Guna.UI2.WinForms.Guna2Button();
            this.buttonRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSearchBy.BorderRadius = 6;
            this.comboBoxSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSearchBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxSearchBy.ItemHeight = 30;
            this.comboBoxSearchBy.Location = new System.Drawing.Point(66, 3);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(150, 36);
            this.comboBoxSearchBy.TabIndex = 9;
            // 
            // buttonSearchClear
            // 
            this.buttonSearchClear.BorderRadius = 8;
            this.buttonSearchClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearchClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearchClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSearchClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSearchClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSearchClear.ForeColor = System.Drawing.Color.White;
            this.buttonSearchClear.Location = new System.Drawing.Point(541, 3);
            this.buttonSearchClear.Name = "buttonSearchClear";
            this.buttonSearchClear.Size = new System.Drawing.Size(38, 36);
            this.buttonSearchClear.TabIndex = 8;
            this.buttonSearchClear.Text = "✕";
            this.buttonSearchClear.Visible = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderRadius = 6;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.DefaultText = "";
            this.textBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Location = new System.Drawing.Point(222, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "Search";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(313, 36);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // buttonDownload
            // 
            this.buttonDownload.BorderRadius = 8;
            this.buttonDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDownload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDownload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDownload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDownload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDownload.ForeColor = System.Drawing.Color.White;
            this.buttonDownload.Location = new System.Drawing.Point(693, 3);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(112, 36);
            this.buttonDownload.TabIndex = 10;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // separatorDownload
            // 
            this.separatorDownload.Location = new System.Drawing.Point(677, 3);
            this.separatorDownload.Name = "separatorDownload";
            this.separatorDownload.Size = new System.Drawing.Size(10, 36);
            this.separatorDownload.TabIndex = 12;
            // 
            // flowLayoutPanelResults
            // 
            this.flowLayoutPanelResults.AutoScroll = true;
            this.flowLayoutPanelResults.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelResults.Location = new System.Drawing.Point(3, 45);
            this.flowLayoutPanelResults.Name = "flowLayoutPanelResults";
            this.flowLayoutPanelResults.Size = new System.Drawing.Size(802, 491);
            this.flowLayoutPanelResults.TabIndex = 13;
            // 
            // buttonStopDownloads
            // 
            this.buttonStopDownloads.BorderRadius = 8;
            this.buttonStopDownloads.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStopDownloads.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonStopDownloads.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonStopDownloads.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonStopDownloads.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonStopDownloads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonStopDownloads.ForeColor = System.Drawing.Color.White;
            this.buttonStopDownloads.Image = global::FlacDownloader.Properties.Resources.Stop;
            this.buttonStopDownloads.Location = new System.Drawing.Point(633, 3);
            this.buttonStopDownloads.Name = "buttonStopDownloads";
            this.buttonStopDownloads.Size = new System.Drawing.Size(38, 36);
            this.buttonStopDownloads.TabIndex = 14;
            this.buttonStopDownloads.Visible = false;
            this.buttonStopDownloads.Click += new System.EventHandler(this.buttonStopDownloads_Click);
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
            this.buttonRefresh.Location = new System.Drawing.Point(22, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(38, 36);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // UC_Downloads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonStopDownloads);
            this.Controls.Add(this.flowLayoutPanelResults);
            this.Controls.Add(this.separatorDownload);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.buttonSearchClear);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "UC_Downloads";
            this.Size = new System.Drawing.Size(808, 639);
            this.Load += new System.EventHandler(this.UC_Downloads_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSearchBy;
        private Guna.UI2.WinForms.Guna2Button buttonSearchClear;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2Button buttonDownload;
        private Guna.UI2.WinForms.Guna2Button buttonRefresh;
        private Guna.UI2.WinForms.Guna2VSeparator separatorDownload;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResults;
        private Guna.UI2.WinForms.Guna2Button buttonStopDownloads;
    }
}
