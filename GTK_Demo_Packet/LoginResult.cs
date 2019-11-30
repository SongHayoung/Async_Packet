using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTK_Demo_Packet
{
    [Serializable]
    public class LoginResult : Packet
    {
        public bool result { get; set; }
		public string msg { get; set; }

		public LoginResult()
		{
			this.packet_Type = PacketType.Login_RESULT;
		}
    }
}
