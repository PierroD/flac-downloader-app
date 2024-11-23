using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Classes
{
    public class MusicSelected
    {
        public string albumCover { get; set; }
        public string title { get; set; }
        public string artistName { get; set; }
        public string previewUrl { get; set; }

        public MusicSelected(string albumCover, string title, string artistName, string previewUrl)
        {
            this.albumCover = albumCover;
            this.title = title;
            this.artistName = artistName;
            this.previewUrl = previewUrl;
        }
    }
}
