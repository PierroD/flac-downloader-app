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
using static System.Net.Mime.MediaTypeNames;

namespace FlacDownloader.Views
{
    public partial class UC_HomeAlbumCard : UserControl
    {
        private AlbumGroup album;
        private ItemToDownload track;

        public delegate void GoToEventHandler(object sender, GoToObject goToObject);
        public event GoToEventHandler GoTo;

        protected virtual void OnGoTo()
        {
            LocalFileObject localFileObject = new LocalFileObject(LocalFilesEnum.ALBUM, this.album.albumName);
            GoToObject goToObject = new GoToObject(localFileObject, GoToEnum.LOCAL_FILES_ALBUM, FromEnum.HOME);
            GoTo?.Invoke(this, goToObject);
        }


        public UC_HomeAlbumCard(AlbumGroup album)
        {
            this.album = album;
            this.track = album.tracks.Count() > 0 ? album.tracks[0] : null;
            InitializeComponent();
        }

        private void UC_HomeAlbumCard_Load(object sender, EventArgs e)
        {
            LoadAppColor();
            LoadData();

        }

        public async void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundColor;
            pictureBoxAlbum.BackColor = AppColors.backgroundColor;
            pictureBoxAlbum.FillColor = AppColors.backgroundColor;
            labelAlbumName.ForeColor = AppColors.textColor;
            labelAlbumName.Parent = pictureBoxAlbum;
            if (track == null || track.albumCover == null || track.albumCover.Length <= 0)
            {
                return;
            }
            System.Drawing.Image image = await HttpClientExtensions.LoadImageFromUrlAsync(track.albumCover);
            pictureBoxAlbum.Image = image;

            bool shouldUseDarkText = ImageHelpers.ShouldUseDarkText(new Bitmap(image));

            labelAlbumName.ForeColor = AppColors.AdaptativeTextColor(shouldUseDarkText);


        }

        private void LoadData()
        {
            if (track == null) return;
            labelAlbumName.Text = this.album.albumName;
        }

        private void OnCard_DoubleClick(object sender, EventArgs e)
        {
            OnGoTo();
        }

    }
}
