using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mikmakGUI
{
    static class Program
    {
         
   
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
        static void Main()
        {
            
            while (true)
            {
                try
                {
                    Client.client_socket =  GetSocket.ConnectSocket("127.0.0.1", 1234);
                    Client.locker = new object();
                    break;
                }
                catch
                {
                    continue;
                }
            }

            Application.Run(new login());


        }
    }
}
