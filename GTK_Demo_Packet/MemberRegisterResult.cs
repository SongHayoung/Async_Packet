﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTK_Demo_Packet
{
    [Serializable]
    public class MemberRegisterResult : Packet
    {
        public bool result { get; set; }
		public int error_code { get; set;}
    }
}
