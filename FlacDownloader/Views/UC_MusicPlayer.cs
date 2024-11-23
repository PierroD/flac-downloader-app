using FlacDownloader.Classes;
using FlacDownloader.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlacDownloader.Views
{
    public partial class UC_MusicPlayer : UserControl
    {
        BackgroundWorker musicWorker;
        public UC_MusicPlayer()
        {
            InitializeComponent();
        }
   
        private void UC_MusicPlayer_Load(object sender, EventArgs e)
        {
            musicWorker = new BackgroundWorker();
            musicWorker.WorkerReportsProgress = true;
            musicWorker.WorkerSupportsCancellation = true;
            musicWorker.DoWork += backgroundWorker_DoWork;
            musicWorker.ProgressChanged += backgroundWorker_OnWorkerUpdate;
            LoadAppColor();

        }

        public void LoadAppColor()
        {
            labelTitle.ForeColor = AppColors.textColor;
            labelArtist.ForeColor = AppColors.primaryColor;
            labelArtistName.ForeColor = AppColors.textColor;
            buttonPlayMusic.FillColor = AppColors.backgroundColor;
            trackbarMusic.FillColor = AppColors.backgroundColor;
            labelMusicTime.ForeColor = AppColors.textColor;
            buttonLoud.DisabledState.FillColor = AppColors.backgroundSecondaryColor;
            trackbarVolume.ThumbColor = AppColors.primaryColor;
            trackbarVolume.FillColor = AppColors.backgroundColor;
        }

        public void OnMusicSelected(MusicSelected music)
        {
            LoadImage(music.albumCover);
            labelTitle.Text = music.title;
            labelArtistName.Text = music.artistName;

            windowsMediaPlayerSong.settings.volume = trackbarVolume.Value;
            windowsMediaPlayerSong.URL = music.previewUrl;
            buttonPlayMusic.Image = new Bitmap(Properties.Resources.Pause);
            PlayMusic();

        }

        public void PauseMusic()
        {
            if(windowsMediaPlayerSong.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                windowsMediaPlayerSong.Ctlcontrols.pause();
                buttonPlayMusic.Image = new Bitmap(Properties.Resources.Play);
            }
        }

        private void PlayMusic()
        {
            if (!musicWorker.IsBusy)
            {
                musicWorker.RunWorkerAsync();
            }
            windowsMediaPlayerSong.Ctlcontrols.play();
            buttonPlayMusic.Image = new Bitmap(Properties.Resources.Pause);
        }

        private void buttonPlayMusic_Click(object sender, EventArgs e)
        {
            switch (windowsMediaPlayerSong.playState)
            {
                case WMPLib.WMPPlayState.wmppsPlaying:
                    PauseMusic();
                    break;
                case WMPLib.WMPPlayState.wmppsPaused:
                case WMPLib.WMPPlayState.wmppsStopped:
                    PlayMusic();
                    break;

            }
        }
        private void backgroundWorker_DoWork(object send, DoWorkEventArgs e)
        {
            while (!musicWorker.CancellationPending)
            {
                MusicWorkerState state = new MusicWorkerState(windowsMediaPlayerSong.Ctlcontrols.currentPositionString, windowsMediaPlayerSong.Ctlcontrols.currentPosition);
                musicWorker.ReportProgress(0, state);
                Thread.Sleep(300);
            }
        }

        private void backgroundWorker_OnWorkerUpdate(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is MusicWorkerState musicWorkerState)
            {
                labelMusicTime.Text = $"{musicWorkerState.stringValue}/ 00 : 30";
                trackbarMusic.Value = (int)musicWorkerState.integerValue;
            }
        }

        public void killWorker()
        {
            if (musicWorker.IsBusy)
            {
                musicWorker.CancelAsync();
            }
        }
        public bool IsMusicWorkerBusy => musicWorker.IsBusy;

        private void trackbarVolume_Scroll(object sender, ScrollEventArgs e)
        {
            windowsMediaPlayerSong.settings.volume = trackbarVolume.Value;
        }

        private void windowsMediaPlayerSong_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
            {
                buttonPlayMusic.Image = new Bitmap(Properties.Resources.Play);
                trackbarMusic.Value = 0;
                musicWorker.CancelAsync();
            }
        }

        private async void LoadImage(string imageUrl)
        {
            System.Drawing.Image image = await HttpClientExtensions.LoadImageFromUrlAsync(imageUrl);
            pictureBoxMusicPlaying.Image = image;
        }


    }
}
