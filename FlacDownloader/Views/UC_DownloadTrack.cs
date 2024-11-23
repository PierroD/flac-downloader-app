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
    public partial class UC_DownloadTrack : UserControl
    {
        public string artistName { get; set; }
        public string albumName { get; set; }
        public string albumCover { get; set; }
        public string trackName { get; set; }
        public long trackId { get; set; }

        public delegate void DeleteTrackEventHandler(object sender, long trackId);
        public event DeleteTrackEventHandler DeleteTrack;

        protected virtual void OnDeleteTrack(long trackId)
        {
            DeleteTrack?.Invoke(this, trackId);
        }

        public UC_DownloadTrack()
        {
            InitializeComponent();
        }

        private void UC_DownloadTrack_Load(object sender, EventArgs e)
        {
            LoadAppColor();
            labelTitle.Text = trackName;
            labelArtsitName.Text = artistName;
            LoadImage();
        }

        public void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundSecondaryColor;
            labelTitle.ForeColor = AppColors.textColor;
            labelArtist.ForeColor = AppColors.primaryColor;
            labelArtsitName.ForeColor = AppColors.textColor;
            separator.ForeColor = AppColors.textColor;
            buttonDelete.FillColor = AppColors.backgroundColor;

        }

        private async void LoadImage()
        {
            Image image = await HttpClientExtensions.LoadImageFromUrlAsync(albumCover);
            pictureBoxAlbumCover.Image = image;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ToogleDeleteButton(false);
            OnDeleteTrack(trackId);
        }

        public void ToogleDeleteButton(bool isEnable)
        {
            buttonDelete.Enabled = isEnable;
        }
    }
}
