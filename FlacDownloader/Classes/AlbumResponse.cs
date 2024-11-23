using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Classes
{
    public class AlbumResponse
    {
        public long id { get; set; }
        public string title { get; set; }
        public string upc { get; set; }
        public string link { get; set; }
        public string share { get; set; }
        public string cover { get; set; }
        public string cover_small { get; set; }
        public string cover_medium { get; set; }
        public string cover_big { get; set; }
        public string cover_xl { get; set; }
        public string md5_image { get; set; }
        public int genre_id { get; set; }
        public GenreDataResponse genres { get; set; }
        public string label { get; set; }
        public int nb_tracks { get; set; }
        public int duration { get; set; }
        public long fans { get; set; }
        public string release_date { get; set; }
        public string record_type { get; set; }
        public bool available { get; set; }
        public object alternative { get; set; }
        public string tracklist { get; set; }
        public bool explicit_lyrics { get; set; }
        public int explicit_content_lyrics { get; set; }
        public int explicit_content_cover { get; set; }
        public List<ContributorResponse> contributors { get; set; }
        public object fallback { get; set; }
        public ArtistResponse artist { get; set; }
        public string type { get; set; }
        public AlbumDataTrackResponse tracks { get; set; }

    }

    public class AlbumDataTrackResponse
    {
        public List<AlbumTrackResponse> data { get; set; }
    }

    public class AlbumTrackResponse
    {
        public long id { get; set; }
        public bool readable { get; set; }
        public string title { get; set; }
        public string title_short { get; set; }
        public string title_version { get; set; }
        public string link { get; set; }
        public int duration { get; set; }
        public long rank { get; set; }
        public bool explicit_lyrics { get; set; }
        public int explicit_content_lyrics { get; set; }
        public int explicit_content_cover { get; set; }
        public string preview { get; set; }
        public string md5_image { get; set; }
        public AlbumTrackArtistResponse artist { get; set; }
        public AlbumTrackAlbumResponse album { get; set; }
        public string type { get; set; }

    }

    public class AlbumTrackArtistResponse
    {
        public long id { get; set; }
        public string name { get; set; }
        public string tracklist { get; set; }
        public string type { get; set; }

    }

    public class AlbumTrackAlbumResponse
    {
        public long id { get; set; }
        public string title { get; set; }
        public string cover { get; set; }
        public string cover_small { get; set; }
        public string cover_medium { get; set; }
        public string cover_big { get; set; }
        public string cover_xl { get; set; }
        public string md5_image { get; set; }
        public string tracklist { get; set; }
        public string type { get; set; }

    }


}
