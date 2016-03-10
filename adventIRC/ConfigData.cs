using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventIRC
{
    class ConfigData
    {
        public string server, name, pass;
        public int port;
        public List<string> chans, chanPass;

        public ConfigData()
        {
            chans = new List<string>();
            chanPass = new List<string>();
        }

    }
}
