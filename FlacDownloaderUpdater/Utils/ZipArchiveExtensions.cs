﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloaderUpdater.Utils
{
    static class ZipArchiveExtensions
    {
        private static readonly string[] notToUpdate = { "settings.json", "historic.json", "downloadQueue.json", "Guna.UI2.dll", "FlacDownloaderUpdater.exe", "FlacDownloaderUpdater.pdb" };
        public static void ExtractToDirectory(this ZipArchive archive, string destinationDirPath, bool overwrite)
        {
            if (!overwrite)
            {
                // Use the original method.
                archive.ExtractToDirectory(destinationDirPath, false);
                return;
            }
            //  archive.ExtractToDirectory(destinationDirPath + "\\update", true);


            foreach (ZipArchiveEntry entry in archive.Entries)
            {
                string fullPath = Path.Combine(destinationDirPath, entry.FullName);
                if (notToUpdate.Contains(entry.Name))
                    continue;

                if (entry.FullName.Contains("/"))
                {
                    string directory = Path.GetDirectoryName(entry.FullName);
                    string directoryPath = Path.Combine(destinationDirPath, directory);
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }
                }

                // If it's a directory, it doesn't have a "Name".
                if (string.IsNullOrEmpty(entry.Name))
                    Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
                else
                    entry.ExtractToFile(fullPath, true);
            }
        }

    }
}