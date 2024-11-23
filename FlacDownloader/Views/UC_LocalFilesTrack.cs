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
    public partial class UC_LocalFilesTrack : UserControl
    {
        private ItemToDownload item;
        public UC_LocalFilesTrack(ItemToDownload item)
        {
            InitializeComponent();
            this.item = item;
        }

        private void UC_LocalFilesTrack_Load(object sender, EventArgs e)
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
            separator.ForeColor = AppColors.textColor;
        }

        private async void LoadData()
        {
            labelTitle.Text = this.item.trackName;
            labelArtsitName.Text = this.item.artistName;

            Image image = await HttpClientExtensions.LoadImageFromUrlAsync(this.item.albumCover);
            pictureBoxAlbumCover.Image = image;
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", this.item.outputFolder);

        }
    }
}
