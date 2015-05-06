using BaseService;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinService
{
    /// <summary> test Service implementation. </summary>
    public class TestService : NtServiceBase
    {
        // current class logger
        private readonly ILog currentLogger = LogManager.GetLogger(typeof(TestService));

        // internal main thread
        private Thread mainThread = null;

        /// <summary> Basic constructor. </summary>
        public TestService()
            : base("TestService") { }

        /// <summary> Called on starting service process. </summary>
        /// <param name="args"> parameters if any. </param>
        protected override void OnStart(string[] args)
        {
            currentLogger.Debug("OnStart Enter");
            mainThread = new Thread(new ThreadStart(this.MainLoop));
            mainThread.Name = "MAIN";
            mainThread.Start();
            currentLogger.Debug("OnStart Exit");
        }

        /// <summary> Called on stopping service. </summary>
        protected override void OnStop()
        {
            currentLogger.Debug("OnStop Enter");
            this.IsRunning = false;
            currentLogger.Debug("OnStop Exit");
        }

        /// <summary> Main processing loop. </summary>
        private void MainLoop()
        {
            this.IsRunning = true;
            currentLogger.Debug("MainLoop Enter");
            do
            {
                // Do something
                currentLogger.Debug("Processing...");

                Thread.Sleep(1000);
            } while (this.IsRunning);
            currentLogger.Debug("MainLoop Exit");
        }
    }
}