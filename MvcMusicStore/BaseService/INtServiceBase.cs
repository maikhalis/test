using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseService
{
    /// <summary> Base interface for all services. </summary>
    public interface INtServiceBase
    {
        /// <summary> The service is running or not? </summary>
        bool IsRunning { get; set; }

        /// <summary> Launch the service in console mode. </summary>
        void StartService();

        /// <summary> Stop the service in console mode. </summary>
        void StopService();
    }
}
