using FlacDownloader.Classes;
using FlacDownloader.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlacDownloader.Views
{
    public partial class UC_LocalFilesAlbum : UserControl
    {
        private AlbumGroup albumGroup;
        private ItemToDownload track;

        public delegate void LoadTracksEventHandler(object sender, List<ItemToDownload> tracks);
        public event LoadTracksEventHandler Loadtracks;

        protected virtual void OnLoadTracks()
        {
            Loadtracks?.Invoke(this, albumGroup.tracks);
        }

        public UC_LocalFilesAlbum(AlbumGroup albumGroup)
        {
            InitializeComponent();
            this.albumGroup = albumGroup;

        }

        private void UC_LocalFilesAlbum_Load(object sender, EventArgs e)
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
            buttonOpenFolder.ForeColor = AppColors.primaryColor;
            buttonOpenFolder.FillColor = AppColors.backgroundSecondaryColor;
            buttonSeeTracks.ForeColor = AppColors.primaryColor;
            buttonSeeTracks.FillColor = AppColors.backgroundSecondaryColor;
            separator.ForeColor = AppColors.textColor;
        }

        private async void LoadData()
        {
            this.track = this.albumGroup.tracks.FirstOrDefault();
            labelTitle.Text = this.albumGroup.albumName;
            labelArtsitName.Text = this.track.artistName;

            Image image = await HttpClientExtensions.LoadImageFromUrlAsync(this.track.albumCover);
            pictureBoxAlbumCover.Image = image;
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", this.track.outputFolder);
        }

        private void buttonSeeTracks_Click(object sender, EventArgs e)
        {
            OnLoadTracks();
        }
    }
}
