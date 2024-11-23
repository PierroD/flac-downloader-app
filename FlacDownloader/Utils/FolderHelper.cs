using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Utils
{
    public class FolderHelper
    {
        public static string SanitizeFolderName(string folderName)
        {
            char[] additionalInvalidChars = { ',', '?', '!', '<', '>', '"', '/', '|', '*', '&', '%', '$', '#' };

            // Get the array of invalid path characters
            char[] invalidPathChars = Path.GetInvalidPathChars();

            // Combine invalid path characters with additional invalid characters
            char[] allInvalidChars = invalidPathChars.Union(additionalInvalidChars).ToArray();

            // Remove invalid characters from the folder name
            string sanitizedFolderName = new string(folderName
                .Where(ch => !allInvalidChars.Contains(ch))
                .ToArray());
            return sanitizedFolderName;
        }
    }
}
