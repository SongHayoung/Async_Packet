using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTK_Demo_Packet
{
    [Serializable]
    public class KeepAlive : Packet
    {
        public string id_str { get; set; }
        public string ip_str { get; set; }
        public string port { get; set; }
        public bool result { get; set; }
    }
}

