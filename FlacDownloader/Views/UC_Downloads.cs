using FlacDownloader.Classes;
using FlacDownloader.Enums;
using FlacDownloader.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace FlacDownloader.Views
{
    public partial class UC_Downloads : UserControl
    {
        private List<UC_DownloadTrack> tracks;
        private HTTPDownloader downloader;
        public delegate void AddOrRemoveToDownloadQueueEventHandler(object sender, int number);
        public event AddOrRemoveToDownloadQueueEventHandler AddOrRemoveToDownloadQueue;

        private int downloaded { get; set; }
        private int notDownloaded { get; set; }

        protected virtual void OnAddOrRemoveToDownloadQueue(object sender, int number)
        {
            AddOrRemoveToDownloadQueue?.Invoke(this, 1);
        }

        public UC_Downloads()
        {
            InitializeComponent();
        }

        private void UC_Downloads_Load(object sender, EventArgs e)
        {
            LoadAppColor();
            LoadTracks();
        }

        public void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundSecondaryColor;
            comboBoxSearchBy.FillColor = AppColors.backgroundSecondaryColor;
            comboBoxSearchBy.BorderColor = AppColors.textColor;
            comboBoxSearchBy.ForeColor = AppColors.textColor;
            comboBoxSearchBy.FocusedState.BorderColor = AppColors.textColor;
            textBoxSearch.FillColor = AppColors.backgroundSecondaryColor;
            textBoxSearch.BorderColor = AppColors.textColor;
            textBoxSearch.ForeColor = AppColors.textColor;
            textBoxSearch.FocusedState.BorderColor = AppColors.textColor;
            buttonSearchClear.FillColor = AppColors.primaryColor;
            buttonSearchClear.ForeColor = AppColors.backgroundSecondaryColor;
            buttonRefresh.FillColor = AppColors.backgroundSecondaryColor;
            buttonRefresh.ForeColor = AppColors.primaryColor;
            buttonStopDownloads.FillColor = AppColors.backgroundSecondaryColor;
            buttonStopDownloads.ForeColor = AppColors.primaryColor;
            buttonDownload.FillColor = AppColors.backgroundSecondaryColor;
            buttonDownload.ForeColor = AppColors.primaryColor;
            separatorDownload.FillColor = AppColors.textColor;
            UserControlHelper.CallEventOnAllPanels(flowLayoutPanelResults, "LoadAppColor", null);

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            buttonSearchClear.Visible = textBoxSearch.Text.Trim() != String.Empty;
        }

        private void buttonSearchClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = String.Empty;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBoxSearch.Text != String.Empty)
                {
                    List<UC_DownloadTrack> tracksFound = new List<UC_DownloadTrack>();
                    tracksFound = Search(textBoxSearch.Text, (SearchByEnum)Enum.Parse(typeof(SearchByEnum), comboBoxSearchBy.Text.Length <= 0 ? "None" : comboBoxSearchBy.Text));
                    if (tracksFound.Count > 0)
                    {
                        DisplayMusicToDownload(tracksFound);
                    }
                    else
                    {
                        DisplayMusicToDownload(this.tracks);
                    }
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadTracks();
        }

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            if (AppSettings.downloadApiUrl == String.Empty)
            {
                MessageBox.Show("The Download API Url is empty, make sure to set it in the config before searching again", "Error - API Url is empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ToogleDeleteButton(false);
            List<ItemToDownload> items = DownloadQueue.downloadQueue;
            foreach (ItemToDownload item in items)
            {
                item.outputFolder = CreateFolderForTheTrack(item);
                item.url = String.Format(AppSettings.downloadApiUrl, item.trackId, AppSettings.outputFormat);
            }
            downloader = new HTTPDownloader();
            this.downloaded = 0;
            this.notDownloaded = 0;
            buttonDownload.UseWaitCursor = true;
            buttonDownload.Enabled = false;
            downloader.DownloadCompleted += DownloadCompleted;
            downloader.AllDownloadsCompleted += AllDownloadsCompleted;
            await downloader.DownloadMultipleFilesAsync(items);
        }


        private void DownloadCompleted(object sender, HTTPDownloadCompletedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (e.isSuccess)
                {
                    Historic.Add(e.downloadItem);
                    List<ItemToDownload> items = DownloadQueue.RemoveAndReturn(e.downloadItem.trackId);
                    LoadTracks(items);
                    OnAddOrRemoveToDownloadQueue(this, 1);
                    this.downloaded++;
                }
                else
                {
                    Console.WriteLine(e.message);
                    this.notDownloaded++;
                }
            }));
        }
        private void buttonStopDownloads_Click(object sender, EventArgs e)
        {
            CancelDownloads();
        }

        private void AllDownloadsCompleted(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (AppSettings.isDownloadAutoRetry && DownloadQueue.Count() > 0)
                {
                    buttonDownload.PerformClick();
                }
                else
                {
                    buttonDownload.UseWaitCursor = false;
                    buttonDownload.Enabled = true;
                    ToogleDeleteButton(true);
                }
            }));
        }

        private string CreateFolderForTheTrack(ItemToDownload item)
        {
            string folder = FolderHelper.SanitizeFolderName($"{AppSettings.downloadFolderPath}\\{item.artistName}\\{item.albumName}");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder;
        }

        private void OnDeleteTrack(object sender, long trackId)
        {
            List<ItemToDownload> items = DownloadQueue.RemoveAndReturn(trackId);
            OnAddOrRemoveToDownloadQueue(this, 1);
            if (items.Count == 0)
            {
                flowLayoutPanelResults.Controls.Clear();
                flowLayoutPanelResults.PerformLayout();
                return;
            }
            LoadTracks(items);
        }

        private List<UC_DownloadTrack> Search(string text, SearchByEnum searchBy)
        {
            switch (searchBy)
            {
                case SearchByEnum.Track:
                    return this.tracks.FindAll(item => item.trackName.Contains(text));
                case SearchByEnum.Artist:
                    return this.tracks.FindAll(item => item.artistName.Contains(text));
                case SearchByEnum.Album:
                    return this.tracks.FindAll(item => item.albumName.Contains(text));
                case SearchByEnum.None:
                    return this.tracks.FindAll(item => item.albumName.Contains(text) || item.artistName.Contains(text) || item.trackName.Contains(text));
                default:
                    return new List<UC_DownloadTrack>();
            }
        }

        private void DisplayMusicToDownload(List<UC_DownloadTrack> tracksToDownload)
        {
            flowLayoutPanelResults.Controls.Clear();
            flowLayoutPanelResults.SuspendLayout();
            flowLayoutPanelResults.Controls.AddRange(tracksToDownload.ToArray());
            flowLayoutPanelResults.ResumeLayout();
            this.ResumeLayout();
        }

        public void LoadTracks(List<ItemToDownload> items = null)
        {
            if (items == null)
            {
                items = DownloadQueue.downloadQueue;
            }

            this.tracks = new List<UC_DownloadTrack>();
            if (DownloadQueue.Count() > 0)
            {
                foreach (ItemToDownload item in items)
                {
                    UC_DownloadTrack track = new UC_DownloadTrack
                    {
                        artistName = item.artistName,
                        albumName = item.albumName,
                        albumCover = item.albumCover,
                        trackName = item.trackName,
                        trackId = item.trackId,
                    };
                    track.DeleteTrack += OnDeleteTrack;
                    this.tracks.Add(track);
                }
                DisplayMusicToDownload(this.tracks);
            }
            else
            {
                flowLayoutPanelResults.Controls.Clear();
                flowLayoutPanelResults.SuspendLayout();
                flowLayoutPanelResults.ResumeLayout();
                this.ResumeLayout();

            }
        }

        private void ToogleDeleteButton(bool isEnable)
        {
            buttonStopDownloads.Visible = isEnable;
            UserControlHelper.CallEventOnAllPanels(flowLayoutPanelResults, "ToogleDeleteButton", isEnable);
        }

        public void CancelDownloads()
        {
            if (downloader != null)
            {
                downloader.CancelDownloads();
                ToogleDeleteButton(false);
            }
        }

    }
}
