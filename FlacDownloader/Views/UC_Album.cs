using FlacDownloader.Classes;
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
    public partial class UC_Album : UserControl
    {
        private AlbumResponse albumResponse { get; set; }

        public delegate void GoToEventHandler(object sender, GoToObject goToObject);
        public event GoToEventHandler GoTo;
        public delegate void AddOrRemoveToDownloadQueueEventHandler(object sender, int number);
        public event AddOrRemoveToDownloadQueueEventHandler AddOrRemoveToDownloadQueue;

        protected virtual void OnGoTo(object sender, GoToObject goToObject)
        {
            uC_MusicPlayer.PauseMusic();
            GoTo?.Invoke(this, goToObject);
        }

        protected virtual void OnAddOrRemoveToDownloadQueue(object sender, int number)
        {
            AddOrRemoveToDownloadQueue?.Invoke(this, 1);
            UpdateButtonAddToDownloadState();
        }

        public UC_Album()
        {
            InitializeComponent();
        }

        private void UC_Album_Load(object sender, EventArgs e)
        {
            LoadAppColor();
        }

        public void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundSecondaryColor;
            panelCover.FillColor = AppColors.accentColor;
            panelCover.BackColor = AppColors.accentColor;
            panelCover.ForeColor = AppColors.accentColor;

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
            labelTracks.ForeColor = AppColors.textColor;
            labelTracks.BackColor = AppColors.accentColor;
            labelTracksNumber.ForeColor = AppColors.textColor;
            labelTracksNumber.BackColor = AppColors.accentColor;
            labelDuration.ForeColor = AppColors.textColor;
            labelDuration.BackColor = AppColors.accentColor;
            labelDurationValue.ForeColor = AppColors.textColor;
            labelDurationValue.BackColor = AppColors.accentColor;
            buttonAddToQueue.FillColor = AppColors.backgroundSecondaryColor;
            buttonAddToQueue.DisabledState.FillColor = AppColors.backgroundSecondaryColor;
            buttonAddToQueue.DisabledState.BorderColor = AppColors.backgroundSecondaryColor;
            buttonAddToQueue.DisabledState.CustomBorderColor = AppColors.backgroundSecondaryColor;

            UserControlHelper.CallEventOnAllPanels(flowLayoutPanelResults, "LoadAppColor", null);
        }

        public void NewParameter(GoToObject goToObject)
        {
            dynamic newObjectData = GoToObjectParser.ParseGoToData(goToObject);
            switch (goToObject.from)
            {
                case Enums.FromEnum.SEARCH:
                case Enums.FromEnum.TRACK:
                    long albumId = newObjectData.album.id;
                    GetAlbum(albumId);
                    break;
                case Enums.FromEnum.ARTIST:
                    break;
            }
        }

        private async void GetAlbum(long id)
        {
            this.albumResponse = await HttpClientExtensions.FindAlbumById(id);
            ShowData();
        }

        private void ShowData()
        {
            labelAlbumName.Text = this.albumResponse.title;
            labelArtistName.Text = this.albumResponse.artist.name;
            labelDateValue.Text = this.albumResponse.release_date;
            labelTracksNumber.Text = $"{this.albumResponse.nb_tracks}";
            labelDurationValue.Text = DateHelper.FormatTime(this.albumResponse.duration);
            LoadImage(this.albumResponse.cover_xl);
            DisplayTracks(this.albumResponse.tracks.data);
            UpdateButtonAddToDownloadState();
        }

        private async void LoadImage(string imageUrl)
        {
            Image image = await HttpClientExtensions.LoadImageFromUrlAsync(imageUrl);
            pictureBoxAlbumCover.Image = image;
        }

        private void DisplayTracks(List<AlbumTrackResponse> tracks)
        {
            flowLayoutPanelResults.Controls.Clear();
            flowLayoutPanelResults.SuspendLayout();
            List<UserControl> searchResults = LoadTracks(tracks);
            flowLayoutPanelResults.Controls.AddRange(searchResults.ToArray());
            flowLayoutPanelResults.ResumeLayout();
            this.ResumeLayout();
        }

        private List<UserControl> LoadTracks(List<AlbumTrackResponse> tracks)
        {
            List<UserControl> uc_tracks = new List<UserControl>();
            if (tracks.Count <= 0)
            {
                return uc_tracks;
            }

            foreach (AlbumTrackResponse track in tracks)
            {
                UC_AlbumTrack albumTrack = new UC_AlbumTrack(track);
                albumTrack.PlayMusicStart += OnMusicSelected;
                albumTrack.GoTo += OnGoTo;
                albumTrack.AddOrRemoveToDownloadQueue += OnAddOrRemoveToDownloadQueue;
                uc_tracks.Add(albumTrack);
            }
            return uc_tracks;
        }
        public bool IsMusicWorkerBusy => uC_MusicPlayer.IsMusicWorkerBusy;
        public void killWorker() { uC_MusicPlayer.killWorker(); }


        private void OnMusicSelected(object sender, AlbumTrackResponse albumTrackResponse)
        {
            MusicSelected musicSelected = new MusicSelected(albumTrackResponse.album.cover_medium, albumTrackResponse.title, albumTrackResponse.artist.name, albumTrackResponse.preview);
            uC_MusicPlayer.OnMusicSelected(musicSelected);
        }

        private void labelArtistName_Click(object sender, EventArgs e)
        {
            GoToObject goToObject = new GoToObject(this.albumResponse, Enums.GoToEnum.ARTIST, Enums.FromEnum.ALBUM);
            OnGoTo(sender, goToObject);
        }

        private void buttonAddToQueue_Click(object sender, EventArgs e)
        {
            foreach (AlbumTrackResponse albumTrack in this.albumResponse.tracks.data)
            {
                if (DownloadQueue.IsInTheDownloadQueue(albumTrack.id))
                {
                    DownloadQueue.RemoveItem(albumTrack.id);
                }
                else
                {
                    ItemToDownload item = new ItemToDownload(albumTrack.artist.name, albumTrack.album.title, albumTrack.album.cover_medium, albumTrack.title, albumTrack.id);
                    DownloadQueue.Add(item);

                }
            }
            OnAddOrRemoveToDownloadQueue(this, 1);
        }

        private void UpdateButtonAddToDownloadState()
        {
            List<long> ids = this.albumResponse.tracks.data.Select(x => x.id).ToList();
            if (Historic.IsAlbumDownloaded(ids))
            {
                buttonAddToQueue.Enabled = false;
                buttonAddToQueue.DisabledState.Image = Properties.Resources.Check;
                return;
            }

            if (DownloadQueue.HaveAllAlbumTracks(ids))
            {
                buttonAddToQueue.Image = Properties.Resources.AddedToList;
            }
            else
            {
                buttonAddToQueue.Image = Properties.Resources.Add;
            }
            UserControlHelper.CallEventOnAllPanels(flowLayoutPanelResults, "UpdateButtonAddToDownloadState", null);
        }

    }
}
