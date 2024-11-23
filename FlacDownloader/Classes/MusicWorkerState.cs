using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Classes
{
    public class MusicWorkerState
    {
        public string stringValue { get; set; }
        public double integerValue { get; set; }
    
        public MusicWorkerState(string strValue, double intValue) {
            stringValue = strValue;
            integerValue = intValue;
        }
    }
}
