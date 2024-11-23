using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Classes
{
    public  class ContributorResponse
    {
        public long id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string share { get; set; }
        public string picture { get; set; }
        public string picture_small { get; set; }
        public string picture_medium { get; set; }
        public string picture_big { get; set; }
        public string picture_xl { get; set; }
        public bool radio { get; set; }
        public string tracklist { get; set; }
        public string role { get; set; }
        public string type { get; set; }

    }
}
