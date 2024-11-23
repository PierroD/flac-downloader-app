using FlacDownloader.Properties;
using FlacDownloader.Utils;
using FlacDownloader.Views;
using FlacDownloader.Classes;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlacDownloader
{
    public partial class FormFlacDownloader : Form
    {
        public FormFlacDownloader()
        {
            InitializeComponent();
        }
        private string settingsPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\configs\\settings.json";
        private string downloadQueuePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\configs\\downloadQueue.json";
        private string historicPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\configs\\historic.json";

        private void FormFlacDownloader_Load(object sender, EventArgs e)
        {
            LoadSettings();
            LoadAppColor();
            buttonHome.PerformClick();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            buttonSettings.PerformClick();
        }

        private void OnAppColorChanged(object sender)
        {
            LoadAppColor();
            UserControlHelper.CallEventOnAllPanels(panelMain, "LoadAppColor", null);
        }

        private void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundColor;
            panelLeft.BackColor = AppColors.backgroundSecondaryColor;
            panelNavigation.BackColor = AppColors.backgroundSecondaryColor;
            panelTop.BackColor = AppColors.backgroundSecondaryColor;

            buttonNavigationLeft.FillColor = AppColors.backgroundSecondaryColor;
            buttonNavigationLeft.DisabledState.FillColor = AppColors.backgroundSecondaryColor;
            buttonNavigationRight.FillColor = AppColors.backgroundSecondaryColor;
            buttonNavigationRight.DisabledState.FillColor = AppColors.backgroundSecondaryColor;

            buttonUpdate.FillColor = AppColors.backgroundSecondaryColor;

            labelCurrentPage.ForeColor = AppColors.textColor;
            buttonCurrentPage.DisabledState.FillColor = AppColors.backgroundColor;

            buttonMinimize.FillColor = AppColors.backgroundSecondaryColor;
            buttonMinimize.IconColor = AppColors.textColor;
            buttonClose.FillColor = AppColors.backgroundSecondaryColor;
            buttonClose.IconColor = AppColors.textColor;

            labelDownloadQueueNumber.ForeColor = AppColors.primaryColor;

        }

        private void ButtonSideBarClick(object sender, EventArgs e)
        {
            Guna2Button button = ((Guna2Button)sender);
            UserControlHelper.Switch(panelMain, GetUserControlInstance(button.Name.Replace("button", String.Empty)));
            labelCurrentPage.Text = button.Name.Replace("button", String.Empty);
            buttonCurrentPage.DisabledState.Image = button.Image;
            UpdateNavigationButton();

        }

        UC_Settings settings;
        UC_Home home;
        UC_Search search;
        UC_LocalFiles localFiles;
        UC_Album album;
        UC_Artist artist;
        UC_Track track;
        UC_Downloads downloads;

        private UserControl GetUserControlInstance(string buttonName)
        {
            switch (buttonName)
            {
                case "Home":
                    if (home == null)
                    {
                        home = CreateUserControl<UC_Home>(buttonName);
                        home.GoTo += OnGoToEvent;
                    }
                    Navigation.Push(Enums.GoToEnum.HOME);
                    return home;
                case "Search":
                    if (search == null)
                    {
                        search = CreateUserControl<UC_Search>(buttonName);
                        search.GoTo += OnGoToEvent;
                        search.AddOrRemoveToDownloadQueue += OnRefreshDownLoadQueueCount;
                    }
                    Navigation.Push(Enums.GoToEnum.SEARCH);
                    return search;
                case "LocalFiles":
                    if (localFiles == null)
                    {
                        localFiles = CreateUserControl<UC_LocalFiles>(buttonName);
                        localFiles.GoTo += OnGoToEvent;
                    }
                    Navigation.Push(Enums.GoToEnum.LOCAL_FILES);
                    return localFiles;

                case "Album":
                    if (album == null)
                    {
                        album = CreateUserControl<UC_Album>(buttonName);
                        album.GoTo += OnGoToEvent;
                        album.AddOrRemoveToDownloadQueue += OnRefreshDownLoadQueueCount;
                    }
                    return album;
                case "Artist":
                    if (artist == null)
                    {
                        artist = CreateUserControl<UC_Artist>(buttonName);
                    }
                    return artist;
                case "Track":
                    if (track == null)
                    {
                        track = CreateUserControl<UC_Track>(buttonName);
                        track.GoTo += OnGoToEvent;
                        track.AddOrRemoveToDownloadQueue += OnRefreshDownLoadQueueCount;
                    }
                    return track;

                case "Downloads":
                    if (downloads == null)
                    {
                        downloads = CreateUserControl<UC_Downloads>(buttonName);
                        downloads.AddOrRemoveToDownloadQueue += OnRefreshDownLoadQueueCount;
                    }
                    Navigation.Push(Enums.GoToEnum.DOWNLOADS);
                    return downloads;
                case "Settings":
                    if (settings == null)
                    {
                        settings = CreateUserControl<UC_Settings>(buttonName);
                        settings.AppColorChanged += OnAppColorChanged;
                    }
                    return settings;


                default:
                    return null;
            }
        }

        private T CreateUserControl<T>(string usercontrolName)
        {
            return (T)Assembly.GetExecutingAssembly().CreateInstance($"FlacDownloader.Views.UC_{usercontrolName}"); ;
        }

        private void FormFlacDownloader_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            if (search != null)
            {
                if (search.IsMusicWorkerBusy)
                {
                    search.killWorker();
                    while (search.IsMusicWorkerBusy)
                    {
                        Application.DoEvents();
                    }
                }
            }
            if (album != null)
            {
                if (album.IsMusicWorkerBusy)
                {
                    album.killWorker();
                    while (album.IsMusicWorkerBusy)
                    {
                        Application.DoEvents();
                    }
                }
            }
            if (track != null)
            {
                if (track.IsMusicWorkerBusy)
                {
                    track.killWorker();
                    while (track.IsMusicWorkerBusy)
                    {
                        Application.DoEvents();
                    }
                }
            }
            if (downloads != null)
            {
                downloads.CancelDownloads();
            }
        }

        private void SaveSettings()
        {
            if (File.Exists(this.settingsPath))
                File.Delete(this.settingsPath);

            Classes.Settings settings = new Classes.Settings();
            JsonSerializer serializer = new JsonSerializer();

            settings.IsDarkMode = AppSettings.isDarkMode;
            settings.OutputFormat = AppSettings.outputFormat;
            settings.DownloadFolderPath = AppSettings.downloadFolderPath;
            settings.IsDownloadAutoRetry = AppSettings.isDownloadAutoRetry;
            settings.ApiUrl = AppSettings.apiUrl;
            settings.DownloadApiUrl = AppSettings.downloadApiUrl;
            settings.LatestVersionUrl = AppSettings.latestVersionUrl;
            settings.UpdateChangesUrl = AppSettings.updateChangesUrl;
            settings.UpdateDownloadUrl = AppSettings.updateDownloadUrl;

            using (StreamWriter file = File.CreateText(this.settingsPath))
            {
                using (JsonTextWriter jsonWriter = new JsonTextWriter(file))
                {
                    serializer.Serialize(jsonWriter, settings);
                }
            }
            SaveDownLoadQueue();
            SaveHistoric();
        }

        private void SaveDownLoadQueue()
        {
            if (File.Exists(this.downloadQueuePath))
                File.Delete(this.downloadQueuePath);

            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter file = File.CreateText(this.downloadQueuePath))
            {
                using (JsonTextWriter jsonWriter = new JsonTextWriter(file))
                {
                    serializer.Serialize(jsonWriter, DownloadQueue.downloadQueue);
                }
            }
        }

        private void SaveHistoric()
        {
            if (File.Exists(this.historicPath))
                File.Delete(this.historicPath);

            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter file = File.CreateText(this.historicPath))
            {
                using (JsonTextWriter jsonWriter = new JsonTextWriter(file))
                {
                    serializer.Serialize(jsonWriter, Historic.downloaded);
                }
            }
        }

        private void LoadSettings()
        {
            Classes.Settings settings = new Classes.Settings();
            if (File.Exists(this.settingsPath))
            {
                settings = JsonConvert.DeserializeObject<Classes.Settings>(File.ReadAllText(this.settingsPath));
            }

            if (settings == null)
            {
                return;
            }
            AppSettings.isDarkMode = settings.IsDarkMode;
            AppSettings.downloadFolderPath = settings.DownloadFolderPath;
            AppSettings.outputFormat = settings.OutputFormat;
            AppSettings.isDownloadAutoRetry = settings.IsDownloadAutoRetry;
            AppSettings.apiUrl = settings.ApiUrl;
            AppSettings.downloadApiUrl = settings.DownloadApiUrl;
            AppSettings.latestVersionUrl = settings.LatestVersionUrl;
            AppSettings.updateChangesUrl = settings.UpdateChangesUrl;
            AppSettings.updateDownloadUrl = settings.UpdateDownloadUrl;
            CheckIfUpdateIsNeeded();
            LoadDownloadQeue();
            LoadHistoric();
        }

        private void CheckIfUpdateIsNeeded()
        {
            using (var wc = new System.Net.WebClient())
                AppSettings.latestVersion = wc.DownloadString(AppSettings.latestVersionUrl);
            buttonUpdate.Visible = (AppSettings.appVersion != AppSettings.latestVersion);
        }

        private void LoadDownloadQeue()
        {
            DownloadQueue.downloadQueue = new List<ItemToDownload>();
            if (!File.Exists(this.downloadQueuePath))
            {
                return;
            }
            List<ItemToDownload> items = JsonConvert.DeserializeObject<List<ItemToDownload>>(File.ReadAllText(this.downloadQueuePath));
            if (items != null && items.Count() > 0)
            {
                DownloadQueue.Set(items);
            }
            OnRefreshDownLoadQueueCount(this, 1);
        }

        private void LoadHistoric()
        {
            Historic.downloaded = new List<ItemToDownload>();
            if (!File.Exists(this.historicPath))
            {
                return;
            }
            List<ItemToDownload> items = JsonConvert.DeserializeObject<List<ItemToDownload>>(File.ReadAllText(this.historicPath));
            if (items.Count() > 0)
            {
                Historic.Set(items);
            }
        }

        private void OnGoToEvent(object sender, GoToObject goToObject)
        {
            switch (goToObject.goTo)
            {
                case Enums.GoToEnum.ALBUM:
                    buttonAlbum.Enabled = true;
                    buttonAlbum.PerformClick();
                    if (goToObject.data != null)
                    {
                        this.album.NewParameter(goToObject);
                    }
                    break;
                case Enums.GoToEnum.ARTIST:
                    buttonArtist.Enabled = true;
                    buttonArtist.PerformClick();
                    if (goToObject.data != null)
                    {
                        this.artist.NewParameter(goToObject);
                    }
                    break;
                case Enums.GoToEnum.TRACK:
                    buttonTrack.Enabled = true;
                    buttonTrack.PerformClick();
                    if (goToObject.data != null)
                    {
                        this.track.NewParameter(goToObject);
                    }
                    break;
                case Enums.GoToEnum.LOCAL_FILES:
                case Enums.GoToEnum.LOCAL_FILES_ALBUM:
                case Enums.GoToEnum.LOCAL_FILES_ARTIST:
                    buttonLocalFiles.Enabled = true;
                    buttonLocalFiles.PerformClick();
                    if (goToObject.data != null)
                    {
                        this.localFiles.NewParameter(goToObject.data as LocalFileObject);
                    }
                    break;
                case Enums.GoToEnum.HOME:
                    buttonHome.PerformClick();
                    break;
                case Enums.GoToEnum.DOWNLOADS:
                    buttonDownloads.PerformClick();
                    break;
                case Enums.GoToEnum.SEARCH:
                    buttonSearch.PerformClick();
                    break;
            }
            if (goToObject.data != null)
            {
                switch (goToObject.goTo)
                {
                    case Enums.GoToEnum.ALBUM:
                    case Enums.GoToEnum.ARTIST:
                    case Enums.GoToEnum.TRACK:
                        Navigation.Push(goToObject);
                        break;
                    case Enums.GoToEnum.LOCAL_FILES_ALBUM:
                    case Enums.GoToEnum.LOCAL_FILES_ARTIST:
                        goToObject.goTo = Enums.GoToEnum.LOCAL_FILES;
                        Navigation.Push(goToObject);
                        break;
                }
            }
            UpdateNavigationButton();
        }

        private void UpdateNavigationButton()
        {
            buttonNavigationLeft.Enabled = Navigation.CanGoLeft();
            buttonNavigationRight.Enabled = Navigation.CanGoRight();
        }

        private void OnRefreshDownLoadQueueCount(object sender, int number)
        {
            int downloadQueueCount = DownloadQueue.Count();
            labelDownloadQueueNumber.Text = downloadQueueCount.ToString();
        }

        private void buttonNavigationLeft_Click(object sender, EventArgs e)
        {
            OnGoToEvent(this, Navigation.GoLeft());
        }

        private void buttonNavigationRight_Click(object sender, EventArgs e)
        {
            OnGoToEvent(this, Navigation.GoRight());
        }

    }
}
