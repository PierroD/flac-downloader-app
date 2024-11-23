using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Classes
{
    public class GenreDataResponse
    {
        public List<GenreResponse> data { get; set; } 
    }

    public class GenreResponse
    {
        public long id { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
        public string picture_small { get; set; }
        public string picture_medium { get; set; }
        public string picture_big { get; set; }
        public string picture_xl { get; set; }
        public string type { get; set; }

    }
}
