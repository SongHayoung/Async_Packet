using System;
namespace GTK_Demo_Packet
{
    [Serializable]
    public class ClosePacket : Packet
    {
        public string id_str { get; set; }
        public ClosePacket()
        {
            this.packet_Type = PacketType.Close;
        }
        public ClosePacket(string id)
        {
            this.packet_Type = PacketType.Close;
            this.id_str = id;
        }
    }
}
