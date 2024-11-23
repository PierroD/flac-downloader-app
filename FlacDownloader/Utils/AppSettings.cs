using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Utils
{
    static class AppSettings
    {
        public static bool isDarkMode { get; set; }
        public static string downloadFolderPath { get; set; }
        public static string outputFormat { get; set; }
        public static bool isDownloadAutoRetry { get; set; }
        public static string apiUrl{ get; set; }
        public static string downloadApiUrl { get; set; }
        public static string appVersion { get; set; } = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        public static string latestVersion { get; set; }
        public static string latestVersionUrl { get; set; }
        public static string updateChangesUrl { get; set; }
        public static string updateDownloadUrl { get; set; }


    }
}
