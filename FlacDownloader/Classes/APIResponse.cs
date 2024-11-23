using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Classes
{
    public class APIResponse<T>
    {
        public List<T> data { get; set; }
        public int total { get; set; }
        public string next { get; set; }
    }
}
