using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTK_Demo_Packet
{
    [Serializable]
    public class Login : Packet
    {
        public string id_str { get; set; }
        public string pw_str { get; set; }
        public string ip_str { get; set; }
        public string port_str { get; set; }
    }
}
