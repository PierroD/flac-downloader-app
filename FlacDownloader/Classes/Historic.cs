using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Classes
{
    public static class Historic
    {
        public static List<ItemToDownload> downloaded { get; set; }

        public static void Add(ItemToDownload item)
        {
            if (!IsAllReadyDownloaded(item.trackId))
            {
                downloaded.Add(item);
            }

        }

        public static int Count()
        {
            return downloaded.Count;
        }

        public  static bool IsEmpty => downloaded != null && downloaded.Count == 0;

        public static bool IsAllReadyDownloaded(long trackId)
        {
            return downloaded.Any(item => item.trackId == trackId);
        }

        public static void Set(List<ItemToDownload> items)
        {
            downloaded = items;
        }

        public static void Clear()
        {
            downloaded.Clear();
        }

        public static void Remove(ItemToDownload item)
        {
            downloaded.Remove(item);
        }

        public static bool IsDownloaded(long trackId)
        {
            return downloaded.Any(t => t.trackId == trackId);
        }
        public static bool IsAlbumDownloaded(List<long> ids)
        {
            return ids.All(id => IsDownloaded(id));
        }

        public static List<AlbumGroup> GetItemsGroupedByAlbum()
        {
            var groupedByAlbum = new List<AlbumGroup>();
            if(downloaded == null) { return groupedByAlbum; }
            groupedByAlbum = downloaded
                .GroupBy(item => item.albumName)
                .Select(group => new AlbumGroup
                {
                    albumName = group.Key,
                    tracks = group.ToList()
                })
                .ToList();

            return groupedByAlbum;
        }
        public static List<ArtistGroup> GetItemsGroupedByArtist()
        {
            var groupedByArtist = new List<ArtistGroup>();
            if (downloaded == null) { return groupedByArtist; }
            groupedByArtist = downloaded
                .GroupBy(item => item.artistName)
                .Select(group => new ArtistGroup
                {
                    artistName = group.Key,
                    tracks = group.ToList()
                })
                .ToList();

            return groupedByArtist;
        }

        public static List<ItemToDownload> GetItemsByAlbum(string albumName) {
            return downloaded.FindAll(a => a.albumName == albumName);
        }
        public static List<AlbumGroup> GetItemsByArtistGroupedByAlbum(string artisName) {
            return downloaded.FindAll(a => a.artistName == artisName).GroupBy(item => item.albumName).Select(group => new AlbumGroup
            {
                albumName = group.Key,
                tracks = group.ToList()
            }).ToList();
        }
    }

    public class AlbumGroup
    {
        public string albumName { get; set; }
        public List<ItemToDownload> tracks { get; set; }
    }

    public class ArtistGroup
    {
        public string artistName { get; set; }
        public List<ItemToDownload> tracks { get; set; }

    }

}
