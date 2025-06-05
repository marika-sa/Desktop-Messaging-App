using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopMessageApp1
{
    class MMS : Message
    {
        public bool Picture { get; set; }
        public bool Audio { get; set; }
        public bool Video { get; set; }
        public string FileName { get; set; }

        public MMS()
        {

        }
    }
}
