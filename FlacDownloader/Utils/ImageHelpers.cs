using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Utils
{
    public class ImageHelpers
    {
        public static bool ShouldUseDarkText(Bitmap bitmap, int sampleSize = 10)
        {
            double totalLuminance = 0;
            int sampledPixelCount = 0;

            for (int y = bitmap.Height - 100; y < bitmap.Height; y += sampleSize)
            {
                for (int x = 0; x < bitmap.Width; x += sampleSize)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);

                    double luminance = 0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B;
                    totalLuminance += luminance;
                    sampledPixelCount++;
                }
            }

            double averageLuminance = totalLuminance / sampledPixelCount;
            const double luminanceThreshold = 180;
            return averageLuminance > luminanceThreshold;
        }

    }
}
