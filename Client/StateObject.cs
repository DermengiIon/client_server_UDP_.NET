﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class StateObject
    {
        public Socket workSocket = null;
        public const int BUFFER_SIZE = 65000;
        public byte[] buffer = new byte[BUFFER_SIZE];
        public StringBuilder frame = new StringBuilder();
    }
}
