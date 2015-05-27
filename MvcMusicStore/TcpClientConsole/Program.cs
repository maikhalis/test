using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ZeroMQ;

namespace TcpClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = ZContext.Create())
            {
                using (var requester = new ZSocket(context, ZSocketType.REQ))
                {
                    requester.Connect("tcp://127.0.0.1:5454");
                    var noDataSend = false;

                    do
                    {
                        Console.WriteLine("INPUT?");
                        var input = Console.ReadLine();
                        if (string.IsNullOrEmpty(input))
                        {
                            noDataSend = true;
                            Console.WriteLine("Bye");
                        }
                        else
                        {
                            requester.SendFrame(new ZFrame(input));
                            using (ZFrame reply = requester.ReceiveFrame())
                            {
                                Console.WriteLine(reply.ReadString());
                            }
                        }

                    } while (!noDataSend);
                }
            }
            Console.ReadLine();
        }
    }
}