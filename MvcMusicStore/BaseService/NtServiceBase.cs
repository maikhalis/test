using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace BaseService
{
    /// <summary> Base class for Nt Service. </summary>
    public partial class NtServiceBase : ServiceBase, INtServiceBase
    {
        // base logger
        protected readonly ILog logger = LogManager.GetLogger(typeof(NtServiceBase));
        // service flag
        protected bool isRunning;

        /// <summary> Basic constructor. </summary>
        /// <param name="name"> the service name. </param>
        public NtServiceBase(string name)
        {
            logger.Debug("InitializeComponent Start");
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("A valid name must be provided for Nt service.");
            if (ServiceBase.MaxNameLength < name.Length)
                throw new ArgumentException("Nt Service name exceeds internal length caracters limit.");
            InitializeComponent();
            this.ServiceName = name;
            logger.Debug("InitializeComponent End");
        }

        /// <summary> The service is running or not? </summary>
        public bool IsRunning
        {
            get { return this.isRunning; }
            set { this.isRunning = value; }
        }

        /// <summary> Launch the service in console mode. </summary>
        public virtual void StartService()
        {
            this.OnStart(null);
        }

        /// <summary> Stop the service in console mode. </summary>
        public virtual void StopService()
        {
            this.OnStop();
        }
    }
}