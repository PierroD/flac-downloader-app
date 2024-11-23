using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Classes
{
    public class SearchResponse
    {
        public long id {  get; set; }
        public bool readable {  get; set; }
        public string title {  get; set; }
        public string title_short {  get; set; }
        public string title_version {  get; set; }
        public string link {  get; set; }
        public int duration {  get; set; }
        public long rank {  get; set; }
        public bool explicit_lyrics {  get; set; }
        public string preview {  get; set; }
        public SearchArtistResponse artist {  get; set; }
        public AlbumResponse album {  get; set; }
        public string type { get; set; }
    }

    public class SearchArtistResponse
    {
        public long id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string picture { get; set; }
        public string picture_small { get; set; }
        public string picture_medium { get; set; }
        public string picture_big { get; set; }
        public string picture_xl { get; set; }
        public string type { get; set; }

    }

    public class SearchAlbumResponse
    {
        public long id { get; set; }
        public string title { get; set; }
        public string cover { get; set; }
        public string cover_small { get; set; }
        public string cover_medium { get; set; }
        public string cover_big { get; set; }
        public string cover_xl { get; set; }
        public string type { get; set; }

    }
}
