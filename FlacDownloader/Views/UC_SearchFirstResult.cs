using FlacDownloader.Classes;
using FlacDownloader.Enums;
using FlacDownloader.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlacDownloader.Views
{
    public partial class UC_SearchFirstResult : UserControl
    {
        private SearchResponse searchResponse { get; set; }

        public delegate void PlayMusicEventHandler(object sender, SearchResponse searchResponse);
        public event PlayMusicEventHandler PlayMusicStart;

        public delegate void GoToEventHandler(object sender, GoToObject goToObject);
        public event GoToEventHandler GoTo;

        public delegate void AddOrRemoveToDownloadQueueEventHandler(object sender, int number);
        public event AddOrRemoveToDownloadQueueEventHandler AddOrRemoveToDownloadQueue;

        protected virtual void OnGoTo(GoToEnum goToEnum)
        {
            GoToObject goToObject = new GoToObject(this.searchResponse, goToEnum, FromEnum.SEARCH);
            GoTo?.Invoke(this, goToObject);
        }

        protected virtual void OnPlayMusicEventHandler()
        {
            PlayMusicStart?.Invoke(this, this.searchResponse);
        }

        public UC_SearchFirstResult(SearchResponse searchResponse)
        {
            InitializeComponent();
            this.searchResponse = searchResponse;
        }

        protected virtual void OnAddOrRemoveToDownloadQueue()
        {
            AddOrRemoveToDownloadQueue?.Invoke(this, 1);
        }

        private void UC_SearchFirstResult_Load(object sender, EventArgs e)
        {
            LoadAppColor();
            LoadData();
        }
        public void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundSecondaryColor;
            labelTitle.ForeColor = AppColors.textColor;
            labelArtist.ForeColor = AppColors.primaryColor;
            labelArtsitName.ForeColor = AppColors.textColor;
            labelTime.ForeColor = AppColors.primaryColor;
            separator.ForeColor = AppColors.textColor;
            buttonPlayMusic.FillColor = AppColors.backgroundColor;
            buttonAddToQueue.FillColor = AppColors.backgroundSecondaryColor;
            buttonAddToQueue.DisabledState.FillColor = AppColors.backgroundSecondaryColor;
            buttonAddToQueue.DisabledState.BorderColor = AppColors.backgroundSecondaryColor;
            buttonAddToQueue.DisabledState.CustomBorderColor = AppColors.backgroundSecondaryColor;

        }

        private async void LoadData()
        {
            labelTitle.Text = this.searchResponse.title;
            labelArtsitName.Text = this.searchResponse.artist.name;
            labelTime.Text = DateHelper.FormatTimeToMMSS(this.searchResponse.duration);
            Image image = await HttpClientExtensions.LoadImageFromUrlAsync(this.searchResponse.album.cover_big);
            pictureBoxAlbumCover.Image = image;
            UpdateButtonAddToDownloadState();
        }

        private void buttonPlayMusic_Click(object sender, EventArgs e)
        {
            OnPlayMusicEventHandler();
        }

        private void pictureBoxAlbumCover_Click(object sender, EventArgs e)
        {
            OnGoTo(GoToEnum.ALBUM);
        }

        private void labelArtsitName_Click(object sender, EventArgs e)
        {
            OnGoTo(GoToEnum.ARTIST);
        }
        private void labelTitle_Click(object sender, EventArgs e)
        {
            OnGoTo(GoToEnum.TRACK);
        }

        private void buttonAddToQueue_Click(object sender, EventArgs e)
        {
            
            if (DownloadQueue.IsInTheDownloadQueue(this.searchResponse.id))
            {
                DownloadQueue.RemoveItem(this.searchResponse.id);
            }
            else
            {
                ItemToDownload item = new ItemToDownload(this.searchResponse.artist.name, this.searchResponse.album.title, this.searchResponse.album.cover_medium, this.searchResponse.title, this.searchResponse.id);
                DownloadQueue.Add(item);

            }
            OnAddOrRemoveToDownloadQueue();
            UpdateButtonAddToDownloadState();
        }

        public void UpdateButtonAddToDownloadState()
        {
            if (Historic.IsDownloaded(this.searchResponse.id))
            {
                buttonAddToQueue.Enabled = false;
                buttonAddToQueue.DisabledState.Image = Properties.Resources.Check;
                return;
            }
            if (DownloadQueue.IsInTheDownloadQueue(this.searchResponse.id))
            {
                buttonAddToQueue.Image = Properties.Resources.AddedToList;
            }
            else
            {
                buttonAddToQueue.Image = Properties.Resources.Add;
            }
        }
    }
}
