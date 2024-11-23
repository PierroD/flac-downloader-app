using FlacDownloader.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlacDownloader.Utils
{
    public class HTTPDownloader
    {
        public delegate void DownloadCompletedEventHandler(object sender, HTTPDownloadCompletedEventArgs e);
        public event DownloadCompletedEventHandler DownloadCompleted;

        public delegate void AllDownloadsCompletedEventHandler(object sender, EventArgs e);
        public event AllDownloadsCompletedEventHandler AllDownloadsCompleted;

        private CancellationTokenSource _cancellationTokenSource;

        public async Task DownloadMultipleFilesAsync(List<ItemToDownload> items)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            var downloadTasks = new List<Task>();

            foreach (ItemToDownload item in items)
            {
                downloadTasks.Add(DownloadFileAsync(item, _cancellationTokenSource.Token));
            }

            await Task.WhenAll(downloadTasks);

            AllDownloadsCompleted?.Invoke(this, EventArgs.Empty);
        }

        public async Task DownloadFileAsync(ItemToDownload item, CancellationToken cancellationToken)
        {
            using (HttpClient client = new HttpClient())
            {
                bool isSuccess = true;
                string message = "Download successful.";
                try
                {

                    // Send GET request to the URL
                    HttpResponseMessage response = await client.GetAsync(item.url, cancellationToken);
                    response.EnsureSuccessStatusCode(); // Check if the request was successful

                    // Get the file content as a stream
                    using (Stream contentStream = await response.Content.ReadAsStreamAsync(),
                           fileStream = new FileStream(Path.Combine(item.outputFolder, $"{item.trackName}.{AppSettings.outputFormat.ToLower()}"), FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        await contentStream.CopyToAsync(fileStream, bufferSize: 81920, cancellationToken);
                        // Copy the content stream to the local file
                    }

                }
                catch (Exception ex)
                {
                    isSuccess = false;
                    message = ex.Message;
                }
                finally
                {
                    DownloadCompleted?.Invoke(this, new HTTPDownloadCompletedEventArgs(item, isSuccess, message));
                }

            }
        }

        public void CancelDownloads()
        {
            _cancellationTokenSource.Cancel();
        }

    }
    public class HTTPDownloadCompletedEventArgs : EventArgs
    {
        public ItemToDownload downloadItem { get; }
        public bool isSuccess { get; }
        public string message { get; }

        public HTTPDownloadCompletedEventArgs(ItemToDownload downloadItem, bool isSuccess, string message)
        {
            this.downloadItem = downloadItem;
            this.isSuccess = isSuccess;
            this.message = message;
        }
    }
}
