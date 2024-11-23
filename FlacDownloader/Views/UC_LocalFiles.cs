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
    public partial class UC_LocalFiles : UserControl
    {

        public delegate void GoToEventHandler(object sender, GoToObject goToObject);
        public event GoToEventHandler GoTo;

        private List<ItemToDownload> items;
        private List<AlbumGroup> albums;

        protected virtual void OnGoTo()
        {
            GoToObject goToObject = new GoToObject(null, GoToEnum.HOME, FromEnum.LOCAL_FILES_ALBUM);
            GoTo?.Invoke(this, goToObject);
        }


        public UC_LocalFiles()
        {
            InitializeComponent();
        }


        private void UC_LocalFiles_Load(object sender, EventArgs e)
        {
            LoadAppColor();
        }

        public void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundSecondaryColor;
            labelLocalPath.ForeColor = AppColors.textColor;
            buttonNavigationLeft.FillColor = AppColors.backgroundSecondaryColor; 
            buttonNavigationLeft.DisabledState.FillColor = AppColors.backgroundSecondaryColor; 
            UserControlHelper.CallEventOnAllPanels(flowLayoutPanelResults, "LoadAppColor", null);
        }

        public void NewParameter(LocalFileObject localFileObject)
        {
            this.items = new List<ItemToDownload>();
            this.albums = new List<AlbumGroup>();
            switch (localFileObject.displayType)
            {
                case Enums.LocalFilesEnum.ALBUM:
                    items = Historic.GetItemsByAlbum(localFileObject.name);
                    if (items.Count() > 0)
                    {
                        DisplayMusics(items);
                    }
                    break;
                case Enums.LocalFilesEnum.ARTIST:
                    albums = Historic.GetItemsByArtistGroupedByAlbum(localFileObject.name);
                    if(albums.Count() > 0)
                    {
                        DisplayPhysicalPath($"{AppSettings.downloadFolderPath}\\{localFileObject.name}");
                        DisplayAlbums();
                    }
                    break;
            }
            buttonNavigationLeft.Enabled = false;

        }

        public void DisplayPhysicalPath(string physicalFolder)
        {
            labelLocalPath.Text = physicalFolder;
        }

        public void DisplayMusics(List<ItemToDownload> items =null)
        {
            List<UserControl> uC_LocalFilesTracks = new List<UserControl>();
            items = items ?? this.items;
            foreach (ItemToDownload item in items)
            {
                uC_LocalFilesTracks.Add(new UC_LocalFilesTrack(item));
            }
            DisplayPhysicalPath(items[0].outputFolder);
            DisplayUserControls(uC_LocalFilesTracks);
        }
        public void DisplayAlbums()
        {
            List<UserControl> uC_LocalFilesAlbums = new List<UserControl>();
            foreach (AlbumGroup album in this.albums)
            {
                UC_LocalFilesAlbum uC_LocalFilesAlbum = new UC_LocalFilesAlbum(album);
                uC_LocalFilesAlbum.Loadtracks += OnLoadTracks;
                uC_LocalFilesAlbums.Add(uC_LocalFilesAlbum);
            }
            DisplayUserControls(uC_LocalFilesAlbums);
        }

        public void DisplayUserControls(List<UserControl> userControls)
        {
            flowLayoutPanelResults.Controls.Clear();
            flowLayoutPanelResults.SuspendLayout();
            flowLayoutPanelResults.Controls.AddRange(userControls.ToArray());
            flowLayoutPanelResults.ResumeLayout();
            this.ResumeLayout();
        }

        private void OnLoadTracks(object sender, List<ItemToDownload> tracks)
        {
            DisplayMusics(tracks);
            buttonNavigationLeft.Enabled = true;
        }

        private void buttonNavigationLeft_Click(object sender, EventArgs e)
        {
            buttonNavigationLeft.Enabled = false;
            DisplayAlbums();
        }
    }
}
