using FlacDownloader.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Classes
{
    public class LocalFileObject
    {
        public LocalFilesEnum displayType { get; set; }
        public string name { get; set; }

        public LocalFileObject(LocalFilesEnum displayType, string name)
        {
            this.displayType = displayType;
            this.name = name;
        }
    }
}
