using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace mikmakGUI
{
    class Client
    {
        public static Socket client_socket { get; set; }
        public  static object locker { get; set; }

    }

}
