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
    public partial class UC_Artist : UserControl
    {
        private ArtistResponse artistResponse { get; set; }
        public UC_Artist()
        {
            InitializeComponent();
        }

        public void NewParameter(GoToObject goToObject)
        {
            dynamic newObjectData = GoToObjectParser.ParseGoToData(goToObject);
            switch (goToObject.from)
            {
                case Enums.FromEnum.SEARCH:
                case Enums.FromEnum.TRACK:
                case Enums.FromEnum.ALBUM:
                case Enums.FromEnum.ALBUM_TRACK:
                    long artistId = newObjectData.artist.id;
                    GetArtist(artistId);
                    break;
            }
        }

        private void UC_Artist_Load(object sender, EventArgs e)
        {
            LoadAppColor();
        }

        public void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundSecondaryColor;
            panelCover.FillColor = AppColors.accentColor;
            panelCover.BackColor = AppColors.accentColor;
            panelCover.ForeColor = AppColors.accentColor;
            labelArtistName.ForeColor = AppColors.textColor;
            labelArtistName.BackColor = AppColors.accentColor;
            labelAlbums.ForeColor = AppColors.textColor;
            labelAlbums.BackColor = AppColors.accentColor;
            labelAlbumNumber.ForeColor = AppColors.textColor;
            labelAlbumNumber.BackColor = AppColors.accentColor;
            labelFans.ForeColor = AppColors.textColor;
            labelFans.BackColor = AppColors.accentColor;
            labelFanNumber.ForeColor = AppColors.textColor;
            labelFanNumber.BackColor = AppColors.accentColor;

        }

        private async void GetArtist(long id)
        {
            this.artistResponse = await HttpClientExtensions.FindArtistById(id);
            ShowData(this.artistResponse);
        }

        private void ShowData(ArtistResponse artistResponse)
        {
            labelArtistName.Text = this.artistResponse.name;
            labelAlbumNumber.Text = $"{this.artistResponse.nb_album}";
            labelFanNumber.Text = $"{this.artistResponse.nb_fan}";
            LoadImage(this.artistResponse.picture_medium);

        }
        private async void LoadImage(string imageUrl)
        {
            Image image = await HttpClientExtensions.LoadImageFromUrlAsync(imageUrl);
            pictureBoxArtistPicture.Image = image;
        }
    }
}
