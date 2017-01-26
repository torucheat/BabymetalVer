using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabymetalVer
{
    public class cls_song
    {
        public UInt32 ID
        {
            get;
            set;
        }
        public string Songname
        {
            get;
            set;
        }
        public DateTime Songdauer
        {
            get;
            set;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", Songname, Songdauer);
        }
    }
}
