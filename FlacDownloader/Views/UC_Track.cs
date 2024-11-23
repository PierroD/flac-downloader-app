using FlacDownloader.Classes;
using FlacDownloader.Enums;
using FlacDownloader.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlacDownloader.Views
{
    public partial class UC_Track : UserControl
    {
        private TrackResponse trackResponse { get; set; }

        public delegate void GoToEventHandler(object sender, GoToObject goToObject);
        public event GoToEventHandler GoTo;
        public delegate void AddOrRemoveToDownloadQueueEventHandler(object sender, int number);
        public event AddOrRemoveToDownloadQueueEventHandler AddOrRemoveToDownloadQueue;

        protected virtual void OnGoTo(GoToEnum goToEnum)
        {
            GoToObject goToObject = new GoToObject(trackResponse, goToEnum, FromEnum.TRACK);
            GoTo?.Invoke(this, goToObject);
        }

        protected virtual void OnAddOrRemoveToDownloadQueue()
        {
            AddOrRemoveToDownloadQueue?.Invoke(this, 1);
        }

        public UC_Track()
        {
            InitializeComponent();
        }

        private void UC_Track_Load(object sender, EventArgs e)
        {
            LoadAppColor();
        }

        public void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundSecondaryColor;
            panelCover.FillColor = AppColors.accentColor;
            panelCover.BackColor = AppColors.accentColor;
            panelCover.ForeColor = AppColors.accentColor;

            labelTrackName.ForeColor = AppColors.textColor;
            labelTrackName.BackColor = AppColors.accentColor;
            labelAlbum.ForeColor = AppColors.textColor;
            labelAlbum.BackColor = AppColors.accentColor;
            labelAlbumName.ForeColor = AppColors.textColor;
            labelAlbumName.BackColor = AppColors.accentColor;
            labelArtist.ForeColor = AppColors.textColor;
            labelArtist.BackColor = AppColors.accentColor;
            labelArtistName.ForeColor = AppColors.textColor;
            labelArtistName.BackColor = AppColors.accentColor;
            labelDate.ForeColor = AppColors.textColor;
            labelDate.BackColor = AppColors.accentColor;
            labelDateValue.ForeColor = AppColors.textColor;
            labelDateValue.BackColor = AppColors.accentColor;
            labelDuration.ForeColor = AppColors.textColor;
            labelDuration.BackColor = AppColors.accentColor;
            labelDurationValue.ForeColor = AppColors.textColor;
            labelDurationValue.BackColor = AppColors.accentColor;

            buttonAddToQueue.FillColor = AppColors.backgroundSecondaryColor;
            buttonAddToQueue.DisabledState.FillColor = AppColors.backgroundSecondaryColor;
            buttonAddToQueue.DisabledState.BorderColor = AppColors.backgroundSecondaryColor;
            buttonAddToQueue.DisabledState.CustomBorderColor = AppColors.backgroundSecondaryColor;

            // UserControlHelper.CallEventOnAllPanels(flowLayoutPanelResults, "LoadAppColor", null);

        }

        public void NewParameter(GoToObject goToObject)
        {
            dynamic newObjectData = GoToObjectParser.ParseGoToData(goToObject);
            switch (goToObject.from)
            {
                case Enums.FromEnum.SEARCH:
                case Enums.FromEnum.ALBUM_TRACK:
                    long trackId = newObjectData.id;
                    GetTrack(trackId);
                    break;
            }
        }

        private async void GetTrack(long id)
        {
            this.trackResponse = await HttpClientExtensions.FindTrackById(id);
            ShowData(this.trackResponse);
            UpdateButtonAddToDownloadState();
        }

        private void ShowData(TrackResponse trackResponse)
        {

            labelTrackName.Text = trackResponse.title;
            labelAlbumName.Text = trackResponse.album.title;
            labelArtistName.Text = trackResponse.artist.name;
            labelDateValue.Text = trackResponse.release_date;
            labelDurationValue.Text = DateHelper.FormatTimeToMMSS(trackResponse.duration);

            LoadImage(this.trackResponse.album.cover_medium);
            OnMusicSelected(trackResponse);

        }
        private async void LoadImage(string imageUrl)
        {
            Image image = await HttpClientExtensions.LoadImageFromUrlAsync(imageUrl);
            pictureBoxTrackCover.Image = image;
        }


        public bool IsMusicWorkerBusy => uC_MusicPlayer.IsMusicWorkerBusy;
        public void killWorker() { uC_MusicPlayer.killWorker(); }


        private void OnMusicSelected(TrackResponse trackResponse)
        {
            MusicSelected musicSelected = new MusicSelected(trackResponse.album.cover_medium, trackResponse.title, trackResponse.artist.name, trackResponse.preview);
            uC_MusicPlayer.OnMusicSelected(musicSelected);
        }

        private void labelAlbumName_Click(object sender, EventArgs e)
        {
            OnGoTo(GoToEnum.ALBUM);
        }

        private void labelArtistName_Click(object sender, EventArgs e)
        {
            OnGoTo(GoToEnum.ARTIST);
        }

        private void buttonDownload_Click(object sender, EventArgs e)
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

        private void UpdateButtonAddToDownloadState()
        {
            if (Historic.IsDownloaded(this.trackResponse.id))
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
