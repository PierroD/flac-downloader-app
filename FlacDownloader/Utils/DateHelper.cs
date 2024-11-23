using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Utils
{
    public class DateHelper
    {
        public static string FormatTime(int totalSeconds)
        {
            // Calculate hours, minutes, and seconds
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            // Format the result as "HH h MM m SS s"
            return $"{hours:D2} h {minutes:D2} m {seconds:D2} s";
        }

        public static string FormatTimeToMMSS(int totalSeconds)
        {
            return $"{Math.Round((double)totalSeconds / 60, 2)}".Replace(",", ":").Replace(".", ":");
        }
    }
}
