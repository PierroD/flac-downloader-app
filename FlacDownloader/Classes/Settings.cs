using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Classes
{
    public class Settings
    {
        public bool IsDarkMode { get; set; } = false;
        public string DownloadFolderPath { get; set; } = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\musics";
        public string OutputFormat { get; set; } = "FLAC";
        public bool IsDownloadAutoRetry { get; set; } = false;
        public string ApiUrl { get; set; } = "";
        public string DownloadApiUrl { get; set; } = "";
        public string LatestVersionUrl { get; set; } = "https://raw.githubusercontent.com/PierroD/flac-downloader-app/main/_readmes/lastestVersion.md";
        public string UpdateChangesUrl { get; set; } = "https://raw.githubusercontent.com/PierroD/flac-downloader-app/main/_readmes/updateChanges.md";
        public string UpdateDownloadUrl { get; set; } = "https://raw.githubusercontent.com/PierroD/flac-downloader-app/main/_readmes/updateDownload.md";

    }
}
