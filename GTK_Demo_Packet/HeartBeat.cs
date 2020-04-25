using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTK_Demo_Packet
{
    [Serializable]
    public class HeartBeat : Packet
    {
        public string msg { get; set; }
        public string id_str { get; set; }
        public HeartBeat() {
            this.packet_Type = PacketType.Heart_Beat;
        }
        public HeartBeat(string id){
            this.packet_Type = PacketType.Heart_Beat;
            id_str = id;
        }
    }
}

