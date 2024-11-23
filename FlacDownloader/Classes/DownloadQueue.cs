using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FlacDownloader.Classes
{
    public static class DownloadQueue
    {
        public static List<ItemToDownload> downloadQueue { get; set; }

        public static void Add(ItemToDownload item)
        {
            if (!IsInTheDownloadQueue(item.trackId))
            {
                downloadQueue.Add(item);
            }
        }

        public static void RemoveItem(ItemToDownload item)
        {
            downloadQueue.Remove(item);
        }

        public static void RemoveItem(long trackId)
        {
            ItemToDownload itemToDelete = downloadQueue.Find(item => item.trackId == trackId);
            downloadQueue.Remove(itemToDelete);
        }

        public static List<ItemToDownload> RemoveAndReturn(long  trackId)
        {
            ItemToDownload itemToDelete = downloadQueue.Find(item => item.trackId == trackId);
            downloadQueue.Remove(itemToDelete);
            return downloadQueue;

        }

        public static void Clear()
        {
            downloadQueue.Clear();
        }

        public static int Count()
        {
            return downloadQueue.Count;
        }

        public static bool Contains(ItemToDownload item)
        {
            return downloadQueue.Contains(item);
        }
        public static bool IsInTheDownloadQueue(long trackId)
        {
            return downloadQueue.Any(item => item.trackId == trackId);
        }

        public static bool HaveAllAlbumTracks(List<long> ids)
        {
            foreach (long id in ids)
            {
                if(!IsInTheDownloadQueue(id))
                {
                    return false;
                }
            }
            return true;
        }

        public static void Set(List<ItemToDownload> items)
        {
            downloadQueue = items;
        }
    }

    public class ItemToDownload
    {
        public string artistName { get; set; }
        public string albumName { get; set; }
        public string albumCover { get; set; }
        public string trackName { get; set; }
        public long trackId { get; set; }
        public string url { get; set; }
        public string outputFolder{ get; set; }

        public ItemToDownload(string artistName, string albumName, string albumCover, string trackName, long trackId)
        {
            this.artistName = artistName;
            this.albumName = albumName;
            this.albumCover = albumCover;
            this.trackName = trackName;
            this.trackId = trackId;
        }
    }
}
