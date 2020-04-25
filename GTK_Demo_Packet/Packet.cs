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
		Error = 0,
		Login,
		Login_RESULT,
		Member_REGISTER,
		Member_REGISTER_RESULT,
        Heart_Beat
	}

	[Serializable]
	public class Packet
	{
		public PacketType packet_Type;
		public int packet_Length;
		public const int Header_Size = 8;
		public byte[] buffer;

		public Packet()
		{
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
		public static PacketType GetPacketType(byte[] data)
		{
			try
			{
				Packet p = (Packet)Packet.Deserialize(data);
				return p.packet_Type;
			}
			catch
			{
				return PacketType.Error;
			}
		}
	}
}