using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GTK_Demo_Packet
{
    public enum PacketType : int
    {
        Login = 0,
        Login_RESULT,
        Member_REGISTER,
        Member_REGISTER_RESULT
    }

    [Serializable]
    public class Packet
    {
        public int packet_Type;
        public int packet_Length;

        public Packet()
        {
            this.packet_Type = 0;
            this.packet_Length = 0;
        }

        public static byte[] Serialize(object data)
        {
            try
            {
                MemoryStream ms = new MemoryStream(1024 * 4);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, data);
                return ms.ToArray();
            }
            catch
            {
                return null;
            }
        }
        public static Object Deserialize(byte[] data)
        {
            try
            {
                MemoryStream ms = new MemoryStream(1024 * 4);
                ms.Write(data, 0, data.Length);

                ms.Position = 0;
                BinaryFormatter bf = new BinaryFormatter();
                object obj = bf.Deserialize(ms);
                ms.Close();
                return obj;
            }
            catch
            {
                return null;
            }
        }
    }
}
