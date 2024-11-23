using FlacDownloader.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Utils
{
    public class YTdlpDownloader
    {
        public delegate void DownloadCompletedEventHandler(object sender, YTdlpDownloadCompletedEventArgs e);
        public event DownloadCompletedEventHandler DownloadCompleted;
        private string ytdlpPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "tools", "yt-dlp.exe");
        public Task DownloadMusicInParallel(List<ItemToDownload> items)
        {
            var tasks = new List<Task>();

            foreach (var item in items)
            {
                tasks.Add(Task.Run(() => DownloadMusic(item)));
            }

            return Task.WhenAll(tasks);
        }

        public void DownloadMusic(ItemToDownload item)
        {
            bool isSuccess = true;
            string message = "Download successful.";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = $".\\tools\\yt-dlp.exe",
                    Arguments = $"-x --embed-thumbnail --audio-format {AppSettings.outputFormat.ToLower()} -o \"{item.outputFolder}\\%(title)s.%(ext)s\" -P \"{item.url}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = false // true
                };

                using (Process process = Process.Start(psi))
                {
                    process.OutputDataReceived += (s, e) => Console.WriteLine(e.Data);
                    process.ErrorDataReceived += (s, e) => Console.WriteLine($"ERROR: {e.Data}");

                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                isSuccess = false;
                message = ex.Message;
            }
            finally
            {
                DownloadCompleted?.Invoke(this, new YTdlpDownloadCompletedEventArgs(item, isSuccess, message));
            }

        }
    }

    public class YTdlpDownloadCompletedEventArgs : EventArgs
    {
        public ItemToDownload downloadItem {  get; }
        public bool isSuccess { get; }
        public string message { get; }

        public YTdlpDownloadCompletedEventArgs(ItemToDownload downloadItem, bool isSuccess, string message)
        {
            this.downloadItem = downloadItem;
            this.isSuccess = isSuccess;
            this.message = message;
        }
    }
}
