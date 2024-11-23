namespace FlacDownloader.Views
{
    partial class UC_Settings
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
            this.switchDarkMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labelDarkMode = new System.Windows.Forms.Label();
            this.separatorDarkMode = new Guna.UI2.WinForms.Guna2Separator();
            this.separatorDesktopShortcut = new Guna.UI2.WinForms.Guna2Separator();
            this.labelDesktopShortcut = new System.Windows.Forms.Label();
            this.buttonDesktopShortcutCreate = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxDownloadFolderPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonDownloadFolderSelect = new Guna.UI2.WinForms.Guna2Button();
            this.separatorDownloadFolder = new Guna.UI2.WinForms.Guna2Separator();
            this.labelDownloadFolder = new System.Windows.Forms.Label();
            this.buttonDownloadFolderOpen = new Guna.UI2.WinForms.Guna2Button();
            this.separatorOutputFormat = new Guna.UI2.WinForms.Guna2Separator();
            this.labelOutputFormat = new System.Windows.Forms.Label();
            this.comboBoxOutputFormat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.separatorDownloadAutoRetry = new Guna.UI2.WinForms.Guna2Separator();
            this.labelDownloadAutoRetry = new System.Windows.Forms.Label();
            this.switchDownloadAutoRetry = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.buttonGlobalApiSet = new Guna.UI2.WinForms.Guna2Button();
            this.separatorGlobalApi = new Guna.UI2.WinForms.Guna2Separator();
            this.labelGlobalApi = new System.Windows.Forms.Label();
            this.textboxGlobalApi = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonDownloadApiSet = new Guna.UI2.WinForms.Guna2Button();
            this.separatorDownloadApi = new Guna.UI2.WinForms.Guna2Separator();
            this.labelDownloadApi = new System.Windows.Forms.Label();
            this.textboxDownloadApi = new Guna.UI2.WinForms.Guna2TextBox();
            this.verticalSeparator = new Guna.UI2.WinForms.Guna2VSeparator();
            this.separatorCurrentVersion = new Guna.UI2.WinForms.Guna2Separator();
            this.labelCurrentVersion = new System.Windows.Forms.Label();
            this.labelCurrentVersionValue = new System.Windows.Forms.Label();
            this.labelLatestVersionValue = new System.Windows.Forms.Label();
            this.separatorLatestVersion = new Guna.UI2.WinForms.Guna2Separator();
            this.labelLatestVersion = new System.Windows.Forms.Label();
            this.buttonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // switchDarkMode
            // 
            this.switchDarkMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchDarkMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchDarkMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchDarkMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchDarkMode.Location = new System.Drawing.Point(288, 51);
            this.switchDarkMode.Name = "switchDarkMode";
            this.switchDarkMode.Size = new System.Drawing.Size(35, 20);
            this.switchDarkMode.TabIndex = 0;
            this.switchDarkMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchDarkMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchDarkMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchDarkMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchDarkMode.CheckedChanged += new System.EventHandler(this.switchDarkMode_CheckedChanged);
            // 
            // labelDarkMode
            // 
            this.labelDarkMode.AutoSize = true;
            this.labelDarkMode.BackColor = System.Drawing.Color.Transparent;
            this.labelDarkMode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDarkMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelDarkMode.Location = new System.Drawing.Point(13, 50);
            this.labelDarkMode.Name = "labelDarkMode";
            this.labelDarkMode.Size = new System.Drawing.Size(87, 21);
            this.labelDarkMode.TabIndex = 6;
            this.labelDarkMode.Text = "DarkMode";
            // 
            // separatorDarkMode
            // 
            this.separatorDarkMode.Location = new System.Drawing.Point(17, 77);
            this.separatorDarkMode.Name = "separatorDarkMode";
            this.separatorDarkMode.Size = new System.Drawing.Size(306, 10);
            this.separatorDarkMode.TabIndex = 7;
            // 
            // separatorDesktopShortcut
            // 
            this.separatorDesktopShortcut.Location = new System.Drawing.Point(17, 181);
            this.separatorDesktopShortcut.Name = "separatorDesktopShortcut";
            this.separatorDesktopShortcut.Size = new System.Drawing.Size(306, 10);
            this.separatorDesktopShortcut.TabIndex = 10;
            // 
            // labelDesktopShortcut
            // 
            this.labelDesktopShortcut.AutoSize = true;
            this.labelDesktopShortcut.BackColor = System.Drawing.Color.Transparent;
            this.labelDesktopShortcut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesktopShortcut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelDesktopShortcut.Location = new System.Drawing.Point(13, 154);
            this.labelDesktopShortcut.Name = "labelDesktopShortcut";
            this.labelDesktopShortcut.Size = new System.Drawing.Size(136, 21);
            this.labelDesktopShortcut.TabIndex = 9;
            this.labelDesktopShortcut.Text = "Desktop shortcut";
            // 
            // buttonDesktopShortcutCreate
            // 
            this.buttonDesktopShortcutCreate.BorderRadius = 8;
            this.buttonDesktopShortcutCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDesktopShortcutCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDesktopShortcutCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDesktopShortcutCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDesktopShortcutCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDesktopShortcutCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDesktopShortcutCreate.ForeColor = System.Drawing.Color.White;
            this.buttonDesktopShortcutCreate.Location = new System.Drawing.Point(259, 143);
            this.buttonDesktopShortcutCreate.Name = "buttonDesktopShortcutCreate";
            this.buttonDesktopShortcutCreate.Size = new System.Drawing.Size(64, 35);
            this.buttonDesktopShortcutCreate.TabIndex = 17;
            this.buttonDesktopShortcutCreate.Text = "Create";
            this.buttonDesktopShortcutCreate.Click += new System.EventHandler(this.buttonDesktopShortcutCreate_Click);
            // 
            // textBoxDownloadFolderPath
            // 
            this.textBoxDownloadFolderPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDownloadFolderPath.DefaultText = "";
            this.textBoxDownloadFolderPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDownloadFolderPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDownloadFolderPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDownloadFolderPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDownloadFolderPath.Enabled = false;
            this.textBoxDownloadFolderPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDownloadFolderPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxDownloadFolderPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDownloadFolderPath.Location = new System.Drawing.Point(17, 245);
            this.textBoxDownloadFolderPath.Name = "textBoxDownloadFolderPath";
            this.textBoxDownloadFolderPath.PasswordChar = '\0';
            this.textBoxDownloadFolderPath.PlaceholderText = "Download folder...";
            this.textBoxDownloadFolderPath.SelectedText = "";
            this.textBoxDownloadFolderPath.Size = new System.Drawing.Size(224, 35);
            this.textBoxDownloadFolderPath.TabIndex = 18;
            // 
            // buttonDownloadFolderSelect
            // 
            this.buttonDownloadFolderSelect.BorderRadius = 8;
            this.buttonDownloadFolderSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownloadFolderSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDownloadFolderSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDownloadFolderSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDownloadFolderSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDownloadFolderSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDownloadFolderSelect.ForeColor = System.Drawing.Color.White;
            this.buttonDownloadFolderSelect.Location = new System.Drawing.Point(259, 197);
            this.buttonDownloadFolderSelect.Name = "buttonDownloadFolderSelect";
            this.buttonDownloadFolderSelect.Size = new System.Drawing.Size(64, 35);
            this.buttonDownloadFolderSelect.TabIndex = 21;
            this.buttonDownloadFolderSelect.Text = "Select";
            this.buttonDownloadFolderSelect.Click += new System.EventHandler(this.buttonDownloadFolderSelect_Click);
            // 
            // separatorDownloadFolder
            // 
            this.separatorDownloadFolder.Location = new System.Drawing.Point(17, 286);
            this.separatorDownloadFolder.Name = "separatorDownloadFolder";
            this.separatorDownloadFolder.Size = new System.Drawing.Size(306, 10);
            this.separatorDownloadFolder.TabIndex = 20;
            // 
            // labelDownloadFolder
            // 
            this.labelDownloadFolder.AutoSize = true;
            this.labelDownloadFolder.BackColor = System.Drawing.Color.Transparent;
            this.labelDownloadFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownloadFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelDownloadFolder.Location = new System.Drawing.Point(13, 206);
            this.labelDownloadFolder.Name = "labelDownloadFolder";
            this.labelDownloadFolder.Size = new System.Drawing.Size(135, 21);
            this.labelDownloadFolder.TabIndex = 19;
            this.labelDownloadFolder.Text = "Download Folder";
            // 
            // buttonDownloadFolderOpen
            // 
            this.buttonDownloadFolderOpen.BorderRadius = 8;
            this.buttonDownloadFolderOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownloadFolderOpen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDownloadFolderOpen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDownloadFolderOpen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDownloadFolderOpen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDownloadFolderOpen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDownloadFolderOpen.ForeColor = System.Drawing.Color.White;
            this.buttonDownloadFolderOpen.Location = new System.Drawing.Point(259, 245);
            this.buttonDownloadFolderOpen.Name = "buttonDownloadFolderOpen";
            this.buttonDownloadFolderOpen.Size = new System.Drawing.Size(64, 35);
            this.buttonDownloadFolderOpen.TabIndex = 22;
            this.buttonDownloadFolderOpen.Text = "Open";
            this.buttonDownloadFolderOpen.Click += new System.EventHandler(this.buttonDownloadFolderOpen_Click);
            // 
            // separatorOutputFormat
            // 
            this.separatorOutputFormat.Location = new System.Drawing.Point(17, 342);
            this.separatorOutputFormat.Name = "separatorOutputFormat";
            this.separatorOutputFormat.Size = new System.Drawing.Size(306, 10);
            this.separatorOutputFormat.TabIndex = 24;
            // 
            // labelOutputFormat
            // 
            this.labelOutputFormat.AutoSize = true;
            this.labelOutputFormat.BackColor = System.Drawing.Color.Transparent;
            this.labelOutputFormat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelOutputFormat.Location = new System.Drawing.Point(13, 312);
            this.labelOutputFormat.Name = "labelOutputFormat";
            this.labelOutputFormat.Size = new System.Drawing.Size(118, 21);
            this.labelOutputFormat.TabIndex = 23;
            this.labelOutputFormat.Text = "Output Format";
            // 
            // comboBoxOutputFormat
            // 
            this.comboBoxOutputFormat.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxOutputFormat.BorderRadius = 6;
            this.comboBoxOutputFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutputFormat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxOutputFormat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxOutputFormat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxOutputFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxOutputFormat.ItemHeight = 30;
            this.comboBoxOutputFormat.Location = new System.Drawing.Point(209, 302);
            this.comboBoxOutputFormat.Name = "comboBoxOutputFormat";
            this.comboBoxOutputFormat.Size = new System.Drawing.Size(114, 36);
            this.comboBoxOutputFormat.TabIndex = 25;
            this.comboBoxOutputFormat.SelectedValueChanged += new System.EventHandler(this.comboBoxOutputFormat_SelectedValueChanged);
            // 
            // separatorDownloadAutoRetry
            // 
            this.separatorDownloadAutoRetry.Location = new System.Drawing.Point(17, 128);
            this.separatorDownloadAutoRetry.Name = "separatorDownloadAutoRetry";
            this.separatorDownloadAutoRetry.Size = new System.Drawing.Size(306, 10);
            this.separatorDownloadAutoRetry.TabIndex = 28;
            // 
            // labelDownloadAutoRetry
            // 
            this.labelDownloadAutoRetry.AutoSize = true;
            this.labelDownloadAutoRetry.BackColor = System.Drawing.Color.Transparent;
            this.labelDownloadAutoRetry.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownloadAutoRetry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelDownloadAutoRetry.Location = new System.Drawing.Point(13, 101);
            this.labelDownloadAutoRetry.Name = "labelDownloadAutoRetry";
            this.labelDownloadAutoRetry.Size = new System.Drawing.Size(161, 21);
            this.labelDownloadAutoRetry.TabIndex = 27;
            this.labelDownloadAutoRetry.Text = "Download auto retry";
            // 
            // switchDownloadAutoRetry
            // 
            this.switchDownloadAutoRetry.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchDownloadAutoRetry.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchDownloadAutoRetry.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchDownloadAutoRetry.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchDownloadAutoRetry.Location = new System.Drawing.Point(288, 102);
            this.switchDownloadAutoRetry.Name = "switchDownloadAutoRetry";
            this.switchDownloadAutoRetry.Size = new System.Drawing.Size(35, 20);
            this.switchDownloadAutoRetry.TabIndex = 26;
            this.switchDownloadAutoRetry.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchDownloadAutoRetry.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchDownloadAutoRetry.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchDownloadAutoRetry.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchDownloadAutoRetry.CheckedChanged += new System.EventHandler(this.switchDownloadAutoRetry_CheckedChanged);
            // 
            // buttonGlobalApiSet
            // 
            this.buttonGlobalApiSet.BorderRadius = 8;
            this.buttonGlobalApiSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGlobalApiSet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonGlobalApiSet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonGlobalApiSet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonGlobalApiSet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonGlobalApiSet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonGlobalApiSet.ForeColor = System.Drawing.Color.White;
            this.buttonGlobalApiSet.Location = new System.Drawing.Point(259, 391);
            this.buttonGlobalApiSet.Name = "buttonGlobalApiSet";
            this.buttonGlobalApiSet.Size = new System.Drawing.Size(64, 35);
            this.buttonGlobalApiSet.TabIndex = 32;
            this.buttonGlobalApiSet.Text = "Set";
            this.buttonGlobalApiSet.Click += new System.EventHandler(this.buttonGlobalApiSet_Click);
            // 
            // separatorGlobalApi
            // 
            this.separatorGlobalApi.Location = new System.Drawing.Point(18, 432);
            this.separatorGlobalApi.Name = "separatorGlobalApi";
            this.separatorGlobalApi.Size = new System.Drawing.Size(306, 10);
            this.separatorGlobalApi.TabIndex = 31;
            // 
            // labelGlobalApi
            // 
            this.labelGlobalApi.AutoSize = true;
            this.labelGlobalApi.BackColor = System.Drawing.Color.Transparent;
            this.labelGlobalApi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGlobalApi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelGlobalApi.Location = new System.Drawing.Point(13, 367);
            this.labelGlobalApi.Name = "labelGlobalApi";
            this.labelGlobalApi.Size = new System.Drawing.Size(86, 21);
            this.labelGlobalApi.TabIndex = 30;
            this.labelGlobalApi.Text = "Global Api";
            // 
            // textboxGlobalApi
            // 
            this.textboxGlobalApi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxGlobalApi.DefaultText = "";
            this.textboxGlobalApi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxGlobalApi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxGlobalApi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxGlobalApi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxGlobalApi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxGlobalApi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxGlobalApi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxGlobalApi.Location = new System.Drawing.Point(18, 391);
            this.textboxGlobalApi.Name = "textboxGlobalApi";
            this.textboxGlobalApi.PasswordChar = '\0';
            this.textboxGlobalApi.PlaceholderText = "Global Api Url...";
            this.textboxGlobalApi.SelectedText = "";
            this.textboxGlobalApi.Size = new System.Drawing.Size(224, 35);
            this.textboxGlobalApi.TabIndex = 29;
            // 
            // buttonDownloadApiSet
            // 
            this.buttonDownloadApiSet.BorderRadius = 8;
            this.buttonDownloadApiSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownloadApiSet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDownloadApiSet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDownloadApiSet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDownloadApiSet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDownloadApiSet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDownloadApiSet.ForeColor = System.Drawing.Color.White;
            this.buttonDownloadApiSet.Location = new System.Drawing.Point(259, 486);
            this.buttonDownloadApiSet.Name = "buttonDownloadApiSet";
            this.buttonDownloadApiSet.Size = new System.Drawing.Size(64, 35);
            this.buttonDownloadApiSet.TabIndex = 36;
            this.buttonDownloadApiSet.Text = "Set";
            this.buttonDownloadApiSet.Click += new System.EventHandler(this.buttonDownloadApiSet_Click);
            // 
            // separatorDownloadApi
            // 
            this.separatorDownloadApi.Location = new System.Drawing.Point(18, 527);
            this.separatorDownloadApi.Name = "separatorDownloadApi";
            this.separatorDownloadApi.Size = new System.Drawing.Size(306, 10);
            this.separatorDownloadApi.TabIndex = 35;
            // 
            // labelDownloadApi
            // 
            this.labelDownloadApi.AutoSize = true;
            this.labelDownloadApi.BackColor = System.Drawing.Color.Transparent;
            this.labelDownloadApi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownloadApi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelDownloadApi.Location = new System.Drawing.Point(14, 462);
            this.labelDownloadApi.Name = "labelDownloadApi";
            this.labelDownloadApi.Size = new System.Drawing.Size(113, 21);
            this.labelDownloadApi.TabIndex = 34;
            this.labelDownloadApi.Text = "Download Api";
            // 
            // textboxDownloadApi
            // 
            this.textboxDownloadApi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxDownloadApi.DefaultText = "";
            this.textboxDownloadApi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxDownloadApi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxDownloadApi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxDownloadApi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxDownloadApi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxDownloadApi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxDownloadApi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxDownloadApi.Location = new System.Drawing.Point(18, 486);
            this.textboxDownloadApi.Name = "textboxDownloadApi";
            this.textboxDownloadApi.PasswordChar = '\0';
            this.textboxDownloadApi.PlaceholderText = "Download Api Url...";
            this.textboxDownloadApi.SelectedText = "";
            this.textboxDownloadApi.Size = new System.Drawing.Size(224, 35);
            this.textboxDownloadApi.TabIndex = 33;
            // 
            // verticalSeparator
            // 
            this.verticalSeparator.Location = new System.Drawing.Point(366, 50);
            this.verticalSeparator.Name = "verticalSeparator";
            this.verticalSeparator.Size = new System.Drawing.Size(14, 492);
            this.verticalSeparator.TabIndex = 37;
            // 
            // separatorCurrentVersion
            // 
            this.separatorCurrentVersion.Location = new System.Drawing.Point(415, 77);
            this.separatorCurrentVersion.Name = "separatorCurrentVersion";
            this.separatorCurrentVersion.Size = new System.Drawing.Size(306, 10);
            this.separatorCurrentVersion.TabIndex = 39;
            // 
            // labelCurrentVersion
            // 
            this.labelCurrentVersion.AutoSize = true;
            this.labelCurrentVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelCurrentVersion.Location = new System.Drawing.Point(411, 50);
            this.labelCurrentVersion.Name = "labelCurrentVersion";
            this.labelCurrentVersion.Size = new System.Drawing.Size(122, 21);
            this.labelCurrentVersion.TabIndex = 38;
            this.labelCurrentVersion.Text = "Current version";
            // 
            // labelCurrentVersionValue
            // 
            this.labelCurrentVersionValue.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentVersionValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentVersionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelCurrentVersionValue.Location = new System.Drawing.Point(641, 53);
            this.labelCurrentVersionValue.Name = "labelCurrentVersionValue";
            this.labelCurrentVersionValue.Size = new System.Drawing.Size(80, 21);
            this.labelCurrentVersionValue.TabIndex = 40;
            this.labelCurrentVersionValue.Text = "1.0.0.0";
            this.labelCurrentVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLatestVersionValue
            // 
            this.labelLatestVersionValue.BackColor = System.Drawing.Color.Transparent;
            this.labelLatestVersionValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatestVersionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelLatestVersionValue.Location = new System.Drawing.Point(641, 104);
            this.labelLatestVersionValue.Name = "labelLatestVersionValue";
            this.labelLatestVersionValue.Size = new System.Drawing.Size(80, 21);
            this.labelLatestVersionValue.TabIndex = 43;
            this.labelLatestVersionValue.Text = "1.0.0.0";
            this.labelLatestVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // separatorLatestVersion
            // 
            this.separatorLatestVersion.Location = new System.Drawing.Point(415, 128);
            this.separatorLatestVersion.Name = "separatorLatestVersion";
            this.separatorLatestVersion.Size = new System.Drawing.Size(306, 10);
            this.separatorLatestVersion.TabIndex = 42;
            // 
            // labelLatestVersion
            // 
            this.labelLatestVersion.AutoSize = true;
            this.labelLatestVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelLatestVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatestVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.labelLatestVersion.Location = new System.Drawing.Point(411, 101);
            this.labelLatestVersion.Name = "labelLatestVersion";
            this.labelLatestVersion.Size = new System.Drawing.Size(111, 21);
            this.labelLatestVersion.TabIndex = 41;
            this.labelLatestVersion.Text = "Latest version";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BorderRadius = 8;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(645, 140);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(76, 35);
            this.buttonUpdate.TabIndex = 44;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelLatestVersionValue);
            this.Controls.Add(this.separatorLatestVersion);
            this.Controls.Add(this.labelLatestVersion);
            this.Controls.Add(this.labelCurrentVersionValue);
            this.Controls.Add(this.separatorCurrentVersion);
            this.Controls.Add(this.labelCurrentVersion);
            this.Controls.Add(this.verticalSeparator);
            this.Controls.Add(this.buttonDownloadApiSet);
            this.Controls.Add(this.separatorDownloadApi);
            this.Controls.Add(this.labelDownloadApi);
            this.Controls.Add(this.textboxDownloadApi);
            this.Controls.Add(this.buttonGlobalApiSet);
            this.Controls.Add(this.separatorGlobalApi);
            this.Controls.Add(this.labelGlobalApi);
            this.Controls.Add(this.textboxGlobalApi);
            this.Controls.Add(this.separatorDownloadAutoRetry);
            this.Controls.Add(this.labelDownloadAutoRetry);
            this.Controls.Add(this.switchDownloadAutoRetry);
            this.Controls.Add(this.comboBoxOutputFormat);
            this.Controls.Add(this.separatorOutputFormat);
            this.Controls.Add(this.labelOutputFormat);
            this.Controls.Add(this.buttonDownloadFolderOpen);
            this.Controls.Add(this.buttonDownloadFolderSelect);
            this.Controls.Add(this.separatorDownloadFolder);
            this.Controls.Add(this.labelDownloadFolder);
            this.Controls.Add(this.textBoxDownloadFolderPath);
            this.Controls.Add(this.buttonDesktopShortcutCreate);
            this.Controls.Add(this.separatorDesktopShortcut);
            this.Controls.Add(this.labelDesktopShortcut);
            this.Controls.Add(this.separatorDarkMode);
            this.Controls.Add(this.labelDarkMode);
            this.Controls.Add(this.switchDarkMode);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(808, 639);
            this.Load += new System.EventHandler(this.UC_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ToggleSwitch switchDarkMode;
        private System.Windows.Forms.Label labelDarkMode;
        private Guna.UI2.WinForms.Guna2Separator separatorDarkMode;
        private Guna.UI2.WinForms.Guna2Separator separatorDesktopShortcut;
        private System.Windows.Forms.Label labelDesktopShortcut;
        private Guna.UI2.WinForms.Guna2Button buttonDesktopShortcutCreate;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDownloadFolderPath;
        private Guna.UI2.WinForms.Guna2Button buttonDownloadFolderSelect;
        private Guna.UI2.WinForms.Guna2Separator separatorDownloadFolder;
        private System.Windows.Forms.Label labelDownloadFolder;
        private Guna.UI2.WinForms.Guna2Button buttonDownloadFolderOpen;
        private Guna.UI2.WinForms.Guna2Separator separatorOutputFormat;
        private System.Windows.Forms.Label labelOutputFormat;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxOutputFormat;
        private Guna.UI2.WinForms.Guna2Separator separatorDownloadAutoRetry;
        private System.Windows.Forms.Label labelDownloadAutoRetry;
        private Guna.UI2.WinForms.Guna2ToggleSwitch switchDownloadAutoRetry;
        private Guna.UI2.WinForms.Guna2Button buttonGlobalApiSet;
        private Guna.UI2.WinForms.Guna2Separator separatorGlobalApi;
        private System.Windows.Forms.Label labelGlobalApi;
        private Guna.UI2.WinForms.Guna2TextBox textboxGlobalApi;
        private Guna.UI2.WinForms.Guna2Button buttonDownloadApiSet;
        private Guna.UI2.WinForms.Guna2Separator separatorDownloadApi;
        private System.Windows.Forms.Label labelDownloadApi;
        private Guna.UI2.WinForms.Guna2TextBox textboxDownloadApi;
        private Guna.UI2.WinForms.Guna2VSeparator verticalSeparator;
        private Guna.UI2.WinForms.Guna2Separator separatorCurrentVersion;
        private System.Windows.Forms.Label labelCurrentVersion;
        private System.Windows.Forms.Label labelCurrentVersionValue;
        private System.Windows.Forms.Label labelLatestVersionValue;
        private Guna.UI2.WinForms.Guna2Separator separatorLatestVersion;
        private System.Windows.Forms.Label labelLatestVersion;
        private Guna.UI2.WinForms.Guna2Button buttonUpdate;
    }
}
