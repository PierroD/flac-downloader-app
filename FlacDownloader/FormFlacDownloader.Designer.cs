namespace FlacDownloader
{
    partial class FormFlacDownloader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFlacDownloader));
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.buttonClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.labelDownloadQueueNumber = new System.Windows.Forms.Label();
            this.separatorSecondary = new Guna.UI2.WinForms.Guna2Separator();
            this.separatorMain = new Guna.UI2.WinForms.Guna2Separator();
            this.elipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseLeftPanel = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseTopPanel = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControlForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.elipseMainPanel = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelNavigation = new Guna.UI2.WinForms.Guna2Panel();
            this.elipseNavigation = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.buttonCurrentPage = new Guna.UI2.WinForms.Guna2Button();
            this.buttonNavigationRight = new Guna.UI2.WinForms.Guna2Button();
            this.buttonNavigationLeft = new Guna.UI2.WinForms.Guna2Button();
            this.buttonIcon = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDownloads = new Guna.UI2.WinForms.Guna2Button();
            this.buttonTrack = new Guna.UI2.WinForms.Guna2Button();
            this.buttonArtist = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAlbum = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSettings = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLocalFiles = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.buttonHome = new Guna.UI2.WinForms.Guna2Button();
            this.buttonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.buttonUpdate);
            this.panelTop.Controls.Add(this.buttonMinimize);
            this.panelTop.Controls.Add(this.buttonClose);
            this.panelTop.Location = new System.Drawing.Point(756, -10);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(185, 55);
            this.panelTop.TabIndex = 0;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.buttonMinimize.FillColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.IconColor = System.Drawing.Color.Black;
            this.buttonMinimize.Location = new System.Drawing.Point(64, 15);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(45, 29);
            this.buttonMinimize.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FillColor = System.Drawing.Color.Transparent;
            this.buttonClose.IconColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(115, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(45, 29);
            this.buttonClose.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.guna2Separator1);
            this.panelLeft.Controls.Add(this.buttonIcon);
            this.panelLeft.Controls.Add(this.labelDownloadQueueNumber);
            this.panelLeft.Controls.Add(this.buttonDownloads);
            this.panelLeft.Controls.Add(this.separatorSecondary);
            this.panelLeft.Controls.Add(this.buttonTrack);
            this.panelLeft.Controls.Add(this.buttonArtist);
            this.panelLeft.Controls.Add(this.separatorMain);
            this.panelLeft.Controls.Add(this.buttonAlbum);
            this.panelLeft.Controls.Add(this.buttonSettings);
            this.panelLeft.Controls.Add(this.buttonLocalFiles);
            this.panelLeft.Controls.Add(this.buttonSearch);
            this.panelLeft.Controls.Add(this.buttonHome);
            this.panelLeft.Location = new System.Drawing.Point(10, 12);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(86, 695);
            this.panelLeft.TabIndex = 1;
            // 
            // labelDownloadQueueNumber
            // 
            this.labelDownloadQueueNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownloadQueueNumber.Location = new System.Drawing.Point(4, 489);
            this.labelDownloadQueueNumber.Name = "labelDownloadQueueNumber";
            this.labelDownloadQueueNumber.Size = new System.Drawing.Size(83, 23);
            this.labelDownloadQueueNumber.TabIndex = 12;
            this.labelDownloadQueueNumber.Text = "0";
            this.labelDownloadQueueNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separatorSecondary
            // 
            this.separatorSecondary.Location = new System.Drawing.Point(21, 420);
            this.separatorSecondary.Name = "separatorSecondary";
            this.separatorSecondary.Size = new System.Drawing.Size(47, 10);
            this.separatorSecondary.TabIndex = 10;
            // 
            // separatorMain
            // 
            this.separatorMain.Location = new System.Drawing.Point(21, 236);
            this.separatorMain.Name = "separatorMain";
            this.separatorMain.Size = new System.Drawing.Size(47, 10);
            this.separatorMain.TabIndex = 7;
            // 
            // elipseForm
            // 
            this.elipseForm.BorderRadius = 10;
            this.elipseForm.TargetControl = this;
            // 
            // elipseLeftPanel
            // 
            this.elipseLeftPanel.BorderRadius = 10;
            this.elipseLeftPanel.TargetControl = this.panelLeft;
            // 
            // elipseTopPanel
            // 
            this.elipseTopPanel.BorderRadius = 40;
            this.elipseTopPanel.TargetControl = this.panelTop;
            // 
            // dragControlForm
            // 
            this.dragControlForm.DockIndicatorTransparencyValue = 0.6D;
            this.dragControlForm.TargetControl = this;
            this.dragControlForm.UseTransparentDrag = true;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(102, 68);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(808, 639);
            this.panelMain.TabIndex = 2;
            // 
            // elipseMainPanel
            // 
            this.elipseMainPanel.BorderRadius = 10;
            this.elipseMainPanel.TargetControl = this.panelMain;
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.buttonNavigationRight);
            this.panelNavigation.Controls.Add(this.buttonNavigationLeft);
            this.panelNavigation.Location = new System.Drawing.Point(105, 12);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(90, 45);
            this.panelNavigation.TabIndex = 3;
            // 
            // elipseNavigation
            // 
            this.elipseNavigation.BorderRadius = 12;
            this.elipseNavigation.TargetControl = this.panelNavigation;
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelCurrentPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPage.Location = new System.Drawing.Point(245, 24);
            this.labelCurrentPage.Name = "labelCurrentPage";
            this.labelCurrentPage.Size = new System.Drawing.Size(107, 21);
            this.labelCurrentPage.TabIndex = 15;
            this.labelCurrentPage.Text = "current page";
            this.labelCurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCurrentPage
            // 
            this.buttonCurrentPage.BorderRadius = 8;
            this.buttonCurrentPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCurrentPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCurrentPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCurrentPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCurrentPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCurrentPage.Enabled = false;
            this.buttonCurrentPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCurrentPage.ForeColor = System.Drawing.Color.White;
            this.buttonCurrentPage.Image = global::FlacDownloader.Properties.Resources.Home;
            this.buttonCurrentPage.Location = new System.Drawing.Point(201, 16);
            this.buttonCurrentPage.Name = "buttonCurrentPage";
            this.buttonCurrentPage.Size = new System.Drawing.Size(38, 36);
            this.buttonCurrentPage.TabIndex = 12;
            // 
            // buttonNavigationRight
            // 
            this.buttonNavigationRight.BorderRadius = 8;
            this.buttonNavigationRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNavigationRight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonNavigationRight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonNavigationRight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonNavigationRight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonNavigationRight.Enabled = false;
            this.buttonNavigationRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonNavigationRight.ForeColor = System.Drawing.Color.White;
            this.buttonNavigationRight.Image = global::FlacDownloader.Properties.Resources.Right;
            this.buttonNavigationRight.Location = new System.Drawing.Point(47, 4);
            this.buttonNavigationRight.Name = "buttonNavigationRight";
            this.buttonNavigationRight.Size = new System.Drawing.Size(38, 36);
            this.buttonNavigationRight.TabIndex = 11;
            this.buttonNavigationRight.Click += new System.EventHandler(this.buttonNavigationRight_Click);
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
            this.buttonNavigationLeft.Location = new System.Drawing.Point(3, 4);
            this.buttonNavigationLeft.Name = "buttonNavigationLeft";
            this.buttonNavigationLeft.Size = new System.Drawing.Size(38, 36);
            this.buttonNavigationLeft.TabIndex = 10;
            this.buttonNavigationLeft.Click += new System.EventHandler(this.buttonNavigationLeft_Click);
            // 
            // buttonIcon
            // 
            this.buttonIcon.BackColor = System.Drawing.Color.Transparent;
            this.buttonIcon.BorderColor = System.Drawing.Color.Transparent;
            this.buttonIcon.BorderRadius = 10;
            this.buttonIcon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonIcon.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonIcon.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonIcon.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonIcon.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.buttonIcon.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.buttonIcon.DisabledState.Image = global::FlacDownloader.Properties.Resources.FlacDownloader;
            this.buttonIcon.Enabled = false;
            this.buttonIcon.FillColor = System.Drawing.Color.Transparent;
            this.buttonIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonIcon.ForeColor = System.Drawing.Color.White;
            this.buttonIcon.Image = global::FlacDownloader.Properties.Resources.FlacDownloader;
            this.buttonIcon.ImageSize = new System.Drawing.Size(50, 50);
            this.buttonIcon.Location = new System.Drawing.Point(21, -4);
            this.buttonIcon.Name = "buttonIcon";
            this.buttonIcon.Size = new System.Drawing.Size(50, 50);
            this.buttonIcon.TabIndex = 13;
            this.buttonIcon.UseTransparentBackground = true;
            // 
            // buttonDownloads
            // 
            this.buttonDownloads.BackColor = System.Drawing.Color.Transparent;
            this.buttonDownloads.BorderColor = System.Drawing.Color.Transparent;
            this.buttonDownloads.BorderRadius = 10;
            this.buttonDownloads.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonDownloads.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownloads.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonDownloads.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDownloads.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDownloads.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDownloads.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDownloads.FillColor = System.Drawing.Color.Transparent;
            this.buttonDownloads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDownloads.ForeColor = System.Drawing.Color.White;
            this.buttonDownloads.Image = global::FlacDownloader.Properties.Resources.Dwonload;
            this.buttonDownloads.Location = new System.Drawing.Point(21, 436);
            this.buttonDownloads.Name = "buttonDownloads";
            this.buttonDownloads.Size = new System.Drawing.Size(50, 50);
            this.buttonDownloads.TabIndex = 11;
            this.buttonDownloads.UseTransparentBackground = true;
            this.buttonDownloads.Click += new System.EventHandler(this.ButtonSideBarClick);
            // 
            // buttonTrack
            // 
            this.buttonTrack.BackColor = System.Drawing.Color.Transparent;
            this.buttonTrack.BorderColor = System.Drawing.Color.Transparent;
            this.buttonTrack.BorderRadius = 10;
            this.buttonTrack.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTrack.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonTrack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonTrack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonTrack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonTrack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonTrack.Enabled = false;
            this.buttonTrack.FillColor = System.Drawing.Color.Transparent;
            this.buttonTrack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTrack.ForeColor = System.Drawing.Color.White;
            this.buttonTrack.Image = global::FlacDownloader.Properties.Resources.Track;
            this.buttonTrack.Location = new System.Drawing.Point(18, 364);
            this.buttonTrack.Name = "buttonTrack";
            this.buttonTrack.Size = new System.Drawing.Size(50, 50);
            this.buttonTrack.TabIndex = 9;
            this.buttonTrack.UseTransparentBackground = true;
            this.buttonTrack.Click += new System.EventHandler(this.ButtonSideBarClick);
            // 
            // buttonArtist
            // 
            this.buttonArtist.BackColor = System.Drawing.Color.Transparent;
            this.buttonArtist.BorderColor = System.Drawing.Color.Transparent;
            this.buttonArtist.BorderRadius = 10;
            this.buttonArtist.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonArtist.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonArtist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonArtist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonArtist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonArtist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonArtist.Enabled = false;
            this.buttonArtist.FillColor = System.Drawing.Color.Transparent;
            this.buttonArtist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonArtist.ForeColor = System.Drawing.Color.White;
            this.buttonArtist.Image = global::FlacDownloader.Properties.Resources.Artist;
            this.buttonArtist.Location = new System.Drawing.Point(18, 308);
            this.buttonArtist.Name = "buttonArtist";
            this.buttonArtist.Size = new System.Drawing.Size(50, 50);
            this.buttonArtist.TabIndex = 8;
            this.buttonArtist.UseTransparentBackground = true;
            this.buttonArtist.Click += new System.EventHandler(this.ButtonSideBarClick);
            // 
            // buttonAlbum
            // 
            this.buttonAlbum.BackColor = System.Drawing.Color.Transparent;
            this.buttonAlbum.BorderColor = System.Drawing.Color.Transparent;
            this.buttonAlbum.BorderRadius = 10;
            this.buttonAlbum.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAlbum.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonAlbum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAlbum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAlbum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAlbum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAlbum.Enabled = false;
            this.buttonAlbum.FillColor = System.Drawing.Color.Transparent;
            this.buttonAlbum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAlbum.ForeColor = System.Drawing.Color.White;
            this.buttonAlbum.Image = global::FlacDownloader.Properties.Resources.Disk;
            this.buttonAlbum.Location = new System.Drawing.Point(18, 252);
            this.buttonAlbum.Name = "buttonAlbum";
            this.buttonAlbum.Size = new System.Drawing.Size(50, 50);
            this.buttonAlbum.TabIndex = 6;
            this.buttonAlbum.UseTransparentBackground = true;
            this.buttonAlbum.Click += new System.EventHandler(this.ButtonSideBarClick);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.BorderColor = System.Drawing.Color.Transparent;
            this.buttonSettings.BorderRadius = 10;
            this.buttonSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSettings.FillColor = System.Drawing.Color.Transparent;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = global::FlacDownloader.Properties.Resources.Settings;
            this.buttonSettings.Location = new System.Drawing.Point(18, 631);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(50, 50);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.UseTransparentBackground = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSideBarClick);
            // 
            // buttonLocalFiles
            // 
            this.buttonLocalFiles.BackColor = System.Drawing.Color.Transparent;
            this.buttonLocalFiles.BorderColor = System.Drawing.Color.Transparent;
            this.buttonLocalFiles.BorderRadius = 10;
            this.buttonLocalFiles.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonLocalFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLocalFiles.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonLocalFiles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLocalFiles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLocalFiles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLocalFiles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLocalFiles.Enabled = false;
            this.buttonLocalFiles.FillColor = System.Drawing.Color.Transparent;
            this.buttonLocalFiles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLocalFiles.ForeColor = System.Drawing.Color.White;
            this.buttonLocalFiles.Image = global::FlacDownloader.Properties.Resources.Folder;
            this.buttonLocalFiles.Location = new System.Drawing.Point(18, 180);
            this.buttonLocalFiles.Name = "buttonLocalFiles";
            this.buttonLocalFiles.Size = new System.Drawing.Size(50, 50);
            this.buttonLocalFiles.TabIndex = 4;
            this.buttonLocalFiles.UseTransparentBackground = true;
            this.buttonLocalFiles.Click += new System.EventHandler(this.ButtonSideBarClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BorderColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BorderRadius = 10;
            this.buttonSearch.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSearch.FillColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = global::FlacDownloader.Properties.Resources.Search;
            this.buttonSearch.Location = new System.Drawing.Point(18, 124);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 50);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.UseTransparentBackground = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSideBarClick);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.BorderColor = System.Drawing.Color.Transparent;
            this.buttonHome.BorderRadius = 10;
            this.buttonHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonHome.FillColor = System.Drawing.Color.Transparent;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = global::FlacDownloader.Properties.Resources.Home;
            this.buttonHome.Location = new System.Drawing.Point(18, 68);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(50, 50);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.UseTransparentBackground = true;
            this.buttonHome.Click += new System.EventHandler(this.ButtonSideBarClick);
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
            this.buttonUpdate.Image = global::FlacDownloader.Properties.Resources.Updates;
            this.buttonUpdate.Location = new System.Drawing.Point(13, 15);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(45, 29);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(21, 52);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(47, 10);
            this.guna2Separator1.TabIndex = 14;
            // 
            // FormFlacDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 719);
            this.Controls.Add(this.labelCurrentPage);
            this.Controls.Add(this.buttonCurrentPage);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFlacDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFlacDownloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFlacDownloader_FormClosing);
            this.Load += new System.EventHandler(this.FormFlacDownloader_Load);
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2ControlBox buttonClose;
        private Guna.UI2.WinForms.Guna2ControlBox buttonMinimize;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Button buttonHome;
        private Guna.UI2.WinForms.Guna2Button buttonLocalFiles;
        private Guna.UI2.WinForms.Guna2Button buttonSearch;
        private Guna.UI2.WinForms.Guna2Button buttonSettings;
        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2Elipse elipseLeftPanel;
        private Guna.UI2.WinForms.Guna2Elipse elipseTopPanel;
        private Guna.UI2.WinForms.Guna2DragControl dragControlForm;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Elipse elipseMainPanel;
        private Guna.UI2.WinForms.Guna2Separator separatorMain;
        private Guna.UI2.WinForms.Guna2Button buttonAlbum;
        private Guna.UI2.WinForms.Guna2Button buttonArtist;
        private Guna.UI2.WinForms.Guna2Button buttonTrack;
        private Guna.UI2.WinForms.Guna2Button buttonDownloads;
        private Guna.UI2.WinForms.Guna2Separator separatorSecondary;
        private System.Windows.Forms.Label labelDownloadQueueNumber;
        private Guna.UI2.WinForms.Guna2Panel panelNavigation;
        private Guna.UI2.WinForms.Guna2Button buttonNavigationRight;
        private Guna.UI2.WinForms.Guna2Button buttonNavigationLeft;
        private Guna.UI2.WinForms.Guna2Elipse elipseNavigation;
        private Guna.UI2.WinForms.Guna2Button buttonCurrentPage;
        private System.Windows.Forms.Label labelCurrentPage;
        private Guna.UI2.WinForms.Guna2Button buttonUpdate;
        private Guna.UI2.WinForms.Guna2Button buttonIcon;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}

