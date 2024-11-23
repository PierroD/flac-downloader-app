using FlacDownloader.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Utils
{
    public class GoToObjectParser
    {

        public static dynamic ParseGoToData(GoToObject goToObject)
        {
            switch (goToObject.from)
            {
                case Enums.FromEnum.SEARCH:
                    return (SearchResponse)goToObject.data;
                case Enums.FromEnum.ALBUM:
                    return (AlbumResponse)goToObject.data;
                case Enums.FromEnum.ARTIST:
                    return (ArtistResponse)goToObject.data;
                case Enums.FromEnum.TRACK:
                    return (TrackResponse)goToObject.data;
                case Enums.FromEnum.ALBUM_TRACK:
                    return (AlbumTrackResponse)goToObject.data;
                default:
                    return null;
            }
        }

    }
}
