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
    public partial class UC_HomeArtistCard : UserControl
    {
        private ArtistGroup artist;
        

        public delegate void GoToEventHandler(object sender, GoToObject goToObject);
        public event GoToEventHandler GoTo;

        protected virtual void OnGoTo()
        {
            LocalFileObject localFileObject = new LocalFileObject(LocalFilesEnum.ARTIST, this.artist.artistName);
            GoToObject goToObject = new GoToObject(localFileObject, GoToEnum.LOCAL_FILES_ARTIST, FromEnum.HOME);
            GoTo?.Invoke(this, goToObject);
        }


        public UC_HomeArtistCard(ArtistGroup artist)
        {
            this.artist = artist;
            InitializeComponent();
        }

        private void UC_HomeArtistCard_Load(object sender, EventArgs e)
        {
            LoadAppColor();
            LoadData();
        }

        public void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundColor;
            labelArtistName.ForeColor = AppColors.textColor;
        }

        private void LoadData()
        {
            labelArtistName.Text = this.artist.artistName;
        }
        private void OnCard_DoubleClick(object sender, EventArgs e)
        {
            OnGoTo();
        }

    }
}
