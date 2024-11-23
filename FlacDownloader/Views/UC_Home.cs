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
    public partial class UC_Home : UserControl
    {
        private List<UC_HomeAlbumCard> uC_HomeAlbumCards;
        private List<UC_HomeArtistCard> uC_HomeArtistCards;

        public delegate void GoToEventHandler(object sender, GoToObject goToObject);
        public event GoToEventHandler GoTo;

        protected virtual void OnGoTo(object sender, GoToObject goToObject)
        {
            GoTo?.Invoke(this, goToObject);
        }

        public UC_Home()
        {
            InitializeComponent();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            LoadAppColor();
            LoadData();
        }

        public void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundSecondaryColor;
            labelArtists.ForeColor = AppColors.textColor;
            labelAlbum.ForeColor = AppColors.textColor;
            labelDownloaded.ForeColor = AppColors.textColor;
            buttonRefresh.FillColor = AppColors.backgroundSecondaryColor;
            UserControlHelper.CallEventOnAllPanels(flowLayoutPanelArtists, "LoadAppColor", null);
            UserControlHelper.CallEventOnAllPanels(flowLayoutPanelAlbums, "LoadAppColor", null);
        }

        public void LoadData()
        {
            if (Historic.IsEmpty) { return; }

            uC_HomeAlbumCards = new List<UC_HomeAlbumCard>();
            uC_HomeArtistCards = new List<UC_HomeArtistCard>();

            foreach (AlbumGroup album in Historic.GetItemsGroupedByAlbum())
            {
                UC_HomeAlbumCard albumCard = new UC_HomeAlbumCard(album);
                albumCard.GoTo += OnGoTo;
                uC_HomeAlbumCards.Add(albumCard);
            }

            foreach (ArtistGroup artist in Historic.GetItemsGroupedByArtist())
            {
                UC_HomeArtistCard artistCard = new UC_HomeArtistCard(artist);
                artistCard.GoTo += OnGoTo;
                uC_HomeArtistCards.Add(artistCard);
            }
            ReloadAlbums(uC_HomeAlbumCards);
            ReloadArtists(uC_HomeArtistCards);
        }

        private void ReloadAlbums(List<UC_HomeAlbumCard> cards)
        {
            flowLayoutPanelAlbums.Controls.Clear();
            flowLayoutPanelAlbums.SuspendLayout();
            flowLayoutPanelAlbums.Controls.AddRange(cards.ToArray());
            flowLayoutPanelAlbums.ResumeLayout();
            this.ResumeLayout();

        }
        private void ReloadArtists(List<UC_HomeArtistCard> cards)
        {
            flowLayoutPanelArtists.Controls.Clear();
            flowLayoutPanelArtists.SuspendLayout();
            flowLayoutPanelArtists.Controls.AddRange(cards.ToArray());
            flowLayoutPanelArtists.ResumeLayout();
            this.ResumeLayout();

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
