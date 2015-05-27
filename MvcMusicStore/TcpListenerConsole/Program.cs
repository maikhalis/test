using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZeroMQ;

namespace TcpListenerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ZContext context = ZContext.Create())
            {
                using (ZSocket responder = new ZSocket(context, ZSocketType.REP))
                {
                    responder.Bind("tcp://*:5454");

                    while (true)
                    {
                        using (ZFrame request = responder.ReceiveFrame())
                        {
                            Console.WriteLine(request.ReadString());
                            Thread.Sleep(1);
                            responder.SendFrame(new ZFrame("OK"));
                        }
                    }
                }
            }
        }
    }
}
