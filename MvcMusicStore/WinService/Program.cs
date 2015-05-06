using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            if (null != args && 0 < args.Length && args[0].ToUpper().Equals("DEBUG"))
                runAsConsole();
            else
                runAsService();
        }

        private static void runAsConsole()
        {
            TestService service = new TestService();
            Console.WriteLine("Press [RETURN] to start and [RETURN] to stop.");
            Console.ReadLine();
            service.StartService();
            Console.ReadLine();
            service.StopService();
        }

        private static void runAsService()
        {
            ServiceBase.Run(new TestService());
        }
    }
}
