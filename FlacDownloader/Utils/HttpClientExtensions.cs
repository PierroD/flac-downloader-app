using FlacDownloader.Classes;
using FlacDownloader.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Utils
{
    class HttpClientExtensions
    {
        private static readonly HttpClient httpClient = new HttpClient();


        public static async Task<T> GetAsync<T>(string url)
        {
            try
            {
                // Send the GET request
                HttpResponseMessage response = await httpClient.GetAsync(url);

                // Ensure the request was successful
                response.EnsureSuccessStatusCode();

                // Read the response body as a string
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);

                // Deserialize the response body to the specified type T
                T result = JsonConvert.DeserializeObject<T>(responseBody);
                return result;
            }
            catch (HttpRequestException e)
            {
                // Handle HTTP request exceptions
                Console.WriteLine($"Request error: {e.Message}");
                return default(T);
            }
            catch (Exception e)
            {
                // Handle JSON deserialization exceptions and other exceptions
                Console.WriteLine($"Unexpected error: {e.Message}");
                return default(T);
            }
        }

        public static async Task<APIResponse<SearchResponse>> Search(string search, SearchByEnum category = SearchByEnum.None, int nextIndex = 0)
        {
            string request = $"{AppSettings.apiUrl}/search?q=";
            if (category != SearchByEnum.None)
            {
                request += $"{category.ToString().ToLower()}:";
            }
            request += $"\"{search}\"";
            if(nextIndex > 0)
            {
                request += $"&index={nextIndex}";
            }
            request = request.Replace(" ", "%20");

            APIResponse<SearchResponse> response = await GetAsync<APIResponse<SearchResponse>>(request);

            return response;

        }

        public static async Task<AlbumResponse> FindAlbumById(long albumId)
        {
            string request = $"{AppSettings.apiUrl}/album/{albumId}";

            AlbumResponse response = await GetAsync<AlbumResponse>(request);

            return response;
        }

        public static async Task<ArtistResponse> FindArtistById(long artistId)
        {
            string request = $"{AppSettings.apiUrl}/artist/{artistId}";

            ArtistResponse response = await GetAsync<ArtistResponse>(request);

            return response;
        }

        public static async Task<TrackResponse> FindTrackById(long trackId)
        {
            string request = $"{AppSettings.apiUrl}/track/{trackId}";

            TrackResponse response = await GetAsync<TrackResponse>(request);

            return response;
        }

        public static async Task<Image> LoadImageFromUrlAsync(string url)
        {
            try
            {
                // Download the image as a byte array
                byte[] imageBytes = await httpClient.GetByteArrayAsync(url);

                // Create a MemoryStream from the byte array and load it as an Image
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
                return null;
            }
        }

    }
}
