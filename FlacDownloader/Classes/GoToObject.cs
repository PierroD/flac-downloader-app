using FlacDownloader.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlacDownloader.Classes
{
    public class GoToObject {
        public object data { get; set; }
        public GoToEnum goTo { get; set; }
        public FromEnum from { get; set; }
        public GoToObject(object objectData, GoToEnum objectGoTo, FromEnum objectFrom) {
            this.data = objectData;
            this.goTo = objectGoTo;
            this.from = objectFrom;
        }
    }
}
