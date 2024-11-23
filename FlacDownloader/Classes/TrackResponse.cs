using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Classes
{
    public class TrackResponse
    {
        public long id { get; set; }
        public bool readable { get; set; }
        public string title { get; set; }
        public string title_short { get; set; }
        public string title_version { get; set; }
        public bool unseen { get; set; }
        public string isrc { get; set; }
        public string link { get; set; }
        public string share { get; set; }
        public int duration { get; set; }
        public int track_position { get; set; }
        public int disk_number { get; set; }
        public long rank { get; set; }
        public string release_date { get; set; }
        public bool explicit_lyrics { get; set; }
        public int explicit_content_lyrics { get; set; }
        public int explicit_content_cover { get; set; }
        public string preview { get; set; }
        public float bpm { get; set; }
        public float gain { get; set; }
        public List<string> available_countries { get; set; }
        public TrackResponse alternative { get; set; }
        public List<ContributorResponse> contributors { get; set; }
        public string md5_image { get; set; }
        public string track_token { get; set; }

        public TrackArtistResponse artist { get; set; }
        public TrackAlbumResponse album { get; set; }

    }

    public class TrackArtistResponse: ArtistResponse
    {
        public string role { get; set; }
    }
    public class TrackAlbumResponse
    {
        public long id { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public string share { get; set; }
        public string cover { get; set; }
        public string cover_small { get; set; }
        public string cover_medium { get; set; }
        public string cover_big { get; set; }
        public string cover_xl { get; set; }
        public string release_date { get; set; }

    }
}
