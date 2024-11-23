using FlacDownloaderUpdater.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlacDownloaderUpdater
{
    public partial class FormFlacDownloaderUpdater : Form
    {
        private string downloadUrl;
        private string appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private string tempZipPath =$"{Path.GetTempPath()}FlacDownloader-{Guid.NewGuid()}.zip";

        public FormFlacDownloaderUpdater(string downloadUrl, bool isDarkMode)
        {
            InitializeComponent();
            this.downloadUrl = downloadUrl;
            AppSettings.isDarkMode = isDarkMode;
        }

        private async void FormFlacDownloaderUpdater_Load(object sender, EventArgs e)
        {
            LoadAppColor();
            await StartDownloadAndExtractProcess(this.downloadUrl, this.tempZipPath);
        }

        private void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundSecondaryColor;
            labelUpdateStatus.ForeColor = AppColors.textColor;
            buttonLaunch.FillColor = AppColors.backgroundSecondaryColor;
            buttonLaunch.ForeColor = AppColors.primaryColor;
            buttonLaunch.DisabledState.FillColor = AppColors.backgroundSecondaryColor;

            buttonClose.FillColor = AppColors.backgroundSecondaryColor;
            buttonClose.IconColor = AppColors.textColor;

            progressbarUpdateProgress.FillColor = AppColors.backgroundSecondaryColor;
            progressbarUpdateProgress.ProgressColor = AppColors.primaryColor;
            progressbarUpdateProgress.ProgressColor2 = AppColors.primaryColor;
        }

        private async Task StartDownloadAndExtractProcess(string downloadUrl, string destinationPath)
        {
            try
            {
                string[] updateDownloads;
                using (var wc = new WebClient())
                    updateDownloads = wc.DownloadString(downloadUrl).Split(new[] { '\r', '\n' });
                string latestUpdateUrl = updateDownloads[0];
                labelUpdateStatus.Text = "Downloading update...";
                await DownloadFileAsync(latestUpdateUrl, destinationPath);
                labelUpdateStatus.Text = "Download completed.";
                labelUpdateStatus.Text = "Extracting update...";
                ExtractZipFile(destinationPath);
                labelUpdateStatus.Text = "Update extracted successfully.";
                buttonLaunch.Enabled = true;
            }
            catch (Exception ex)
            {
                labelUpdateStatus.Text = "Error: " + ex.Message;
                DialogResult result = MessageBox.Show($"Download failed : {ex.Message} \n Do you want to retry ?", "Download Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    await StartDownloadAndExtractProcess(this.downloadUrl, this.tempZipPath);
                }
            }
            finally
            {
                // btnDownload.Enabled = true;
                buttonLaunch.Enabled = true;
                buttonClose.Visible = true;
            }
        }

        private async Task DownloadFileAsync(string fileUrl, string destinationPath)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(fileUrl, HttpCompletionOption.ResponseHeadersRead))
                {
                    response.EnsureSuccessStatusCode();

                    using (Stream contentStream = await response.Content.ReadAsStreamAsync(),
                          fileStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
                    {
                        var totalBytes = response.Content.Headers.ContentLength;
                        var totalRead = 0L;
                        var buffer = new byte[8192];
                        var isMoreToRead = true;

                        do
                        {
                            var read = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                            if (read == 0)
                            {
                                isMoreToRead = false;
                                await Task.CompletedTask;
                            }
                            else
                            {
                                await fileStream.WriteAsync(buffer, 0, read);
                                totalRead += read;

                                if (totalBytes.HasValue)
                                {
                                    var progress = (int)((totalRead * 1d) / (totalBytes.Value * 1d) * 100);
                                    progressbarUpdateProgress.Value = progress;
                                    labelUpdateStatus.Text = $"Downloading... {progress}%";
                                }
                            }
                        }
                        while (isMoreToRead);
                    }
                }
            }
        }

        private void ExtractZipFile(string zipPath)
        {
            using (var stream = File.OpenRead(zipPath))
            using (ZipArchive archive = new ZipArchive(stream))
                ZipArchiveExtensions.ExtractToDirectory(archive, this.appPath, true);
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            Process.Start($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\FlacDownloader.exe");
            Application.Exit();
        }
    }
}
