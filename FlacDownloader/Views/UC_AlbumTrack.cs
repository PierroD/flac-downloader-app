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
    public partial class UC_AlbumTrack : UserControl
    {
        private AlbumTrackResponse trackResponse { get; set; }

        public delegate void PlayMusicEventHandler(object sender, AlbumTrackResponse trackResponse);
        public event PlayMusicEventHandler PlayMusicStart;

        public delegate void GoToEventHandler(object sender, GoToObject goToObject);
        public event GoToEventHandler GoTo;

        public delegate void AddOrRemoveToDownloadQueueEventHandler(object sender, int number);
        public event AddOrRemoveToDownloadQueueEventHandler AddOrRemoveToDownloadQueue;

        protected virtual void OnGoTo(GoToEnum goToEnum)
        {
            GoToObject goToObject = new GoToObject(trackResponse, goToEnum, FromEnum.ALBUM_TRACK);
            GoTo?.Invoke(this, goToObject);
        }
        protected virtual void OnPlayMusicEventHandler()
        {
            PlayMusicStart?.Invoke(this, this.trackResponse);
        }

        protected virtual void OnAddOrRemoveToDownloadQueue()
        {
            AddOrRemoveToDownloadQueue?.Invoke(this, 1);
        }

        public UC_AlbumTrack(AlbumTrackResponse albumTrackResponse)
        {
            InitializeComponent();
            this.trackResponse = albumTrackResponse;
        }

        private void UC_AlbumTrack_Load(object sender, EventArgs e)
        {
            LoadAppColor();
            LoadData();
            UpdateButtonAddToDownloadState();
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
            buttonAddToQueue.DisabledState.ForeColor = AppColors.backgroundSecondaryColor;
            buttonAddToQueue.DisabledState.BorderColor = AppColors.backgroundSecondaryColor;
            buttonAddToQueue.DisabledState.CustomBorderColor = AppColors.backgroundSecondaryColor;

            pictureBoxAlbumCover.Cursor = Cursors.Default;
        }

        private async void LoadData()
        {
            labelTitle.Text = this.trackResponse.title;
            labelArtsitName.Text = this.trackResponse.artist.name;
            labelTime.Text = DateHelper.FormatTimeToMMSS(this.trackResponse.duration);

            Image image = await HttpClientExtensions.LoadImageFromUrlAsync(this.trackResponse.album.cover_medium);
            pictureBoxAlbumCover.Image = image;

        }

        private void labelArtsitName_Click(object sender, EventArgs e)
        {
            OnGoTo(GoToEnum.ARTIST);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            OnGoTo(GoToEnum.TRACK);
        }

        private void buttonPlayMusic_Click(object sender, EventArgs e)
        {
            OnPlayMusicEventHandler();
        }

        private void buttonAddToQueue_Click(object sender, EventArgs e)
        {

            if (DownloadQueue.IsInTheDownloadQueue(this.trackResponse.id))
            {
                DownloadQueue.RemoveItem(this.trackResponse.id);
            }
            else
            {
                ItemToDownload item = new ItemToDownload(this.trackResponse.artist.name, this.trackResponse.album.title, this.trackResponse.album.cover_medium, this.trackResponse.title, this.trackResponse.id);
                DownloadQueue.Add(item);

            }
            OnAddOrRemoveToDownloadQueue();
            UpdateButtonAddToDownloadState();

        }

        public void UpdateButtonAddToDownloadState()
        {
            if(Historic.IsDownloaded(this.trackResponse.id))
            {
                buttonAddToQueue.Enabled = false;
                buttonAddToQueue.DisabledState.Image = Properties.Resources.Check;
                return;
            }
            if (DownloadQueue.IsInTheDownloadQueue(this.trackResponse.id))
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
