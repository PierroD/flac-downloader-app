namespace FlacDownloader.Views
{
    partial class UC_Search
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
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonSearchClear = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowLayoutPanelResults = new System.Windows.Forms.FlowLayoutPanel();
            this.labelResults = new System.Windows.Forms.Label();
            this.uC_MusicPlayer = new FlacDownloader.Views.UC_MusicPlayer();
            this.SuspendLayout();
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
            this.textBoxSearch.Location = new System.Drawing.Point(299, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "Search";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(313, 36);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
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
            this.buttonSearchClear.Location = new System.Drawing.Point(618, 3);
            this.buttonSearchClear.Name = "buttonSearchClear";
            this.buttonSearchClear.Size = new System.Drawing.Size(38, 36);
            this.buttonSearchClear.TabIndex = 5;
            this.buttonSearchClear.Text = "✕";
            this.buttonSearchClear.Visible = false;
            this.buttonSearchClear.Click += new System.EventHandler(this.buttonSearchClear_Click);
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
            this.comboBoxSearchBy.Location = new System.Drawing.Point(143, 3);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(150, 36);
            this.comboBoxSearchBy.TabIndex = 6;
            this.comboBoxSearchBy.Click += new System.EventHandler(this.comboBoxSearchBy_Click);
            // 
            // flowLayoutPanelResults
            // 
            this.flowLayoutPanelResults.AutoScroll = true;
            this.flowLayoutPanelResults.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelResults.Location = new System.Drawing.Point(3, 45);
            this.flowLayoutPanelResults.Name = "flowLayoutPanelResults";
            this.flowLayoutPanelResults.Size = new System.Drawing.Size(802, 491);
            this.flowLayoutPanelResults.TabIndex = 7;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.Location = new System.Drawing.Point(3, 539);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(53, 13);
            this.labelResults.TabIndex = 8;
            this.labelResults.Text = "Results : ";
            // 
            // uC_MusicPlayer
            // 
            this.uC_MusicPlayer.Location = new System.Drawing.Point(0, 555);
            this.uC_MusicPlayer.Name = "uC_MusicPlayer";
            this.uC_MusicPlayer.Size = new System.Drawing.Size(808, 81);
            this.uC_MusicPlayer.TabIndex = 9;
            // 
            // UC_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uC_MusicPlayer);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.flowLayoutPanelResults);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.buttonSearchClear);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "UC_Search";
            this.Size = new System.Drawing.Size(808, 639);
            this.Load += new System.EventHandler(this.UC_Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2Button buttonSearchClear;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSearchBy;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResults;
        private System.Windows.Forms.Label labelResults;
        private UC_MusicPlayer uC_MusicPlayer;
    }
}
